namespace Inwentaryzacja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Przypisanie obs³ugi zdarzenia KeyDown dla pola has³a
            textBox_Haslo.KeyDown += TextBox_Haslo_KeyDown;

            // Przypisanie obs³ugi zdarzenia FormClosing
            FormClosing += LoginForm_FormClosing;
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // SprawdŸ, czy zamkniêcie dotyczy okna logowania
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Zamknij wszystkie otwarte okna aplikacji
                Application.Exit();
            }
        }

        private void TextBox_Haslo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Wywo³aj metodê weryfikuj¹c¹ logowanie
                button_Zaloguj_Click(sender, e);
            }
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

                // Wyczyœæ pole has³a
                textBox_Haslo.Text = "";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // SprawdŸ, czy zamkniêcie dotyczy okna logowania
            if (e.CloseReason == CloseReason.UserClosing && sender == this)
            {
                // Zamknij ca³¹ aplikacjê
                Application.Exit();
            }
        }

    }
}
