using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Control_Industrial_Processes
{
    public partial class Interpreter : Form
    {
        public Interpreter()
        {
            InitializeComponent();
        }

        private void In1btn_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\Test4\Internal DSL\Internal DSL\bin\Debug\Internal DSL.exe");
        }
    }
}
