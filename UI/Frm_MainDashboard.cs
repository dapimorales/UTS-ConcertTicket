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

namespace UTS_ConcertTicket.UI
{
    public partial class Frm_MainDashboard : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private Form _activeForm = null;

        // Injeksi ServiceProvider
        public Frm_MainDashboard(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            // Tampilkan default form saat startup (misalnya: Manajemen Konser)
            OpenChildForm<Frm_ManageConcerts>();
        }

        private void OpenChildForm<TForm>() where TForm : Form
        {
            // 1. Tutup form yang aktif sebelumnya
            if (_activeForm != null)
            {
                _activeForm.Close();
            }

            // 2. Buat instance form baru menggunakan ServiceProvider (DI)
            _activeForm = _serviceProvider.GetRequiredService<TForm>();

            // 3. Konfigurasi sebagai Child Form
            _activeForm.TopLevel = false;
            _activeForm.FormBorderStyle = FormBorderStyle.None;
            _activeForm.Dock = DockStyle.Fill;

            // 4. Tampilkan di pnl_ContentArea
            pnl_ContentArea.Controls.Add(_activeForm);
            pnl_ContentArea.Tag = _activeForm;
            _activeForm.BringToFront();
            _activeForm.Show();
        }

        // Event Handler untuk Tombol Navigasi
        private void btn_NavConcerts_Click(object sender, EventArgs e)
        {
            OpenChildForm<Frm_ManageConcerts>();
        }

        private void btn_NavAccounts_Click(object sender, EventArgs e)
        {
            OpenChildForm<Frm_ManageAccounts>();
        }

        private void btn_NavTickets_Click(object sender, EventArgs e)
        {
            OpenChildForm<Frm_ManageTickets>();
        }

        private void Frm_MainDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
