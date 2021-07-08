using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proba5._5
{
    class DolgozokAdmin
    {
        private int _Id;
        public int Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (value >= 0) _Id = value;
                else throw new Exception("A ID nem lehet negatív érték!");
            }
        }
        private string _Nev;
        public string Nev
        {
            get
            {
                return _Nev;
            }
            set
            {
                if (value.Length <= 30) _Nev = value;
                else throw new Exception("A mező maximum 30 karakter hosszú lehet!");
            }
        }
        private string _Jelszo;
        public string Jelszo
        {
            get
            {
                return _Jelszo;
            }
            set
            {
                if (value.Length >= 5) _Jelszo = value;
                else throw new Exception("A Jelszo nem lehet 5-nél kisebb érték!");
            }
        }

        public DolgozokAdmin(int Id, string nev, string jelszo)
        {
            this.Id = Id;
            this.Nev = nev;
            this.Jelszo = jelszo;
        }
    }
}
