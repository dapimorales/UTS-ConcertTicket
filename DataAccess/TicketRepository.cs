using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UTS_ConcertTicket.Models;

namespace UTS_ConcertTicket.DataAccess
{
    public class TicketRepository
    {
        private readonly ApplicationDbContext _context;

        // Dependency Injection: Menerima DbContext
        public TicketRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // =========================================================
        // Standard CRUD Operations
        // =========================================================

        // C - CREATE (Menambah Tiket Baru/Mencatat Penjualan)
        public async Task<Ticket> AddAsync(Ticket ticket)
        {
            await _context.Tickets.AddAsync(ticket);
            await _context.SaveChangesAsync();
            return ticket;
        }

        // R - READ BY ID
        public async Task<Ticket> GetByIdAsync(int id)
        {
            return await _context.Tickets.FindAsync(id);
        }

        // R - READ ALL (Mengambil Semua Tiket beserta detail Konser dan Pembeli)
        public async Task<List<Ticket>> GetAllWithDetailsAsync()
        {
            // Menggunakan Eager Loading (.Include) untuk memuat data relasi
            // Ini diperlukan agar Frm_ManageTickets bisa menampilkan Nama Konser dan Nama Pembeli
            return await _context.Tickets
                                 .Include(t => t.Concert) // Load data Konser
                                 .Include(t => t.Account) // Load data Pembeli/Account
                                 .ToListAsync();
        }

        // U - UPDATE (Digunakan terutama untuk mengubah Status Tiket)
        public async Task UpdateAsync(Ticket ticket)
        {
            _context.Tickets.Update(ticket);
            await _context.SaveChangesAsync();
        }

        // D - DELETE
        public async Task DeleteAsync(Ticket ticket)
        {
            _context.Tickets.Remove(ticket);
            await _context.SaveChangesAsync();
        }

        // =========================================================
        // Business Logic Helper Methods
        // =========================================================

        // Helper: Mencari tiket berdasarkan Kode Unik/Barcode
        public async Task<Ticket> GetByTicketCodeAsync(string ticketCode)
        {
            return await _context.Tickets
                                 .FirstOrDefaultAsync(t => t.TicketCode == ticketCode);
        }

        // Helper: Mendapatkan total tiket terjual untuk konser tertentu
        public async Task<int> CountSoldTicketsAsync(int concertId)
        {
            return await _context.Tickets
                                 .CountAsync(t => t.ConcertId == concertId);
        }
    }
}
