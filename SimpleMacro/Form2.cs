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
    public partial class Form2 : Form
    {
        Form1 f1;
        public Form2(Form1 f1)
        {
            try
            {
            this.f1 = f1;
            InitializeComponent();
            }
            catch (Exception ea)
            {
                MessageBox.Show("An Error has occured!\n" + ea.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            f1.Enabled = true;
            Close();
            }
            catch (Exception ea)
            {
                MessageBox.Show("An Error has occured!\n" + ea.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
