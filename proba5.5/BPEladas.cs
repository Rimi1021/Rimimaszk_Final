using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using System.IO;
using System.Data.SqlClient;

namespace proba5._5
{
    public partial class BPEladas : UserControl, IEladas
    {
        public BPEladas()
        {
            InitializeComponent();
            AdminRaktar.Tisztalista();
        }
        private static bool vanilyenbarcode = false;
        private static string MaszktipusEladas = "";
        private static string MaszknevEladas = "";
        private static int MaxFelvihetoOsszeg = 0;
        private static int Felvittdb = 0;
        private static string telephelyarudb = "keszletarubudapest";

        // A listbox alatt lévő labelhez tartozik az összes áru nettó és bruttó(Ha van akció akkor azzal szamol) osszege
        private static double Nettoosszeg = 0;
        private static double Bruttoosszeg = 0;


        /// Encode Decode gombok
        #region Encode Decode buttonok
        private void button_Encode_Click(object sender, EventArgs e)
        {
            Encode(textBox_Encode, textBox_Kosarba, pictureBox_Barcode);
        }

        private void button_Decode_Click(object sender, EventArgs e)
        {
            Decode(textBox_Decode, textBox_Kosarba, pictureBox_Barcode);
        }
        #endregion

        ///Kosárba tevés melletti textboxBarcode vizsgálat
        private void textBox_Kosarba_TextChanged(object sender, EventArgs e)
        {
           /* for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
            {
                if (SzerverData.MaszInfokOsszes[i].Barcode == textBox_Kosarba.Text)
                {
                    label_akcio.Text = "Akció:" + Convert.ToString(SzerverData.MaszInfokOsszes[i].Akcio) + "%";
                    vanilyenbarcode = true;
                    label_Adottarubrutto.Text = Convert.ToString(AdminArAkcio.Brutto(SzerverData.MaszInfokOsszes[i].Ar_db)) + " Ft";
                    if (SzerverData.MaszInfokOsszes[i].Akcio != 0)
                    {
                        label_Adottarubruttoakcio.Text = Convert.ToString(AdminArAkcio.akcio(AdminArAkcio.Brutto(SzerverData.MaszInfokOsszes[i].Ar_db), SzerverData.MaszInfokOsszes[i].Akcio)) + " Ft";
                    }
                    else
                    {
                        label_Adottarubruttoakcio.Text = "Nincs akció";
                    }
                }
            }
            if (vanilyenbarcode == false && textBox_Kosarba.Text != "")
            {
                MessageBox.Show("Nem létezik ilyen vonalkód, használja a manuális termékkiválasztás opciót");
                textBox_Decode.Text = "";
                textBox_Encode.Text = "";
                textBox_Kosarba.Text = "";
            }*/
            // Kosarevent(TextBox kosatextbx,TextBox encode,TextBox decode,bool vaneilyenbarcode, Label akcio, Label adottbrutto, Label adottbruttoakcio)
            Kosarevent(textBox_Kosarba, textBox_Encode, textBox_Decode, label_akcio, label_Adottarubrutto, label_Adottarubruttoakcio);
        }

        private void comboBox_Maszktipus_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaszknevEladas = "";
            comboboxitemchanges(comboBox_Maszktipus, comboBox_Maszknev);
            MaszktipusEladas = comboBox_Maszktipus.SelectedItem.ToString();
        }


        //Combobox fuggveny
        #region ComboBOX fugveny
        public static void comboboxitemchanges(ComboBox maszktipuscombobx, ComboBox maszknevcombobx)
        {
            if (maszktipuscombobx.SelectedIndex == 0)
            {
                maszknevcombobx.Items.Clear();
                maszknevcombobx.Items.Add("Kek");
                maszknevcombobx.Items.Add("Terepmintas");
                maszknevcombobx.Items.Add("Zold");
                maszknevcombobx.Items.Add("Fekete");
                maszknevcombobx.Items.Add("Piros");
                maszknevcombobx.Items.Add("Feher");

                maszknevcombobx.Text = "Maszknév";
            }
            else if (maszktipuscombobx.SelectedIndex == 1)
            {
                maszknevcombobx.Items.Clear();
                maszknevcombobx.Items.Add("Kek");
                maszknevcombobx.Items.Add("Rozsaszin");
                maszknevcombobx.Items.Add("Zold");
                maszknevcombobx.Items.Add("Fekete");
                maszknevcombobx.Items.Add("Sarga");
                maszknevcombobx.Items.Add("Feher");

                maszknevcombobx.Text = "Maszknév";
            }
            else if (maszktipuscombobx.SelectedIndex == 2)
            {
                maszknevcombobx.Items.Clear();
                maszknevcombobx.Items.Add("Kek");
                maszknevcombobx.Items.Add("Terepmintas");
                maszknevcombobx.Items.Add("Zold");
                maszknevcombobx.Items.Add("Fekete");
                maszknevcombobx.Items.Add("Sarga");
                maszknevcombobx.Items.Add("Feher");

                maszknevcombobx.Text = "Maszknév";
            }
            else if (maszktipuscombobx.SelectedIndex == 3)
            {
                maszknevcombobx.Items.Clear();
                maszknevcombobx.Items.Add("Kek");
                maszknevcombobx.Items.Add("Terepmintas");
                maszknevcombobx.Items.Add("Zold");
                maszknevcombobx.Items.Add("Fekete");
                maszknevcombobx.Items.Add("Sarga");
                maszknevcombobx.Items.Add("Feher");

                maszknevcombobx.Text = "Maszknév";
            }
            else if (maszktipuscombobx.SelectedIndex == 4)
            {
                maszknevcombobx.Items.Clear();
                maszknevcombobx.Items.Add("Kek");
                maszknevcombobx.Items.Add("Hupikek");
                maszknevcombobx.Items.Add("Zold");
                maszknevcombobx.Items.Add("Fekete");
                maszknevcombobx.Items.Add("Rozsaszin");
                maszknevcombobx.Items.Add("Feher");

                maszknevcombobx.Text = "Maszknév";
            }
            else
            {
                maszknevcombobx.Items.Clear();
                maszknevcombobx.Items.Add("Marvel");
                maszknevcombobx.Items.Add("DC");
                maszknevcombobx.Items.Add("Frozen");
                maszknevcombobx.Items.Add("Csipkes");
                maszknevcombobx.Items.Add("Shrek");
                maszknevcombobx.Items.Add("Memes");

                maszknevcombobx.Text = "Maszknév";
            }
        }
        #endregion


        // db text event
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (AdminRaktar.rg.IsMatch(textBox1.Text))
            {
                Felvittdb = Convert.ToInt32(textBox1.Text);
            }
        }

        private void comboBox_Maszknev_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaszknevEladas = comboBox_Maszknev.SelectedItem.ToString();
        }

        //Manuális hozzáadás gomb
        private void button_Hozzaadas_Click(object sender, EventArgs e)
        {
            Manualishozzaadasgomb(MaszktipusEladas, MaszknevEladas, MaxFelvihetoOsszeg, Felvittdb, textBox1, listBox_Kosar, label_Osszesar, label_Osszesbrutto);
        }

        //Lista osszes elem torlese es a kijelző elemek és az osszeg számlálók 0-ázása
        private void button_Torle_Click(object sender, EventArgs e)
        {
            Listboxelemektorles(listBox_Kosar, label_Osszesar, label_Osszesbrutto, textBox1);
        }

        private void button_Hozzaadas2_Click(object sender, EventArgs e)
        {
            /* System.Diagnostics.Debug.WriteLine(vanilyenbarcode);
             if (vanilyenbarcode == true)
             {
                 for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                 {
                     if (SzerverData.MaszInfokOsszes[i].Barcode == textBox_Kosarba.Text)
                     {
                         listBox_Kosar.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].Ar_db}Ft; {SzerverData.MaszInfokOsszes[i].Akcio}%; {SzerverData.MaszInfokOsszes[i].Barcode}");
                         vanilyenbarcode = false;
                         pictureBox_Barcode.Image = null;
                         textBox_Encode.Text = "";
                         textBox_Decode.Text = "";
                         textBox_Kosarba.Text = "";
                         label_Adottarubrutto.Text = "";
                         label_Adottarubruttoakcio.Text = "";
                         label_Osszesar.Text = Convert.ToString(Nettoosszeg + SzerverData.MaszInfokOsszes[i].Ar_db);
                         Nettoosszeg = Convert.ToInt32(label_Osszesar.Text);
                         double bruttoar = Aruvisszavetel.Brutto(SzerverData.MaszInfokOsszes[i].Ar_db);
                         Bruttoosszeg += Aruvisszavetel.akcio(bruttoar, SzerverData.MaszInfokOsszes[i].Akcio);
                         label_Osszesbrutto.Text = Convert.ToString(Bruttoosszeg);
                         label_akcio.Text = "Akció:";
                     }
                 }
             }
             else
             {
                 MessageBox.Show("Nincs ilyen termék! Rossz Vonalkód!");
             }*/
            TermekHozzadas2(textBox_Kosarba, textBox_Encode, textBox_Decode, listBox_Kosar, pictureBox_Barcode
             , label_Adottarubrutto, label_Adottarubruttoakcio, label_Osszesar, label_Osszesbrutto, label_akcio);
        }

        private void button_Elad_Click(object sender, EventArgs e)
        {
             /*List<string> vonalkodok = new List<string>();
             for (int i = 0; i < listBox_Kosar.Items.Count; i++)
             {
                 string Sor = (string)listBox_Kosar.Items[i];
                 string[] SorElemek = Sor.Split(';');
                 vonalkodok.Add(SorElemek[4]);
             }
             for (int i = 0; i < vonalkodok.Count; i++)
             {
                 //System.Diagnostics.Debug.WriteLine(vonalkodok[i]);
                 for (int j = 0; j < SzerverData.MaszInfokOsszes.Count; j++)
                 {
                     if (SzerverData.MaszInfokOsszes[j].Barcode == vonalkodok[i].Trim())
                     {
                         try
                         {
                             using (SqlConnection Csatlakozas = new SqlConnection(SzerverData.SzerverInfoAdmin))
                             {
                                 string Feltoltes = $"UPDATE MaszkAruk SET keszletarubudapest = keszletarubudapest - 1 WHERE barcode = '{vonalkodok[i].Trim()}'"; //Adatok feltöltése
                                 using (SqlCommand Parancs = new SqlCommand(Feltoltes, Csatlakozas))
                                 {
                                     Csatlakozas.Open(); //Csatlakozási folyamat megnyitása
                                     var result = Parancs.ExecuteNonQuery();
                                     Parancs.Dispose();
                                     // Hiba keresés, ha nem lett eredmény
                                     if (result < 0)
                                     { MessageBox.Show("Hiba az adatfeltöltés során!"); } //Hibaüzenet
                                     MessageBox.Show("Az eladás megtörtént!"); //Sikeres feltöltés esetén megjelenő üzenet
                                     Csatlakozas.Close(); //Csatlakozási folyamat lezárása
                                 }
                             }
                         }
                         catch (Exception) //Kivétel megadása, ha a try részben lévő kód nem fut le.
                         { MessageBox.Show("Nem sikerült a csalakozás"); }
                     }
                 }
             }
            Raktar.Tisztalista();
            listBox_Kosar.Items.Clear();*/
            EladasGombfuggveny(listBox_Kosar, telephelyarudb);
            Nettoosszeg = 0;
            label_Osszesar.Text = "0Ft";
            Bruttoosszeg = 0;
            label_Osszesbrutto.Text = "0Ft";
            textBox1.Text = "0";
        }

        private void listBox_Kosar_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"Nettóösszeg: {Nettoosszeg}");
            if (listBox_Kosar.SelectedItem != null) //Ha van kiválasztva lista item a dupla klikkeléskor
            {
                MessageBox.Show(listBox_Kosar.SelectedItem.ToString()); //Kiíratom a kijelölt listaelem adatait
                if (MessageBox.Show("Biztosan töli az elemet?", "Elem törlése kosárból", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string vonalkod = "";

                    string Sor = listBox_Kosar.SelectedItem.ToString();
                    string[] SorElemek = Sor.Split(';');
                    vonalkod = (SorElemek[4]);
                    for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                    {
                        if (vonalkod.Trim() == SzerverData.MaszInfokOsszes[i].Barcode)
                        {
                            SzerverData.MaszInfokOsszes[i].KeszletraktarBudapest += 1;
                            Nettoosszeg = Nettoosszeg - SzerverData.MaszInfokOsszes[i].Ar_db;
                            label_Osszesar.Text = Convert.ToString(Nettoosszeg);
                            double bruttoar = AdminArAkcio.Brutto(SzerverData.MaszInfokOsszes[i].Ar_db);
                            Bruttoosszeg = Bruttoosszeg - AdminArAkcio.akcio(bruttoar, SzerverData.MaszInfokOsszes[i].Akcio);
                            label_Osszesbrutto.Text = Convert.ToString(Bruttoosszeg);
                        }
                    }

                    listBox_Kosar.Items.Remove(listBox_Kosar.SelectedItem);
                }
                else
                {
                    return;
                }

            }
            else //Különben eset, ha az elem üres lenne
            {
                MessageBox.Show("Nincs kijelölt elem!"); //Hiba visszajelzése, ha üres az elem
            }
        }




        ///Fuggvenzek
        ///
        ///
        //Encode button
        public static void  Encode(TextBox encode,TextBox kosarba, PictureBox picbox)
        {
            try
            {
                BarcodeWriter writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
                if (encode.Text != "")
                {
                    picbox.Image = writer.Write(encode.Text);
                    kosarba.Text = encode.Text;
                }
                else
                {
                    MessageBox.Show("Nincs Kódolandó vonalkód!");
                    picbox.Image = null;
                    kosarba.Text = "";
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Nem található vonalkód");
            }
        }

        //Decode button
        public static void Decode(TextBox decode, TextBox kosarba, PictureBox picbox) 
        {
            BarcodeReader reader = new BarcodeReader();
            if (picbox.Image != null)
            {
                var result = reader.Decode((Bitmap)picbox.Image);
                if (result != null)
                {
                    decode.Text = result.Text;
                    kosarba.Text = decode.Text;
                }
            }
            else
            {
                MessageBox.Show("Nincs Dekódolandó vódolandó vonalkód!");
                kosarba.Text = "";
                decode.Text = "";
            }
        }

        //Kosarbateves textchange event
       public void Kosarevent(TextBox kosatextbx,TextBox encode,TextBox decode, Label akcio, Label adottbrutto, Label adottbruttoakcio) 
        {
            for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
            {
                if (SzerverData.MaszInfokOsszes[i].Barcode == kosatextbx.Text)
                {
                    akcio.Text = "Akció:" + Convert.ToString(SzerverData.MaszInfokOsszes[i].Akcio) + "%";
                    vanilyenbarcode = true;
                    adottbrutto.Text = Convert.ToString(AdminArAkcio.Brutto(SzerverData.MaszInfokOsszes[i].Ar_db)) + " Ft";
                    if (SzerverData.MaszInfokOsszes[i].Akcio != 0)
                    {
                        adottbruttoakcio.Text = Convert.ToString(AdminArAkcio.akcio(AdminArAkcio.Brutto(SzerverData.MaszInfokOsszes[i].Ar_db), SzerverData.MaszInfokOsszes[i].Akcio)) + " Ft";
                    }
                    else
                    {
                        adottbruttoakcio.Text = "Nincs akció";
                    }
                }
            }
            if (vanilyenbarcode == false && kosatextbx.Text != "")
            {
                MessageBox.Show("Nem létezik ilyen vonalkód, használja a manuális termékkiválasztás opciót");
                decode.Text = "";
                encode.Text = "";
                kosatextbx.Text = "";
            }
       }

        //Manualis hozzaadas Gomb
        //
        public void Manualishozzaadasgomb(string maszktipus, string maszknev, int max,int felvihetodb, TextBox textbxdb, ListBox kosar, Label osszesar, Label osszesbrutto) 
        {
            for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
            {
                if (SzerverData.MaszInfokOsszes[i].Maszktipus == maszktipus && SzerverData.MaszInfokOsszes[i].Maszknev == maszknev)
                {
                    max = Convert.ToInt32(SzerverData.MaszInfokOsszes[i].KeszletraktarBudapest);
                }
            }

            if (maszktipus != "" && maszknev != "")
            {
                if (AdminRaktar.rg.IsMatch(textbxdb.Text) && felvihetodb <= max)
                {
                    for (int i = 0; i < felvihetodb; i++)
                    {
                        for (int j = 0; j < SzerverData.MaszInfokOsszes.Count; j++)
                        {
                            if (SzerverData.MaszInfokOsszes[j].Maszktipus == maszktipus && SzerverData.MaszInfokOsszes[j].Maszknev == maszknev)
                            {
                                kosar.Items.Add($"{SzerverData.MaszInfokOsszes[j].Maszktipus}; {SzerverData.MaszInfokOsszes[j].Maszknev}; {SzerverData.MaszInfokOsszes[j].Ar_db}Ft; {SzerverData.MaszInfokOsszes[j].Akcio}%; {SzerverData.MaszInfokOsszes[j].Barcode}");
                                max = max - 1;
                                SzerverData.MaszInfokOsszes[j].KeszletraktarBudapest = max;
                                osszesar.Text = Convert.ToString(Nettoosszeg + SzerverData.MaszInfokOsszes[j].Ar_db);
                                Nettoosszeg = Convert.ToInt32(osszesar.Text);
                                double bruttoar = AdminArAkcio.Brutto(SzerverData.MaszInfokOsszes[j].Ar_db);
                                Bruttoosszeg += AdminArAkcio.akcio(bruttoar, SzerverData.MaszInfokOsszes[j].Akcio);
                                osszesbrutto.Text = Convert.ToString(Bruttoosszeg);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Csak számot írhat a darabszámhoz és az eladottt darabszám nem haladhatja meg a a készletmennyiséget");
                }
            }
            else
            {
                MessageBox.Show("Válassza ki a termék típusát és a nevét");
            }
        }

        //Button hozzaadas2 Gomb
        public void TermekHozzadas2(TextBox kosartxt,TextBox encode, TextBox decode, ListBox listbx, PictureBox picbox
            ,Label adottbrutto, Label adottbruttoakcio, Label osszesar, Label osszesbrutto, Label akcio) 
        {
            if (vanilyenbarcode == true)
            {
                for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                {
                    if (SzerverData.MaszInfokOsszes[i].Barcode == kosartxt.Text)
                    {
                        if (SzerverData.MaszInfokOsszes[i].KeszletraktarBudapest > 0)
                        {
                            listbx.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].Ar_db}Ft; {SzerverData.MaszInfokOsszes[i].Akcio}%; {SzerverData.MaszInfokOsszes[i].Barcode}");
                            vanilyenbarcode = false;
                            picbox.Image = null;
                            encode.Text = "";
                            decode.Text = "";
                            kosartxt.Text = "";
                            adottbrutto.Text = "";
                            adottbruttoakcio.Text = "";
                            SzerverData.MaszInfokOsszes[i].KeszletraktarBudapest = SzerverData.MaszInfokOsszes[i].KeszletraktarBudapest - 1;
                            osszesar.Text = Convert.ToString(Nettoosszeg + SzerverData.MaszInfokOsszes[i].Ar_db);
                            Nettoosszeg = Convert.ToInt32(osszesar.Text);
                            double bruttoar = AdminArAkcio.Brutto(SzerverData.MaszInfokOsszes[i].Ar_db);
                            Bruttoosszeg += AdminArAkcio.akcio(bruttoar, SzerverData.MaszInfokOsszes[i].Akcio);
                            osszesbrutto.Text = Convert.ToString(Bruttoosszeg);
                            akcio.Text = "Akció:";
                        }
                        else
                        {
                            MessageBox.Show("Nincs raktáron elegendő termék","Hiánycikk", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nincs ilyen termék! Rossz Vonalkód!");
            }
        }

        //listabox elemek ürítése
        public void Listboxelemektorles(ListBox listbx, Label osszesar, Label osszesbrutto, TextBox txtbxdb) 
        {
            AdminRaktar.Tisztalista();
            listbx.Items.Clear();
            Nettoosszeg = 0;
            osszesar.Text = "0Ft";
            Bruttoosszeg = 0;
            osszesbrutto.Text = "0Ft";
            txtbxdb.Text = "0";
        }

        //Eladas GOMB

        public  void EladasGombfuggveny(ListBox listabox,string keszletarutelephely) 
        {
            List<string> vonalkodok = new List<string>();
            for (int i = 0; i < listabox.Items.Count; i++)
            {
                string Sor = (string)listabox.Items[i];
                string[] SorElemek = Sor.Split(';');
                vonalkodok.Add(SorElemek[4]);
            }
            for (int i = 0; i < vonalkodok.Count; i++)
            {
                //System.Diagnostics.Debug.WriteLine(vonalkodok[i]);
                for (int j = 0; j < SzerverData.MaszInfokOsszes.Count; j++)
                {
                    if (SzerverData.MaszInfokOsszes[j].Barcode == vonalkodok[i].Trim())
                    {
                        try
                        {
                            using (SqlConnection Csatlakozas = new SqlConnection(SzerverData.SzerverInfoAdmin))
                            {
                                string Feltoltes = $"UPDATE MaszkAruk SET {keszletarutelephely} = {keszletarutelephely} - 1 WHERE barcode = '{vonalkodok[i].Trim()}'"; //Adatok feltöltése
                                using (SqlCommand Parancs = new SqlCommand(Feltoltes, Csatlakozas))
                                {
                                    Csatlakozas.Open(); //Csatlakozási folyamat megnyitása
                                    var result = Parancs.ExecuteNonQuery();
                                    Parancs.Dispose();
                                    // Hiba keresés, ha nem lett eredmény
                                    if (result < 0)
                                    { MessageBox.Show("Hiba az adatfeltöltés során!"); } //Hibaüzenet
                                    //Sikeres feltöltés esetén megjelenő üzenet
                                    Csatlakozas.Close(); //Csatlakozási folyamat lezárása
                                }
                            }
                        }
                        catch (Exception) //Kivétel megadása, ha a try részben lévő kód nem fut le.
                        { MessageBox.Show("Nem sikerült a csalakozás"); }
                    }
                }
            }
            MessageBox.Show("Az eladás megtörtént!");
            AdminRaktar.Tisztalista();
            listabox.Items.Clear();
        }
    }
}
