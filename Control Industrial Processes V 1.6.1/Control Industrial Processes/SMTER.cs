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

namespace Control_Industrial_Processes
{
    public partial class SMTER : Form
    {
        Socket socket;
        EndPoint Send, Receive;
        byte[] Buffer;
        public SMTER()
        {
            InitializeComponent();
        }
        private void SMTER_Load(object sender, EventArgs e)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            txtSIP.Text = GetIP();
            txtDIP.Text = GetIP();
        }
        private string GetIP()
        {
            IPHostEntry Host;
            Host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in Host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }
        private void MessageReturn(IAsyncResult Res)
        {
            try
            {


                byte[] ReceiveddData = new byte[1500];
                ReceiveddData = (byte[])Res.AsyncState;
                ASCIIEncoding Encoding = new ASCIIEncoding();
                string ReceivedMessage = Encoding.GetString(ReceiveddData);
                LM1.Items.Add("Destination: " + ReceivedMessage);

                Buffer = new byte[1500];
                socket.BeginReceiveFrom(Buffer, 0, Buffer.Length, SocketFlags.None, ref Send, new AsyncCallback(MessageReturn), Buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {


                Send = new IPEndPoint(IPAddress.Parse(txtSIP.Text), Convert.ToInt32(txtSPort.Text));
                socket.Bind(Send);

                Receive = new IPEndPoint(IPAddress.Parse(txtDIP.Text),
                Convert.ToInt32(txtDPort.Text));
                socket.Connect(Receive);

                Buffer = new byte[1500];
                socket.BeginReceiveFrom(Buffer, 0, Buffer.Length, SocketFlags.None, ref Receive, new
                AsyncCallback(MessageReturn), Buffer);

                btnSend.Enabled = true;
                btnConnect.Text = "Connected";
                btnConnect.Enabled = false;
                txtM.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnMqtt_Click(object sender, EventArgs e)
        {
            MQTTc frm = new MQTTc();
            frm.Show();
        }

        private void btnRs_Click(object sender, EventArgs e)
        {
            RS232c frm = new RS232c();
            frm.Show();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {

                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];

                msg = enc.GetBytes(txtM.Text);

                socket.Send(msg);


                LM1.Items.Add("Source: " + txtM.Text);

                txtM.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
