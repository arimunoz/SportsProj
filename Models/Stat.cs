using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsProj.Models
{
    public class Stat
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StatID { get; set; }
        public string statName { get; set; }


        public ICollection<Teams> Teams { get; set; }
    }
}
