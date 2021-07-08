using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proba5._5
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            felhasznalohozzaAdas1.Hide();
            listazasTorles1.Hide();
            raktar1.Hide();
            aruvisszavetel1.Hide();
            eladas1.Hide();
            aruatcsoportositas1.Hide();
            Design();
            Profilkepalattinev();
            kezdopanel1.Show();
            kezdopanel1.BringToFront();
        }

        private void button_felhasznalohozzaadas_Click1(object sender, EventArgs e)
        {
            kezdopanel1.Hide();
            raktar1.Hide();
            aruvisszavetel1.Hide();
            eladas1.Hide();
            listazasTorles1.Hide();
            felhasznalohozzaAdas1.Show();
            felhasznalohozzaAdas1.BringToFront();
        }

        private void button_felhasznalohozzaadas_Click_1(object sender, EventArgs e)
        {
            kezdopanel1.Hide();
            raktar1.Hide();
            aruvisszavetel1.Hide();
            eladas1.Hide();
            listazasTorles1.Hide();
            felhasznalohozzaAdas1.Show();
            felhasznalohozzaAdas1.BringToFront();
            SubMenuHide();
        }
        private void Design()
        {
            panel_Userlenyilo.Visible = false;
            panel_Lenyilo2.Visible = false;
        }

        private void SubMenuHide() /////Ha le van nyílva a submenu akkor bezárja 
        {
            if (panel_Userlenyilo.Visible == true)
            {
                panel_Userlenyilo.Visible = false;
            }
            if (panel_Lenyilo2.Visible == true)
            {
                panel_Lenyilo2.Visible = false;
            }
        }

        private void SubMenuMutat(Panel subMenu) 
        {
            if (subMenu.Visible == false)
            {
                SubMenuHide();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void button_Users_Click(object sender, EventArgs e)
        {
            SubMenuMutat(panel_Userlenyilo);
        }

        private void Profilkepalattinev() 
        {
            label_provilnev.Text = LoginForm.profilnev;
        }

        // listazas torles event handler
        private void button1_Click(object sender, EventArgs e)
        {
            SubMenuHide();
            kezdopanel1.Hide();
            felhasznalohozzaAdas1.Hide();
            raktar1.Hide();
            aruvisszavetel1.Hide();
            eladas1.Hide();
            listazasTorles1.Show();
            listazasTorles1.BringToFront();
        }

        private void button_Aru_Click(object sender, EventArgs e)
        {
            SubMenuMutat(panel_Lenyilo2);
        }

        private void button_Eladas_Click(object sender, EventArgs e)
        {
            SubMenuHide();
            raktar1.Hide();
            kezdopanel1.Hide();
            aruvisszavetel1.Hide();
            listazasTorles1.Hide();
            felhasznalohozzaAdas1.Hide();
            eladas1.Show();
            eladas1.BringToFront();
        }

        private void button_Visszavetel_Click(object sender, EventArgs e)
        {
            SubMenuHide();
            kezdopanel1.Hide();
            felhasznalohozzaAdas1.Hide();
            raktar1.Hide();
            listazasTorles1.Hide();
            felhasznalohozzaAdas1.Hide();
            aruvisszavetel1.Show();
            aruvisszavetel1.BringToFront();
        }

        private void button_Raktar_Click(object sender, EventArgs e)
        {
            SubMenuHide();
            kezdopanel1.Hide();
            eladas1.Hide();
            aruvisszavetel1.Hide();
            listazasTorles1.Hide();
            felhasznalohozzaAdas1.Hide();
            raktar1.Show();
            raktar1.BringToFront();
        }

        private void button_Kijelentkezes_Click(object sender, EventArgs e)
        {
            SubMenuHide();
            LoginForm Bejelentkezes = new LoginForm();
            this.Hide();
            Bejelentkezes.Show();
            Bejelentkezes.BringToFront();
        }

        private void button_Kilepes_Click(object sender, EventArgs e)
        {
            SubMenuHide();
            ////Nem lép ki végleg
            if (MessageBox.Show("Biztosan ki szeretne lépni?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close(); //Ha a „No” kattintunk, akkor nem csinálunk semmit, a feltétel miatt, ez persze lehet másik „gomb” is!
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

        private void button_AruAtcsoportositas_Click(object sender, EventArgs e)
        {
            SubMenuHide();
            felhasznalohozzaAdas1.Hide();
            kezdopanel1.Hide();
            listazasTorles1.Hide();
            raktar1.Hide();
            aruvisszavetel1.Hide();
            eladas1.Hide();
            aruatcsoportositas1.Show();
            aruatcsoportositas1.BringToFront();
        }
    }
}
