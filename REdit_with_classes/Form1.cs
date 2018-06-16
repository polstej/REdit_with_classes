using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace REdit_with_classes
{
    public partial class REdit_Main_Form : Form
    {
        
        public REdit_Main_Form()
        {
            InitializeComponent();

            //initialize hard-coded directory location for REDIT
            string reditDirectory = 
                @" C:\Users\" + Environment.UserName + @"\REdit files";
            
            //check to see if REDIT directory exists.  If not, then launch the 
            //configuration/settings form
            if (Directory.Exists(reditDirectory))
            {

            }
            else
            {
                MessageBox.Show("It looks like this may be your first time " +
                    "using REdit.  Click OK to configure your settings.");
                Directory.CreateDirectory(reditDirectory);
                SettingsForm settingsform = new SettingsForm();
                settingsform.ShowDialog();
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            //upon clicking settings button, launch settings form
            AllSettings allsettingsform = new AllSettings();
            allsettingsform.ShowDialog();
        }
    }
}
