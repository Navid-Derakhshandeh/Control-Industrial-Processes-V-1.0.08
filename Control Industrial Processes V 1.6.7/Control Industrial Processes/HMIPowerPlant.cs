using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace Control_Industrial_Processes
{
    public partial class HMIPowerPlant : Form
    {
        
        private Timer timerfan;
        private float angle;
        private int chargeLevel;
        private int vaporOffset;
        private int bubbleOffset;
        private int fireFlicker;
        private float angleSeries1, angleSeries2;
        private int outletOffset = 0;
        private int Fan;
        private int Boiler;
        private int turbine;
        private int Tower;
        private int Battery;
        public MqttClient mqttclient;
        public HMIPowerPlant()
        {
            InitializeComponent();
            timerfan = new Timer { Interval = 50 }; // Animation speed
            timerfan.Tick += Timerfan_Tick;
            timerfan.Start();
            timerBattery.Interval = 3000;
            timerBattery.Tick += timerBattery_Tick;
            timerBattery.Start();
            timerCooling.Interval = 100;
            timerCooling.Tick += timerCooling_Tick;
            timerCooling.Start();
            timerBoiler.Interval = 100; // Animation speed
            timerBoiler.Tick += timerBoiler_Tick;
            timerBoiler.Start();
            timerTurbine.Interval = 50; // Speed of turbine rotation
            timerTurbine.Tick += timerTurbine_Tick;
            timerTurbine.Start();
            
        }
        private void Timerfan_Tick(object sender, EventArgs e)
        {
            angle += 5; // Increment angle
            if (angle >= 360) angle = 0; // Reset angle
            if(Fan>=50)
            {
                picFan.Invalidate(); // Refresh the PictureBox
            }
            
        }
        private void picFan_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Center of the fan
            int centerX = picFan.Width / 2;
            int centerY = picFan.Height / 2;

            // Circle radius (based on blade size and padding)
            int bladeSize = 50; // Blade length
            int circleRadius = bladeSize * 1;

            // Draw the circle
            g.DrawEllipse(Pens.Black, centerX - circleRadius, centerY - circleRadius, circleRadius * 2, circleRadius * 2);

            // Draw the fan blades
            g.TranslateTransform(centerX, centerY); // Center origin
            for (int i = 0; i < 4; i++) // 4 Blades
            {
                g.RotateTransform(angle + i * 90); // Rotate each blade
                g.FillPie(Brushes.Blue, -bladeSize, -bladeSize, bladeSize * 2, bladeSize * 2, 0, 30); // Draw blade
                g.ResetTransform();
                g.TranslateTransform(centerX, centerY);
            }
        }

        private void picBattery_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Battery dimensions
            int batteryWidth = picBattery.Width - 20; // Battery container width
            int batteryHeight = picBattery.Height - 40; // Battery container height
            int batteryX = 10; // X-coordinate
            int batteryY = 10; // Y-coordinate

            // Draw battery outline
            g.DrawRectangle(Pens.Black, batteryX, batteryY, batteryWidth, batteryHeight);

            // Draw battery positive terminal
            g.FillRectangle(Brushes.Black, batteryX + batteryWidth, batteryY + batteryHeight / 4, 10, batteryHeight / 2);

            // Draw charge level inside battery
            int chargeHeight = (int)(chargeLevel / 100.0 * batteryHeight); // Calculate charge height
            g.FillRectangle(Brushes.Green, batteryX + 2, batteryY + batteryHeight - chargeHeight, batteryWidth - 4, chargeHeight);

            // Display charge percentage
            g.DrawString($"{chargeLevel}%", new Font("Arial", 10), Brushes.Black, batteryX + batteryWidth / 4, batteryY + batteryHeight + 5);
        }

        private void timerBattery_Tick(object sender, EventArgs e)
        {
            chargeLevel += 5; // Increment charge level
            if (chargeLevel > 100) chargeLevel = 0; // Reset after full charge
            if(Battery >=60)
            {
                picBattery.Invalidate(); // Refresh the PictureBox
            }
            
        }

        private void picCooling_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Draw cooling tower (trapezoid shape)
            Point[] towerPoints = {
            new Point(80, picCooling.Height - 20),  // Bottom-left
            new Point(220, picCooling.Height - 20), // Bottom-right
            new Point(180, 50),                     // Top-right
            new Point(120, 50)                      // Top-left
        };
            g.FillPolygon(Brushes.Gray, towerPoints);

            // Draw water vapor rising
            for (int i = 0; i < 5; i++) // 5 vapor clouds
            {
                int x = 130 + (i * 10) - vaporOffset; // Vary x-position
                int y = 30 - (i * 15);               // Vary y-position
                int size = 40 - (i * 5);             // Shrink size as it rises
                g.FillEllipse(Brushes.LightGray, x, y, size, size);
            }
            
        }

        private void timerCooling_Tick(object sender, EventArgs e)
        {
            vaporOffset += 5; // Move vapor horizontally
            if (vaporOffset > 30) vaporOffset = 0; // Reset offset for looping
            if(Tower>=70)
            {
                picCooling.Invalidate(); // Refresh the PictureBox
            }
            
        }

        private void picBoiler_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int boilerX = picBoiler.Width / 2 - 80; // X-coordinate of the cylinder's top-left corner
            int boilerY = 120;                       // Y-coordinate of the cylinder's top
            int boilerWidth = 160;                   // Width of the cylinder
            int boilerHeight = 200;                  // Height of the cylinder

            // Draw the top ellipse (cylinder top)
            g.FillEllipse(Brushes.Gray, boilerX, boilerY, boilerWidth, 40);
            g.DrawEllipse(Pens.Black, boilerX, boilerY, boilerWidth, 40);

            // Draw the rectangular body of the cylinder
            g.FillRectangle(Brushes.Gray, boilerX, boilerY + 20, boilerWidth, boilerHeight - 40);
            g.DrawRectangle(Pens.Black, boilerX, boilerY + 20, boilerWidth, boilerHeight - 40);

            // Draw the bottom ellipse (cylinder base)
            g.FillEllipse(Brushes.Gray, boilerX, boilerY + boilerHeight - 40, boilerWidth, 40);
            g.DrawEllipse(Pens.Black, boilerX, boilerY + boilerHeight - 40, boilerWidth, 40);

            //// Draw main boiler (rectangular body)
            //int boilerX = pictureBox4.Width / 2 - 80;
            //int boilerY = 120;
            //g.FillRectangle(Brushes.Gray, boilerX, boilerY, 160, 200);
            //g.DrawRectangle(Pens.Black, boilerX, boilerY, 160, 200);

            // Draw water inside boiler
            int waterHeight = 100;
            int waterY = boilerY + 200 - waterHeight;
            g.FillRectangle(Brushes.Blue, boilerX + 2, waterY, 156, waterHeight);

            // Draw bubbles in water
            for (int i = 0; i < 4; i++)
            {
                int bubbleX = boilerX + 40 + (i * 20) - bubbleOffset;
                int bubbleY = waterY - (i * 20);
                int bubbleSize = 15;
                g.FillEllipse(Brushes.LightBlue, bubbleX, bubbleY, bubbleSize, bubbleSize);
            }

            // Draw fire beneath the boiler
            for (int i = 0; i < 3; i++)
            {
                int fireX = boilerX + 20 + (i * 50);
                int fireY = boilerY + 210;
                int fireHeight = 30 + fireFlicker;
                g.FillPolygon(Brushes.OrangeRed, new Point[]
                {
                new Point(fireX, fireY),
                new Point(fireX + 25, fireY - fireHeight),
                new Point(fireX + 50, fireY)
                });
            }

            // Draw water pipe with flow effect
            int pipeX = boilerX + 160;
            int pipeY = boilerY + 60;
            g.FillRectangle(Brushes.DarkGray, pipeX, pipeY, 20, 100);
            g.DrawRectangle(Pens.Black, pipeX, pipeY, 20, 100);

            // Flowing water drops
            int dropY = pipeY + bubbleOffset % 100;
            g.FillEllipse(Brushes.Blue, pipeX + 5, dropY, 10, 10);
        }

        private void timerBoiler_Tick(object sender, EventArgs e)
        {
            bubbleOffset += 10; // Move bubbles and water drops
            if (bubbleOffset > 100) bubbleOffset = 0;

            fireFlicker = fireFlicker == 10 ? 0 : 10; // Flicker fire height
            if(Boiler>=80)
            {
                picBoiler.Invalidate(); // Refresh the PictureBox
            }
            
        }

        private void timerTurbine_Tick(object sender, EventArgs e)
        {
            angleSeries1 += 10; // First series rotates clockwise
            angleSeries2 += 5;  // Second series rotates counter-clockwise (slower for effect)
            if (angleSeries1 >= 360) angleSeries1 = 0;
            if (angleSeries2 >= 360) angleSeries2 = 0;

            outletOffset += 5;
            if (outletOffset > 20) outletOffset = -20; // Create oscillation effect
            if(turbine>=90)
            {
                picTurbine.Invalidate();
            }
           
        }

        

        private void picTurbine_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Center of the turbine
            int centerX = picTurbine.Width / 2;
            int centerY = picTurbine.Height / 2;

            // Draw glowing fire chamber
            int fireRadius = 70;
            g.FillEllipse(Brushes.OrangeRed, centerX - fireRadius, centerY - fireRadius, fireRadius * 2, fireRadius * 2);

            // Draw the gas outlet (as a cone)
            //g.FillPolygon(Brushes.Gray, new Point[]
            //{
            //new Point(centerX - 60, centerY + 60), // Left
            //new Point(centerX + 60, centerY + 60), // Right
            //new Point(centerX, centerY + 120)      // Bottom (outlet point)
            //});
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Center of the turbine


            // Draw turbine frame and blades here (if needed)...


            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;



            // Draw turbine frame here if necessary...

            // Draw gas outlet



            // Create vapor effect
            Random rand = new Random();
            for (int i = 0; i < 10; i++) // 10 vapor particles
            {
                int x = centerX - 40 + rand.Next(80); // Randomize horizontal position
                int y = centerY + 80 + vaporOffset + rand.Next(20); // Vertical movement
                int size = rand.Next(5, 15); // Random size for particles
                Color vaporColor = Color.FromArgb(rand.Next(100, 200), 200, 200, 200); // Semi-transparent vapor
                using (SolidBrush brush = new SolidBrush(vaporColor))
                {
                    g.FillEllipse(brush, x, y, size, size); // Draw vapor particle
                }
            }


            // Draw first series of rotating blades
            int bladeLength = 70, bladeWidth = 10;
            g.TranslateTransform(centerX, centerY); // Set rotation center
            for (int i = 0; i < 8; i++) // 6 blades in the first series
            {
                g.RotateTransform(angleSeries1 + i * 60); // Rotate each blade
                g.FillPolygon(Brushes.LightGray, new Point[]
                {
                new Point(-bladeWidth / 2, 0),    // Narrow top
                new Point(-bladeWidth / 2, -bladeLength), // Left
                new Point(bladeWidth / 2, -bladeLength),  // Right
                new Point(bladeWidth / 2, 0)     // Bottom
                });
            }
            g.ResetTransform();

            //Draw second series of counter - rotating blades
            g.TranslateTransform(centerX, centerY); // Set rotation center
            for (int i = 0; i < 8; i++) // 6 blades in the second series
            {
                g.RotateTransform(-angleSeries2 + i * 60); // Rotate in the opposite direction
                g.FillPolygon(Brushes.DarkGray, new Point[]
                {
                new Point(-bladeWidth / 2, 0),    // Narrow top
                new Point(-bladeWidth / 2, -bladeLength), // Left
                new Point(bladeWidth / 2, -bladeLength),  // Right
                new Point(bladeWidth / 2, 0)     // Bottom
                });
            }
            g.ResetTransform();
            int frameRadius = 70;
            g.DrawEllipse(Pens.Black, centerX - frameRadius, centerY - frameRadius, frameRadius * 2, frameRadius * 2);
            g.TranslateTransform(centerX, centerY); // Center origin for blade rotation
            for (int i = 0; i < 6; i++) // 6 blades
            {
                g.RotateTransform(angle + i * 60); // Rotate each blade
                g.FillPolygon(Brushes.DarkGray, new Point[]
                {
                new Point(0, -10), // Top point
                new Point(-10, -40), // Left point
                new Point(10, -40)  // Right point
                });
                g.ResetTransform();
                g.TranslateTransform(centerX, centerY);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            mqttclient = new MqttClient("localhost");
            mqttclient.Connect("clientid_1", "test", "test@unit1");
            if (mqttclient.IsConnected)
            {
                mqttclient.MqttMsgPublishReceived += mqttclient_mqttmessagepublishreceived;
                string[] Topics = new string[5];
                Topics[0] = "hmi1/tag1";
                Topics[1] = "hmi1/tag2";
                Topics[2] = "hmi1/tag3";
                Topics[3] = "hmi1/tag4";
                Topics[4] = "hmi1/tag5";
                byte[] message = new byte[5];
                message[0] = MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE;
                message[1] = MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE;
                message[2] = MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE;
                message[3] = MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE;
                message[4] = MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE;
                mqttclient.Subscribe(Topics, message);

            }
        }

        

        
        private void HMIPowerPlant_FormClosing(object sender, FormClosingEventArgs e)
        {
            mqttclient.Disconnect();
        }

        

        private void mqttclient_mqttmessagepublishreceived(object sender, MqttMsgPublishEventArgs e)
        {
            string Topic = e.Topic;
            string Value = Encoding.UTF8.GetString(e.Message);

            if (Topic == "hmi1/tag1")
            {
                txtFan.Invoke(new Action(() => txtFan.Text = Value));
                Fan = int.Parse(txtFan.Text);

            }
            if (Topic == "hmi1/tag2")
            {
                txtTemp.Invoke(new Action(() => txtTemp.Text = Value));
                Boiler = int.Parse(txtTemp.Text);

            }
            if (Topic == "hmi1/tag3")
            {
                txtTurbine.Invoke(new Action(() => txtTurbine.Text = Value));
                turbine = int.Parse(txtTurbine.Text);

            }
            if (Topic == "hmi1/tag4")
            {
                txtTower.Invoke(new Action(() => txtTower.Text = Value));
                Tower = int.Parse(txtTower.Text);

            }
            if (Topic == "hmi1/tag5")
            {
                txtBattery.Invoke(new Action(() => txtBattery.Text = Value));
                Battery = int.Parse(txtBattery.Text);

            }


        }
    }
}
