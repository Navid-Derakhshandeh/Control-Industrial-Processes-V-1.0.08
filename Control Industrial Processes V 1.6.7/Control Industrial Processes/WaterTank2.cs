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
    public partial class WaterTank2 : Form
    {
        private int tankcapacity = 70;
        private int currentlevel = 0;
        private Panel panel1;
        private ModbusClient link1;
        public WaterTank2()
        {
            InitializeComponent();
            panel1 = new Panel
            {
                BackColor = Color.Blue,
                Width = 125,
                Height = 0,
                Location = new Point(63, 190)

            };
            link1 = new ModbusClient("127.0.0.1", 502);
        }
        private void updateWaterLevel(int change)
        {
            currentlevel += change;

            if (currentlevel > tankcapacity)
            {
                currentlevel = tankcapacity;
                MessageBox.Show("overflow! The Tank is Full");
            }
            else if (currentlevel < 0)
            {
                currentlevel = 0;
                MessageBox.Show("The tank is empty!");
            }
            panel1.Height = (int)(currentlevel * 1.5);
            panel1.Location = new Point(63, 190 + (0 - panel1.Height));
            label1.Text = $"Current level : {currentlevel}00/{tankcapacity}00";

        }
        private void btnconnect_Click(object sender, EventArgs e)
        {
            try
            {
                link1.Connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                link1.Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            if(link1.Connected)
            {
                updateWaterLevel(10);
                pictureBox1.Controls.Add(panel1);
                link1.WriteSingleRegister(0, currentlevel);
            }
            else
            {
                MessageBox.Show("You are Disconnected!");
            }
            
        }

        private void btnDrain_Click(object sender, EventArgs e)
        {
            if (link1.Connected)
            {
                updateWaterLevel(-10);
                link1.WriteSingleRegister(0, currentlevel);
            }
            else
            {
                MessageBox.Show("You are Disconnected!");
            }

        }
    }
}
