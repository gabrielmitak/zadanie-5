using System;
using System.Linq;

namespace zadanie1krok1.Models
{
    public class Klient
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string Pesel { get; set; }
        public DateTime BirthYear { get; set; }
        public string Płeć { get; set; }
    }
}
