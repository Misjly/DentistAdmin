using DentistAdmin.HumanObjects;
using DentistAdmin.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using DentistAdmin.ServiceObjects;

namespace DentistAdmin
{
    public partial class DentistForm : Form
    {
        private ListOfDentists _dentistList { get; set; }
        public DentistForm()
        {
            InitializeComponent();

            var Specialisations = new List<string> { "Хирург стоматолог", "Детский стоматолог", "Терапевт стоматолог", "Ортопед стоматолог" };
            SpecializationBox.DataSource = Specialisations;

            _dentistList = new ListOfDentists("Dentists.bin");
            DentistListbox.DataSource = _dentistList.GetDentists();
            DentistListbox.DisplayMember = "FullInfo";
            ClearFields();
        }

        private void ClearFields()
        {
            NameBox.ForeColor = Color.Gray;
            NameBox.Text = "Введите имя";
            SurnameBox.ForeColor = Color.Gray;
            SurnameBox.Text = "Введите фамилию";
            PatronymicBox.ForeColor = Color.Gray;
            PatronymicBox.Text = "Введите отчество";
            SpecializationBox.SelectedItem = SpecializationBox.Items[0];
            for (int i = 0; i < DaysBox1.Items.Count; i++)
            {
                DaysBox1.SetItemCheckState(i, CheckState.Unchecked);
                DaysBox2.SetItemCheckState(i, CheckState.Unchecked);
            }
            HoursOfBeginningBox1.Value = 0;
            MinutesOfBeginningBox1.Value = 0;
            HoursOfEndingBox1.Value = 0;
            MinutesOfEndingBox1.Value = 0;

            HoursOfBeginningBox2.Value = 0;
            MinutesOfBeginningBox2.Value = 0;
            HoursOfEndingBox2.Value = 0;
            MinutesOfEndingBox2.Value = 0;
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

            DialogResult dialogResult = MessageBox.Show($"Добавить доктора " +
                $"{SurnameBox.Text} " +
                $"{NameBox.Text} " +
                $"{PatronymicBox.Text} " +
                $"со специальностью " +
                $"{SpecializationBox.SelectedItem.ToString()}?",
                "Подтверждение", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No)
                return;


            List<int> firstShiftDays = DaysBox1.CheckedItems.OfType<object>().Select(x => int.Parse(x.ToString())).ToList();
            List<int> secondShiftDays = DaysBox2.CheckedItems.OfType<object>().Select(x => int.Parse(x.ToString())).ToList();

            TimeSpan firstShitBeginning = new TimeSpan(
                int.Parse(HoursOfBeginningBox1.Value.ToString()),
                int.Parse(MinutesOfBeginningBox1.Value.ToString()), 0);
            TimeSpan firstShitEnding = new TimeSpan(
                int.Parse(HoursOfEndingBox1.Value.ToString()),
                int.Parse(MinutesOfEndingBox1.Value.ToString()), 0);
            TimeSpan secondShitBeginning = new TimeSpan(
                int.Parse(HoursOfBeginningBox2.Value.ToString()),
                int.Parse(MinutesOfBeginningBox2.Value.ToString()), 0);
            TimeSpan secondShitEnding = new TimeSpan(
                int.Parse(HoursOfEndingBox2.Value.ToString()),
                int.Parse(MinutesOfEndingBox2.Value.ToString()), 0);


            _dentistList.AddDentist(NameBox.Text,
                SurnameBox.Text,
                PatronymicBox.Text,
                SpecializationBox.SelectedItem.ToString(),
                new Schedule(firstShiftDays, secondShiftDays, firstShitBeginning, firstShitEnding, secondShitBeginning, secondShitEnding));

            for (int i = 0; i < DaysBox1.Items.Count; i++)
            {
                DaysBox1.SetItemCheckState(i, CheckState.Unchecked);
                DaysBox2.SetItemCheckState(i, CheckState.Unchecked);
            }

            _dentistList.Save();

            ClearFields();

        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Удалить данные выбранного доктора?", "Подтверждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _dentistList.DeleteDentist(DentistListbox.SelectedItem as Dentist);
                _dentistList.Save();
            }
        }

        private void ChangeButtonClick(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Принять изменения для выбранного доктора?", "Подтверждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (NameBox.Text == "Введите имя" || NameBox.Text == "" ||
                    SurnameBox.Text == "Введите фамилию" || SurnameBox.Text == "" ||
                    PatronymicBox.Text == "Введите отчество" || PatronymicBox.Text == "")
                {
                    MessageBox.Show("Поля не заполнены");
                }
                else
                {
                    _dentistList.DeleteDentist(DentistListbox.SelectedItem as Dentist);

                    List<int> firstShiftDays = DaysBox1.CheckedItems.OfType<object>().Select(x => int.Parse(x.ToString())).ToList();
                    List<int> secondShiftDays = DaysBox2.CheckedItems.OfType<object>().Select(x => int.Parse(x.ToString())).ToList();
                    TimeSpan firstShitBeginning = new TimeSpan(
                        int.Parse(HoursOfBeginningBox1.Value.ToString()),
                        int.Parse(MinutesOfBeginningBox1.Value.ToString()), 0);
                    TimeSpan firstShitEnding = new TimeSpan(
                        int.Parse(HoursOfEndingBox1.Value.ToString()),
                        int.Parse(MinutesOfEndingBox1.Value.ToString()), 0);
                    TimeSpan secondShitBeginning = new TimeSpan(
                        int.Parse(HoursOfBeginningBox2.Value.ToString()),
                        int.Parse(MinutesOfBeginningBox2.Value.ToString()), 0);
                    TimeSpan secondShitEnding = new TimeSpan(
                        int.Parse(HoursOfEndingBox2.Value.ToString()),
                        int.Parse(MinutesOfEndingBox2.Value.ToString()), 0);

                    _dentistList.AddDentist(NameBox.Text,
                        SurnameBox.Text,
                        PatronymicBox.Text,
                        SpecializationBox.SelectedItem.ToString(),
                        new Schedule(firstShiftDays, secondShiftDays, firstShitBeginning, firstShitEnding, secondShitBeginning, secondShitEnding));

                    for (int i = 0; i < 31; i++)
                    {
                        DaysBox1.SetItemCheckState(i, CheckState.Unchecked);
                        DaysBox2.SetItemCheckState(i, CheckState.Unchecked);
                    }

                    _dentistList.Save();
                }
                ClearFields();
            }
        }

        private void ExitButtonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void NameBoxEnter(object sender, EventArgs e)
        {
            if (NameBox.Text == "Введите имя")
            {
                NameBox.ForeColor = Color.Black;
                NameBox.Text = "";
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

        private void SurnameBoxEnter(object sender, EventArgs e)
        {
            if (SurnameBox.Text == "Введите фамилию")
            {
                SurnameBox.ForeColor = Color.Black;
                SurnameBox.Text = "";
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

        private void PatronymicBoxEnter(object sender, EventArgs e)
        {
            if (PatronymicBox.Text == "Введите отчество")
            {
                PatronymicBox.ForeColor = Color.Black;
                PatronymicBox.Text = "";
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

        private void DentistListboxSelectedValueChanged(object sender, EventArgs e)
        {
            Dentist dentist = DentistListbox.SelectedItem as Dentist;

            if (dentist == null)
            {
                ClearFields();
                return;
            }

            SurnameBox.ForeColor = Color.Black;
            NameBox.ForeColor = Color.Black;
            PatronymicBox.ForeColor = Color.Black;

            SurnameBox.Text = dentist.Surname;
            NameBox.Text = dentist.Name;
            PatronymicBox.Text = dentist.Patronymic;
            SpecializationBox.SelectedItem = dentist.Specialization;

            for (int i = 0; i < 31; i++)
            {
                DaysBox1.SetItemCheckState(i, dentist.Timetable.FirstShiftDays.Contains(i + 1) ? CheckState.Checked : CheckState.Unchecked);
                DaysBox2.SetItemCheckState(i, dentist.Timetable.SecondShiftDays.Contains(i + 1) ? CheckState.Unchecked : CheckState.Checked);
            }

            HoursOfBeginningBox1.Value = dentist.Timetable.FirstShiftBeginning.Hours;
            MinutesOfBeginningBox1.Value = dentist.Timetable.FirstShiftBeginning.Minutes;
            HoursOfEndingBox1.Value = dentist.Timetable.FirstShiftEnding.Hours;
            MinutesOfEndingBox1.Value = dentist.Timetable.FirstShiftEnding.Minutes;

            HoursOfBeginningBox2.Value = dentist.Timetable.SecondShiftBeginning.Hours;
            MinutesOfBeginningBox2.Value = dentist.Timetable.SecondShiftBeginning.Minutes;
            HoursOfEndingBox2.Value = dentist.Timetable.SecondShiftEnding.Hours;
            MinutesOfEndingBox2.Value = dentist.Timetable.SecondShiftEnding.Minutes;
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
