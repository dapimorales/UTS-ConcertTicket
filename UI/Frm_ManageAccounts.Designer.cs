namespace UTS_ConcertTicket.UI
{
    partial class Frm_ManageAccounts
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
            txtSearchAccount = new TextBox();
            dgvAccounts = new DataGridView();
            btnAddAccount = new Button();
            btnEditAccount = new Button();
            btnDeleteAccount = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 55);
            label1.Name = "label1";
            label1.Size = new Size(160, 30);
            label1.TabIndex = 0;
            label1.Text = "Cari Akun :";
            // 
            // txtSearchAccount
            // 
            txtSearchAccount.Location = new Point(283, 58);
            txtSearchAccount.Name = "txtSearchAccount";
            txtSearchAccount.Size = new Size(236, 31);
            txtSearchAccount.TabIndex = 1;
            // 
            // dgvAccounts
            // 
            dgvAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccounts.Location = new Point(-7, 158);
            dgvAccounts.Name = "dgvAccounts";
            dgvAccounts.RowHeadersWidth = 62;
            dgvAccounts.Size = new Size(1207, 380);
            dgvAccounts.TabIndex = 2;
            // 
            // btnAddAccount
            // 
            btnAddAccount.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddAccount.Location = new Point(201, 109);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(135, 43);
            btnAddAccount.TabIndex = 3;
            btnAddAccount.Text = "Add Account";
            btnAddAccount.UseVisualStyleBackColor = true;
            // 
            // btnEditAccount
            // 
            btnEditAccount.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditAccount.Location = new Point(437, 109);
            btnEditAccount.Name = "btnEditAccount";
            btnEditAccount.Size = new Size(120, 43);
            btnEditAccount.TabIndex = 4;
            btnEditAccount.Text = "Edit Account";
            btnEditAccount.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteAccount.Location = new Point(661, 109);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(143, 43);
            btnDeleteAccount.TabIndex = 5;
            btnDeleteAccount.Text = "Delete Account";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // Frm_ManageAccounts
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 540);
            Controls.Add(btnDeleteAccount);
            Controls.Add(btnEditAccount);
            Controls.Add(btnAddAccount);
            Controls.Add(dgvAccounts);
            Controls.Add(txtSearchAccount);
            Controls.Add(label1);
            Name = "Frm_ManageAccounts";
            Text = "Frm_ManageAccounts";
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearchAccount;
        private DataGridView dgvAccounts;
        private Button btnAddAccount;
        private Button btnEditAccount;
        private Button btnDeleteAccount;
    }
}