using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoThingy
{
    public partial class ArduinoThing : Form
    {
        public ArduinoThing()
        {
            InitializeComponent();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            cmbComport.Text = "";
            cmbComport.Items.Clear();
            String[] ports = SerialPort.GetPortNames();
            cmbComport.Items.AddRange(ports);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (ConnectPort())
            {
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                cmbBaudrate.Enabled = false;
                cmbComport.Enabled = false;
            }
        }
        public bool ConnectPort()
        {
            try
            {
                if (cmbComport.Text != "" || cmbBaudrate.Text != "")
                {
                    serialPort.PortName = cmbComport.Text;
                    serialPort.BaudRate = int.Parse(cmbBaudrate.Text);
                    serialPort.Open();
                    return true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error!",MessageBoxButtons.OK);
                return false;
            }
            return false;
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            serialPort.Close();
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            cmbBaudrate.Enabled = true;
            cmbComport.Enabled = true;
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(serialPort_DataReceived));
        }
        private void serialPort_DataReceived(object sender, EventArgs e)
        {
            string dump = serialPort.ReadLine();
            rtbSerial.Text = rtbSerial.Text + dump;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbSerial.Text = "";
            serialPort.Write("clear");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if(!(serialPort.IsOpen))
                {
                    serialPort.Open();
                }
                serialPort.Write(rtbOutgoing.Text);
                rtbOutgoing.Text = "";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR!",MessageBoxButtons.OK);
            }


        }
    }
}
