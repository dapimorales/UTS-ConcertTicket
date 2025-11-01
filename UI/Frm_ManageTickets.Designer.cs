namespace UTS_ConcertTicket.UI
{
    partial class Frm_ManageTickets
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
            cmb_FilterConcert = new ComboBox();
            txt_SearchTicketCode = new TextBox();
            btn_ViewDetailTicket = new Button();
            dgv_Tickets = new DataGridView();
            label2 = new Label();
            btn_ChangeStatus = new Button();
            btn_RefreshTickets = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Tickets).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 0;
            label1.Text = "Filter Konser: : ";
            // 
            // cmb_FilterConcert
            // 
            cmb_FilterConcert.FormattingEnabled = true;
            cmb_FilterConcert.Location = new Point(165, 10);
            cmb_FilterConcert.Name = "cmb_FilterConcert";
            cmb_FilterConcert.Size = new Size(182, 33);
            cmb_FilterConcert.TabIndex = 1;
            // 
            // txt_SearchTicketCode
            // 
            txt_SearchTicketCode.Location = new Point(674, 13);
            txt_SearchTicketCode.Name = "txt_SearchTicketCode";
            txt_SearchTicketCode.Size = new Size(150, 31);
            txt_SearchTicketCode.TabIndex = 2;
            // 
            // btn_ViewDetailTicket
            // 
            btn_ViewDetailTicket.Location = new Point(69, 201);
            btn_ViewDetailTicket.Name = "btn_ViewDetailTicket";
            btn_ViewDetailTicket.Size = new Size(112, 34);
            btn_ViewDetailTicket.TabIndex = 3;
            btn_ViewDetailTicket.Text = "View";
            btn_ViewDetailTicket.UseVisualStyleBackColor = true;
            // 
            // dgv_Tickets
            // 
            dgv_Tickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Tickets.Location = new Point(41, 252);
            dgv_Tickets.Name = "dgv_Tickets";
            dgv_Tickets.RowHeadersWidth = 62;
            dgv_Tickets.Size = new Size(863, 244);
            dgv_Tickets.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(508, 16);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 5;
            label2.Text = "Cari Kode :";
            // 
            // btn_ChangeStatus
            // 
            btn_ChangeStatus.Location = new Point(215, 201);
            btn_ChangeStatus.Name = "btn_ChangeStatus";
            btn_ChangeStatus.Size = new Size(112, 34);
            btn_ChangeStatus.TabIndex = 6;
            btn_ChangeStatus.Text = "Change";
            btn_ChangeStatus.UseVisualStyleBackColor = true;
            // 
            // btn_RefreshTickets
            // 
            btn_RefreshTickets.Location = new Point(363, 201);
            btn_RefreshTickets.Name = "btn_RefreshTickets";
            btn_RefreshTickets.Size = new Size(112, 34);
            btn_RefreshTickets.TabIndex = 7;
            btn_RefreshTickets.Text = "Refresh";
            btn_RefreshTickets.UseVisualStyleBackColor = true;
            // 
            // Frm_ManageTickets
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 522);
            Controls.Add(btn_RefreshTickets);
            Controls.Add(btn_ChangeStatus);
            Controls.Add(label2);
            Controls.Add(dgv_Tickets);
            Controls.Add(btn_ViewDetailTicket);
            Controls.Add(txt_SearchTicketCode);
            Controls.Add(cmb_FilterConcert);
            Controls.Add(label1);
            Name = "Frm_ManageTickets";
            Text = "Frm_ManageTickets";
            Load += Frm_ManageTickets_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Tickets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmb_FilterConcert;
        private TextBox txt_SearchTicketCode;
        private Button btn_ViewDetailTicket;
        private DataGridView dgv_Tickets;
        private Label label2;
        private Button btn_ChangeStatus;
        private Button btn_RefreshTickets;
    }
}