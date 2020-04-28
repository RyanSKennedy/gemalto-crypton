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
        }

        private void numericUpDownFeatureId_ValueChanged(object sender, EventArgs e)
        {
            Variables.myFeature = new Aladdin.HASP.HaspFeature(Convert.ToInt32(numericUpDownFeatureId.Value));
            Variables.myHasp = new Aladdin.HASP.Hasp(Variables.myFeature);
        }
    }
}
