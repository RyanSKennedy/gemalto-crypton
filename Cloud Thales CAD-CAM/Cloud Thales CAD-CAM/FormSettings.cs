using System;
using System.Windows.Forms;

namespace Cloud_Thales_CAD_CAM
{
    public partial class FormSettings : Form
    {
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
        }
    }
}
