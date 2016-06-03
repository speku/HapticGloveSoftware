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


namespace HapticGloveTestUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Connector.Failure += message => log.AppendText(message);
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
