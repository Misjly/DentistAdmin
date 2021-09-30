namespace DentistAdmin.Forms
{
    partial class MainForm
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
            this.AppointmentButton = new System.Windows.Forms.Button();
            this.ServiceButton = new System.Windows.Forms.Button();
            this.DentistsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AppointmentButton
            // 
            this.AppointmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AppointmentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(216)))), ((int)(((byte)(164)))));
            this.AppointmentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AppointmentButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.AppointmentButton.FlatAppearance.BorderSize = 2;
            this.AppointmentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(82)))), ((int)(((byte)(41)))));
            this.AppointmentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(196)))), ((int)(((byte)(164)))));
            this.AppointmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AppointmentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.AppointmentButton.Location = new System.Drawing.Point(409, 205);
            this.AppointmentButton.Name = "AppointmentButton";
            this.AppointmentButton.Size = new System.Drawing.Size(286, 64);
            this.AppointmentButton.TabIndex = 1;
            this.AppointmentButton.Text = "Записать на приём";
            this.AppointmentButton.UseVisualStyleBackColor = false;
            this.AppointmentButton.Click += new System.EventHandler(this.AppointmentButtonClick);
            // 
            // ServiceButton
            // 
            this.ServiceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ServiceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(216)))), ((int)(((byte)(164)))));
            this.ServiceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ServiceButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.ServiceButton.FlatAppearance.BorderSize = 2;
            this.ServiceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(82)))), ((int)(((byte)(41)))));
            this.ServiceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(196)))), ((int)(((byte)(164)))));
            this.ServiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ServiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServiceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.ServiceButton.Location = new System.Drawing.Point(409, 275);
            this.ServiceButton.Name = "ServiceButton";
            this.ServiceButton.Size = new System.Drawing.Size(286, 64);
            this.ServiceButton.TabIndex = 2;
            this.ServiceButton.Text = "Список услуг";
            this.ServiceButton.UseVisualStyleBackColor = false;
            this.ServiceButton.Click += new System.EventHandler(this.ServiceButtonClick);
            // 
            // DentistsButton
            // 
            this.DentistsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DentistsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(216)))), ((int)(((byte)(164)))));
            this.DentistsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DentistsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.DentistsButton.FlatAppearance.BorderSize = 2;
            this.DentistsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(82)))), ((int)(((byte)(41)))));
            this.DentistsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(196)))), ((int)(((byte)(164)))));
            this.DentistsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DentistsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DentistsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.DentistsButton.Location = new System.Drawing.Point(409, 345);
            this.DentistsButton.Name = "DentistsButton";
            this.DentistsButton.Size = new System.Drawing.Size(286, 64);
            this.DentistsButton.TabIndex = 3;
            this.DentistsButton.Text = "Доктора";
            this.DentistsButton.UseVisualStyleBackColor = false;
            this.DentistsButton.Click += new System.EventHandler(this.DentistsButtonClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1075, 36);
            this.label1.TabIndex = 4;
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
            this.ExitButton.Location = new System.Drawing.Point(1039, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(36, 36);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.TabStop = false;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(186)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1075, 677);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DentistsButton);
            this.Controls.Add(this.ServiceButton);
            this.Controls.Add(this.AppointmentButton);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AppointmentButton;
        private System.Windows.Forms.Button ServiceButton;
        private System.Windows.Forms.Button DentistsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
    }
}