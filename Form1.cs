//Remote Flight Controller - Md Irfanur Rahman Fahim - 30074676
using System;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Web.Script.Serialization;
using System.IO;
using LiveCharts.WinForms;
using System.Windows.Media;
using System.Security.AccessControl;
using System.Web.UI.WebControls;
using Microsoft.Win32;
using System.Windows;
using System.Net.Http;
using System.Diagnostics;



namespace Remote_Flight_Controller
{
    public partial class RemoteFlightController : Form
    {
        TcpClient client;   //declaring tcpclient

        
        //initializing threads
        Thread listenthread = null;
        Thread autopilotthread = null;


        //creating an object of RemoteFlightController for connecting multiple forms
        public static RemoteFlightController instance;


        //declaring variables
        #region variables
        public string blackboxpath;
        public string serverpath;
        public double autoaltitude = 0;
        double currentaltitude;
        double currentpitch;
        string controlinfo;
        bool autopilotstatus = false;
        #endregion


        //declaring delegates with their respective events
        #region delegates
        public delegate void delegatecontrol(ControlsUpdate updatecontrols);
        public event delegatecontrol updated;

        public delegate void delegatewarning(int wcode);
        public event delegatewarning warn;

        public delegate void datacollection(TelemetryUpdate datareceived);
        public event datacollection distributedata;

        public delegate Task updateweather();
        #endregion


        //initializing form components
        public RemoteFlightController()
        {
            InitializeComponent();

            instance = this;

            datagrid();
            initializeguage();
            findipaddress();


            updated += control;
            warn += warning; 
            distributedata += showdata;

            //initializing the starting form and displaying it
            startingform start = new startingform();    
            start.ShowDialog();
            

            porttext.Text = "9999";
            controlinfo = "User";
            disconnectbtn.Enabled = false;
            controlpanel.Enabled = false;
            turnoffauto.Enabled = false;
            autopilotbtn.Enabled = false;
        }


        //function to find the ip address of the system by using built in dns methods
        void findipaddress()
        {
            try
            {
                iptext.Text = Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error: " + ex.Message, "Error", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Error);
            }
        }


        //function to initialize the guages
        void initializeguage()
        {
            Brush needle = new SolidColorBrush(Colors.Red);

            altitudeg.FromValue = 0;
            altitudeg.ToValue = 10000;
            altitudeg.BackColor = System.Drawing.Color.BurlyWood;
            altitudeg.Wedge = 200;
            altitudeg.NeedleFill = needle;

            pitchg.FromValue = -90;
            pitchg.ToValue = +90;
            pitchg.BackColor = System.Drawing.Color.BurlyWood;
            pitchg.Wedge = 200;
            pitchg.NeedleFill = needle;

            speedg.FromValue = 0;
            speedg.ToValue = 800;
            speedg.BackColor = System.Drawing.Color.BurlyWood;
            speedg.Wedge = 200;
            speedg.NeedleFill= needle;  

        }


        //struct for creating ControlsUpdate objects to send data
        public struct ControlsUpdate
        {
            public double Throttle;    //Current throttle setting as a percentage 
            public double ElevatorPitch;    //Current Elevator Pitch in degrees
        }


        //struct for creating TelemetryUpdate objects to receive data
        public struct TelemetryUpdate
        {
            public double Altitude;  //Altitude in ft
            public double Speed;   //Plane's speed in Knots
            public double Pitch;   //Plane's pitch in degrees relative to horizon. Positive is planes pointing upwards, negative plane points downwards.
            public double VerticalSpeed;   //Plane's vertical speed in Feet per minute
            public double Throttle;     //Current throttle setting as a percentage 
            public double ElevatorPitch;    //Current Elevator Pitch in degrees. Positive creates upwards lift, negative downwards
            public int WarningCode;    //Warning code: 0 - No Warnings; 1 - Too Low (less than 1000ft); 2 - Stall
        }


        //function to connect remote flight controller to flight simulator
        private void connectbtn_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient();
                IPAddress ip = IPAddress.Parse(iptext.Text);  //getting the ip address from the textbox
                int port = Convert.ToInt32(porttext.Text);   //receiving and converting the port number from the textbox
                client.Connect(ip, port);

                if (client.Connected)
                {
                    statustext.Text = "Connected";
                    disconnectbtn.Enabled = true;
                    controlpanel.Enabled = true;
                    autopilotbtn.Enabled = true;
                    connectbtn.Enabled = false;
                    blackboxinitialize();
                }
                listenthread = new Thread(new ThreadStart(listen));   //initializing the listenthread to start running the listen function
                listenthread.Start();
            }
            catch (Exception ex) 
            {
                System.Windows.MessageBox.Show("Error: " + ex.Message, "Error", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Error);
            }

        }


        //function to disconnect the remote flight controller from flight simulator
        private void disconnectbtn_Click(object sender, EventArgs e)
        {
            try
            {
                autopilotstatus = false;
                if (autopilotthread != null)
                {
                    if (autopilotthread.IsAlive)
                    {
                        autopilotthread.Abort();
                    }
                }
                if (listenthread != null)
                {
                    if (listenthread.IsAlive)
                    {
                        listenthread.Abort();
                    }
                }
                client.Close();
                if (!client.Connected)
                {
                    statustext.Text = "Not Connected";
                    controlpanel.Enabled = false;
                    disconnectbtn.Enabled = false;
                    autopilotbtn.Enabled = false;
                    connectbtn.Enabled = true; 
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error: " + ex.Message, "Error", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Error);
            }
        }


        //function to receive data from the flight simulator and deserialize it
        private void listen()
        {
            NetworkStream stream = client.GetStream();
            TelemetryUpdate telemetry = new TelemetryUpdate();
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string jsonformat = null;
            while (true)
            {
                byte[] buffer = new byte[256];
                int bytenum = stream.Read(buffer, 0, buffer.Length);
                if (bytenum > 0)
                {
                    string jsonformattext = Encoding.UTF8.GetString(buffer, 0, bytenum);   // receiving the string

                    #region Validating_JSON_Data
                    int startIndex = 0;
                    int braceCount = 0;
                    for (int i = 0; i < jsonformattext.Length; i++)
                    {
                        if (jsonformattext[i] == '{')
                        {
                            if (braceCount == 0)
                            {
                                startIndex = i;
                            }
                            braceCount++;
                        }
                        else if (jsonformattext[i] == '}')
                        {
                            braceCount--;
                            if (braceCount == 0)
                            {
                                jsonformat = jsonformattext.Substring(startIndex, i - startIndex + 1);
                            }
                        }
                    }
                    #endregion

                    telemetry = serializer.Deserialize<TelemetryUpdate>(jsonformat);   //deserializing the received string to create a TelemetryUpdate object
                    distributedata?.Invoke(telemetry);     //invoking distributedata delegate event
                }
            }
        }


        //function to add the data in the datagrid and pass the data to other functions 
        void showdata(TelemetryUpdate datareceived)
        {
            if (this.InvokeRequired)
            {
                telemetrydatagrid.Invoke(new datacollection(showdata), datareceived);
            }
            else
            {
                telemetrydatagrid.Rows.Add(datareceived.Altitude.ToString("N2"), datareceived.Speed.ToString("N2"), datareceived.Pitch.ToString("N2"), datareceived.VerticalSpeed.ToString("N2"), datareceived.Throttle.ToString("N2"), datareceived.ElevatorPitch.ToString("N2"));
                telemetrydatagrid.FirstDisplayedScrollingRowIndex = telemetrydatagrid.RowCount - 1;
                warn?.Invoke(datareceived.WarningCode);    //invoking warn delegate event to process the warning code
                writetoblackbox(datareceived);     //calling writetoblackbox function to write the data in a csv file
                guages(datareceived);     //calling guages function to update the guages
                currentaltitude = datareceived.Altitude;
                currentpitch = datareceived.Pitch;
                autotext.Text = "Autopilot Altitude: " + autoaltitude.ToString() + " feets";
            }
        }


        //function to update the guages and labels to showcase the current telemetry data
        void guages(TelemetryUpdate guage)
        {
            //updating guages
            altitudeg.Value = guage.Altitude;
            pitchg.Value = guage.Pitch;
            speedg.Value = guage.Speed;

            //updating the labels
            altlbl.Text = "Altitude : " + guage.Altitude.ToString("F0") + " feets";
            pitchlbl.Text = "Pitch : " + guage.Pitch.ToString("F0") + "°";
            speedlbl.Text = "Speed : " + guage.Speed.ToString("F0") + " KNots";
            verticalspeedlbl.Text = "Vertical Speed : " + guage.VerticalSpeed.ToString("F0") + " ft/min";
            throttlelbl2.Text = "Throttle : " + guage.Throttle.ToString("F0") + "%";
            epitchlbl.Text = "Elevator Pitch : " + guage.ElevatorPitch.ToString("F0") + "°";
        }


        //function to decode the warning code to show necessary warning updates and warning indicator light
        void warning (int code)
        {
            switch (code){
                case 0:
                    warningbox.ForeColor = System.Drawing.Color.Lime;
                    warningbox.Text = "No Warning";
                    red.Visible = false;
                    green.Visible = true;
                    break;

                case 1:
                    warningbox.ForeColor = System.Drawing.Color.Red;
                    warningbox.Text = "Warning! Low Altitude - Pull Up!";
                    green.Visible = false;
                    red.Visible = true;
                    break;
                    
                case 2:
                    warningbox.ForeColor = System.Drawing.Color.Red;
                    warningbox.Text = "Warning! Stall Risk - Lower Pitch,Increase Speed! ";
                    green.Visible = false;
                    red.Visible = true;
                    break;
            }

        }


        //function to initialize the datagrid with column names
        void datagrid()
        {
            //adding columns to the datagrid
            telemetrydatagrid.Columns.Add("Altitude", "Altitude");
            telemetrydatagrid.Columns.Add("Speed", "Speed");
            telemetrydatagrid.Columns.Add("Pitch", "Pitch");
            telemetrydatagrid.Columns.Add("VerticalSpeed", "Vertical Speed");
            telemetrydatagrid.Columns.Add("Throttle", "Throttle");
            telemetrydatagrid.Columns.Add("ElevatorPitch", "Elevator Pitch");
        }


        //initializing the Blackbox.csv file
        void blackboxinitialize()
        {
            using (StreamWriter outputFile = File.AppendText(Path.Combine(blackboxpath, "Blackbox.csv")))
            {
                outputFile.WriteLine();
                outputFile.WriteLine();
                outputFile.WriteLine(string.Join(",", ("Date, Time, Altitude, Speed, Pitch, Vertical Speed, Throttle, ElevatorPitch, Warning Code, Control Info")));
            }
        }


        //function to serialize the ControlsUpdate object and send it to the Flight Simulator
        void control(ControlsUpdate controlsupdate)
        {
            try
            {
                NetworkStream stream = client.GetStream();
                JavaScriptSerializer serializer = new JavaScriptSerializer();

                string jsonformattext = serializer.Serialize(controlsupdate);   //serializing the object

                byte[] senddata = Encoding.UTF8.GetBytes(jsonformattext);
                stream.Write(senddata, 0, senddata.Length);     //sending the data to Flight Simulator

            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error: " + ex.Message, "Error", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Error);
            }
        }


        //function to update the throttle and elevatorpitch when the trackbar's value is changed
        private void control_Value_Changed(object sender, EventArgs e)
        {
            ControlsUpdate update = new ControlsUpdate();
            update.Throttle = throttlebar.Value;
            update.ElevatorPitch = pitchbar.Value;
            updated?.Invoke(update);
        }


        //updating weather details by making api calls
        async Task getweatherupdate()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new updateweather(getweatherupdate));
            }
            else
            {
                try
                {
                    using (WebClient web = new WebClient())
                    {
                        string postcode = posttxt.Text;

                        JavaScriptSerializer serializer = new JavaScriptSerializer();

                        string cityurl = string.Format($"http://api.openweathermap.org/geo/1.0/zip?zip={postcode},GB&appid=631d8f360d3c7e3efab7ef8844707ae9");
                        var citydata = web.DownloadString(cityurl);   //getting location details in jsdn format by making api call

                        Weatherupdate.citydetails city = new Weatherupdate.citydetails();
                        city = serializer.Deserialize<Weatherupdate.citydetails>(citydata);   //deserailizing area details

                        arealbl.Text = "Area: " + city.name;

                        string weatherurl = string.Format($"https://api.openweathermap.org/data/2.5/weather?lat={city.lat}&lon={city.lon}&appid=631d8f360d3c7e3efab7ef8844707ae9");
                        var weatherdata = web.DownloadString(weatherurl);   //getting weather details in json format by making api call

                        Weatherupdate.primary primary = new Weatherupdate.primary();
                        primary = serializer.Deserialize<Weatherupdate.primary>(weatherdata);  //deserializing weather details

                        //updating labels related to weather details
                        #region weatherlabels
                        wthdescription.Text = "Weather: " + primary.weather[0].description.ToString();
                        wthvisibility.Text = "Visibility: " + primary.visibility.ToString() + " meters";
                        wthcloudiness.Text = "Cloudiness: " + primary.clouds.all.ToString() + "%";
                        wthtemp.Text = "Temperature: " + (primary.main.temp - 273.15).ToString("F2") + "°C";
                        wthpressure.Text = "Atmospheric Pressure: " + primary.main.pressure.ToString() + " hPa";
                        wthwind.Text = "Wind Speed: " + primary.wind.speed.ToString() + " m/s";
                        wthhumidity.Text = "Humidity: " + primary.main.humidity.ToString() + "%";
                        #endregion
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show("Error: " + ex.Message, "Error", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Error);
                }
            }
        }


        //function to start the process of updating weather details
        private void weatherbtn_Click(object sender, EventArgs e)
        {
          Task.Run(() => getweatherupdate());  //running getweatherupdate method parallelly by using Task
        }


        //function to write useful data to Blackbox.csv file by using StreamWriter
        void writetoblackbox(TelemetryUpdate blackboxdata)
        {
            using (StreamWriter outputFile = File.AppendText(Path.Combine(blackboxpath, "Blackbox.csv")))
            {
                DateTime date = DateTime.Now.Date; //getting current date
                TimeSpan time = DateTime.Now.TimeOfDay; //getting current time
                outputFile.WriteLine(string.Join(",", date, time, blackboxdata.Altitude, blackboxdata.Speed, blackboxdata.Pitch, blackboxdata.VerticalSpeed, blackboxdata.Throttle, blackboxdata.ElevatorPitch, blackboxdata.WarningCode, controlinfo));
            }
        }


        //function to open the Blackbox.csv file while it is not connected to the FlightSimulator.exe
        private void blackbox_Click(object sender, EventArgs e)
        {
            try
            {
                if (client != null && client.Connected) //checks if the controller is connected to the flight simulator
                {
                    System.Windows.MessageBox.Show("While data is being received by the Remote Flight Controller, you cannot access the blackbox as it may lead to data loss.", "Caution", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
                else
                {
                    Process.Start(blackboxpath + "/Blackbox.csv"); //opening the Blackbox.csv file
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Error: " + ex.Message, "Error", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Error);
            }
        }


        //function to open the autopliot form
        private void autopilotbtn_Click(object sender, EventArgs e)
        {
            //starting the autopilot form
            autopilotform apform = new autopilotform();
            apform.ShowDialog();

            if (autoaltitude >= 1500 && autoaltitude <= 15000)
            {
                controlpanel.Enabled = false;
                autopilotthread = new Thread(() => maintainautopilot());    //initializing the autopilot thread
                autopilotstatus = true;
                autopilotthread.Start();     //starting the autopliot thread
                controlinfo = "Autopilot";
                turnoffauto.Enabled = true;
                controlpanel.Enabled = false;
            }
        }


        //function to maintain the aircraft on user specific altitude
        private void maintainautopilot()
        {
            ControlsUpdate autoupdate = new ControlsUpdate();
            while (autopilotstatus)
            {
                if (currentaltitude - autoaltitude > 500 || autoaltitude  - currentaltitude > 500)
                {
                    if (currentaltitude > autoaltitude)
                    {
                        autoupdate.Throttle = 30;
                        if (currentpitch < -15)
                        {
                            autoupdate.ElevatorPitch = 2;
                        }
                        else
                        {
                            autoupdate.ElevatorPitch = -3;
                        }
                    }

                    if (currentaltitude < autoaltitude)
                    {
                        autoupdate.Throttle = 40;

                        if (currentpitch > 15)
                        {
                            autoupdate.ElevatorPitch = -2;
                        }
                        else
                        {
                            autoupdate.ElevatorPitch = 3;
                        }
                    }
                }
                else if (100 < currentaltitude - autoaltitude && currentaltitude - autoaltitude < 500 || 100 < autoaltitude - currentaltitude && autoaltitude - currentaltitude < 500)
                {
                    if (currentaltitude > autoaltitude)
                    {
                        autoupdate.Throttle = 30;
                        if (currentpitch < -5)
                        {
                            autoupdate.ElevatorPitch = 2;
                        }
                        else
                        {
                            autoupdate.ElevatorPitch = -3;
                        }
                    }

                    if (currentaltitude < autoaltitude)
                    {
                        autoupdate.Throttle = 40;

                        if (currentpitch > 5)
                        {
                            autoupdate.ElevatorPitch = -2;
                        }
                        else
                        {
                            autoupdate.ElevatorPitch = 3;
                        }
                    }
                }
                else
                {
                    if (currentaltitude > autoaltitude)
                    {
                        autoupdate.Throttle = 30;
                        if (currentpitch < -2)
                        {
                            autoupdate.ElevatorPitch = 2;
                        }
                        else
                        {
                            autoupdate.ElevatorPitch = -3;
                        }
                    }

                    if (currentaltitude < autoaltitude)
                    {
                        autoupdate.Throttle = 40;

                        if (currentpitch > 2)
                        {
                            autoupdate.ElevatorPitch = -2;
                        }
                        else
                        {
                            autoupdate.ElevatorPitch = 3;
                        }
                    }
                }

                if (currentaltitude == autoaltitude)
                {
                    autoupdate.ElevatorPitch = 0;
                    autoupdate.Throttle = 40;
                }

                updated?.Invoke(autoupdate);   //invoking updated event to send the data to the flight simulator to maintain the altitude
                Thread.Sleep(300);
            }
        }


        //function to turn off the autopilot
        private void turnoffauto_Click(object sender, EventArgs e)
        {
            autopilotstatus = false;
            autopilotthread.Abort();    //turning off the thread
            controlinfo = "User";
            turnoffauto.Enabled = false;
            controlpanel.Enabled = true;
            autoaltitude = 0;
        }

       
        //function to close the application after closing all the threads and tcpclient
        private void closebtn_Click(object sender, EventArgs e)
        {
            if (autopilotthread != null)
            {
                if (autopilotthread.IsAlive)
                {
                    autopilotthread.Abort();  //turning off the thread
                }
            }
            if (listenthread != null)
            {
                if (listenthread.IsAlive)
                {
                    listenthread.Abort();    //turning off the thread
                }
            }
            if (client != null)
            {
                client.Close();    //closing the tcpclient
            }
            this.Close();     //closing the mian form
        }
    }
}