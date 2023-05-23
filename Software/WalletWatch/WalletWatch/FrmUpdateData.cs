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
    public partial class FrmUpdateData : Form
    {
        private Trosak trosak;
        public FrmUpdateData(Trosak selectedTrosak)
        {
            InitializeComponent();
            trosak = selectedTrosak;

            txtValueUpdate.Text = trosak.Iznos.ToString();
            txtDescUpdate.Text = trosak.Opis;
            datDateUpdate.Value = trosak.DatumTroska;

            Dictionary<int, string> vrsteDictionary = TroskoviRepository.GetNaziviVrsta();
            cboSelection.DataSource = new BindingSource(vrsteDictionary, null);
            cboSelection.DisplayMember = "Value";
            cboSelection.ValueMember = "Key";


            int vrstaTroskaId = trosak.IdVrste;

            if (vrsteDictionary.ContainsKey(vrstaTroskaId))
            {
                string vrstaTroskaNaziv = vrsteDictionary[vrstaTroskaId];
                int selectedIndex = cboSelection.FindStringExact(vrstaTroskaNaziv);

                if (selectedIndex >= 0)
                {
                    cboSelection.SelectedIndex = selectedIndex;
                }
            }
        }

        private void FrmUpdateData_Load(object sender, EventArgs e)
        {
            {

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int iznos = int.Parse(txtValueUpdate.Text);
            string opis = txtDescUpdate.Text;
            DateTime datumTroska = datDateUpdate.Value;
            int vrstaTroskaId = ((KeyValuePair<int, string>)cboSelection.SelectedItem).Key;

            trosak.Iznos = iznos;
            trosak.Opis = opis;
            trosak.DatumTroska = datumTroska;
            trosak.IdVrste = vrstaTroskaId;

            TroskoviRepository.UpdateTrosak(trosak);

            MessageBox.Show("Trosak je uspješno ažuriran.");
  
            Close();
        }
    }
}
