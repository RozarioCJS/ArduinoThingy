namespace ArduinoThingy
{
    partial class ArduinoThing
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
            this.components = new System.ComponentModel.Container();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.cmbComport = new System.Windows.Forms.ComboBox();
            this.cmbBaudrate = new System.Windows.Forms.ComboBox();
            this.rtbSerial = new System.Windows.Forms.RichTextBox();
            this.rtbOutgoing = new System.Windows.Forms.RichTextBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 236);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(99, 45);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(12, 310);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(99, 45);
            this.btnDisconnect.TabIndex = 1;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(150, 236);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(99, 45);
            this.btnScan.TabIndex = 2;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(293, 236);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 45);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(293, 310);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(99, 45);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // cmbComport
            // 
            this.cmbComport.FormattingEnabled = true;
            this.cmbComport.Location = new System.Drawing.Point(12, 119);
            this.cmbComport.Name = "cmbComport";
            this.cmbComport.Size = new System.Drawing.Size(163, 21);
            this.cmbComport.TabIndex = 5;
            // 
            // cmbBaudrate
            // 
            this.cmbBaudrate.FormattingEnabled = true;
            this.cmbBaudrate.Items.AddRange(new object[] {
            "9600"});
            this.cmbBaudrate.Location = new System.Drawing.Point(229, 119);
            this.cmbBaudrate.Name = "cmbBaudrate";
            this.cmbBaudrate.Size = new System.Drawing.Size(163, 21);
            this.cmbBaudrate.TabIndex = 6;
            // 
            // rtbSerial
            // 
            this.rtbSerial.Location = new System.Drawing.Point(12, 13);
            this.rtbSerial.Name = "rtbSerial";
            this.rtbSerial.Size = new System.Drawing.Size(162, 217);
            this.rtbSerial.TabIndex = 7;
            this.rtbSerial.Text = "";
            this.rtbSerial.Visible = false;
            // 
            // rtbOutgoing
            // 
            this.rtbOutgoing.Location = new System.Drawing.Point(122, 22);
            this.rtbOutgoing.Name = "rtbOutgoing";
            this.rtbOutgoing.Size = new System.Drawing.Size(162, 46);
            this.rtbOutgoing.TabIndex = 8;
            this.rtbOutgoing.Text = "";
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // ArduinoThing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 366);
            this.Controls.Add(this.rtbOutgoing);
            this.Controls.Add(this.rtbSerial);
            this.Controls.Add(this.cmbBaudrate);
            this.Controls.Add(this.cmbComport);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Name = "ArduinoThing";
            this.Text = "ArduinoThing";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ComboBox cmbComport;
        private System.Windows.Forms.ComboBox cmbBaudrate;
        private System.Windows.Forms.RichTextBox rtbSerial;
        private System.Windows.Forms.RichTextBox rtbOutgoing;
        private System.IO.Ports.SerialPort serialPort;
    }
}

