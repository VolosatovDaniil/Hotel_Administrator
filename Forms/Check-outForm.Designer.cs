
namespace Hotel_Administrator.Forms
{
    partial class CheckOutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckOutForm));
            this.ConfirmCheckOutButton = new System.Windows.Forms.Button();
            this.CheckOutDateText = new System.Windows.Forms.Label();
            this.CheckOutDatePicker = new System.Windows.Forms.DateTimePicker();
            this.CheckInDateText = new System.Windows.Forms.Label();
            this.CheckInDatePicker = new System.Windows.Forms.DateTimePicker();
            this.RoomNumberText = new System.Windows.Forms.Label();
            this.RoomNumberBox = new System.Windows.Forms.TextBox();
            this.PassportText = new System.Windows.Forms.Label();
            this.PassportTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameText = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameText = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.CheckOutLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConfirmCheckOutButton
            // 
            this.ConfirmCheckOutButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ConfirmCheckOutButton.BackColor = System.Drawing.SystemColors.Control;
            this.ConfirmCheckOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmCheckOutButton.Location = new System.Drawing.Point(131, 440);
            this.ConfirmCheckOutButton.Name = "ConfirmCheckOutButton";
            this.ConfirmCheckOutButton.Size = new System.Drawing.Size(270, 40);
            this.ConfirmCheckOutButton.TabIndex = 27;
            this.ConfirmCheckOutButton.Text = "Підтвердити виселення";
            this.ConfirmCheckOutButton.UseVisualStyleBackColor = false;
            this.ConfirmCheckOutButton.Click += new System.EventHandler(this.ConfirmCheckOutButton_Click);
            // 
            // CheckOutDateText
            // 
            this.CheckOutDateText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CheckOutDateText.AutoSize = true;
            this.CheckOutDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckOutDateText.Location = new System.Drawing.Point(68, 378);
            this.CheckOutDateText.Name = "CheckOutDateText";
            this.CheckOutDateText.Size = new System.Drawing.Size(112, 24);
            this.CheckOutDateText.TabIndex = 26;
            this.CheckOutDateText.Text = "Виселення:";
            // 
            // CheckOutDatePicker
            // 
            this.CheckOutDatePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CheckOutDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckOutDatePicker.Location = new System.Drawing.Point(186, 378);
            this.CheckOutDatePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.CheckOutDatePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.CheckOutDatePicker.Name = "CheckOutDatePicker";
            this.CheckOutDatePicker.Size = new System.Drawing.Size(280, 26);
            this.CheckOutDatePicker.TabIndex = 25;
            this.CheckOutDatePicker.Value = new System.DateTime(2025, 5, 1, 0, 0, 0, 0);
            // 
            // CheckInDateText
            // 
            this.CheckInDateText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CheckInDateText.AutoSize = true;
            this.CheckInDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckInDateText.Location = new System.Drawing.Point(68, 323);
            this.CheckInDateText.Name = "CheckInDateText";
            this.CheckInDateText.Size = new System.Drawing.Size(112, 24);
            this.CheckInDateText.TabIndex = 24;
            this.CheckInDateText.Text = "Заселення:";
            // 
            // CheckInDatePicker
            // 
            this.CheckInDatePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CheckInDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckInDatePicker.Location = new System.Drawing.Point(186, 323);
            this.CheckInDatePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.CheckInDatePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.CheckInDatePicker.Name = "CheckInDatePicker";
            this.CheckInDatePicker.Size = new System.Drawing.Size(280, 26);
            this.CheckInDatePicker.TabIndex = 23;
            this.CheckInDatePicker.Value = new System.DateTime(2025, 4, 1, 0, 0, 0, 0);
            // 
            // RoomNumberText
            // 
            this.RoomNumberText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RoomNumberText.AutoSize = true;
            this.RoomNumberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomNumberText.Location = new System.Drawing.Point(68, 268);
            this.RoomNumberText.Name = "RoomNumberText";
            this.RoomNumberText.Size = new System.Drawing.Size(74, 24);
            this.RoomNumberText.TabIndex = 22;
            this.RoomNumberText.Text = "Номер:";
            // 
            // RoomNumberBox
            // 
            this.RoomNumberBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RoomNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomNumberBox.Location = new System.Drawing.Point(186, 268);
            this.RoomNumberBox.Name = "RoomNumberBox";
            this.RoomNumberBox.Size = new System.Drawing.Size(280, 26);
            this.RoomNumberBox.TabIndex = 21;
            // 
            // PassportText
            // 
            this.PassportText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PassportText.AutoSize = true;
            this.PassportText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassportText.Location = new System.Drawing.Point(68, 213);
            this.PassportText.Name = "PassportText";
            this.PassportText.Size = new System.Drawing.Size(91, 24);
            this.PassportText.TabIndex = 20;
            this.PassportText.Text = "Паспорт:";
            // 
            // PassportTextBox
            // 
            this.PassportTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PassportTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassportTextBox.Location = new System.Drawing.Point(186, 213);
            this.PassportTextBox.Name = "PassportTextBox";
            this.PassportTextBox.Size = new System.Drawing.Size(280, 26);
            this.PassportTextBox.TabIndex = 19;
            // 
            // FirstNameText
            // 
            this.FirstNameText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FirstNameText.AutoSize = true;
            this.FirstNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameText.Location = new System.Drawing.Point(68, 158);
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.Size = new System.Drawing.Size(46, 24);
            this.FirstNameText.TabIndex = 18;
            this.FirstNameText.Text = "Ім\'я:";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameTextBox.Location = new System.Drawing.Point(186, 158);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(280, 26);
            this.FirstNameTextBox.TabIndex = 17;
            // 
            // LastNameText
            // 
            this.LastNameText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LastNameText.AutoSize = true;
            this.LastNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameText.Location = new System.Drawing.Point(69, 102);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(99, 24);
            this.LastNameText.TabIndex = 16;
            this.LastNameText.Text = "Прізвище:";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameTextBox.Location = new System.Drawing.Point(186, 102);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(280, 26);
            this.LastNameTextBox.TabIndex = 15;
            // 
            // CheckOutLabel
            // 
            this.CheckOutLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CheckOutLabel.AutoSize = true;
            this.CheckOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckOutLabel.Location = new System.Drawing.Point(107, 28);
            this.CheckOutLabel.Name = "CheckOutLabel";
            this.CheckOutLabel.Size = new System.Drawing.Size(324, 42);
            this.CheckOutLabel.TabIndex = 14;
            this.CheckOutLabel.Text = "Виселення гостя";
            this.CheckOutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.ConfirmCheckOutButton);
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
            this.Controls.Add(this.CheckOutLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hotel Administrator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfirmCheckOutButton;
        private System.Windows.Forms.Label CheckOutDateText;
        private System.Windows.Forms.DateTimePicker CheckOutDatePicker;
        private System.Windows.Forms.Label CheckInDateText;
        private System.Windows.Forms.DateTimePicker CheckInDatePicker;
        private System.Windows.Forms.Label RoomNumberText;
        private System.Windows.Forms.TextBox RoomNumberBox;
        private System.Windows.Forms.Label PassportText;
        private System.Windows.Forms.TextBox PassportTextBox;
        private System.Windows.Forms.Label FirstNameText;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label LastNameText;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label CheckOutLabel;
    }
}