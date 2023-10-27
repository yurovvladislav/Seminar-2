namespace Seminar_2
{
    public partial class Form1 : Form
    {
        string login;
        string password;
        string per;
        string per2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login = textBox1.Text;
            password = textBox2.Text;
            per = textBox2.Text;
            //
            // label1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}