using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlgs, uint dx, uint dy, uint dwData, int dwExtraInfo);

        private static int Cur_x, Cur_y;
        private static int Loop_cun;

        private const uint L_Down = 0x0002;
        private const uint R_Down = 0x0004;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Cur_label.Text = "X : " + Cursor.Position.X.ToString() + Cursor.Position.Y.ToString();
        }

        private void start_Click(object seander , EventArgs e)
        {
            if(!String.IsNullOrEmpty(text_x.Text) && !String.IsNullOrEmpty(text_y.Text))
            {
                Cur_x = Convert.ToInt32(text_x.Text);
                Cur_y = Convert.ToInt32(text_y.Text);
                Cursor.Position = new Point(Cur_x, Cur_y);
            }

            Loop_cun = Convert.ToInt32(text_cun.Text);

            for(int i  = 0; i < Loop_cun; i++)
            {
                mouse_event(L_Down, 0, 0, 0, 0);
                mouse_event(R_Down, 0, 0, 0, 0);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2_Tick(sender, e);
            timer1.Interval = 300;
            timer1.Start();
        }

        private void exitClick(object sender , EventArgs e)
        {
            Application.Exit();
        }
      
    }
}
