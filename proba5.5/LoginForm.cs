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

namespace proba5._5
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            // listak feltoltese
            SzerverData.AdminListabaOlvasas();
            SzerverData.BudapestUsersListabaOlvasas();
            SzerverData.GyorUsersListabaOlvasas();
            SzerverData.DebrecenUsersListabaOlvasas();
        }

        private void button_kilepes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztosan ki szeretne lépni?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close(); 
            }
            else
            {
                try
                {
                    //Alapértelmezetten az ablak bezáródna magától így azt külön nem kell kiadni, kivéve ha az eventet külön gombra tesszük.
                    //Ide jöhet az adatbázis mentése majd bezárása ha van!
                    //pl.: ABKezelo.KapcsolatBontasa();->Ebben van az SQL connection AdatbázisCsalakozas.Close();
                }
                catch
                {
                    return; //Nem csinálunk semmit csak visszatérünk az eredeti állapothoz.
                }
            }
        }
        public static string profilnev = "";
        private void button_Bejelentkezes_Click(object sender, EventArgs e)
        {
            if (!radioButton_Debrecen2.Checked && !radioButton_Gyor2.Checked &&
                !radioButton_Admin2.Checked  &&
                !radioButton_Budapest2.Checked )
            {
                MessageBox.Show("Válassza ki a megfelelő jogosultságot");
            }
            else
            {
                ///////////// AdminRadibutton
                if (radioButton_Admin2.Checked == true)
                {
                    // ListakbaOlvasas.AdminListabaOlvasas();
                    int index = 0;
                    bool vane = false;
                    bool vanejlszo = false;
                    for (int i = 0; i < SzerverData.AdminUserLista.Count; i++)
                    {
                        if (textBox_nev.Text == SzerverData.AdminUserLista[i].Nev)
                        {
                            index = i;
                            vane = true;
                            profilnev = SzerverData.AdminUserLista[i].Nev;
                        }
                    }
                    if (vane == true)
                    {
                        for (int i = 0; i < SzerverData.AdminUserLista.Count; i++)
                        {
                            if (textBox_jelszo.Text == SzerverData.AdminUserLista[index].Jelszo)
                            {
                                vanejlszo = true;
                            }
                        }
                    }
                    if (vane == true && vanejlszo == true)
                    {
                        Admin AdminForm = new Admin();
                        this.Hide();
                        AdminForm.Show();
                        AdminForm.BringToFront();
                    }
                    else
                    {
                        if (MessageBox.Show("Kérem ellenőrizze le újból a belépési adatait", "Hibás felhasználónév vagy jelszó", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        {
                            return;
                        }
                    }
                }
                ///////////////////Budapest RadioButton
                else if (radioButton_Budapest2.Checked == true)
                {
                    // ListakbaOlvasas.BudapestUsersListabaOlvasas();
                    int index = 0;
                    bool vane = false;
                    bool vanejlszo = false;
                    for (int i = 0; i < SzerverData.BPUserLista.Count; i++)
                    {
                        if (textBox_nev.Text == SzerverData.BPUserLista[i].Nev)
                        {
                            index = i;
                            vane = true;
                            profilnev = SzerverData.BPUserLista[i].Nev;
                        }
                    }
                    if (vane == true)
                    {
                        for (int i = 0; i < SzerverData.BPUserLista.Count; i++)
                        {
                            if (textBox_jelszo.Text == SzerverData.BPUserLista[index].Jelszo)
                            {
                                vanejlszo = true;
                            }
                        }
                    }
                    if (vane == true && vanejlszo == true)
                    {
                        BudapestForm BPForm = new BudapestForm();
                        this.Hide();
                        BPForm.Show();
                        BPForm.BringToFront();
                    }
                    else
                    {
                        if (MessageBox.Show("Kérem ellenőrizze le újból a belépési adatait", "Hibás felhasználónév vagy jelszó", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        {
                            return;
                        }
                    }
                }

                ///////////////////Győr RadioButton
                else if (radioButton_Gyor2.Checked == true)
                {
                    // ListakbaOlvasas.GyorUsersListabaOlvasas();
                    int index = 0;
                    bool vane = false;
                    bool vanejlszo = false;
                    for (int i = 0; i < SzerverData.GyorUserLista.Count; i++)
                    {
                        if (textBox_nev.Text == SzerverData.GyorUserLista[i].Nev)
                        {
                            index = i;
                            vane = true;
                            profilnev = SzerverData.GyorUserLista[i].Nev;
                        }
                    }
                    if (vane == true)
                    {
                        for (int i = 0; i < SzerverData.GyorUserLista.Count; i++)
                        {
                            if (textBox_jelszo.Text == SzerverData.GyorUserLista[index].Jelszo)
                            {
                                vanejlszo = true;
                            }
                        }
                    }
                    if (vane == true && vanejlszo == true)
                    {
                        GyorForm GyForm = new GyorForm();
                        this.Hide();
                        GyForm.Show();
                        GyForm.BringToFront();
                    }
                    else
                    {
                        if (MessageBox.Show("Kérem ellenőrizze le újból a belépési adatait", "Hibás felhasználónév vagy jelszó", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        {
                            return;
                        }
                    }
                }
                
                ///////////////////Debrecen RadioButton
                else if (radioButton_Debrecen2.Checked == true)
                {
                    // ListakbaOlvasas.DebrecenUsersListabaOlvasas();
                    int index = 0;
                    bool vane = false;
                    bool vanejlszo = false;
                    for (int i = 0; i < SzerverData.DebUserLista.Count; i++)
                    {
                        if (textBox_nev.Text == SzerverData.DebUserLista[i].Nev)
                        {
                            index = i;
                            vane = true;
                            profilnev = SzerverData.DebUserLista[i].Nev;
                        }
                    }
                    if (vane == true)
                    {
                        for (int i = 0; i < SzerverData.DebUserLista.Count; i++)
                        {
                            if (textBox_jelszo.Text == SzerverData.DebUserLista[index].Jelszo)
                            {
                                vanejlszo = true;
                            }
                        }
                    }
                    if (vane == true && vanejlszo == true)
                    {
                        DebrecenForm DForm = new DebrecenForm();
                        this.Hide();
                        DForm.Show();
                        DForm.BringToFront();
                    }
                    else
                    {
                        if (MessageBox.Show("Kérem ellenőrizze le újból a belépési adatait", "Hibás felhasználónév vagy jelszó", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        {
                            return;
                        }
                    }
                }
            }
        }
    }
}
