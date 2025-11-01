using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTS_ConcertTicket.DataAccess;
using UTS_ConcertTicket.Models;

namespace UTS_ConcertTicket.BusinessLogic
{
    public class TicketService
    {
        private readonly TicketRepository _ticketRepository;
        private readonly ConcertRepository _concertRepository; // Diperlukan untuk filter konser

        // Dependency Injection: Service menerima Repository
        public TicketService(TicketRepository ticketRepository, ConcertRepository concertRepository)
        {
            _ticketRepository = ticketRepository;
            _concertRepository = concertRepository;
        }

        /// <summary>
        /// Mengambil semua tiket beserta detail Konser dan Akun (untuk tampilan admin).
        /// </summary>
        public async Task<List<Ticket>> GetTicketsWithDetailsAsync()
        {
            // Panggil Repository untuk mendapatkan data tiket dengan JOIN (Include)
            // Asumsi TicketRepository memiliki method GetAllWithDetailsAsync()
            return await _ticketRepository.GetAllWithDetailsAsync();
        }

        /// <summary>
        /// Mengupdate status klaim tiket.
        /// </summary>
        /// <param name="ticketId">ID Tiket yang akan diupdate.</param>
        /// <param name="newStatus">Status baru (misalnya "Terklaim", "Dibatalkan").</param>
        public async Task UpdateTicketStatusAsync(int ticketId, string newStatus)
        {
            if (string.IsNullOrWhiteSpace(newStatus))
            {
                throw new ArgumentException("Status tiket tidak boleh kosong.");
            }

            var ticket = await _ticketRepository.GetByIdAsync(ticketId);

            if (ticket == null)
            {
                throw new KeyNotFoundException($"Tiket dengan ID {ticketId} tidak ditemukan.");
            }

            // Logika Bisnis: Mencegah perubahan status ke 'Terklaim' jika sudah dibatalkan
            if (ticket.Status == "Dibatalkan" && newStatus == "Terklaim")
            {
                throw new InvalidOperationException("Tiket yang sudah dibatalkan tidak bisa diklaim.");
            }

            // Logika Bisnis: Jika status diubah menjadi 'Terklaim'/'Used', catat waktunya (opsional)
            if (newStatus == "Terklaim" && ticket.Status != "Terklaim")
            {
                // Tambahkan properti LastClaimDate di model Ticket jika ini diperlukan
                // ticket.LastClaimDate = DateTime.Now; 
            }

            ticket.Status = newStatus;
            await _ticketRepository.UpdateAsync(ticket);
        }

        /// <summary>
        /// Mengambil daftar Konser hanya untuk keperluan filter di UI.
        /// </summary>
        public async Task<List<Concert>> GetConcertsForFilterAsync()
        {
            // Panggil ConcertRepository untuk mendapatkan daftar konser
            return await _concertRepository.GetAllAsync();
        }

        // Anda bisa menambahkan method lain di sini, seperti:
        // public async Task<Ticket> IssueNewTicketAsync(...) { ... }
        // public async Task DeleteTicketAsync(int ticketId) { ... }
    }
}
