using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week05
{
    public partial class Form1 : Form
    {
        Point x = new Point(1, 0), y = new Point(0,1);
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    label2.Text = "按了左鍵於";
                    break;
                case MouseButtons.Right:
                    label2.Text = "按了右鍵於";
                    break;
                case MouseButtons.Middle:
                    label2.Text = "按了滾輪於";
                    break;
                default:
                    break;
            }
            label2.Text += "X：" + e.X + "，Y：" + e.Y;

            return;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = "按了" + e.KeyCode + "鍵，鍵碼：" + e.KeyValue;
            switch (e.KeyCode)
            {
                case Keys.Up:
                    label1.Top -= 1;
                    break;
                case Keys.Down:
                    label1.Top += 1;
                    break;
                case Keys.Left:
                    label1.Left -= 1;
                    break;
                case Keys.Right:
                    label1.Left += 1;
                    break;
                default:
                    break;
            }
            return;
        }
    }
}
