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
                    linkLabelKeyInfo.Text = XDocument.Parse(GetSessionInfo("<haspformat format=\"keyinfo\"/>")).Descendants().FirstOrDefault(p => p.Name.LocalName == "haspid").Value;
                    labelIntro.Text = "Login successfully!";
                    labelIntro.ForeColor = Color.Green;
                    panelMain.Enabled = true;
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

        }

        private void linkLabelLicenseStatus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(GetSessionInfo("<haspformat format=\"sessioninfo\"/>"), "Session Info");
        }

        private void buttonClearResults_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
        }

        private void linkLabelKeyInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(GetSessionInfo("<haspformat format=\"keyinfo\"/>"), "Key Info");
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
    }
}
