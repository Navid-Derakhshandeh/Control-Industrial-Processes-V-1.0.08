using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;

namespace Control_Industrial_Processes
{
    public partial class WaterTank : Form
    {
        ModbusClient modbusClient12;
        public WaterTank()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime DT = DateTime.Now;
            txtDT.Text = (DT.ToString("MM/dd/yyyy HH:mm:ss"));
            timer1.Enabled = true;
            modbusClient12.WriteMultipleCoils(4, new bool[] { true, true, true, true, true, true, true, true, true, true });
            bool[] readCoils = modbusClient12.ReadCoils(9, 10);
            int[] readHoldingRegisters = modbusClient12.ReadHoldingRegisters(0, 10);

            int a = readHoldingRegisters[0];
            int b = readHoldingRegisters[1];
            int c = readHoldingRegisters[2];
            int d = readHoldingRegisters[3];

            if (a >= 50)
            {
                picTG.Visible = true;
                picTR.Visible = false;
            }
            else
            {
                picTG.Visible = false;
                picTR.Visible = true;
            }
            if(b >= 50)
            {
                picOG.Visible = true;
                picOR.Visible = false;
            }
            else
            {
                picOG.Visible = false;
                picOR.Visible = true;
            }
            if(c >= 50)
            {
                picMG.Visible = true;
                picMR.Visible = false;
            }
            else
            {
                picMG.Visible = false;
                picMR.Visible = true;
            }
            if(d >= 50)
            {
                picPG.Visible = true;
                picPR.Visible = false;
            }
            else
            {
                picPG.Visible = false;
                picPR.Visible = true;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                modbusClient12 = new ModbusClient(txtIP.Text, 502);
                modbusClient12.Connect();
                lbC.Text = "Connected";
                timer1.Enabled = true;
            }
            catch (Exception ex)
            {
                lbC.Text = ex.ToString();
                throw;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            modbusClient12.Disconnect();
            lbC.Text = "Offline";
            timer1.Enabled = false;
            picTR.Visible = true;
            picOR.Visible = true;
            picMR.Visible = true;
            picPR.Visible = true;
        }
    }
}
