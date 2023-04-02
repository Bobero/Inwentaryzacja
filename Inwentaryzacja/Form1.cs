namespace Inwentaryzacja
{
    public partial class Form1 : Form
    {
        string user = "Admin";
        string haslo = "Qwert";

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == user & textBox2.Text == haslo)
            {
                label3.Text = "Zalogowano pomyslnie";
            }
            else
            {
                label3.Text = "B³¹d logowania";
                textBox1.Text = default;
                textBox2.Text = default;
            }

        }
    }
}