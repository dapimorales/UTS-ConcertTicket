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
using UTS_ConcertTicket.Models;
using UTS_ConcertTicket.BusinessLogic;

namespace UTS_ConcertTicket.UI
{
    public partial class Frm_ManageAccounts : Form
    {
        private readonly AccountService AccountService;
        private readonly IServiceProvider serviceProvider;

        public Frm_ManageAccounts(AccountService accountService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _accountService = accountService;
            _serviceProvider = serviceProvider;
            //memanggil loadaccount pertama kali di muat
            this.Load += async (s, e) => await LoadAccount();
        }
        private async Task LoadAccount()
        {
            try
            {
                // Ambil semua akun dari Service Layer
                var accounts = await _accountService.GetAllAccountsAsync();

                // Tampilkan data di DataGridView (hanya kolom yang relevan)
                dgvAccounts.DataSource = accounts.Select(a => new
                {
                    // Kolom yang akan ditampilkan di grid
                    ID = a.Id,
                    a.Username,
                    a.FullName,
                    a.Email,
                    a.PhoneNumber
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error memuat data akun: {ex.Message}", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //edit account
        private async void btnEditAccount_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.CurrentRow == null) return;
            var selectedAccountId = (int)dgvAccounts.CurrentRow.Cells["ID"].Value;
            var accountToEdit = await _accountsService.GetAccountsByIdAsync(selectedAccountId);

            if (accountToEdit == null)
            {
                MessageBox.Show("Akun tidak ditemukan nih.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        //add account
        private async void btnAddAccount_Click(object sender, EventArgs e)
        {
            using (var inputForm = serviceProvider.GetRequiredService<Frm_InputAccount>())
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        //memanggil service untuk menyimpan data akun baru 
                        await _accountService.CreateAccountAsync(inputForm.AccountData);
                        MessageBox.Show("Akun berhasil ditambahkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadAccount();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Gagal menyimpan akun: {ex.Message}", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.CurrentRow == null) return;
            var selectedAccountId = (int)dgvAccounts.CurrentRow.Cells["ID"].Value;
            var username = dgvAccounts.CurrentRow.Cells["username"].Value;
            var result = MessageBox.Show($"Yakin ingin menghapus akun '{username}'?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    await _accountService.DeleteAccountAsync(selectedAccountId);
                    MessageBox.Show("Akun berhasil di hapus", "Sukses");
                    await LoadAccount();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gagal menghapus akun : {ex.Message}", "Kesalahan");
                }
            }
        }

        private void Frm_ManageAccounts_Load(object sender, EventArgs e)
        {

        }
    }
}
