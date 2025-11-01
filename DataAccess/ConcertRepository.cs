using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UTS_ConcertTicket.Models;

namespace UTS_ConcertTicket.DataAccess
{
    public class ConcertRepository
    {
        private readonly ApplicationDbContext _context;

        // Dependency Injection: Menerima DbContext
        public ConcertRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // =========================================================
        // Standard CRUD Operations (Required by ConcertService)
        // =========================================================

        // C - CREATE
        public async Task<Concert> AddAsync(Concert concert)
        {
            await _context.Concerts.AddAsync(concert);
            await _context.SaveChangesAsync();
            return concert;
        }

        // R - READ ALL
        public async Task<List<Concert>> GetAllAsync()
        {
            // Mengambil semua konser
            return await _context.Concerts.ToListAsync();
        }

        // R - READ BY ID
        public async Task<Concert> GetByIdAsync(int id)
        {
            // Mencari konser berdasarkan ID
            return await _context.Concerts.FindAsync(id);
        }

        // U - UPDATE
        public async Task UpdateAsync(Concert concert)
        {
            _context.Concerts.Update(concert);
            await _context.SaveChangesAsync();
        }

        // D - DELETE
        public async Task DeleteAsync(Concert concert)
        {
            _context.Concerts.Remove(concert);
            await _context.SaveChangesAsync();
        }

        // =========================================================
        // Business Logic Helper Methods (Used by ConcertService)
        // =========================================================

        // Helper 1: Memeriksa apakah Konser sudah memiliki transaksi tiket (Untuk DELETE)
        public async Task<bool> HasTicketsAsync(int concertId)
        {
            // EF Core: Mencari di tabel Tickets apakah ada Foreign Key yang merujuk ke Concert ID ini
            return await _context.Tickets
                                 .AnyAsync(t => t.ConcertId == concertId);
        }

        // Helper 2: Mengambil Konser beserta tiketnya (Opsional, untuk perhitungan stok yang lebih kompleks)
        public async Task<Concert> GetConcertWithTicketsAsync(int id)
        {
            // Menggunakan Eager Loading (.Include) untuk memuat data relasi Ticket
            return await _context.Concerts
                .Include(c => c.Tickets)
                .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
