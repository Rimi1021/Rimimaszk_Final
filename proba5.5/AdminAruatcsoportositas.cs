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
    public partial class AdminAruatcsoportositas : UserControl
    {
        public AdminAruatcsoportositas()
        {
            InitializeComponent();
            AdminRaktar.Tisztalista();
        }
        private static string Honnan = "";
        private static string Hova = "";
        private static string Termektipus = "";
        private static string Termeknev = "";
        private static bool maszkkombo = false;
        private static bool Szallitasra_Alkalmas = false;
        private static bool MegadottdbTextboxba = false;
        private static int db = 0;
        private static int Atvittdb = 0;
        #region radiobuttonok
        //VAN picturebox
        private void radioButton_BP_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(64, 60, 64);
            Honnan = "Budapest";
            label_Honnan.Text = "Budapest";
        }

        private void radioButton_Gyor_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(97, 201, 35);
            Honnan = "Gyor";
            label_Honnan.Text = "Győr";
        }

        private void radioButton_Debrecen_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(0, 204, 204);
            Honnan = "Debrecen";
            label_Honnan.Text = "Debrecen";
        }

        ///Raktár bictureBox
        private void radioButton4_CheckedChanged(object sender, EventArgs e) //BP
        {
            pictureBox1.BackColor = Color.FromArgb(64, 60, 64);
            Hova = "Budapest";
            label_Hova.Text = "Budapest";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)//Győr
        {
            pictureBox1.BackColor = Color.FromArgb(97, 201, 35);
            Hova = "Gyor";
            label_Hova.Text = "Győr";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)//Debrecen
        {
            pictureBox1.BackColor = Color.FromArgb(0, 204, 204);
            Hova = "Debrecen";
            label_Hova.Text = "Debrecen";
        }
        #endregion

        //Combobox Events
        #region Combobox
        private void MasztipusShange(object sender, EventArgs e)
        {
            Termektipus = comboBox_Maszktipus.SelectedItem.ToString();
        }

        private void Maszknevchange(object sender, EventArgs e)
        {
            Termeknev = comboBox_Maszknev.SelectedItem.ToString();
        }

        #endregion

        private void button_Találat_Click(object sender, EventArgs e)
        {
            AdminRaktar.Tisztalista();
            vizsgalat();
            if (radioButton_BP.Checked == false && radioButton_Gyor.Checked == false && radioButton_Debrecen.Checked == false) //Ha Radiobutton ures
            {
                MessageBox.Show("Válassza ki a telephelyet");
            }
            else if (comboBox_Maszktipus.SelectedItem == null || comboBox_Maszknev.SelectedItem == null) //Ha combo űres 
            {
                MessageBox.Show("Válassza ki a termék csoportot és termék fajtát");
            }
            else if (maszkkombo == true)
            {
                Szallitasra_Alkalmas = true;
                label_Maszktipus.Text = Termektipus;
                label_Maszknev.Text = Termeknev;
                label_Maszkdb.Text = Convert.ToString(db);
            }
            else
            {
                MessageBox.Show("Nem létező maszktípus-név kombináció");
            }
            maszkkombo = false;
        }

        #region Termékkombóvizsgálat
        public static void vizsgalat() 
        {
            for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
            {
                if (SzerverData.MaszInfokOsszes[i].Maszktipus == Termektipus && SzerverData.MaszInfokOsszes[i].Maszknev == Termeknev)
                {
                    maszkkombo = true;
                    if (Honnan == "Budapest")
                    {
                        db = SzerverData.MaszInfokOsszes[i].KeszletraktarBudapest;
                    }
                    else if (Honnan == "Gyor")
                    {
                        db = SzerverData.MaszInfokOsszes[i].KeszletraktarGyor;
                    }
                    else
                    {
                        db = SzerverData.MaszInfokOsszes[i].KeszletraktarDebrecen;
                    }
                }
            }
        }
        #endregion

        private void textBox_atcsoportositDB_TextChanged(object sender, EventArgs e)
        {
              if (AdminRaktar.rg.IsMatch(textBox_atcsoportositDB.Text) && db >= Convert.ToInt32(textBox_atcsoportositDB.Text) && Convert.ToInt32(textBox_atcsoportositDB.Text) != 0)
              {
                  MegadottdbTextboxba = true;
                  Atvittdb = Convert.ToInt32(textBox_atcsoportositDB.Text);
              }
              else
              {
                  MessageBox.Show("Csak számot adhatsz meg ami nem lehet 0 és a megadott érték nem lehet nagyobb a jelenlegi darabszámnál");
                  textBox_atcsoportositDB.Text = "";
                  MegadottdbTextboxba = false;
              }
            
        }

        /// ÁRUÁTCSOPORTOSÍTÁS CLICK
        #region Átcsoportosítás
        private void button_Atcsoportosit_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == false && radioButton5.Checked == false && radioButton6.Checked == false || Honnan == Hova)
            {
                MessageBox.Show("Rossz telephelyválasztás","Hiba",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (Szallitasra_Alkalmas == true && MegadottdbTextboxba == true)
            {
                if (Honnan == "Budapest")
                {
                    try
                    {
                        using (SqlConnection Csatlakozas = new SqlConnection(SzerverData.SzerverInfoAdmin))
                        {
                            string Feltoltes = $"UPDATE MaszkAruk SET keszletarubudapest = keszletarubudapest - {Atvittdb} WHERE maszktipus='{Termektipus}' AND maszknev='{Termeknev}'"; //Adatok feltöltése
                            using (SqlCommand Parancs = new SqlCommand(Feltoltes, Csatlakozas))
                            {
                                Csatlakozas.Open(); //Csatlakozási folyamat megnyitása
                                var result = Parancs.ExecuteNonQuery(); 
                                Parancs.Dispose();
                                // Hiba keresés, ha nem lett eredmény
                                if (result < 0)
                                { MessageBox.Show("Hiba az adatfeltöltés során!"); } //Hibaüzenet
                                MessageBox.Show("A feltöltés megtörtént!"); //Sikeres feltöltés esetén megjelenő üzenet
                                Csatlakozas.Close(); //Csatlakozási folyamat lezárása
                            }
                        }
                    }
                    catch (Exception) //Kivétel megadása, ha a try részben lévő kód nem fut le.
                    { MessageBox.Show("Nem sikerült a csalakozás"); }
                }
                else if (Honnan == "Gyor")
                {
                    try
                    {
                        using (SqlConnection Csatlakozas = new SqlConnection(SzerverData.SzerverInfoAdmin))
                        {
                            string Feltoltes = $"UPDATE MaszkAruk SET keszletarugyor = keszletarugyor - {Atvittdb} WHERE maszktipus='{Termektipus}' AND maszknev='{Termeknev}'"; //Adatok feltöltése
                            using (SqlCommand Parancs = new SqlCommand(Feltoltes, Csatlakozas))
                            {
                                Csatlakozas.Open(); //Csatlakozási folyamat megnyitása
                                var result = Parancs.ExecuteNonQuery(); 
                                Parancs.Dispose();
                                // Hiba keresés, ha nem lett eredmény
                                if (result < 0)
                                { MessageBox.Show("Hiba az adatfeltöltés során!"); } //Hibaüzenet
                                MessageBox.Show("A feltöltés megtörtént!"); //Sikeres feltöltés esetén megjelenő üzenet
                                Csatlakozas.Close(); //Csatlakozási folyamat lezárása
                            }
                        }
                    }
                    catch (Exception) //Kivétel megadása, ha a try részben lévő kód nem fut le.
                    { MessageBox.Show("Nem sikerült a csalakozás"); }
                }
                else ///Honnan == Debrecen
                {
                    try
                    {
                        using (SqlConnection Csatlakozas = new SqlConnection(SzerverData.SzerverInfoAdmin))
                        {
                            string Feltoltes = $"UPDATE MaszkAruk SET keszletarudebrecen = keszletarudebrecen - {Atvittdb} WHERE maszktipus='{Termektipus}' AND maszknev='{Termeknev}'"; //Adatok feltöltése
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
                            }
                        }
                    }
                    catch (Exception) //Kivétel megadása, ha a try részben lévő kód nem fut le.
                    { MessageBox.Show("Nem sikerült a csalakozás"); }
                }
                if (Hova == "Budapest")
                {
                    try
                    {
                        using (SqlConnection Csatlakozas = new SqlConnection(SzerverData.SzerverInfoAdmin))
                        {
                            string Feltoltes = $"UPDATE MaszkAruk SET keszletarubudapest = keszletarubudapest + {Atvittdb} WHERE maszktipus='{Termektipus}' AND maszknev='{Termeknev}'"; //Adatok feltöltése
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
                                /*comboBox_Maszknev.Text = "";
                                comboBox_Maszktipus.Text = "";
                                label_Maszktipus.Text = "Maszktípus";
                                label_Maszknev.Text = "Maszknév";
                                label_Maszkdb.Text = "DB";
                                label_Honnan.Text = "Honnan";
                                label_Hova.Text = "Hova";
                                radioButton_BP.Checked = false;
                                radioButton4.Checked = false;*/
                            }
                        }
                    }
                    catch (Exception) //Kivétel megadása, ha a try részben lévő kód nem fut le.
                    { MessageBox.Show("Nem sikerült a csalakozás"); }
                }
                else if (Hova == "Gyor")
                {
                    try
                    {
                        using (SqlConnection Csatlakozas = new SqlConnection(SzerverData.SzerverInfoAdmin))
                        {
                            string Feltoltes = $"UPDATE MaszkAruk SET keszletarugyor = keszletarugyor + {Atvittdb} WHERE maszktipus='{Termektipus}' AND maszknev='{Termeknev}'"; //Adatok feltöltése
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
                               /* comboBox_Maszknev.Text = "";
                                comboBox_Maszktipus.Text = "";
                                label_Maszktipus.Text = "Maszktípus";
                                label_Maszknev.Text = "Maszknév";
                                label_Maszkdb.Text = "DB";
                                label_Honnan.Text = "Honnan";
                                label_Hova.Text = "Hova";
                                radioButton_Gyor.Checked = false;
                                radioButton5.Checked = false;*/
                            }
                        }
                    }
                    catch (Exception) //Kivétel megadása, ha a try részben lévő kód nem fut le.
                    { MessageBox.Show("Nem sikerült a csalakozás"); }
                }
                else//Hova == Debrecen
                {
                    try
                    {
                        using (SqlConnection Csatlakozas = new SqlConnection(SzerverData.SzerverInfoAdmin))
                        {
                            string Feltoltes = $"UPDATE MaszkAruk SET keszletarudebrecen = keszletarudebrecen + {Atvittdb} WHERE maszktipus='{Termektipus}' AND maszknev='{Termeknev}'"; //Adatok feltöltése
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
                                /*comboBox_Maszknev.Text = "";
                                comboBox_Maszktipus.Text = "";
                                label_Maszktipus.Text = "Maszktípus";
                                label_Maszknev.Text = "Maszknév";
                                label_Maszkdb.Text = "DB";
                                label_Honnan.Text = "Honnan";
                                label_Hova.Text = "Hova";
                                radioButton_Debrecen.Checked = false;
                                radioButton6.Checked = false;*/
                            }
                        }
                    }
                    catch (Exception) //Kivétel megadása, ha a try részben lévő kód nem fut le.
                    { MessageBox.Show("Nem sikerült a csalakozás"); }
                }
            }
        }
        #endregion
    }
}
