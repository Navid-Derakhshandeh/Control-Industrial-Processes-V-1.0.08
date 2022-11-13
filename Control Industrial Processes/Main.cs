//Navid-Derakhshandeh
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Toolkit.Uwp.Notifications;
using System.Diagnostics;
namespace Control_Industrial_Processes
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            new ToastContentBuilder()
            .AddText("Welcome")
            .AddText("Program Has Started")
            .Show();
        }
        private void tempToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Temp frm = new Temp();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LayoutMdi(MdiLayout.Cascade);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void eventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Event frm = new Event();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void valvesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Valves frm = new Valves();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void boilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boiler frm = new Boiler();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void dieselGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DieselGen frm = new DieselGen();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void iDSLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interpreter frm = new Interpreter();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Event frm = new Event();
            frm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\Test4\Boiler Efficiency\Boiler Efficiency\bin\Debug\Boiler Efficiency.exe");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SendData frm = new SendData();
            frm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Receiver frm = new Receiver();
            frm.Show();
        }
    }
}
