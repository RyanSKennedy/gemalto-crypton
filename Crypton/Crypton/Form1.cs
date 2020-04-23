using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aladdin.HASP;
using System.Xml.Linq;

namespace Crypton
{
    public partial class FormMain : Form
    {
        public string keyId;
        public string productId;
        public XDocument keyInfo;
        public XDocument productInfo;
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonLoginLogout_Click(object sender, EventArgs e)
        {
            if (Variables.myStatus != HaspStatus.StatusOk)
            {
                Variables.myStatus = Variables.myHasp.Login(Variables.vendorCode["DEMOMA"]);
                if (Variables.myStatus == HaspStatus.StatusOk)
                {
                    buttonLoginLogout.Text = "Logout";
                    linkLabelLicenseStatus.Text = "Status OK!";
                    keyInfo = XDocument.Parse(GetSessionInfo("<haspformat format=\"keyinfo\"/>"));
                    productInfo = XDocument.Parse(GetSessionInfo(Variables.formatForGetProductId));
                    keyId = keyInfo.Descendants().FirstOrDefault(p => p.Name.LocalName == "haspid").Value;
                    productId = productInfo.Descendants().FirstOrDefault(p => p.Name.LocalName == "id").Value;
                    linkLabelKeyInfo.Text = keyId;

                    if (keyInfo.Descendants().Where(p => p.Name.LocalName == "address").Count() > 0)
                    {
                        labelNumberOfDaysForDetach.Enabled = true;
                        numericUpDownDaysForDetach.Enabled = true;
                    }
                    
                    labelIntro.Text = "Login successfully!";
                    labelIntro.ForeColor = Color.Green;
                    panelMain.Enabled = true;
                    labelCurrentLicense.Enabled = true;
                    linkLabelLicenseStatus.Enabled = true;
                    labelKeyInfo.Enabled = true;
                    linkLabelKeyInfo.Enabled = true;
                }
                else 
                {
                    linkLabelLicenseStatus.Text = "Login Error: " + Variables.myStatus.ToString();
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
                linkLabelLicenseStatus.Text = "...";
                linkLabelKeyInfo.Text = "...";
                textBoxSourceText.Text = "";
                textBoxResult.Text = "";
                labelIntro.ForeColor = Color.Black;
                panelMain.Enabled = false;
                labelNumberOfDaysForDetach.Enabled = false;
                numericUpDownDaysForDetach.Value = 0;
                numericUpDownDaysForDetach.Enabled = true;
                buttonDetach.Enabled = false;
                labelCurrentLicense.Enabled = false;
                linkLabelLicenseStatus.Enabled = false;
                labelKeyInfo.Enabled = false;
                linkLabelKeyInfo.Enabled = false;
            }
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
            var myId = GetInfo(Variables.scopeForLocal, Variables.formatForGetId);

            string info = null;
            int detachingTime = (Convert.ToInt32(numericUpDownDaysForDetach.Value) * 24 * 60 * 60);

            Variables.myStatus = Hasp.Transfer(Variables.actionForDetach.Replace("{PRODUCT_ID}", productId).Replace("{NUMBER_OF_SECONDS}", detachingTime.ToString()), Variables.scopeForSpecificKeyId.Replace("{KEY_ID}", keyId), Variables.vendorCode["DEMOMA"], myId, ref info);

            if (Variables.myStatus == HaspStatus.StatusOk)
            {
                // hasp_update
                string ack = null;
                Variables.myStatus = Hasp.Update(info, ref ack);

                if (Variables.myStatus == HaspStatus.StatusOk)
                {
                    //handle error
                    MessageBox.Show(Variables.myStatus.ToString(), "Detaching apply update error!");
                }
            }
            else 
            {
                //handle error
                MessageBox.Show(Variables.myStatus.ToString(), "Detaching error!");
            }
        }

        private void buttonClearResults_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
        }

        private void linkLabelLicenseStatus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(GetSessionInfo("<haspformat format=\"sessioninfo\"/>"), "Session Info");
        }

        private void linkLabelKeyInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(GetSessionInfo("<haspformat format=\"keyinfo\"/>"), "Key Info");
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

        public string GetSessionInfo(string format)
        {
            string info = null;
            if (Variables.myStatus == HaspStatus.StatusOk)
            {
                Variables.myStatus = Variables.myHasp.GetSessionInfo(format, ref info);
                if (Variables.myStatus == HaspStatus.StatusOk)
                {
                    return info;
                }
                else
                {
                    return Variables.myStatus.ToString();
                }
            }

            return Variables.myStatus.ToString();
        }

        public string GetInfo(string scope, string format)
        {
            string info = null;
            HaspStatus getRecipientStatus = HaspStatus.AlreadyLoggedOut;
            if (Variables.myStatus == HaspStatus.StatusOk)
            {
                getRecipientStatus = Hasp.GetInfo(scope, format, Variables.vendorCode["DEMOMA"], ref info);
                if (getRecipientStatus == HaspStatus.StatusOk)
                {
                    return info;
                }
                else
                {
                    return getRecipientStatus.ToString();
                }
            }
            return getRecipientStatus.ToString();
        }
    }
}
