﻿using System;
using System.Drawing;
using System.Windows.Forms;
using HapticGloveConnector;
using System.Threading;


namespace HapticGloveTestUI
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Text = "Haptic Glove Utility";

            Connector.Failure += message => { InvokeControl(log, () => log.AppendText(Environment.NewLine + DateTime.Now + ": " + message)); var panel = message.ToLower().Contains("right") ? rightHandPanel : lefthandPanel; InvokeControl(panel, () => panel.BackColor = Color.Red); };
            Connector.Success += hand => { var panel = hand == Hand.Right ? rightHandPanel : lefthandPanel; InvokeControl(panel, () => panel.BackColor = Color.Green); InvokeControl(log, () => log.AppendText(Environment.NewLine + DateTime.Now + ": Connected to " + hand.ToString() + " glove.")); };

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

        private void button11_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(y =>
            {
                Connector.Connect(1000);
            });
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
    }



}



