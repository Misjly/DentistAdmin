using DentistAdmin.HumanObjects;
using DentistAdmin.ServiceObjects;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DentistAdmin.Forms
{
    public partial class ClientForm : Form
    {
        private ListOfDentists _dentistList { get; set; }
        private static Pricelist _pricelist;
        public ClientForm()
        {
            InitializeComponent();
            _dentistList = new ListOfDentists("Dentists.bin");
            DentistListbox.DataSource = _dentistList.GetDentists();
            DentistListbox.DisplayMember = "FullInfo";

            _pricelist = new Pricelist("Pricelist.bin");
            PricelistBox.DataSource = _pricelist.GetPricelist();
            PricelistBox.DisplayMember = "FullInfo";
            ClearFields();
        }

        private void ClientFormLoad(object sender, EventArgs e)
        {

        }

        private void ClearFields()
        {
            NameBox.ForeColor = Color.Gray;
            NameBox.Text = "Введите имя";
            SurnameBox.ForeColor = Color.Gray;
            SurnameBox.Text = "Введите фамилию";
            PatronymicBox.ForeColor = Color.Gray;
            PatronymicBox.Text = "Введите отчество";
        }



        private bool CheckDate(Dentist dentist, DateTime beginning, DateTime ending)
        {
            if (!(dentist.Timetable.FirstShiftDays.Contains(beginning.Day) || dentist.Timetable.SecondShiftDays.Contains(beginning.Day)))
                return false;

            var clients = dentist.GetListOfClients().GetClients();

            if (dentist.Timetable.FirstShiftDays.Contains(beginning.Day))
            {
                if (!(new TimeSpan(dentist.Timetable.FirstShiftBeginning.Hours, dentist.Timetable.FirstShiftBeginning.Minutes, 0)
                    <= new TimeSpan(beginning.Hour, beginning.Minute, 0)

                    && (new TimeSpan(dentist.Timetable.FirstShiftEnding.Hours, dentist.Timetable.FirstShiftEnding.Minutes, 0)
                    >= new TimeSpan(ending.Hour, ending.Minute, 0))))
                    return false;

                foreach (var client in clients)
                {
                    if ((new TimeSpan(client.StartOfProcedure.Hour, client.StartOfProcedure.Minute, 0)
                        < new TimeSpan(ending.Hour, ending.Minute, 0))
                        &&
                        (new TimeSpan(client.EndOfProcedure.Hour, client.EndOfProcedure.Minute, 0)
                        > new TimeSpan(beginning.Hour, beginning.Minute, 0)))
                        return true;
                }
                return true;
            }


            if (!(new TimeSpan(dentist.Timetable.SecondShiftBeginning.Hours, dentist.Timetable.SecondShiftBeginning.Minutes, 0)
                    <= new TimeSpan(beginning.Hour, beginning.Minute, 0)

                    && (new TimeSpan(dentist.Timetable.SecondShiftEnding.Hours, dentist.Timetable.SecondShiftEnding.Minutes, 0)
                    >= new TimeSpan(ending.Hour, ending.Minute, 0))))
                return false;

            foreach (var client in clients)
            {
                if ((new TimeSpan(client.StartOfProcedure.Hour, client.StartOfProcedure.Minute, 0)
                    < new TimeSpan(ending.Hour, ending.Minute, 0))
                    &&
                    (new TimeSpan(client.EndOfProcedure.Hour, client.EndOfProcedure.Minute, 0)
                    > new TimeSpan(beginning.Hour, beginning.Minute, 0)))
                    return true;
            }

            return true;
        }



        private void BackButtonClick(object sender, EventArgs e)
        {
            Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void ExitButtonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            if (NameBox.Text == "Введите имя" || NameBox.Text == "" ||
                SurnameBox.Text == "Введите фамилию" || SurnameBox.Text == "" ||
                PatronymicBox.Text == "Введите отчество" || PatronymicBox.Text == "")
            {
                MessageBox.Show("Поля не заполнены");
                return;
            }

            

            var dentist = DentistListbox.SelectedItem as Dentist;

            var startDate1 = MonthCalendar.SelectionRange.Start;
            var endDate1 = startDate1;

            var startDate2 = startDate1.AddHours((double)HoursOfBeginningBox.Value);
            var startDate3 = startDate2.AddMinutes((double)MinutesOfBeginningBox.Value);

            var endDate2 = endDate1.AddHours((double)HoursOfEndingBox.Value);
            var endDate3 = endDate2.AddMinutes((double)MinutesOfEndingBox.Value);
            if (!CheckDate(dentist, startDate3, endDate3))
            {
                MessageBox.Show("Неверно назначенное время или несовпадение с расписанием врача");
                return;
            }

            var dentists = _dentistList.GetDentists();
            int index = dentists.IndexOf(dentist);
            var service = PricelistBox.SelectedItem as Service;
            var client = new Client(service, NameBox.Text, SurnameBox.Text, PatronymicBox.Text, startDate3, endDate3);
            dentists[index].AddClient(client);


            DialogResult dialogResult = MessageBox.Show($"{client.FullInfo}",
                "Подтверждение", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No)
                return;


            _dentistList.Save();
        }

        private void SurnameBoxEnter(object sender, EventArgs e)
        {
            if (SurnameBox.Text == "Введите фамилию")
            {
                SurnameBox.ForeColor = Color.Black;
                SurnameBox.Text = "";
            }
        }

        private void NameBoxEnter(object sender, EventArgs e)
        {
            if (NameBox.Text == "Введите имя")
            {
                NameBox.ForeColor = Color.Black;
                NameBox.Text = "";
            }
        }

        private void PatronymicBoxEnter(object sender, EventArgs e)
        {
            if (PatronymicBox.Text == "Введите отчество")
            {
                PatronymicBox.ForeColor = Color.Black;
                PatronymicBox.Text = "";
            }
        }

        private void SurnameBoxLeave(object sender, EventArgs e)
        {
            if (SurnameBox.Text == "")
            {
                SurnameBox.ForeColor = Color.Gray;
                SurnameBox.Text = "Введите фамилию";
            }
        }

        private void NameBoxLeave(object sender, EventArgs e)
        {
            if (NameBox.Text == "")
            {
                NameBox.ForeColor = Color.Gray;
                NameBox.Text = "Введите имя";
            }
        }

        private void PatronymicBoxLeave(object sender, EventArgs e)
        {
            if (PatronymicBox.Text == "")
            {
                PatronymicBox.ForeColor = Color.Gray;
                PatronymicBox.Text = "Введите отчество";
            }
        }

        private void ScheduleBoxClick(object sender, EventArgs e)
        {
            var form = new ScheduleForm(DentistListbox.SelectedItem as Dentist, _dentistList);
            form.Show();
        }

        private void SurnameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar.ToString() == "\b")
                return;
            else
                e.Handled = true;
        }

        private void NameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar.ToString() == "\b")
                return;
            else
                e.Handled = true;
        }

        private void PatronymicBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar.ToString() == "\b")
                return;
            else
                e.Handled = true;
        }
    }
}
