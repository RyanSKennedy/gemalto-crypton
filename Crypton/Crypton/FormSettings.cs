using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypton
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            numericUpDownFeatureId.Value = Variables.myFeature.FeatureId;
            textBoxAdminApiPassword.Text = Variables.adminApiPassword;
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

        private void checkBoxUseAdminApi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUseAdminApi.Checked == true)
            {
                Variables.useAdminApi = true;
                textBoxAdminApiPassword.Enabled = true;
            }
            else 
            {
                Variables.useAdminApi = false;
                textBoxAdminApiPassword.Enabled = false;
            }
        }

        private void textBoxAdminApiPassword_TextChanged(object sender, EventArgs e)
        {
            Variables.adminApiPassword = textBoxAdminApiPassword.Text;
        }

        private void checkBoxUseUrlForDetachLicense_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUseUrlForDetachLicense.Checked == true)
            {
                Variables.useUrl = true;
            }
            else
            {
                Variables.useUrl = false;
            }
        }
    }
}
