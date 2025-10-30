using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS_ConcertTicket.UI
{
    public partial class Frm_InputConcert : Form
    {
        // Properti untuk menyimpan data Concert yang akan dikembalikan
        public Concert ConcertData { get; private set; }

        // Constructor untuk Tambah Baru
        public Frm_InputConcert()
        {
            InitializeComponent();
            ConcertData = new Concert();
            this.Text = "Tambah Konser Baru";
        }

        // Constructor untuk Edit
        public Frm_InputConcert(Concert existingConcert)
        {
            InitializeComponent();
            ConcertData = existingConcert;
            this.Text = "Edit Konser";
            // Panggil metode untuk mengisi data ke komponen
            LoadConcertData(existingConcert);
        }

        private void LoadConcertData(Concert concert)
        {
            // Isi komponen sesuai name yang disepakati
            txt_NamaKonser.Text = concert.NamaKonser;
            txt_Artis.Text = concert.Artis;
            dtp_TanggalWaktu.Value = concert.TanggalWaktu;
            txt_Lokasi.Text = concert.Lokasi;
            num_HargaDasar.Value = concert.HargaDasar;
            num_TotalStok.Value = concert.TotalStok;
            // Catatan: Jika edit, TotalStok harus hati-hati agar tidak kurang dari (TotalStok - StokTersedia)
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                // Ambil data dari komponen dan masukkan ke objek ConcertData
                ConcertData.NamaKonser = txt_NamaKonser.Text;
                ConcertData.Artis = txt_Artis.Text;
                ConcertData.TanggalWaktu = dtp_TanggalWaktu.Value;
                ConcertData.Lokasi = txt_Lokasi.Text;
                ConcertData.HargaDasar = num_HargaDasar.Value;
                ConcertData.TotalStok = (int)num_TotalStok.Value;

                // Jika ini form tambah, StokTersedia akan diisi di Service.
                // Jika ini form edit, pastikan StokTersedia juga diperbarui jika TotalStok bertambah.

                this.DialogResult = DialogResult.OK; // Tanda sukses
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Validasi Input Gagal: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Frm_InputConcert_Load(object sender, EventArgs e)
        {

        }
    }
