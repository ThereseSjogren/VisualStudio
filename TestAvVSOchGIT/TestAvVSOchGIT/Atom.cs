using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAvVSOchGIT
{
    class Atom
    {
        private int Kula;

        public int kula
        {
            get { return Kula; }
            set { Kula = value; }
        }
        private int Antal;

        public int antal
        {
            get { return Antal; }
            set { Antal = value; }
        }
        public Atom() //Konstruktor
        {

        }
        public Atom(int kula, int antal) //konstruktor
        {
            this.Kula = kula;
            this.Antal = antal;
        }
    }
}
