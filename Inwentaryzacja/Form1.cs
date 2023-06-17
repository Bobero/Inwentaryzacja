using System.Data.SqlClient;
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

            string connectionString = "Server=localhost;Database=Inwentaryzacja;User Id=user;Password=!QAZ2wsx;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Wykonaj zapytanie do bazy danych
                    string query = "SELECT COUNT(*) FROM users WHERE Login = @login AND Passwd = @haslo";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@haslo", haslo);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
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
                        MessageBox.Show("Błędne dane logowania!");

                        // Wyczyść pole hasła
                        textBox_Haslo.Text = "";
                    }
                }
                catch (SqlException ex)
                {
                    // Obsłuż wyjątek, jeśli wystąpił problem z połączeniem lub wykonaniem zapytania
                    MessageBox.Show("Wystąpił błąd podczas połączenia z bazą danych: " + ex.Message);
                }
                connection.Close();
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