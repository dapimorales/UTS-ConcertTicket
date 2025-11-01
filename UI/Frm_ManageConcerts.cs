using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using UTS_ConcertTicket.BusinessLogic;

namespace UTS_ConcertTicket.UI
{
    public partial class Frm_ManageConcerts : Form
    {
        private readonly ConcertService _concertService;
        private readonly IServiceProvider _serviceProvider; // Diperlukan untuk membuat Frm_InputConcert via DI
        private List<Concert> _allConcerts; // Menyimpan semua data untuk keperluan filter

        public Frm_ManageConcerts (ConcertService concertService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _concertService = concertService;
            _serviceProvider = serviceProvider;
            // Panggil LoadConcerts saat form pertama kali dimuat
            this.Load += async (s, e) => await LoadConcerts();
        }

        // Metode untuk memuat data dari service ke Data Grid View
        private async Task LoadConcerts()
        {
            try
            {
                // Ambil semua data dari Business Service dan simpan di variabel lokal
                _allConcerts = await _concertService.GetConcerts();

                // Tampilkan semua data ke Grid
                DisplayConcerts(_allConcerts);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error memuat data konser: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Metode Helper untuk menampilkan data (dipanggil oleh LoadConcerts dan Filter)
        private void DisplayConcerts(List<Concert> concerts)
        {
            dgvConcerts.DataSource = concerts.Select(c => new
            {
                c.Id,
                c.NamaKonser,
                c.Artis,
                c.TanggalWaktu,
                c.Lokasi,
                c.HargaDasar,
                c.StokTersedia,
                c.TotalPenonton
            }).ToList();
        }

        // Tombol Tambah (C)
        private async void btn_AddConcert_Click(object sender, EventArgs e)
        {
            // Gunakan ServiceProvider untuk mendapatkan instance Frm_InputConcert
            using (var inputForm = _serviceProvider.GetRequiredService<Frm_InputConcert>())
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Panggil Business Service untuk menyimpan data baru
                        await ConcertService.CreateConcert(inputForm.ConcertData);
                        MessageBox.Show("Konser berhasil ditambahkan!", "Sukses");
                        await LoadConcerts(); // Refresh
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Gagal menyimpan konser: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Tombol Edit (U)
        private async void btn_EditConcert_Click(object sender, EventArgs e)
        {
            if (dgvConcerts.CurrentRow == null) return;

            // Ambil ID konser yang dipilih
            var selectedId = (int)dgvConcerts.CurrentRow.Cells["Id"].Value;
            // Cari objek Konser dari daftar lokal
            var concertToEdit = _allConcerts.FirstOrDefault(c => c.Id == selectedId);

            if (concertToEdit == null) return;

            // Buka form input dengan data yang sudah ada (Anda perlu constructor Frm_InputConcert(Concert) )
            // Catatan: Jika Anda menggunakan DI untuk Frm_InputConcert, Anda perlu Factory Pattern
            using (var inputForm = new Frm_InputConcert(concertToEdit))
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Panggil Business Service untuk mengupdate data
                        await ConcertService.UpdateConcert(inputForm.ConcertData);
                        MessageBox.Show("Konser berhasil diperbarui!", "Sukses");
                        await LoadConcerts(); // Refresh
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Gagal memperbarui konser: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Tombol Hapus (D)
        private async void btn_DeleteConcert_Click(object sender, EventArgs e)
        {
            if (dgvConcerts.CurrentRow == null) return;

            var selectedId = (int)dgvConcerts.CurrentRow.Cells["Id"].Value;

            var confirm = MessageBox.Show("Yakin ingin menghapus konser ini? Tindakan ini tidak dapat dibatalkan.", "Konfirmasi",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    await ConcertService.DeleteConcert(selectedId);
                    MessageBox.Show("Konser berhasil dihapus.", "Sukses");
                    await LoadConcerts(); // Refresh
                }
                catch (InvalidOperationException ex) // Tangkap Exception dari Business Service (misal: sudah ada tiket)
                {
                    MessageBox.Show(ex.Message, "Gagal Hapus", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Fungsi Pencarian/Filter (R)
        private void txt_SearchConcert_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchConcert.Text.ToLowerInvariant();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                // Jika kosong, tampilkan semua data
                DisplayConcerts(_allConcerts);
            }
            else
            {
                // Filter daftar konser berdasarkan Nama Konser atau Artis
                var filteredList = _allConcerts
                    .Where(c => c.NamaKonser.ToLowerInvariant().Contains(searchText) ||
                                c.Artis.ToLowerInvariant().Contains(searchText))
                    .ToList();

                DisplayConcerts(filteredList);
            }
        }

        private void Frm_ManageConcerts_Load(object sender, EventArgs e)
        {

        }
    }
}
