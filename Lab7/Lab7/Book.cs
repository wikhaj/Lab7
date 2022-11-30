using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    [Serializable]
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Status { get; set; } // dostępna, wypożyczona
        public string User { get; set; } // imienazwisko

    }
}
