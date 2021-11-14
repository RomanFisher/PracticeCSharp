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
    public partial class Convector1 : Form
    {
        bool x = true;
        bool x1 = false;

        string t;
        public Convector1()
        {
            InitializeComponent();
            this.Text = "Конвектор площин";
            button1.Text = "Перевести";
            button2.Text = "Очистити";
            button5.Text = "Назад";
            textBox1.Text = "0";
            label2.Text = "Довідка";
            label1.Text = "";
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            button5.Visible = false;
            button5.Enabled = false;
            listBox1.Enabled = false;
            listBox1.Visible = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        List<string> vs = new List<string>();
        private void Convector1_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double a;

            if (textBox1.Text == "") a = 0;
            else a = Convert.ToDouble(textBox1.Text);
            
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0)
            {
                label1.Text = Convert.ToString(a);
                vs.Add(a.ToString("0.0") + " кв міліметрів = " + label1.Text + " кв міліметрів");
              
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1)
            {
                label1.Text = Convert.ToString(a / 100);
                vs.Add(a.ToString("0.0") + " кв міліметрів = " + label1.Text + " кв сантиметрів");
              
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 2)
            {
                label1.Text = Convert.ToString(a / 100000000);
                vs.Add(a.ToString("0.0") + " кв міліметрів = " + label1.Text + " кв метрів");
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 3)
            {
                label1.Text = Convert.ToString(a / 10000000000);
                vs.Add(a.ToString("0.0") + " кв міліметрів = " + label1.Text + " гектара");
                
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 4)
            {
                label1.Text = Convert.ToString(a / 1000000000000);
                vs.Add(a.ToString("0.0") + " кв міліметрів = " + label1.Text + " кв кілометрів");
               
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 5)
            {
                label1.Text = Convert.ToString(a / 645.16);
                vs.Add(a.ToString("0.0") + " кв міліметрів = " + label1.Text + " кв дюймів");
              
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 6)
            {
                label1.Text = Convert.ToString(a / 92903.04);
                vs.Add(a.ToString("0.0") + " кв міліметрів = " + label1.Text + " кв футів");
              
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 7)
            {
                label1.Text = Convert.ToString(a / 836127.39);
                vs.Add(a.ToString("0.0") + " кв міліметрів = " + label1.Text + " кв ярдів");
              
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 8)  
            {
                label1.Text = Convert.ToString(a / 4046854481.18);
                vs.Add(a.ToString("0.0") + " кв міліметрів = " + label1.Text + " акрів");
              
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 9)
            {
                label1.Text = Convert.ToString(Math.Round((a / 2589987832237.16), 7));
                vs.Add(a.ToString("0.0") + " кв міліметрів = " + label1.Text + " кв миль");
               
            }


            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)
            {
                label1.Text = Convert.ToString(a * 100);
                vs.Add(a.ToString("0.0") + " кв сантиметрів = " + label1.Text + " кв міліметів");
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1)
            {
                label1.Text = Convert.ToString(a);
                vs.Add(a.ToString("0.0") + " кв сантиметрів = " + label1.Text + " кв сантиметрів");
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
            {
                label1.Text = Convert.ToString(a * 0.0001);
                vs.Add(a.ToString("0.0") + " кв сантиметрів = " + label1.Text + " кв метвір");
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 3)
            {
                label1.Text = Convert.ToString(a * 0.00000001);
                vs.Add(a.ToString("0.0") + " кв сантиметрів = " + label1.Text + " гектара");
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 4)
            {
                label1.Text = Convert.ToString(a * 0.0000000001);
                vs.Add(a.ToString("0.0") + " кв сантиметрів = " + label1.Text + " кв кілометрів");
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 5)
            {
                label1.Text = Convert.ToString(a * 0.155);
                vs.Add(a.ToString("0.0") + " кв сантиметрів = " + label1.Text + " кв дюймів");
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 6)
            {
                label1.Text = Convert.ToString(a * 0.00107639);
                vs.Add(a.ToString("0.0") + " кв сантиметрів = " + label1.Text + " кв футів");
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 7)
            {
                label1.Text = Convert.ToString(a * 0.0001196);
                vs.Add(a.ToString("0.0") + " кв сантиметрів = " + label1.Text + " кв ярдів");
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 8)
            {
                label1.Text = Convert.ToString(a * 0.000000024711);
                vs.Add(a.ToString("0.0") + " кв сантиметрів = " + label1.Text + " акрів");
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 9)
            {
                label1.Text = Convert.ToString(a * 0.00000000003861);
                vs.Add(a.ToString("0.0") + " кв сантиметрів = " + label1.Text + " кв миль");
            }


            else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 0)
            {
                label1.Text = Convert.ToString(a * 1000000);
                vs.Add(a.ToString("0.0") + " кв метрів = " + label1.Text + " кв міліметри");
            }
            else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 1)
            {
                label1.Text = Convert.ToString(a * 10000);
                vs.Add(a.ToString("0.0") + " кв метрів = " + label1.Text + " кв сантиметрів");
            }
            else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 2)
            {
                label1.Text = Convert.ToString(a);
                vs.Add(a.ToString("0.0") + " кв метрів = " + label1.Text + " кв метрів");
            }
            else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 3)
            {
                label1.Text = Convert.ToString(a * 0.0001);
                vs.Add(a.ToString("0.0") + " кв метрів = " + label1.Text + " гектара");
            }
            else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 4)
            {
                label1.Text = Convert.ToString(a * 0.000001);
                vs.Add(a.ToString("0.0") + " кв метрів = " + label1.Text + " кв кілометрів");
            }
            else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 5)
            {
                label1.Text = Convert.ToString(a * 1550);
                vs.Add(a.ToString("0.0") + " кв метрів = " + label1.Text + " кв дюймів");
            }
            else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 6)
            {
                label1.Text = Convert.ToString(a * 10.7639);
                vs.Add(a.ToString("0.0") + " кв метрів = " + label1.Text + " кв футів");
            }
            else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 7)
            {
                label1.Text = Convert.ToString(a * 1.196);
                vs.Add(a.ToString("0.0") + " кв метрів = " + label1.Text + " кв ярдів");
            }
            else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 8)
            {
                label1.Text = Convert.ToString(a * 0.00024711);
                vs.Add(a.ToString("0.0") + " кв метрів = " + label1.Text + " акрів");
            }
            else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 9)
            {
                label1.Text = Convert.ToString(a * 0.0000003861);
                vs.Add(a.ToString("0.0") + " кв метрів = " + label1.Text + " кв миль");
            }


            else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 0)
            {
                label1.Text = Convert.ToString(a * 10000000000);
                vs.Add(a.ToString("0.0") + " гектара = " + label1.Text + " кв міліметрів");
            }
            else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 1)
            {
                label1.Text = Convert.ToString(a * 100000000);
                vs.Add(a.ToString("0.0") + " гектара = " + label1.Text + " кв сантиметрів");
            }
            else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 2)
            {
                label1.Text = Convert.ToString(a * 10000);
                vs.Add(a.ToString("0.0") + " гектара = " + label1.Text + " кв метрів");
            }
            else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 3)
            {
                label1.Text = Convert.ToString(a);
                vs.Add(a.ToString("0.0") + " гектара = " + label1.Text + " гектара");
            }
            else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 4)
            {
                label1.Text = Convert.ToString(a * 0.01);
                vs.Add(a.ToString("0.0") + " гектара = " + label1.Text + " кв кілометрів");
            }
            else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 5)
            {
                label1.Text = Convert.ToString(a * 15500030);
                vs.Add(a.ToString("0.0") + " гектара = " + label1.Text + " кв дюймів");
            }
            else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 6)
            {
                label1.Text = Convert.ToString(a * 107639.1);
                vs.Add(a.ToString("0.0") + " гектара = " + label1.Text + " кв футів");
            }
            else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 7)
            {
                label1.Text = Convert.ToString(a * 11959.9);
                vs.Add(a.ToString("0.0") + " гектара = " + label1.Text + " кв ярдів");
            }
            else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 8)
            {
                label1.Text = Convert.ToString(a * 2.4711);
                vs.Add(a.ToString("0.0") + " гектара = " + label1.Text + " акрів");
            }
            else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 9)
            {
                label1.Text = Convert.ToString(a * 0.00386102);
                vs.Add(a.ToString("0.0") + " гектара = " + label1.Text + " кв миль");
            }

            else if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 0)
            {
                label1.Text = Convert.ToString(a * 1000000000000);
                vs.Add(a.ToString("0.0") + " кв кілометрів = " + label1.Text + " кв міліметрів");
            }
            else if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 1)
            {
                label1.Text = Convert.ToString(a * 10000000000);
                vs.Add(a.ToString("0.0") + " кв кілометрів = " + label1.Text + " кв сантиметрів");
            }
            else if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 2)
            {
                label1.Text = Convert.ToString(a * 1000000);
                vs.Add(a.ToString("0.0") + " кв кілометрів = " + label1.Text + " кв метрів");
            }
            else if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 3)
            {
                label1.Text = Convert.ToString(a * 100);
                vs.Add(a.ToString("0.0") + " кв кілометрів = " + label1.Text + " гектара");
            }
            else if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 4)
            {
                label1.Text = Convert.ToString(a);
                vs.Add(a.ToString("0.0") + " кв кілометрів = " + label1.Text + " кв кілометрів");
            }
            else if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 5)
            {
                label1.Text = Convert.ToString(a * 1550003000);
                vs.Add(a.ToString("0.0") + " кв кілометрів = " + label1.Text + " кв дюймів");
            }
            else if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 6)
            {
                label1.Text = Convert.ToString(a * 10763910);
                vs.Add(a.ToString("0.0") + " кв кілометрів = " + label1.Text + " кв футів");
            }
            else if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 7)
            {
                label1.Text = Convert.ToString(a * 1195990);
                vs.Add(a.ToString("0.0") + " кв кілометрів = " + label1.Text + " кв ярдів");
            }
            else if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 8)
            {
                label1.Text = Convert.ToString(a * 247.11);
                vs.Add(a.ToString("0.0") + " кв кілометрів = " + label1.Text + " акрів");
            }
            else if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 9)
            {
                label1.Text = Convert.ToString(a * 0.386102);
                vs.Add(a.ToString("0.0") + " кв кілометрів = " + label1.Text + " кв миль");
            }


            else if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 0)
            {
                label1.Text = Convert.ToString(a * 645.16);
                vs.Add(a.ToString("0.0") + " кв дюймів = " + label1.Text + " кв міліметрів");
            }
            else if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 1)
            {
                label1.Text = Convert.ToString(a * 6.4516);
                vs.Add(a.ToString("0.0") + " кв дюймів = " + label1.Text + " кв сантиметрів");
            }
            else if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 2)
            {
                label1.Text = Convert.ToString(a * 0.00064516);
                vs.Add(a.ToString("0.0") + " кв дюймів = " + label1.Text + " кв метрів");
            }
            else if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 3)
            {
                label1.Text = Convert.ToString(a * 0.000000064516);
                vs.Add(a.ToString("0.0") + " кв дюймів = " + label1.Text + " гектара");
            }
            else if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 4)
            {
                label1.Text = Convert.ToString(a * 0.00000000064516);
                vs.Add(a.ToString("0.0") + " кв дюймів = " + label1.Text + " кв кілометрів");
            }
            else if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 5)
            {
                label1.Text = Convert.ToString(a);
                vs.Add(a.ToString("0.0") + " кв дюймів = " + label1.Text + " кв дюймів");
            }
            else if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 6)
            {
                label1.Text = Convert.ToString(a * 0.00694444);
                vs.Add(a.ToString("0.0") + " кв дюймів = " + label1.Text + " кв футів");
            }
            else if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 7)
            {
                label1.Text = Convert.ToString(a * 0.0007716);
                vs.Add(a.ToString("0.0") + " кв дюймів = " + label1.Text + " кв ярдів");
            }
            else if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 8)
            {
                label1.Text = Convert.ToString(a * 0.00000015942);
                vs.Add(a.ToString("0.0") + " кв дюймів = " + label1.Text + " акрів");
            }
            else if (comboBox1.SelectedIndex == 5 && comboBox2.SelectedIndex == 9)
            {
                label1.Text = Convert.ToString(a * 0.0000000002491);
                vs.Add(a.ToString("0.0") + " кв дюймів = " + label1.Text + " кв миль");
            }



            else if (comboBox1.SelectedIndex == 6 && comboBox2.SelectedIndex == 0)
            {
                label1.Text = Convert.ToString(a * 92903.04);
                vs.Add(a.ToString("0.0") + " кв футів = " + label1.Text + " кв міліметрів");
            }
            else if (comboBox1.SelectedIndex == 6 && comboBox2.SelectedIndex == 1)
            {
                label1.Text = Convert.ToString(a * 929.03);
                vs.Add(a.ToString("0.0") + " кв футів = " + label1.Text + " кв сантиметрів");
            }
            else if (comboBox1.SelectedIndex == 6 && comboBox2.SelectedIndex == 2)
            {
                label1.Text = Convert.ToString(a * 0.092903);
                vs.Add(a.ToString("0.0") + " кв футів = " + label1.Text + " кв метрів");
            }
            else if (comboBox1.SelectedIndex == 6 && comboBox2.SelectedIndex == 3)
            {
                label1.Text = Convert.ToString(a * 0.0000092903);
                vs.Add(a.ToString("0.0") + " кв футів = " + label1.Text + " гектара");
            }
            else if (comboBox1.SelectedIndex == 6 && comboBox2.SelectedIndex == 4)
            {
                label1.Text = Convert.ToString(a * 0.000000092903);
                vs.Add(a.ToString("0.0") + " кв футів = " + label1.Text + " кв кілометрів");
            }
            else if (comboBox1.SelectedIndex == 6 && comboBox2.SelectedIndex == 5)
            {
                label1.Text = Convert.ToString(a * 144);
                vs.Add(a.ToString("0.0") + " кв футів = " + label1.Text + " кв дюймів");
            }
            else if (comboBox1.SelectedIndex == 6 && comboBox2.SelectedIndex == 6)
            {
                label1.Text = Convert.ToString(a);
                vs.Add(a.ToString("0.0") + " кв футів = " + label1.Text + " кв футів");
            }
            else if (comboBox1.SelectedIndex == 6 && comboBox2.SelectedIndex == 7)
            {
                label1.Text = Convert.ToString(a * 0.111111);
                vs.Add(a.ToString("0.0") + " кв футів = " + label1.Text + " кв ярдів");
            }
            else if (comboBox1.SelectedIndex == 6 && comboBox2.SelectedIndex == 8)
            {
                label1.Text = Convert.ToString(a * 0.0000229569);
                vs.Add(a.ToString("0.0") + " кв футів = " + label1.Text + " акрів");
            }
            else if (comboBox1.SelectedIndex == 6 && comboBox2.SelectedIndex == 9)
            {
                label1.Text = Convert.ToString(a * 0.00000003587);
                vs.Add(a.ToString("0.0") + " кв футів = " + label1.Text + " кв миль");
            }



            else if (comboBox1.SelectedIndex == 7 && comboBox2.SelectedIndex == 0)
            {
                label1.Text = Convert.ToString(a * 836127.39);
                vs.Add(a.ToString("0.0") + " кв ярдів = " + label1.Text + " кв міліметрів");
            }
            else if (comboBox1.SelectedIndex == 7 && comboBox2.SelectedIndex == 1)
            {
                label1.Text = Convert.ToString(a * 8361.27);
                vs.Add(a.ToString("0.0") + " кв ярдів = " + label1.Text + " кв сантиметрів");
            }
            else if (comboBox1.SelectedIndex == 7 && comboBox2.SelectedIndex == 2)
            {
                label1.Text = Convert.ToString(a * 0.836127);
                vs.Add(a.ToString("0.0") + " кв ярдів = " + label1.Text + " кв метрів");
            }
            else if (comboBox1.SelectedIndex == 7 && comboBox2.SelectedIndex == 3)
            {
                label1.Text = Convert.ToString(a * 0.0000836127);
                vs.Add(a.ToString("0.0") + " кв ярдів = " + label1.Text + " гектара");
            }
            else if (comboBox1.SelectedIndex == 7 && comboBox2.SelectedIndex == 4)
            {
                label1.Text = Convert.ToString(a * 0.00000083613);
                vs.Add(a.ToString("0.0") + " кв ярдів = " + label1.Text + " кв кілометрів");
            }
            else if (comboBox1.SelectedIndex == 7 && comboBox2.SelectedIndex == 5)
            {
                label1.Text = Convert.ToString(a * 1296);
                vs.Add(a.ToString("0.0") + " кв ярдів = " + label1.Text + " кв дюймів");
            }
            else if (comboBox1.SelectedIndex == 7 && comboBox2.SelectedIndex == 6)
            {
                label1.Text = Convert.ToString(a * 9);
                vs.Add(a.ToString("0.0") + " кв ярдів = " + label1.Text + " кв футів");
            }
            else if (comboBox1.SelectedIndex == 7 && comboBox2.SelectedIndex == 7)
            {
                label1.Text = Convert.ToString(a);
                vs.Add(a.ToString("0.0") + " кв ярдів = " + label1.Text + " кв ярдів");
            }
            else if (comboBox1.SelectedIndex == 7 && comboBox2.SelectedIndex == 8)
            {
                label1.Text = Convert.ToString(a * 0.00020661);
                vs.Add(a.ToString("0.0") + " кв ярдів = " + label1.Text + " акрів");
            }
            else if (comboBox1.SelectedIndex == 7 && comboBox2.SelectedIndex == 9)
            {
                label1.Text = Convert.ToString(a * 0.00000032283);
                vs.Add(a.ToString("0.0") + " кв ярдів = " + label1.Text + " кв миль");
            }



            else if (comboBox1.SelectedIndex == 8 && comboBox2.SelectedIndex == 0)
            {
                label1.Text = Convert.ToString(a * 4046854481.18);
                vs.Add(a.ToString("0.0") + " акрів = " + label1.Text + " кв міліметрів");
            }
            else if (comboBox1.SelectedIndex == 8 && comboBox2.SelectedIndex == 1)
            {
                label1.Text = Convert.ToString(a * 40468544.81);
                vs.Add(a.ToString("0.0") + " акрів = " + label1.Text + " кв сантиметрів");
            }
            else if (comboBox1.SelectedIndex == 8 && comboBox2.SelectedIndex == 2)
            {
                label1.Text = Convert.ToString(a * 4046.85);
                vs.Add(a.ToString("0.0") + " акрів = " + label1.Text + " кв метрів");
            }
            else if (comboBox1.SelectedIndex == 8 && comboBox2.SelectedIndex == 3)
            {
                label1.Text = Convert.ToString(a * 0.404685);
                vs.Add(a.ToString("0.0") + " акрів = " + label1.Text + " гектара");
            }
            else if (comboBox1.SelectedIndex == 8 && comboBox2.SelectedIndex == 4)
            {
                label1.Text = Convert.ToString(a * 0.00404685);
                vs.Add(a.ToString("0.0") + " акрів = " + label1.Text + " кв кілометрів");
            }
            else if (comboBox1.SelectedIndex == 8 && comboBox2.SelectedIndex == 5)
            {
                label1.Text = Convert.ToString(a * 6272636.59);
                vs.Add(a.ToString("0.0") + " акрів = " + label1.Text + " кв дюймів");
            }
            else if (comboBox1.SelectedIndex == 8 && comboBox2.SelectedIndex == 6)
            {
                label1.Text = Convert.ToString(a * 43559.98);
                vs.Add(a.ToString("0.0") + " акрів = " + label1.Text + " кв футів");
            }
            else if (comboBox1.SelectedIndex == 8 && comboBox2.SelectedIndex == 7)
            {
                label1.Text = Convert.ToString(a * 4840);
                vs.Add(a.ToString("0.0") + " акрів = " + label1.Text + " кв ярдів");
            }
            else if (comboBox1.SelectedIndex == 8 && comboBox2.SelectedIndex == 8)
            {
                label1.Text = Convert.ToString(a);
                vs.Add(a.ToString("0.0") + " акрів = " + label1.Text + " вкрів");
            }
            else if (comboBox1.SelectedIndex == 8 && comboBox2.SelectedIndex == 9)
            {
                label1.Text = Convert.ToString(a * 0.0015625);
                vs.Add(a.ToString("0.0") + " акрів = " + label1.Text + " кв миль");
            }



            else if (comboBox1.SelectedIndex == 9 && comboBox2.SelectedIndex == 0)
            {
                label1.Text = Convert.ToString(a * 2589987832237.16);
                vs.Add(a.ToString("0.0") + " кв миль = " + label1.Text + " кв міліметрів");
            }
            else if (comboBox1.SelectedIndex == 9 && comboBox2.SelectedIndex == 1)
            {
                label1.Text = Convert.ToString(a * 25899878322.37);
                vs.Add(a.ToString("0.0") + " кв миль = " + label1.Text + " кв сантиметрів");
            }
            else if (comboBox1.SelectedIndex == 9 && comboBox2.SelectedIndex == 2)
            {
                label1.Text = Convert.ToString(a * 2589987.83);
                vs.Add(a.ToString("0.0") + " кв миль = " + label1.Text + " кв метрів");
            }
            else if (comboBox1.SelectedIndex == 9 && comboBox2.SelectedIndex == 3)
            {
                label1.Text = Convert.ToString(a * 640);
                vs.Add(a.ToString("0.0") + " кв миль = " + label1.Text + " гектара");
            }
            else if (comboBox1.SelectedIndex == 9 && comboBox2.SelectedIndex == 4)
            {
                label1.Text = Convert.ToString(a * 2.59);
                vs.Add(a.ToString("0.0") + " кв миль = " + label1.Text + " кв кілометрів");
            }
            else if (comboBox1.SelectedIndex == 9 && comboBox2.SelectedIndex == 5)
            {
                label1.Text = Convert.ToString(a * 4014488909.93);
                vs.Add(a.ToString("0.0") + " кв миль = " + label1.Text + " кв дюймів");
            }
            else if (comboBox1.SelectedIndex == 9 && comboBox2.SelectedIndex == 6)
            {
                label1.Text = Convert.ToString(a * 27878395.93);
                vs.Add(a.ToString("0.0") + " кв миль = " + label1.Text + " кв футів");
            }
            else if (comboBox1.SelectedIndex == 9 && comboBox2.SelectedIndex == 7)
            {
                label1.Text = Convert.ToString(a * 3097599.55);
                vs.Add(a.ToString("0.0") + " кв миль = " + label1.Text + " кв ярдів");
            }
            else if (comboBox1.SelectedIndex == 9 && comboBox2.SelectedIndex == 8)
            {
                label1.Text = Convert.ToString(a * 640);
                vs.Add(a.ToString("0.0") + " кв миль = " + label1.Text + " акрів");
            }
            else 
            {
                label1.Text = Convert.ToString(a);
                vs.Add(a.ToString("0.0") + " кв миль = " + label1.Text + " кв миль");
            }
        

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar > 47 && e.KeyChar < 58) || e.KeyChar == 8 || e.KeyChar == 44 ) //|| e.KeyChar == 45
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
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int a;
            a = comboBox2.SelectedIndex;
            comboBox2.SelectedIndex = comboBox1.SelectedIndex;
            comboBox1.SelectedIndex = a;
           // button1_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

       
        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "binary files (*.bin)|*.bin|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = saveFileDialog1.FileName;
            BinaryWriter binaryWriter = new BinaryWriter(new FileStream(filename, FileMode.Append), Encoding.GetEncoding(1251));
            for(int i = 0; i < vs.Count; i++)
            {
                binaryWriter.Write(vs[i]);
            }
            binaryWriter.Close();
            MessageBox.Show("Файл збережений", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void прочитатиЗФайлуСесіюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.Filter = "binary files (*.bin)|*.bin|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = openFileDialog1.FileName;
            BinaryReader binaryReader = new BinaryReader(new FileStream(filename, FileMode.Open), Encoding.GetEncoding(1251));
            while (binaryReader.PeekChar() > -1)
            {
                listBox1.Items.Add(binaryReader.ReadString());
            }
            binaryReader.Close();
            button5.Visible = true;
            button5.Enabled = true;
            listBox1.Enabled = true;
            listBox1.Visible = true;

            button1.Visible = false;
            button1.Enabled = false;
            button2.Visible = false;
            button2.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            button5.Visible = false;
            button5.Enabled = false;
            listBox1.Enabled = false;
            listBox1.Visible = false;

            button1.Visible = true;
            button1.Enabled = true;
            button2.Visible = true;
            button2.Enabled = true;
        }

        private void очиститиБуферToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vs.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
               
                MessageBox.Show("1 міліметр квадраний = 0.01 сантиметру квадратному\n" +
                    "1 міліметр квадраний  = 0.000001 метру квадратному\n" +
                    "1 міліметр квадраний  = 0.0000000001 гектара\n" +
                    "1 міліметр квадраний = 0,000000000001 кілометру квадратному\n" +
                    "1 міліметр квадраний = 0.0015 дюйму квадратному\n" +
                    "1 міліметр квадраний = 0.0000107 футу квадратному\n" +
                    "1 міліметр квадраний = 0.00000119 ярду квадратному\n" +
                    "1 міліметр квадраний = 0.000000000247 акра\n" +
                    "1 міліметр квадраний = 0.00000000000038 миль квадратних" , "Відношення квадратного міліметра до інших..." );
            }

            else if (comboBox1.SelectedIndex == 1)
            {

                MessageBox.Show("1 сантиметр квадратний = 100 міліметру квадратному\n" +
                    "1 сантиметр квадратний  = 0.0001 метру квадратному\n" +
                    "1 сантиметр квадратний  = 0.00000001 гектара\n" +
                    "1 сантиметр квадратний = 0.0000000001 кілометру квадратному\n" +
                    "1 сантиметр квадратний = 0.1550 дюйму квадратному\n" +
                    "1 сантиметр квадратний = 0.00107 футу квадратному\n" +
                    "1 сантиметр квадратний = 0.0001195 ярду квадратному\n" +
                    "1 сантиметр квадратний = 0.0000000247 акра\n" +
                    "1 сантиметр квадратний = 0.0000000000386 миль квадратних", "Відношення квадратного сантиметра до інших...");
            }

            else if (comboBox1.SelectedIndex == 2)
            {

                MessageBox.Show("1 метр квадратний = 1000000 міліметру квадратному\n" +
                    "1 метр квадратний  = 10000 сантиметру квадратному\n" +
                    "1 метр квадратний  = 0.0001 гектара\n" +
                    "1 метр квадратний = 0.000001 кілометру квадратному\n" +
                    "1 метр квадратний = 1550 дюйму квадратному\n" +
                    "1 метр квадратний = 10.763 футу квадратному\n" +
                    "1 метр квадратний = 1.1959 ярду квадратному\n" +
                    "1 метр квадратний = 0.000247 акра\n" +
                    "1 метр квадратний = 0.000000386 миль квадратних", "Відношення квадратного метра до інших...");
            }

            else if (comboBox1.SelectedIndex == 3)
            {

                MessageBox.Show("1 гектар = 10000000000 міліметрів квадратних\n" +
                    "1 гектар  = 100000000 сантиметрів квадратних\n" +
                    "1 гектар  = 10000 метрів квадратних\n" +
                    "1 гектар = 0.01 кілометрів квадратних\n" +
                    "1 гектар = 15500031 дюймів квадратних\n" +
                    "1 гектар = 107639 футів квадратних\n" +
                    "1 гектар = 11959 ярдів квадратних\n" +
                    "1 гектар = 2.471 акрів\n" +
                    "1 гектар = 0.00386 миль квадратних", "Відношення гектара до інших...");
            }

            else if (comboBox1.SelectedIndex == 4)
            {

                MessageBox.Show("1 кілометр квадраний = 1000000000000 міліметрів квадратних\n" +
                    "1 кілометр квадраний  = 10000000000 сантиметрів квадратних\n" +
                    "1 кілометр квадраний  = 1000000 метрів квадратних\n" +
                    "1 кілометр квадраний = 100 гектарів\n" +
                    "1 кілометр квадраний = 1550003100 дюймів квадратних\n" +
                    "1 кілометр квадраний = 10763910 футів квадратних\n" +
                    "1 кілометр квадраний = 1195990 ярдів квадратних\n" +
                    "1 кілометр квадраний = 247.1 акрів\n" +
                    "1 кілометр квадраний = 0.386 миль квадратних", "Відношення кілометра квадратного до інших...");
            }

            else if (comboBox1.SelectedIndex == 5)
            {

                MessageBox.Show("1 дюйм квадраний = 645.16 міліметрів квадратних\n" +
                    "1 дюйм квадраний  = 6.4516 сантиметрів квадратних\n" +
                    "1 дюйм квадраний  = 0.00064516 метра квадратного\n" +
                    "1 дюйм квадраний = 0.000000064516 гектара\n" +
                    "1 дюйм квадраний = 0.00000000064516 кілометра квадратного\n" +
                    "1 дюйм квадраний = 0.00694 фута квадратного\n" +
                    "1 дюйм квадраний = 0.000771 ярда квадратного\n" +
                    "1 дюйм квадраний = 0.0000001594 акра\n" +
                    "1 дюйм квадраний = 0.000000000249 миль квадратних", "Відношення дюйма квадратного до інших...");
            }

            else if (comboBox1.SelectedIndex == 6)
            {

                MessageBox.Show("1 фут квадраний = 92903.04 міліметрів квадратних\n" +
                    "1 фут квадраний = 929.0304 сантиметрів квадратних\n" +
                    "1 фут квадраний = 0.0929 метра квадратного\n" +
                    "1 фут квадраний = 0.00000929 гектара\n" +
                    "1 фут квадраний = 0.0000000929 кілометра квадратного\n" +
                    "1 фут квадраний = 144 дюймів квадратних\n" +
                    "1 фут квадраний = 0.1111 ярда квадратного\n" +
                    "1 фут квадраний = 0.0000229 акра\n" +
                    "1 фут квадраний = 0.00000003587 миль квадратних", "Відношення фута квадратного до інших...");
            }

            else if (comboBox1.SelectedIndex == 7)
            {

                MessageBox.Show("1 ярд квадраний = 836127.36 міліметрів квадратних\n" +
                    "1 ярд квадраний = 8361.27 сантиметрів квадратних\n" +
                    "1 ярд квадраний = 0.8361 метра квадратного\n" +
                    "1 ярд квадраний = 0.0000836 гектара\n" +
                    "1 ярд квадраний = 0.0000008361 кілометра квадратного\n" +
                    "1 ярд квадраний = 1296 дюймів квадратних\n" +
                    "1 ярд квадраний = 9 футів квадратних\n" +
                    "1 ярд квадраний = 0.0002066 акра\n" +
                    "1 ярд квадраний = 0.0000003228 миль квадратних", "Відношення ярда квадратного до інших...");
            }

            else if (comboBox1.SelectedIndex == 8)
            {

                MessageBox.Show("1 акр = 4046856422.4 міліметрів квадратних\n" +
                    "1 акр = 40468564.224 сантиметрів квадратних\n" +
                    "1 акр = 4046.85 метра квадратного\n" +
                    "1 акр = 0.4046 гектара\n" +
                    "1 акр = 0.004046 кілометра квадратного\n" +
                    "1 акр = 6272640 дюймів квадратних\n" +
                    "1 акр = 43560 футів квадратних\n" +
                    "1 акр = 4840 ярдів квадратних\n" +
                    "1 акр = 0.00156 миль квадратних", "Відношення акра до інших...");
            }

            else if (comboBox1.SelectedIndex == 9)
            {

                MessageBox.Show("1 миля квадратна = 2589988110336 міліметрів квадратних\n" +
                    "1 миля квадратна = 25899881103.36 сантиметрів квадратних\n" +
                    "1 миля квадратна = 2589988.11 метра квадратного\n" +
                    "1 миля квадратна = 258.998 гектарів\n" +
                    "1 миля квадратна = 2.589 кілометрів квадратних\n" +
                    "1 миля квадратна = 4014489600 дюймів квадратних\n" +
                    "1 миля квадратна = 27878400 футів квадратних\n" +
                    "1 миля квадратна = 3097600 ярдів квадратних\n" +
                    "1 миля квадратна = 640 акрів", "Відношення милі квадратної до інших...");
            }
        }
    }
}
