using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS_ConcertTicket.Models
{
    public class Concert
    {
        public int id { get; set; }
        //data concert
        public string NamaKonser { get; set; }
        public string Artis { get; set; }
        public DateTime TanggalWaktu { get; set; }
        public string Lokasi {  get; set; }
        public string HargaDasar {  get; set; }
        public string TotalPenonton { get; set; }
        public int StokTersedia { get; set; }
        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

    }
}
