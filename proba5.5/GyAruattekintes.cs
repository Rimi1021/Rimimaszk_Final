using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proba5._5
{
    public partial class GyAruattekintes : UserControl
    {
        public GyAruattekintes()
        {
            InitializeComponent();
        }
        private static string Maszktipus = "";
        private static string Masznev = "";
        private static string txtboxdefault = "Áru";
        public static Regex rx = new Regex(@"^[a-zA-Z0-9]+$");

        private void comboBox_Masktipus_SelectedIndexChanged(object sender, EventArgs e)
        {
            DebAruattekintes.Fuggvenycoboboxra(comboBox_Masktipus, comboBox_Maszknev);
            Maszktipus = comboBox_Masktipus.SelectedItem.ToString();
        }

        private void comboBox_Maszknev_SelectedIndexChanged(object sender, EventArgs e)
        {
            Masznev = comboBox_Maszknev.SelectedItem.ToString();
        }

        private void button_Listazas_Click(object sender, EventArgs e)
        {
            DebAruattekintes.Listazasfuggveny(radioButton_BP, radioButton_GY, radioButton_D, listBox1, Maszktipus, Masznev);
        }

        private void button_Listboxtorles_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void textBox_export_TextChanged(object sender, EventArgs e)
        {
            txtboxdefault = textBox_export.Text;
        }

        private void button_Export_Click(object sender, EventArgs e)
        {
            if (txtboxdefault != "" && rx.IsMatch(txtboxdefault))
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
                MessageBox.Show("Adjon nevet a CSV fájlnak, ne használjon speciális karaktert!");
            }
        }
    }
}
