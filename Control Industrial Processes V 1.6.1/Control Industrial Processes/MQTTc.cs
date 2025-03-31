using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace Control_Industrial_Processes
{
    public partial class MQTTc : Form
    {
        MqttClient mqttclient1;
        public MQTTc()
        {
            InitializeComponent();
        }
        private void mqtt(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        {
            var message = Encoding.UTF8.GetString(e.Message);
            Console.WriteLine(message);
            LM1.Invoke((MethodInvoker)(() => LM1.Items.Add(message)));
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                if (mqttclient1 != null && mqttclient1.IsConnected)
                {
                    mqttclient1.Publish("ER", Encoding.UTF8.GetBytes(txtM.Text));
                }
            });
        }

        private void MQTTc_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                mqttclient1 = new MqttClient("localhost");
                mqttclient1.MqttMsgPublishReceived += mqtt;
                mqttclient1.Subscribe(new string[] { "ER" }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                mqttclient1.Connect("clientid_1");
            });
        }

        private void MQTTc_FormClosing(object sender, FormClosingEventArgs e)
        {
            mqttclient1.Disconnect();
            mqttclient1 = null;
        }
    }
}
