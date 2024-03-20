using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Gazda
    {
        public int Id { get; set; }
        public string Nev { get; set; }
        public ICollection<Pet> Pet { get; } = new List<Pet>();

        public Gazda()
        {
        }
        public Gazda(string nev)
        {
            Nev = nev;
        }

        public override string? ToString()
        {
            string s = Nev + " (";
            foreach (var pet in Pet)
            {
                s += pet + ", ";
            }
            return s + ")";
        }
    }
}
