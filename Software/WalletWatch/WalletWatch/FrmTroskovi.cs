using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WalletWatch.Models;
using WalletWatch.Repositories;

namespace WalletWatch
{
    public partial class FrmTroskovi : Form
    {
        public FrmTroskovi()
        {
            InitializeComponent();
        }

        private void FrmTroskovi_Load(object sender, EventArgs e)
        {
            ShowTroskovi();
        }
        private void ShowTroskovi()
        {
            List<Trosak> troskovi = TroskoviRepository.GetTroskovi();
            dgvTroskovi.DataSource = troskovi;

        }

        private void btnUnesiNovi_Click(object sender, EventArgs e)
        {
            FrmUnosTroska frmUnosTroska = new FrmUnosTroska();
            frmUnosTroska.ShowDialog();
            dgvTroskovi.Refresh();
        }
    }
}
