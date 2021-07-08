using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proba5._5
{
    public partial class AdminRaktar : UserControl
    {
        public AdminRaktar()
        {
            InitializeComponent();
            Tisztalista();
            hianycikk();
        }
        public static Regex rg = new Regex(@"^[0-9]+$");
        private static int szam1 = 0;
        private static int szam2 = 0;
        private static int szam3 = 0;
        private static int szam4 = 0;
        private static int szam5 = 0;
        private static int szam6 = 0;
       // public static Random rnd = new Random();
        

        //rg.IsMatch(textBox_5_5.Text)
        /// <summary>
        /// Elsőnek a + - gombok és a textbox change eventeket írom le az alábbiakban.
        /// A felső public stattic szam x valtozók idejonnek
        /// Mindegyik sorhoz van egy event a textbox érték manuális megváltoztatása miatt, amit darabszamvaltozas x-nek neveztem el
        /// HIBA!!! Ha karaktert írunk bele KÖLL egy regef feltétel
        /// </summary>
        #region +- gombok és textChangeeventek 
        //1.Sor
        private void button_1_1plusz_Click(object sender, EventArgs e)
        {
            szam1++;
            textBox_1_1.Text = Convert.ToString(szam1);
        }
        private void darabszamvaltozas(object sender, EventArgs e)
        {
            if (rg.IsMatch(textBox_1_1.Text))
            {
                if (textBox_1_1.Text == "" || Convert.ToInt32(textBox_1_1.Text) == 0)
                {
                    szam1 = 0;
                    button_Arufelvitel1.BackColor = Color.FromArgb(255,128,128);
                }
                else
                {
                    szam1 = Convert.ToInt32(textBox_1_1.Text);
                    button_Arufelvitel1.BackColor = Color.Lime;
                }
            }
            else
            {
                MessageBox.Show("Csak pozitiv számot írhatsz bele");
                button_Arufelvitel1.BackColor = Color.FromArgb(255, 128, 128);
            }
            
        }

        private void button1_1minusz_Click(object sender, EventArgs e)
        {
            szam1--;
            textBox_1_1.Text = Convert.ToString(szam1);
        }

        //2.Sor
        private void button_2_2plusz_Click(object sender, EventArgs e)
        {
            szam2++;
            textBox_2_2.Text = Convert.ToString(szam2);
        }

        private void button2_2minusz_Click(object sender, EventArgs e)
        {
            szam2--;
            textBox_2_2.Text = Convert.ToString(szam2);
        }

        private void darabszamvaltozas2(object sender, EventArgs e)
        {
            if (rg.IsMatch(textBox_2_2.Text))
            {
                if (textBox_2_2.Text == "" || Convert.ToInt32(textBox_2_2.Text) == 0)
                {
                    szam2 = 0;
                    button_Arufelvitel2.BackColor = Color.FromArgb(255, 128, 128);
                }
                else
                {
                    szam2 = Convert.ToInt32(textBox_2_2.Text);
                    button_Arufelvitel2.BackColor = Color.Lime;
                }
            }
            else
            {
                MessageBox.Show("Csak pozitív számot írhatsz bele");
                button_Arufelvitel2.BackColor = Color.FromArgb(255, 128, 128);
            }
        }

        //3.Sor
        private void button_3_3plusz_Click(object sender, EventArgs e)
        {
            szam3++;
            textBox_3_3.Text = Convert.ToString(szam3);
        }

        private void button3_3minusz_Click(object sender, EventArgs e)
        {
            
            szam3--;
            textBox_3_3.Text = Convert.ToString(szam3);
            
        }

        private void darabszamvaltozas3(object sender, EventArgs e)
        {
            if (rg.IsMatch(textBox_3_3.Text))
            {
                if (textBox_3_3.Text == "" || Convert.ToInt32(textBox_3_3.Text) == 0)
                {
                    szam3 = 0;
                    button_Arufelvitel3.BackColor = Color.FromArgb(255, 128, 128);
                }
                else
                {
                    szam3 = Convert.ToInt32(textBox_3_3.Text);
                    button_Arufelvitel3.BackColor = Color.Lime;
                }
            }
            else
            {
                MessageBox.Show("Csak pozitív számot írhatsz bele");
                button_Arufelvitel3.BackColor = Color.FromArgb(255, 128, 128);
            }
        }

        //4.Sor
        private void button_4_4plusz_Click(object sender, EventArgs e)
        {
            szam4++;
            textBox_4_4.Text = Convert.ToString(szam4);
        }

        private void button4_4minusz_Click(object sender, EventArgs e)
        {
            
            szam4--;
            textBox_4_4.Text = Convert.ToString(szam4);
            
        }

        private void darabszamvaltozas4(object sender, EventArgs e)
        {
            if (rg.IsMatch(textBox_4_4.Text))
            {
                if (textBox_4_4.Text == "" || Convert.ToInt32(textBox_4_4.Text) == 0)
                {
                    szam4 = 0;
                    button_Arufelvitel4.BackColor = Color.FromArgb(255, 128, 128);
                }
                else
                {
                    szam4 = Convert.ToInt32(textBox_4_4.Text);
                    button_Arufelvitel4.BackColor = Color.Lime;
                }
            }
            else
            {
                MessageBox.Show("Csak pozitív számot írhatsz bele");
                button_Arufelvitel4.BackColor = Color.FromArgb(255, 128, 128);
            }
        }

        //5.Sor
        private void button_5_5plusz_Click(object sender, EventArgs e)
        {
            szam5++;
            textBox_5_5.Text = Convert.ToString(szam5);
        }

        private void button5_5minusz_Click(object sender, EventArgs e)
        {
            szam5--;
            textBox_5_5.Text = Convert.ToString(szam5);
        }

        private void darabszamvaltozas5(object sender, EventArgs e)
        {
            if (rg.IsMatch(textBox_5_5.Text))
            {
                if (textBox_5_5.Text == "" || Convert.ToInt32(textBox_5_5.Text) == 0)
                {
                    szam5 = 0;
                    button_Arufelvitel5.BackColor = Color.FromArgb(255, 128, 128);
                }
                else
                {
                    szam5 = Convert.ToInt32(textBox_5_5.Text);
                    button_Arufelvitel5.BackColor = Color.Lime;
                }
            }
            else
            {
                MessageBox.Show("Csak pozitív számot írhatsz bele");
                button_Arufelvitel5.BackColor = Color.FromArgb(255, 128, 128);
            }
        }

        //6.Sor
        private void button_6_6plusz_Click(object sender, EventArgs e)
        {
            szam6++;
            textBox_6_6.Text = Convert.ToString(szam6);
        }

        private void button6_6minusz_Click(object sender, EventArgs e)
        {
            szam6--;
            textBox_6_6.Text = Convert.ToString(szam6);
        }

        private void darabszamvaltozas6(object sender, EventArgs e)
        {
            if (rg.IsMatch(textBox_6_6.Text))
            {
                if (textBox_6_6.Text == "" || Convert.ToInt32(textBox_6_6.Text) == 0)
                {
                    szam6 = 0;
                    button_Arufelvitel6.BackColor = Color.FromArgb(255, 128, 128);
                }
                else
                {
                    szam6 = Convert.ToInt32(textBox_6_6.Text);
                    button_Arufelvitel6.BackColor = Color.Lime;
                }
            }
            else
            {
                MessageBox.Show("Csak pozitív számot írhatsz bele");
                button_Arufelvitel6.BackColor = Color.FromArgb(255, 128, 128);
            }
        }
        #endregion
        /// <summary>
        /// + -  Gombok és textbocChangek Vége
        /// /// </summary>
        /// 

        /// <summary>
        /// FELTÖLTÉS GOMBOK
        /// /// </summary>
        /// 
        #region 1.Feltöltésgom Lajebb van a tobbi
        private void button_Arufelvitel1_Click(object sender, EventArgs e)
        {
            bool valtozookes = false;
            int valtozo = 0; // uj aru szam
            if (textBox_1_1.Text != null && rg.IsMatch(textBox_1_1.Text))
            {
                valtozo = Convert.ToInt32(textBox_1_1.Text);
                valtozookes = true;
            }
            string maszktipusgui = Convert.ToString(comboBox_Maszktipus.SelectedItem);
            string maszknevgui = label_maszknev1.Text.ToString();

            // call methid

            //Budapest
            if (radioButtonBP.Checked == true)
            {

                if (rg.IsMatch(textBox_1_1.Text) && Convert.ToInt32(textBox_1_1.Text) > 0 && Convert.ToInt32(textBox_1_1.Text) < 999 && comboBox_Maszktipus.SelectedItem != null && valtozookes == true)
                {
                    // call method
                    update_aru_keszletBP(valtozo, maszknevgui, maszktipusgui);

                    // call method vonalkod
                   // termekhozzaadasEgyDarab(maszktipusgui, maszknevgui, szam1);

                    //
                    textBox_1_1.Text = "0";
                    valtozookes = false;
                }
                else
                {
                    if (MessageBox.Show("Hiba a feltöltés során", "A feltöltendő mennyiség 0-1000 közé eshet és csak számot adhatsz meg és válassza ki a maszktípust", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        return;
                    }
                }
            }
            else if (radioButtonGY.Checked == true)
            {

                if (rg.IsMatch(textBox_1_1.Text) && Convert.ToInt32(textBox_1_1.Text) > 0 && Convert.ToInt32(textBox_1_1.Text) < 999 && comboBox_Maszktipus.SelectedItem != null && valtozookes == true)
                {
                    // call method
                    update_aru_keszletGY(valtozo, maszknevgui, maszktipusgui);
                    // call method vonalkod
                   // termekhozzaadasEgyDarab(maszktipusgui, maszknevgui, szam1);

                    //
                    textBox_1_1.Text = "0";
                }
                else
                {
                    if (MessageBox.Show("Hiba a feltöltés során", "A feltöltendő mennyiség 0-1000 közé eshet és csak számot adhatsz meg", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        return;
                    }
                }
            }
            else if (radioButtonD.Checked == true)
            {

                if (rg.IsMatch(textBox_1_1.Text) && Convert.ToInt32(textBox_1_1.Text) > 0 && Convert.ToInt32(textBox_1_1.Text) < 999 && comboBox_Maszktipus.SelectedItem != null && valtozookes == true)
                {
                    // call method
                    update_aru_keszletdebrecen(valtozo, maszknevgui, maszktipusgui);
                    // call method vonalkod
                    //termekhozzaadasEgyDarab(maszktipusgui, maszknevgui, szam1);

                    textBox_1_1.Text = "0";
                }
                else
                {
                    if (MessageBox.Show("Hiba a feltöltés során", "A feltöltendő mennyiség 0-1000 közé eshet és csak számot adhatsz meg", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Válassza ki a régiót");
            }

        }
        #endregion


        //Updat metodus  buttonokra Budapestre
        #region Metódusok UPDATE
        public void update_aru_keszletBP(int valtozo,string maszknevgui,string maszktipusgui) 
        {
            try
            {
                using (SqlConnection Csatlakozas = new SqlConnection(SzerverData.SzerverInfoAdmin))
                {
                    string Feltoltes = $"UPDATE MaszkAruk SET keszletarubudapest = keszletarubudapest + {valtozo} WHERE maszktipus='{maszktipusgui}' AND maszknev='{maszknevgui}'"; //Adatok feltöltése
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
            { MessageBox.Show("Nem sikerült a csalakozás"); } //Feltöltési probléma esetén megjelenő üzenet
        }

        //Updat metodus  buttonokra Győebe
        public void update_aru_keszletGY(int valtozo, string maszknevgui, string maszktipusgui)
        {
            try
            {
                using (SqlConnection Csatlakozas = new SqlConnection(SzerverData.SzerverInfoAdmin))
                {
                    string Feltoltes = $"UPDATE MaszkAruk SET keszletarugyor = keszletarugyor + {valtozo} WHERE maszktipus='{maszktipusgui}' AND maszknev='{maszknevgui}'"; //Adatok feltöltése
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
            { MessageBox.Show("Nem sikerült a csalakozás"); } //Feltöltési probléma esetén megjelenő üzenet
        }

        //Updat metodus  buttonokra Debrecenbe
        public void update_aru_keszletdebrecen(int valtozo, string maszknevgui, string maszktipusgui)
        {
            try
            {
                using (SqlConnection Csatlakozas = new SqlConnection(SzerverData.SzerverInfoAdmin))
                {
                    string Feltoltes = $"UPDATE MaszkAruk SET keszletarudebrecen = keszletarudebrecen + {valtozo} WHERE maszktipus='{maszktipusgui}' AND maszknev='{maszknevgui}'"; //Adatok feltöltése
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
            { MessageBox.Show("Nem sikerült a csalakozás"); } //Feltöltési probléma esetén megjelenő üzenet
        }
        #endregion
        /// <summary>
        /// FELTÖLTÉS GOMBOK vége
        /// /// </summary>

        /// <summary>
        /// /Combobox textevent
        /// </summary>
        #region combobox selectindex = Maszklabelek;
        private void comboBox_Maszktipus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Maszktipus.SelectedIndex == 0) //gaymasyk
            {
                label_maszknev1.Text = "Kek";
                label_maszknev2.Text = "Terepmintas";
                label_maszknev3.Text = "Zold";
                label_maszknev4.Text = "Fekete";
                label_maszknev5.Text = "Piros";
                label_maszknev6.Text = "Feher";
            }
            else if (comboBox_Maszktipus.SelectedIndex == 1) //szelepes
            {
                label_maszknev1.Text = "Kek";
                label_maszknev2.Text = "Rozsaszin";
                label_maszknev3.Text = "Zold";
                label_maszknev4.Text = "Fekete";
                label_maszknev5.Text = "Sarga";
                label_maszknev6.Text = "Feher";
            }
            else if (comboBox_Maszktipus.SelectedIndex == 2) //fashion
            {
                label_maszknev1.Text = "Kek";
                label_maszknev2.Text = "Terepmintas";
                label_maszknev3.Text = "Zold";
                label_maszknev4.Text = "Fekete";
                label_maszknev5.Text = "Sarga";
                label_maszknev6.Text = "Feher";
            }
            else if (comboBox_Maszktipus.SelectedIndex == 3) //szuros
            {
                label_maszknev1.Text = "Kek";
                label_maszknev2.Text = "Terepmintas";
                label_maszknev3.Text = "Zold";
                label_maszknev4.Text = "Fekete";
                label_maszknev5.Text = "Sarga";
                label_maszknev6.Text = "Feher";
            }
            else if (comboBox_Maszktipus.SelectedIndex == 4) //egyszerhasznalatos
            {
                label_maszknev1.Text = "Kek";
                label_maszknev2.Text = "Hupikek";
                label_maszknev3.Text = "Zold";
                label_maszknev4.Text = "Fekete";
                label_maszknev5.Text = "Rozsaszin";
                label_maszknev6.Text = "Feher";
            }
            else if (comboBox_Maszktipus.SelectedIndex == 5) //mintás
            {
                label_maszknev1.Text = "Marvel";
                label_maszknev2.Text = "DC";
                label_maszknev3.Text = "Frozen";
                label_maszknev4.Text = "Csipkes";
                label_maszknev5.Text = "Shrek";
                label_maszknev6.Text = "Memes";
            }
        }
        #endregion
        /// <summary>
        /// /Combobox textevent Vége
        /// </summary>


        /// <summary>
        /// /RadioButton eventek
        /// </summary>
        #region radiobutton eventek
        private void radioButtonBP_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(64,60,64);
            label_Raktar.Text = "Raktár: Budapest";
        }

        private void radioButtonGY_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(97, 201, 35);
            label_Raktar.Text = "Raktár: Győr";
        }

        private void radioButtonD_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 204, 204); 
            label_Raktar.Text = "Raktár: Debrecen";
        }
        #endregion


        //2.Gomb 
        #region  2.Gomb
        private void button_Arufelvitel2_Click(object sender, EventArgs e)
        {
            bool valtozookes = false;
            int valtozo = 0; // uj aru szam
            if (textBox_2_2.Text != null && rg.IsMatch(textBox_2_2.Text))
            {
                valtozo = Convert.ToInt32(textBox_2_2.Text);
                valtozookes = true;
            }
            string maszktipusgui = Convert.ToString(comboBox_Maszktipus.SelectedItem);
            string maszknevgui = label_maszknev2.Text.ToString();

            // call methid

            //Budapest
            if (radioButtonBP.Checked == true)
            {

                if (rg.IsMatch(textBox_2_2.Text) && Convert.ToInt32(textBox_2_2.Text) > 0 && Convert.ToInt32(textBox_2_2.Text) < 999 && comboBox_Maszktipus.SelectedItem != null && valtozookes == true)
                {
                    // call method
                    update_aru_keszletBP(valtozo, maszknevgui, maszktipusgui);

                    // call method vonalkod
                    //termekhozzaadasEgyDarab(maszktipusgui, maszknevgui,szam2);

                    // 
                    textBox_2_2.Text = "0";
                }
                else
                {
                    if (MessageBox.Show("Hiba a feltöltés során", "A feltöltendő mennyiség 0-1000 közé eshet és csak számot adhatsz meg", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        return;
                    }
                }
            }
            else if (radioButtonGY.Checked == true)
            {

                if (rg.IsMatch(textBox_2_2.Text) && Convert.ToInt32(textBox_2_2.Text) > 0 && Convert.ToInt32(textBox_2_2.Text) < 999 && comboBox_Maszktipus.SelectedItem != null && valtozookes == true)
                {
                    // call method
                    update_aru_keszletGY(valtozo, maszknevgui, maszktipusgui);

                    // call method vonalkod
                   // termekhozzaadasEgyDarab(maszktipusgui, maszknevgui, szam2);
                    
                    //
                    textBox_2_2.Text = "0";
                }
                else
                {
                    if (MessageBox.Show("Hiba a feltöltés során", "A feltöltendő mennyiség 0-1000 közé eshet és csak számot adhatsz meg", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        return;
                    }
                }
            }
            else if (radioButtonD.Checked == true)
            {

                if (rg.IsMatch(textBox_2_2.Text) && Convert.ToInt32(textBox_2_2.Text) > 0 && Convert.ToInt32(textBox_2_2.Text) < 999 && comboBox_Maszktipus.SelectedItem != null && valtozookes == true)
                {
                    // call method
                    update_aru_keszletdebrecen(valtozo, maszknevgui, maszktipusgui);

                    // call method vonalkod
                    //termekhozzaadasEgyDarab(maszktipusgui, maszknevgui, szam2);

                    //
                    textBox_2_2.Text = "0";
                }
                else
                {
                    if (MessageBox.Show("Hiba a feltöltés során", "A feltöltendő mennyiség 0-1000 közé eshet és csak számot adhatsz meg", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Válassza ki a régiót");
            }
        }
        #endregion


        /// 3.Gomb


        #region 3.Gomb
        private void button_Arufelvitel3_Click(object sender, EventArgs e)
        {
            bool valtozookes = false;
            int valtozo = 0; // uj aru szam
            if (textBox_3_3.Text != null && rg.IsMatch(textBox_3_3.Text))
            {
                valtozo = Convert.ToInt32(textBox_3_3.Text);
                valtozookes = true;
            }
            string maszktipusgui = Convert.ToString(comboBox_Maszktipus.SelectedItem);
            string maszknevgui = label_maszknev3.Text.ToString();

            // call methid

            //Budapest
            if (radioButtonBP.Checked == true)
            {

                if (rg.IsMatch(textBox_3_3.Text) && Convert.ToInt32(textBox_3_3.Text) > 0 && Convert.ToInt32(textBox_3_3.Text) < 999 && comboBox_Maszktipus.SelectedItem != null && valtozookes == true)
                {
                    // call method
                    update_aru_keszletBP(valtozo, maszknevgui, maszktipusgui);
                    // call method vonalkod
                   // termekhozzaadasEgyDarab(maszktipusgui, maszknevgui, szam3);

                    textBox_3_3.Text = "0";
                }
                else
                {
                    if (MessageBox.Show("Hiba a feltöltés során", "A feltöltendő mennyiség 0-1000 közé eshet és csak számot adhatsz meg", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        return;
                    }
                }
            }
            else if (radioButtonGY.Checked == true)
            {

                if (rg.IsMatch(textBox_3_3.Text) && Convert.ToInt32(textBox_3_3.Text) > 0 && Convert.ToInt32(textBox_3_3.Text) < 999 && comboBox_Maszktipus.SelectedItem != null && valtozookes == true)
                {
                    // call method
                    update_aru_keszletGY(valtozo, maszknevgui, maszktipusgui);
                    // call method vonalkod
                   // termekhozzaadasEgyDarab(maszktipusgui, maszknevgui, szam3);
                    textBox_3_3.Text = "0";
                }
                else
                {
                    if (MessageBox.Show("Hiba a feltöltés során", "A feltöltendő mennyiség 0-1000 közé eshet és csak számot adhatsz meg", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        return;
                    }
                }
            }
            else if (radioButtonD.Checked == true)
            {

                if (rg.IsMatch(textBox_3_3.Text) && Convert.ToInt32(textBox_3_3.Text) > 0 && Convert.ToInt32(textBox_3_3.Text) < 999 && comboBox_Maszktipus.SelectedItem != null && valtozookes == true)
                {
                    // call method
                    update_aru_keszletdebrecen(valtozo, maszknevgui, maszktipusgui);
                    // call method vonalkod
                   // termekhozzaadasEgyDarab(maszktipusgui, maszknevgui, szam3);

                    textBox_3_3.Text = "0";
                }
                else
                {
                    if (MessageBox.Show("Hiba a feltöltés során", "A feltöltendő mennyiség 0-1000 közé eshet és csak számot adhatsz meg", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Válassza ki a régiót");
            }
        }
        #endregion


        //4.Gomb
        #region 4.gomb
        private void button_Arufelvitel4_Click(object sender, EventArgs e)
        {
            bool valtozookes = false;
            int valtozo = 0; // uj aru szam
            if (textBox_4_4.Text != null && rg.IsMatch(textBox_4_4.Text))
            {
                valtozo = Convert.ToInt32(textBox_4_4.Text);
                valtozookes = true;
            }
            string maszktipusgui = Convert.ToString(comboBox_Maszktipus.SelectedItem);
            string maszknevgui = label_maszknev4.Text.ToString();

            // call methid

            //Budapest
            if (radioButtonBP.Checked == true)
            {

                if (rg.IsMatch(textBox_4_4.Text) && Convert.ToInt32(textBox_4_4.Text) > 0 && Convert.ToInt32(textBox_4_4.Text) < 999 && comboBox_Maszktipus.SelectedItem != null && valtozookes == true)
                {
                    // call method
                    update_aru_keszletBP(valtozo, maszknevgui, maszktipusgui);
                    // call method vonalkod
                   // termekhozzaadasEgyDarab(maszktipusgui, maszknevgui, szam4);

                    textBox_4_4.Text = "0";
                }
                else
                {
                    if (MessageBox.Show("Hiba a feltöltés során", "A feltöltendő mennyiség 0-1000 közé eshet és csak számot adhatsz meg", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        return;
                    }
                }
            }
            else if (radioButtonGY.Checked == true)
            {

                if (rg.IsMatch(textBox_4_4.Text) && Convert.ToInt32(textBox_4_4.Text) > 0 && Convert.ToInt32(textBox_4_4.Text) < 999 && comboBox_Maszktipus.SelectedItem != null && valtozookes == true)
                {
                    // call method
                    update_aru_keszletGY(valtozo, maszknevgui, maszktipusgui);
                    // call method vonalkod
                   // termekhozzaadasEgyDarab(maszktipusgui, maszknevgui, szam4);
                    textBox_4_4.Text = "0";
                }
                else
                {
                    if (MessageBox.Show("Hiba a feltöltés során", "A feltöltendő mennyiség 0-1000 közé eshet és csak számot adhatsz meg", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        return;
                    }
                }
            }
            else if (radioButtonD.Checked == true)
            {

                if (rg.IsMatch(textBox_4_4.Text) && Convert.ToInt32(textBox_4_4.Text) > 0 && Convert.ToInt32(textBox_4_4.Text) < 999 && comboBox_Maszktipus.SelectedItem != null && valtozookes == true)
                {
                    // call method
                    update_aru_keszletdebrecen(valtozo, maszknevgui, maszktipusgui);
                    // call method vonalkod
                    //termekhozzaadasEgyDarab(maszktipusgui, maszknevgui, szam4);

                    textBox_4_4.Text = "0";
                }
                else
                {
                    if (MessageBox.Show("Hiba a feltöltés során", "A feltöltendő mennyiség 0-1000 közé eshet és csak számot adhatsz meg", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Válassza ki a régiót");
            }
        }
        #endregion

        //5.Gomb
        #region 5.Gomb
        private void button_Arufelvitel5_Click(object sender, EventArgs e)
        {
            bool valtozookes = false;
            int valtozo = 0; // uj aru szam
            if (textBox_5_5.Text != null && rg.IsMatch(textBox_5_5.Text))
            {
                valtozo = Convert.ToInt32(textBox_5_5.Text);
                valtozookes = true;
            }
            string maszktipusgui = Convert.ToString(comboBox_Maszktipus.SelectedItem);
            string maszknevgui = label_maszknev5.Text.ToString();

            // call methid

            //Budapest
            if (radioButtonBP.Checked == true)
            {

                if (rg.IsMatch(textBox_5_5.Text) && Convert.ToInt32(textBox_5_5.Text) > 0 && Convert.ToInt32(textBox_5_5.Text) < 999 && comboBox_Maszktipus.SelectedItem != null && valtozookes == true)
                {
                    // call method
                    update_aru_keszletBP(valtozo, maszknevgui, maszktipusgui);
                    // call method vonalkod
                    //termekhozzaadasEgyDarab(maszktipusgui, maszknevgui, szam5);

                    textBox_5_5.Text = "0";
                }
                else
                {
                    if (MessageBox.Show("Hiba a feltöltés során", "A feltöltendő mennyiség 0-1000 közé eshet és csak számot adhatsz meg", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        return;
                    }
                }
            }
            else if (radioButtonGY.Checked == true)
            {

                if (rg.IsMatch(textBox_5_5.Text) && Convert.ToInt32(textBox_5_5.Text) > 0 && Convert.ToInt32(textBox_5_5.Text) < 999 && comboBox_Maszktipus.SelectedItem != null && valtozookes == true)
                {
                    // call method
                    update_aru_keszletGY(valtozo, maszknevgui, maszktipusgui);
                    // call method vonalkod
                    //termekhozzaadasEgyDarab(maszktipusgui, maszknevgui, szam5);

                    textBox_5_5.Text = "0";
                }
                else
                {
                    if (MessageBox.Show("Hiba a feltöltés során", "A feltöltendő mennyiség 0-1000 közé eshet és csak számot adhatsz meg", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        return;
                    }
                }
            }
            else if (radioButtonD.Checked == true)
            {

                if (rg.IsMatch(textBox_5_5.Text) && Convert.ToInt32(textBox_5_5.Text) > 0 && Convert.ToInt32(textBox_5_5.Text) < 999 && comboBox_Maszktipus.SelectedItem != null && valtozookes == true)
                {
                    // call method
                    update_aru_keszletdebrecen(valtozo, maszknevgui, maszktipusgui);
                    // call method vonalkod
                    //termekhozzaadasEgyDarab(maszktipusgui, maszknevgui, szam5);

                    textBox_5_5.Text = "0";
                }
                else
                {
                    if (MessageBox.Show("Hiba a feltöltés során", "A feltöltendő mennyiség 0-1000 közé eshet és csak számot adhatsz meg", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Válassza ki a régiót");
            }
        }
        #endregion

        //6.Gomb
        #region 6.Gomb
        private void button_Arufelvitel6_Click(object sender, EventArgs e)
        {
            bool valtozookes = false;
            int valtozo = 0; // uj aru szam
            if (textBox_6_6.Text != null && rg.IsMatch(textBox_6_6.Text))
            {
                valtozo = Convert.ToInt32(textBox_6_6.Text);
                valtozookes = true;
            }
            string maszktipusgui = Convert.ToString(comboBox_Maszktipus.SelectedItem);
            string maszknevgui = label_maszknev6.Text.ToString();

            // call methid

            //Budapest
            if (radioButtonBP.Checked == true)
            {

                if (rg.IsMatch(textBox_6_6.Text) && Convert.ToInt32(textBox_6_6.Text) > 0 && Convert.ToInt32(textBox_6_6.Text) < 999 && comboBox_Maszktipus.SelectedItem != null && valtozookes == true)
                {
                    // call method
                    update_aru_keszletBP(valtozo, maszknevgui, maszktipusgui);
                    // call method vonalkod
                    //termekhozzaadasEgyDarab(maszktipusgui, maszknevgui, szam6);

                    textBox_6_6.Text = "0";
                }
                else
                {
                    if (MessageBox.Show("Hiba a feltöltés során", "A feltöltendő mennyiség 0-1000 közé eshet és csak számot adhatsz meg", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        return;
                    }
                }
            }
            else if (radioButtonGY.Checked == true)
            {

                if (rg.IsMatch(textBox_6_6.Text) && Convert.ToInt32(textBox_6_6.Text) > 0 && Convert.ToInt32(textBox_6_6.Text) < 999 && comboBox_Maszktipus.SelectedItem != null && valtozookes == true)
                {
                    // call method
                    update_aru_keszletGY(valtozo, maszknevgui, maszktipusgui);
                    // call method vonalkod
                    //termekhozzaadasEgyDarab(maszktipusgui, maszknevgui, szam6);

                    textBox_6_6.Text = "0";
                }
                else
                {
                    if (MessageBox.Show("Hiba a feltöltés során", "A feltöltendő mennyiség 0-1000 közé eshet és csak számot adhatsz meg", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        return;
                    }
                }
            }
            else if (radioButtonD.Checked == true)
            {

                if (rg.IsMatch(textBox_6_6.Text) && Convert.ToInt32(textBox_6_6.Text) > 0 && Convert.ToInt32(textBox_6_6.Text) < 999 && comboBox_Maszktipus.SelectedItem != null && valtozookes == true)
                {
                    // call method
                    update_aru_keszletdebrecen(valtozo, maszknevgui, maszktipusgui);
                    // call method vonalkod
                    //termekhozzaadasEgyDarab(maszktipusgui, maszknevgui, szam6);

                    textBox_6_6.Text = "0";
                }
                else
                {
                    if (MessageBox.Show("Hiba a feltöltés során", "A feltöltendő mennyiség 0-1000 közé eshet és csak számot adhatsz meg", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Válassza ki a régiót");
            }
        }
        #endregion

        /// <summary>
        /// /RadioButton eventek vége
        /// </summary>

        //Áruk listaclearing es belefeleolvasas
        public static void Tisztalista() 
        {
            SzerverData.MaszInfokOsszes.Clear();
            SzerverData.MaszarukListabaOlvasas();
        }

        #region Hiánycikkbutton
        private void button_Hianycikk_Click(object sender, EventArgs e)
        {
            listBox_Hianycikk.Items.Clear();

            if (checkBox_BP.Checked == false && checkBox_D.Checked == false && checkBox_Gy.Checked == false)
            {
                MessageBox.Show("Válasszon ki legalább egy db checkboxot");
            }
            if (checkBox_BP.Checked == true)
            {
                for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                {
                    if (SzerverData.MaszInfokOsszes[i].KeszletraktarBudapest < 20)
                    {
                        listBox_Hianycikk.Items.Add(SzerverData.MaszInfokOsszes[i].Maszktipus + ";" + SzerverData.MaszInfokOsszes[i].Maszknev + ";" + SzerverData.MaszInfokOsszes[i].KeszletraktarBudapest + "; BUdapest");
                    }
                }
            }
            if (checkBox_Gy.Checked == true)
            {
                for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                {
                    if (SzerverData.MaszInfokOsszes[i].KeszletraktarGyor < 20)
                    {
                        listBox_Hianycikk.Items.Add(SzerverData.MaszInfokOsszes[i].Maszktipus + ";" + SzerverData.MaszInfokOsszes[i].Maszknev + ";" + SzerverData.MaszInfokOsszes[i].KeszletraktarGyor + "; Győr");
                    }
                }
            }
            if (checkBox_D.Checked == true)
            {
                for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                {
                    if (SzerverData.MaszInfokOsszes[i].KeszletraktarDebrecen < 20)
                    {
                        listBox_Hianycikk.Items.Add(SzerverData.MaszInfokOsszes[i].Maszktipus + ";" + SzerverData.MaszInfokOsszes[i].Maszknev + ";" + SzerverData.MaszInfokOsszes[i].KeszletraktarDebrecen + "; Debrecen");
                    }
                }
            }
            
        }
        #endregion
        private static bool BPpiros = false;
        private static bool GYpiros = false;
        private static bool Dpiros = false;
        #region Hianycikk vizsgalat a hianycikk buttonnnak piros lesz és kiirja hol van baj
        public void hianycikk() 
        {
            for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
            {
                if (SzerverData.MaszInfokOsszes[i].KeszletraktarBudapest < 20)
                {
                    BPpiros = true;
                }
            }
            for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
            {
                if (SzerverData.MaszInfokOsszes[i].KeszletraktarGyor < 20)
                {
                    GYpiros = true;
                }
            }
            for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
            {
                if (SzerverData.MaszInfokOsszes[i].KeszletraktarDebrecen < 20)
                {
                    Dpiros = true;
                }
            }
            if (BPpiros == true)
            {
                button_Hianycikk.Text = button_Hianycikk.Text + "; BP";
                button_Hianycikk.ForeColor = Color.FromArgb(150, 35, 42);
            }
            if (GYpiros == true)
            {
                button_Hianycikk.Text = button_Hianycikk.Text + "; GY";
                button_Hianycikk.ForeColor = Color.FromArgb(150, 35, 42);
            }
            if (Dpiros == true)
            {
                button_Hianycikk.Text = button_Hianycikk.Text + "; D";
                button_Hianycikk.ForeColor = Color.FromArgb(150, 35, 42);
            }
        }
        #endregion

        private void button_Frissítés_Click(object sender, EventArgs e)
        {
            Tisztalista();
            listBox_Hianycikk.Items.Clear();

            if (checkBox_BP.Checked == false && checkBox_D.Checked == false && checkBox_Gy.Checked == false)
            {
                listBox_Hianycikk.Items.Clear();
            }
            if (checkBox_BP.Checked == true)
            {
                for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                {
                    if (SzerverData.MaszInfokOsszes[i].KeszletraktarBudapest < 20)
                    {
                        listBox_Hianycikk.Items.Add(SzerverData.MaszInfokOsszes[i].Maszktipus + ";" + SzerverData.MaszInfokOsszes[i].Maszknev + ";" + SzerverData.MaszInfokOsszes[i].KeszletraktarBudapest + "; BUdapest");
                    }
                }
            }
            if (checkBox_Gy.Checked == true)
            {
                for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                {
                    if (SzerverData.MaszInfokOsszes[i].KeszletraktarGyor < 20)
                    {
                        listBox_Hianycikk.Items.Add(SzerverData.MaszInfokOsszes[i].Maszktipus + ";" + SzerverData.MaszInfokOsszes[i].Maszknev + ";" + SzerverData.MaszInfokOsszes[i].KeszletraktarGyor + "; Győr");
                    }
                }
            }
            if (checkBox_D.Checked == true)
            {
                for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                {
                    if (SzerverData.MaszInfokOsszes[i].KeszletraktarDebrecen < 20)
                    {
                        listBox_Hianycikk.Items.Add(SzerverData.MaszInfokOsszes[i].Maszktipus + ";" + SzerverData.MaszInfokOsszes[i].Maszknev + ";" + SzerverData.MaszInfokOsszes[i].KeszletraktarDebrecen + "; Debrecen");
                    }
                }
            }
        }

        ///kódgenerátor
       /* public static string GazmaszkKodgenerator(string maszktipuska, string maszknevecske)
        {
            
            
            string genszamvege = "";
            //12 számot tesz az azonosítójához 
            for (int i = 0; i < 10; i++)
            {
                genszamvege += Convert.ToString(rnd.Next(0, 9));
            }
            string elotag1 = maszktipuska.Substring(0, 2);
            string elotag2 = maszknevecske.Substring(0, 1);
            string Generaltkod = elotag1 + elotag2 + genszamvege;
            //return generáltkód
            return Generaltkod;
            //text.Text = Generaltkod;
            //System.Diagnostics.Debug.Write(Generaltkod);
        }

        public static void termekhozzaadasEgyDarab(string maszktipuska, string maszknevecske, int darabszam)
        {
            // Primary ID
            int maszkaruID = 0;// Maszkaru ID
            // maszkaru kereses
            for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
            {
                if (SzerverData.MaszInfokOsszes[i].Maszktipus == maszktipuska && SzerverData.MaszInfokOsszes[i].Maszknev == maszknevecske)
                {
                    maszkaruID = SzerverData.MaszInfokOsszes[i].Id;
                }
            }

            ////// 1 TERMEK //////
            
            string vonalkod = "";

            for (int i = 0; i < darabszam; i++)
            {
                vonalkod = GazmaszkKodgenerator(maszktipuska, maszknevecske);// VONALKOD
                try
                {
                    using (SqlConnection Csatlakozas = new SqlConnection(SzerverData.SzerverInfoAdmin))
                    {
                        string Feltoltes = $"INSERT INTO Vonalkod VALUES (@barcode,@aru)"; //Adatok feltöltése
                        using (SqlCommand Parancs = new SqlCommand(Feltoltes, Csatlakozas))
                        {
                            Parancs.Parameters.AddWithValue("@barcode", vonalkod); //Genralt kód public static fielbe
                            Parancs.Parameters.AddWithValue("@aru", maszkaruID); //Hivatkozott paraméter értékeinek megadása
                            System.Diagnostics.Debug.WriteLine(" Ez az ID: " + maszkaruID);
                            System.Diagnostics.Debug.Write(vonalkod);
                            Csatlakozas.Open(); //Csatlakozási folyamat megnyitása
                            var result = Parancs.ExecuteNonQuery();
                            Parancs.Dispose();
                            // Hiba keresés, ha nem lett eredmény
                            if (result < 0)
                            { MessageBox.Show("Hiba az adatfeltöltés során!"); } //Hibaüzenet
                            Csatlakozas.Close(); //Csatlakozási folyamat lezárása
                        }
                    }
                }
                catch (Exception) //Kivétel megadása, ha a try részben lévő kód nem fut le.
                { MessageBox.Show("Nem sikerült a vonalkod csalakozás"); }
            }


        }*/

    }
}
