using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proba5._5
{
    interface IEladas
    {

        /*
        * Ellenőrzi hogy jó e a megadott vonalkód ami a kosárba kerül encode gomb után
        */
        void Kosarevent(TextBox kosatextbx, TextBox encode, TextBox decode, Label akcio, Label adottbrutto, Label adottbruttoakcio);


        /*
       * A manualis termekkivalasztas utan hozzadaja a termeket a kosárhoz.
       */
        void Manualishozzaadasgomb(string maszktipus, string maszknev, int max, int felvihetodb, TextBox textbxdb, ListBox kosar, Label osszesar, Label osszesbrutto);

        /*
       * A kosár egy bizonyos elem törlése két katt után
       */
        void Listboxelemektorles(ListBox listbx, Label osszesar, Label osszesbrutto, TextBox txtbxdb);

        /*
       * A miután ecode/decode gombnyomás megtörtén és helyes a vonalkód, hozzáadja a terméket a kosárhoz
       */
        void TermekHozzadas2(TextBox kosartxt, TextBox encode, TextBox decode, ListBox listbx, PictureBox picbox, Label adottbrutto, Label adottbruttoakcio, Label osszesar, Label osszesbrutto, Label akcio);

        /*
        * A kosár tartalmának megfelelően elvesz az adatbázis_keszletaruból 1-et
        */
        void EladasGombfuggveny(ListBox listabox, string keszletarutelephely);

    }
}
