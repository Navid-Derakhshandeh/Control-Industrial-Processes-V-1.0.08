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
using System.Diagnostics;
using System.Data.SqlClient;

namespace Control_Industrial_Processes
{
    public partial class ConveyorbeltSpeed : Form
    {
        ModbusClient modbusClient;
        public ConveyorbeltSpeed()
        {
            InitializeComponent();
        }
        
        private Bitmap[] Pics;
        private int PicsNumber = 0;

        private void ConveyorbeltSpeed_Load(object sender, EventArgs e)
        {
            
            Pics = new Bitmap[10];
            for (int i = 0; i < 10; i++)
            {
                Pics[i] = new Bitmap("CB" + i + ".png");
            }
            picBox1.Image = Pics[PicsNumber];
            ClientSize = new Size(
                 picBox1.Right + picBox1.Left,
                 picBox1.Bottom + picBox1.Left);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            try
            {

                modbusClient = new ModbusClient(ServerIP.Text, 502);
                modbusClient.Connect();
                label2.Text = "Connected";
                timer1.Enabled = true;
            }
            catch (Exception ex)
            {
                label2.Text = ex.ToString();
                throw;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            DateTime DT = DateTime.Now;
            txtDate.Text = (DT.ToString("MM/dd/yyyy HH:mm:ss"));
            modbusClient.WriteMultipleCoils(4, new bool[] { true, true, true, true, true, true, true, true, true, true });
            bool[] readCoils = modbusClient.ReadCoils(9, 10);
            int[] readHoldingRegisters = modbusClient.ReadHoldingRegisters(0, 10);
            int a = readHoldingRegisters[0];
            txtSpeed.Text = a.ToString();

        }

        private void btnD_Click(object sender, EventArgs e)
        {
            modbusClient.Disconnect();
            label2.Text = "Offline";
            timer1.Enabled = false;
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            timer2.Enabled = !timer2.Enabled;

            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int a = int.Parse(txtSpeed.Text);
            timer2.Interval = 1000 / a;
           
            PicsNumber = ++PicsNumber % Pics.Length;
            picBox1.Image = Pics[PicsNumber];
        }
    }
}
