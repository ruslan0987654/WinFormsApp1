namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string name = "";
        string email = "";
        string password = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            email = textBox2.Text;
            password = textBox3.Text;

            MessageBox.Show("Qeydiyyat uğurla tamamlandı!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == email &&
                textBox5.Text == password)
            {
                MessageBox.Show("Hesaba daxil oldunuz!");
            }
            else
            {
                MessageBox.Show("Email və ya password səhvdir!");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
    }
}