using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTS_ConcertTicket.BusinessLogic;

namespace UTS_ConcertTicket.UI
{
    public partial class Frm_ManageTickets : Form
    {
        private readonly TicketService _ticketService;

        // Injeksi TicketService
        public Frm_ManageTickets(TicketService ticketService)
        {
            InitializeComponent();
            _ticketService = ticketService;
            // Panggil LoadTickets saat form pertama kali dimuat
            this.Load += async (s, e) => await LoadTickets();
        }

        // Metode utama untuk memuat data Tiket secara Asynchronous
        private async Task LoadTickets()
        {
            try
            {
                // Asumsi method GetTicketsWithDetailsAsync() di TicketService me-load relasi Concert dan Account
                var tickets = await _ticketService.GetTicketsWithDetailsAsync();

                // Tampilkan data di DataGridView, menggunakan properti dari objek relasi
                dgv_Tickets.DataSource = tickets.Select(t => new
                {
                    ID = t.Id,
                    Concert = t.Concert.NamaKonser,       // Dari relasi Concert
                    Buyer = t.Account.FullName,           // Dari relasi Account
                    t.TicketCode,
                    t.PricePaid,
                    t.SaleDate,
                    t.Status
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error memuat data tiket: {ex.Message}", "Kesalahan Koneksi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event Handler untuk mengubah Status Tiket
        private async void btn_ChangeStatus_Click(object sender, EventArgs e)
        {
            if (dgv_Tickets.CurrentRow == null)
            {
                MessageBox.Show("Pilih tiket yang ingin diubah statusnya.", "Peringatan");
                return;
            }

            var selectedId = (int)dgv_Tickets.CurrentRow.Cells["ID"].Value;
            var currentStatus = dgv_Tickets.CurrentRow.Cells["Status"].Value.ToString();
            string newStatus = (currentStatus == "Sold") ? "Claimed" : "Sold"; // Logika sederhana ubah status

            var result = MessageBox.Show($"Ubah status tiket {selectedId} dari '{currentStatus}' menjadi '{newStatus}'?", "Konfirmasi Status", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Panggil Service untuk mengupdate status
                    await _ticketService.UpdateTicketStatusAsync(selectedId, newStatus);
                    MessageBox.Show("Status tiket berhasil diubah.", "Sukses");
                    await LoadTickets(); // Refresh DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gagal mengubah status: {ex.Message}", "Kesalahan");
                }
            }
        }

        // Event Handler untuk tombol Refresh
        private async void btn_Refresh_Click(object sender, EventArgs e)
        {
            await LoadTickets();
        }
    }
