namespace Inwentaryzacja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Zaloguj_Click(object sender, EventArgs e)
        {
            string login = textBox_Login.Text;
            string haslo = textBox_Haslo.Text;

            if (login == "admin" && haslo == "1234")
            {
                // Logowanie poprawne
                MessageBox.Show("Logowanie udane!");

                // Otwórz nowe okno aplikacji
                MainAppForm mainAppForm = new MainAppForm();
                mainAppForm.Show();

                // Zamknij okno logowania
                this.Hide();
            }
            else
            {
                // Logowanie nieudane
                MessageBox.Show("B³êdne dane logowania!");
            }
        }
    }
}