namespace Remote_Flight_Controller
{
    partial class startingform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startingform));
            this.blackboxpath = new System.Windows.Forms.TextBox();
            this.acceptbtn = new System.Windows.Forms.Button();
            this.manualbox = new System.Windows.Forms.CheckBox();
            this.blackboxpathbtn = new System.Windows.Forms.Button();
            this.serveropenbtn = new System.Windows.Forms.Button();
            this.serveropen = new System.Windows.Forms.TextBox();
            this.rfclbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // blackboxpath
            // 
            this.blackboxpath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackboxpath.Location = new System.Drawing.Point(12, 189);
            this.blackboxpath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.blackboxpath.Name = "blackboxpath";
            this.blackboxpath.Size = new System.Drawing.Size(479, 38);
            this.blackboxpath.TabIndex = 0;
            // 
            // acceptbtn
            // 
            this.acceptbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptbtn.Location = new System.Drawing.Point(427, 250);
            this.acceptbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.acceptbtn.Name = "acceptbtn";
            this.acceptbtn.Size = new System.Drawing.Size(179, 45);
            this.acceptbtn.TabIndex = 1;
            this.acceptbtn.Text = "Okay";
            this.acceptbtn.UseVisualStyleBackColor = true;
            this.acceptbtn.Click += new System.EventHandler(this.acceptbtn_Click);
            // 
            // manualbox
            // 
            this.manualbox.AutoSize = true;
            this.manualbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualbox.Location = new System.Drawing.Point(12, 262);
            this.manualbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manualbox.Name = "manualbox";
            this.manualbox.Size = new System.Drawing.Size(594, 41);
            this.manualbox.TabIndex = 2;
            this.manualbox.Text = "Manually Open FlightSimulator.exe file";
            this.manualbox.UseVisualStyleBackColor = true;
            this.manualbox.CheckedChanged += new System.EventHandler(this.manualbox_CheckedChanged);
            // 
            // blackboxpathbtn
            // 
            this.blackboxpathbtn.Image = ((System.Drawing.Image)(resources.GetObject("blackboxpathbtn.Image")));
            this.blackboxpathbtn.Location = new System.Drawing.Point(515, 132);
            this.blackboxpathbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.blackboxpathbtn.Name = "blackboxpathbtn";
            this.blackboxpathbtn.Size = new System.Drawing.Size(84, 82);
            this.blackboxpathbtn.TabIndex = 3;
            this.blackboxpathbtn.UseVisualStyleBackColor = true;
            this.blackboxpathbtn.Click += new System.EventHandler(this.blackboxpathbtn_Click);
            // 
            // serveropenbtn
            // 
            this.serveropenbtn.Image = ((System.Drawing.Image)(resources.GetObject("serveropenbtn.Image")));
            this.serveropenbtn.Location = new System.Drawing.Point(514, 11);
            this.serveropenbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serveropenbtn.Name = "serveropenbtn";
            this.serveropenbtn.Size = new System.Drawing.Size(92, 84);
            this.serveropenbtn.TabIndex = 4;
            this.serveropenbtn.UseVisualStyleBackColor = true;
            this.serveropenbtn.Click += new System.EventHandler(this.serveropenbtn_Click);
            // 
            // serveropen
            // 
            this.serveropen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serveropen.Location = new System.Drawing.Point(12, 72);
            this.serveropen.Name = "serveropen";
            this.serveropen.Size = new System.Drawing.Size(479, 38);
            this.serveropen.TabIndex = 5;
            // 
            // rfclbl
            // 
            this.rfclbl.AutoSize = true;
            this.rfclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rfclbl.Location = new System.Drawing.Point(111, 35);
            this.rfclbl.Name = "rfclbl";
            this.rfclbl.Size = new System.Drawing.Size(595, 44);
            this.rfclbl.TabIndex = 6;
            this.rfclbl.Text = "FlightSimulator.exe File Location :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Save Blackbox in : ";
            // 
            // startingform
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(620, 309);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rfclbl);
            this.Controls.Add(this.serveropen);
            this.Controls.Add(this.serveropenbtn);
            this.Controls.Add(this.blackboxpathbtn);
            this.Controls.Add(this.manualbox);
            this.Controls.Add(this.acceptbtn);
            this.Controls.Add(this.blackboxpath);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "startingform";
            this.Text = "Remote Flight Controller - 30074676";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox blackboxpath;
        private System.Windows.Forms.Button acceptbtn;
        private System.Windows.Forms.CheckBox manualbox;
        private System.Windows.Forms.Button blackboxpathbtn;
        private System.Windows.Forms.Button serveropenbtn;
        private System.Windows.Forms.TextBox serveropen;
        private System.Windows.Forms.Label rfclbl;
        private System.Windows.Forms.Label label1;
    }
}