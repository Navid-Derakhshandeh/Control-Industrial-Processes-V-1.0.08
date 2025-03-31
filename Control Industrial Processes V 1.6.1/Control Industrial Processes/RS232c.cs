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
using System.IO.Ports;

namespace Control_Industrial_Processes
{
    public partial class RS232c : Form
    {
        public RS232c()
        {
            InitializeComponent();
        }
        private void getport()
        {
            string[] Ports = SerialPort.GetPortNames();

            foreach (string Port in Ports)
            {
                cbop.Items.Add(Port);
            }
            cbop.SelectedIndex = 0;
        }
        private delegate void settext(string TXT);

        private void datareceive(string Data)
        {
            txtR.Text = Data.Trim();
        }

        SerialPort serialports;
        private void connectserial()
        {
            serialports = new SerialPort(cbop.Text, 19200, Parity.None, 8, StopBits.One);
            serialports.Handshake = Handshake.None;
            serialports.DataReceived += new SerialDataReceivedEventHandler(serialdata);
            serialports.WriteTimeout = 500;
            serialports.Open();
        }

        private void serialdata(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort seriaports = (SerialPort)sender;
            string data = seriaports.ReadExisting();
            this.BeginInvoke(new settext(datareceive), new object[] { data });
        }

        private void RS232c_Load(object sender, EventArgs e)
        {
            getport();
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            if (serialports.IsOpen)
            {
                serialports.WriteLine(txtS.Text);
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            try
            {
                connectserial();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
    
}
