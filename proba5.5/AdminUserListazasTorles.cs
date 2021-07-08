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
using System.IO;

namespace proba5._5
{
    public partial class AdminUserListazasTorles : UserControl
    {
        public AdminUserListazasTorles()
        {
            InitializeComponent();
            // SzerverData.AdminUserLista.Clear();
            // SzerverData.BPUserLista.Clear();
            // SzerverData.GyorUserLista.Clear();
            // SzerverData.DebUserLista.Clear();
        }

        private void button_Listazas_Click(object sender, EventArgs e)
        {
            // listaba olvases + 
            // checkboxvizsgalat();
            listBox_Felhasznalolistazas.Items.Clear();
            
            if (checkBox_Debuserek.Checked == false && checkBox_Gyoruserek.Checked == false && checkBox_BPuserek.Checked == false && checkBox_Adminuserek.Checked == false)
            {

                if (MessageBox.Show("A listázás sikertelen", "Nincs kijelölt checkbox", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    return;
                }
            }

            checkboxvizsgalat();

            // SzerverData.AdminUserLista.Clear();
            // SzerverData.BPUserLista.Clear();
            //SzerverData.GyorUserLista.Clear();
            // SzerverData.DebUserLista.Clear();
        }


        // ujra beolvassa a SzerverData listakat a checkbox alapjan
        public void checkboxvizsgalat() 
        {
            if (checkBox_Adminuserek.Checked == true)
            {
                // ListakbaOlvasas.AdminListabaOlvasas();
                for (int i = 0; i < SzerverData.AdminUserLista.Count; i++)
                {
                    listBox_Felhasznalolistazas.Items.Add(SzerverData.AdminUserLista[i].Id + ";" + SzerverData.AdminUserLista[i].Nev + ";" + SzerverData.AdminUserLista[i].Jelszo);
                }
            }
            if (checkBox_BPuserek.Checked == true)
            {
                // ListakbaOlvasas.BudapestUsersListabaOlvasas();
                for (int i = 0; i < SzerverData.BPUserLista.Count; i++)
                {
                    listBox_Felhasznalolistazas.Items.Add(SzerverData.BPUserLista[i].Id + ";" + SzerverData.BPUserLista[i].Nev + ";" + SzerverData.BPUserLista[i].Jelszo);
                }
            }
            if (checkBox_Gyoruserek.Checked == true)
            {
                // ListakbaOlvasas.GyorUsersListabaOlvasas();
                for (int i = 0; i < SzerverData.GyorUserLista.Count; i++)
                {
                    listBox_Felhasznalolistazas.Items.Add(SzerverData.GyorUserLista[i].Id + ";" + SzerverData.GyorUserLista[i].Nev + ";" + SzerverData.GyorUserLista[i].Jelszo);
                }
            }
            if (checkBox_Debuserek.Checked == true)
            {
                // ListakbaOlvasas.DebrecenUsersListabaOlvasas();
                for (int i = 0; i < SzerverData.DebUserLista.Count; i++)
                {
                    listBox_Felhasznalolistazas.Items.Add(SzerverData.DebUserLista[i].Id + ";" + SzerverData.DebUserLista[i].Nev + ";" + SzerverData.DebUserLista[i].Jelszo);
                }
            }
        }

        private void button_ListaBoxKijelzo_clear_Click(object sender, EventArgs e)
        {
            listBox_Felhasznalolistazas.Items.Clear();
        }

        private void button_Frissites_Click(object sender, EventArgs e)
        {
            listBox_Felhasznalolistazas.Items.Clear();
            SzerverData.AdminUserLista.Clear();
            SzerverData.BPUserLista.Clear();
            SzerverData.GyorUserLista.Clear();
            SzerverData.DebUserLista.Clear();
            SzerverData.AdminListabaOlvasas();
            SzerverData.DebrecenUsersListabaOlvasas();
            SzerverData.BudapestUsersListabaOlvasas();
            SzerverData.GyorUsersListabaOlvasas();
            checkboxvizsgalat();
            MessageBox.Show("A frissítés megtörtént");
        }

        private void Elemkiir(object sender, EventArgs e)
        {
            if (listBox_Felhasznalolistazas.SelectedItem != null) //Ha van kiválasztva lista item a dupla klikkeléskor
            {
                MessageBox.Show(listBox_Felhasznalolistazas.SelectedItem.ToString()); //Kiíratom a kijelölt listaelem adatait
                textBox_Kijelotelemtorles.Text = listBox_Felhasznalolistazas.SelectedItem.ToString();
            }
            else //Különben eset, ha az elem üres lenne
            {
                MessageBox.Show("Nincs kijelölt elem!"); //Hiba visszajelzése, ha üres az elem
            }
        }

        
        private void button_Export_Click(object sender, EventArgs e)
        {
            string csvfajlnev = textBox_Csv.Text + ".csv";
            if (listBox_Felhasznalolistazas.Items != null)
            {
                StreamWriter Iro = new StreamWriter(csvfajlnev,false,Encoding.Default);
                for (int i = 0; i < listBox_Felhasznalolistazas.Items.Count; i++)
                {
                    Iro.WriteLine(listBox_Felhasznalolistazas.Items[i].ToString());
                }
                Iro.Close();
                MessageBox.Show("Az írási folyamat végrehajtva");
            }
            else
            {
                MessageBox.Show("Először listázza ki az exportálandó adatokat");/////Ez a része nem jó
            }
        }

        private void button_Kereses_Click(object sender, EventArgs e)
        {
            if (textBox_NevKereses.Text != null)
            {
                listBox_Felhasznalolistazas.Items.Clear();
                //ListakbaOlvasas.AdminListabaOlvasas();
                //ListakbaOlvasas.BudapestUsersListabaOlvasas();
                //ListakbaOlvasas.GyorUsersListabaOlvasas();
                //ListakbaOlvasas.DebrecenUsersListabaOlvasas();
                bool Admin = false;
                bool BP = false;
                bool Deb = false;
                bool Gy = false;
                bool volte = false;
                int index = 0;
                for (int i = 0; i < SzerverData.AdminUserLista.Count; i++)
                {
                    if (textBox_NevKereses.Text == SzerverData.AdminUserLista[i].Nev)
                    {
                        Admin = true;
                        index = i;
                    }
                }
                for (int i = 0; i < SzerverData.BPUserLista.Count; i++)  
                {
                    if (textBox_NevKereses.Text == SzerverData.BPUserLista[i].Nev)
                    {
                        BP = true;
                        index = i;
                    }
                }
                for (int i = 0; i < SzerverData.GyorUserLista.Count; i++)
                {
                    if (textBox_NevKereses.Text == SzerverData.GyorUserLista[i].Nev)
                    {
                        Gy = true;
                        index = i;
                    }
                }
                for (int i = 0; i < SzerverData.DebUserLista.Count; i++)
                {
                    if (textBox_NevKereses.Text == SzerverData.DebUserLista[i].Nev)
                    {
                        Deb = true;
                        index = i;
                    }
                }
                if (Admin == true)
                {
                    listBox_Felhasznalolistazas.Items.Add($"{SzerverData.AdminUserLista[index].Id};{SzerverData.AdminUserLista[index].Nev};{SzerverData.AdminUserLista[index].Jelszo} ADMINJOG");
                    volte = true;
                }
                if (Deb == true)
                {
                    listBox_Felhasznalolistazas.Items.Add($"{SzerverData.DebUserLista[index].Id};{SzerverData.DebUserLista[index].Nev};{SzerverData.DebUserLista[index].Jelszo} Debreceni felhasználó");
                }
                if (BP == true)
                {
                    listBox_Felhasznalolistazas.Items.Add($"{SzerverData.BPUserLista[index].Id};{SzerverData.BPUserLista[index].Nev};{SzerverData.BPUserLista[index].Jelszo} Budapesti felhasználó");
                    volte = true;
                }
                if (Gy ==  true)
                {
                    listBox_Felhasznalolistazas.Items.Add($"{SzerverData.GyorUserLista[index].Id};{SzerverData.GyorUserLista[index].Nev};{SzerverData.GyorUserLista[index].Jelszo} Győri felhasználó");
                    volte = true;
                }
                if (volte == true)
                {
                    MessageBox.Show(" A keresés sikeres");
                }
                else
                {
                    MessageBox.Show("Nincs ilyen nevű felhasználó");
                }
            }
            else
            {
                MessageBox.Show("Írja be a keresendő felhasználónevet");
            }
        }

        private void button_ElemTorles_Click(object sender, EventArgs e)
        {
            if (textBox_Kijelotelemtorles.Text != "")
            {
                string ListaElemID = textBox_Kijelotelemtorles.Text.ToString().Split(';')[0]; //Kiszedjük a listából az elem ID értékét!
                string Felhasznalo = textBox_Kijelotelemtorles.Text.ToString().Split(';')[1];
                //string jelszo = textBox_Kijelotelemtorles.Text.ToString().Split(';')[2];
                bool adminbavan = false;
                bool gyorbevan = false;
                bool bpbevan = false;
                bool debrecenbevan = false;
                ////// Elsőnek megvizsgáljuk hol található a dolgozó
                for (int i = 0; i < SzerverData.AdminUserLista.Count; i++)
                  {
                      if (Felhasznalo == SzerverData.AdminUserLista[i].Nev)
                      {
                          adminbavan = true;
                      }
                  }

                // ha  nincs az adminbanm nezd meg a gyorben
                if (adminbavan != true)
                {
                    for (int i = 0; i < SzerverData.GyorUserLista.Count; i++)
                    {
                        if (Felhasznalo == SzerverData.GyorUserLista[i].Nev)
                        {
                            gyorbevan = true;
                        }
                    }
                }

                // ha nincs gyorbe, nezd meg a bpbe
                if (gyorbevan != true)
                {
                    for (int i = 0; i < SzerverData.BPUserLista.Count; i++)
                    {
                        if (Felhasznalo == SzerverData.BPUserLista[i].Nev)
                        {
                            bpbevan = true;
                        }
                    }
                }

                // ha nincs bpbe, nezd meg debrecenbe
                if (bpbevan != true)
                {
                    for (int i = 0; i < SzerverData.DebUserLista.Count; i++)
                    {
                        if (Felhasznalo == SzerverData.DebUserLista[i].Nev)
                        {
                            debrecenbevan = true;
                        }
                    }
                }

                

                /////A vizsgálat után megvizsgáljuk a melyik bool igaz
                if (adminbavan == true)
                {
                    // System.Diagnostics.Debug.WriteLine("megtortenikadmin");

                    try
                    {
                        string Torles = "DELETE FROM DolgozokAdmin WHERE id=" + ListaElemID + ""; //Adatok törlésének parancsa (kijelölt adat)
                        SqlConnection CsatlakozasiFolyamat = new SqlConnection(SzerverData.SzerverInfoAdmin); //Csatlakozunk a szerverhez
                        CsatlakozasiFolyamat.Open(); //Megnyitja a folyamotat, használatra
                        SqlCommand Parancsvegrehajtas = new SqlCommand(Torles, CsatlakozasiFolyamat);
                        Parancsvegrehajtas.ExecuteNonQuery();
                        Parancsvegrehajtas.Dispose();
                        MessageBox.Show("Az adatbázis elemének: (" + textBox_Kijelotelemtorles.ToString() + ") törlése megtörtént...");
                        CsatlakozasiFolyamat.Close(); //Bezárjuk a folyamatot
                                                      //Törlés a Listából, miután töröltük az adatbázisból!!! fordítva nem lehet
                        listBox_Felhasznalolistazas.Items.Remove(listBox_Felhasznalolistazas.SelectedItem);
                        adminbavan = false;
                    }
                    catch
                    {
                        if (MessageBox.Show("A törlés sikertelen", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        {
                            return;
                        }
                    }

                    // remove from AdminUserLista
                    SzerverData.AdminUserLista.RemoveAll(s => s.Id == Convert.ToInt32(ListaElemID));
                }
                else if (bpbevan == true)
                {
                    // System.Diagnostics.Debug.WriteLine("megtortenikbudapest");

                    try
                    {
                        string Torles = "DELETE FROM DolgozokBP WHERE id=" + ListaElemID + ""; //Adatok törlésének parancsa (kijelölt adat)
                        SqlConnection CsatlakozasiFolyamat = new SqlConnection(SzerverData.SzerverInfoAdmin); //Csatlakozunk a szerverhez
                        CsatlakozasiFolyamat.Open(); //Megnyitja a folyamotat, használatra
                        SqlCommand Parancsvegrehajtas = new SqlCommand(Torles, CsatlakozasiFolyamat);
                        Parancsvegrehajtas.ExecuteNonQuery();
                        Parancsvegrehajtas.Dispose();
                        MessageBox.Show("Az adatbázis elemének: (" + textBox_Kijelotelemtorles.ToString() + ") törlése megtörtént...");
                        CsatlakozasiFolyamat.Close(); //Bezárjuk a folyamatot
                                                      //Törlés a Listából, miután töröltük az adatbázisból!!! fordítva nem lehet
                        listBox_Felhasznalolistazas.Items.Remove(listBox_Felhasznalolistazas.SelectedItem);
                        bpbevan = false;
                    }
                    catch
                    {
                        if (MessageBox.Show("A törlés sikertelen", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        {
                            return;
                        }
                    }

                    // remove from AdminUserLista
                    SzerverData.BPUserLista.RemoveAll(s => s.Id == Convert.ToInt32(ListaElemID));
                }
                else if (gyorbevan == true)
                {
                    // System.Diagnostics.Debug.WriteLine("megtortenikgyor");

                    try
                    {
                        string Torles = "DELETE FROM DolgozokGY WHERE id=" + ListaElemID + ""; //Adatok törlésének parancsa (kijelölt adat)
                        SqlConnection CsatlakozasiFolyamat = new SqlConnection(SzerverData.SzerverInfoAdmin); //Csatlakozunk a szerverhez
                        CsatlakozasiFolyamat.Open(); //Megnyitja a folyamotat, használatra
                        SqlCommand Parancsvegrehajtas = new SqlCommand(Torles, CsatlakozasiFolyamat);
                        Parancsvegrehajtas.ExecuteNonQuery();
                        Parancsvegrehajtas.Dispose();
                        MessageBox.Show("Az adatbázis elemének: (" + textBox_Kijelotelemtorles.ToString() + ") törlése megtörtént...");
                        CsatlakozasiFolyamat.Close(); //Bezárjuk a folyamatot
                                                      //Törlés a Listából, miután töröltük az adatbázisból!!! fordítva nem lehet
                        listBox_Felhasznalolistazas.Items.Remove(listBox_Felhasznalolistazas.SelectedItem);
                        gyorbevan = false;
                    }
                    catch
                    {
                        if (MessageBox.Show("A törlés sikertelen", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        {
                            return;
                        }
                    }

                    // remove from AdminUserLista
                    SzerverData.GyorUserLista.RemoveAll(s => s.Id == Convert.ToInt32(ListaElemID));
                }
                else if (debrecenbevan == true)
                {
                    // System.Diagnostics.Debug.WriteLine("megtortenikDebrecen");

                    try
                    {
                        string Torles = "DELETE FROM DolgozokD WHERE id=" + ListaElemID + ""; //Adatok törlésének parancsa (kijelölt adat)
                        SqlConnection CsatlakozasiFolyamat = new SqlConnection(SzerverData.SzerverInfoAdmin); //Csatlakozunk a szerverhez
                        CsatlakozasiFolyamat.Open(); //Megnyitja a folyamotat, használatra
                        SqlCommand Parancsvegrehajtas = new SqlCommand(Torles, CsatlakozasiFolyamat);
                        Parancsvegrehajtas.ExecuteNonQuery();
                        Parancsvegrehajtas.Dispose();
                        MessageBox.Show("Az adatbázis elemének: (" + textBox_Kijelotelemtorles.ToString() + ") törlése megtörtént...");
                        CsatlakozasiFolyamat.Close(); //Bezárjuk a folyamatot
                                                      //Törlés a Listából, miután töröltük az adatbázisból!!! fordítva nem lehet
                        listBox_Felhasznalolistazas.Items.Remove(listBox_Felhasznalolistazas.SelectedItem);
                        debrecenbevan = false;
                    }
                    catch
                    {
                        if (MessageBox.Show("A törlés sikertelen", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        {
                            return;
                        }
                    }

                    // remove from AdminUserLista
                    SzerverData.DebUserLista.RemoveAll(s => s.Id == Convert.ToInt32(ListaElemID));
                }
            }
            else
            {
                if (MessageBox.Show("Kattintson kétszer a törlendő elemre, majd válassza az elem törlés gombot", "Az elem törlése sikertelen", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    return;
                }
            }
        }
    }
    
}