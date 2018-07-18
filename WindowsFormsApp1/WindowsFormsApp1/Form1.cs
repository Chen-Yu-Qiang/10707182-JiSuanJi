using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int now = 0;
        int bufadd, bufsub = 0;
        int bufmul, bufdiv = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //7
            now = now * 10 + 7;
            Show_NB();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Show_NB();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //8
            now = now * 10 + 8;
            Show_NB();
        }
        void Show_NB()
        {
            int a = now;
            int b, c, d, e, f = 0;
            b = a / 10000;
            c = a % 10000 / 1000;
            d = a % 1000 / 100;
            e = a % 100 / 10;
            f = a % 10;

            label1.Text = b == 0 ? "" : Convert.ToString(b);
            label2.Text = c == 0 ? "" : Convert.ToString(c);
            label3.Text = d == 0 ? "" : Convert.ToString(d);
            label4.Text = e == 0 ? "" : Convert.ToString(e);
            label5.Text = Convert.ToString(f);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //9
            now = now * 10 + 9;
            Show_NB();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //4
            now = now * 10 + 4;
            Show_NB();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //5
            now = now * 10 + 5;
            Show_NB();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //6
            now = now * 10 + 6;
            Show_NB();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //1
            now = now * 10 + 1;
            Show_NB();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //2
            now = now * 10 + 2;
            Show_NB();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            bufadd = now;
            now = 0;
            Show_NB();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            bufsub = now;
            now = 0;
            Show_NB();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            bufmul = now;
            now = 0;
            Show_NB();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            bufdiv = now;
            now = 0;
            Show_NB();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            now = bufdiv == 1 ? bufsub == 0 ? bufadd == 0 ? now * bufmul : now + bufadd : bufsub - now : bufdiv / now;
            Show_NB();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            now = 0;
            bufadd = 0;
            bufsub = 0;
            bufmul = 1;
            bufdiv = 1;
            Show_NB();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //3
            now = now * 10 + 3;
            Show_NB();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //0
            now = now * 10;
            Show_NB();
        }
    }
}
