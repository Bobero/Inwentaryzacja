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
        }

        private void MainAppForm_Load(object sender, EventArgs e)
        {
            // Kod do wykonania po załadowaniu okna aplikacji
            AddCommodity.Click += AddCommodity_Click;
        }

        private void AddCommodity_Click(object sender, EventArgs e)
        {
            // Otwórz okno "AddCommodityForm" jako dialogowe
            AddCommodityForm addCommodityForm = new AddCommodityForm();
            addCommodityForm.ShowDialog();
        }

        // Dodaj inne metody i logikę specyficzną dla okna głównego aplikacji
    }
}
