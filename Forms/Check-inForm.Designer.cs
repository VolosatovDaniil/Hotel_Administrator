
using System;

namespace Hotel_Administrator.Forms
{
    partial class Check_inForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Check_inForm));
            this.CheckInLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameText = new System.Windows.Forms.Label();
            this.FirstNameText = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.PassportText = new System.Windows.Forms.Label();
            this.PassportTextBox = new System.Windows.Forms.TextBox();
            this.RoomNumberText = new System.Windows.Forms.Label();
            this.RoomNumberBox = new System.Windows.Forms.TextBox();
            this.CheckInDateText = new System.Windows.Forms.Label();
            this.CheckInDatePicker = new System.Windows.Forms.DateTimePicker();
            this.CheckOutDateText = new System.Windows.Forms.Label();
            this.CheckOutDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ConfirmCheckInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckInLabel
            // 
            this.CheckInLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CheckInLabel.AutoSize = true;
            this.CheckInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckInLabel.Location = new System.Drawing.Point(106, 9);
            this.CheckInLabel.Name = "CheckInLabel";
            this.CheckInLabel.Size = new System.Drawing.Size(322, 42);
            this.CheckInLabel.TabIndex = 0;
            this.CheckInLabel.Text = "Заселення гостя";
            this.CheckInLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckInLabel.Click += new System.EventHandler(this.CheckInLabel_Click);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameTextBox.Location = new System.Drawing.Point(181, 81);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(280, 26);
            this.LastNameTextBox.TabIndex = 1;
            this.LastNameTextBox.TextChanged += new System.EventHandler(this.LastNameTextBox_TextChanged);
            // 
            // LastNameText
            // 
            this.LastNameText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LastNameText.AutoSize = true;
            this.LastNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameText.Location = new System.Drawing.Point(64, 81);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(99, 24);
            this.LastNameText.TabIndex = 2;
            this.LastNameText.Text = "Прізвище:";
            this.LastNameText.Click += new System.EventHandler(this.label1_Click);
            // 
            // FirstNameText
            // 
            this.FirstNameText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FirstNameText.AutoSize = true;
            this.FirstNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameText.Location = new System.Drawing.Point(63, 137);
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.Size = new System.Drawing.Size(46, 24);
            this.FirstNameText.TabIndex = 4;
            this.FirstNameText.Text = "Ім\'я:";
            this.FirstNameText.Click += new System.EventHandler(this.FirstNameText_Click);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameTextBox.Location = new System.Drawing.Point(181, 137);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(280, 26);
            this.FirstNameTextBox.TabIndex = 3;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // PassportText
            // 
            this.PassportText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PassportText.AutoSize = true;
            this.PassportText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassportText.Location = new System.Drawing.Point(63, 192);
            this.PassportText.Name = "PassportText";
            this.PassportText.Size = new System.Drawing.Size(91, 24);
            this.PassportText.TabIndex = 6;
            this.PassportText.Text = "Паспорт:";
            this.PassportText.Click += new System.EventHandler(this.PassportText_Click);
            // 
            // PassportTextBox
            // 
            this.PassportTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PassportTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassportTextBox.Location = new System.Drawing.Point(181, 192);
            this.PassportTextBox.Name = "PassportTextBox";
            this.PassportTextBox.Size = new System.Drawing.Size(280, 26);
            this.PassportTextBox.TabIndex = 5;
            this.PassportTextBox.TextChanged += new System.EventHandler(this.PassportTextBox_TextChanged);
            // 
            // RoomNumberText
            // 
            this.RoomNumberText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RoomNumberText.AutoSize = true;
            this.RoomNumberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomNumberText.Location = new System.Drawing.Point(63, 247);
            this.RoomNumberText.Name = "RoomNumberText";
            this.RoomNumberText.Size = new System.Drawing.Size(74, 24);
            this.RoomNumberText.TabIndex = 8;
            this.RoomNumberText.Text = "Номер:";
            this.RoomNumberText.Click += new System.EventHandler(this.RoomNumberText_Click);
            // 
            // RoomNumberBox
            // 
            this.RoomNumberBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RoomNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomNumberBox.Location = new System.Drawing.Point(181, 247);
            this.RoomNumberBox.Name = "RoomNumberBox";
            this.RoomNumberBox.Size = new System.Drawing.Size(280, 26);
            this.RoomNumberBox.TabIndex = 7;
            this.RoomNumberBox.TextChanged += new System.EventHandler(this.RoomNumberBox_TextChanged);
            // 
            // CheckInDateText
            // 
            this.CheckInDateText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CheckInDateText.AutoSize = true;
            this.CheckInDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckInDateText.Location = new System.Drawing.Point(63, 302);
            this.CheckInDateText.Name = "CheckInDateText";
            this.CheckInDateText.Size = new System.Drawing.Size(112, 24);
            this.CheckInDateText.TabIndex = 10;
            this.CheckInDateText.Text = "Заселення:";
            this.CheckInDateText.Click += new System.EventHandler(this.CheckInDateText_Click);
            // 
            // CheckInDatePicker
            // 
            this.CheckInDatePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CheckInDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckInDatePicker.Location = new System.Drawing.Point(181, 302);
            this.CheckInDatePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.CheckInDatePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.CheckInDatePicker.Name = "CheckInDatePicker";
            this.CheckInDatePicker.Size = new System.Drawing.Size(280, 26);
            this.CheckInDatePicker.TabIndex = 9;
            this.CheckInDatePicker.Value = new System.DateTime(2025, 4, 1, 0, 0, 0, 0);
            this.CheckInDatePicker.TextChanged += new System.EventHandler(this.CheckInDatePicker_TextChanged);
            // 
            // CheckOutDateText
            // 
            this.CheckOutDateText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CheckOutDateText.AutoSize = true;
            this.CheckOutDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckOutDateText.Location = new System.Drawing.Point(63, 357);
            this.CheckOutDateText.Name = "CheckOutDateText";
            this.CheckOutDateText.Size = new System.Drawing.Size(112, 24);
            this.CheckOutDateText.TabIndex = 12;
            this.CheckOutDateText.Text = "Виселення:";
            this.CheckOutDateText.Click += new System.EventHandler(this.CheckOutDateText_Click);
            // 
            // CheckOutDatePicker
            // 
            this.CheckOutDatePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CheckOutDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckOutDatePicker.Location = new System.Drawing.Point(181, 357);
            this.CheckOutDatePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.CheckOutDatePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.CheckOutDatePicker.Name = "CheckOutDatePicker";
            this.CheckOutDatePicker.Size = new System.Drawing.Size(280, 26);
            this.CheckOutDatePicker.TabIndex = 11;
            this.CheckOutDatePicker.Value = new System.DateTime(2025, 5, 1, 0, 0, 0, 0);
            this.CheckOutDatePicker.TextChanged += new System.EventHandler(this.CheckOutDatePicker_TextChanged);
            // 
            // ConfirmCheckInButton
            // 
            this.ConfirmCheckInButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ConfirmCheckInButton.BackColor = System.Drawing.SystemColors.Control;
            this.ConfirmCheckInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmCheckInButton.Location = new System.Drawing.Point(133, 419);
            this.ConfirmCheckInButton.Name = "ConfirmCheckInButton";
            this.ConfirmCheckInButton.Size = new System.Drawing.Size(270, 40);
            this.ConfirmCheckInButton.TabIndex = 13;
            this.ConfirmCheckInButton.Text = "Підтвердити заселення";
            this.ConfirmCheckInButton.UseVisualStyleBackColor = false;
            this.ConfirmCheckInButton.Click += new System.EventHandler(this.ConfirmCheckInButton_Click);
            // 
            // Check_inForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.ConfirmCheckInButton);
            this.Controls.Add(this.CheckOutDateText);
            this.Controls.Add(this.CheckOutDatePicker);
            this.Controls.Add(this.CheckInDateText);
            this.Controls.Add(this.CheckInDatePicker);
            this.Controls.Add(this.RoomNumberText);
            this.Controls.Add(this.RoomNumberBox);
            this.Controls.Add(this.PassportText);
            this.Controls.Add(this.PassportTextBox);
            this.Controls.Add(this.FirstNameText);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.CheckInLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Check_inForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Administrator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CheckOutDatePicker_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CheckOutDateText_Click(object sender, EventArgs e)
        {
            
        }

        private void CheckInDatePicker_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CheckInDateText_Click(object sender, EventArgs e)
        {
            
        }

        private void RoomNumberBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void RoomNumberText_Click(object sender, EventArgs e)
        {
            
        }

        private void PassportTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PassportText_Click(object sender, EventArgs e)
        {
            
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FirstNameText_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Label CheckInLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label LastNameText;
        private System.Windows.Forms.Label FirstNameText;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label PassportText;
        private System.Windows.Forms.TextBox PassportTextBox;
        private System.Windows.Forms.Label RoomNumberText;
        private System.Windows.Forms.TextBox RoomNumberBox;
        private System.Windows.Forms.Label CheckInDateText;
        private System.Windows.Forms.DateTimePicker CheckInDatePicker;
        private System.Windows.Forms.Label CheckOutDateText;
        private System.Windows.Forms.DateTimePicker CheckOutDatePicker;
        private System.Windows.Forms.Button ConfirmCheckInButton;
    }
}