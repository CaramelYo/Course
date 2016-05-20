using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormEventExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            label1.Text = "Double click event";
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            label1.Text += "Mouse Enter";
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            label1.Text += "Mouse Hover";
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text += "Mouse Leave";
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //label1.Text += "Mouse Move";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            label1.Text += "Click event";
        }

        private void textBox2_MouseCaptureChanged(object sender, EventArgs e)
        {
            label2.Text = "Mouse Capture Changed";
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label1.Text = "Mouse double click event";
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text += "Mouse click event";
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //label1.Text = "Mouse down";
        }

        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {
            //label1.Text = "Mouse up";
        }

        private void textBox1_MouseCaptureChanged(object sender, EventArgs e)
        {
            label1.Text += "Mouse Capture Changed";
        }
    }
}
