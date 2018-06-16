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
    public partial class SettingsForm : Form
    {


        public SettingsForm()
        {
            InitializeComponent();
        }
        public string anatomy { get; set; }
        public string modality { get; set; }
        public string folderLocation { get; set; }
        public string appName { get; set; }


        /*private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                txtFolderPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        */

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            SettingsConfigurer configuration = new SettingsConfigurer
                (txtBodyKeyword.Text, txtTechniqueKeyword.Text);
            string word1 = configuration.BodyHeader;
            MessageBox.Show(word1);
;


            MessageBox.Show("Body header: " + configuration.BodyHeader + "Technique: " +
                configuration.TechniqueHeader);
            //check that all fields are not empty (does NOT
            //check if info is otherwise appropriate..
            //develop that logic later
            if ((txtAppName.Text != "")
                && (txtBodyKeyword.Text != "")
                //&& (txtFolderPath.Text != "")
                && (txtTechniqueKeyword.Text != "")
                )  //if fields filled out then assign variables and save Settings file
            {
                anatomy = txtBodyKeyword.Text;
                modality = txtTechniqueKeyword.Text;
                //folderLocation = txtFolderPath.Text;
                appName = txtAppName.Text;

                //format the variables in strings separated by lines for saving in text file
                string settingsString = anatomy  + 
                    Environment.NewLine+ modality+
                    //Environment.NewLine + folderLocation + 
                    Environment.NewLine + appName;

                //set the directory path for all REDIT files under the signed in Username
                //this should probably be put elsewhere. IT is now also in the main form
                string reditDirectory = @" C:\Users\"+ Environment.UserName + @"\REdit files";
               

                string settingsPath= reditDirectory+ @"\REdit settings";
                
                //create or overwrite Settings file
                if (File.Exists(settingsPath)==false) //If doesn't exist, create and write to file
                {
                    File.AppendAllText(settingsPath, settingsString);
                }
                else
                { 
                    File.WriteAllText(settingsPath, settingsString);//if does exist, overrite
                }
                                      
                //Close form after data saved to file
                Close();
                
            }
            else
            {
                MessageBox.Show("Not all fields are filled out.  Please complete.");

            }
        }

        private void FileTerms_Click(object sender, EventArgs e)
        {
            //FileTermsForm fileTerms = new FileTermsForm();
            //settingsform.ShowDialog();
        }

        private void txtBodyKeyword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
