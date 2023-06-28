using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inwentaryzacja
{
    public partial class MainAppForm : Form
    {
        // Połączenie do bazy danych
        private SqlConnection connection;

        public MainAppForm()
        {
            InitializeComponent();

            // Przypisanie obsługi zdarzenia FormClosing
            FormClosing += MainAppForm_FormClosing;

            // Inicjalizacja połączenia do bazy danych
            connection = new SqlConnection("Server=localhost;Database=Inwentaryzacja;User Id=user;Password=!QAZ2wsx;");
        }

        private void MainAppForm_Load(object sender, EventArgs e)
        {
            // Kod do wykonania po załadowaniu okna aplikacji
            AddCommodity.Click += AddCommodity_Click;
            UsersManage.Click += UsersManage_Click;


            // Wczytaj dane z tabeli "Stock" i wyświetl w DataGridView "StockView"
            LoadStockData();

            // Dodaj przycisk do pierwszego wiersza DataGridView "StockView"
            AddFilterButton();
        }

        private void LoadStockData()
        {
            try
            {
                // Otwórz połączenie do bazy danych
                connection.Open();

                // Zapytanie SQL do pobrania danych z tabeli "Stock"
                string query = "SELECT * FROM Stock";

                // Utwórz obiekt SqlDataAdapter do wykonania zapytania i pobrania danych
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    // Utwórz obiekt DataTable do przechowywania pobranych danych
                    DataTable dataTable = new DataTable();

                    // Wypełnij obiekt DataTable danymi z bazy danych
                    adapter.Fill(dataTable);

                    // Przypisz DataTable jako źródło danych dla DataGridView "StockView"
                    StockView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas wczytywania danych z bazy danych: " + ex.Message);
            }
            finally
            {
                // Upewnij się, że połączenie jest zamknięte
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }


        private void AddFilterButton()
        {
            // Tworzenie przycisku "Edytuj"
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "EditButtonColumn";
            editButtonColumn.HeaderText = "";
            editButtonColumn.Text = "Edytuj";
            editButtonColumn.UseColumnTextForButtonValue = true;

            // Dodawanie przycisku "Edytuj" do DataGridView "StockView"
            StockView.Columns.Add(editButtonColumn);

            // Przypisanie obsługi zdarzenia CellClick dla przycisku "Edytuj"
            StockView.CellClick += StockView_CellClick;

            // Tworzenie przycisku "Usuń"
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "DeleteButtonColumn";
            deleteButtonColumn.HeaderText = "";
            deleteButtonColumn.Text = "Usuń";
            deleteButtonColumn.UseColumnTextForButtonValue = true;

            // Dodawanie przycisku "Usuń" do DataGridView "StockView"
            StockView.Columns.Add(deleteButtonColumn);
        }

        // ...

        private void StockView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sprawdź, czy kliknięcie nastąpiło w kolumnie z przyciskiem edycji
            if (e.RowIndex >= 0 && e.ColumnIndex == StockView.Columns["EditButtonColumn"].Index)
            {
                // Pobierz indeks wiersza
                int rowIndex = e.RowIndex;

                // Pobierz wartość kolumny "Index" wiersza, który ma być edytowany
                int index = Convert.ToInt32(StockView.Rows[rowIndex].Cells["Index"].Value);
                // Pobierz dane z wybranego wiersza
                string uid = StockView.Rows[e.RowIndex].Cells["UID"].Value.ToString();
                string nazwa = StockView.Rows[e.RowIndex].Cells["Nazwa"].Value.ToString();
                string lokalizacja = StockView.Rows[e.RowIndex].Cells["Lokalizacja"].Value.ToString();
                string kategoria = StockView.Rows[e.RowIndex].Cells["Kategoria"].Value.ToString();
                string model = StockView.Rows[e.RowIndex].Cells["Model"].Value.ToString();
                string opis = StockView.Rows[e.RowIndex].Cells["Opis"].Value.ToString();
                DateTime dataDodania = Convert.ToDateTime(StockView.Rows[e.RowIndex].Cells["DataDodania"].Value);

                // Otwórz okno "EditCommodityForm" jako modalne, przekazując dane rekordu
                EditCommodityForm editCommodityForm = new EditCommodityForm(index,uid, nazwa, lokalizacja, kategoria, model, opis, dataDodania);
                editCommodityForm.ShowDialog();

                // Po zamknięciu okna odśwież dane w DataGridView "StockView"
                LoadStockData();
                return;
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == StockView.Columns["DeleteButtonColumn"].Index)
            {
                // Pobierz indeks wiersza
                int rowIndex = e.RowIndex;

                // Pobierz wartość kolumny "Index" wiersza, który ma zostać usunięty
                int index = Convert.ToInt32(StockView.Rows[rowIndex].Cells["Index"].Value);

                // Wywołaj metodę usuwania danych dla danego indeksu
                DeleteStockData(index);

                // Po usunięciu odśwież dane w DataGridView "StockView"
                LoadStockData();
            }
        }



        // ...



        private void DeleteStockData(int index)
        {
            try
            {
                // Otwórz połączenie do bazy danych
                connection.Open();

                // Zapytanie SQL do usuwania danych z tabeli "Stock"
                string query = "DELETE FROM Stock WHERE [Index] = @Index";

                // Utwórz obiekt SqlCommand do wykonania zapytania
                SqlCommand command = new SqlCommand(query, connection);

                // Dodaj parametr do zapytania SQL
                command.Parameters.AddWithValue("@Index", index);

                // Wykonaj zapytanie SQL
                command.ExecuteNonQuery();

                // Zamknij połączenie do bazy danych
                connection.Close();

                // Po usunięciu odśwież dane w DataGridView "StockView"
                LoadStockData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas usuwania danych: " + ex.Message);
            }
            finally
            {
                // Upewnij się, że połączenie zostanie zawsze zamknięte
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void FilterStockData(string filterText)
        {
            try
            {
                // Otwórz połączenie do bazy danych
                connection.Open();

                // Zapytanie SQL do filtrowania danych
                string query = "SELECT * FROM Stock WHERE Nazwa LIKE @FilterText";

                // Utwórz obiekt SqlCommand do wykonania zapytania
                SqlCommand command = new SqlCommand(query, connection);

                // Dodaj parametr do zapytania SQL
                command.Parameters.AddWithValue("@FilterText", "%" + filterText + "%");

                // Utwórz obiekt SqlDataAdapter do wykonania zapytania i pobrania danych
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Utwórz obiekt DataTable do przechowywania pobranych danych
                DataTable dataTable = new DataTable();

                // Wypełnij obiekt DataTable danymi z bazy danych
                adapter.Fill(dataTable);

                // Przypisz DataTable jako źródło danych dla DataGridView "StockView"
                StockView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas filtrowania danych: " + ex.Message);
            }
            finally
            {
                // Zamknij połączenie do bazy danych
                connection.Close();
            }
        }
        private void AddCommodity_Click(object sender, EventArgs e)
        {
            // Otwórz okno "AddCommodityForm" jako modalne
            AddCommodityForm addCommodityForm = new AddCommodityForm();
            addCommodityForm.ShowDialog();

            // Po zamknięciu okna odśwież dane w DataGridView "StockView"
            LoadStockData();
        }

        private void UsersManage_Click(object sender, EventArgs e)
        {
            // Otwórz okno "UsersManageForm" jako modalne
            UsersManageForm usersManageForm = new UsersManageForm();
            usersManageForm.ShowDialog();
        }

        private void MainAppForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Sprawdź, czy zamknięcie dotyczy głównego okna aplikacji
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Zamknij wszystkie otwarte okna aplikacji
                Application.Exit();
            }
        }
    }
}
