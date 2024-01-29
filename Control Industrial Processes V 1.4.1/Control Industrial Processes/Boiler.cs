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
    public partial class Boiler : Form
    {
        ModbusClient modbusClient3;
        public Boiler()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Boiler_Load(object sender, EventArgs e)
        {

        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            try
            {
                modbusClient3 = new ModbusClient(txtIPS.Text, 502);
                modbusClient3.Connect();
                Lbc1.Text = "Connected";
                timer1.Enabled = true;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\Air-raid-siren (online-audio-converter.com).wav");
                player.Stop();
            }

            catch (Exception ex)
            {
                Lbc1.Text = ex.ToString();
                throw;
            }
        }
        private void btnSTP_Click(object sender, EventArgs e)
        {
            modbusClient3.Disconnect();
            Lbc1.Text = "Offline";
            timer1.Enabled = false;
            ledvalve.Blink(0);
            ledMotor.Blink(0);
            ledM1.Blink(0);
            ledfail.Blink(0);
            ledSV.Blink(0);
            ledSVG.Blink(0);
            ledSVGfail.Blink(0);
            ledScfail.Blink(0);
            txtv1.Text = 0.ToString();
            
        }

            private void timer1_Tick(object sender, EventArgs e)
            {
                int[] readHoldingRegisters = modbusClient3.ReadHoldingRegisters(0, 10);
                bool[] readCoils = modbusClient3.ReadCoils(9, 10);
                //modbusClient3.WriteSingleRegister(1, 100);
                int c28 = readHoldingRegisters[1];

                if (c28 == 220)
                {
                    ledSV.Blink(200);

                    modbusClient3.WriteSingleRegister(4, 220);
                    modbusClient3.WriteSingleCoil(2, true);
                }
                else
                {
                    ledScfail.Blink(200);
                }

                int c33 = readHoldingRegisters[0];


                if (c33 == 100)
                {
                    ledMotor.Blink(200);

                }
                else
                {
                    ledMotor.Blink(0);
                    ledM1.Blink(200);
                }

                int c31 = readHoldingRegisters[2];
                string c30 = "fail";
                int c29 = 220;
                if (c31 == 150)
                {
                    modbusClient3.WriteSingleRegister(3, 220);
                    ledvalve.Blink(200);
                    txtv1.Text = c29.ToString();
                }
                else
                {
                    ledfail.Blink(200);
                    txtv1.Text = c30;
                    ledvalve.Blink(0);
                }
                if (readHoldingRegisters[4] == 220 && readHoldingRegisters[1] == 220)
                {
                    ledSVG.Blink(200);
                }
                else
                {
                    ledSVG.Blink(200);
                }
                int tmp1 = readHoldingRegisters[5];
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\Air-raid-siren (online-audio-converter.com).wav");
                if (tmp1 >= 150)
                {
                   
                   player.Play();
                   ledTemp1.Blink(200);
                   lbTemp1.Text = "High";
                   btnSTP.PerformClick();
                   
                }
                else
                {
                   lbTemp1.Text = tmp1.ToString();
                   ledTemp1.Blink(0);
                   
                }
                int p12 = readHoldingRegisters[6];
                if (p12 <= 170)
                {
                    LbP1.Text = readHoldingRegisters[6].ToString();
                }
                else if (p12 >= 171)
                {
                    LbP1.Text = "High";
                }
                else
                {
                    ledP1.Blink(200);
                }
            }
    }
}
