namespace DentistAdmin
{
    partial class DentistForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.BorderLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.SpecializationBox = new System.Windows.Forms.ComboBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.DentistListbox = new System.Windows.Forms.ListBox();
            this.PatronymicBox = new System.Windows.Forms.TextBox();
            this.DaysBox1 = new System.Windows.Forms.CheckedListBox();
            this.HoursOfBeginningBox1 = new System.Windows.Forms.NumericUpDown();
            this.MinutesOfBeginningBox1 = new System.Windows.Forms.NumericUpDown();
            this.HoursOfEndingBox1 = new System.Windows.Forms.NumericUpDown();
            this.MinutesOfEndingBox1 = new System.Windows.Forms.NumericUpDown();
            this.MinutesOfEndingBox2 = new System.Windows.Forms.NumericUpDown();
            this.HoursOfEndingBox2 = new System.Windows.Forms.NumericUpDown();
            this.MinutesOfBeginningBox2 = new System.Windows.Forms.NumericUpDown();
            this.HoursOfBeginningBox2 = new System.Windows.Forms.NumericUpDown();
            this.FirstShiftLabel = new System.Windows.Forms.Label();
            this.SecondShiftLabel = new System.Windows.Forms.Label();
            this.DaysBox2 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.HoursOfBeginningBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesOfBeginningBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursOfEndingBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesOfEndingBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesOfEndingBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursOfEndingBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesOfBeginningBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursOfBeginningBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(216)))), ((int)(((byte)(164)))));
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.AddButton.FlatAppearance.BorderSize = 2;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(82)))), ((int)(((byte)(41)))));
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(196)))), ((int)(((byte)(164)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.AddButton.Location = new System.Drawing.Point(1175, 646);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(148, 54);
            this.AddButton.TabIndex = 0;
            this.AddButton.TabStop = false;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(216)))), ((int)(((byte)(164)))));
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.DeleteButton.FlatAppearance.BorderSize = 2;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(82)))), ((int)(((byte)(41)))));
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(196)))), ((int)(((byte)(164)))));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.DeleteButton.Location = new System.Drawing.Point(1175, 706);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(148, 54);
            this.DeleteButton.TabIndex = 0;
            this.DeleteButton.TabStop = false;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(216)))), ((int)(((byte)(164)))));
            this.ChangeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.ChangeButton.FlatAppearance.BorderSize = 2;
            this.ChangeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(82)))), ((int)(((byte)(41)))));
            this.ChangeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(196)))), ((int)(((byte)(164)))));
            this.ChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.ChangeButton.Location = new System.Drawing.Point(1175, 766);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(148, 54);
            this.ChangeButton.TabIndex = 0;
            this.ChangeButton.TabStop = false;
            this.ChangeButton.Text = "Изменить";
            this.ChangeButton.UseVisualStyleBackColor = false;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButtonClick);
            // 
            // BorderLabel
            // 
            this.BorderLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.BorderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorderLabel.Location = new System.Drawing.Point(0, 0);
            this.BorderLabel.Name = "BorderLabel";
            this.BorderLabel.Size = new System.Drawing.Size(1335, 36);
            this.BorderLabel.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(82)))), ((int)(((byte)(41)))));
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.ExitButton.Location = new System.Drawing.Point(1299, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(36, 36);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.TabStop = false;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButtonClick);
            // 
            // NameBox
            // 
            this.NameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.NameBox.Location = new System.Drawing.Point(745, 106);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(590, 58);
            this.NameBox.TabIndex = 2;
            this.NameBox.Enter += new System.EventHandler(this.NameBoxEnter);
            this.NameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameBox_KeyPress);
            this.NameBox.Leave += new System.EventHandler(this.NameBoxLeave);
            // 
            // SurnameBox
            // 
            this.SurnameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.SurnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.SurnameBox.Location = new System.Drawing.Point(745, 42);
            this.SurnameBox.Multiline = true;
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(590, 58);
            this.SurnameBox.TabIndex = 1;
            this.SurnameBox.Enter += new System.EventHandler(this.SurnameBoxEnter);
            this.SurnameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurnameBox_KeyPress);
            this.SurnameBox.Leave += new System.EventHandler(this.SurnameBoxLeave);
            // 
            // SpecializationBox
            // 
            this.SpecializationBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpecializationBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.SpecializationBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SpecializationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpecializationBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.SpecializationBox.FormattingEnabled = true;
            this.SpecializationBox.Location = new System.Drawing.Point(745, 234);
            this.SpecializationBox.Name = "SpecializationBox";
            this.SpecializationBox.Size = new System.Drawing.Size(590, 39);
            this.SpecializationBox.TabIndex = 4;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(82)))), ((int)(((byte)(41)))));
            this.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.BackButton.Location = new System.Drawing.Point(1257, 0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(36, 36);
            this.BackButton.TabIndex = 9;
            this.BackButton.TabStop = false;
            this.BackButton.Text = "<";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // DentistListbox
            // 
            this.DentistListbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DentistListbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.DentistListbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DentistListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DentistListbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.DentistListbox.FormattingEnabled = true;
            this.DentistListbox.ItemHeight = 31;
            this.DentistListbox.Location = new System.Drawing.Point(12, 73);
            this.DentistListbox.Name = "DentistListbox";
            this.DentistListbox.Size = new System.Drawing.Size(683, 717);
            this.DentistListbox.Sorted = true;
            this.DentistListbox.TabIndex = 0;
            this.DentistListbox.TabStop = false;
            this.DentistListbox.SelectedValueChanged += new System.EventHandler(this.DentistListboxSelectedValueChanged);
            // 
            // PatronymicBox
            // 
            this.PatronymicBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PatronymicBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.PatronymicBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatronymicBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.PatronymicBox.Location = new System.Drawing.Point(745, 170);
            this.PatronymicBox.Multiline = true;
            this.PatronymicBox.Name = "PatronymicBox";
            this.PatronymicBox.Size = new System.Drawing.Size(590, 58);
            this.PatronymicBox.TabIndex = 3;
            this.PatronymicBox.Enter += new System.EventHandler(this.PatronymicBoxEnter);
            this.PatronymicBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatronymicBox_KeyPress);
            this.PatronymicBox.Leave += new System.EventHandler(this.PatronymicBoxLeave);
            // 
            // DaysBox1
            // 
            this.DaysBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DaysBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.DaysBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DaysBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DaysBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.DaysBox1.FormattingEnabled = true;
            this.DaysBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.DaysBox1.Location = new System.Drawing.Point(745, 334);
            this.DaysBox1.MultiColumn = true;
            this.DaysBox1.Name = "DaysBox1";
            this.DaysBox1.Size = new System.Drawing.Size(590, 129);
            this.DaysBox1.TabIndex = 5;
            // 
            // HoursOfBeginningBox1
            // 
            this.HoursOfBeginningBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.HoursOfBeginningBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HoursOfBeginningBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HoursOfBeginningBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.HoursOfBeginningBox1.Location = new System.Drawing.Point(745, 646);
            this.HoursOfBeginningBox1.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.HoursOfBeginningBox1.Name = "HoursOfBeginningBox1";
            this.HoursOfBeginningBox1.Size = new System.Drawing.Size(203, 38);
            this.HoursOfBeginningBox1.TabIndex = 7;
            this.HoursOfBeginningBox1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // MinutesOfBeginningBox1
            // 
            this.MinutesOfBeginningBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.MinutesOfBeginningBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinutesOfBeginningBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinutesOfBeginningBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.MinutesOfBeginningBox1.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.MinutesOfBeginningBox1.Location = new System.Drawing.Point(954, 646);
            this.MinutesOfBeginningBox1.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.MinutesOfBeginningBox1.Name = "MinutesOfBeginningBox1";
            this.MinutesOfBeginningBox1.Size = new System.Drawing.Size(198, 38);
            this.MinutesOfBeginningBox1.TabIndex = 8;
            // 
            // HoursOfEndingBox1
            // 
            this.HoursOfEndingBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.HoursOfEndingBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HoursOfEndingBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HoursOfEndingBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.HoursOfEndingBox1.Location = new System.Drawing.Point(745, 690);
            this.HoursOfEndingBox1.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.HoursOfEndingBox1.Name = "HoursOfEndingBox1";
            this.HoursOfEndingBox1.Size = new System.Drawing.Size(203, 38);
            this.HoursOfEndingBox1.TabIndex = 9;
            this.HoursOfEndingBox1.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // MinutesOfEndingBox1
            // 
            this.MinutesOfEndingBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.MinutesOfEndingBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinutesOfEndingBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinutesOfEndingBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.MinutesOfEndingBox1.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.MinutesOfEndingBox1.Location = new System.Drawing.Point(954, 690);
            this.MinutesOfEndingBox1.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.MinutesOfEndingBox1.Name = "MinutesOfEndingBox1";
            this.MinutesOfEndingBox1.Size = new System.Drawing.Size(198, 38);
            this.MinutesOfEndingBox1.TabIndex = 10;
            // 
            // MinutesOfEndingBox2
            // 
            this.MinutesOfEndingBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.MinutesOfEndingBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinutesOfEndingBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinutesOfEndingBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.MinutesOfEndingBox2.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.MinutesOfEndingBox2.Location = new System.Drawing.Point(954, 796);
            this.MinutesOfEndingBox2.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.MinutesOfEndingBox2.Name = "MinutesOfEndingBox2";
            this.MinutesOfEndingBox2.Size = new System.Drawing.Size(198, 38);
            this.MinutesOfEndingBox2.TabIndex = 14;
            // 
            // HoursOfEndingBox2
            // 
            this.HoursOfEndingBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.HoursOfEndingBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HoursOfEndingBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HoursOfEndingBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.HoursOfEndingBox2.Location = new System.Drawing.Point(745, 796);
            this.HoursOfEndingBox2.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.HoursOfEndingBox2.Name = "HoursOfEndingBox2";
            this.HoursOfEndingBox2.Size = new System.Drawing.Size(203, 38);
            this.HoursOfEndingBox2.TabIndex = 13;
            this.HoursOfEndingBox2.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
            // 
            // MinutesOfBeginningBox2
            // 
            this.MinutesOfBeginningBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.MinutesOfBeginningBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinutesOfBeginningBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinutesOfBeginningBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.MinutesOfBeginningBox2.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.MinutesOfBeginningBox2.Location = new System.Drawing.Point(954, 752);
            this.MinutesOfBeginningBox2.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.MinutesOfBeginningBox2.Name = "MinutesOfBeginningBox2";
            this.MinutesOfBeginningBox2.Size = new System.Drawing.Size(198, 38);
            this.MinutesOfBeginningBox2.TabIndex = 12;
            // 
            // HoursOfBeginningBox2
            // 
            this.HoursOfBeginningBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.HoursOfBeginningBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HoursOfBeginningBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HoursOfBeginningBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.HoursOfBeginningBox2.Location = new System.Drawing.Point(745, 752);
            this.HoursOfBeginningBox2.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.HoursOfBeginningBox2.Name = "HoursOfBeginningBox2";
            this.HoursOfBeginningBox2.Size = new System.Drawing.Size(203, 38);
            this.HoursOfBeginningBox2.TabIndex = 11;
            this.HoursOfBeginningBox2.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // FirstShiftLabel
            // 
            this.FirstShiftLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstShiftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstShiftLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.FirstShiftLabel.Location = new System.Drawing.Point(745, 293);
            this.FirstShiftLabel.Name = "FirstShiftLabel";
            this.FirstShiftLabel.Size = new System.Drawing.Size(590, 38);
            this.FirstShiftLabel.TabIndex = 0;
            this.FirstShiftLabel.Text = "Дни с первой сменой";
            // 
            // SecondShiftLabel
            // 
            this.SecondShiftLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecondShiftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondShiftLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.SecondShiftLabel.Location = new System.Drawing.Point(745, 466);
            this.SecondShiftLabel.Name = "SecondShiftLabel";
            this.SecondShiftLabel.Size = new System.Drawing.Size(590, 38);
            this.SecondShiftLabel.TabIndex = 0;
            this.SecondShiftLabel.Text = "Дни со второй сменой";
            // 
            // DaysBox2
            // 
            this.DaysBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DaysBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.DaysBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DaysBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DaysBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.DaysBox2.FormattingEnabled = true;
            this.DaysBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.DaysBox2.Location = new System.Drawing.Point(745, 511);
            this.DaysBox2.MultiColumn = true;
            this.DaysBox2.Name = "DaysBox2";
            this.DaysBox2.Size = new System.Drawing.Size(590, 129);
            this.DaysBox2.TabIndex = 6;
            // 
            // DentistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(186)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1335, 912);
            this.Controls.Add(this.DaysBox2);
            this.Controls.Add(this.SecondShiftLabel);
            this.Controls.Add(this.FirstShiftLabel);
            this.Controls.Add(this.MinutesOfEndingBox2);
            this.Controls.Add(this.HoursOfEndingBox2);
            this.Controls.Add(this.MinutesOfBeginningBox2);
            this.Controls.Add(this.HoursOfBeginningBox2);
            this.Controls.Add(this.MinutesOfEndingBox1);
            this.Controls.Add(this.HoursOfEndingBox1);
            this.Controls.Add(this.MinutesOfBeginningBox1);
            this.Controls.Add(this.HoursOfBeginningBox1);
            this.Controls.Add(this.DaysBox1);
            this.Controls.Add(this.PatronymicBox);
            this.Controls.Add(this.DentistListbox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SpecializationBox);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.BorderLabel);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "DentistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.HoursOfBeginningBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesOfBeginningBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursOfEndingBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesOfEndingBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesOfEndingBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursOfEndingBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesOfBeginningBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursOfBeginningBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Label BorderLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.ComboBox SpecializationBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ListBox DentistListbox;
        private System.Windows.Forms.TextBox PatronymicBox;
        private System.Windows.Forms.CheckedListBox DaysBox1;
        private System.Windows.Forms.NumericUpDown HoursOfBeginningBox1;
        private System.Windows.Forms.NumericUpDown MinutesOfBeginningBox1;
        private System.Windows.Forms.NumericUpDown HoursOfEndingBox1;
        private System.Windows.Forms.NumericUpDown MinutesOfEndingBox1;
        private System.Windows.Forms.NumericUpDown MinutesOfEndingBox2;
        private System.Windows.Forms.NumericUpDown HoursOfEndingBox2;
        private System.Windows.Forms.NumericUpDown MinutesOfBeginningBox2;
        private System.Windows.Forms.NumericUpDown HoursOfBeginningBox2;
        private System.Windows.Forms.Label FirstShiftLabel;
        private System.Windows.Forms.Label SecondShiftLabel;
        private System.Windows.Forms.CheckedListBox DaysBox2;
    }
}

