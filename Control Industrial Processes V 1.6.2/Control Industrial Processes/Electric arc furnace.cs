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
    public partial class Electric_arc_furnace : Form
    {
        public MqttClient mqttclient;
        public Electric_arc_furnace()
        {
            InitializeComponent();
            
            mqttclient = new MqttClient("localhost");
            mqttclient.Connect("clientid_1", "test", "test@unit1");
            if (mqttclient.IsConnected)
            {
                mqttclient.MqttMsgPublishReceived += mqttclient_mqttmessagepublishreceived;
                string[] Topics = new string[2];
                Topics[0] = "unit1/tag1";
                Topics[1] = "unit1/tag2";
                byte[] message = new byte[2];
                message[0] = MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE;
                message[1] = MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE;
                mqttclient.Subscribe(Topics, message);

            }
            
        }
        private void mqttclient_mqttmessagepublishreceived(object sender, MqttMsgPublishEventArgs e)
        {
            string Topic = e.Topic;
            string Value = Encoding.UTF8.GetString(e.Message);

            if (Topic == "unit1/tag2")
            {
                lblsensor.Invoke(new Action(() => lblsensor.Text = Value));
                int sensor = int.Parse(lblsensor.Text);
                sevenSegmentArray1.Value = sensor.ToString();

            }
            
            

        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            
            timer1.Enabled = true;
        }

        private void Electric_arc_furnace_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
            mqttclient.Disconnect();
            mqttclient = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            mqttclient.Publish("unit1/tag1", Encoding.UTF8.GetBytes(txtdata.Text));
            int a = knobControl1.Value;
            txtdata.Text = a.ToString();
        }

        private void btndisconnect_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void knobControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
