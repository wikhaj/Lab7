using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    [Serializable]
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }    



        public User() { }
    }
}
