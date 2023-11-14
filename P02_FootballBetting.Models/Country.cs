using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_FootballBetting.Models
{
    public class Country
    {
        public Country()
        {
            Towns = new HashSet<Town>();
        }
        public int CountryId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Town> Towns { get; set; }
    }
}
