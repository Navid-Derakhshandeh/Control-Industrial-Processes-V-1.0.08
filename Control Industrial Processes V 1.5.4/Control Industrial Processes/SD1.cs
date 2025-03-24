using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.IO;

namespace Control_Industrial_Processes
{
    public partial class SD1 : Form
    {
        private static string SYFN = "";
        private static string FN = "";
        public SD1()
        {
            InitializeComponent();
        }
        private void btnB_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "File Sharing Client";
            OFD.ShowDialog();
            txtFP.Text = OFD.FileName;
            FN = OFD.FileName;
            SYFN = OFD.SafeFileName;
        }
        private void btnS_Click(object sender, EventArgs e)
        {
            string IP = txtIP.Text;
            int Port = int.Parse(txtP.Text);
            string FP = txtFP.Text;
            Task.Factory.StartNew(() => SendDocument(IP, Port, FP, SYFN));
            MessageBox.Show("Your Document Sent Successfully");
        }
        public void SendDocument(string RIP, int RP, string MFP, string synopticFP)
        {
            try
            {
                if (!string.IsNullOrEmpty(RIP))
                {
                    byte[] FilePathByte = Encoding.ASCII.GetBytes(synopticFP);
                    byte[] DocData = File.ReadAllBytes(MFP);
                    byte[] CData = new byte[4 + FilePathByte.Length + DocData.Length];
                    byte[] DocNP = BitConverter.GetBytes(FilePathByte.Length);
                    DocNP.CopyTo(CData, 0);
                    FilePathByte.CopyTo(CData, 4); DocData.CopyTo(CData, 4 + FilePathByte.Length);
                    TcpClient CS = new TcpClient(RIP, RP);
                    NetworkStream NS = CS.GetStream();
                    NS.Write(CData, 0, CData.GetLength(0));
                    NS.Close();
                }
            }
            catch
            {
            }
        }

    }
}
