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
    public partial class Verefication : Form
    {
        bool x = true;
        bool x1 = false;

        bool x2 = true;
        bool x3 = false;

        bool x4 = true;
        bool x5 = false;
        public class mista
        {
            public string name;
            public double ploscha;
            public int klLud;

            private string[] studentInfo;
            public mista() { }
            //  Конструктор
            public mista(string nameC, double plosch, int KlLUD)
            {
                name = nameC;
                ploscha = plosch;
                klLud= KlLUD;
            }
        };
        List<mista> mistas = new List<mista>();
        public Verefication()
        {
            InitializeComponent();
            this.Text = "   Країни світу";
            label2.Text = "Введіть пароль";
            label1.Text = "Введіть країну";
            label3.Text = "Введіть її площу(км^2)";
            label4.Text = "Введіть кількість населення";
            button2.Text = "Ввійти";
            button3.Text = "Очистити";
            button8.Text = "Держави, густина..";
            button1.Text = "Додати";
            tabControl1.Visible = false;
            tabControl1.Enabled = false;
            button5.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") MessageBox.Show("Введіть пароль!");
            else if (textBox1.Text == "user")
            {
                textBox1.Visible = false;
                textBox1.Enabled = false;
                label2.Enabled = false;
                label2.Visible = false;
                button2.Visible = false;
                button2.Enabled = false;

                tabControl1.Visible = true;
                tabControl1.Enabled = true;

                dataGridView1.ReadOnly = true;

                button5.Enabled = false;
            }
            else if (textBox1.Text == "admin")
            {
                textBox1.Visible = false;
                textBox1.Enabled = false;
                label2.Enabled = false;
                label2.Visible = false;
                button2.Visible = false;
                button2.Enabled = false;

                button5.Enabled = true;
                dataGridView1.ReadOnly = false;
                tabControl1.Visible = true;
                tabControl1.Enabled = true;
            }
            else { MessageBox.Show("ПАРОЛЬ не  правильний!?!?!?!?!"); textBox1.Text = ""; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string name;
            double S;
            int kl;
            if (textBox2.Text != "") name = textBox2.Text;
            else name = "******";
            if (textBox3.Text != "") S = Convert.ToDouble(textBox3.Text);
            else S = 0.0;
            if (textBox4.Text != "") kl = Convert.ToInt32(textBox4.Text);
            else kl = 0;
            mista mista = new mista();
            mista.name = name;
            mista.ploscha = S;
            mista.klLud = kl;
            mistas.Add(mista);
            for (int i = 0; i < mistas.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = mistas[i].name;
                dataGridView1.Rows[i].Cells[1].Value = mistas[i].ploscha;
                dataGridView1.Rows[i].Cells[2].Value = mistas[i].klLud;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mistas.Clear();
            dataGridView1.Rows.Clear();
            textBox3.Text = "";
            textBox4.Text = "";
            textBox2.Text = "";
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

        private void записатиУФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "binary files (*.bin)|*.bin|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = saveFileDialog1.FileName;
            int i = 0;
            // mistas.Clear();
            BinaryWriter binaryWriter = new BinaryWriter(new FileStream(filename, FileMode.Append), Encoding.GetEncoding(1251));
            //while (dataGridView1.Rows[i].Cells[0].Value != null)
            //{
            //    string St0 = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
            //    string St1 = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
            //    string St2 = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
            //    string St3 = Convert.ToString(dataGridView1.Rows[i].Cells[3].Value);
            //    info temp = new info(St0, St1, St2, St3);
            //    mistas.Add(temp);
            //    i++;
            //}
            for (int p = 0; p < mistas.Count; p++)
            {
                binaryWriter.Write(mistas[p].name);
                binaryWriter.Write(mistas[p].ploscha);
                binaryWriter.Write(mistas[p].klLud);
            }
            binaryWriter.Close();
            MessageBox.Show("Файл збережений", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aЯToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s1, s2;
            for (int i = mistas.Count - 1; i >= 0; --i)
            {
                for (int j = 0; j < i; ++j)
                {
                    s1 = mistas[j].name;
                    s2 = mistas[j + 1].name;
                    if (string.Compare(s1, s2) > 0)
                    {
                        swap(j, j + 1);
                    }
                }
            }
            for (int p = 0; p < mistas.Count; p++)
            {

                dataGridView1.Rows[p].Cells[0].Value = mistas[p].name;
                dataGridView1.Rows[p].Cells[1].Value = mistas[p].ploscha;
                dataGridView1.Rows[p].Cells[2].Value = mistas[p].klLud;
            }
        }
        public void swap(int i1, int i2)
        {
            mista temp;
            temp = mistas[i1];
            mistas[i1] = mistas[i2];
            mistas[i2] = temp;
        }
        private void прочититиЗФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            openFileDialog1.Filter = "binary files (*.bin)|*.bin|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = openFileDialog1.FileName;
            mistas.Clear();
            BinaryReader binaryReader = new BinaryReader(new FileStream(filename, FileMode.Open), Encoding.GetEncoding(1251));
            while (binaryReader.PeekChar() > -1)
            {
                string name = binaryReader.ReadString();
                double S = binaryReader.ReadDouble();
                int kl = binaryReader.ReadInt32();
                mista temp = new  mista(name, S, kl);
                mistas.Add(temp);
            }
            binaryReader.Close();
            for (int i = 0; i < mistas.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = mistas[i].name;
                dataGridView1.Rows[i].Cells[1].Value = mistas[i].ploscha;
                dataGridView1.Rows[i].Cells[2].Value = mistas[i].klLud;
            }
            for(int i = 0; i < mistas.Count;i++)
            {
                comboBox1.Items.Add(mistas[i].name);
            }
        }

        private void яАToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s1, s2;
            for (int i = mistas.Count - 1; i >= 0; --i)
            {
                for (int j = 0; j < i; ++j)
                {
                    s1 = mistas[j].name;
                    s2 = mistas[j + 1].name;
                    if (string.Compare(s1, s2) < 0)
                    {
                        swap(j, j + 1);
                    }
                }
            }

            for (int p = 0; p < mistas.Count; p++)
            {

                dataGridView1.Rows[p].Cells[0].Value = mistas[p].name;
                dataGridView1.Rows[p].Cells[1].Value = mistas[p].ploscha;
                dataGridView1.Rows[p].Cells[2].Value = mistas[p].klLud;
            }
        }

        private void Verefication_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            int i = 0;
            string x1;
            x1 = comboBox1.Text;

            for (int p = 0; p < mistas.Count; p++)
            {
                if (mistas[p].name == x1)
                {
                    textBox9.Text = mistas[p].name;
                    textBox8.Text = Convert.ToString(mistas[p].ploscha);
                    textBox7.Text = Convert.ToString(mistas[p].klLud);
                    break;
                }
            }
        }
        int currentOne;
        private void button6_Click(object sender, EventArgs e)
        {
            string x1;
            x1 = Convert.ToString(textBox5.Text);
            bool posh = false;
            for (int i = 0; i < mistas.Count; i++)
            {
                if (mistas[i].name == x1)
                {
                    MessageBox.Show("Запис знайдено", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox9.Text = mistas[i].name;
                    textBox8.Text = Convert.ToString(mistas[i].ploscha);
                    textBox7.Text = Convert.ToString(mistas[i].klLud);
                    currentOne = i;
                    posh = true;
                    break;
                }
            }
            if (!posh)
            {
                MessageBox.Show("Такого запису не знайдено", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (currentOne > 0)
            {
                --currentOne;
                textBox9.Text = mistas[currentOne].name;
                textBox8.Text = Convert.ToString(mistas[currentOne].ploscha);
                textBox7.Text = Convert.ToString(mistas[currentOne].klLud);
            }
            else { MessageBox.Show("Попереднього запису немає", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (currentOne < mistas.Count-1)
            {
                ++currentOne;
                textBox9.Text = mistas[currentOne].name;
                textBox8.Text = Convert.ToString(mistas[currentOne].ploscha);
                textBox7.Text = Convert.ToString(mistas[currentOne].klLud);
            }
            else MessageBox.Show("Наступного запису немає", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        int currentMax;
        private void button5_Click(object sender, EventArgs e)
        {
            string message = "Ви впевнені що бажаєте стерти саме цей запис ?";
            string caption = "!_?_!_?_!_?_!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon ico = MessageBoxIcon.Warning;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons, ico);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                mistas.RemoveAt(currentOne);
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add(10);  //  ВОТ ТУТ ХАРАШО ПРАЦЮЄ ЯКЩО НІЧОГО НЕ ЧІПАТИ //
                for (int p = 0; p < mistas.Count; p++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[p].Cells[0].Value = mistas[p].name;
                    dataGridView1.Rows[p].Cells[1].Value = mistas[p].ploscha;
                    dataGridView1.Rows[p].Cells[2].Value = mistas[p].klLud;
                }
                comboBox1.Items.RemoveAt(currentOne);
                if (currentOne > 0) --currentOne;
                currentMax = mistas.Count;
                if (currentMax == 0)
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                }
                textBox9.Text = "";
                textBox8.Text = "";
                textBox7.Text = "";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<double> zn = new List<double>();
            for(int i = 0; i < mistas.Count; i++)
            {
                zn.Add(mistas[i].klLud / mistas[i].ploscha);
            }
            double srZnach = 0;
            for (int i = 0; i < zn.Count; i++)
            {
               srZnach+=zn[i];
            }
            srZnach /= zn.Count;
            for (int i = 0; i < mistas.Count; i++)
            {
                if (zn[i] > srZnach) listBox1.Items.Add(mistas[i].name);
            }
        }

        /*ПЕРЕВІРКА!!!!!!*/
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || e.KeyChar == 8 || e.KeyChar == 32)
            {
                e.Handled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
            if (c == 0) x = true;
            else x = false;
            if (str.Length == 0) x1 = false;
            else x1 = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar > 47 && e.KeyChar < 58) || e.KeyChar == 44 || e.KeyChar == 8 )//|| e.KeyChar == 45
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
            str = textBox3.Text;
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

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
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
            if (c == 0) x4 = true;
            else x4 = false;
            if (str.Length == 0) x5 = false;
            else x5 = true;
        }
    }
}
