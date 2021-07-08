using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace proba5._5
{
    public partial class AdminFelhasznalohozzaAdas : UserControl
    {
        public AdminFelhasznalohozzaAdas()
        {
            InitializeComponent();
        }
        private void button_Felvitel_Click(object sender, EventArgs e)
        {
            if (!radioButton_Debrecen.Checked  && !radioButton_Gyor.Checked &&
                !radioButton_Admin.Checked &&
                !radioButton_Budapest.Checked)
            {
                MessageBox.Show("Válassza ki a megfelelő jogosultságot");
            }
            else if (textBox_nev.Text != null && textBox_jelszo.Text.Length >= 5)
            {
                if (radioButton_Admin.Checked)
                {
                    try
                    {
                        using (SqlConnection Csatlakozas = new SqlConnection(SzerverData.SzerverInfoAdmin))
                        {
                            string Feltoltes = "INSERT INTO DolgozokAdmin VALUES (@nevAdat,@jelszoAdat)"; //Adatok feltöltése
                            using (SqlCommand Parancs = new SqlCommand(Feltoltes, Csatlakozas))
                            {

                                Parancs.Parameters.AddWithValue("@nevAdat", textBox_nev.Text); //Hivatkozott paraméter értékeinek megadása
                                Parancs.Parameters.AddWithValue("@jelszoAdat", textBox_jelszo.Text); //Hivatkozott paraméter értékeinek megadása
                                Csatlakozas.Open(); //Csatlakozási folyamat megnyitása
                                var result = Parancs.ExecuteNonQuery();
                                Parancs.Dispose();
                                // Hiba keresés, ha nem lett eredmény
                                if (result < 0)
                                {
                                    MessageBox.Show("Hiba az adatfeltöltés során!"); //Hibaüzenet  
                                }
                                else
                                {
                                    MessageBox.Show("A feltöltés megtörtént!"); //Sikeres feltöltés esetén megjelenő üzenet
                                }
                                Csatlakozas.Close(); //Csatlakozási folyamat lezárása
                            }
                        }
                        // clear
                        SzerverData.AdminUserLista.Clear();
                        // listakbaolvasas
                        SzerverData.AdminListabaOlvasas();
                        

                    }
                    catch (Exception) //Kivétel megadása, ha a try részben lévő kód nem fut le.
                    {
                        MessageBox.Show("Nem sikerült a csalakozás");
                    } //Feltöltési probléma esetén megjelenő üzenet
                    textBox_nev.Text = ""; //Aktuális elemek "kiürítése"
                    textBox_jelszo.Text = ""; //Aktuális elemek "kiürítése"
                }

                else if (radioButton_Budapest.Checked == true)
                {
                    try
                    {
                        using (SqlConnection Csatlakozas = new SqlConnection(SzerverData.SzerverInfoAdmin))
                        {
                            string Feltoltes = "INSERT INTO DolgozokBP VALUES (@nevAdat,@jelszoAdat)"; //Adatok feltöltése
                            using (SqlCommand Parancs = new SqlCommand(Feltoltes, Csatlakozas))
                            {
                                
                                    Parancs.Parameters.AddWithValue("@nevAdat", textBox_nev.Text); //Hivatkozott paraméter értékeinek megadása
                                    Parancs.Parameters.AddWithValue("@jelszoAdat", textBox_jelszo.Text); //Hivatkozott paraméter értékeinek megadása
                                    Csatlakozas.Open(); //Csatlakozási folyamat megnyitása
                                    var result = Parancs.ExecuteNonQuery();
                                    Parancs.Dispose();
                                    // Hiba keresés, ha nem lett eredmény
                                    if (result < 0)
                                    {
                                        MessageBox.Show("Hiba az adatfeltöltés során!"); //Hibaüzenet  
                                    }
                                    else
                                    {
                                        MessageBox.Show("A feltöltés megtörtént!"); //Sikeres feltöltés esetén megjelenő üzenet
                                    }
                                    Csatlakozas.Close(); //Csatlakozási folyamat lezárása
                            }
                        }
                    }
                    catch (Exception) //Kivétel megadása, ha a try részben lévő kód nem fut le.
                    {
                        MessageBox.Show("Nem sikerült a csalakozás");
                    } //Feltöltési probléma esetén megjelenő üzenet
                    textBox_nev.Text = ""; //Aktuális elemek "kiürítése"
                    textBox_jelszo.Text = ""; //Aktuális elemek "kiürítése"
                }

                else if (radioButton_Gyor.Checked == true)
                {
                    try
                    {
                        using (SqlConnection Csatlakozas = new SqlConnection(SzerverData.SzerverInfoAdmin))
                        {
                            string Feltoltes = "INSERT INTO DolgozokGY VALUES (@nevAdat,@jelszoAdat)"; //Adatok feltöltése
                            using (SqlCommand Parancs = new SqlCommand(Feltoltes, Csatlakozas))
                            {

                                Parancs.Parameters.AddWithValue("@nevAdat", textBox_nev.Text); //Hivatkozott paraméter értékeinek megadása
                                Parancs.Parameters.AddWithValue("@jelszoAdat", textBox_jelszo.Text); //Hivatkozott paraméter értékeinek megadása
                                Csatlakozas.Open(); //Csatlakozási folyamat megnyitása
                                var result = Parancs.ExecuteNonQuery();
                                Parancs.Dispose();
                                // Hiba keresés, ha nem lett eredmény
                                if (result < 0)
                                {
                                    MessageBox.Show("Hiba az adatfeltöltés során!"); //Hibaüzenet  
                                }
                                else
                                {
                                    MessageBox.Show("A feltöltés megtörtént!"); //Sikeres feltöltés esetén megjelenő üzenet
                                }
                                Csatlakozas.Close(); //Csatlakozási folyamat lezárása
                            }
                        }
                    }
                    catch (Exception) //Kivétel megadása, ha a try részben lévő kód nem fut le.
                    {
                        MessageBox.Show("Nem sikerült a csalakozás");
                    } //Feltöltési probléma esetén megjelenő üzenet
                    textBox_nev.Text = ""; //Aktuális elemek "kiürítése"
                    textBox_jelszo.Text = ""; //Aktuális elemek "kiürítése"
                }

                else
                {
                    try
                    {
                        using (SqlConnection Csatlakozas = new SqlConnection(SzerverData.SzerverInfoAdmin))
                        {
                            string Feltoltes = "INSERT INTO DolgozokD VALUES (@nevAdat,@jelszoAdat)"; //Adatok feltöltése
                            using (SqlCommand Parancs = new SqlCommand(Feltoltes, Csatlakozas))
                            {

                                Parancs.Parameters.AddWithValue("@nevAdat", textBox_nev.Text); //Hivatkozott paraméter értékeinek megadása
                                Parancs.Parameters.AddWithValue("@jelszoAdat", textBox_jelszo.Text); //Hivatkozott paraméter értékeinek megadása
                                Csatlakozas.Open(); //Csatlakozási folyamat megnyitása
                                var result = Parancs.ExecuteNonQuery();
                                Parancs.Dispose();
                                // Hiba keresés, ha nem lett eredmény
                                if (result < 0)
                                {
                                    MessageBox.Show("Hiba az adatfeltöltés során!"); //Hibaüzenet  
                                }
                                else
                                {
                                    MessageBox.Show("A feltöltés megtörtént!"); //Sikeres feltöltés esetén megjelenő üzenet
                                }
                                Csatlakozas.Close(); //Csatlakozási folyamat lezárása
                            }
                        }
                    }
                    catch (Exception) //Kivétel megadása, ha a try részben lévő kód nem fut le.
                    {
                        MessageBox.Show("Nem sikerült a csalakozás");
                    } //Feltöltési probléma esetén megjelenő üzenet
                    textBox_nev.Text = ""; //Aktuális elemek "kiürítése"
                    textBox_jelszo.Text = ""; //Aktuális elemek "kiürítése"
                }

            }
            else
            {
                MessageBox.Show("Adjon meg egy nevet és legalább 5 karakterhosszúságú jelszavat");
            }
        }





        private void radioButton_Admin_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_Budapest.Checked = false;
            radioButton_Debrecen.Checked = false;
            radioButton_Gyor.Checked = false;
        }

        private void radioButton_Budapest_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_Debrecen.Checked = false;
            radioButton_Gyor.Checked = false;
            radioButton_Admin.Checked = false;
        }

        private void radioButton_Gyor_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_Debrecen.Checked = false;
            radioButton_Admin.Checked = false;
            radioButton_Budapest.Checked = false;
        }

        private void radioButton_Debrecen_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_Gyor.Checked = false;
            radioButton_Admin.Checked = false;
            radioButton_Budapest.Checked = false;
        }
    }
}
