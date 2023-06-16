using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inwentaryzacja
{
    public partial class MainAppForm : Form
    {
        public MainAppForm()
        {
            InitializeComponent();

            // Przypisanie obsługi zdarzenia FormClosing
            FormClosing += MainAppForm_FormClosing;
        }

        private void MainAppForm_Load(object sender, EventArgs e)
        {
            // Kod do wykonania po załadowaniu okna aplikacji
            AddCommodity.Click += AddCommodity_Click;
            UsersManage.Click += UsersManage_Click;
        }

        private void AddCommodity_Click(object sender, EventArgs e)
        {
            // Otwórz okno "AddCommodityForm" jako dialogowe
            AddCommodityForm addCommodityForm = new AddCommodityForm();
            addCommodityForm.ShowDialog();
        }

        private void UsersManage_Click(object sender, EventArgs e)
        {
            // Otwórz okno "UsersManageForm" jako dialogowe
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
