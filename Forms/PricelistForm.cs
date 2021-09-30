using System;
using System.Drawing;
using System.Windows.Forms;
using DentistAdmin.ServiceObjects;

namespace DentistAdmin.Forms
{
    public partial class PricelistForm : Form
    {
        private static Pricelist _pricelist;
        public PricelistForm()
        {
            InitializeComponent();
            PriceBox.Maximum = decimal.MaxValue;
            _pricelist = new Pricelist("Pricelist.bin");
            PricelistBox.DataSource = _pricelist.GetPricelist();
            PricelistBox.DisplayMember = "FullInfo";
            ClearFields();
        }

        private void ClearFields()
        {
            NameBox.ForeColor = Color.Gray;
            NameBox.Text = "Введите название";
            PriceBox.Value = 0;
            FloatingPriceBox.Value = 0;
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
            if (NameBox.Text == "Введите название")
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
                NameBox.Text = "Введите название";
            }
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            if (NameBox.Text == "Введите название")
            {
                MessageBox.Show("Поля не заполнены");
                return;
            }

            DialogResult dialogResult = MessageBox.Show($"Добавить услугу " +
                $"{NameBox.Text} " +
                $"за " +
                $"{PriceBox.Value},{FloatingPriceBox.Value}",
                "Подтверждение", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No)
                return;

            _pricelist.Add(new Service(NameBox.Text, (double)PriceBox.Value + (double)FloatingPriceBox.Value * 0.01));
            _pricelist.Save();
            ClearFields();
        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            if (PricelistBox.SelectedItem == null)
            {
                MessageBox.Show("Услуга не выбрана");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Удалить данные выбранной услуги?", "Подтверждение", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                _pricelist.Delete(PricelistBox.SelectedItem as Service);
                _pricelist.Save();
            }
        }

        private void ChangeButtonClick(object sender, EventArgs e)
        {
            if (PricelistBox.SelectedItem == null)
            {
                MessageBox.Show("Услуга не выбрана");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Принять изменения для выбранного доктора?", "Подтверждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
                return;

            if (NameBox.Text == "Введите название" || NameBox.Text == "")
            {
                MessageBox.Show("Поля не заполнены");
                return;
            }
            _pricelist.Delete(PricelistBox.SelectedItem as Service);
            _pricelist.Add(new Service(NameBox.Text, (double)PriceBox.Value + (double)FloatingPriceBox.Value * 0.01));
            _pricelist.Save();

            ClearFields();
        }

        private void PricelistBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            var service = PricelistBox.SelectedItem as Service;
            if (service == null)
            {
                ClearFields();
                return;
            }
            NameBox.ForeColor = Color.Black;
            NameBox.Text = service.Name;
            PriceBox.Value = (decimal)Math.Round(service.Price);
            FloatingPriceBox.Value = (decimal)(service.Price - Math.Truncate(service.Price)) * 100;
        }

        private void NameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar.ToString() == "\b" || e.KeyChar.ToString() == "\"" || e.KeyChar.ToString() == "-")
                return;
            else
                e.Handled = true;
        }
    }
}
