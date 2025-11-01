using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using UTS_ConcertTicket.DataAccess;
using UTS_ConcertTicket.Models;


public class AccountRepository
{
    private readonly ApplicationDbContext _context;

    // Dependency Injection: Menerima DbContext
    public AccountRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    //  CREATE
    public async Task<Account> AddAsync(Account account)
    {
        await _context.Accounts.AddAsync(account);
        await _context.SaveChangesAsync();
        return account;
    }

    //  READ ALL
    public async Task<List<Account>> GetAllAsync()
    {
        return await _context.Accounts.ToListAsync();
    }

    //  READ BY ID
    public async Task<Account> GetByIdAsync(int id)
    {
        return await _context.Accounts.FindAsync(id);
    }

    //  READ BY USERNAME (Digunakan untuk validasi/autentikasi)
    public async Task<Account> GetByUsernameAsync(string username)
    {
        // Mencari akun pertama yang cocok dengan username
        return await _context.Accounts
            .FirstOrDefaultAsync(a => a.Username == username);
    }

    // UPDATE
    public async Task UpdateAsync(Account account)
    {
        _context.Accounts.Update(account);
        await _context.SaveChangesAsync();
    }

    //  DELETE
    public async Task DeleteAsync(Account account)
    {
        _context.Accounts.Remove(account);
        await _context.SaveChangesAsync();
    }


    //  Memeriksa apakah Username sudah digunakan 
    public async Task<bool> IsUsernameTakenAsync(string username)
    {
        // EF Core: Mencari apakah ada akun dengan username yang sama
        return await _context.Accounts
                             .AnyAsync(a => a.Username == username);
    }

    //  Memeriksa apakah Akun sudah memiliki transaksi tiket buat delete
    public async Task<bool> HasTicketsAsync(int accountId)
    {
        // EF Core: Mencari di tabel Tickets apakah ada Foreign Key yang merujuk ke Account ID ini
        return await _context.Tickets
                             .AnyAsync(t => t.AccountId == accountId);
    }
}