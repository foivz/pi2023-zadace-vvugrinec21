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
    public partial class FrmExpensesInput : Form
    {
        public FrmExpensesInput()
        {
            InitializeComponent();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            int iznosTroska = Convert.ToInt32(txtIznos.Text);
            string opis = txtOpis.Text;
            DateTime datumTroska = dtpDatumTroska.Value;
            int idNaziva = Convert.ToInt32(cboVrste.SelectedValue);


            Expense expense = new Expense();
            expense.Value = iznosTroska;
            expense.Description = opis;
            expense.ExpenseDate = datumTroska;
            expense.IdType = idNaziva;

            ExpenseRepository.InsertExpense(expense);


            MessageBox.Show("Trosak je uspješno dodan.");
        }

        private void FrmUnosTroska_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> vrsteDictionary = ExpenseRepository.GetExpenseType();
            cboVrste.DataSource = new BindingSource(vrsteDictionary, null);
            cboVrste.DisplayMember = "Value";
            cboVrste.ValueMember = "Key";
            
        }

        private void cboVrste_SelectedIndexChanged(object sender, EventArgs e)
        {
            // int idNaziva = Convert.ToInt32(cboVrste.SelectedValue);

            if (cboVrste.SelectedValue != null)
            {
                if (int.TryParse(cboVrste.SelectedValue.ToString(), out int id))
                {
                    string categoryName = CategoryRepository.GetCategoryName(id);
                    if (!string.IsNullOrEmpty(categoryName))
                    {
                        txtCategoryShow.Text = categoryName;
                    }
                }
            }


        }

    }
}
