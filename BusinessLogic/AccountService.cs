using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using UTS_ConcertTicket.DataAccess;
using UTS_ConcertTicket.Models;

namespace UTS_ConcertTicket.BusinessLogic
{
    public class AccountService
    {
        private readonly AccountRepository _repository;

        public AccountService(AccountRepository repository)
        {
            _repository = repository;
        }
        //CRUD
        public async Task<Account> CreateAccountAsync(Account newAccount)
        {
            //validasi
            if (string.IsNullOrWhiteSpace(newAccount.Username))
            {
                throw new ArgumentException("Username wajib diisi ya");
            }
            if (string.IsNullOrWhiteSpace(newAccount.PasswordHash))
            {
                throw new ArgumentException("Password wajib diisi");
            }
            if (await _repository.IsUsernameTakenAsync(newAccount.Username))
            {
                throw new ArgumentException($"Username'{newAccount.Username}'sudah digunakan");
            }
            //logika untuk password
            newAccount.PasswordHash = BCrypt.Net.BCrypt.HashPassword(newAccount.PasswordHash);
            //simpan lewat repository
            return await _repository.AddAsync(newAccount);
        }
        //mengambil semua akun
        public async Task<List<Account>> GetAllAccountsAsync()
        {
            return await _repository.GetAllAsync();
        }
        public async Task<Account> GetAccountByIdAsync(int id)
        {
            var account = await _repository.GetByIdAsync(id);
            if (account == null)
            {
                throw new KeyNotFoundException($"Akun dengan ID{id} tidak ditemukan");
            }
            return account;
        }
        public async Task UpdateAccountAsync(Account accountToUpdate)
        {
            var exsitingAccount = await _repository.GetByIdAsync(accountToUpdate.Id);
            if (exsitingAccount == null)
            {
                throw new KeyNotFoundException("Akun tidak ditemukan");
            }
            //update data dasar
            exsitingAccount.FullName = accountToUpdate.FullName;
            exsitingAccount.Email = accountToUpdate.Email;
            exsitingAccount.PhoneNumber = accountToUpdate.PhoneNumber;
            //logika update password
            if (!string.IsNullOrWhiteSpace(accountToUpdate.PasswordHash))
            {
                //password dari form input mentah
                exsitingAccount.PasswordHash = BCrypt.Net.BCrypt.HashPassword(accountToUpdate.PasswordHash);
            }
            //simpan perubahan melalui repository
            await _repository.UpdateAsync(exsitingAccount);
        }
        public async Task DeleteAccountAsync(int accountId)
        {
            var account = await _repository.GetByIdAsync(accountId);
            if (account == null) return;

            // Aturan Bisnis: Tidak bisa hapus akun jika sudah memiliki tiket yang terjual
            if (await _repository.HasTicketsAsync(accountId)) // Asumsi: Repository memiliki metode HasTicketsAsync()
            {
                throw new InvalidOperationException("Akun tidak dapat dihapus karena sudah melakukan transaksi tiket.");
            }

            await _repository.DeleteAsync(account);
        }
    }
}
