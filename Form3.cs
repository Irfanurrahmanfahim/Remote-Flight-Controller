using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Remote_Flight_Controller
{
    public partial class startingform : Form
    {
        //creating an object of startingform for connecting multiple forms
        public static startingform instance;

        //initializing form components
        public startingform()
        {
            InitializeComponent();
            instance = this;
        }

        //function to locate the FlightSimulator.exe file to start it
        private void serveropenbtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Set the title of the dialog
                openFileDialog.Title = "Select a File";

                // Set the file filter to specify the allowed file types
                openFileDialog.Filter = "All files (*.*)|*.*";

                // Show the dialog and check if the user clicked OK
                DialogResult result = openFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string selectedFile = openFileDialog.FileName;    //getting the full file path
                    serveropen.Text = selectedFile;
                }
            }
        }

        //function to get the full path where Blackbox.csv file will be saved
        private void blackboxpathbtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog serverpathbrowser = new FolderBrowserDialog())
            {
                // Set the title of the dialog
                serverpathbrowser.Description = "Select a folder";

                DialogResult result = serverpathbrowser.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Get the selected folder
                    string selectedFolder = serverpathbrowser.SelectedPath;
                    blackboxpath.Text = selectedFolder;
                }
            }
        }

        //function to enable or disable gui elements based on user input
        private void manualbox_CheckedChanged(object sender, EventArgs e)
        {
            if (manualbox.Checked)
            {
                serveropen.Enabled = false;
                serveropenbtn.Enabled = false;
            }
            else
            {
                serveropen.Enabled = true;
                serveropenbtn.Enabled = true;
            }
        }

        //function to open the FlightSimulator.exe and pass the blackbox save location to the main form
        private void acceptbtn_Click(object sender, EventArgs e)
        {
            //if manualbox is checked, it will only pass the blackbox save path to the main form
            if (manualbox.Checked)
            {
                if (Directory.Exists(blackboxpath.Text))
                {
                    RemoteFlightController.instance.blackboxpath = blackboxpath.Text.ToString();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Blackbox Save File Path does not exist. Insert a Valid File Path.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                serveropen.Enabled = true;
                serveropenbtn.Enabled = true;

                //If both the file and the path exists, then it will pass the details to the main form
                if (File.Exists(serveropen.Text))  //checking if the file exists
                {
                    RemoteFlightController.instance.serverpath = serveropen.Text.ToString();
                }
                else
                {
                    MessageBox.Show("File does not exist. Select correct file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                if (Directory.Exists(blackboxpath.Text))  //checking if the directory path exists
                {
                    RemoteFlightController.instance.blackboxpath = blackboxpath.Text.ToString();
                }
                else
                {
                    MessageBox.Show("Blackbox Save File Path does not exist. Insert a Valid File Path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if(File.Exists(serveropen.Text) && Directory.Exists(blackboxpath.Text))
                {
                    if (RemoteFlightController.instance.serverpath != null)
                    {
                        Process.Start(RemoteFlightController.instance.serverpath);
                    }
                    this.Close();
                }
            }
        }
    }
}

   