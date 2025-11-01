using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS_ConcertTicket.Models
{
    public class Ticket
    {
        // Primary Key (Primary Key)
        [Key]
        public int Id { get; set; }

        // Foreign Keys (Kunci Asing)
        public int ConcertId { get; set; }
        public int AccountId { get; set; }

        // Properti Tiket
        [Required]
        [MaxLength(50)]
        public string TicketCode { get; set; } // Kode Unik/Barcode

        [MaxLength(50)]
        public string TicketCategory { get; set; } // Misalnya: VIP, Regular, Festival

        [Column(TypeName = "numeric(10, 2)")]
        public decimal PricePaid { get; set; } // Harga yang dibayarkan

        public DateTime SaleDate { get; set; } = DateTime.Now; // Tanggal penjualan/cetak

        [Required]
        [MaxLength(20)]
        public string Status { get; set; } = "Terjual"; // Status: Terjual, Terklaim, Dibatalkan

        // Navigation Properties (Relasi ORM)
        // Properti ini digunakan Entity Framework Core untuk mengambil data relasi (JOIN)

        // Relasi Many-to-One dengan Concert
        [ForeignKey("ConcertId")]
        public Concert Concert { get; set; }

        // Relasi Many-to-One dengan Account (Pembeli)
        [ForeignKey("AccountId")]
        public Account Account { get; set; }
    }
}
