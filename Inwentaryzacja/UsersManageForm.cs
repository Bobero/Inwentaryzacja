using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inwentaryzacja
{
    public partial class UsersManageForm : Form
    {
        private SqlConnection connection;

        public UsersManageForm()
        {
            InitializeComponent();
            connection = new SqlConnection("Server=localhost;Database=Inwentaryzacja;User Id=User;Password=!QAZ2wsx;");
        }

        private void UsersManageForm_Load(object sender, EventArgs e)
        {
            //AddUserButton.Click += AddUserButton_Click;
            LoadUserData();
            AddEditDeleteButtons();
            AddUserBtn.Click += AddUserBtn_Click;
        }

        //private void AddUserButton_Click(object sender, EventArgs e)
        //{
        //    AddUserForm addUserForm = new AddUserForm();
        //    addUserForm.ShowDialog();
        //    LoadUserData();
        //}

        private void LoadUserData()
        {
            try
            {
                connection.Open();

                string query = "SELECT * FROM Users";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    UsersView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas wczytywania danych z bazy danych: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void AddEditDeleteButtons()
        {
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "EditButtonColumn";
            editButtonColumn.HeaderText = "";
            editButtonColumn.Text = "Edytuj";
            editButtonColumn.UseColumnTextForButtonValue = true;
            UsersView.Columns.Add(editButtonColumn);
            UsersView.CellClick += UsersView_CellClick;

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "DeleteButtonColumn";
            deleteButtonColumn.HeaderText = "";
            deleteButtonColumn.Text = "Usuń";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            UsersView.Columns.Add(deleteButtonColumn);
        }

        private void UsersView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == UsersView.Columns["EditButtonColumn"].Index)
            {
                int userId = Convert.ToInt32(UsersView.Rows[e.RowIndex].Cells["Id"].Value);
                string userName = UsersView.Rows[e.RowIndex].Cells["Login"].Value.ToString();
                string userPassword = UsersView.Rows[e.RowIndex].Cells["Passwd"].Value.ToString();
                int userPermissions = Convert.ToInt32(UsersView.Rows[e.RowIndex].Cells["Permissions"].Value.ToString());

                EditUserForm editUserForm = new EditUserForm(userId, userName, userPassword, userPermissions);
                editUserForm.ShowDialog();
                LoadUserData();
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == UsersView.Columns["DeleteButtonColumn"].Index)
            {
                DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć tego użytkownika?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int userId = Convert.ToInt32(UsersView.Rows[e.RowIndex].Cells["Id"].Value);
                    DeleteUser(userId);
                }
            }
        }

        private void DeleteUser(int userId)
        {
            try
            {
                connection.Open();

                string deleteQuery = "DELETE FROM Users WHERE Id = @Id";
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                deleteCommand.Parameters.AddWithValue("@Id", userId);
                deleteCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas usuwania użytkownika: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();

                LoadUserData(); // Przeniesiono do bloku finally, aby odświeżyć dane niezależnie od wyniku operacji usuwania
            }
        }
        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.ShowDialog();
            LoadUserData();
        }


    }
}
