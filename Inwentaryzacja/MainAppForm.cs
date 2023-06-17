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
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                // Utwórz obiekt DataTable do przechowywania pobranych danych
                DataTable dataTable = new DataTable();

                // Wypełnij obiekt DataTable danymi z bazy danych
                adapter.Fill(dataTable);

                // Przypisz DataTable jako źródło danych dla DataGridView "StockView"
                StockView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas wczytywania danych z bazy danych: " + ex.Message);
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
