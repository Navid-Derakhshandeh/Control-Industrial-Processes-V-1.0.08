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
    public partial class DieselGen : Form
    {
        ModbusClient modbusClient5;
        public DieselGen()
        {
            InitializeComponent();
            modbusClient5 = new ModbusClient("COM9");
            modbusClient5.UnitIdentifier = 1;
            modbusClient5.Baudrate = 9600;
            modbusClient5.Parity = System.IO.Ports.Parity.None;
            modbusClient5.StopBits = System.IO.Ports.StopBits.Two;
            modbusClient5.Connect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x22 = knobControl1.Value;
            modbusClient5.WriteSingleRegister(9, x22);
            int[] readholdingreg = modbusClient5.ReadHoldingRegisters(0, 10);
            
            modbusClient5.WriteSingleCoil(3, true);
            
            int[] readinputreg = modbusClient5.ReadInputRegisters(9, 10);
            int x23 = readholdingreg[4];
            sevenSegmentArray1.Value = x23.ToString();
            
        }

        

        private void DieselGen_Load(object sender, EventArgs e)
        {
            sevenSegment1.Value = 1.ToString();
        }

        
    }
}
