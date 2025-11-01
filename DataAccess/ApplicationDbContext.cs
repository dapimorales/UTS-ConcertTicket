// 3. DataAccess / Repositories/ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;
using UTS_ConcertTicket.Models;
// Pastikan using namespace untuk Models sudah benar

public class ApplicationDbContext : DbContext
{
    public DbSet<Account> Accounts => Set<Account>();
    public DbSet<Concert> Concerts => Set<Concert>();
    public DbSet<Ticket> Tickets => Set<Ticket>();

    private readonly string _connectionString;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Hanya panggil jika constructor sederhana digunakan
        //if (!optionsBuilder.IsConfigured && !string.IsNullOrEmpty(_connectionString))
        //{
            optionsBuilder.UseNpgsql("Host=localhost;Database=db_vb2_concert_ticketing;Username=postgres;Password=root");
        //}
    }

}