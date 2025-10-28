using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS_ConcertTicket.Models
{
    public class Account
    {
       //primary key account
       public int Id { get; set; }
        //data untuk account
        public string Username { get; set; }

        //password 
        public string PasswordHash { get; set; }

        public string FullName {  get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        //fungsi orm untuk mengetahui account yang memiliki tiket
        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
