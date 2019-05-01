using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsProj.Models
{
    public class Player
    {
        public int PlayerID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Team { get; set; }
        //public string Position { get; set; }


        public ICollection<Teams> Teams { get; set; }
    }
}
