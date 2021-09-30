using DentistAdmin.HumanObjects;
using System;
using System.Windows.Forms;

namespace DentistAdmin.Forms
{
    public partial class ScheduleForm : Form
    {
        private Dentist _dentist { get; set; }
        private readonly ListOfDentists _dentists;
        public ScheduleForm(Dentist dentist, ListOfDentists dentists)
        {
            InitializeComponent();
            _dentist = dentist;
            _dentists = dentists;
            if (_dentist.GetListOfClients() != null)
                ClientListbox.DataSource = _dentist.GetListOfClients().GetClients();
            ClientListbox.DisplayMember = "FullInfo";
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {

        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            Close();
            var form = new ClientForm();
            form.Show();
        }

        private void ExitButtonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Удалить данные выбранного пациента?", "Подтверждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _dentist.DeleteClient(ClientListbox.SelectedItem as Client);
                _dentists.Save();
            }
        }
    }
}
