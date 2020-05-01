using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cloud_Thales_CAD_CAM
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();

            comboBoxMethodsForDetach.SelectedIndex = 0;
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            numericUpDownFeatureId.Value = Variables.myFeature.FeatureId;
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
            if (comboBoxMethodsForDetach.SelectedItem.ToString() == "Via ACC Url (Recommended)")
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
