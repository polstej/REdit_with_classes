using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REdit_with_classes
{
    public partial class AllSettings : Form
    {
        public AllSettings()
        {
            InitializeComponent();
        }

        private void btnUserSetUp_Click(object sender, EventArgs e)
        {
            //launch User Settings window form
            SettingsForm settingsform = new SettingsForm();
            settingsform.ShowDialog();
        }
    }
}
