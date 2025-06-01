using System;
using System.Windows.Forms;

namespace Remote_Flight_Controller
{
    public partial class autopilotform : Form
    {
        //creating an object of autopilotform for connecting multiple forms
        public static autopilotform instance;


        //initializing form components
        public autopilotform()
        {
            InitializeComponent();
            instance = this;
        }

        //function to pass the set autopliot altitude to the main form if it is in the range
        private void autobtn_Click(object sender, EventArgs e)
        {
            if (double.Parse(alttext.Text) >= 1500 && double.Parse(alttext.Text) <= 15000)
            {
                RemoteFlightController.instance.autoaltitude = double.Parse(alttext.Text);
                this.Close(); //closing the autopilot form
            }
            else
            {
                MessageBox.Show("Autopilot Altitude can be set between 1500 feets and 15000 feets.","Autopilot Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        //function to close the autopilot form
        private void autoclosebtn_Click(object sender, EventArgs e)
        {
            this.Close(); //closing the autopilot form
        }
    }
}
