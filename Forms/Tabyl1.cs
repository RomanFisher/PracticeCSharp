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
    public partial class Tabyl1 : Form
    {
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

        public Tabyl1()
        {
            InitializeComponent();
            chart1.Visible = false;
            chart2.Visible = false;
        }

        private void Tabyl1_Load(object sender, EventArgs e)
        {
            this.Text = "Табулювання функцій";
            label1.Text = "Ліва межа";
            label2.Text = "Права межа";
            label3.Text = "Крок";
            label4.Text = "Точність";
            label5.Text = "Крок";
            groupBox1.Text = "Виведення";
            groupBox2.Text = "Додаткові можливості";
            groupBox3.Text = "Додаткові можливості";
            checkBox1.Text = "На екран";
            //checkBox2.Text = "У файл";
            checkBox3.Text = "Сума Y менших за ср. геом.";
            checkBox4.Text = "Похідна";
            checkBox5.Text = "Значення Х при першому від'є..";
            checkBox6.Text = "Добуток від'ємних Y";
            checkBox7.Text = "Вивести Х...";
            checkBox8.Text = "Побудувати графік функції";
            checkBox9.Text = "Очищення виведення";

            checkBox12.Text = "Побудувати графік";
            checkBox13.Text = "Підрахунок суми";
            
            textBox1.Text = "0,5";
            textBox2.Text = "3";
            textBox3.Text = "0,4";
            textBox4.Text = "0,01";
            textBox5.Text = "1";
          
            checkBox1.Checked = true;
            chart1.Visible = false;
            chart2.Visible = false;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void обчисленняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            chart1.Visible = false;
            chart1.Series[0].Points.Clear();
            double d = 1;
            List<double> ts = new List<double>();
            bool vid = true;
            double a, b, h, x, y, t, minY, minX = 0, yP = 0, yVid = 0,xVid =0;
            double[] arr = new double[100];
            if (textBox1.Text == "") a = 0;
            else a = Convert.ToDouble(textBox1.Text);
            if (textBox2.Text == "") b = 0;
            else b = Convert.ToDouble(textBox2.Text);
            if (textBox3.Text == "") h = 0;
            else h = Convert.ToDouble(textBox3.Text);
            if (h == 0) h = 1;
            if ((h < 0) && (a < b)) { t = a; a = b; b = t; h = -1 * h; };
            if ((h > 0) && (a > b)) { t = a; a = b; b = t; };
            if (checkBox1.Checked && !checkBox4.Checked) listBox1.Items.Add("X" + "\t" + "Y");
            else if (checkBox1.Checked && checkBox4.Checked) listBox1.Items.Add("X" + "\t" + "Y" + "\t" + "Y'");
            else listBox1.Items.Add("ERROR DATA");
            minY = (3 * (6 * a + 3 * Math.Pow(a, 4)) * Math.Pow(Math.Cos(2 * a), 3) - 18 * Math.Pow(a, 2) * (3 + Math.Pow(a, 3)) * Math.Pow(Math.Cos(2 * a), 2) * Math.Sin(2 * a)) / (2 * Math.Pow(Math.Pow(3 + Math.Pow(a, 3), 2), 1.0 / 3.0));
            ts.Clear();
            for (x = a; x < b + h / 2; x += h)
            {

                if (checkBox4.Checked == true)

                {
                    yP = (3 * (6 * x + 3 * Math.Pow(x, 4)) * Math.Pow(Math.Cos(2 * x), 3) - 18 * Math.Pow(x, 2) * (3 + Math.Pow(x, 3)) * Math.Pow(Math.Cos(2 * x), 2) * Math.Sin(2 * x)) / (2 * Math.Pow(Math.Pow(3 + Math.Pow(x, 3), 2), 1.0 / 3.0));
                    if (minY > yP) { minY = yP; minX = x; }

                    y = Math.Pow(3 + Math.Pow(x, 3.0), 1.0 / 5.0) * Math.Pow(Math.Cos(2.0 * x), 3) + 6 * Math.Pow(x / 2.0, 2);
                    ts.Add(y);

                    if (checkBox5.Checked && vid && y < 0)
                    {
                        xVid = x;
                        yVid = y;
                        vid = false;
                    }
                }
                //ромчик і женя зрадники :)))))))))))))))))))))))))))))))))))))))))))))))))))
                // аня - зрадниця.!!!!!!!!!!!!!!!!!!!!!!
                else
                {
                    y = Math.Pow(3 + Math.Pow(x, 3.0), 1.0 / 5.0) * Math.Pow(Math.Cos(2.0 * x), 3) + 6 * Math.Pow(x / 2.0, 2);
                    ts.Add(y);
                    if (checkBox5.Checked && vid && y < 0)
                    {
                        xVid = x;
                        yVid = y;
                        vid = false;
                    }
                }
                if (checkBox1.Checked && checkBox4.Checked)
                { listBox1.Items.Add(x.ToString("00.00") + "\t" + y.ToString("00.0000") + "\t" + yP.ToString("00.000") + "\r\n"); }
                else if(checkBox1.Checked) { listBox1.Items.Add(x.ToString("00.00") + "\t" + y.ToString("00.0000") + "\r\n"); }
                if (checkBox8.Checked)
                {
                    chart1.Visible = true;
                    chart1.Series[0].Points.AddXY((x), Math.Cos(x));
                }

            }
            listBox1.Items.Add("_______________________");
            double p = 2.2;
            double ar = ts.Count;
            if (checkBox3.Checked && checkBox1.Checked)
            {

                for (int i = 0; i < ts.Count; i++)
                {
                    d *= ts[i];
                }
                p = Math.Pow(d, 1 / ar);
                d = 0;
                for (int i = 0; i < ts.Count; i++)
                {
                    if (ts[i] < p) d += ts[i];
                }

                listBox1.Items.Add("Серед. геом. = " + p.ToString("0.00"));
                listBox1.Items.Add("Cума = " + d.ToString("0.00"));
                listBox1.Items.Add("_______________________");//Стандарт)))
            }


            if (checkBox4.Checked && checkBox1.Checked)
            {
                listBox1.Items.Add("Y' min = " + minY.ToString("0.00"));
                listBox1.Items.Add("X min = " + minX.ToString("0.00"));
            }
            if(checkBox5.Checked && checkBox1.Checked)
            {
                if (!vid)
                {
                    listBox1.Items.Add("_______________________");
                    listBox1.Items.Add("Перше від'ємне значення:");
                    listBox1.Items.Add("X = " + xVid.ToString("0.00"));
                    listBox1.Items.Add("Y = " + yVid.ToString("0.00"));
                }
                else { listBox1.Items.Add("_______________________"); listBox1.Items.Add("Всі значення >= 0"); }
            }
            double dobutok = 1;
            bool dob = true;
            if(checkBox6.Checked && checkBox1.Checked)
            {
                for (int i = 0; i < ts.Count; i++)
                {
                    if (ts[i] < 0) { dobutok *= ts[i]; dob = false; }
                    
                }
                if(!dob)
                {
                    listBox1.Items.Add("_______________________");
                    listBox1.Items.Add("Добуток від'ємних Y:");
                    listBox1.Items.Add("Добуток = " + dobutok.ToString("0.00"));
                }
                else 
                {
                    listBox1.Items.Add("_______________________");
                    listBox1.Items.Add("Всі числа додатні");
                }
            }
            //double srArah = 0;
            //double srAraf = 0;
            //double nablyzh = ts[0];
            //if (checkBox7.Checked)
            //{
            //    for (int i = 0; i < ts.Count; i++)
            //    {
            //        srArah += ts[i];
            //    }
            //    int f = ts.Count;
            //    srAraf = srArah / f;
            //    for (int i = 0; i < ts.Count; i++)
            //    {
            //       // if()
            //    }
            //}

            

        }



        private void очиститиПолеВведенняToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void всеВключитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkBox3.Checked = true;
            checkBox4.Checked = true;
            checkBox5.Checked = true;
            checkBox6.Checked = true;
            checkBox7.Checked = true;
            checkBox8.Checked = true;
            checkBox9.Checked = true;
        }

        private void всеВиключитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
        }

        private void включитиІнверсивноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkBox3.Checked = !checkBox3.Checked;
            checkBox4.Checked = !checkBox4.Checked;
            checkBox5.Checked = !checkBox5.Checked;
            checkBox6.Checked = !checkBox6.Checked;
            checkBox7.Checked = !checkBox7.Checked;
            checkBox8.Checked = !checkBox8.Checked;
            checkBox9.Checked = !checkBox9.Checked;
        }

        private void всеВключитиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox12.Checked = true;
            checkBox13.Checked = true;
            //checkBox2.Checked = true;
        }

        private void всеВиключатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            //checkBox2.Checked = false;
        }

        private void включитиІнверсивноToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = !checkBox1.Checked;
            checkBox12.Checked = !checkBox12.Checked;
            checkBox13.Checked = !checkBox13.Checked;
            //checkBox2.Checked = !checkBox2.Checked;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar > 47 && e.KeyChar < 58) || e.KeyChar == 44 || e.KeyChar == 8 || e.KeyChar == 45)
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
            if ((e.KeyChar > 47 && e.KeyChar < 58) || e.KeyChar == 44 || e.KeyChar == 8 || e.KeyChar == 45)
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
            if ((e.KeyChar > 47 && e.KeyChar < 58) || e.KeyChar == 44 || e.KeyChar == 8 || e.KeyChar == 45)
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
            if ((e.KeyChar > 47 && e.KeyChar < 58) || e.KeyChar == 44 || e.KeyChar == 8 || e.KeyChar == 45)
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
            if ((e.KeyChar > 47 && e.KeyChar < 58) || e.KeyChar == 44 || e.KeyChar == 8 || e.KeyChar == 45)
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

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void очиститиПолеВиведенняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }
        double Time;
        private void табулюватиToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            //timer1.Interval = 1;
            //timer1.Tick += new EventHandler(timer1_Tick);

            double toch, h,i=1,znach, S=0;
            listBox2.Items.Clear();
            chart2.Visible = false;
            chart2.Series[0].Points.Clear();
            double[] arr = new double[100];
            if (textBox4.Text == "") toch = 0.01;
            else toch = Convert.ToDouble(textBox4.Text);

            if (toch >= 0.99)
            {
                listBox2.Items.Add("FATAL ERROR");
                return;
            }
            else
            {
                if (textBox5.Text == "") h = 0;
                else h = Convert.ToDouble(textBox5.Text);
                znach = (i + 1) / ((Math.Pow(i, 2) + 7 * i - 3) * (4 * i - 3));
                listBox2.Items.Add("I\tY");

                
                timer1.Enabled = true;
                while (Math.Abs(znach) > toch)
                {
                    if(checkBox12.Checked)
                    {
                        chart2.Visible = true;
                        chart2.Series[0].Points.AddXY(i, znach);
                    }
                    listBox2.Items.Add(i.ToString("0.00") +"\t" + znach.ToString("0.0000"));
                    S += znach;
                    i += h;
                    znach = (i + 1) / ((Math.Pow(i, 2) + 7 * i - 3) * (4 * i - 3));
                }
                
                //label6.Text = String.Format("{0:F3}", Time);
                //timer1.Enabled = false;
                //timer1.Stop();


                if (checkBox13.Checked)
                {
                    listBox2.Items.Add("Сума = " + S.ToString("0.00"));
                }
            }
           
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }

        private void записатиУФайлToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "binary files (*.bin)|*.bin|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = saveFileDialog1.FileName;
            BinaryWriter binaryWriter = new BinaryWriter(new FileStream(filename, FileMode.Append), Encoding.GetEncoding(1251));
            if (listBox1 != null)
            {
                foreach (var item in listBox1.Items) 
                {
                    binaryWriter.Write(item.ToString());
                }
            }
            binaryWriter.Close();
            MessageBox.Show("Файл збережений", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void прочитатиЗФайлаToolStripMenuItem1_Click(object sender, EventArgs e)
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
        }

        private void записатиУФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "binary files (*.bin)|*.bin|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = saveFileDialog1.FileName;
            BinaryWriter binaryWriter = new BinaryWriter(new FileStream(filename, FileMode.Append), Encoding.GetEncoding(1251));
            if (listBox1 != null)
            {
                foreach (var item in listBox2.Items)
                {
                    binaryWriter.Write(item.ToString());
                }
            }
            binaryWriter.Close();
            MessageBox.Show("Файл збережений", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void прочитатиЗФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "binary files (*.bin)|*.bin|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = openFileDialog1.FileName;

            BinaryReader binaryReader = new BinaryReader(new FileStream(filename, FileMode.Open), Encoding.GetEncoding(1251));
            while (binaryReader.PeekChar() > -1)
            {
                listBox2.Items.Add(binaryReader.ReadString());
            }
            binaryReader.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time += 0.000001 * timer1.Interval;
            label6.Text = String.Format("{0:F5}", Time);

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
