using System;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;

namespace Inwentaryzacja
{
    public partial class EditCommodityForm : Form
    {
        private int commodityIndex;

        public EditCommodityForm(int index, string uid, string nazwa, string lokalizacja, string kategoria, string model, string opis, DateTime dataDodania)
        {
            InitializeComponent();

            // Przypisanie indeksu rekordu do pola klasy
            commodityIndex = index;

            // Wypełnij pola tekstowe danymi z wybranego wiersza
            UIDTextBox.Text = uid;
            NazwaTextBox.Text = nazwa;
            LokalizacjaTextBox.Text = lokalizacja;
            KategoriaTextBox.Text = kategoria;
            ModelTextBox.Text = model;
            OpisTextBox.Text = opis;
            DataDodaniaDateTimePicker.Value = dataDodania;
        }


        private void EditCommodityForm_Load(object sender, EventArgs e)
        {
            // Wczytaj dane rekordu o danym indeksie i wyświetl w kontrolkach
            LoadCommodityData();
        }

        private void LoadCommodityData()
        {
            try
            {
                // Otwórz połączenie do bazy danych
                using (SqlConnection connection = new SqlConnection("Server=localhost;Database=Inwentaryzacja;User Id=user;Password=!QAZ2wsx;"))
                {
                    connection.Open();

                    // Zapytanie SQL do pobrania danych rekordu o danym indeksie
                    string query = "SELECT * FROM Stock WHERE [Index] = @Index";

                    // Utwórz obiekt SqlCommand do wykonania zapytania
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Dodaj parametr do zapytania SQL
                        command.Parameters.AddWithValue("@Index", commodityIndex);

                        // Utwórz obiekt SqlDataReader do odczytu wyników zapytania
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Pobierz dane z rekordu i przypisz do odpowiednich kontrolkach
                                string uid = reader.GetString(reader.GetOrdinal("UID"));
                                string nazwa = reader.GetString(reader.GetOrdinal("Nazwa"));
                                string lokalizacja = reader.GetString(reader.GetOrdinal("Lokalizacja"));
                                string kategoria = reader.GetString(reader.GetOrdinal("Kategoria"));
                                string model = reader.GetString(reader.GetOrdinal("Model"));
                                string opis = reader.GetString(reader.GetOrdinal("Opis"));
                                DateTime dataDodania = reader.GetDateTime(reader.GetOrdinal("DataDodania"));

                                UIDTextBox.Text = uid;
                                NazwaTextBox.Text = nazwa;
                                LokalizacjaTextBox.Text = lokalizacja;
                                KategoriaTextBox.Text = kategoria;
                                ModelTextBox.Text = model;
                                OpisTextBox.Text = opis;
                                DataDodaniaDateTimePicker.Value = dataDodania;
                            }
                        }
                    }

                    // Zamknij połączenie do bazy danych
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas wczytywania danych: " + ex.Message);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Otwórz połączenie do bazy danych
                using (SqlConnection connection = new SqlConnection("Server=localhost;Database=Inwentaryzacja;User Id=user;Password=!QAZ2wsx;"))
                {
                    connection.Open();

                    // Zapytanie SQL do aktualizacji danych rekordu
                    string query = "UPDATE Stock SET UID = @UID, Nazwa = @Nazwa, Lokalizacja = @Lokalizacja, Kategoria = @Kategoria, Model = @Model, Opis = @Opis, DataDodania = @DataDodania WHERE [Index] = @Index";

                    // Utwórz obiekt SqlCommand do wykonania zapytania
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Dodaj parametry do zapytania SQL
                        command.Parameters.AddWithValue("@UID", UIDTextBox.Text);
                        command.Parameters.AddWithValue("@Nazwa", NazwaTextBox.Text);
                        command.Parameters.AddWithValue("@Lokalizacja", LokalizacjaTextBox.Text);
                        command.Parameters.AddWithValue("@Kategoria", KategoriaTextBox.Text);
                        command.Parameters.AddWithValue("@Model", ModelTextBox.Text);
                        command.Parameters.AddWithValue("@Opis", OpisTextBox.Text);
                        command.Parameters.AddWithValue("@DataDodania", DataDodaniaDateTimePicker.Value);
                        command.Parameters.AddWithValue("@Index", commodityIndex);

                        // Wykonaj zapytanie SQL
                        command.ExecuteNonQuery();

                        // Zamknij połączenie do bazy danych
                        connection.Close();
                    }
                }

                // Wyświetl komunikat o pomyślnym zapisie
                MessageBox.Show("Dane zostały zapisane.");

                // Zamknij okno dialogowe
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas zapisywania danych: " + ex.Message);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Zamknij okno dialogowe
            this.Close();
        }
    }
}
