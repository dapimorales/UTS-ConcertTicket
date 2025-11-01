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

    // Digunakan saat menggunakan Dependency Injection di aplikasi modern
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    // Constructor sederhana jika tidak menggunakan DI (kurang disarankan)
    public ApplicationDbContext(string connectionString)
    {
        _connectionString = connectionString;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Hanya panggil jika constructor sederhana digunakan
        if (!optionsBuilder.IsConfigured && !string.IsNullOrEmpty(_connectionString))
        {
            optionsBuilder.UseNpgsql(_connectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Konfigurasi primary key, foreign key, dan tipe data spesifik
        modelBuilder.Entity<Concert>()
            .Property(c => c.HargaDasar)
            .HasColumnType("numeric(10, 2)"); // Akurasi 10 digit, 2 desimal

        modelBuilder.Entity<Ticket>()
            .Property(t => t.PricePaid)
            .HasColumnType("numeric(10, 2)");

        // Relasi Concert (1) -> Ticket (Many)
        modelBuilder.Entity<Ticket>()
            .HasOne(t => t.Concert)
            .WithMany(c => c.Tickets)
            .HasForeignKey(t => t.ConcertId);

        // Relasi Account (1) -> Ticket (Many)
        modelBuilder.Entity<Ticket>()
            .HasOne(t => t.Account)
            .WithMany(a => a.Tickets)
            .HasForeignKey(t => t.AccountId);
    }
}