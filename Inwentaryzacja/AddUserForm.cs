using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inwentaryzacja
{
    public partial class AddUserForm : Form
    {
        private SqlConnection connection;

        public AddUserForm()
        {
            InitializeComponent();
            connection = new SqlConnection("Server=localhost;Database=Inwentaryzacja;User Id=User;Password=!QAZ2wsx;");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;
            int permissions = int.Parse(txtPermissions.Text);

            try
            {
                connection.Open();

                string query = "INSERT INTO Users (Login, Passwd, Permissions, CreationDate) VALUES (@Login, @Password, @Permissions, GETDATE())";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Login", login);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Permissions", permissions);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Nowy użytkownik został dodany.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nie udało się dodać nowego użytkownika.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas dodawania użytkownika: " + ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0'; // Pokaż hasło
            }
            else
            {
                txtPassword.PasswordChar = '*'; // Ukryj hasło
            }
        }
    }
}
