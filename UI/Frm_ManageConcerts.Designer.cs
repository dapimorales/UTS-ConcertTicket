namespace UTS_ConcertTicket.UI
{
    partial class Frm_ManageConcerts
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
            label1 = new Label();
            txtSearchConcert = new TextBox();
            btnAddConcert = new Button();
            btnEditConcert = new Button();
            btnDeleteConcert = new Button();
            dgvConcerts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvConcerts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(235, 100);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 0;
            label1.Text = "Cari Konser :";
            // 
            // txtSearchConcert
            // 
            txtSearchConcert.Location = new Point(379, 97);
            txtSearchConcert.Name = "txtSearchConcert";
            txtSearchConcert.Size = new Size(220, 31);
            txtSearchConcert.TabIndex = 1;
            // 
            // btnAddConcert
            // 
            btnAddConcert.Location = new Point(320, 174);
            btnAddConcert.Name = "btnAddConcert";
            btnAddConcert.Size = new Size(128, 34);
            btnAddConcert.TabIndex = 2;
            btnAddConcert.Text = "AddConcert";
            btnAddConcert.UseVisualStyleBackColor = true;
            // 
            // btnEditConcert
            // 
            btnEditConcert.Location = new Point(517, 174);
            btnEditConcert.Name = "btnEditConcert";
            btnEditConcert.Size = new Size(128, 34);
            btnEditConcert.TabIndex = 3;
            btnEditConcert.Text = "EditConcert";
            btnEditConcert.UseVisualStyleBackColor = true;
            // 
            // btnDeleteConcert
            // 
            btnDeleteConcert.Location = new Point(717, 173);
            btnDeleteConcert.Name = "btnDeleteConcert";
            btnDeleteConcert.Size = new Size(168, 34);
            btnDeleteConcert.TabIndex = 4;
            btnDeleteConcert.Text = "DeleteConcert";
            btnDeleteConcert.UseVisualStyleBackColor = true;
            // 
            // dgvConcerts
            // 
            dgvConcerts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConcerts.Location = new Point(-8, 214);
            dgvConcerts.Name = "dgvConcerts";
            dgvConcerts.RowHeadersWidth = 62;
            dgvConcerts.Size = new Size(1143, 459);
            dgvConcerts.TabIndex = 5;
            // 
            // Frm_ManageConcerts
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 671);
            Controls.Add(dgvConcerts);
            Controls.Add(btnDeleteConcert);
            Controls.Add(btnEditConcert);
            Controls.Add(btnAddConcert);
            Controls.Add(txtSearchConcert);
            Controls.Add(label1);
            Name = "Frm_ManageConcerts";
            Text = "Frm_ManageConcerts";
            Load += Frm_ManageConcerts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConcerts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearchConcert;
        private Button btnAddConcert;
        private Button btnEditConcert;
        private Button btnDeleteConcert;
        private DataGridView dgvConcerts;
    }
}