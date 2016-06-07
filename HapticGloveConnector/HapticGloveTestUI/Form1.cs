using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HapticGloveConnector;
using System.IO;
using System.IO.Ports;
using System.Management;
using System.Threading;
using HapticGloveShared;
using NamedPipeWrapper.IO;
using NamedPipeWrapper;


namespace HapticGloveTestUI
{
    public partial class Form1 : Form
    {
        List<SerialPort> ports = new List<SerialPort>();
        NamedPipeServer<HapticGloveMessage> server = new NamedPipeServer<HapticGloveMessage>(HapticGloveMessage.pipeName);
        NamedPipeConnection<HapticGloveMessage, HapticGloveMessage> connection;

        public Form1()
        {
            InitializeComponent();
            Text = "Haptic Glove Utility";

            Connector.Failure += message => { Log(message); var panel = message.ToLower().Contains("right") ? rightHandPanel : lefthandPanel; InvokeControl(panel, () => panel.BackColor = Color.Red); };
            Connector.Success += hand => { var panel = hand == Hand.Right ? rightHandPanel : lefthandPanel; InvokeControl(panel, () => panel.BackColor = Color.Green); Log("Connected to " + hand.ToString() + " glove."); };

            server.ClientConnected += (conn) => { connection = conn; Log("Connection to client established."); };
            server.ClientDisconnected += (conn) => Log("Client disconnected.");
            server.ClientMessage += (conn, message) => Connector.Intensity(message.hand, message.finger, message.intensity);


            foreach (Control c in new Control[] { rightHandPanel, lefthandPanel})
            {
                foreach (Control _c in c.Controls)
                {
                    if (_c.GetType() == typeof(TrackBar))
                    {
                        var tip = new ToolTip();
                        var bar = (TrackBar)_c;
                        bar.ValueChanged += (s,args) => tip.SetToolTip(bar, bar.Value.ToString());
                    }
                }
            }
        }

        private void Log(string message)
        {
            InvokeControl(log, () => log.AppendText(Environment.NewLine + DateTime.Now + ": " + message));
        }

        private void InvokeControl(Control control, Action action)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(action);
            } else
            {
                action();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connector.Intensity(Hand.Left, Finger.Thumb, (byte)trackBarLeftThumb.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connector.Intensity(Hand.Left, Finger.Index, (byte)trackBarLeftIndex.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Connector.Intensity(Hand.Left, Finger.Middle, (byte)trackBarLeftMiddle.Value);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Connector.Intensity(Hand.Left, Finger.Pinky, (byte)trackBarLeftPinky.Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Connector.Intensity(Hand.Left, Finger.Ring, (byte)trackBarLeftRing.Value);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void thumbRight_Click(object sender, EventArgs e)
        {
            Connector.Intensity(Hand.Right ,Finger.Thumb, (byte)trackBarRightThumb.Value);
        }

        private void indexRight_Click(object sender, EventArgs e)
        {
            Connector.Intensity(Hand.Right, Finger.Index, (byte)trackBarRightIndex.Value);
        }

        private void middleRight_Click(object sender, EventArgs e)
        {
            Connector.Intensity(Hand.Right, Finger.Middle, (byte)trackBarRightMiddle.Value);
        }

        private void ringRight_Click(object sender, EventArgs e)
        {
            Connector.Intensity(Hand.Right, Finger.Ring, (byte)trackBarRightRing.Value);
        }

        private void pinkyRight_Click(object sender, EventArgs e)
        {
            Connector.Intensity(Hand.Right, Finger.Pinky, (byte)trackBarRightPinky.Value);
        }

        private void log_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(y =>
            {
                Connector.Connect(1000);
            });
        }
    }



}




