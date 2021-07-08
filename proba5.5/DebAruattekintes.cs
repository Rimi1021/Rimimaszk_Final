using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proba5._5
{
    public partial class DebAruattekintes : UserControl
    {
        public DebAruattekintes()
        {
            InitializeComponent();
        }
        private static string Maszktipus = "";
        private static string Masznev = "";
        private static string txtboxdefault = "Áru";
        private void comboBox_Maszktipus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fuggvenycoboboxra(comboBox_Maszktipus, comboBox_Maszknev);
            Maszktipus = comboBox_Maszktipus.SelectedItem.ToString();
        }

        private void comboBox_Maszknev_SelectedIndexChanged(object sender, EventArgs e)
        {
            Masznev = comboBox_Maszknev.SelectedItem.ToString();
        }

        private void button_Listazas_Click(object sender, EventArgs e)
        {
            Listazasfuggveny(radioButton_BP,radioButton_GY, radioButton_Debrecen, listBox1, Maszktipus, Masznev);
        }

        private void button_Torles_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button_Export_Click(object sender, EventArgs e)
        {
            if (txtboxdefault != "" && BPAruattekintes.rx.IsMatch(txtboxdefault)) //Regex a budapestAruattekintesbol
            {
                txtboxdefault += ".csv";
                if (listBox1.Items != null)
                {
                    StreamWriter Iro = new StreamWriter(txtboxdefault, false, Encoding.Default);
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        Iro.WriteLine(listBox1.Items[i].ToString());
                    }
                    Iro.Close();
                    MessageBox.Show("Az írási folyamat végrehajtva");
                }
                else
                {
                    MessageBox.Show("Először listázza ki az exportálandó adatokat");
                }
            }
            else
            {
                MessageBox.Show("Adjon nevet a CSV fájlnak és ne használjon speciális karaktereket");
            }
        }

        private void textBox_Export_TextChanged(object sender, EventArgs e)
        {
            txtboxdefault = textBox_Export.Text;
        }



        /// <summary>
        /// Listázás fuggveny
        /// </summary>
        public static void Listazasfuggveny(RadioButton BP, RadioButton GY, RadioButton D, ListBox LB, string masktype, string maskname) 
        {
            if (BP.Checked == false && GY.Checked == false && D.Checked == false)
            {
                MessageBox.Show("Válassza ki melyik telephelyen lévő raktárkészletre kíváncsi!");
            }
            else if (masktype == "" || maskname == "")
            {
                MessageBox.Show("Válassza ki melyik terméktipusokat szertné kilistázni");
            }
            else
            {
                AdminRaktar.Tisztalista();

                ///Budapest
                if (BP.Checked == true)
                {
                    LB.Items.Add("Budapesti készlet:");
                    if (masktype == "Osszes" && maskname != "Osszes")
                    {
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            if (SzerverData.MaszInfokOsszes[i].Maszknev == maskname)
                            {
                                LB.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarBudapest} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                    $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                            }
                        }
                    }
                    else if (maskname == "Osszes" && masktype != "Osszes")
                    {
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            if (SzerverData.MaszInfokOsszes[i].Maszktipus == masktype)
                            {
                                LB.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarBudapest} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                   $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                            }
                        }
                    }
                    else if (maskname == "Osszes" && masktype == "Osszes")
                    {
                        LB.Items.Clear();
                        LB.Items.Add("Összes Maszktípus/Maszknev:");
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            LB.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarBudapest} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                    $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                        }
                    }
                    else
                    {
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            if (SzerverData.MaszInfokOsszes[i].Maszktipus == masktype && SzerverData.MaszInfokOsszes[i].Maszknev == maskname)
                            {
                                LB.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarBudapest} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                   $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                            }
                        }
                    }
                }

                /// Győr
                else if (GY.Checked == true)
                {
                    LB.Items.Add("Győri készlet:");
                    if (masktype == "Osszes" && maskname != "Osszes")
                    {
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            if (SzerverData.MaszInfokOsszes[i].Maszknev == maskname)
                            {
                                LB.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarGyor} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                   $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                            }
                        }
                    }
                    else if (maskname == "Osszes" && masktype != "Osszes")
                    {
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            if (SzerverData.MaszInfokOsszes[i].Maszktipus == masktype)
                            {
                                LB.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarGyor} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                    $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                            }
                        }
                    }
                    else if (maskname == "Osszes" && masktype == "Osszes")
                    {
                        LB.Items.Clear();
                        LB.Items.Add("Összes Maszktípus/Maszknev:");
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            LB.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarGyor} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                   $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                        }
                    }
                    else
                    {
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            if (SzerverData.MaszInfokOsszes[i].Maszktipus == masktype && SzerverData.MaszInfokOsszes[i].Maszknev == maskname)
                            {
                                LB.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarGyor} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                   $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                            }
                        }
                    }
                }

                //Debrecen
                else
                {
                    LB.Items.Add("Debreceni készlet:");
                    if (masktype == "Osszes" && maskname != "Osszes")
                    {
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            if (SzerverData.MaszInfokOsszes[i].Maszknev == maskname)
                            {
                                LB.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarDebrecen} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                   $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                            }
                        }
                    }
                    else if (maskname == "Osszes" && masktype != "Osszes")
                    {
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            if (SzerverData.MaszInfokOsszes[i].Maszktipus == masktype)
                            {
                                LB.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarDebrecen} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                    $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                            }
                        }
                    }
                    else if (maskname == "Osszes" && masktype == "Osszes")
                    {
                        /*
                         LB.Items.Clear();
                        LB.Items.Add("Összes Maszktípus/Maszknev:");
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            LB.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarGyor} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                   $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                        }
                         */
                        LB.Items.Clear();
                        LB.Items.Add("Összes Maszktípus/Maszknev:");
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            LB.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarDebrecen} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                   $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                        }
                    }
                    else
                    {
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            if (SzerverData.MaszInfokOsszes[i].Maszktipus == masktype && SzerverData.MaszInfokOsszes[i].Maszknev == maskname)
                            {
                                LB.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarDebrecen} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                   $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                            }
                        }
                    }
                }
            }
        }

        //Fuggveny a comboboxokra
        public static void Fuggvenycoboboxra(ComboBox combomaszktipus, ComboBox combomaszknev)
        {
            if (combomaszktipus.SelectedIndex == 0)
            {
                combomaszknev.Items.Clear();
                combomaszknev.Items.Add("Kek");
                combomaszknev.Items.Add("Terepmintas");
                combomaszknev.Items.Add("Zold");
                combomaszknev.Items.Add("Fekete");
                combomaszknev.Items.Add("Piros");
                combomaszknev.Items.Add("Feher");
                combomaszknev.Items.Add("Osszes");
                combomaszknev.Text = "Maszknév";
            }
            else if (combomaszktipus.SelectedIndex == 1)
            {
                combomaszknev.Items.Clear();
                combomaszknev.Items.Add("Kek");
                combomaszknev.Items.Add("Rozsaszin");
                combomaszknev.Items.Add("Zold");
                combomaszknev.Items.Add("Fekete");
                combomaszknev.Items.Add("Sarga");
                combomaszknev.Items.Add("Feher");
                combomaszknev.Items.Add("Osszes");
                combomaszknev.Text = "Maszknév";
            }
            else if (combomaszktipus.SelectedIndex == 2)
            {
                combomaszknev.Items.Clear();
                combomaszknev.Items.Add("Kek");
                combomaszknev.Items.Add("Terepmintas");
                combomaszknev.Items.Add("Zold");
                combomaszknev.Items.Add("Fekete");
                combomaszknev.Items.Add("Sarga");
                combomaszknev.Items.Add("Feher");
                combomaszknev.Items.Add("Osszes");
                combomaszknev.Text = "Maszknév";
            }
            else if (combomaszktipus.SelectedIndex == 3)
            {
                combomaszknev.Items.Clear();
                combomaszknev.Items.Add("Kek");
                combomaszknev.Items.Add("Terepmintas");
                combomaszknev.Items.Add("Zold");
                combomaszknev.Items.Add("Fekete");
                combomaszknev.Items.Add("Sarga");
                combomaszknev.Items.Add("Feher");
                combomaszknev.Items.Add("Osszes");
                combomaszknev.Text = "Maszknév";
            }
            else if (combomaszktipus.SelectedIndex == 4)
            {
                combomaszknev.Items.Clear();
                combomaszknev.Items.Add("Kek");
                combomaszknev.Items.Add("Hupikek");
                combomaszknev.Items.Add("Zold");
                combomaszknev.Items.Add("Fekete");
                combomaszknev.Items.Add("Rozsaszin");
                combomaszknev.Items.Add("Feher");
                combomaszknev.Items.Add("Osszes");
                combomaszknev.Text = "Maszknév";
            }
            else if (combomaszktipus.SelectedIndex == 5)
            {
                combomaszknev.Items.Clear();
                combomaszknev.Items.Add("Marvel");
                combomaszknev.Items.Add("DC");
                combomaszknev.Items.Add("Frozen");
                combomaszknev.Items.Add("Csipkes");
                combomaszknev.Items.Add("Shrek");
                combomaszknev.Items.Add("Memes");
                combomaszknev.Items.Add("Osszes");
                combomaszknev.Text = "Maszknév";
            }
            else
            {
                combomaszknev.Items.Clear();
                combomaszknev.Items.Add("Marvel");
                combomaszknev.Items.Add("DC");
                combomaszknev.Items.Add("Frozen");
                combomaszknev.Items.Add("Csipkes");
                combomaszknev.Items.Add("Shrek");
                combomaszknev.Items.Add("Memes");
                combomaszknev.Items.Add("Kek");
                combomaszknev.Items.Add("Terepmintas");
                combomaszknev.Items.Add("Zold");
                combomaszknev.Items.Add("Fekete");
                combomaszknev.Items.Add("Sarga");
                combomaszknev.Items.Add("Feher");
                combomaszknev.Items.Add("Piros");
                combomaszknev.Items.Add("Hupikek");
                combomaszknev.Items.Add("Rozsaszin");
                combomaszknev.Items.Add("Osszes");
            }
        }
    }
}
