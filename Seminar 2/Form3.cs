using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar_2
{
    public partial class Form3 : Form
    {
        string[] months = { "Август", "Сентябрь", "Октябрь" };
        int c_cats;
        string text;
        string month;
        string cat;
        string[] cats = { "Продукты", "Налоги и ЖКХ", "Вещи", "Техника", "Прочее" };
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //запрос на заполнение массива cats и months, а также заполнение datagridview1
            c_cats = cats.Length;
            
            
            show();
            show2();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Form1 f = new Form1();
            //f.Show();
            //this.Hide();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            text = textBox1.Text;
            month = comboBox1.Text;
            cat = comboBox2.Text;
            //запрос на обновление datagridview
            show();
            panel1.Visible = false;
            text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            text = textBox2.Text;
            //запрос на добавление в cats
            panel2.Visible = false;
            text = "";
            show();
            show2();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            text = textBox2.Text;
            //запрос на удаление в cats
            panel2.Visible = false;
            text = "";
            show();
            show2();
        }
        public void show()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            for (int i = 0; i < months.Length; i++)
            {
                dataGridView1.Columns.Add(Convert.ToString(i), months[i]);
            }
            for (int i = 0; i < c_cats; i++)
            {
                dataGridView1.Rows.Add("");
                dataGridView1.Rows[i].HeaderCell.Value = cats[i];
                dataGridView1.Rows[i].ReadOnly = true;
            }
        }

        public void show2()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            foreach (var item in cats)
            {
                comboBox1.Items.Add(item);
                comboBox2.Items.Add(item);
            }
        }


    }
}
