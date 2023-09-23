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
    public partial class WorkBenchToolKit : Form
    {
        OpcClient Opc = new OpcClient("opc.tcp://localhost:62640/");
        public WorkBenchToolKit()
        {
            InitializeComponent();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var Tag1 = "ns=2;s=Tag1";
            var t1 = Opc.ReadNode(Tag1);
            var Tag2 = "ns=2;s=Tag2";
            var t2 = Opc.ReadNode(Tag2);
            var Tag3 = "ns=2;s=Tag3";
            var t3 = Opc.ReadNode(Tag3);
            txtBox4.Text = t1.ToString();
            txtBox5.Text = t2.ToString();
            txtBox6.Text = t3.ToString();

            int a = Int32.Parse(txtBox4.Text);
            int b = Int32.Parse(txtBox5.Text);
            int c = Int32.Parse(txtBox6.Text);

            moveGauge1.Value = a;
            moveGauge2.Value = b;
            moveGauge3.Value = c;




        }

        private void moveButton1_Click(object sender, EventArgs e)
        {
            try
            {

                Opc.Connect();
                timer1.Start();
                lbl1.Text = "Connected";

            }
            catch (Exception ex)
            {
                lbl1.Text = ex.ToString();
                throw;
            }
        }

        private void moveButton2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (Opc != null)
            {
                Opc.Disconnect();
            }
            lbl1.Text = "Disconnected";
        }
    }
}
