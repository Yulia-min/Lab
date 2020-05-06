using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form3 : Form
    {
        Form1 form;
        int choice;
        public Form3(Form1 form1,int choice1)
        {
            InitializeComponent();
            form = form1;
            choice = choice1;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "Отсортированный";
            string line = "";
            for (int i = 0; i < form.dataGridView1.RowCount; i++)
            {
                line += form.dataGridView1[0, i].Value + " ";
            }

            AonedimensionalArray arr = new AonedimensionalArray(line);
            richTextBox1.Text = line;
            richTextBox1.Text += "\n";
            if (choice == 2)
            {
                arr.Sort1();
            }

            if (choice == 1)
            {
                arr.Sort2();
            }

            line = " ";
            for(int i = 0;i < arr.Lenght; i++)
            {
                line += arr[i] + " ";
            }

            line = line.Trim();
            richTextBox1.Text += line;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
