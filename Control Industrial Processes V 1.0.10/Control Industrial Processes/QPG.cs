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
    public partial class QPG : Form
    {
        string connString = @"Data Source=DESKTOP-21H6HAU\DESKTOP;Initial Catalog=Industrial;Integrated Security=True;
            Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        SqlDataAdapter dataAdapter;
        System.Data.DataTable table;
        SqlConnection conn;
        string selectionStatement = "Select * from Efficiency";
        ModbusClient modbusClient10;
        public QPG()
        {
            InitializeComponent();
        }

        private void QPG_Load(object sender, EventArgs e)
        {
            DateTime DT = DateTime.Now;
            txtDT.Text = (DT.ToString("MM/dd/yyyy HH:mm:ss"));
            GetData(selectionStatement);
        }
        private void GetData(string selectCommand)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, connString);
                table = new System.Data.DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            
                modbusClient10 = new ModbusClient(txtIP.Text, 502);
                modbusClient10.Connect();
                Lbc2.Text = "Connected";
                timer1.Enabled = true;
                

            
            
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            modbusClient10.Disconnect();
            Lbc2.Text = "Offline";
            timer1.Enabled = false;
            ledBulb1.Blink(0);
            ledBulb2.Blink(0);
            ledBulb3.Blink(0);
            ledBulb4.Blink(500);
            ledBulb5.Blink(500);
            ledBulb6.Blink(500);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int[] readHoldingRegisters = modbusClient10.ReadHoldingRegisters(0, 10);
            bool[] readCoils = modbusClient10.ReadCoils(9, 10);
            int G = readHoldingRegisters[0];
            int W = readHoldingRegisters[1];
            int P = readHoldingRegisters[2];

            sevenSegmentArray1.Value = G.ToString();
            sevenSegmentArray2.Value = W.ToString();
            sevenSegmentArray3.Value = P.ToString();
            if (G >= 1 && W >= 1 && P >= 1)
            {
                ledBulb1.Blink(200);
                ledBulb2.Blink(200);
                ledBulb3.Blink(200);
            }
            else
            {

            }
            SqlCommand command;
            string insert = @"insert into Efficiency(Date, Water, Gas, Power)

                               values(@Date, @Water, @Gas, @Power)";
            using (conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    command = new SqlCommand(insert, conn);
                    command.Parameters.AddWithValue(@"Date", txtDT.Text);
                    command.Parameters.AddWithValue("@Water", W);
                    command.Parameters.AddWithValue("@Power", P);
                    command.Parameters.AddWithValue("@Gas", G);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }


            }
            GetData(selectionStatement);
        }
    }
}
