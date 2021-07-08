using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proba5._5
{
    class MaszkAruk
    {
        private string _Maszknev;
        private string _Maszktipus;
        private int _KeszletraktarBudapest;
        private int _KeszletraktarGyor;
        private int _KeszletraktarDebrecen;
        private double _Ar_db;
        private double _Akcio;
        private int _Id;
        private string _Barcode;
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

        public string Maszktipus
        {
            get 
            {
                return _Maszktipus;
            }
            set 
            {
                if (value.Length <= 30) _Maszktipus = value;
                else throw new Exception("A mező maximum 30 karakter hosszú lehet!");
            }
        }
        public string Maszknev
        {
            get
            {
                return _Maszknev;
            }
            set
            {
                if (value.Length <= 30) _Maszknev = value;
                else throw new Exception("A mező maximum 30 karakter hosszú lehet!");
            }
        }

        public int KeszletraktarBudapest
        {
            get
            {
                return _KeszletraktarBudapest;
            }
            set
            {
                if (value >= 0 && value <= 10000000) _KeszletraktarBudapest = value;
                else throw new Exception("A maxertek 10000000 A minertek 0");
            }
        }

        public int KeszletraktarGyor
        {
            get
            {
                return _KeszletraktarGyor;
            }
            set
            {
                if (value >= 0 && value <= 100000000) _KeszletraktarGyor = value;
                else throw new Exception("A maxertek 10000000 A minertek 0");
            }
        }

        public int KeszletraktarDebrecen
        {
            get
            {
                return _KeszletraktarDebrecen;
            }
            set
            {
                if (value >= 0 && value <= 100000000) _KeszletraktarDebrecen = value;
                else throw new Exception("A maxertek 10000000 A minertek 0");
            }
        }

        public double Ar_db
        {
            get
            {
                return _Ar_db;
            }
            set
            {
                if (value >= 50 && value <= 50000) _Ar_db = value;
                else throw new Exception("A Maszk erteke 50 es 50000 k0ze eshet!");
            }
        }

        public double Akcio
        {
            get
            {
                return _Akcio;
            }
            set
            {
                if (value >= 0 && value <= 99) _Akcio = value;
                else throw new Exception("Az akció 0-99 értéket vehet fel!");
            }
        }

        public string Barcode
        {
            get
            {
                return _Barcode;
            }
            set
            {
                if (value.Length <= 15) _Barcode = value;
                else throw new Exception("A mező max 15 karakter hosszú lehet!");
            }
        }
        public MaszkAruk(int Id, string Maszktipus, string Maszknev, int KeszletraktarBudapest, int KeszletraktarGyor, int KeszletraktarDebrecen, double Ar_db, double Akcio, string barcode)
        {
            this.Id = Id;
            this.Maszktipus = Maszktipus;
            this.Maszknev = Maszknev;
            this.KeszletraktarBudapest = KeszletraktarBudapest;
            this.KeszletraktarGyor = KeszletraktarGyor;
            this.KeszletraktarDebrecen = KeszletraktarDebrecen;
            this.Ar_db = Ar_db;
            this.Akcio = Akcio;
            this.Barcode = barcode;
        }
    }
}
