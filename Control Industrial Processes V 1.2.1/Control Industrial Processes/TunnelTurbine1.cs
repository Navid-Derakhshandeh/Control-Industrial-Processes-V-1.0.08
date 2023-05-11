using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Opc.UaFx.Client;
namespace Control_Industrial_Processes
{
    public partial class TunnelTurbine1 : Form
    {
        
        OpcClient Opc = new OpcClient("opc.tcp://localhost:62640/");

        public TunnelTurbine1()
        {
            InitializeComponent();
            
        }
        

        private void Cbtn_Click(object sender, EventArgs e)
        {
            try
            {

                Opc.Connect();
                timer1.Start();
                lblc.Text = "Connected";
                
            }
            catch (Exception ex)
            {
                lblc.Text = ex.ToString();
                throw;
            }

            
        }

        private void Dbtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (Opc != null)
            {
                Opc.Disconnect();
            }
            lblc.Text = "Disconnected";
        }

        private void TunnelTurbine1_Load(object sender, EventArgs e)
        {
            DateTime DT = DateTime.Now;
            txtDT.Text = (DT.ToString("MM/dd/yyyy HH:mm:ss"));
            if (Opc != null)
            {
                Opc.Disconnect();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Opc.Connect();
            //timer1.Enabled = false;
            var Tag3 = "ns=2;s=Tag3";
            int Power = knobControl1.Value;
            Opc.WriteNode(Tag3, Power);
            double Divide = Power / 3;
            var Tag7 = "ns=2;s=Tag7";
            Opc.WriteNode(Tag7, Divide);
            var Turbine = Opc.ReadNode(Tag7);
            txt1.Text = Turbine.ToString();
            txt2.Text = Turbine.ToString();
            txt3.Text = Turbine.ToString();
            Double p1;
            p1 = Convert.ToDouble(txt1.Text);

            aGauge1.Value = Convert.ToInt64(p1);

            aGauge2.Value = Convert.ToInt64(p1);

            aGauge3.Value = Convert.ToInt64(p1);


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
