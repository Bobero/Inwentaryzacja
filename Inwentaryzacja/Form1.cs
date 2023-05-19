namespace Inwentaryzacja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Przypisanie obs�ugi zdarzenia KeyDown dla pola has�a
            textBox_Haslo.KeyDown += TextBox_Haslo_KeyDown;

            // Przypisanie obs�ugi zdarzenia FormClosing
            FormClosing += LoginForm_FormClosing;
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Sprawd�, czy zamkni�cie dotyczy okna logowania
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
                // Wywo�aj metod� weryfikuj�c� logowanie
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

                // Otw�rz nowe okno aplikacji
                MainAppForm mainAppForm = new MainAppForm();
                mainAppForm.Show();

                // Zamknij okno logowania
                this.Hide();
            }
            else
            {
                // Logowanie nieudane
                MessageBox.Show("B��dne dane logowania!");

                // Wyczy�� pole has�a
                textBox_Haslo.Text = "";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Sprawd�, czy zamkni�cie dotyczy okna logowania
            if (e.CloseReason == CloseReason.UserClosing && sender == this)
            {
                // Zamknij ca�� aplikacj�
                Application.Exit();
            }
        }

    }
}
