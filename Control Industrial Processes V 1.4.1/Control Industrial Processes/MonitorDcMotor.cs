using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;

namespace Control_Industrial_Processes
{
    public enum CpuType
    {
        S7200 = 0,
        S7300 = 10,
        S7400 = 20,
        S71200 = 30,
        S71500 = 40,
    }
    public partial class MonitorDcMotor : Form
    {
        
        Plc plc = new Plc((S7.Net.CpuType)CpuType.S71500, "127.0.0.1", 0, 1);
        
        public MonitorDcMotor()
        {
            plc.Open();
            InitializeComponent();
        }

        private void MonitorDcMotor_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string on = "ON";
            string off = "OFF";
            
            
            bool Bool1 = (bool)plc.Read("I0.0");
            if(Bool1==false)
            {
                txtBPower.Text = off;
            }
            else if(Bool1==true)
            {
                txtBPower.Text = on;
            }
            bool Bool2 = (bool)plc.Read("Q0.0");
            
            
            if (Bool2 == false)
            {
                txtDC.Text = off;
            }
            else if (Bool2 == true)
            {
                txtDC.Text = on;
            }
            short result = ((ushort)plc.Read("MW2")).ConvertToShort();
            txtVoltage.Text = result.ToString();
        }

        private void MonitorDcMotor_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }
    }
}
