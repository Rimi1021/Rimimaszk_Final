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
    public partial class GyorForm : Form
    {
        public GyorForm()
        {
            InitializeComponent();
            gykezdopanel1.Show();
            gykezdopanel1.BringToFront();
            BudapestForm.Nev(labelnev);
        }

        private void button_Eladas_Click(object sender, EventArgs e)
        {
            gykezdopanel1.Hide();
            gyAruattekintes1.Hide();
            gyeladas1.Show();
            gyeladas1.BringToFront();
        }

        private void button_Aruk_Click(object sender, EventArgs e)
        {
            gykezdopanel1.Hide();
            gyeladas1.Hide();
            gyAruattekintes1.Show();
            gyAruattekintes1.BringToFront();
        }

        private void button_Kijelentkezes_Click(object sender, EventArgs e)
        {
            LoginForm Bejelentkezes = new LoginForm();
            this.Hide();
            Bejelentkezes.Show();
            Bejelentkezes.BringToFront();
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
    }
}
