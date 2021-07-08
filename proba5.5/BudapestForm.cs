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
    public partial class BudapestForm : Form
    {
        public BudapestForm()
        {
            InitializeComponent();
            Nev(label_Nev);
            bpkezdopanel1.Show();
            bpkezdopanel1.BringToFront();
        }
        public static void Nev(Label nev)
        {
            nev.Text = LoginForm.profilnev;
        }

        private void button_Kilepes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztosan ki szeretne lépni?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close(); //Ha a „No” kattintunk, akkor nem csinálunk semmit, a feltétel miatt, ez persze lehet másik „gomb” is!
            }
            else
            {
                return;
            }
        }

        private void button_Kijelentkezes_Click(object sender, EventArgs e)
        {
            LoginForm Bejelentkezes = new LoginForm();
            this.Hide();
            Bejelentkezes.Show();
            Bejelentkezes.BringToFront();
        }

        private void button_Eladas_Click(object sender, EventArgs e)
        {
            bpkezdopanel1.Hide();
            bpAruattekintes1.Hide();
            bpEladas1.BringToFront();
            bpEladas1.Show();
        }

        private void button_Aruk_Click(object sender, EventArgs e)
        {
            bpkezdopanel1.Hide();
            bpEladas1.Hide();
            bpAruattekintes1.Show();
            bpAruattekintes1.BringToFront();
        }
    }
}
