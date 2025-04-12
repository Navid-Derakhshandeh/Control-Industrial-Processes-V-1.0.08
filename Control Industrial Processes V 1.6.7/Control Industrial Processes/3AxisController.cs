using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mach4;
using System.Runtime.InteropServices;
using System.Windows.Forms.VisualStyles;
using System.IO;

namespace Control_Industrial_Processes
{
    public partial class _3AxisController : Form
    {
        public IMach4 _Mach3Mill;
        public IMyScriptObject _MachMill;
        public _3AxisController()
        {
            InitializeComponent();
        }
        private void mach3mill()
        {
            try
            {
                _Mach3Mill = (IMach4)Marshal.GetActiveObject("Mach4.document");
                _MachMill = (IMyScriptObject)_Mach3Mill.GetScriptDispatch();
            }
            catch
            {
                _Mach3Mill = null;
                _MachMill = null;
            }
        }
        private void Axis()
        {
            mach3mill();
            txtXAxis.Text = _MachMill.GetOEMDRO(800).ToString();
            txtYAxis.Text = _MachMill.GetOEMDRO(801).ToString();
            txtZAxis.Text = _MachMill.GetOEMDRO(802).ToString();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Axis();
        }

        

        private void btnC_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnCS_Click(object sender, EventArgs e)
        {
            Axis();
            if (_MachMill != null)
            {
                _MachMill.DoOEMButton(1000);
            }
        }

        private void btnFH_Click(object sender, EventArgs e)
        {
            Axis();
            if (_MachMill != null)
            {
                _MachMill.DoOEMButton(1001);
            }
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            Axis();
            if (_MachMill != null)
            {
                _MachMill.DoOEMButton(1003);
            }
        }

        private void btnSendGcode_Click(object sender, EventArgs e)
        {
            Axis();
            if (_MachMill != null)
            {
               
                foreach (var item in listBox1.Items)
                {
                    _MachMill.Code(item.ToString().Trim());
                    

                }

            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt"; 
                openFileDialog.Title = "Select a Text File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                       
                        string[] lines = File.ReadAllLines(openFileDialog.FileName);

                        
                        listBox1.Items.Clear();
                        listBox1.Items.AddRange(lines);
                    }
                    catch (Exception ex)
                    {
                       
                        MessageBox.Show($"Error loading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
