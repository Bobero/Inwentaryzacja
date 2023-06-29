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
    public partial class EditUserForm : Form
    {
        private SqlConnection connection;
        private int userId;

        public EditUserForm(int userId, string login, string password, int permissions)
        {
            InitializeComponent();
            connection = new SqlConnection("Server=localhost;Database=Inwentaryzacja;User Id=User;Password=!QAZ2wsx;");
            this.userId = userId;
            txtLogin.Text = login;
            txtPassword.Text = password;
            txtPermissions.Text = permissions.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;
            int permissions = int.Parse(txtPermissions.Text);

            try
            {
                connection.Open();

                string query = "UPDATE Users SET Login = @Login, Passwd = @Password, Permissions = @Permissions WHERE Id = @UserId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Login", login);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Permissions", permissions);
                command.Parameters.AddWithValue("@UserId", userId);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Dane użytkownika zostały zaktualizowane.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nie udało się zaktualizować danych użytkownika.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas aktualizowania danych w bazie danych: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
