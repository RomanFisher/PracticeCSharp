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
    public partial class Mass_1 : Form
    {
        public Mass_1()
        {
            InitializeComponent();
            this.Text = "Робота з масивами";
            label2.Text = "Кількість стовпців";
            label1.Text = "Кількість рядків";
            label3.Text = "Ліва межа";
            label5.Text = "Права межа";
            label6.Text = "Ліва межа";
            label7.Text = "Права межа";
            label8.Text = "Кількість людей";
            groupBox3.Text = "Межі рандома";
            checkBox1.Text = "Ввімкнути редагування";
            checkBox2.Text = "Макс вік групи";
            checkBox3.Text = "Ср вік групи";
            checkBox4.Text = "Чи одного вік люди?";
            checkBox7.Text = "Людина найбільш віддалена...";
            checkBox6.Text = "Топ 5 на молодших";
            checkBox5.Text = "Впорядкувати по зростанню";
            checkBox8.Text = "Ввімкнути редагування";
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "1";
            textBox4.Text = "97";
            textBox5.Text = "1";
            textBox6.Text = "97";
            textBox7.Text = "1";
            groupBox1.Text = "Межі рандома";
            groupBox2.Text = "Дод можливості";
            groupBox4.Text = "Дод можливості";
            button2.Text = "Виконати";
            listBox1.Visible = false;
            listBox2.Visible = false;
            button1.Text = "Виконати";
            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;


        }
        List<int> age = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            age.Clear();
            listBox2.Visible = false;
            listBox2.Items.Clear();
            dataGridView2.Rows.Clear();
            int klLud = 0, diazP = 0, diazK = 0;
            if (textBox5.Text == "") diazP = 1;
            else diazP = Convert.ToInt32(textBox3.Text);
            if (textBox6.Text == "") diazK = 12;
            else diazK = Convert.ToInt32(textBox4.Text);
            if (textBox7.Text == "" || textBox7.Text == "0") klLud = 1;
            else klLud = Convert.ToInt32(textBox7.Text);
            dataGridView2.RowCount = 1;
            dataGridView2.ColumnCount = klLud;
            Random random = new Random();
            for (int i = 0; i < klLud; i++)
            {
                dataGridView2.Columns[i].HeaderText = ("Особистість №" + (i + 1));
            }
            for (int i = 0; i < klLud; i++)
            {
                age.Add(random.Next(diazP, diazK));
            }
            for(int i = 0; i < age.Count; i++)
            {
                dataGridView2.Rows[0].Cells[i].Value = Convert.ToInt32(age[i]);
            }

            if (checkBox7.Checked)
            {
                listBox2.Visible = true;
                int srZnach = 0;
                for (int i = 0; i < age.Count; i++)
                {
                    srZnach += age[i];
                }
                srZnach /= age.Count;
                int kl = 0;
                for (int i = 0; i < age.Count; i++)
                {
                    if (age[i] > srZnach) kl++;
                }
                listBox2.Items.Add("________________________________________");
                listBox2.Items.Add(kl + " людина старші серенього віку");
            }

            if(checkBox6.Checked)
            {
                listBox2.Visible = true;
                List<string> vs = new List<string>();
                age.Sort();
                for(int j = 0; j < 5; j++)
                {
                    for(int i = 0; i < age.Count; i++)
                    {
                        if (age[j] == Convert.ToInt32(dataGridView2.Rows[0].Cells[i].Value))
                        {
                            vs.Add(dataGridView2.Columns[i].HeaderText);
                        }
                    }
                }
                
                if(vs.Count != 0)
                {
                    listBox2.Items.Add("________________________________________");
                    listBox2.Items.Add("Топ 5 наймолодших");
                    for(int i = 0; i < vs.Count; i++)
                    {
                        listBox2.Items.Add(vs[i]);
                    }
                }
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            listBox1.Items.Clear();
            dataGridView1.Rows.Clear();
            int a = 0, b = 0, diazP = 0 , diazK = 0;
            if (textBox2.Text == "" || textBox2.Text == "0") b = 1;
            else b = Convert.ToInt32(textBox2.Text);
            if (textBox1.Text == "" || textBox1.Text == "0") a = 1;
            else a = Convert.ToInt32(textBox1.Text);
            if (textBox3.Text == "") diazP = 1;
            else diazP = Convert.ToInt32(textBox3.Text);
            if (textBox4.Text == "") diazK = 12;
            else diazK = Convert.ToInt32(textBox4.Text);
            dataGridView1.RowCount = a;
            dataGridView1.ColumnCount = b;
            for (int i = 0; i < b; i++)
            {
                 dataGridView1.Columns[i].HeaderText = ("Група №" + (i+1));
            }
           
            Random random = new Random();
            int[][] age = new int[a][];
            for(int i = 0; i < a ; i++)
            {
                age[i] = new int[b];
            }

            for(int i=0;i<a;i++)
            {
                for(int j = 0; j<b;j++)
                {
                    age[i][j] = random.Next(diazP, diazK);
                }
            }
           

            for (int i = 0; i < b; i++)
            {
                for (int u = 0; u < a; u++)
                {
                    dataGridView1.Rows[u].Cells[i].Value = Convert.ToString(age[u][i]);
                }

            }
           
            if(checkBox2.Checked)
            {
                int max = diazP;
                // ох уж ці жені!!!!!!!!!!!!!!!!!!!! ох уж ці @нички!!!!!!!!!!!!!!!!!!!!!!!!!!!
                // 
                List<int> maxi = new List<int>();
                listBox1.Visible = true;
                for (int i = 0; i < b; i++)
                {
                    for (int u = 0; u < a; u++)
                    {
                       if(max < age[u][i])  max = age[u][i];
                    }

                    maxi.Add(max);
                    max = diazP;
                }
            for(int p = 0; p < maxi.Count; p++)
                {
                    listBox1.Items.Add("Група №" + (p+1) + " - макс вік = " + maxi[p]) ;
                }
            }

            
            
            if (checkBox3.Checked)
            {   
                int sr = 0;
                List<int> srVik = new List<int>();
                listBox1.Visible = true;
                for (int i = 0; i < b; i++)
                {
                    for (int u = 0; u < a; u++)
                    {
                        sr += age[u][i];
                    }

                    srVik.Add(sr / a);
                    sr = 0;
                }
                for (int p = 0; p < srVik.Count; p++)
                {
                    listBox1.Items.Add("Ср вік в групі №" + (p+1) + " = " + srVik[p]);
                }
            }

            if (checkBox4.Checked)
            {
                int max = diazP;
                int min = diazK;
                int num = 0;
                listBox1.Visible = true;
                List<string> resul = new List<string>();
                for (int i = 0; i < b; i++)
                {
                    for (int u = 0; u < a; u++)
                    {
                        if (max < age[u][i]) max = age[u][i];
                        if (min > age[u][i]) min = age[u][i];
                        num = i + 1 ;
                    }

                    if (max - min > 5) resul.Add("Люди в групі№ " + num + " різного віку");
                    else resul.Add("Люди в групі№ " + num + " одного віку");
                }
                for(int i = 0; i < resul.Count; i++)
                {

                    listBox1.Items.Add(resul[i]);
                }
            }


            // this.dataGridView1.EditMode = DataGridViewEditMode.EditOnF2;


            //ромчик не вітається!!!!!!!!!!!!!!!!!
            //женя тоже!!!!!!!!!
            // аня теж !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //софі богиня!!!!!!!!!!!!!!!!!!!11
            //лєрко тоже!!!!!!!
            //ох уж ці жені!!!!!

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void включитиВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            checkBox4.Checked = true;
           // checkBox5.Checked = true;
            checkBox6.Checked = true;
            checkBox7.Checked = true;
        }

        private void виключитиВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
           // checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
        }

        private void включитиРеверсивноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = !checkBox2.Checked;
            checkBox3.Checked = !checkBox3.Checked;
            checkBox4.Checked = !checkBox4.Checked;
          //  checkBox5.Checked = !checkBox5.Checked;
            checkBox6.Checked = !checkBox6.Checked;
            checkBox7.Checked = !checkBox7.Checked;
        }

        

        private void записатиУФаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            textBox6.Text = "";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Mass_1_Load(object sender, EventArgs e)
        {
          
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked) dataGridView2.ReadOnly = false;
            else dataGridView2.ReadOnly = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) dataGridView1.ReadOnly = false;
            else dataGridView1.ReadOnly = true;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (age.Count == 0) MessageBox.Show("Список людей ПУСТИЙ!?!?!?!?!");
            else
            {
                age.Sort();
                for(int i = 0; i < age.Count; i++)
                {
                    dataGridView2.Rows[0].Cells[i].Value = age[i];
                }
            }
        }

        private void прочитатиЗФайлуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
          //  listBox2.Visible = true;
            openFileDialog1.Filter = "binary files (*.bin)|*.bin|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = openFileDialog1.FileName;
            dataGridView2.Rows.Clear();
            dataGridView2.RowCount = 1;
            List<string> vs = new List<string>();
            BinaryReader binaryReader = new BinaryReader(new FileStream(filename, FileMode.Open), Encoding.GetEncoding(1251));
            while (binaryReader.PeekChar() > -1)
            {
                vs.Add(binaryReader.ReadString());
            }
            dataGridView2.ColumnCount = vs.Count;
            for(int i = 0; i < vs.Count; i++)
            {
                dataGridView2.Rows[0].Cells[i].Value = vs[i];
            }
            binaryReader.Close();
        }

        private void записатиУФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "binary files (*.bin)|*.bin|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = saveFileDialog1.FileName;
           
            // mistas.Clear();
            BinaryWriter binaryWriter = new BinaryWriter(new FileStream(filename, FileMode.Append), Encoding.GetEncoding(1251));
            for(int i = 0; i<dataGridView2.ColumnCount;i++)
            {
                 binaryWriter.Write(Convert.ToString(dataGridView2.Rows[0].Cells[i].Value));
            }
            binaryWriter.Close();
            MessageBox.Show("Файл збережений", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void очиститиПолеВиводуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void очиститиПолеВиведенняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void записатиУФаToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "binary files (*.bin)|*.bin|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = saveFileDialog1.FileName;

            // mistas.Clear();
            BinaryWriter binaryWriter = new BinaryWriter(new FileStream(filename, FileMode.Append), Encoding.GetEncoding(1251));
            binaryWriter.Write(dataGridView1.RowCount);
            binaryWriter.Write(dataGridView1.ColumnCount);
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for(int j = 0; j < dataGridView1.RowCount; j++)
                {
                     binaryWriter.Write(Convert.ToString(dataGridView1.Rows[j].Cells[i].Value));
                }
               
            }
            binaryWriter.Close();
            MessageBox.Show("Файл збережений", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void прочитатиЗФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //listBox1.Visible = true;
            dataGridView1.Rows.Clear();
            openFileDialog1.Filter = "binary files (*.bin)|*.bin|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = openFileDialog1.FileName;

            BinaryReader binaryReader = new BinaryReader(new FileStream(filename, FileMode.Open), Encoding.GetEncoding(1251));
            dataGridView1.RowCount = binaryReader.ReadInt32();
            dataGridView1.ColumnCount = binaryReader.ReadInt32();
            for(int i = 0; i < dataGridView1.RowCount; i++)
            {
                for(int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(binaryReader.ReadInt32());
                }
            }
            binaryReader.Close();
        }
    }
}
