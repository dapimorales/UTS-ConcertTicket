namespace UTS_ConcertTicket.UI
{
    partial class Frm_InputConcert
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_NamaKonser = new TextBox();
            dtp_TanggalWaktu = new DateTimePicker();
            num_HargaDasar = new NumericUpDown();
            num_TotalStok = new NumericUpDown();
            btn_Save = new Button();
            btn_Cancel = new Button();
            label5 = new Label();
            txt_Artis = new TextBox();
            label6 = new Label();
            txt_Lokasi = new TextBox();
            ((System.ComponentModel.ISupportInitialize)num_HargaDasar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_TotalStok).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 20);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 0;
            label1.Text = "Nama Konser:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 168);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 1;
            label2.Text = "Tanggal/Waktu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 308);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 2;
            label3.Text = "Harga Dasar:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 373);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 3;
            label4.Text = "Total Stok:";
            // 
            // txt_NamaKonser
            // 
            txt_NamaKonser.Location = new Point(242, 20);
            txt_NamaKonser.Name = "txt_NamaKonser";
            txt_NamaKonser.Size = new Size(230, 31);
            txt_NamaKonser.TabIndex = 4;
            // 
            // dtp_TanggalWaktu
            // 
            dtp_TanggalWaktu.Location = new Point(242, 163);
            dtp_TanggalWaktu.Name = "dtp_TanggalWaktu";
            dtp_TanggalWaktu.Size = new Size(300, 31);
            dtp_TanggalWaktu.TabIndex = 5;
            // 
            // num_HargaDasar
            // 
            num_HargaDasar.Location = new Point(242, 308);
            num_HargaDasar.Name = "num_HargaDasar";
            num_HargaDasar.Size = new Size(230, 31);
            num_HargaDasar.TabIndex = 6;
            // 
            // num_TotalStok
            // 
            num_TotalStok.Location = new Point(242, 371);
            num_TotalStok.Name = "num_TotalStok";
            num_TotalStok.Size = new Size(230, 31);
            num_TotalStok.TabIndex = 7;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(32, 444);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(130, 45);
            btn_Save.TabIndex = 8;
            btn_Save.Text = "Simpan";
            btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(363, 444);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(130, 45);
            btn_Cancel.TabIndex = 9;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 110);
            label5.Name = "label5";
            label5.Size = new Size(99, 25);
            label5.TabIndex = 10;
            label5.Text = "Artis/Band:";
            // 
            // txt_Artis
            // 
            txt_Artis.Location = new Point(242, 95);
            txt_Artis.Name = "txt_Artis";
            txt_Artis.Size = new Size(230, 31);
            txt_Artis.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 246);
            label6.Name = "label6";
            label6.Size = new Size(120, 25);
            label6.TabIndex = 12;
            label6.Text = "Lokasi/Venue:";
            // 
            // txt_Lokasi
            // 
            txt_Lokasi.Location = new Point(242, 240);
            txt_Lokasi.Name = "txt_Lokasi";
            txt_Lokasi.Size = new Size(230, 31);
            txt_Lokasi.TabIndex = 13;
            // 
            // Frm_InputConcert
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 673);
            Controls.Add(txt_Lokasi);
            Controls.Add(label6);
            Controls.Add(txt_Artis);
            Controls.Add(label5);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Save);
            Controls.Add(num_TotalStok);
            Controls.Add(num_HargaDasar);
            Controls.Add(dtp_TanggalWaktu);
            Controls.Add(txt_NamaKonser);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Frm_InputConcert";
            Text = "Tambah/Edit Konser";
            Load += Frm_InputConcert_Load;
            ((System.ComponentModel.ISupportInitialize)num_HargaDasar).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_TotalStok).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_NamaKonser;
        private DateTimePicker dtp_TanggalWaktu;
        private NumericUpDown num_HargaDasar;
        private NumericUpDown num_TotalStok;
        private Button btn_Save;
        private Button btn_Cancel;
        private Label label5;
        private TextBox txt_Artis;
        private Label label6;
        private TextBox txt_Lokasi;
    }
}