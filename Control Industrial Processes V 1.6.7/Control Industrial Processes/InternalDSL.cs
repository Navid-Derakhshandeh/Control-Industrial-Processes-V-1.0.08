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
using System.IO;
namespace Control_Industrial_Processes
{
    public partial class InternalDSL : Form
    {
        
        public InternalDSL()
        {
            InitializeComponent();
        }
       
        private void btnIDSL_Click(object sender, EventArgs e)
        {
            ModbusClient modbusClient = new ModbusClient("127.0.0.1", 502);
            modbusClient.Connect();
          
                string command = txtCommand.Text.ToString();
                string[] parts = command.Split();
                if(parts.Length == 3 && parts[0].ToLower()=="increase" && parts[1].ToLower()=="temp")
                {
                    int value;
                    if(int.TryParse(parts[2], out value))
                    {
                        modbusClient.WriteSingleRegister(0, value);
                        
                        int[] value1 = modbusClient.ReadHoldingRegisters(0, 10);
                        int value2 = value1[0];
                        txtExecute.Text = "Temperature increased to " + value2.ToString() + " and writen to register 0";
                }
                    else
                    {
                        txtExecute.Text = "invalid Command Format. Try Again";
                        
                    }
                    
                }
                modbusClient.Disconnect();
            
           

        }

        
    }
}
