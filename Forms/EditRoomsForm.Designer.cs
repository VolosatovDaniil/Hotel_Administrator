
namespace Hotel_Administrator.Forms
{
    partial class EditRoomsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRoomsForm));
            this.EditRoomsLabel = new System.Windows.Forms.Label();
            this.EditRoomsTable = new System.Windows.Forms.DataGridView();
            this.EditRoomsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EditRoomsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // EditRoomsLabel
            // 
            this.EditRoomsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EditRoomsLabel.AutoSize = true;
            this.EditRoomsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditRoomsLabel.Location = new System.Drawing.Point(114, 11);
            this.EditRoomsLabel.Name = "EditRoomsLabel";
            this.EditRoomsLabel.Size = new System.Drawing.Size(410, 42);
            this.EditRoomsLabel.TabIndex = 1;
            this.EditRoomsLabel.Text = "Редагування номерів";
            // 
            // EditRoomsTable
            // 
            this.EditRoomsTable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EditRoomsTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.EditRoomsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditRoomsTable.Location = new System.Drawing.Point(0, 71);
            this.EditRoomsTable.Name = "EditRoomsTable";
            this.EditRoomsTable.Size = new System.Drawing.Size(634, 405);
            this.EditRoomsTable.TabIndex = 2;
            this.EditRoomsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditRoomsTable_CellContentClick);
            // 
            // EditRoomsButton
            // 
            this.EditRoomsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EditRoomsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditRoomsButton.Location = new System.Drawing.Point(206, 496);
            this.EditRoomsButton.Name = "EditRoomsButton";
            this.EditRoomsButton.Size = new System.Drawing.Size(222, 43);
            this.EditRoomsButton.TabIndex = 3;
            this.EditRoomsButton.Text = "Зберегти зміни";
            this.EditRoomsButton.UseVisualStyleBackColor = true;
            this.EditRoomsButton.Click += new System.EventHandler(this.EditRoomsButton_Click);
            // 
            // EditRoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 561);
            this.Controls.Add(this.EditRoomsButton);
            this.Controls.Add(this.EditRoomsTable);
            this.Controls.Add(this.EditRoomsLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditRoomsForm";
            this.Text = "Hotel Administrator";
            ((System.ComponentModel.ISupportInitialize)(this.EditRoomsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EditRoomsLabel;
        private System.Windows.Forms.DataGridView EditRoomsTable;
        private System.Windows.Forms.Button EditRoomsButton;
    }
}