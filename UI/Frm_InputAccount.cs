using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTS_ConcertTicket.Models;

namespace UTS_ConcertTicket.UI
{
    public partial class Frm_InputAccount : Form
    {
        //properti untuk menyimpan objek account
        public Account AccountData { get; private set; }

        public Frm_InputAccount()
        {
            InitializeComponent();
            AccountData = new Account();
            this.Text = " Tambah pengguna baru ";
        }

        //untuk edit akun lama
        public Frm_InputAccount(Account exitingAccount)
        {
            InitializeComponent();
            AccountData = exitingAccount;
            this.Text = "Edit detail akun";
            LoadAccountData(exitingAccount);
        }
        //metode untuk mengisi komponen input 
        private void LoadAccountData(Account account)
        {
            txtUsername.Text = account.Username;
            txtNamaLengkap.Text = account.FullName;
            txtEmail.Text = account.Email;
            txtPhoneNumber.Text = account.PhoneNumber;
            txtPassword.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //validasi sederhana 
                if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    throw new ArgumentException("Username dan email wajib di isi masbro");
                }
                //ambil data
                AccountData.Username = txtUsername.Text;
                AccountData.FullName = txtNamaLengkap.Text;
                AccountData.Email = txtEmail.Text;
                AccountData.PhoneNumber = txtPhoneNumber.Text;
                //logika untuk password 
                if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    //password di isi
                    AccountData.PasswordHash = txtPassword.Text;
                }
                //jika password kosong di abaikan
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validasi Input Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi Kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }
    }
}
