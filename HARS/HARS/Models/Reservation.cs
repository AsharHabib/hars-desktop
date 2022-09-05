using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HARS.Models
{
    internal class Reservation
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public string reservationJSON { get; set; }
        public string namesJSON { get; set; }
    }
}
