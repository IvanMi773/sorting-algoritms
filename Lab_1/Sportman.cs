using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    [Serializable]
    class Sportman
    {
        public String firstName { get; set; }
        public String kindOfSport { get; set; }
        public int yearOfBorn { get; set; }

        public Sportman(string firstName, int yearOfBorn, string kindOfSport)
        {
            this.firstName = firstName;
            this.kindOfSport = kindOfSport;
            this.yearOfBorn = yearOfBorn;
        }
    }
}
