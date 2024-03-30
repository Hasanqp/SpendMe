using System;
using System.Collections.Generic;
using System.Text;

namespace SpendMe.Core
{
    public class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Details { get; set; }
        public double Balance { get; set; }
        public DateTime AddedDAte { get; set; }

        // Navigations
        public virtual List<Outcome> outcome { get; set; }
    }
}
