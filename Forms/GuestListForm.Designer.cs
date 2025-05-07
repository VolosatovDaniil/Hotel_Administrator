
namespace Hotel_Administrator.Forms
{
    partial class GuestListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestListForm));
            this.GuestListLabel = new System.Windows.Forms.Label();
            this.GuestListTable = new System.Windows.Forms.DataGridView();
            this.EditButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GuestListTable)).BeginInit();
            this.SuspendLayout();
            // 
            // GuestListLabel
            // 
            this.GuestListLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GuestListLabel.AutoSize = true;
            this.GuestListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GuestListLabel.Location = new System.Drawing.Point(177, 11);
            this.GuestListLabel.Name = "GuestListLabel";
            this.GuestListLabel.Size = new System.Drawing.Size(282, 42);
            this.GuestListLabel.TabIndex = 0;
            this.GuestListLabel.Text = "Список гостей";
            // 
            // GuestListTable
            // 
            this.GuestListTable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GuestListTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.GuestListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GuestListTable.Location = new System.Drawing.Point(0, 71);
            this.GuestListTable.Name = "GuestListTable";
            this.GuestListTable.Size = new System.Drawing.Size(634, 405);
            this.GuestListTable.TabIndex = 1;
            this.GuestListTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GuestListTable_CellContentClick);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditButton.Location = new System.Drawing.Point(236, 496);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(159, 43);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Редагувати";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // GuestListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 561);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.GuestListTable);
            this.Controls.Add(this.GuestListLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GuestListForm";
            this.Text = "Hotel Administrator";
            ((System.ComponentModel.ISupportInitialize)(this.GuestListTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GuestListLabel;
        private System.Windows.Forms.DataGridView GuestListTable;
        private System.Windows.Forms.Button EditButton;
    }
}