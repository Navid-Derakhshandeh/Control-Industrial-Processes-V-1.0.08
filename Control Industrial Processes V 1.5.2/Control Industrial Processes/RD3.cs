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
    public partial class RD3 : Form
    {
        public delegate void FileRecievedEventHandler(object Sender, string DN);
        public event FileRecievedEventHandler NewDocRecieved;
        public RD3()
        {
            InitializeComponent();
        }

        private void RD3_Load(object sender, EventArgs e)
        {
            this.NewDocRecieved += new FileRecievedEventHandler(Form1_NewDocRecieved);
        }
        private void Form1_NewDocRecieved(object sender, string fileName)
        {
            this.BeginInvoke(new Action(delegate ()
            {
                MessageBox.Show("You Have  Received New Document\n" + fileName);
                System.Diagnostics.Process.Start("explorer", @"c:\");
            }));
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            int Port = int.Parse(txtP.Text);
            Task.Factory.StartNew(() => HandleIncomingDoc(Port));
            MessageBox.Show("Program is Going To Listen Port" + Port);
        }
        public void HandleIncomingDoc(int Port2)
        {
            try
            {
                TcpListener tl = new TcpListener(Port2);
                tl.Start();
                while (true)
                {
                    Socket HS = tl.AcceptSocket();
                    if (HS.Connected)
                    {
                        string DOCN = string.Empty;
                        NetworkStream networkStream = new NetworkStream(HS);
                        int thisRead = 0;
                        int blockSize = 1024;
                        Byte[] DByte = new Byte[blockSize];
                        lock (this)
                        {
                            string DocPath = @"c:\";
                            int RB = HS.Receive(DByte);
                            int DN = BitConverter.ToInt32(DByte, 0);
                            DOCN = Encoding.ASCII.GetString(DByte, 4, DN);
                            Stream DS = File.OpenWrite(DocPath + DOCN);
                            DS.Write(DByte, 4 + DN, (1024 - (4 + DN)));
                            while (true)
                            {
                                thisRead = networkStream.Read(DByte, 0, blockSize);
                                DS.Write(DByte, 0, thisRead);
                                if (thisRead == 0)
                                    break;
                            }
                            DS.Close();
                        }
                        if (NewDocRecieved != null)
                        {
                            NewDocRecieved(this, DOCN);
                        }
                        HS = null;
                    }
                }
            }
            catch 
            {

            }
        }
    }
}
