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
using EasyModbus;

namespace Control_Industrial_Processes
{
    public partial class SendData : Form
    {
        ModbusClient modbusClient;
        Socket socket;
        EndPoint Send, Receive;
        byte[] Buffer;

        private void SendData_Load(object sender, EventArgs e)
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                modbusClient = new ModbusClient(txtSIP.Text, 502);
                modbusClient.Connect();

                int[] readHoldingRegisters = modbusClient.ReadHoldingRegisters(0, 10);
                bool[] readCoils = modbusClient.ReadCoils(9, 10);
                System.Text.ASCIIEncoding encode = new System.Text.ASCIIEncoding();
                byte[] message = new byte[1500];


                int a = readHoldingRegisters[0];


                message = encode.GetBytes(a.ToString());


                socket.Send(message);




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public SendData()
        {
            InitializeComponent();
        }
    }
}
