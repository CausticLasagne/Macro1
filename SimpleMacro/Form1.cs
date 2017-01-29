using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleMacro
{
    public partial class Form1 : Form
    {
        int doTimes;
        int startDelay;
        int fullDelay;
        public Form1()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ea)
            {
                timer1.Stop();
                timer2.Stop();
                Height = 260;
                button1.Text = "GO";
                MessageBox.Show("An Error has occured!\n" + ea.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                doTimes = int.Parse(textBox3.Text);
            }
            catch (Exception ea)
            {
                timer1.Stop();
                timer2.Stop();
                Height = 260;
                button1.Text = "GO";
                MessageBox.Show("An Error has occured!\n" + ea.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (button1.Text == "GO")
                {
                    startDelay = int.Parse(textBox4.Text);
                    fullDelay = startDelay;
                    timer2.Start();
                    Height = 327;
                    button1.Text = "Stop";
                }
                else
                {
                    timer1.Stop();
                    timer2.Stop();
                    progressBar1.Value = 0;
                    label5.Text = "0";
                    Height = 260;
                    button1.Text = "GO";
                }
            }
            catch (Exception ea)
            {
                timer1.Stop();
                timer2.Stop();
                Height = 260;
                button1.Text = "GO";
                MessageBox.Show("An Error has occured!\n" + ea.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                startDelay -= 10;
                if (startDelay <= 0)
                {
                    timer2.Stop();
                    timer1.Interval = int.Parse(textBox1.Text);
                    timer1.Start();
                    doTimes = int.Parse(textBox3.Text);
                }
                int percentDone = startDelay * 100 / fullDelay;
                progressBar1.Value = percentDone;
                label5.Text = "" + startDelay;
            }
            catch (Exception ea)
            {
                timer1.Stop();
                timer2.Stop();
                Height = 260;
                button1.Text = "GO";
                MessageBox.Show("An Error has occured!\n" + ea.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (doTimes > 0)
                {
                    SendKeys.SendWait(textBox2.Text);
                }
                else
                {
                    timer1.Stop();
                    label7.Text = "0";
                    return;
                }
                doTimes--;
                label7.Text = "" + doTimes;
            }
            catch (Exception ea)
            {
                timer1.Stop();
                timer2.Stop();
                Height = 260;
                button1.Text = "GO";
                MessageBox.Show("An Error has occured!\n" + ea.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int outnum;
                if (!int.TryParse(textBox1.Text, out outnum))
                {
                    textBox1.Text = "";
                    return;
                }
                if (textBox1.Text == "1")
                {
                    label6.Text = "Millisecond";
                }
                else
                {
                    label6.Text = "Milliseconds";
                }
            }
            catch (Exception ea)
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("An Error has occured!\n" + ea.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int outnum;
                if (!int.TryParse(textBox3.Text, out outnum))
                {
                    textBox3.Text = "";
                    return;
                }
            }
            catch (Exception ea)
            {
                timer1.Stop();
                timer2.Stop();
                Height = 260;
                button1.Text = "GO";
                MessageBox.Show("An Error has occured!\n" + ea.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 f2 = new Form2(this);
                f2.Show();
                Enabled = false;
            }
            catch (Exception ea)
            {
                timer1.Stop();
                timer2.Stop();
                Height = 260;
                button1.Text = "GO";
                MessageBox.Show("An Error has occured!\n" + ea.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
