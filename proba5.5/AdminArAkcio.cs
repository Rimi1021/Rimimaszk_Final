using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proba5._5
{
    public partial class AdminArAkcio : UserControl
    {
        public AdminArAkcio()
        {
            InitializeComponent();
        }
        private static string maszktipus = "";
        const double ADO_KULCS = 0.27;
        
        //ComboboxSelectItem
        #region combobox selectItem
        private void comboBox_Maszktipus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Maszktipus.SelectedIndex == 0) //gaymasyk/
            {
                // maszknev label beallitasok
                label_maszknev1.Text = "Kek";
                label_maszknev2.Text = "Terepmintas";
                label_maszknev3.Text = "Zold";
                label_maszknev4.Text = "Fekete";
                label_maszknev5.Text = "Piros";
                label_maszknev6.Text = "Feher";

                // maszktipus elmentese kesobbi keresesre
                maszktipus = "Gazmaszk";

                // Adatok kiirasa
                AdatokKiiratasa(label_maszknev1.Text, label_Brutto1, textBox_2_1, textBox_3_1, label_nettoakcio1, label_bruttoakcio1);
                AdatokKiiratasa(label_maszknev2.Text, label_Brutto2, textBox_2_2, textBox_3_2, label_nettoakcio2, label_bruttoakcio2);
                AdatokKiiratasa(label_maszknev3.Text, label_Brutto3, textBox_2_3, textBox_3_3, label_nettoakcio3, label_bruttoakcio3);
                AdatokKiiratasa(label_maszknev4.Text, label_Brutto4, textBox_2_4, textBox_3_4, label_nettoakcio4, label_bruttoakcio4);
                AdatokKiiratasa(label_maszknev5.Text, label_Brutto5, textBox_2_5, textBox_3_5, label_nettoakcio5, label_bruttoakcio5);
                AdatokKiiratasa(label_maszknev6.Text, label_Brutto6, textBox_2_6, textBox_3_6, label_nettoakcio6, label_bruttoakcio6);
            }
            else if (comboBox_Maszktipus.SelectedIndex == 1) //szelepes
            {
                label_maszknev1.Text = "Kek";
                label_maszknev2.Text = "Rozsaszin";
                label_maszknev3.Text = "Zold";
                label_maszknev4.Text = "Fekete";
                label_maszknev5.Text = "Sarga";
                label_maszknev6.Text = "Feher";
                maszktipus = "Szelepes";
                AdatokKiiratasa(label_maszknev1.Text, label_Brutto1, textBox_2_1, textBox_3_1, label_nettoakcio1, label_bruttoakcio1);
                AdatokKiiratasa(label_maszknev2.Text, label_Brutto2, textBox_2_2, textBox_3_2, label_nettoakcio2, label_bruttoakcio2);
                AdatokKiiratasa(label_maszknev3.Text, label_Brutto3, textBox_2_3, textBox_3_3, label_nettoakcio3, label_bruttoakcio3);
                AdatokKiiratasa(label_maszknev4.Text, label_Brutto4, textBox_2_4, textBox_3_4, label_nettoakcio4, label_bruttoakcio4);
                AdatokKiiratasa(label_maszknev5.Text, label_Brutto5, textBox_2_5, textBox_3_5, label_nettoakcio5, label_bruttoakcio5);
                AdatokKiiratasa(label_maszknev6.Text, label_Brutto6, textBox_2_6, textBox_3_6, label_nettoakcio6, label_bruttoakcio6);
            }
            else if (comboBox_Maszktipus.SelectedIndex == 2) //fashion
            {
                label_maszknev1.Text = "Kek";
                label_maszknev2.Text = "Terepmintas";
                label_maszknev3.Text = "Zold";
                label_maszknev4.Text = "Fekete";
                label_maszknev5.Text = "Sarga";
                label_maszknev6.Text = "Feher";
                maszktipus = "Fashion";
                AdatokKiiratasa(label_maszknev1.Text, label_Brutto1, textBox_2_1, textBox_3_1, label_nettoakcio1, label_bruttoakcio1);
                AdatokKiiratasa(label_maszknev2.Text, label_Brutto2, textBox_2_2, textBox_3_2, label_nettoakcio2, label_bruttoakcio2);
                AdatokKiiratasa(label_maszknev3.Text, label_Brutto3, textBox_2_3, textBox_3_3, label_nettoakcio3, label_bruttoakcio3);
                AdatokKiiratasa(label_maszknev4.Text, label_Brutto4, textBox_2_4, textBox_3_4, label_nettoakcio4, label_bruttoakcio4);
                AdatokKiiratasa(label_maszknev5.Text, label_Brutto5, textBox_2_5, textBox_3_5, label_nettoakcio5, label_bruttoakcio5);
                AdatokKiiratasa(label_maszknev6.Text, label_Brutto6, textBox_2_6, textBox_3_6, label_nettoakcio6, label_bruttoakcio6);
            }
            else if (comboBox_Maszktipus.SelectedIndex == 3) //szuros
            {
                label_maszknev1.Text = "Kek";
                label_maszknev2.Text = "Terepmintas";
                label_maszknev3.Text = "Zold";
                label_maszknev4.Text = "Fekete";
                label_maszknev5.Text = "Sarga";
                label_maszknev6.Text = "Feher";
                maszktipus = "Szuros";
                AdatokKiiratasa(label_maszknev1.Text, label_Brutto1, textBox_2_1, textBox_3_1, label_nettoakcio1, label_bruttoakcio1);
                AdatokKiiratasa(label_maszknev2.Text, label_Brutto2, textBox_2_2, textBox_3_2, label_nettoakcio2, label_bruttoakcio2);
                AdatokKiiratasa(label_maszknev3.Text, label_Brutto3, textBox_2_3, textBox_3_3, label_nettoakcio3, label_bruttoakcio3);
                AdatokKiiratasa(label_maszknev4.Text, label_Brutto4, textBox_2_4, textBox_3_4, label_nettoakcio4, label_bruttoakcio4);
                AdatokKiiratasa(label_maszknev5.Text, label_Brutto5, textBox_2_5, textBox_3_5, label_nettoakcio5, label_bruttoakcio5);
                AdatokKiiratasa(label_maszknev6.Text, label_Brutto6, textBox_2_6, textBox_3_6, label_nettoakcio6, label_bruttoakcio6);
            }
            else if (comboBox_Maszktipus.SelectedIndex == 4) //egyszerhasznalatos
            {
                label_maszknev1.Text = "Kek";
                label_maszknev2.Text = "Hupikek";
                label_maszknev3.Text = "Zold";
                label_maszknev4.Text = "Fekete";
                label_maszknev5.Text = "Rozsaszin";
                label_maszknev6.Text = "Feher";
                maszktipus = "Egyszerhasznalatos";
                AdatokKiiratasa(label_maszknev1.Text, label_Brutto1, textBox_2_1, textBox_3_1, label_nettoakcio1, label_bruttoakcio1);
                AdatokKiiratasa(label_maszknev2.Text, label_Brutto2, textBox_2_2, textBox_3_2, label_nettoakcio2, label_bruttoakcio2);
                AdatokKiiratasa(label_maszknev3.Text, label_Brutto3, textBox_2_3, textBox_3_3, label_nettoakcio3, label_bruttoakcio3);
                AdatokKiiratasa(label_maszknev4.Text, label_Brutto4, textBox_2_4, textBox_3_4, label_nettoakcio4, label_bruttoakcio4);
                AdatokKiiratasa(label_maszknev5.Text, label_Brutto5, textBox_2_5, textBox_3_5, label_nettoakcio5, label_bruttoakcio5);
                AdatokKiiratasa(label_maszknev6.Text, label_Brutto6, textBox_2_6, textBox_3_6, label_nettoakcio6, label_bruttoakcio6);
            }
            else if (comboBox_Maszktipus.SelectedIndex == 5) //mintás
            {
                label_maszknev1.Text = "Marvel";
                label_maszknev2.Text = "DC";
                label_maszknev3.Text = "Frozen";
                label_maszknev4.Text = "Csipkes";
                label_maszknev5.Text = "Shrek";
                label_maszknev6.Text = "Memes";
                maszktipus = "Mintas";
                AdatokKiiratasa(label_maszknev1.Text, label_Brutto1, textBox_2_1, textBox_3_1, label_nettoakcio1, label_bruttoakcio1);
                AdatokKiiratasa(label_maszknev2.Text, label_Brutto2, textBox_2_2, textBox_3_2, label_nettoakcio2, label_bruttoakcio2);
                AdatokKiiratasa(label_maszknev3.Text, label_Brutto3, textBox_2_3, textBox_3_3, label_nettoakcio3, label_bruttoakcio3);
                AdatokKiiratasa(label_maszknev4.Text, label_Brutto4, textBox_2_4, textBox_3_4, label_nettoakcio4, label_bruttoakcio4);
                AdatokKiiratasa(label_maszknev5.Text, label_Brutto5, textBox_2_5, textBox_3_5, label_nettoakcio5, label_bruttoakcio5);
                AdatokKiiratasa(label_maszknev6.Text, label_Brutto6, textBox_2_6, textBox_3_6, label_nettoakcio6, label_bruttoakcio6);
            }
        }
        #endregion
        //ComboEvents
        #region radiobuttonok amik mar nincsenek
        /*
        private void BP(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(64, 60, 64);
            Regio = "Budapest";
        }

        private void GY(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(97, 201, 35);
            Regio = "Gyor";
        }

        private void D(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 204, 204);
            Regio = "Debrecen";
        }*/
        #endregion

        public static void AdatokKiiratasa(string valtozomaszknev, Label label1, TextBox textbx2, TextBox textbx3, Label label2, Label label3) 
        {
            AdminRaktar.Tisztalista();
            for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
            {
                if (SzerverData.MaszInfokOsszes[i].Maszktipus == maszktipus && SzerverData.MaszInfokOsszes[i].Maszknev == valtozomaszknev)
                {
                    double x = Brutto(SzerverData.MaszInfokOsszes[i].Ar_db);
                    label1.Text = Convert.ToString(x);
                    textbx2.Text = Convert.ToString(SzerverData.MaszInfokOsszes[i].Ar_db);
                    textbx3.Text = Convert.ToString(SzerverData.MaszInfokOsszes[i].Akcio);
                    if (SzerverData.MaszInfokOsszes[i].Akcio != 0)
                    {
                        label2.Text = Convert.ToString(akcio(SzerverData.MaszInfokOsszes[i].Ar_db, SzerverData.MaszInfokOsszes[i].Akcio));
                        label3.Text = Convert.ToString(akcio(Convert.ToDouble(label1.Text), SzerverData.MaszInfokOsszes[i].Akcio)); 
                    }
                    else
                    {
                        label2.Text = "Nincs akció";
                        label3.Text = "Nincs akció";
                    }
                }
            }
        }

        //System.Diagnostics.Debug.WriteLine("megtortenikbudapest");
        public static double Brutto(double NettoOsszeg) 
        {
            double BruttoOsszeg =  Math.Round(NettoOsszeg * (1 + ADO_KULCS)) ;
            return BruttoOsszeg;
        }

        // Az "osszeg" paraméter a bruttó összegnek kell lennie
        public static double akcio(double osszeg, double magaazakcio)
        {
            osszeg = Math.Round(osszeg - (magaazakcio / 100 * osszeg));
            return osszeg;
        }


        /// TextCahnge eventek regex es button zold
        private void textBox_2_1_TextChanged(object sender, EventArgs e)
        {
            SzinvaltozasArValtozasra(textBox_2_1, button_Mentes1, label_maszknev1);
        }



        //Method4Textevent
        #region Metódus texteventre 1.oszlop
        public static void SzinvaltozasArValtozasra(TextBox textbox, Button gomb, Label labelka)
        {
            if (AdminRaktar.rg.IsMatch(textbox.Text) && Convert.ToInt32(textbox.Text) >= 50 && Convert.ToInt32(textbox.Text) <= 50000)
            {
                for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                {
                    if (SzerverData.MaszInfokOsszes[i].Maszktipus == maszktipus && labelka.Text == SzerverData.MaszInfokOsszes[i].Maszknev)
                    {
                        if (SzerverData.MaszInfokOsszes[i].Ar_db != Convert.ToDouble(textbox.Text))
                        {
                            gomb.BackColor = Color.FromArgb(153,255,51);
                        }
                        else
                        {
                            gomb.BackColor = Color.FromKnownColor(KnownColor.Control);
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                {
                    if (SzerverData.MaszInfokOsszes[i].Maszktipus == maszktipus && labelka.Text == SzerverData.MaszInfokOsszes[i].Maszknev)
                    {
                        gomb.BackColor = Color.FromKnownColor(KnownColor.Control);
                    }
                }
            }
        }
        #endregion

        //textevents2-6
        #region Textevents 2-6
        private void textBox_2_2_TextChanged(object sender, EventArgs e)
        {
            SzinvaltozasArValtozasra(textBox_2_2, button_Mentes2, label_maszknev2);
        }

        private void textBox_2_3_TextChanged(object sender, EventArgs e)
        {
            SzinvaltozasArValtozasra(textBox_2_3, button_Mentes3, label_maszknev3);
        }

        private void textBox_2_4_TextChanged(object sender, EventArgs e)
        {
            SzinvaltozasArValtozasra(textBox_2_4, button_Mentes4, label_maszknev4);
        }

        private void textBox_2_5_TextChanged(object sender, EventArgs e)
        {
            SzinvaltozasArValtozasra(textBox_2_5, button_Mentes5, label_maszknev5);
        }

        private void textBox_2_6_TextChanged(object sender, EventArgs e)
        {
            SzinvaltozasArValtozasra(textBox_2_6, button_Mentes6, label_maszknev6);
        }
        #endregion

        //Methodus texteventre 2.Oszlo textboxok
        #region Metódus textbox%-ra
        public static void SzinvaltozasAkcioValtozasra(TextBox textbox, Button gomb, Label labelka) 
        {
            if (AdminRaktar.rg.IsMatch(textbox.Text) && Convert.ToInt32(textbox.Text) >= 0 && Convert.ToInt32(textbox.Text) <= 99)
            {
                for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                {
                    if (SzerverData.MaszInfokOsszes[i].Maszktipus == maszktipus && labelka.Text == SzerverData.MaszInfokOsszes[i].Maszknev)
                    {
                        if (SzerverData.MaszInfokOsszes[i].Akcio != Convert.ToDouble(textbox.Text))
                        {
                            gomb.BackColor = Color.FromArgb(153, 255, 51);
                        }
                        else
                        {
                            gomb.BackColor = Color.FromKnownColor(KnownColor.Control);
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                {
                    if (SzerverData.MaszInfokOsszes[i].Maszktipus == maszktipus && labelka.Text == SzerverData.MaszInfokOsszes[i].Maszknev)
                    {
                        gomb.BackColor = Color.FromKnownColor(KnownColor.Control);
                    }
                }
            }
        }
        #endregion


        //Textboxeventek 2.Column
        #region
        private void textBox_3_1_TextChanged(object sender, EventArgs e)
        {
            SzinvaltozasAkcioValtozasra(textBox_3_1, button_Mentes2_1, label_maszknev1);
        }

        private void textBox_3_2_TextChanged(object sender, EventArgs e)
        {
            SzinvaltozasAkcioValtozasra(textBox_3_2, button_Mentes2_2, label_maszknev2);
        }

        private void textBox_3_3_TextChanged(object sender, EventArgs e)
        {
            SzinvaltozasAkcioValtozasra(textBox_3_3, button_Mentes2_3, label_maszknev3);
        }

        private void textBox_3_4_TextChanged(object sender, EventArgs e)
        {
            SzinvaltozasAkcioValtozasra(textBox_3_4, button_Mentes2_4, label_maszknev4);
        }

        private void textBox_3_5_TextChanged(object sender, EventArgs e)
        {
            SzinvaltozasAkcioValtozasra(textBox_3_5, button_Mentes2_5, label_maszknev5);
        }

        private void textBox_3_6_TextChanged(object sender, EventArgs e)
        {
            SzinvaltozasAkcioValtozasra(textBox_3_6, button_Mentes2_6, label_maszknev6);
        }
        #endregion

        private void button_Mentes1_Click(object sender, EventArgs e)
        {
            GombnyomasFuggveny(label_maszknev1,label_Brutto1 ,textBox_2_1,textBox_3_1, label_nettoakcio1, label_bruttoakcio1,button_Mentes1);
        }


        //Metódus Gomb 1.Oszlop
        #region Metodus Gom 1.Oszlop
        public static void GombnyomasFuggveny(Label maszknevecske,Label abruttolabel, TextBox azertek, TextBox atextboxakcio, Label labelnettoakcio, Label labelbruttoakcio,Button agomb)
        {
            if (agomb.BackColor == Color.FromArgb(153, 255, 51))
            {
                string fuggvenymaszktipus = maszktipus;
                string maszknev = maszknevecske.Text;
                string felvittertek = azertek.Text;
                if (MessageBox.Show("Biztosan Feltölti az új adatokat?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    agomb.BackColor = Color.FromKnownColor(KnownColor.Control);
                    try
                    {
                        using (SqlConnection Csatlakozas = new SqlConnection(SzerverData.SzerverInfoAdmin))
                        {
                            string Feltoltes = $"UPDATE MaszkAruk SET ar_db = '{felvittertek}' WHERE maszktipus='{fuggvenymaszktipus}' AND maszknev='{maszknev}'"; //Adatok feltöltése
                            using (SqlCommand Parancs = new SqlCommand(Feltoltes, Csatlakozas))
                            {
                                Csatlakozas.Open(); //Csatlakozási folyamat megnyitása
                                var result = Parancs.ExecuteNonQuery(); //itt  baj
                                Parancs.Dispose();
                                // Hiba keresés, ha nem lett eredmény
                                if (result < 0)
                                { MessageBox.Show("Hiba az adatfeltöltés során!"); } //Hibaüzenet
                                MessageBox.Show("A feltöltés megtörtént!"); //Sikeres feltöltés esetén megjelenő üzenet
                                Csatlakozas.Close(); //Csatlakozási folyamat lezárása
                                AdminRaktar.Tisztalista();
                            }
                        }
                    }
                    catch (Exception) //Kivétel megadása, ha a try részben lévő kód nem fut le.
                    { MessageBox.Show("Nem sikerült a csalakozás"); }
                    for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                    {
                        if (SzerverData.MaszInfokOsszes[i].Maszktipus == maszktipus && SzerverData.MaszInfokOsszes[i].Maszknev == maszknevecske.Text)
                        {
                            maszknevecske.Text = SzerverData.MaszInfokOsszes[i].Maszknev;
                            abruttolabel.Text = Convert.ToString(Brutto(SzerverData.MaszInfokOsszes[i].Ar_db));
                            azertek.Text = Convert.ToString(SzerverData.MaszInfokOsszes[i].Ar_db);
                            atextboxakcio.Text = Convert.ToString(SzerverData.MaszInfokOsszes[i].Akcio);
                            if (SzerverData.MaszInfokOsszes[i].Akcio != 0)
                            {
                                labelnettoakcio.Text = Convert.ToString(akcio(SzerverData.MaszInfokOsszes[i].Ar_db, SzerverData.MaszInfokOsszes[i].Akcio));
                                labelbruttoakcio.Text = Convert.ToString(akcio(Convert.ToDouble(abruttolabel.Text), SzerverData.MaszInfokOsszes[i].Akcio));
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                    {
                        if (SzerverData.MaszInfokOsszes[i].Maszktipus == maszktipus && maszknevecske.Text == SzerverData.MaszInfokOsszes[i].Maszknev)
                        {
                            azertek.Text = Convert.ToString(SzerverData.MaszInfokOsszes[i].Ar_db);
                            agomb.BackColor = Color.FromKnownColor(KnownColor.Control);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nem jó értéket adtál meg");
                for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                {
                    if (SzerverData.MaszInfokOsszes[i].Maszktipus == maszktipus && maszknevecske.Text == SzerverData.MaszInfokOsszes[i].Maszknev)
                    {
                        azertek.Text = Convert.ToString(SzerverData.MaszInfokOsszes[i].Ar_db);
                    }
                }
            }
        }
        #endregion


        /// Metódus Gomb 2.oszlop %-ra
        /// textbox.Text = Convert.ToString(SzerverData.MaszInfokOsszes[i].Akcio);
        #region Metodus Gomb 2.Oszlop %-ra
        public static void szazalekbutton(Label maszknevecske,Label bruttolabel , TextBox atextboxakcio, Label labelnettoakcio, Label labelbruttoakcio, Button agomb) 
        {
            if (agomb.BackColor == Color.FromArgb(153, 255, 51))
            {
                string fuggvenymaszktipus = maszktipus;
                string maszknev = maszknevecske.Text;
                string szazalekertek = atextboxakcio.Text;
                if (MessageBox.Show("Biztosan Feltölti az új adatokat?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    agomb.BackColor = Color.FromKnownColor(KnownColor.Control);
                    try
                    {
                        using (SqlConnection Csatlakozas = new SqlConnection(SzerverData.SzerverInfoAdmin))
                        {
                            string Feltoltes = $"UPDATE MaszkAruk SET akcio = '{szazalekertek}' WHERE maszktipus='{fuggvenymaszktipus}' AND maszknev='{maszknev}'"; //Adatok feltöltése
                            using (SqlCommand Parancs = new SqlCommand(Feltoltes, Csatlakozas))
                            {
                                Csatlakozas.Open(); //Csatlakozási folyamat megnyitása
                                var result = Parancs.ExecuteNonQuery(); //itt  baj
                                Parancs.Dispose();
                                // Hiba keresés, ha nem lett eredmény
                                if (result < 0)
                                { MessageBox.Show("Hiba az adatfeltöltés során!"); } //Hibaüzenet
                                MessageBox.Show("A feltöltés megtörtént!"); //Sikeres feltöltés esetén megjelenő üzenet
                                Csatlakozas.Close(); //Csatlakozási folyamat lezárása
                                AdminRaktar.Tisztalista();
                            }
                        }
                    }
                    catch (Exception) //Kivétel megadása, ha a try részben lévő kód nem fut le.
                    { MessageBox.Show("Nem sikerült a csalakozás"); }
                    for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                    {
                        if (SzerverData.MaszInfokOsszes[i].Maszktipus == maszktipus && SzerverData.MaszInfokOsszes[i].Maszknev == maszknevecske.Text)
                        {
                            atextboxakcio.Text = Convert.ToString(SzerverData.MaszInfokOsszes[i].Akcio);
                            if (SzerverData.MaszInfokOsszes[i].Akcio != 0)
                            {
                                labelnettoakcio.Text = Convert.ToString(akcio(SzerverData.MaszInfokOsszes[i].Ar_db, SzerverData.MaszInfokOsszes[i].Akcio));
                                labelbruttoakcio.Text = Convert.ToString(akcio(Convert.ToDouble(bruttolabel.Text), SzerverData.MaszInfokOsszes[i].Akcio));
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                    {
                        if (SzerverData.MaszInfokOsszes[i].Maszktipus == maszktipus && maszknevecske.Text == SzerverData.MaszInfokOsszes[i].Maszknev)
                        {
                            atextboxakcio.Text = Convert.ToString(SzerverData.MaszInfokOsszes[i].Akcio);
                            agomb.BackColor = Color.FromKnownColor(KnownColor.Control);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nem jó értéket adtál meg");
                for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                {
                    if (SzerverData.MaszInfokOsszes[i].Maszktipus == maszktipus && maszknevecske.Text == SzerverData.MaszInfokOsszes[i].Maszknev)
                    {
                        atextboxakcio.Text = Convert.ToString(SzerverData.MaszInfokOsszes[i].Akcio);
                        agomb.BackColor = Color.FromKnownColor(KnownColor.Control);
                    }
                }
            }
        }
        #endregion

        private void label_nettoakcio5_Click(object sender, EventArgs e)
        {

        }

        private void label_bruttoakcio2_Click(object sender, EventArgs e)
        {

        }

        #region Osszes gomb sorban
        //A 1.Oszlop Gombok_CLICK Az elsogom természetesen elcsúszott és feljebb van
        private void button_Mentes2_Click(object sender, EventArgs e)
        {
            GombnyomasFuggveny(label_maszknev2, label_Brutto2, textBox_2_2, textBox_3_2, label_nettoakcio2, label_bruttoakcio2, button_Mentes2);
        }

        private void button_Mentes3_Click(object sender, EventArgs e)
        {
            GombnyomasFuggveny(label_maszknev3, label_Brutto3, textBox_2_3, textBox_3_3, label_nettoakcio3, label_bruttoakcio3, button_Mentes3);
        }

        private void button_Mentes4_Click(object sender, EventArgs e)
        {
            GombnyomasFuggveny(label_maszknev4, label_Brutto4, textBox_2_4, textBox_3_4, label_nettoakcio4, label_bruttoakcio4, button_Mentes4);
        }

        private void button_Mentes5_Click(object sender, EventArgs e)
        {
            GombnyomasFuggveny(label_maszknev5, label_Brutto5, textBox_2_5, textBox_3_5, label_nettoakcio5, label_bruttoakcio5, button_Mentes5);
        }

        private void button_Mentes6_Click(object sender, EventArgs e)
        {
            GombnyomasFuggveny(label_maszknev6, label_Brutto6, textBox_2_6, textBox_3_6, label_nettoakcio6, label_bruttoakcio6, button_Mentes6);
        }

        //A 2.Oszlop Gombok_CLICK
        private void button_Mentes2_1_Click(object sender, EventArgs e)
        {
            szazalekbutton(label_maszknev1, label_Brutto1, textBox_3_1, label_nettoakcio1, label_bruttoakcio1, button_Mentes2_1);
        }

        private void button_Mentes2_2_Click(object sender, EventArgs e)
        {
            szazalekbutton(label_maszknev2, label_Brutto2, textBox_3_2, label_nettoakcio2, label_bruttoakcio2, button_Mentes2_2);
        }

        private void button_Mentes2_3_Click(object sender, EventArgs e)
        {
            szazalekbutton(label_maszknev3, label_Brutto3, textBox_3_3, label_nettoakcio3, label_bruttoakcio3, button_Mentes2_3);
        }

        private void button_Mentes2_4_Click(object sender, EventArgs e)
        {
            szazalekbutton(label_maszknev4, label_Brutto4, textBox_3_4, label_nettoakcio4, label_bruttoakcio4, button_Mentes2_4);
        }

        private void button_Mentes2_5_Click(object sender, EventArgs e)
        {
            szazalekbutton(label_maszknev5, label_Brutto5, textBox_3_5, label_nettoakcio5, label_bruttoakcio5, button_Mentes2_5);
        }

        private void button_Mentes2_6_Click(object sender, EventArgs e)
        {
            szazalekbutton(label_maszknev6, label_Brutto6, textBox_3_6, label_nettoakcio6, label_bruttoakcio6, button_Mentes2_6);
        }
        #endregion
    }
}
