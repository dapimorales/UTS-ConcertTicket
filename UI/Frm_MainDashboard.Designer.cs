namespace UTS_ConcertTicket.UI
{
    partial class Frm_MainDashboard
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
            btn_NavConcerts = new Button();
            btn_NavTickets = new Button();
            btn_NavAccounts = new Button();
            pnl_ContentArea = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 51);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 0;
            label1.Text = "Navigasi";
            // 
            // btn_NavConcerts
            // 
            btn_NavConcerts.Location = new Point(55, 109);
            btn_NavConcerts.Name = "btn_NavConcerts";
            btn_NavConcerts.Size = new Size(140, 59);
            btn_NavConcerts.TabIndex = 1;
            btn_NavConcerts.Text = "Konser";
            btn_NavConcerts.UseVisualStyleBackColor = true;
            // 
            // btn_NavTickets
            // 
            btn_NavTickets.Location = new Point(55, 567);
            btn_NavTickets.Name = "btn_NavTickets";
            btn_NavTickets.Size = new Size(140, 59);
            btn_NavTickets.TabIndex = 2;
            btn_NavTickets.Text = "Tiket";
            btn_NavTickets.UseVisualStyleBackColor = true;
            // 
            // btn_NavAccounts
            // 
            btn_NavAccounts.Location = new Point(55, 342);
            btn_NavAccounts.Name = "btn_NavAccounts";
            btn_NavAccounts.Size = new Size(140, 59);
            btn_NavAccounts.TabIndex = 3;
            btn_NavAccounts.Text = "Akun";
            btn_NavAccounts.UseVisualStyleBackColor = true;
            // 
            // pnl_ContentArea
            // 
            pnl_ContentArea.Location = new Point(227, 109);
            pnl_ContentArea.Name = "pnl_ContentArea";
            pnl_ContentArea.Size = new Size(1017, 517);
            pnl_ContentArea.TabIndex = 4;
            // 
            // Frm_MainDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 753);
            Controls.Add(pnl_ContentArea);
            Controls.Add(btn_NavAccounts);
            Controls.Add(btn_NavTickets);
            Controls.Add(btn_NavConcerts);
            Controls.Add(label1);
            Name = "Frm_MainDashboard";
            Text = "Concert Ticketing - Admin Panel";
            Load += Frm_MainDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_NavConcerts;
        private Button btn_NavTickets;
        private Button btn_NavAccounts;
        private Panel pnl_ContentArea;
    }
}