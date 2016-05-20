using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tooltip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
            //toolTip1.SetToolTip(this.label1, "My button1");
            toolTip1.SetToolTip(this.button1, "顯示國文");
            toolTip1.SetToolTip(this.button2, "顯示英文");
            toolTip1.SetToolTip(this.button3, "顯示數學");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "80";
            label1.Visible = true;
            toolTip1.SetToolTip(this.label1, "國文80分，還不錯!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "100";
            label1.Visible = true;
            toolTip1.SetToolTip(this.label1, "英文100分，非常好!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "20";
            label1.Visible = true;
            toolTip1.SetToolTip(this.label1, "數學20分，死當吧!");
        }
    }
}
