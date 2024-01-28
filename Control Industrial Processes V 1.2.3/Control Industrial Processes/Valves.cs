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
using Microsoft.Toolkit.Uwp.Notifications;
namespace Control_Industrial_Processes
{
    public partial class Valves : Form
    {
        ModbusClient modbusClient2;
        public Valves()
        {
            InitializeComponent();
            modbusClient2 = new ModbusClient("COM7");
            modbusClient2.UnitIdentifier = 1;
            modbusClient2.Baudrate = 9600;
            modbusClient2.Parity = System.IO.Ports.Parity.None;
            modbusClient2.StopBits = System.IO.Ports.StopBits.Two;
            modbusClient2.Connect();
        }

        private void Valves_Load(object sender, EventArgs e)
        {
            new ToastContentBuilder()
            .AddText("Welcome")
            .AddText("Program Has Started")
            .Show();
            DateTime DT = DateTime.Now;
            txtDate.Text = (DT.ToString("MM/dd/yyyy HH:mm:ss"));
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            modbusClient2.WriteSingleCoil(4, true);
        }

        private void btnA1_Click(object sender, EventArgs e)
        {
            modbusClient2.WriteSingleCoil(4, false);
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            modbusClient2.WriteSingleCoil(5, true);
        }

        private void btnV1_Click(object sender, EventArgs e)
        {
            modbusClient2.WriteSingleCoil(5, false);
        }
    }
}
