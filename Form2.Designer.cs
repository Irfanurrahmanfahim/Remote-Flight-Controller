namespace Remote_Flight_Controller
{
    partial class autopilotform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(autopilotform));
            this.alttext = new System.Windows.Forms.MaskedTextBox();
            this.autobtn = new System.Windows.Forms.Button();
            this.setalt = new System.Windows.Forms.Label();
            this.autoclosebtn = new System.Windows.Forms.Button();
            this.autoinfo = new System.Windows.Forms.Label();
            this.autofeets = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // alttext
            // 
            this.alttext.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alttext.Location = new System.Drawing.Point(135, 105);
            this.alttext.Margin = new System.Windows.Forms.Padding(4);
            this.alttext.Name = "alttext";
            this.alttext.Size = new System.Drawing.Size(320, 47);
            this.alttext.TabIndex = 1;
            // 
            // autobtn
            // 
            this.autobtn.Font = new System.Drawing.Font("Montserrat SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autobtn.Location = new System.Drawing.Point(281, 180);
            this.autobtn.Margin = new System.Windows.Forms.Padding(4);
            this.autobtn.Name = "autobtn";
            this.autobtn.Size = new System.Drawing.Size(240, 76);
            this.autobtn.TabIndex = 2;
            this.autobtn.Text = "Start Autopilot";
            this.autobtn.UseVisualStyleBackColor = true;
            this.autobtn.Click += new System.EventHandler(this.autobtn_Click);
            // 
            // setalt
            // 
            this.setalt.AutoSize = true;
            this.setalt.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setalt.Location = new System.Drawing.Point(14, 108);
            this.setalt.Name = "setalt";
            this.setalt.Size = new System.Drawing.Size(224, 44);
            this.setalt.TabIndex = 3;
            this.setalt.Text = "Set Altitude:";
            // 
            // autoclosebtn
            // 
            this.autoclosebtn.Font = new System.Drawing.Font("Montserrat SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoclosebtn.Location = new System.Drawing.Point(13, 180);
            this.autoclosebtn.Margin = new System.Windows.Forms.Padding(4);
            this.autoclosebtn.Name = "autoclosebtn";
            this.autoclosebtn.Size = new System.Drawing.Size(240, 76);
            this.autoclosebtn.TabIndex = 4;
            this.autoclosebtn.Text = "Close";
            this.autoclosebtn.UseVisualStyleBackColor = true;
            this.autoclosebtn.Click += new System.EventHandler(this.autoclosebtn_Click);
            // 
            // autoinfo
            // 
            this.autoinfo.AutoSize = true;
            this.autoinfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.autoinfo.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoinfo.ForeColor = System.Drawing.Color.Red;
            this.autoinfo.Location = new System.Drawing.Point(18, 30);
            this.autoinfo.Name = "autoinfo";
            this.autoinfo.Size = new System.Drawing.Size(1010, 46);
            this.autoinfo.TabIndex = 5;
            this.autoinfo.Text = "Autopilot Altitude can be set from 1500 feets to 15000 feets.";
            // 
            // autofeets
            // 
            this.autofeets.AutoSize = true;
            this.autofeets.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autofeets.Location = new System.Drawing.Point(463, 108);
            this.autofeets.Name = "autofeets";
            this.autofeets.Size = new System.Drawing.Size(101, 44);
            this.autofeets.TabIndex = 6;
            this.autofeets.Text = "feets";
            // 
            // autopilotform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 279);
            this.ControlBox = false;
            this.Controls.Add(this.autofeets);
            this.Controls.Add(this.autoinfo);
            this.Controls.Add(this.autoclosebtn);
            this.Controls.Add(this.setalt);
            this.Controls.Add(this.autobtn);
            this.Controls.Add(this.alttext);
            this.Font = new System.Drawing.Font("Montserrat SemiBold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "autopilotform";
            this.Text = "Autopliot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox alttext;
        private System.Windows.Forms.Button autobtn;
        private System.Windows.Forms.Label setalt;
        private System.Windows.Forms.Button autoclosebtn;
        private System.Windows.Forms.Label autoinfo;
        private System.Windows.Forms.Label autofeets;
    }
}