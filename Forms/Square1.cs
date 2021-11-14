using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Інивідуальне_Завдання.Forms
{
    public partial class Square1 : Form
    {
        int[] m_p = new int[17];

        bool x = true;
        bool x1 = false;

        bool x2 = true;
        bool x3 = false;

        bool x4 = true;
        bool x5 = false;

        bool x6 = true;
        bool x7 = false;

        bool x8 = true;
        bool x9 = false;

        bool x10 = true;
        bool x11 = false;

        bool x12 = true;
        bool x13 = false;

        bool x14 = true;
        bool x15 = false;

        bool x16 = true;
        bool x17 = false;

        bool x18 = true;
        bool x19 = false;

        bool x20 = true;
        bool x21 = false;

        bool x22 = true;
        bool x23 = false;

        bool x24 = true;
        bool x25 = false;

        bool x26 = true;
        bool x27 = false;

        bool x28 = true;
        bool x29 = false;

        bool x30 = true;
        bool x31 = false;
        private Random random1;
        public Square1()
        {
            
            InitializeComponent();
            random1 = new Random();
            this.Text = "Геометрія";
            button2.Text = "Накреслити";
            button1.Text = "Очистити";
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox13.Text = "0";
            textBox14.Text = "0";
            textBox15.Text = "0";
            textBox16.Text = "0";
            textBox17.Text = "0";
            textBox18.Text = "0"; 
            textBox19.Text = "0";
            textBox20.Text = "0";
            groupBox1.Text = "Відрізок №1";
            groupBox2.Text = "Відрізок №2";
            groupBox4.Text = "Відрізок №3";
            groupBox5.Text = "Відрізок №4";
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            m_p[1] = Convert.ToInt32(textBox1.Text);
            m_p[2] = Convert.ToInt32(textBox3.Text);
            m_p[3] = Convert.ToInt32(textBox2.Text);
            m_p[4] = Convert.ToInt32(textBox4.Text);
            m_p[5] = Convert.ToInt32(textBox5.Text);
            m_p[6] = Convert.ToInt32(textBox7.Text);
            m_p[7] = Convert.ToInt32(textBox6.Text);
            m_p[8] = Convert.ToInt32(textBox8.Text);

            m_p[9] = Convert.ToInt32(textBox13.Text);
            m_p[10] = Convert.ToInt32(textBox15.Text);
            m_p[11] = Convert.ToInt32(textBox14.Text);
            m_p[12] = Convert.ToInt32(textBox16.Text);
            m_p[13] = Convert.ToInt32(textBox17.Text);
            m_p[14] = Convert.ToInt32(textBox19.Text);
            m_p[15] = Convert.ToInt32(textBox18.Text);
            m_p[16] = Convert.ToInt32(textBox20.Text);
            double x1, x2, x3, x4, x5, x6, x7, x8, y1, y2, y3, y4, y5, y6, y7, y8;
            if (textBox1.Text != "") x1 = Convert.ToInt32(textBox1.Text);
            else x1 = 0;
            if (textBox3.Text != "") y1 = Convert.ToInt32(textBox3.Text);
            else y1 = 0;
            if (textBox2.Text != "") x2 = Convert.ToInt32(textBox2.Text);
            else x2 = 0;
            if (textBox4.Text != "") y2 = Convert.ToInt32(textBox4.Text);
            else y2 = 0;

            if (textBox5.Text != "") x3 = Convert.ToInt32(textBox5.Text);
            else x3 = 0;
            if (textBox7.Text != "") y3 = Convert.ToInt32(textBox7.Text);
            else y3 = 0;
            if (textBox6.Text != "") x4 = Convert.ToInt32(textBox6.Text);
            else x4 = 0;
            if (textBox8.Text != "") y4 = Convert.ToInt32(textBox8.Text);
            else y4 = 0;

            if (textBox13.Text != "") x5 = Convert.ToInt32(textBox13.Text);
            else x5 = 0;
            if (textBox15.Text != "") y5 = Convert.ToInt32(textBox15.Text);
            else y5 = 0;
            if (textBox14.Text != "") x6 = Convert.ToInt32(textBox14.Text);
            else x6 = 0;
            if (textBox16.Text != "") y6 = Convert.ToInt32(textBox16.Text);
            else y6 = 0;

            if (textBox17.Text != "") x7 = Convert.ToInt32(textBox17.Text);
            else x7 = 0;
            if (textBox19.Text != "") y7 = Convert.ToInt32(textBox19.Text);
            else y7 = 0;
            if (textBox18.Text != "") x8 = Convert.ToInt32(textBox18.Text);
            else x8 = 0;
            if (textBox20.Text != "") y8 = Convert.ToInt32(textBox20.Text);
            else y8 = 0;

            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(System.Drawing.Pens.DarkBlue, m_p[1], m_p[2], m_p[3], m_p[4]);
            e.Graphics.DrawLine(System.Drawing.Pens.DarkBlue, m_p[5], m_p[6], m_p[7], m_p[8]);
            e.Graphics.DrawLine(System.Drawing.Pens.DarkBlue, m_p[9], m_p[10], m_p[11], m_p[12]);
            e.Graphics.DrawLine(System.Drawing.Pens.DarkBlue, m_p[13], m_p[14], m_p[15], m_p[16]);

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }
        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }
        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }
        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }
        private void textBox6_Click(object sender, EventArgs e)
        {
            textBox6.Text = "";
        }
        private void textBox7_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
        }
        private void textBox8_Click(object sender, EventArgs e)
        {
            textBox8.Text = "";
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar > 47 && e.KeyChar < 58) || e.KeyChar == 8 || e.KeyChar == 45)//|| e.KeyChar == 44 
            {
                if (e.KeyChar == 44)
                {
                    if (x == true && x1 == true) e.Handled = false;
                    else e.Handled = true;
                }
                else if (e.KeyChar == 45)
                {
                    if (x1 == false) e.Handled = false;
                    else e.Handled = true;
                }
                else e.Handled = false;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str;
            int c = 0;
            str = textBox1.Text;
            for (int i = 0; i < str.Length; i++)
            {
                if (Equals(str[i].ToString(), ",") == true)
                {
                    c++;
                }
            }
            if (c == 0) x = true;
            else x = false;
            if (str.Length == 0) x1 = false;
            else x1 = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar > 47 && e.KeyChar < 58)  || e.KeyChar == 8 || e.KeyChar == 45)//|| e.KeyChar == 44
            {
                if (e.KeyChar == 44)
                {
                    if (x2 == true && x3 == true) e.Handled = false;
                    else e.Handled = true;
                }
                else if (e.KeyChar == 45)
                {
                    if (x3 == false) e.Handled = false;
                    else e.Handled = true;
                }
                else e.Handled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string str;
            int c = 0;
            str = textBox2.Text;
            for (int i = 0; i < str.Length; i++)
            {
                if (Equals(str[i].ToString(), ",") == true)
                {
                    c++;
                }
            }
            if (c == 0) x2 = true;
            else x2 = false;
            if (str.Length == 0) x3 = false;
            else x3 = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar > 47 && e.KeyChar < 58)  || e.KeyChar == 8 || e.KeyChar == 45)//|| e.KeyChar == 44
            {
                if (e.KeyChar == 44)
                {
                    if (x4 == true && x5 == true) e.Handled = false;
                    else e.Handled = true;
                }
                else if (e.KeyChar == 45)
                {
                    if (x5 == false) e.Handled = false;
                    else e.Handled = true;
                }
                else e.Handled = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string str;
            int c = 0;
            str = textBox3.Text;
            for (int i = 0; i < str.Length; i++)
            {
                if (Equals(str[i].ToString(), ",") == true)
                {
                    c++;
                }
            }
            if (c == 0) x4 = true;
            else x4 = false;
            if (str.Length == 0) x5 = false;
            else x5 = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar > 47 && e.KeyChar < 58)  || e.KeyChar == 8 || e.KeyChar == 45)//|| e.KeyChar == 44
            {
                if (e.KeyChar == 44)
                {
                    if (x6 == true && x7 == true) e.Handled = false;
                    else e.Handled = true;
                }
                else if (e.KeyChar == 45)
                {
                    if (x7 == false) e.Handled = false;
                    else e.Handled = true;
                }
                else e.Handled = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string str;
            int c = 0;
            str = textBox4.Text;
            for (int i = 0; i < str.Length; i++)
            {
                if (Equals(str[i].ToString(), ",") == true)
                {
                    c++;
                }
            }
            if (c == 0) x6 = true;
            else x6 = false;
            if (str.Length == 0) x7 = false;
            else x7 = true;
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar > 47 && e.KeyChar < 58)  || e.KeyChar == 8 || e.KeyChar == 45)//|| e.KeyChar == 44
            {
                if (e.KeyChar == 44)
                {
                    if (x8 == true && x9 == true) e.Handled = false;
                    else e.Handled = true;
                }
                else if (e.KeyChar == 45)
                {
                    if (x9 == false) e.Handled = false;
                    else e.Handled = true;
                }
                else e.Handled = false;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string str;
            int c = 0;
            str = textBox5.Text;
            for (int i = 0; i < str.Length; i++)
            {
                if (Equals(str[i].ToString(), ",") == true)
                {
                    c++;
                }
            }
            if (c == 0) x8 = true;
            else x8 = false;
            if (str.Length == 0) x9 = false;
            else x9 = true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar > 47 && e.KeyChar < 58)  || e.KeyChar == 8 || e.KeyChar == 45)//|| e.KeyChar == 44
            {
                if (e.KeyChar == 44)
                {
                    if (x10 == true && x11 == true) e.Handled = false;
                    else e.Handled = true;
                }
                else if (e.KeyChar == 45)
                {
                    if (x11 == false) e.Handled = false;
                    else e.Handled = true;
                }
                else e.Handled = false;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string str;
            int c = 0;
            str = textBox6.Text;
            for (int i = 0; i < str.Length; i++)
            {
                if (Equals(str[i].ToString(), ",") == true)
                {
                    c++;
                }
            }
            if (c == 0) x10 = true;
            else x10 = false;
            if (str.Length == 0) x11 = false;
            else x11 = true;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar > 47 && e.KeyChar < 58)  || e.KeyChar == 8 || e.KeyChar == 45)//|| e.KeyChar == 44
            {
                if (e.KeyChar == 44)
                {
                    if (x12 == true && x13 == true) e.Handled = false;
                    else e.Handled = true;
                }
                else if (e.KeyChar == 45)
                {
                    if (x13 == false) e.Handled = false;
                    else e.Handled = true;
                }
                else e.Handled = false;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string str;
            int c = 0;
            str = textBox7.Text;
            for (int i = 0; i < str.Length; i++)
            {
                if (Equals(str[i].ToString(), ",") == true)
                {
                    c++;
                }
            }
            if (c == 0) x12 = true;
            else x12 = false;
            if (str.Length == 0) x13 = false;
            else x13 = true;
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar > 47 && e.KeyChar < 58)  || e.KeyChar == 8 || e.KeyChar == 45)//|| e.KeyChar == 44
            {
                if (e.KeyChar == 44)
                {
                    if (x14 == true && x15 == true) e.Handled = false;
                    else e.Handled = true;
                }
                else if (e.KeyChar == 45)
                {
                    if (x15 == false) e.Handled = false;
                    else e.Handled = true;
                }
                else e.Handled = false;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            string str;
            int c = 0;
            str = textBox7.Text;
            for (int i = 0; i < str.Length; i++)
            {
                if (Equals(str[i].ToString(), ",") == true)
                {
                    c++;
                }
            }
            if (c == 0) x14 = true;
            else x14 = false;
            if (str.Length == 0) x15 = false;
            else x15 = true;
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar > 47 && e.KeyChar < 58) || e.KeyChar == 8 || e.KeyChar == 45)//|| e.KeyChar == 44
            {
                if (e.KeyChar == 44)
                {
                    if (x16 == true && x17 == true) e.Handled = false;
                    else e.Handled = true;
                }
                else if (e.KeyChar == 45)
                {
                    if (x17 == false) e.Handled = false;
                    else e.Handled = true;
                }
                else e.Handled = false;
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            string str;
            int c = 0;
            str = textBox13.Text;
            for (int i = 0; i < str.Length; i++)
            {
                if (Equals(str[i].ToString(), ",") == true)
                {
                    c++;
                }
            }
            if (c == 0) x16 = true;
            else x16 = false;
            if (str.Length == 0) x17 = false;
            else x17 = true;
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar > 47 && e.KeyChar < 58) || e.KeyChar == 8 || e.KeyChar == 45)//|| e.KeyChar == 44
            {
                if (e.KeyChar == 44)
                {
                    if (x18 == true && x19 == true) e.Handled = false;
                    else e.Handled = true;
                }
                else if (e.KeyChar == 45)
                {
                    if (x19 == false) e.Handled = false;
                    else e.Handled = true;
                }
                else e.Handled = false;
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            string str;
            int c = 0;
            str = textBox14.Text;
            for (int i = 0; i < str.Length; i++)
            {
                if (Equals(str[i].ToString(), ",") == true)
                {
                    c++;
                }
            }
            if (c == 0) x18 = true;
            else x18 = false;
            if (str.Length == 0) x19 = false;
            else x19 = true;
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar > 47 && e.KeyChar < 58) || e.KeyChar == 8 || e.KeyChar == 45)//|| e.KeyChar == 44
            {
                if (e.KeyChar == 44)
                {
                    if (x20 == true && x21 == true) e.Handled = false;
                    else e.Handled = true;
                }
                else if (e.KeyChar == 45)
                {
                    if (x20 == false) e.Handled = false;
                    else e.Handled = true;
                }
                else e.Handled = false;
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            string str;
            int c = 0;
            str = textBox14.Text;
            for (int i = 0; i < str.Length; i++)
            {
                if (Equals(str[i].ToString(), ",") == true)
                {
                    c++;
                }
            }
            if (c == 0) x20 = true;
            else x20 = false;
            if (str.Length == 0) x21 = false;
            else x21 = true;
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar > 47 && e.KeyChar < 58) || e.KeyChar == 8 || e.KeyChar == 45)//|| e.KeyChar == 44
            {
                if (e.KeyChar == 44)
                {
                    if (x22 == true && x23 == true) e.Handled = false;
                    else e.Handled = true;
                }
                else if (e.KeyChar == 45)
                {
                    if (x22 == false) e.Handled = false;
                    else e.Handled = true;
                }
                else e.Handled = false;
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            string str;
            int c = 0;
            str = textBox15.Text;
            for (int i = 0; i < str.Length; i++)
            {
                if (Equals(str[i].ToString(), ",") == true)
                {
                    c++;
                }
            }
            if (c == 0) x22 = true;
            else x22 = false;
            if (str.Length == 0) x23 = false;
            else x23 = true;
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar > 47 && e.KeyChar < 58) || e.KeyChar == 8 || e.KeyChar == 45 || e.KeyChar == 44)
            {
                if (e.KeyChar == 44)
                {
                    if (x24 == true && x25 == true) e.Handled = false;
                    else e.Handled = true;
                }
                else if (e.KeyChar == 45)
                {
                    if (x24 == false) e.Handled = false;
                    else e.Handled = true;
                }
                else e.Handled = false;
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            string str;
            int c = 0;
            str = textBox17.Text;
            for (int i = 0; i < str.Length; i++)
            {
                if (Equals(str[i].ToString(), ",") == true)
                {
                    c++;
                }
            }
            if (c == 0) x24 = true;
            else x24 = false;
            if (str.Length == 0) x25 = false;
            else x25 = true;
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar > 47 && e.KeyChar < 58) || e.KeyChar == 8 || e.KeyChar == 45)//|| e.KeyChar == 44
            {
                if (e.KeyChar == 44)
                {
                    if (x26 == true && x27 == true) e.Handled = false;
                    else e.Handled = true;
                }
                else if (e.KeyChar == 45)
                {
                    if (x26 == false) e.Handled = false;
                    else e.Handled = true;
                }
                else e.Handled = false;
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            string str;
            int c = 0;
            str = textBox17.Text;
            for (int i = 0; i < str.Length; i++)
            {
                if (Equals(str[i].ToString(), ",") == true)
                {
                    c++;
                }
            }
            if (c == 0) x26 = true;
            else x26 = false;
            if (str.Length == 0) x27 = false;
            else x27 = true;
        }


        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar > 47 && e.KeyChar < 58) || e.KeyChar == 8 || e.KeyChar == 45)//|| e.KeyChar == 44
            {
                if (e.KeyChar == 44)
                {
                    if (x28 == true && x29 == true) e.Handled = false;
                    else e.Handled = true;
                }
                else if (e.KeyChar == 45)
                {
                    if (x28 == false) e.Handled = false;
                    else e.Handled = true;
                }
                else e.Handled = false;
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            string str;
            int c = 0;
            str = textBox18.Text;
            for (int i = 0; i < str.Length; i++)
            {
                if (Equals(str[i].ToString(), ",") == true)
                {
                    c++;
                }
            }
            if (c == 0) x28 = true;
            else x28 = false;
            if (str.Length == 0) x29 = false;
            else x29 = true;
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar > 47 && e.KeyChar < 58) || e.KeyChar == 8 || e.KeyChar == 45)//|| e.KeyChar == 44
            {
                if (e.KeyChar == 44)
                {
                    if (x30 == true && x31 == true) e.Handled = false;
                    else e.Handled = true;
                }
                else if (e.KeyChar == 45)
                {
                    if (x30 == false) e.Handled = false;
                    else e.Handled = true;
                }
                else e.Handled = false;
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            string str;
            int c = 0;
            str = textBox19.Text;
            for (int i = 0; i < str.Length; i++)
            {
                if (Equals(str[i].ToString(), ",") == true)
                {
                    c++;
                }
            }
            if (c == 0) x30 = true;
            else x30 = false;
            if (str.Length == 0) x31 = false;
            else x31 = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";

            textBox13.Text = "0";
            textBox14.Text = "0";
            textBox15.Text = "0";
            textBox16.Text = "0";
            textBox17.Text = "0";
            textBox18.Text = "0";
            textBox19.Text = "0";
            textBox20.Text = "0";
            button2_Click(sender, e);
        }

        private void textBox13_Click(object sender, EventArgs e)
        {
            textBox13.Text = "";
        }

        private void textBox15_Click(object sender, EventArgs e)
        {
            textBox15.Text = "";
        }

        private void textBox14_Click(object sender, EventArgs e)
        {
            textBox14.Text = "";
        }

        private void textBox16_Click(object sender, EventArgs e)
        {
            textBox16.Text = "";
        }

        private void textBox17_Click(object sender, EventArgs e)
        {
            textBox17.Text = "";
        }

        private void textBox19_Click(object sender, EventArgs e)
        {
            textBox19.Text = "";
        }

        private void textBox18_Click(object sender, EventArgs e)
        {
            textBox18.Text = "";
        }

        private void textBox20_Click(object sender, EventArgs e)
        {
            textBox20.Text = "";
        }

        private void записатиУФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double x1, x2, x3, x4, x5, x6, x7, x8, y1, y2, y3, y4, y5, y6, y7, y8;
            if (textBox1.Text != "") x1 = Convert.ToInt32(textBox1.Text);
            else x1 = 0;
            if (textBox3.Text != "") y1 = Convert.ToInt32(textBox3.Text);
            else y1 = 0;
            if (textBox2.Text != "") x2 = Convert.ToInt32(textBox2.Text);
            else x2 = 0;
            if (textBox4.Text != "") y2 = Convert.ToInt32(textBox4.Text);
            else y2 = 0;

            if (textBox5.Text != "") x3 = Convert.ToInt32(textBox5.Text);
            else x3 = 0;
            if (textBox7.Text != "") y3 = Convert.ToInt32(textBox7.Text);
            else y3 = 0;
            if (textBox6.Text != "") x4 = Convert.ToInt32(textBox6.Text);
            else x4 = 0;
            if (textBox8.Text != "") y4 = Convert.ToInt32(textBox8.Text);
            else y4 = 0;

            if (textBox13.Text != "") x5 = Convert.ToInt32(textBox13.Text);
            else x5 = 0;
            if (textBox15.Text != "") y5 = Convert.ToInt32(textBox15.Text);
            else y5 = 0;
            if (textBox14.Text != "") x6 = Convert.ToInt32(textBox14.Text);
            else x6 = 0;
            if (textBox16.Text != "") y6 = Convert.ToInt32(textBox16.Text);
            else y6 = 0;

            if (textBox17.Text != "") x7 = Convert.ToInt32(textBox17.Text);
            else x7 = 0;
            if (textBox19.Text != "") y7 = Convert.ToInt32(textBox19.Text);
            else y7 = 0;
            if (textBox18.Text != "") x8 = Convert.ToInt32(textBox18.Text);
            else x8 = 0;
            if (textBox20.Text != "") y8 = Convert.ToInt32(textBox20.Text);
            else y8 = 0;

            saveFileDialog1.Filter = "binary files (*.bin)|*.bin|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = saveFileDialog1.FileName;

            // mistas.Clear();
            BinaryWriter binaryWriter = new BinaryWriter(new FileStream(filename, FileMode.Append), Encoding.GetEncoding(1251));

            binaryWriter.Write(x1);
            binaryWriter.Write(x2);
            binaryWriter.Write(x3);
            binaryWriter.Write(x4);
            binaryWriter.Write(x5);
            binaryWriter.Write(x6);
            binaryWriter.Write(x7);
            binaryWriter.Write(x8);
            binaryWriter.Write(y1);
            binaryWriter.Write(y2);
            binaryWriter.Write(y3);
            binaryWriter.Write(y4);
            binaryWriter.Write(y5);
            binaryWriter.Write(y6);
            binaryWriter.Write(y7);
            binaryWriter.Write(y8);
            binaryWriter.Close();
            MessageBox.Show("Файл збережений", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void прочитатиЗФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            openFileDialog1.Filter = "binary files (*.bin)|*.bin|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = openFileDialog1.FileName;

            BinaryReader binaryReader = new BinaryReader(new FileStream(filename, FileMode.Open), Encoding.GetEncoding(1251));

            textBox1.Text = Convert.ToString(binaryReader.ReadDouble());
            textBox2.Text = Convert.ToString(binaryReader.ReadDouble());
            textBox5.Text = Convert.ToString(binaryReader.ReadDouble());
            textBox6.Text = Convert.ToString(binaryReader.ReadDouble());
            textBox13.Text = Convert.ToString(binaryReader.ReadDouble());
            textBox14.Text = Convert.ToString(binaryReader.ReadDouble());
            textBox17.Text = Convert.ToString(binaryReader.ReadDouble());
            textBox18.Text = Convert.ToString(binaryReader.ReadDouble());

            textBox3.Text = Convert.ToString(binaryReader.ReadDouble());
            textBox4.Text = Convert.ToString(binaryReader.ReadDouble());
            textBox7.Text = Convert.ToString(binaryReader.ReadDouble());
            textBox8.Text = Convert.ToString(binaryReader.ReadDouble());
            textBox15.Text = Convert.ToString(binaryReader.ReadDouble());
            textBox16.Text = Convert.ToString(binaryReader.ReadDouble());
            textBox19.Text = Convert.ToString(binaryReader.ReadDouble());
            textBox20.Text = Convert.ToString(binaryReader.ReadDouble());
            binaryReader.Close();
        }
    }
}