using System;
using System.Windows.Forms;

namespace DentistAdmin.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {

        }

        private void AppointmentButtonClick(object sender, EventArgs e)
        {
            Hide();
            var clientForm = new ClientForm();
            clientForm.Show();
        }

        private void ServiceButtonClick(object sender, EventArgs e)
        {
            Hide();
            var pricelistForm = new PricelistForm();
            pricelistForm.Show();
        }

        private void DentistsButtonClick(object sender, EventArgs e)
        {
            Hide();
            var dentistForm = new DentistForm();
            dentistForm.Show();
        }

        private void ExitButtonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
