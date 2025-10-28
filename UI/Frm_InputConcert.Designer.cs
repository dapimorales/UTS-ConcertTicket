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
            dateTimePicker1 = new DateTimePicker();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            btn_Save = new Button();
            btn_Cancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
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
            label2.Location = new Point(29, 103);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 1;
            label2.Text = "Tanggal/Waktu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 181);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 2;
            label3.Text = "Harga Dasar:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 253);
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(242, 98);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(242, 181);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(230, 31);
            numericUpDown1.TabIndex = 6;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(242, 251);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(230, 31);
            numericUpDown2.TabIndex = 7;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(32, 324);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(130, 45);
            btn_Save.TabIndex = 8;
            btn_Save.Text = "Simpan";
            btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(363, 324);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(130, 45);
            btn_Cancel.TabIndex = 9;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // Frm_InputConcert
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 439);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Save);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(dateTimePicker1);
            Controls.Add(txt_NamaKonser);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Frm_InputConcert";
            Text = "Tambah/Edit Konser";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_NamaKonser;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Button btn_Save;
        private Button btn_Cancel;
    }
}