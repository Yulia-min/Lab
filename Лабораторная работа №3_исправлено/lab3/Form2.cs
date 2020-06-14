using System;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form2 : Form
    {
        private readonly Form1 form;

        public Form2(Form1 form1)
        {           
            form = form1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Text = "Количество";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string line = " ";
            for (int i = 0; i < form.dataGridView1.RowCount; i++)
            {
                line += form.dataGridView1[0, i].Value + " ";
            }

            var arr = AonedimensionalArray.GetCollectionFromDataGridView(form.dataGridView1);

            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            if (x == 0 && y == 0)
            {
                MessageBox.Show($"Количество:{arr.SearchNegativeElements()}", "Количество", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show($"Количество:{arr.SearchNegativeElements(x, y)}", "Количество", MessageBoxButtons.OK);
            }
            Close();
        }
    }
}
