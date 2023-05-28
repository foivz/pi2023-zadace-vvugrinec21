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
    public partial class FrmExpenses : Form
    {
        public FrmExpenses()
        {
            InitializeComponent();
        }

        private void FrmExpenses_Load(object sender, EventArgs e)
        {
            ShowExpenses();
        }
        private void ShowExpenses()
        {
            List<Expense> expenses = ExpenseRepository.GetExpenses();
            dgvExpenses.DataSource = expenses;

            dgvExpenses.Columns["Id"].HeaderText = "Identifikacijski broj troška";
            dgvExpenses.Columns["ExpenseDate"].HeaderText = "Datum troška";
            dgvExpenses.Columns["IdType"].HeaderText = "Identifikiacijski broj vrste troska";
            dgvExpenses.Columns["ExpenseType"].HeaderText = "Vrsta troška";
            dgvExpenses.Columns["Category"].HeaderText = "Kategorija";
        }

        private void btnUnesiNovi_Click(object sender, EventArgs e)
        {
            FrmExpensesInput frmExpensesInput = new FrmExpensesInput();
            frmExpensesInput.FormClosed += FrmExpensesInput_FormClosed;
            frmExpensesInput.ShowDialog();
        }
        private void FrmExpensesInput_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowExpenses();
        }

        private void dgvExpenses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvExpenses.Rows[e.RowIndex].Selected = true;
            }
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.SelectedRows.Count > 0)
            {
                int expenseId = Convert.ToInt32(dgvExpenses.SelectedRows[0].Cells["Id"].Value);
                ExpenseRepository.DeleteExpense(expenseId);
                ShowExpenses();
            }
        }
        private void btnPretrazi_Click_1(object sender, EventArgs e)
        {
            string keyword = txtPretrazivanje.Text;
            List<Expense> results = ExpenseRepository.GetExpenses(keyword);
            dgvExpenses.DataSource = results;
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.SelectedRows.Count > 0)
            {
                
                Expense selectedExpense = dgvExpenses.SelectedRows[0].DataBoundItem as Expense;

                FrmUpdateData frmUpdateData= new FrmUpdateData(selectedExpense);

                frmUpdateData.FormClosed += FrmUpdateData_FormClosed;
              
                frmUpdateData.ShowDialog();
            }
        }
        private void FrmUpdateData_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowExpenses();
        }
    }
}
