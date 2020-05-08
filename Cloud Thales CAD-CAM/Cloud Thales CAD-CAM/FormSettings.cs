using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Cloud_Thales_CAD_CAM
{
    public partial class FormSettings : Form
    {
        public ToolTip toolTipTextBoxAddNewBatchCode = new ToolTip();
        public FormSettings()
        {
            InitializeComponent();
;
            foreach (var el in FormMain.alpPackSourceXdocument.Root.Elements("AvailableLanguages")) 
            {
                foreach (var el2 in el.Elements("language")) 
                {
                    comboBoxSelectLanguage.Items.Add(el2.Value);
                }
            }

            foreach (var el3 in Variables.vendorCode) 
            {
                comboBoxBatchCode.Items.Add(el3.Key.Key);
            }

            comboBoxBatchCode.SelectedIndex = comboBoxBatchCode.FindString(Properties.Settings.Default.CurrentBatchCode);

            toolTipTextBoxAddNewBatchCode.SetToolTip(textBoxAddNewBatchCode, MultiLanguage.ErrorMessageReplacer(FormMain.language.Key, "Format for input: ") + Variables.formatForInputToolTip);
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            FormMain.sForm = (FormSettings)Application.OpenForms["FormSettings"];
            bool isSetAlpFormAbout = FormMain.alp.SetLanguage(FormMain.language.Key, this.Controls, FormMain.sForm);

            numericUpDownFeatureId.Value = Variables.myFeature.FeatureId;

            comboBoxSelectLanguage.SelectedIndex = comboBoxSelectLanguage.FindString(FormMain.language.Value);
            comboBoxMethodsForDetach.SelectedIndex = Variables.useUrl ? 0 : 1;
        }

        private void numericUpDownFeatureId_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.FID = Convert.ToInt32(numericUpDownFeatureId.Value);
            Properties.Settings.Default.Save();

            Variables.myFeature = new Aladdin.HASP.HaspFeature(Convert.ToInt32(numericUpDownFeatureId.Value));
            Variables.myHasp = new Aladdin.HASP.Hasp(Variables.myFeature);
        }

        private void checkBoxSpecifyKeyIdEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSpecifyKeyIdEnable.Checked == true)
            {
                textBoxSpecifyKeyId.Enabled = true;
                Variables.connectToSpecifyKeyId = true;
            }
            else 
            {
                textBoxSpecifyKeyId.Enabled = false;
                Variables.connectToSpecifyKeyId = false;
            }
        }

        private void textBoxSpecifyKeyId_TextChanged(object sender, EventArgs e)
        {
            Variables.specifyKeyId = textBoxSpecifyKeyId.Text;
        }

        private void textBoxAddNewBatchCode_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxAddNewBatchCode.Text))
            {
                buttonAddNewBatchCode.Enabled = true;
            }
            else
            {
                buttonAddNewBatchCode.Enabled = false;
            }
        }

        private void comboBoxMethodsForDetach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMethodsForDetach.SelectedItem.ToString() == "ACC Url (Recommended)")
            {
                Variables.useUrl = true;
            }
            else
            {
                Variables.useUrl = false;
            }
        }

        private void comboBoxSelectLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Language = comboBoxSelectLanguage.SelectedItem.ToString();
            Properties.Settings.Default.Save();

            FormMain.language = MultiLanguage.ResetLanguage(FormMain.alpPackSourceXdocument);
            FormMain.alp.SetLanguage(FormMain.language.Key, this.Controls, FormMain.sForm);
            FormMain.alp.SetLanguage(FormMain.language.Key, FormMain.mForm.Controls, FormMain.mForm);
            toolTipTextBoxAddNewBatchCode.SetToolTip(textBoxAddNewBatchCode, MultiLanguage.ErrorMessageReplacer(FormMain.language.Key, "Format for input: ") + Variables.formatForInputToolTip);
        }

        private void comboBoxBatchCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CurrentBatchCode = comboBoxBatchCode.SelectedItem.ToString();
            Properties.Settings.Default.Save();
            Variables.currentBatchCode = comboBoxBatchCode.SelectedItem.ToString();

            if (comboBoxBatchCode.SelectedItem.ToString() != "DEMOMA")
            {
                buttonDeleteBatchCode.Enabled = true;
            }
            else 
            {
                buttonDeleteBatchCode.Enabled = false;
            }
        }

        private void buttonDeleteBatchCode_Click(object sender, EventArgs e)
        {
            Variables.vendorCode.Remove(Variables.vendorCode.Keys.Where(k => k.Key == comboBoxBatchCode.SelectedItem.ToString()).FirstOrDefault());
            Properties.Settings.Default.BatchCodes.Root.Elements("vendor").Where(d => d.Element("batchCode").Value == comboBoxBatchCode.SelectedItem.ToString()).FirstOrDefault().Remove();
            comboBoxBatchCode.Items.RemoveAt(comboBoxBatchCode.SelectedIndex);

            comboBoxBatchCode.SelectedIndex = 0;
            Variables.currentBatchCode = "DEMOMA";
            Properties.Settings.Default.CurrentBatchCode = "DEMOMA";
            Properties.Settings.Default.Save();
        }

        private void buttonAddNewBatchCode_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBoxAddNewBatchCode.Text, Variables.regExForValidatingNewBatchCode))
            {
                var tmpBatchCodeData = textBoxAddNewBatchCode.Text.Split("-:".ToCharArray(), 3);
                string tmpBatchCode = tmpBatchCodeData[0];
                string tmpVendorId = tmpBatchCodeData[1];
                string tmpVendorCode = tmpBatchCodeData[2];

                if (tmpBatchCode != "" && tmpVendorId != "" && tmpVendorCode != "" && Variables.vendorCode.ContainsKey(new KeyValuePair<string, string>(tmpBatchCode, tmpVendorId)) == false) 
                    Variables.vendorCode.Add(new KeyValuePair<string, string>(tmpBatchCode, tmpVendorId), tmpVendorCode);

                comboBoxBatchCode.Items.Add(tmpBatchCode);

                var tmpXElement = new XElement("vendor");
                tmpXElement.Add(new XElement("batchCode", tmpBatchCode));
                tmpXElement.Add(new XElement("vendorId", tmpVendorId));
                tmpXElement.Add(new XElement("vendorCode", tmpVendorCode));
                Properties.Settings.Default.BatchCodes.Root.Add(tmpXElement);
                Properties.Settings.Default.Save();

                textBoxAddNewBatchCode.Text = "";
            }
            else
            {
                MessageBox.Show(MultiLanguage.ErrorMessageReplacer(FormMain.language.Key, @"Incorrect new Batch code! Maybe incorrect format of input string. Please check your data, you should using this format: ") + Variables.formatForInputToolTip + "(Regex: " + Variables.regExForValidatingNewBatchCode + ")", MultiLanguage.ErrorMessageReplacer(FormMain.language.Key, "Incorrect Vendor Data!"));
            }
        }
    }
}
