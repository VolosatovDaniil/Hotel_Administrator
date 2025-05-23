
namespace Hotel_Administrator
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SearchRoomPropertiesText = new System.Windows.Forms.Label();
            this.SearchRoomText = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchResultsText = new System.Windows.Forms.Label();
            this.SearchResultsTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ViewGuestsButton = new System.Windows.Forms.Button();
            this.EditRoomsButton = new System.Windows.Forms.Button();
            this.CheckOutButton = new System.Windows.Forms.Button();
            this.CheckInButton = new System.Windows.Forms.Button();
            this.SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultsTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchPanel
            // 
            this.SearchPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchPanel.BackColor = System.Drawing.SystemColors.Control;
            this.SearchPanel.Controls.Add(this.SearchRoomPropertiesText);
            this.SearchPanel.Controls.Add(this.SearchRoomText);
            this.SearchPanel.Controls.Add(this.SearchButton);
            this.SearchPanel.Controls.Add(this.SearchTextBox);
            this.SearchPanel.Location = new System.Drawing.Point(0, 0);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(984, 100);
            this.SearchPanel.TabIndex = 0;
            // 
            // SearchRoomPropertiesText
            // 
            this.SearchRoomPropertiesText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchRoomPropertiesText.AutoSize = true;
            this.SearchRoomPropertiesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchRoomPropertiesText.Location = new System.Drawing.Point(12, 59);
            this.SearchRoomPropertiesText.Name = "SearchRoomPropertiesText";
            this.SearchRoomPropertiesText.Size = new System.Drawing.Size(173, 18);
            this.SearchRoomPropertiesText.TabIndex = 3;
            this.SearchRoomPropertiesText.Text = "Номер / Клас / Паспорт";
            // 
            // SearchRoomText
            // 
            this.SearchRoomText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchRoomText.AutoSize = true;
            this.SearchRoomText.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchRoomText.Location = new System.Drawing.Point(9, 24);
            this.SearchRoomText.Name = "SearchRoomText";
            this.SearchRoomText.Size = new System.Drawing.Size(177, 31);
            this.SearchRoomText.TabIndex = 2;
            this.SearchRoomText.Text = "Пошук номера";
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchButton.BackColor = System.Drawing.SystemColors.Control;
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(872, 35);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(100, 30);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Пошук";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchTextBox.Location = new System.Drawing.Point(201, 35);
            this.SearchTextBox.Multiline = true;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(651, 30);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // SearchResultsText
            // 
            this.SearchResultsText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchResultsText.AutoSize = true;
            this.SearchResultsText.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchResultsText.Location = new System.Drawing.Point(9, 109);
            this.SearchResultsText.Name = "SearchResultsText";
            this.SearchResultsText.Size = new System.Drawing.Size(225, 31);
            this.SearchResultsText.TabIndex = 4;
            this.SearchResultsText.Text = "Результати пошуку:";
            // 
            // SearchResultsTable
            // 
            this.SearchResultsTable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchResultsTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.SearchResultsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchResultsTable.Location = new System.Drawing.Point(0, 148);
            this.SearchResultsTable.Name = "SearchResultsTable";
            this.SearchResultsTable.Size = new System.Drawing.Size(984, 296);
            this.SearchResultsTable.TabIndex = 5;
            this.SearchResultsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchResultsTable_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.ViewGuestsButton);
            this.panel1.Controls.Add(this.EditRoomsButton);
            this.panel1.Controls.Add(this.CheckOutButton);
            this.panel1.Controls.Add(this.CheckInButton);
            this.panel1.Location = new System.Drawing.Point(0, 450);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 111);
            this.panel1.TabIndex = 6;
            // 
            // ViewGuestsButton
            // 
            this.ViewGuestsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ViewGuestsButton.BackColor = System.Drawing.SystemColors.Control;
            this.ViewGuestsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewGuestsButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewGuestsButton.Location = new System.Drawing.Point(762, 60);
            this.ViewGuestsButton.Name = "ViewGuestsButton";
            this.ViewGuestsButton.Size = new System.Drawing.Size(210, 38);
            this.ViewGuestsButton.TabIndex = 10;
            this.ViewGuestsButton.Text = "Переглянути гостей";
            this.ViewGuestsButton.UseVisualStyleBackColor = false;
            this.ViewGuestsButton.Click += new System.EventHandler(this.ViewGuestsButton_Click);
            // 
            // EditRoomsButton
            // 
            this.EditRoomsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EditRoomsButton.BackColor = System.Drawing.SystemColors.Control;
            this.EditRoomsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditRoomsButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditRoomsButton.Location = new System.Drawing.Point(762, 11);
            this.EditRoomsButton.Name = "EditRoomsButton";
            this.EditRoomsButton.Size = new System.Drawing.Size(210, 38);
            this.EditRoomsButton.TabIndex = 9;
            this.EditRoomsButton.Text = "Редагувати номери";
            this.EditRoomsButton.UseVisualStyleBackColor = false;
            this.EditRoomsButton.Click += new System.EventHandler(this.EditRoomsButton_Click);
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CheckOutButton.BackColor = System.Drawing.SystemColors.Control;
            this.CheckOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckOutButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckOutButton.Location = new System.Drawing.Point(163, 35);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(125, 38);
            this.CheckOutButton.TabIndex = 8;
            this.CheckOutButton.Text = "Виселити";
            this.CheckOutButton.UseVisualStyleBackColor = false;
            this.CheckOutButton.Click += new System.EventHandler(this.CheckOutButton_Click);
            // 
            // CheckInButton
            // 
            this.CheckInButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CheckInButton.BackColor = System.Drawing.SystemColors.Control;
            this.CheckInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckInButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckInButton.Location = new System.Drawing.Point(15, 35);
            this.CheckInButton.Name = "CheckInButton";
            this.CheckInButton.Size = new System.Drawing.Size(125, 38);
            this.CheckInButton.TabIndex = 4;
            this.CheckInButton.Text = "Заселити";
            this.CheckInButton.UseVisualStyleBackColor = false;
            this.CheckInButton.Click += new System.EventHandler(this.CheckInButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SearchResultsTable);
            this.Controls.Add(this.SearchResultsText);
            this.Controls.Add(this.SearchPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Administrator";
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultsTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label SearchRoomPropertiesText;
        private System.Windows.Forms.Label SearchRoomText;
        private System.Windows.Forms.Label SearchResultsText;
        private System.Windows.Forms.DataGridView SearchResultsTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ViewGuestsButton;
        private System.Windows.Forms.Button EditRoomsButton;
        private System.Windows.Forms.Button CheckOutButton;
        private System.Windows.Forms.Button CheckInButton;
    }
}

