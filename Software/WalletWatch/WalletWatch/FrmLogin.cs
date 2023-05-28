using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WalletWatch.Repositories;

namespace WalletWatch
{
    public partial class FrmLogin : Form
    {

        string password = KorisnicaRepository.GetPassword();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == password) {
                MessageBox.Show("Uspješno ste se logirali", "Prijvaljeni ste", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
                
                FrmTroskovi frmTroskovi = new FrmTroskovi();
                Hide();
                frmTroskovi.ShowDialog();
                Close();

            }
            else
            {
                MessageBox.Show("Korisnička lozinka je kriva", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

        }
    }
}
