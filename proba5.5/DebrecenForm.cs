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
    public partial class DebrecenForm : Form
    {
        public DebrecenForm()
        {
            InitializeComponent();
            BudapestForm.Nev(labelnev);
            debrecenkezdopanel1.Show();
            debrecenkezdopanel1.BringToFront();
        }

        private void button_Kijelentkezes_Click(object sender, EventArgs e)
        {
            LoginForm Bejelentkezes = new LoginForm();
            this.Hide();
            Bejelentkezes.Show();
            Bejelentkezes.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button_eladas_Click(object sender, EventArgs e)
        {
            debrecenkezdopanel1.Hide();
            debraktarattekintes1.Hide();
            debEladas1.Show();
            debEladas1.BringToFront();
        }

        private void button_Aruk_Click(object sender, EventArgs e)
        {
            debEladas1.Hide();
            debrecenkezdopanel1.Hide();
            debraktarattekintes1.Show();
            debraktarattekintes1.BringToFront();
        }
    }
}
