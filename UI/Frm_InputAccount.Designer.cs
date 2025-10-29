namespace UTS_ConcertTicket.UI
{
    partial class Frm_InputAccount
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
            txtUsername = new TextBox();
            label2 = new Label();
            txtNamaLengkap = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtPhoneNumber = new TextBox();
            label5 = new Label();
            txtPassword = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 59);
            label1.Name = "label1";
            label1.Size = new Size(148, 30);
            label1.TabIndex = 0;
            label1.Text = "Username :";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(285, 61);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(227, 31);
            txtUsername.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 114);
            label2.Name = "label2";
            label2.Size = new Size(203, 30);
            label2.TabIndex = 2;
            label2.Text = "Nama Lengkap :";
            // 
            // txtNamaLengkap
            // 
            txtNamaLengkap.Location = new Point(285, 119);
            txtNamaLengkap.Name = "txtNamaLengkap";
            txtNamaLengkap.Size = new Size(227, 31);
            txtNamaLengkap.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 164);
            label3.Name = "label3";
            label3.Size = new Size(96, 30);
            label3.TabIndex = 4;
            label3.Text = "Email :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(285, 166);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(227, 31);
            txtEmail.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(38, 216);
            label4.Name = "label4";
            label4.Size = new Size(129, 30);
            label4.TabIndex = 6;
            label4.Text = "Telepon :";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(285, 218);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(227, 31);
            txtPhoneNumber.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(38, 269);
            label5.Name = "label5";
            label5.Size = new Size(156, 30);
            label5.TabIndex = 8;
            label5.Text = "Password :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(285, 281);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(227, 31);
            txtPassword.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(107, 356);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(123, 37);
            btnSave.TabIndex = 10;
            btnSave.Text = "Simpan";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(399, 356);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(123, 37);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Frm_InputAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 484);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPassword);
            Controls.Add(label5);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtNamaLengkap);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Name = "Frm_InputAccount";
            Text = "Frm_InputAccount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsername;
        private Label label2;
        private TextBox txtNamaLengkap;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtPhoneNumber;
        private Label label5;
        private TextBox txtPassword;
        private Button btnSave;
        private Button btnCancel;
    }
}