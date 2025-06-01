namespace Remote_Flight_Controller
{
    partial class RemoteFlightController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoteFlightController));
            this.connectionpanel = new System.Windows.Forms.Panel();
            this.disconnectbtn = new System.Windows.Forms.Button();
            this.statustext = new System.Windows.Forms.Label();
            this.connectbtn = new System.Windows.Forms.Button();
            this.connectionstatus = new System.Windows.Forms.Label();
            this.porttext = new System.Windows.Forms.TextBox();
            this.portlabel = new System.Windows.Forms.Label();
            this.iptext = new System.Windows.Forms.TextBox();
            this.iplabel = new System.Windows.Forms.Label();
            this.controlpanel = new System.Windows.Forms.Panel();
            this.maxlbl = new System.Windows.Forms.Label();
            this.min2lbl = new System.Windows.Forms.Label();
            this.midlbl = new System.Windows.Forms.Label();
            this.mlbl = new System.Windows.Forms.Label();
            this.minlbl = new System.Windows.Forms.Label();
            this.pitchlabel = new System.Windows.Forms.Label();
            this.throttlelabel = new System.Windows.Forms.Label();
            this.pitchbar = new System.Windows.Forms.TrackBar();
            this.throttlebar = new System.Windows.Forms.TrackBar();
            this.telemetrydatagrid = new System.Windows.Forms.DataGridView();
            this.green = new System.Windows.Forms.PictureBox();
            this.red = new System.Windows.Forms.PictureBox();
            this.indicator = new System.Windows.Forms.Label();
            this.warningpanel = new System.Windows.Forms.Panel();
            this.warningbox = new System.Windows.Forms.Label();
            this.blackbox = new System.Windows.Forms.Button();
            this.speedg = new LiveCharts.WinForms.AngularGauge();
            this.altitudeg = new LiveCharts.WinForms.AngularGauge();
            this.pitchg = new LiveCharts.WinForms.AngularGauge();
            this.altlbl = new System.Windows.Forms.Label();
            this.pitchlbl = new System.Windows.Forms.Label();
            this.speedlbl = new System.Windows.Forms.Label();
            this.verticalspeedlbl = new System.Windows.Forms.Label();
            this.throttlelbl2 = new System.Windows.Forms.Label();
            this.epitchlbl = new System.Windows.Forms.Label();
            this.autopilotbtn = new System.Windows.Forms.Button();
            this.autotext = new System.Windows.Forms.Label();
            this.turnoffauto = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            this.wthvisibility = new System.Windows.Forms.Label();
            this.weatherpanel = new System.Windows.Forms.Panel();
            this.wthpressure = new System.Windows.Forms.Label();
            this.arealbl = new System.Windows.Forms.Label();
            this.weatherbtn = new System.Windows.Forms.Button();
            this.postcodelbl = new System.Windows.Forms.Label();
            this.posttxt = new System.Windows.Forms.TextBox();
            this.wthdescription = new System.Windows.Forms.Label();
            this.wthtemp = new System.Windows.Forms.Label();
            this.wthhumidity = new System.Windows.Forms.Label();
            this.wthcloudiness = new System.Windows.Forms.Label();
            this.wthwind = new System.Windows.Forms.Label();
            this.connectionpanel.SuspendLayout();
            this.controlpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pitchbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.throttlebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telemetrydatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).BeginInit();
            this.warningpanel.SuspendLayout();
            this.weatherpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectionpanel
            // 
            this.connectionpanel.BackColor = System.Drawing.Color.BurlyWood;
            this.connectionpanel.Controls.Add(this.disconnectbtn);
            this.connectionpanel.Controls.Add(this.statustext);
            this.connectionpanel.Controls.Add(this.connectbtn);
            this.connectionpanel.Controls.Add(this.connectionstatus);
            this.connectionpanel.Controls.Add(this.porttext);
            this.connectionpanel.Controls.Add(this.portlabel);
            this.connectionpanel.Controls.Add(this.iptext);
            this.connectionpanel.Controls.Add(this.iplabel);
            this.connectionpanel.Location = new System.Drawing.Point(16, 17);
            this.connectionpanel.Margin = new System.Windows.Forms.Padding(7);
            this.connectionpanel.Name = "connectionpanel";
            this.connectionpanel.Size = new System.Drawing.Size(335, 245);
            this.connectionpanel.TabIndex = 0;
            // 
            // disconnectbtn
            // 
            this.disconnectbtn.BackColor = System.Drawing.Color.Tomato;
            this.disconnectbtn.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnectbtn.Location = new System.Drawing.Point(8, 132);
            this.disconnectbtn.Name = "disconnectbtn";
            this.disconnectbtn.Size = new System.Drawing.Size(150, 50);
            this.disconnectbtn.TabIndex = 10;
            this.disconnectbtn.Text = "Disconnect";
            this.disconnectbtn.UseVisualStyleBackColor = false;
            this.disconnectbtn.Click += new System.EventHandler(this.disconnectbtn_Click);
            // 
            // statustext
            // 
            this.statustext.AutoSize = true;
            this.statustext.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statustext.Location = new System.Drawing.Point(179, 201);
            this.statustext.Name = "statustext";
            this.statustext.Size = new System.Drawing.Size(135, 22);
            this.statustext.TabIndex = 9;
            this.statustext.Text = "Not Connected";
            // 
            // connectbtn
            // 
            this.connectbtn.BackColor = System.Drawing.Color.YellowGreen;
            this.connectbtn.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectbtn.Location = new System.Drawing.Point(164, 132);
            this.connectbtn.Name = "connectbtn";
            this.connectbtn.Size = new System.Drawing.Size(150, 50);
            this.connectbtn.TabIndex = 8;
            this.connectbtn.Text = "Connect";
            this.connectbtn.UseVisualStyleBackColor = false;
            this.connectbtn.Click += new System.EventHandler(this.connectbtn_Click);
            // 
            // connectionstatus
            // 
            this.connectionstatus.AutoSize = true;
            this.connectionstatus.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionstatus.Location = new System.Drawing.Point(9, 201);
            this.connectionstatus.Name = "connectionstatus";
            this.connectionstatus.Size = new System.Drawing.Size(166, 22);
            this.connectionstatus.TabIndex = 6;
            this.connectionstatus.Text = "Connection Status:";
            // 
            // porttext
            // 
            this.porttext.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porttext.Location = new System.Drawing.Point(48, 76);
            this.porttext.Name = "porttext";
            this.porttext.Size = new System.Drawing.Size(268, 27);
            this.porttext.TabIndex = 3;
            // 
            // portlabel
            // 
            this.portlabel.AutoSize = true;
            this.portlabel.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portlabel.Location = new System.Drawing.Point(3, 76);
            this.portlabel.Name = "portlabel";
            this.portlabel.Size = new System.Drawing.Size(43, 20);
            this.portlabel.TabIndex = 2;
            this.portlabel.Text = "Port:";
            // 
            // iptext
            // 
            this.iptext.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iptext.Location = new System.Drawing.Point(95, 27);
            this.iptext.Name = "iptext";
            this.iptext.Size = new System.Drawing.Size(237, 27);
            this.iptext.TabIndex = 1;
            // 
            // iplabel
            // 
            this.iplabel.AutoSize = true;
            this.iplabel.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iplabel.Location = new System.Drawing.Point(5, 31);
            this.iplabel.Name = "iplabel";
            this.iplabel.Size = new System.Drawing.Size(89, 20);
            this.iplabel.TabIndex = 0;
            this.iplabel.Text = "Ip Address:";
            // 
            // controlpanel
            // 
            this.controlpanel.BackColor = System.Drawing.Color.BurlyWood;
            this.controlpanel.Controls.Add(this.maxlbl);
            this.controlpanel.Controls.Add(this.min2lbl);
            this.controlpanel.Controls.Add(this.midlbl);
            this.controlpanel.Controls.Add(this.mlbl);
            this.controlpanel.Controls.Add(this.minlbl);
            this.controlpanel.Controls.Add(this.pitchlabel);
            this.controlpanel.Controls.Add(this.throttlelabel);
            this.controlpanel.Controls.Add(this.pitchbar);
            this.controlpanel.Controls.Add(this.throttlebar);
            this.controlpanel.Location = new System.Drawing.Point(16, 282);
            this.controlpanel.Name = "controlpanel";
            this.controlpanel.Size = new System.Drawing.Size(293, 622);
            this.controlpanel.TabIndex = 2;
            // 
            // maxlbl
            // 
            this.maxlbl.AutoSize = true;
            this.maxlbl.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxlbl.Location = new System.Drawing.Point(165, 66);
            this.maxlbl.Name = "maxlbl";
            this.maxlbl.Size = new System.Drawing.Size(17, 20);
            this.maxlbl.TabIndex = 7;
            this.maxlbl.Text = "5";
            // 
            // min2lbl
            // 
            this.min2lbl.AutoSize = true;
            this.min2lbl.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min2lbl.Location = new System.Drawing.Point(160, 586);
            this.min2lbl.Name = "min2lbl";
            this.min2lbl.Size = new System.Drawing.Size(22, 20);
            this.min2lbl.TabIndex = 6;
            this.min2lbl.Text = "-5";
            // 
            // midlbl
            // 
            this.midlbl.AutoSize = true;
            this.midlbl.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midlbl.Location = new System.Drawing.Point(163, 331);
            this.midlbl.Name = "midlbl";
            this.midlbl.Size = new System.Drawing.Size(18, 20);
            this.midlbl.TabIndex = 5;
            this.midlbl.Text = "0";
            // 
            // mlbl
            // 
            this.mlbl.AutoSize = true;
            this.mlbl.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mlbl.Location = new System.Drawing.Point(17, 68);
            this.mlbl.Name = "mlbl";
            this.mlbl.Size = new System.Drawing.Size(32, 20);
            this.mlbl.TabIndex = 3;
            this.mlbl.Text = "100";
            // 
            // minlbl
            // 
            this.minlbl.AutoSize = true;
            this.minlbl.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minlbl.Location = new System.Drawing.Point(28, 586);
            this.minlbl.Name = "minlbl";
            this.minlbl.Size = new System.Drawing.Size(18, 20);
            this.minlbl.TabIndex = 4;
            this.minlbl.Text = "0";
            // 
            // pitchlabel
            // 
            this.pitchlabel.AutoSize = true;
            this.pitchlabel.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pitchlabel.Location = new System.Drawing.Point(153, 20);
            this.pitchlabel.Name = "pitchlabel";
            this.pitchlabel.Size = new System.Drawing.Size(127, 22);
            this.pitchlabel.TabIndex = 3;
            this.pitchlabel.Text = "Elevator Pitch";
            // 
            // throttlelabel
            // 
            this.throttlelabel.AutoSize = true;
            this.throttlelabel.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.throttlelabel.Location = new System.Drawing.Point(41, 20);
            this.throttlelabel.Name = "throttlelabel";
            this.throttlelabel.Size = new System.Drawing.Size(77, 22);
            this.throttlelabel.TabIndex = 2;
            this.throttlelabel.Text = "Throttle";
            // 
            // pitchbar
            // 
            this.pitchbar.BackColor = System.Drawing.Color.Gray;
            this.pitchbar.LargeChange = 1;
            this.pitchbar.Location = new System.Drawing.Point(187, 66);
            this.pitchbar.Maximum = 5;
            this.pitchbar.Minimum = -5;
            this.pitchbar.Name = "pitchbar";
            this.pitchbar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.pitchbar.Size = new System.Drawing.Size(45, 540);
            this.pitchbar.TabIndex = 1;
            this.pitchbar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.pitchbar.ValueChanged += new System.EventHandler(this.control_Value_Changed);
            // 
            // throttlebar
            // 
            this.throttlebar.BackColor = System.Drawing.Color.Gray;
            this.throttlebar.LargeChange = 1;
            this.throttlebar.Location = new System.Drawing.Point(52, 66);
            this.throttlebar.Maximum = 100;
            this.throttlebar.Name = "throttlebar";
            this.throttlebar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.throttlebar.Size = new System.Drawing.Size(45, 540);
            this.throttlebar.TabIndex = 0;
            this.throttlebar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.throttlebar.ValueChanged += new System.EventHandler(this.control_Value_Changed);
            // 
            // telemetrydatagrid
            // 
            this.telemetrydatagrid.AllowUserToAddRows = false;
            this.telemetrydatagrid.AllowUserToDeleteRows = false;
            this.telemetrydatagrid.AllowUserToResizeColumns = false;
            this.telemetrydatagrid.AllowUserToResizeRows = false;
            this.telemetrydatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.telemetrydatagrid.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.telemetrydatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.telemetrydatagrid.Location = new System.Drawing.Point(672, 463);
            this.telemetrydatagrid.Name = "telemetrydatagrid";
            this.telemetrydatagrid.ReadOnly = true;
            this.telemetrydatagrid.RowHeadersWidth = 82;
            this.telemetrydatagrid.Size = new System.Drawing.Size(631, 442);
            this.telemetrydatagrid.TabIndex = 3;
            // 
            // green
            // 
            this.green.Image = ((System.Drawing.Image)(resources.GetObject("green.Image")));
            this.green.Location = new System.Drawing.Point(571, 10);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(41, 40);
            this.green.TabIndex = 4;
            this.green.TabStop = false;
            // 
            // red
            // 
            this.red.Image = ((System.Drawing.Image)(resources.GetObject("red.Image")));
            this.red.Location = new System.Drawing.Point(570, 10);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(42, 40);
            this.red.TabIndex = 5;
            this.red.TabStop = false;
            // 
            // indicator
            // 
            this.indicator.AutoSize = true;
            this.indicator.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicator.Location = new System.Drawing.Point(554, 53);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(75, 20);
            this.indicator.TabIndex = 7;
            this.indicator.Text = "Indicator";
            // 
            // warningpanel
            // 
            this.warningpanel.BackColor = System.Drawing.Color.Silver;
            this.warningpanel.Controls.Add(this.warningbox);
            this.warningpanel.Controls.Add(this.green);
            this.warningpanel.Controls.Add(this.indicator);
            this.warningpanel.Controls.Add(this.red);
            this.warningpanel.Location = new System.Drawing.Point(672, 363);
            this.warningpanel.Name = "warningpanel";
            this.warningpanel.Size = new System.Drawing.Size(631, 79);
            this.warningpanel.TabIndex = 10;
            // 
            // warningbox
            // 
            this.warningbox.AutoSize = true;
            this.warningbox.Font = new System.Drawing.Font("Montserrat ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningbox.ForeColor = System.Drawing.Color.Lime;
            this.warningbox.Location = new System.Drawing.Point(11, 25);
            this.warningbox.Name = "warningbox";
            this.warningbox.Size = new System.Drawing.Size(138, 26);
            this.warningbox.TabIndex = 0;
            this.warningbox.Text = "No Warning!";
            this.warningbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blackbox
            // 
            this.blackbox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.blackbox.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackbox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.blackbox.Location = new System.Drawing.Point(324, 854);
            this.blackbox.Name = "blackbox";
            this.blackbox.Size = new System.Drawing.Size(150, 50);
            this.blackbox.TabIndex = 11;
            this.blackbox.Text = "Blackbox";
            this.blackbox.UseVisualStyleBackColor = false;
            this.blackbox.Click += new System.EventHandler(this.blackbox_Click);
            // 
            // speedg
            // 
            this.speedg.BackColor = System.Drawing.Color.BurlyWood;
            this.speedg.Location = new System.Drawing.Point(1000, 17);
            this.speedg.Name = "speedg";
            this.speedg.Size = new System.Drawing.Size(300, 300);
            this.speedg.TabIndex = 12;
            this.speedg.Text = "angularGauge1";
            // 
            // altitudeg
            // 
            this.altitudeg.BackColor = System.Drawing.Color.BurlyWood;
            this.altitudeg.Location = new System.Drawing.Point(369, 17);
            this.altitudeg.Name = "altitudeg";
            this.altitudeg.Size = new System.Drawing.Size(300, 300);
            this.altitudeg.TabIndex = 13;
            this.altitudeg.Text = "angularGauge2";
            // 
            // pitchg
            // 
            this.pitchg.BackColor = System.Drawing.Color.BurlyWood;
            this.pitchg.Location = new System.Drawing.Point(685, 17);
            this.pitchg.Name = "pitchg";
            this.pitchg.Size = new System.Drawing.Size(300, 300);
            this.pitchg.TabIndex = 14;
            this.pitchg.Text = "angularGauge3";
            // 
            // altlbl
            // 
            this.altlbl.AutoSize = true;
            this.altlbl.Font = new System.Drawing.Font("Montserrat Medium", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altlbl.Location = new System.Drawing.Point(438, 281);
            this.altlbl.Name = "altlbl";
            this.altlbl.Size = new System.Drawing.Size(172, 21);
            this.altlbl.TabIndex = 16;
            this.altlbl.Text = "Altitude : 00000 feets";
            // 
            // pitchlbl
            // 
            this.pitchlbl.AutoSize = true;
            this.pitchlbl.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pitchlbl.Location = new System.Drawing.Point(792, 281);
            this.pitchlbl.Name = "pitchlbl";
            this.pitchlbl.Size = new System.Drawing.Size(83, 22);
            this.pitchlbl.TabIndex = 17;
            this.pitchlbl.Text = "Pitch : 0°";
            // 
            // speedlbl
            // 
            this.speedlbl.AutoSize = true;
            this.speedlbl.Font = new System.Drawing.Font("Montserrat Medium", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedlbl.Location = new System.Drawing.Point(1060, 282);
            this.speedlbl.Name = "speedlbl";
            this.speedlbl.Size = new System.Drawing.Size(169, 21);
            this.speedlbl.TabIndex = 18;
            this.speedlbl.Text = "Speed : 00000 KNots";
            // 
            // verticalspeedlbl
            // 
            this.verticalspeedlbl.AutoSize = true;
            this.verticalspeedlbl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.verticalspeedlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.verticalspeedlbl.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verticalspeedlbl.Location = new System.Drawing.Point(413, 324);
            this.verticalspeedlbl.Name = "verticalspeedlbl";
            this.verticalspeedlbl.Size = new System.Drawing.Size(220, 22);
            this.verticalspeedlbl.TabIndex = 19;
            this.verticalspeedlbl.Text = "Vertical Speed : 00000 ft/min";
            // 
            // throttlelbl2
            // 
            this.throttlelbl2.AutoSize = true;
            this.throttlelbl2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.throttlelbl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.throttlelbl2.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.throttlelbl2.Location = new System.Drawing.Point(767, 324);
            this.throttlelbl2.Name = "throttlelbl2";
            this.throttlelbl2.Size = new System.Drawing.Size(135, 24);
            this.throttlelbl2.TabIndex = 20;
            this.throttlelbl2.Text = "Throttle : 000%";
            // 
            // epitchlbl
            // 
            this.epitchlbl.AutoSize = true;
            this.epitchlbl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.epitchlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.epitchlbl.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.epitchlbl.Location = new System.Drawing.Point(1072, 324);
            this.epitchlbl.Name = "epitchlbl";
            this.epitchlbl.Size = new System.Drawing.Size(157, 24);
            this.epitchlbl.TabIndex = 21;
            this.epitchlbl.Text = "Elevator Pitch : 0°";
            // 
            // autopilotbtn
            // 
            this.autopilotbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.autopilotbtn.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autopilotbtn.Location = new System.Drawing.Point(327, 793);
            this.autopilotbtn.Name = "autopilotbtn";
            this.autopilotbtn.Size = new System.Drawing.Size(150, 50);
            this.autopilotbtn.TabIndex = 22;
            this.autopilotbtn.Text = "Autopilot Configuration";
            this.autopilotbtn.UseVisualStyleBackColor = false;
            this.autopilotbtn.Click += new System.EventHandler(this.autopilotbtn_Click);
            // 
            // autotext
            // 
            this.autotext.AutoSize = true;
            this.autotext.BackColor = System.Drawing.SystemColors.HighlightText;
            this.autotext.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.autotext.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autotext.Location = new System.Drawing.Point(355, 757);
            this.autotext.Name = "autotext";
            this.autotext.Size = new System.Drawing.Size(267, 24);
            this.autotext.TabIndex = 23;
            this.autotext.Text = "Autopilot Altitude: 00000 feets";
            // 
            // turnoffauto
            // 
            this.turnoffauto.BackColor = System.Drawing.Color.Coral;
            this.turnoffauto.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnoffauto.Location = new System.Drawing.Point(504, 793);
            this.turnoffauto.Name = "turnoffauto";
            this.turnoffauto.Size = new System.Drawing.Size(150, 50);
            this.turnoffauto.TabIndex = 24;
            this.turnoffauto.Text = "Turn off Autopilot";
            this.turnoffauto.UseVisualStyleBackColor = false;
            this.turnoffauto.Click += new System.EventHandler(this.turnoffauto_Click);
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.closebtn.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.Location = new System.Drawing.Point(504, 854);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(150, 50);
            this.closebtn.TabIndex = 25;
            this.closebtn.Text = "Close";
            this.closebtn.UseVisualStyleBackColor = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // wthvisibility
            // 
            this.wthvisibility.AutoSize = true;
            this.wthvisibility.BackColor = System.Drawing.SystemColors.HighlightText;
            this.wthvisibility.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wthvisibility.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wthvisibility.Location = new System.Drawing.Point(13, 70);
            this.wthvisibility.Name = "wthvisibility";
            this.wthvisibility.Size = new System.Drawing.Size(194, 24);
            this.wthvisibility.TabIndex = 27;
            this.wthvisibility.Text = "Visibility: 00000 Meter";
            // 
            // weatherpanel
            // 
            this.weatherpanel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.weatherpanel.Controls.Add(this.wthpressure);
            this.weatherpanel.Controls.Add(this.arealbl);
            this.weatherpanel.Controls.Add(this.weatherbtn);
            this.weatherpanel.Controls.Add(this.postcodelbl);
            this.weatherpanel.Controls.Add(this.posttxt);
            this.weatherpanel.Controls.Add(this.wthdescription);
            this.weatherpanel.Controls.Add(this.wthtemp);
            this.weatherpanel.Controls.Add(this.wthhumidity);
            this.weatherpanel.Controls.Add(this.wthcloudiness);
            this.weatherpanel.Controls.Add(this.wthwind);
            this.weatherpanel.Controls.Add(this.wthvisibility);
            this.weatherpanel.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weatherpanel.Location = new System.Drawing.Point(327, 363);
            this.weatherpanel.Name = "weatherpanel";
            this.weatherpanel.Size = new System.Drawing.Size(327, 381);
            this.weatherpanel.TabIndex = 29;
            // 
            // wthpressure
            // 
            this.wthpressure.AutoSize = true;
            this.wthpressure.BackColor = System.Drawing.SystemColors.HighlightText;
            this.wthpressure.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wthpressure.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wthpressure.Location = new System.Drawing.Point(13, 135);
            this.wthpressure.Name = "wthpressure";
            this.wthpressure.Size = new System.Drawing.Size(284, 24);
            this.wthpressure.TabIndex = 38;
            this.wthpressure.Text = "Atmospheric Pressure: 0000 hPa";
            // 
            // arealbl
            // 
            this.arealbl.AutoSize = true;
            this.arealbl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.arealbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.arealbl.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arealbl.Location = new System.Drawing.Point(13, 10);
            this.arealbl.Name = "arealbl";
            this.arealbl.Size = new System.Drawing.Size(57, 24);
            this.arealbl.TabIndex = 37;
            this.arealbl.Text = "Area:";
            // 
            // weatherbtn
            // 
            this.weatherbtn.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weatherbtn.Location = new System.Drawing.Point(49, 318);
            this.weatherbtn.Name = "weatherbtn";
            this.weatherbtn.Size = new System.Drawing.Size(238, 52);
            this.weatherbtn.TabIndex = 36;
            this.weatherbtn.Text = "Get Weather Update";
            this.weatherbtn.UseVisualStyleBackColor = true;
            this.weatherbtn.Click += new System.EventHandler(this.weatherbtn_Click);
            // 
            // postcodelbl
            // 
            this.postcodelbl.AutoSize = true;
            this.postcodelbl.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postcodelbl.Location = new System.Drawing.Point(32, 283);
            this.postcodelbl.Name = "postcodelbl";
            this.postcodelbl.Size = new System.Drawing.Size(91, 22);
            this.postcodelbl.TabIndex = 35;
            this.postcodelbl.Text = "Postcode:";
            // 
            // posttxt
            // 
            this.posttxt.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posttxt.Location = new System.Drawing.Point(122, 282);
            this.posttxt.Name = "posttxt";
            this.posttxt.Size = new System.Drawing.Size(171, 24);
            this.posttxt.TabIndex = 34;
            // 
            // wthdescription
            // 
            this.wthdescription.AutoSize = true;
            this.wthdescription.BackColor = System.Drawing.SystemColors.HighlightText;
            this.wthdescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wthdescription.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wthdescription.Location = new System.Drawing.Point(13, 41);
            this.wthdescription.Name = "wthdescription";
            this.wthdescription.Size = new System.Drawing.Size(88, 24);
            this.wthdescription.TabIndex = 33;
            this.wthdescription.Text = "Weather:";
            // 
            // wthtemp
            // 
            this.wthtemp.AutoSize = true;
            this.wthtemp.BackColor = System.Drawing.SystemColors.HighlightText;
            this.wthtemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wthtemp.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wthtemp.Location = new System.Drawing.Point(13, 170);
            this.wthtemp.Name = "wthtemp";
            this.wthtemp.Size = new System.Drawing.Size(179, 24);
            this.wthtemp.TabIndex = 32;
            this.wthtemp.Text = "Temperature: 000°C";
            // 
            // wthhumidity
            // 
            this.wthhumidity.AutoSize = true;
            this.wthhumidity.BackColor = System.Drawing.SystemColors.HighlightText;
            this.wthhumidity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wthhumidity.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wthhumidity.Location = new System.Drawing.Point(13, 236);
            this.wthhumidity.Name = "wthhumidity";
            this.wthhumidity.Size = new System.Drawing.Size(142, 24);
            this.wthhumidity.TabIndex = 31;
            this.wthhumidity.Text = "Humidity: 000%";
            // 
            // wthcloudiness
            // 
            this.wthcloudiness.AutoSize = true;
            this.wthcloudiness.BackColor = System.Drawing.SystemColors.HighlightText;
            this.wthcloudiness.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wthcloudiness.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wthcloudiness.Location = new System.Drawing.Point(13, 103);
            this.wthcloudiness.Name = "wthcloudiness";
            this.wthcloudiness.Size = new System.Drawing.Size(155, 24);
            this.wthcloudiness.TabIndex = 30;
            this.wthcloudiness.Text = "Cloudiness: 000%";
            // 
            // wthwind
            // 
            this.wthwind.AutoSize = true;
            this.wthwind.BackColor = System.Drawing.SystemColors.HighlightText;
            this.wthwind.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wthwind.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wthwind.Location = new System.Drawing.Point(13, 204);
            this.wthwind.Name = "wthwind";
            this.wthwind.Size = new System.Drawing.Size(209, 24);
            this.wthwind.TabIndex = 29;
            this.wthwind.Text = "Wind Speed: 00000 m/s";
            // 
            // RemoteFlightController
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1309, 910);
            this.Controls.Add(this.weatherpanel);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.turnoffauto);
            this.Controls.Add(this.autotext);
            this.Controls.Add(this.autopilotbtn);
            this.Controls.Add(this.epitchlbl);
            this.Controls.Add(this.throttlelbl2);
            this.Controls.Add(this.verticalspeedlbl);
            this.Controls.Add(this.speedlbl);
            this.Controls.Add(this.pitchlbl);
            this.Controls.Add(this.altlbl);
            this.Controls.Add(this.pitchg);
            this.Controls.Add(this.speedg);
            this.Controls.Add(this.altitudeg);
            this.Controls.Add(this.blackbox);
            this.Controls.Add(this.warningpanel);
            this.Controls.Add(this.telemetrydatagrid);
            this.Controls.Add(this.controlpanel);
            this.Controls.Add(this.connectionpanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "RemoteFlightController";
            this.Text = "Remote Flight Controller - 30074676";
            this.connectionpanel.ResumeLayout(false);
            this.connectionpanel.PerformLayout();
            this.controlpanel.ResumeLayout(false);
            this.controlpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pitchbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.throttlebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telemetrydatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).EndInit();
            this.warningpanel.ResumeLayout(false);
            this.warningpanel.PerformLayout();
            this.weatherpanel.ResumeLayout(false);
            this.weatherpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel connectionpanel;
        private System.Windows.Forms.Label iplabel;
        private System.Windows.Forms.TextBox iptext;
        private System.Windows.Forms.TextBox porttext;
        private System.Windows.Forms.Label portlabel;
        private System.Windows.Forms.Label connectionstatus;
        private System.Windows.Forms.Button connectbtn;
        private System.Windows.Forms.Panel controlpanel;
        private System.Windows.Forms.TrackBar throttlebar;
        private System.Windows.Forms.TrackBar pitchbar;
        private System.Windows.Forms.Label pitchlabel;
        private System.Windows.Forms.Label throttlelabel;
        private System.Windows.Forms.Label mlbl;
        private System.Windows.Forms.Label minlbl;
        private System.Windows.Forms.Label min2lbl;
        private System.Windows.Forms.Label midlbl;
        private System.Windows.Forms.Label maxlbl;
        private System.Windows.Forms.Label statustext;
        private System.Windows.Forms.DataGridView telemetrydatagrid;
        private System.Windows.Forms.PictureBox green;
        private System.Windows.Forms.PictureBox red;
        private System.Windows.Forms.Label indicator;
        private System.Windows.Forms.Panel warningpanel;
        private System.Windows.Forms.Label warningbox;
        private System.Windows.Forms.Button blackbox;
        private LiveCharts.WinForms.AngularGauge speedg;
        private LiveCharts.WinForms.AngularGauge altitudeg;
        private LiveCharts.WinForms.AngularGauge pitchg;
        private System.Windows.Forms.Label altlbl;
        private System.Windows.Forms.Label pitchlbl;
        private System.Windows.Forms.Label speedlbl;
        private System.Windows.Forms.Label verticalspeedlbl;
        private System.Windows.Forms.Label throttlelbl2;
        private System.Windows.Forms.Label epitchlbl;
        private System.Windows.Forms.Button autopilotbtn;
        private System.Windows.Forms.Button disconnectbtn;
        private System.Windows.Forms.Label autotext;
        private System.Windows.Forms.Button turnoffauto;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Label wthvisibility;
        private System.Windows.Forms.Panel weatherpanel;
        private System.Windows.Forms.Label wthwind;
        private System.Windows.Forms.Label wthtemp;
        private System.Windows.Forms.Label wthhumidity;
        private System.Windows.Forms.Label wthcloudiness;
        private System.Windows.Forms.Label wthdescription;
        private System.Windows.Forms.Button weatherbtn;
        private System.Windows.Forms.Label postcodelbl;
        private System.Windows.Forms.TextBox posttxt;
        private System.Windows.Forms.Label arealbl;
        private System.Windows.Forms.Label wthpressure;
    }
}

