using System;
using System.Windows.Forms;
using System.IO;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Форма";
            openFileDialog1.FileName = " ";
            openFileDialog1.Filter = "Текстовые файлы(*.txt)|*.txt|Allfiles (*.*)|*.*";
            saveFileDialog1.Filter = "Текстовые файлы(*.txt)|*.txt|Allfiles (*.*)|*.*";
        }

        private void Save()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false, System.Text.Encoding.Default))
                {
                    string line = " ";
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        line += dataGridView1[0, i].Value + " ";
                    }
                    line = line.Trim();
                    sw.Write(line);
                    sw.Close();
                }
            }
            catch (Exception Ситуация)
            {
                MessageBox.Show(Ситуация.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void НовыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (dataGridView1.ColumnCount < 1)
            {
                dataGridView1.Columns.Add("1", "Массив");
                dataGridView1.Columns[0].Width = 347;
            }

            dataGridView1.Columns[0].Width = 347;
        }
        private void ОткрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = " ";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == null) return;
            try
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    string line=sr.ReadToEnd();
                    string[] tmp = line.Split(' ');
                    dataGridView1.Rows.Clear();
                    if (dataGridView1.ColumnCount < 1)
                    {
                        dataGridView1.Columns.Add("1", "Массив");
                        dataGridView1.Columns[0].Width = 330;
                    }
                    dataGridView1.Columns[0].Width = 330;
                    foreach (string s in tmp)
                    {
                        dataGridView1.Rows.Add(s);
                    }
                    sr.Close();
                }
            }
            catch (FileNotFoundException Ситуация)
            {
                MessageBox.Show(Ситуация.Message + "\nФайл не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception Ситуация)
            {
                MessageBox.Show(Ситуация.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "NoNameFile";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK) Save();
        }
        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void СуммаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string line = " ";
            for(int i = 0; i < dataGridView1.RowCount; i++)
            {
                line += dataGridView1[0, i].Value + " ";
            }

            AonedimensionalArray arr = new AonedimensionalArray(line);
            MessageBox.Show($"сумма:{arr.Sum()}", "Сумма", MessageBoxButtons.OK);
        }
        private void КоличествоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(this);
            form.Show();
        }
        private void ПоУбываниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3(this, 1);
            form.Show();
        }
        private void ПоВозрастаниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3(this, 2);
            form.Show();
        }
        private void ОбАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
