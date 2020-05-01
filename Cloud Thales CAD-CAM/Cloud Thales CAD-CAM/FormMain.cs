﻿using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;
using Aladdin.HASP;


namespace Cloud_Thales_CAD_CAM
{
    public partial class FormMain : Form
    {
        public string vendorId;
        public static string parentKeyId;
        public string childKeyId;
        public string productId;
        public string productName;
        public string featureId;
        public string featureName;
        public XDocument keyInfo;
        public XDocument productInfo;
        public XDocument featureInfo;
        FormSettings SettingsWindow;

        public FormMain()
        {
            InitializeComponent();

            SettingsWindow = new FormSettings();
        }

        private void buttonLoginLogout_Click(object sender, EventArgs e)
        {
            if (Variables.myStatus != HaspStatus.StatusOk)
            {
                if (Variables.connectToSpecifyKeyId == true && !String.IsNullOrEmpty(Variables.specifyKeyId))
                {
                    Variables.myStatus = Variables.myHasp.Login(Variables.vendorCode[Variables.vendorCode.Keys.Where(k => k.Key == "DEMOMA").FirstOrDefault()], Variables.scopeForSpecificKeyId.Replace("{KEY_ID}", Variables.specifyKeyId));
                }
                else 
                {
                    Variables.myStatus = Variables.myHasp.Login(Variables.vendorCode[Variables.vendorCode.Keys.Where(k => k.Key == "DEMOMA").FirstOrDefault()], Variables.scopeForLocal);

                    if (Variables.myStatus != HaspStatus.StatusOk)
                    {
                        Variables.myStatus = Variables.myHasp.Login(Variables.vendorCode[Variables.vendorCode.Keys.Where(k => k.Key == "DEMOMA").FirstOrDefault()]);
                    }
                }

                if (Variables.myStatus == HaspStatus.StatusOk)
                {
                    buttonLoginLogout.Text = "Logout";
                    keyInfo = XDocument.Parse(MyGlobalMethods.GetSessionInfo("<haspformat format=\"keyinfo\"/>"));
                    productInfo = XDocument.Parse(MyGlobalMethods.GetSessionInfo(Variables.formatForGetProductId));
                    featureInfo = XDocument.Parse(MyGlobalMethods.GetSessionInfo(Variables.formatForGetFeatureId));
                    parentKeyId = keyInfo.Descendants().FirstOrDefault(p => p.Name.LocalName == "haspid").Value;
                    productId = productInfo.Descendants().FirstOrDefault(p => p.Name.LocalName == "id").Value;
                    productName = productInfo.Descendants().FirstOrDefault(p => p.Name.LocalName == "name").Value;
                    featureId = featureInfo.Descendants().FirstOrDefault(f => f.Name.LocalName == "id").Value;
                    featureName = featureInfo.Descendants().FirstOrDefault(f => f.Name.LocalName == "name").Value;
                    linkLabelKeyInfo.Text = parentKeyId;
                    linkLabelLicenseInfo.Text = productName + " -> " + featureName + " (FID: " + featureId + ")";
                    labelLoginStatusCode.Text = Variables.myStatus.ToString();

                    if (keyInfo.Descendants().Where(p => p.Name.LocalName == "address").Count() > 0)
                    {
                        labelNumberOfDaysForDetach.Enabled = true;
                        numericUpDownDaysForDetach.Enabled = true;
                        buttonDetach.Enabled = true;
                        buttonCancelDetach.Enabled = false;
                    }
                    else
                    {
                        labelNumberOfDaysForDetach.Enabled = false;
                        numericUpDownDaysForDetach.Enabled = false;
                        buttonDetach.Enabled = false;
                        buttonCancelDetach.Enabled = true;
                    }

                    labelIntro.Text = "Login successfully!";
                    labelIntro.ForeColor = Color.Green;
                    panelMain.Enabled = true;
                    labelLoginStatus.Enabled = true;
                    labelLoginStatusCode.Enabled = true;
                    labelCurrentLicense.Enabled = true;
                    linkLabelLicenseInfo.Enabled = true;
                    labelKeyInfo.Enabled = true;
                    linkLabelKeyInfo.Enabled = true;
                    buttonCheckAvailableLicenses.Enabled = false;
                }
                else 
                {
                    labelLoginStatusCode.Text = Variables.myStatus.ToString();
                    labelIntro.Text = "Please login first!";
                    labelIntro.ForeColor = Color.Black;
                    panelMain.Enabled = false;
                }
            } 
            else 
            {
                Variables.myStatus = Variables.myHasp.Logout();
                Variables.myStatus = HaspStatus.AlreadyLoggedOut;
                buttonLoginLogout.Text = "Login";
                labelIntro.Text = "Please login first!";
                linkLabelLicenseInfo.Text = "...";
                linkLabelKeyInfo.Text = "...";
                labelLoginStatusCode.Text = "...";
                textBoxSourceText.Text = "";
                textBoxResult.Text = "";
                labelIntro.ForeColor = Color.Black;
                panelMain.Enabled = false;
                labelNumberOfDaysForDetach.Enabled = false;
                numericUpDownDaysForDetach.Value = 0;
                numericUpDownDaysForDetach.Enabled = true;
                buttonDetach.Enabled = false;
                buttonCancelDetach.Enabled = false;
                labelLoginStatus.Enabled = false;
                labelLoginStatusCode.Enabled = false;
                labelCurrentLicense.Enabled = false;
                linkLabelLicenseInfo.Enabled = false;
                labelKeyInfo.Enabled = false;
                linkLabelKeyInfo.Enabled = false;
                buttonCheckAvailableLicenses.Enabled = true;
            }
        }

        private void buttonCheckAvailableLicenses_Click(object sender, EventArgs e)
        {
            var availableLicenses = MyGlobalMethods.GetInfo(Variables.scopeUnfiltered, Variables.formatForGetAvailableLicenses, true);

            MessageBox.Show(availableLicenses, "Available Licenses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Variables.myStatus = HaspStatus.AlreadyLoggedOut;
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            SettingsWindow.ShowDialog();
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
            byte[] myData = System.Text.Encoding.Unicode.GetBytes(textBoxSourceText.Text);
            Variables.myStatus = Variables.myHasp.Encrypt(myData);

            if (Variables.myStatus == HaspStatus.StatusOk)
            {
                textBoxResult.Text = System.Text.Encoding.Unicode.GetString(myData);
            }
            else 
            {
                textBoxResult.Text = "Error: " + Variables.myStatus.ToString();
            }
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
            byte[] myData = System.Text.Encoding.Unicode.GetBytes(textBoxSourceText.Text);
            Variables.myStatus = Variables.myHasp.Decrypt(myData);

            if (Variables.myStatus == HaspStatus.StatusOk)
            {
                textBoxResult.Text = System.Text.Encoding.Unicode.GetString(myData);
            }
            else
            {
                textBoxResult.Text = "Error: " + Variables.myStatus.ToString();
            }
        }

        private void buttonDetach_Click(object sender, EventArgs e)
        {
            var myId = MyGlobalMethods.GetInfo(Variables.scopeForLocal, Variables.formatForGetId);

            string info = null;
            int detachingTime = (Convert.ToInt32(numericUpDownDaysForDetach.Value) * 24 * 60 * 60);

            HaspStatus myDetachStatus = Hasp.Transfer(Variables.actionForDetach.Replace("{PRODUCT_ID}", productId).Replace("{NUMBER_OF_SECONDS}", detachingTime.ToString()), Variables.scopeForSpecificKeyId.Replace("{KEY_ID}", parentKeyId), Variables.vendorCode[Variables.vendorCode.Keys.Where(k => k.Key == "DEMOMA").FirstOrDefault()], myId, ref info);

            if (myDetachStatus == HaspStatus.StatusOk)
            {
                // hasp_update
                string ack = null;
                HaspStatus myUpdateStatus = Hasp.Update(info, ref ack);

                if (myUpdateStatus == HaspStatus.StatusOk)
                {
                    //handle success
                    var tmpAvaliablesKeys = XDocument.Parse(MyGlobalMethods.GetInfo(Variables.scopeForLocal, Variables.formatForGetAvailableLicenses));
                    foreach (var el in tmpAvaliablesKeys.Root.Elements("hasp")) 
                    {
                        foreach (var el2 in el.Elements("feature"))
                        {
                            if (el2.Attribute("id").Value == Variables.myFeature.FeatureId.ToString())
                            {
                                childKeyId = el.Attribute("id").Value;
                                break;
                            }
                        }

                        if (String.IsNullOrEmpty(childKeyId)) 
                        {
                            break;
                        }
                    }

                    MessageBox.Show("Current status of the opperation is: " + myUpdateStatus.ToString() + Environment.NewLine + "Please, re-login in appplication, for using locally license.", "Successfully Detached!");
                }
                else 
                {
                    //handle error
                    MessageBox.Show(myUpdateStatus.ToString(), "Detaching apply update error!");
                }
            }
            else 
            {
                if (myDetachStatus == HaspStatus.InvalidDuration && !Variables.useUrl)
                {
                    try
                    {
                        var tmpAvaliablesKeys = XDocument.Parse(MyGlobalMethods.GetInfo(Variables.scopeForLocal, Variables.formatForGetAvailableLicenses));
                        foreach (var el in tmpAvaliablesKeys.Root.Elements("hasp"))
                        {
                            foreach (var el2 in el.Elements("feature"))
                            {
                                if (el2.Attribute("id").Value == Variables.myFeature.FeatureId.ToString())
                                {
                                    childKeyId = el.Attribute("id").Value;
                                    break;
                                }
                            }

                            if (String.IsNullOrEmpty(childKeyId))
                            {
                                break;
                            }
                        }

                        string myCancelDetachStatus = MyGlobalMethods.CancelDetachViaUrl(productId, childKeyId);

                        if (myCancelDetachStatus == HttpStatusCode.OK.ToString())
                        {
                            myDetachStatus = Hasp.Transfer(Variables.actionForDetach.Replace("{PRODUCT_ID}", productId).Replace("{NUMBER_OF_SECONDS}", detachingTime.ToString()), Variables.scopeForSpecificKeyId.Replace("{KEY_ID}", parentKeyId), Variables.vendorCode[Variables.vendorCode.Keys.Where(k => k.Key == "DEMOMA").FirstOrDefault()], myId, ref info);

                            if (myDetachStatus == HaspStatus.StatusOk)
                            {
                                // hasp_update
                                string ack = null;
                                HaspStatus myUpdateStatus = Hasp.Update(info, ref ack);

                                if (myUpdateStatus == HaspStatus.StatusOk)
                                {
                                    //handle success
                                    MessageBox.Show("Current status of the opperation is: " + myUpdateStatus.ToString() + Environment.NewLine + "Please, re-login in appplication, for using locally license.", "Successfully Detached!");
                                }
                                else
                                {
                                    //handle error
                                    MessageBox.Show(myUpdateStatus.ToString(), "Detaching apply update error!");
                                }
                            }
                            else
                            {
                                //handle error
                                MessageBox.Show(myDetachStatus.ToString(), "Re-Detaching error!");
                            }
                        }
                        else
                        {
                            //handle error
                            MessageBox.Show("Status request: " + myCancelDetachStatus + Environment.NewLine + "Something goes wrong... Please, try again later!", "Cancel Detaching error (In Re-Detach)!");
                        }
                    }
                    catch 
                    {
                        // do nothing...
                        MessageBox.Show(myDetachStatus.ToString(), "Detaching error!");
                    }
                }
                else 
                {
                    //handle error
                    MessageBox.Show(myDetachStatus.ToString(), "Detaching error!");
                }
            }
        }

        private void buttonCancelDetach_Click(object sender, EventArgs e)
        {
            if (Variables.useUrl)
            {
                string myCancelDetachStatus = MyGlobalMethods.CancelDetachViaUrl(productId);

                if (myCancelDetachStatus == HttpStatusCode.OK.ToString())
                {
                    buttonLoginLogout.PerformClick();

                    MessageBox.Show("Current status of the opperation is: " + myCancelDetachStatus + Environment.NewLine + "Please, re-login in appplication, for using locally license.", "Successfully Canceled Detaching license!");

                }
                else 
                {
                    //handle error
                    MessageBox.Show("Status request: " + myCancelDetachStatus + Environment.NewLine + "Something goes wrong... Please, try again later!", "Cancel Detaching error!");
                }
            }
            else 
            {
                string myCancelDetachStatus = MyGlobalMethods.CancelDetachViaLicensingApi(parentKeyId);

                if (myCancelDetachStatus == HaspStatus.StatusOk.ToString())
                {
                    buttonLoginLogout.PerformClick();

                    MessageBox.Show("Current status of the opperation is: " + myCancelDetachStatus + Environment.NewLine + "Please, re-login in appplication, for using locally license.", "Successfully Canceled Detaching license!");
                }
                else
                {
                    //handle error
                    MessageBox.Show(myCancelDetachStatus, "Cancel Detaching error!");
                }
            }
        }

        private void buttonClearResults_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
        }

        private void linkLabelLicenseStatus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(MyGlobalMethods.GetSessionInfo("<haspformat format=\"sessioninfo\"/>"), "Session Info");
        }

        private void linkLabelKeyInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(MyGlobalMethods.GetSessionInfo("<haspformat format=\"keyinfo\"/>"), "Key Info");
        }

        private void numericUpDownDaysForDetach_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownDaysForDetach.Value > 0)
            {
                buttonDetach.Enabled = true;
            }
            else
            {
                buttonDetach.Enabled = false;
            }
        }

        private void textBoxSourceText_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSourceText.Text.Length > 0)
            {
                buttonEncrypt.Enabled = true;
                buttonDecrypt.Enabled = true;
            }
            else
            {
                buttonEncrypt.Enabled = false;
                buttonDecrypt.Enabled = false;
            }
        }
    }
}