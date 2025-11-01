using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTS_ConcertTicket.DataAccess;
using UTS_ConcertTicket.Models;

namespace UTS_ConcertTicket.BusinessLogic
{
    public  class ConcertService
    {
        private readonly ConcertRepository _repository;

        // Dependency Injection: Service ini membutuhkan Repository untuk mengakses data
        public ConcertService(ConcertRepository repository)
        {
            _repository = repository;
        }

        // =========================================================
        // C - CREATE (Membuat Konser Baru)
        // =========================================================
        public async Task<Concert> CreateConcertAsync(Concert newConcert)
        {
            // 1. Validasi Bisnis Dasar
            if (string.IsNullOrWhiteSpace(newConcert.NamaKonser))
            {
                throw new ArgumentException("Nama Konser wajib diisi.");
            }
            if (newConcert.HargaDasar <= 0)
            {
                throw new ArgumentException("Harga dasar tiket harus lebih besar dari nol.");
            }
            if (newConcert.TotalPenonton <= 0)
            {
                throw new ArgumentException("Total Stok tiket harus lebih besar dari nol.");
            }
            if (newConcert.TanggalWaktu < DateTime.Now)
            {
                throw new InvalidOperationException("Tanggal dan waktu konser tidak boleh di masa lalu.");
            }

            // 2. Logika Bisnis: Set Stok Tersedia
            // Saat pertama dibuat, Stok Tersedia harus sama dengan Total Stok
            newConcert.StokTersedia = newConcert.TotalPenonton;

            // 3. Simpan melalui Repository
            return await _repository.AddAsync(newConcert);
        }

        // =========================================================
        // R - READ Operations
        // =========================================================
        public async Task<List<Concert>> GetAllConcertsAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Concert> GetConcertByIdAsync(int id)
        {
            var concert = await _repository.GetByIdAsync(id);
            if (concert == null)
            {
                throw new KeyNotFoundException($"Konser dengan ID {id} tidak ditemukan.");
            }
            return concert;
        }

        // =========================================================
        // U - UPDATE (Memperbarui Konser)
        // =========================================================
        public async Task UpdateConcertAsync(Concert concertToUpdate)
        {
            var existingConcert = await _repository.GetByIdAsync(concertToUpdate.Id);
            if (existingConcert == null)
            {
                throw new KeyNotFoundException("Konser tidak ditemukan.");
            }

            // 1. Validasi Stok (Logika Bisnis Kritis)
            // Kita tidak boleh mengurangi TotalStok di bawah jumlah tiket yang sudah terjual
            int soldTickets = existingConcert.TotalPenonton - existingConcert.StokTersedia;

            if (concertToUpdate.TotalPenonton < soldTickets)
            {
                throw new InvalidOperationException($"Total stok baru ({concertToUpdate.TotalPenonton}) tidak boleh kurang dari jumlah tiket yang sudah terjual ({soldTickets}).");
            }

            // 2. Update Data Dasar
            existingConcert.NamaKonser = concertToUpdate.NamaKonser;
            existingConcert.Artis = concertToUpdate.Artis;
            existingConcert.TanggalWaktu = concertToUpdate.TanggalWaktu;
            existingConcert.Lokasi = concertToUpdate.Lokasi;
            existingConcert.HargaDasar = concertToUpdate.HargaDasar;

            // 3. Update Stok Tersedia berdasarkan Total Stok yang baru
            existingConcert.TotalPenonton = concertToUpdate.TotalPenonton;
            existingConcert.StokTersedia = concertToUpdate.TotalPenonton - soldTickets;

            // 4. Simpan perubahan melalui Repository
            await _repository.UpdateAsync(existingConcert);
        }

        // =========================================================
        // D - DELETE (Menghapus Konser)
        // =========================================================
        public async Task DeleteConcertAsync(int concertId)
        {
            var concert = await _repository.GetByIdAsync(concertId);
            if (concert == null) return;

            // Aturan Bisnis: Tidak bisa hapus konser jika sudah ada tiket yang terjual
            if (await _repository.HasTicketsAsync(concertId)) // Asumsi: Repository memiliki metode HasTicketsAsync()
            {
                throw new InvalidOperationException("Konser tidak dapat dihapus karena sudah ada transaksi tiket yang tercatat.");
            }

            await _repository.DeleteAsync(concert);
        }
    }
}
