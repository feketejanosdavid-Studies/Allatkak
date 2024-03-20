using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Nev { get; set; }
        public string Faj { get; set; }
        public int Kor { get; set; }
        public int GazdaId { get; set; }
        public Pet() { }

        public Pet(string sor)
        {
            string[] t = sor.Split(';');

            Nev = t[0];
            Faj = t[1];
            Kor = Convert.ToInt32(t[2]);
            GazdaId = Convert.ToInt32(t[3]);
        }

        public override string? ToString() {
            return $"A nevem {Nev}, {Faj}, aki {Kor} éves";
        }
    }
}
