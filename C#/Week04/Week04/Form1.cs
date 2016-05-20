using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a, b;
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                b = float.Parse(textBox1.Text);
                a = float.Parse(textBox2.Text);
                label4.Text = (a / b).ToString();
            }
        }
    }
}
