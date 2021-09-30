namespace DentistAdmin.Forms
{
    partial class ClientForm
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
            this.BackButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.BorderLabel = new System.Windows.Forms.Label();
            this.DentistListbox = new System.Windows.Forms.ListBox();
            this.MonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.PricelistBox = new System.Windows.Forms.ListBox();
            this.MinutesOfEndingBox = new System.Windows.Forms.NumericUpDown();
            this.HoursOfEndingBox = new System.Windows.Forms.NumericUpDown();
            this.MinutesOfBeginningBox = new System.Windows.Forms.NumericUpDown();
            this.HoursOfBeginningBox = new System.Windows.Forms.NumericUpDown();
            this.AddButton = new System.Windows.Forms.Button();
            this.ScheduleBox = new System.Windows.Forms.Button();
            this.FirstShiftLabel = new System.Windows.Forms.Label();
            this.PatronymicBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesOfEndingBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursOfEndingBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesOfBeginningBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursOfBeginningBox)).BeginInit();
            this.SuspendLayout();
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
            this.BackButton.Location = new System.Drawing.Point(1864, 0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(36, 36);
            this.BackButton.TabIndex = 15;
            this.BackButton.TabStop = false;
            this.BackButton.Text = "<";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButtonClick);
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
            this.ExitButton.Location = new System.Drawing.Point(1906, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(36, 36);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.TabStop = false;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButtonClick);
            // 
            // BorderLabel
            // 
            this.BorderLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.BorderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorderLabel.Location = new System.Drawing.Point(0, 0);
            this.BorderLabel.Name = "BorderLabel";
            this.BorderLabel.Size = new System.Drawing.Size(1942, 36);
            this.BorderLabel.TabIndex = 13;
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
            this.DentistListbox.Location = new System.Drawing.Point(10, 39);
            this.DentistListbox.Name = "DentistListbox";
            this.DentistListbox.Size = new System.Drawing.Size(616, 779);
            this.DentistListbox.Sorted = true;
            this.DentistListbox.TabIndex = 16;
            this.DentistListbox.TabStop = false;
            // 
            // MonthCalendar
            // 
            this.MonthCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MonthCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MonthCalendar.Location = new System.Drawing.Point(1720, 318);
            this.MonthCalendar.MaxSelectionCount = 1;
            this.MonthCalendar.Name = "MonthCalendar";
            this.MonthCalendar.TabIndex = 17;
            // 
            // PricelistBox
            // 
            this.PricelistBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PricelistBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.PricelistBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PricelistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PricelistBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.PricelistBox.FormattingEnabled = true;
            this.PricelistBox.ItemHeight = 31;
            this.PricelistBox.Location = new System.Drawing.Point(632, 39);
            this.PricelistBox.Name = "PricelistBox";
            this.PricelistBox.Size = new System.Drawing.Size(1076, 779);
            this.PricelistBox.Sorted = true;
            this.PricelistBox.TabIndex = 18;
            this.PricelistBox.TabStop = false;
            // 
            // MinutesOfEndingBox
            // 
            this.MinutesOfEndingBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinutesOfEndingBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.MinutesOfEndingBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinutesOfEndingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinutesOfEndingBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.MinutesOfEndingBox.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.MinutesOfEndingBox.Location = new System.Drawing.Point(1788, 619);
            this.MinutesOfEndingBox.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.MinutesOfEndingBox.Name = "MinutesOfEndingBox";
            this.MinutesOfEndingBox.Size = new System.Drawing.Size(137, 38);
            this.MinutesOfEndingBox.TabIndex = 23;
            // 
            // HoursOfEndingBox
            // 
            this.HoursOfEndingBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HoursOfEndingBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.HoursOfEndingBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HoursOfEndingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HoursOfEndingBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.HoursOfEndingBox.Location = new System.Drawing.Point(1635, 619);
            this.HoursOfEndingBox.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.HoursOfEndingBox.Name = "HoursOfEndingBox";
            this.HoursOfEndingBox.Size = new System.Drawing.Size(142, 38);
            this.HoursOfEndingBox.TabIndex = 22;
            this.HoursOfEndingBox.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // MinutesOfBeginningBox
            // 
            this.MinutesOfBeginningBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinutesOfBeginningBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.MinutesOfBeginningBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinutesOfBeginningBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinutesOfBeginningBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.MinutesOfBeginningBox.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.MinutesOfBeginningBox.Location = new System.Drawing.Point(1788, 575);
            this.MinutesOfBeginningBox.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.MinutesOfBeginningBox.Name = "MinutesOfBeginningBox";
            this.MinutesOfBeginningBox.Size = new System.Drawing.Size(137, 38);
            this.MinutesOfBeginningBox.TabIndex = 21;
            // 
            // HoursOfBeginningBox
            // 
            this.HoursOfBeginningBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HoursOfBeginningBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.HoursOfBeginningBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HoursOfBeginningBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HoursOfBeginningBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.HoursOfBeginningBox.Location = new System.Drawing.Point(1635, 575);
            this.HoursOfBeginningBox.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.HoursOfBeginningBox.Name = "HoursOfBeginningBox";
            this.HoursOfBeginningBox.Size = new System.Drawing.Size(142, 38);
            this.HoursOfBeginningBox.TabIndex = 20;
            this.HoursOfBeginningBox.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(216)))), ((int)(((byte)(164)))));
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.AddButton.FlatAppearance.BorderSize = 2;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(82)))), ((int)(((byte)(41)))));
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(196)))), ((int)(((byte)(164)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.AddButton.Location = new System.Drawing.Point(1714, 680);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(222, 54);
            this.AddButton.TabIndex = 19;
            this.AddButton.TabStop = false;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // ScheduleBox
            // 
            this.ScheduleBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScheduleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(216)))), ((int)(((byte)(164)))));
            this.ScheduleBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ScheduleBox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.ScheduleBox.FlatAppearance.BorderSize = 2;
            this.ScheduleBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(82)))), ((int)(((byte)(41)))));
            this.ScheduleBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(196)))), ((int)(((byte)(164)))));
            this.ScheduleBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScheduleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScheduleBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.ScheduleBox.Location = new System.Drawing.Point(1714, 740);
            this.ScheduleBox.Name = "ScheduleBox";
            this.ScheduleBox.Size = new System.Drawing.Size(222, 54);
            this.ScheduleBox.TabIndex = 24;
            this.ScheduleBox.TabStop = false;
            this.ScheduleBox.Text = "Расписание";
            this.ScheduleBox.UseVisualStyleBackColor = false;
            this.ScheduleBox.Click += new System.EventHandler(this.ScheduleBoxClick);
            // 
            // FirstShiftLabel
            // 
            this.FirstShiftLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstShiftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstShiftLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.FirstShiftLabel.Location = new System.Drawing.Point(1629, 534);
            this.FirstShiftLabel.Name = "FirstShiftLabel";
            this.FirstShiftLabel.Size = new System.Drawing.Size(296, 38);
            this.FirstShiftLabel.TabIndex = 25;
            this.FirstShiftLabel.Text = "Время";
            // 
            // PatronymicBox
            // 
            this.PatronymicBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PatronymicBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.PatronymicBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatronymicBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.PatronymicBox.Location = new System.Drawing.Point(1714, 185);
            this.PatronymicBox.Multiline = true;
            this.PatronymicBox.Name = "PatronymicBox";
            this.PatronymicBox.Size = new System.Drawing.Size(222, 58);
            this.PatronymicBox.TabIndex = 28;
            this.PatronymicBox.Enter += new System.EventHandler(this.PatronymicBoxEnter);
            this.PatronymicBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatronymicBox_KeyPress);
            this.PatronymicBox.Leave += new System.EventHandler(this.PatronymicBoxLeave);
            // 
            // SurnameBox
            // 
            this.SurnameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.SurnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.SurnameBox.Location = new System.Drawing.Point(1714, 57);
            this.SurnameBox.Multiline = true;
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(222, 58);
            this.SurnameBox.TabIndex = 26;
            this.SurnameBox.Enter += new System.EventHandler(this.SurnameBoxEnter);
            this.SurnameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurnameBox_KeyPress);
            this.SurnameBox.Leave += new System.EventHandler(this.SurnameBoxLeave);
            // 
            // NameBox
            // 
            this.NameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.NameBox.Location = new System.Drawing.Point(1714, 121);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(222, 58);
            this.NameBox.TabIndex = 27;
            this.NameBox.Enter += new System.EventHandler(this.NameBoxEnter);
            this.NameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameBox_KeyPress);
            this.NameBox.Leave += new System.EventHandler(this.NameBoxLeave);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(186)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1942, 855);
            this.Controls.Add(this.PatronymicBox);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.FirstShiftLabel);
            this.Controls.Add(this.ScheduleBox);
            this.Controls.Add(this.MinutesOfEndingBox);
            this.Controls.Add(this.HoursOfEndingBox);
            this.Controls.Add(this.MinutesOfBeginningBox);
            this.Controls.Add(this.HoursOfBeginningBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PricelistBox);
            this.Controls.Add(this.MonthCalendar);
            this.Controls.Add(this.DentistListbox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.BorderLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ClientFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.MinutesOfEndingBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursOfEndingBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesOfBeginningBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursOfBeginningBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label BorderLabel;
        private System.Windows.Forms.ListBox DentistListbox;
        private System.Windows.Forms.MonthCalendar MonthCalendar;
        private System.Windows.Forms.ListBox PricelistBox;
        private System.Windows.Forms.NumericUpDown MinutesOfEndingBox;
        private System.Windows.Forms.NumericUpDown HoursOfEndingBox;
        private System.Windows.Forms.NumericUpDown MinutesOfBeginningBox;
        private System.Windows.Forms.NumericUpDown HoursOfBeginningBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ScheduleBox;
        private System.Windows.Forms.Label FirstShiftLabel;
        private System.Windows.Forms.TextBox PatronymicBox;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.TextBox NameBox;
    }
}