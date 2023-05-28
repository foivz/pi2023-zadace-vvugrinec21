using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WalletWatch.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }   
        public DateTime ExpenseDate { get; set; }
        public int IdType { get; set; }
        public string ExpenseType { get; set; }

        public string Category { get; set; }
        public Expense(int id, int value, string description, DateTime expenseDate, int idType,  string expenseType, string category)
        {
            Id = id;
            Value = value;
            Description = description;
            ExpenseDate = expenseDate;
            ExpenseType = expenseType;
            Category = category;
            IdType = idType;
        }
        public Expense() { }
    }
}
