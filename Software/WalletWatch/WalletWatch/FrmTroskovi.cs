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
            frmUnosTroska.FormClosed += FrmUnosTroska_FormClosed;
            frmUnosTroska.ShowDialog();
        }
        private void FrmUnosTroska_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowTroskovi();
        }

        private void dgvTroskovi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvTroskovi.Rows[e.RowIndex].Selected = true;
            }
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvTroskovi.SelectedRows.Count > 0)
            {
                int trosakId = Convert.ToInt32(dgvTroskovi.SelectedRows[0].Cells["Id"].Value);
                TroskoviRepository.DeleteTrosak(trosakId);
                ShowTroskovi();
            }
        }
        private void btnPretrazi_Click_1(object sender, EventArgs e)
        {
            string kljucnaRijec = txtPretrazivanje.Text;
            PretraziTroskove(kljucnaRijec);
        }

        private void PretraziTroskove(string kljucnaRijec)
        {
            int trenutnaPozicija = dgvTroskovi.CurrentRow?.Index ?? -1;

            //spremanje trenutne pozicije

            List<Trosak> troskovi = TroskoviRepository.GetTroskovi();

            List<Trosak> filtriraniTroskovi = troskovi.Where(trosak =>
                trosak.Iznos.ToString().IndexOf(kljucnaRijec, StringComparison.OrdinalIgnoreCase) >= 0 ||
                trosak.Opis.IndexOf(kljucnaRijec, StringComparison.OrdinalIgnoreCase) >= 0 ||
                trosak.DatumTroska.ToString().IndexOf(kljucnaRijec, StringComparison.OrdinalIgnoreCase) >= 0

            ).ToList();

            dgvTroskovi.DataSource = filtriraniTroskovi;

            if (trenutnaPozicija >= 0 && trenutnaPozicija < dgvTroskovi.Rows.Count)
            {
                dgvTroskovi.Rows[trenutnaPozicija].Selected = true;
            }
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvTroskovi.SelectedRows.Count > 0)
            {
                
                Trosak selectedTrosak = dgvTroskovi.SelectedRows[0].DataBoundItem as Trosak;

                FrmUpdateData frmUpdateData= new FrmUpdateData(selectedTrosak);

                frmUpdateData.FormClosed += FrmUpdateData_FormClosed;
              
                frmUpdateData.ShowDialog();
            }
        }
        private void FrmUpdateData_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowTroskovi();
        }
    }
}
