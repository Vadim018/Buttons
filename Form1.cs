using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = String.Format("Form Size: W = {0}, H = {1}",
            this.Width, this.Height);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = !button1.Visible;
            label1.Visible = !label1.Visible;
            label2.Visible = !label2.Visible;
            if (button1.Visible)
            {
                button2.Text = "Hide";
            }
            else
                button2.Text = "Show";
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label2_MouseMove(object sender, EventArgs e)
        {
            label2.Left = label2.Left + 10;
            label2.Top = label2.Top - 10;

            if ((label2.Left < -20) || (label2.Left > this.Width - 20))
            {
                label2.Left = 10;
            }

            if ((label2.Top < 10) || (label2.Top > this.Height - 10))
            {
                label2.Top = 80;
            }
        }
    }
}