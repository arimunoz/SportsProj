using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SportsProj.Models
{
    public enum StatValues
    {
        A, B, C, D, F
    }
    public class Teams
    {
        public int TeamsID { get; set; }
        public int PlayerID { get; set; }
        public int StatID { get; set; }
        public StatValues? StatValues { get; set; }

        public Player Player { get; set; }
        public Stat Stat { get; set; }
    }
}
