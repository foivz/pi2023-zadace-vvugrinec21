using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WalletWatch.Models;

namespace WalletWatch.Repositories
{
    public static class ExpenseRepository
    {
        public static Expense GetExpense(int id)
        {
            Expense expense = null;
            string sql = $"SELECT * FROM Troskovi WHERE ID_troska = {id}";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                expense = CreateObject(reader);
                reader.Close();

            }
            DB.CloseConnection();
            return expense;
        }
        public static List<Expense> GetExpenses()
        {
            List<Expense> expenses = new List<Expense>();

            string sql = $"SELECT * FROM Troskovi JOIN VrsteTroskova ON VrsteTroskova.ID_naziva = Troskovi.ID_naziva JOIN Kategorije ON VrsteTroskova.ID_kategorije = Kategorije.ID_kategorije";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Expense expense = CreateObject(reader);
                expenses.Add(expense);
            } 
            reader.Close();
            DB.CloseConnection();

            return expenses;
        }
        public static List<Expense> GetExpenses(string keyword)
        {
            string sql = $"SELECT * FROM Troskovi " +
                         $"JOIN VrsteTroskova ON VrsteTroskova.ID_naziva = Troskovi.ID_naziva " +
                         $"JOIN Kategorije ON VrsteTroskova.ID_kategorije = Kategorije.ID_kategorije " +
                         $"WHERE Troskovi.iznos_troska LIKE '%{keyword}%' OR " +
                         $"Troskovi.description LIKE '%{keyword}%' OR " +
                         $"Troskovi.datum_troska LIKE '%{keyword}%' OR " +
                         $"Troskovi.ID_troska LIKE '%{keyword}%' OR " +
                         $"VrsteTroskova.ID_naziva LIKE '%{keyword}%' OR " +
                         $"VrsteTroskova.naziv_vrste LIKE '%{keyword}%' OR " +
                         $"Kategorije.ID_kategorije LIKE '%{keyword}%' OR " +
                         $"Kategorije.naziv_kategorije LIKE '%{keyword}%'";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            List<Expense> expenses = new List<Expense>();

            while (reader.Read())
            {
                Expense expense = CreateObject(reader);
                expenses.Add(expense);
            }

            reader.Close();
            DB.CloseConnection();

            return expenses;
        }


        private static Expense CreateObject(SqlDataReader reader)
        {

            int id = int.Parse(reader["ID_troska"].ToString());
            int value = int.Parse(reader["iznos_troska"].ToString());
            string description = reader["description"].ToString();
            DateTime expenseDate = DateTime.Parse(reader["datum_troska"].ToString());
            int idType = int.Parse(reader["ID_naziva"].ToString());
            string expenseType = reader["naziv_vrste"].ToString();
            string category = reader["naziv_kategorije"].ToString();

            Expense expense = new Expense(id, value , description, expenseDate, idType, expenseType, category);

            return expense;
        }

        public static void InsertExpense(Expense expense)
        {
            string sql = $"INSERT INTO Troskovi (iznos_troska, description, datum_troska, ID_korisnice,ID_naziva) VALUES( '{expense.Value}','{expense.Description}','{expense.ExpenseDate.ToString("yyyy-MM-dd HH:mm:ss")}',1,'{expense.IdType}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static Dictionary<int, string> GetExpenseType()
        {
            Dictionary<int, string> vrsteDictionary = new Dictionary<int, string>();

            string sql = "SELECT ID_naziva, naziv_vrste FROM VrsteTroskova";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                int id = int.Parse(reader["ID_naziva"].ToString());
                string expenseType = reader["naziv_vrste"].ToString();
                vrsteDictionary.Add(id, expenseType);
            }
            reader.Close();
            DB.CloseConnection();

            return vrsteDictionary;
        }

        public static void DeleteExpense(int id)
        {
            string sql = $"DELETE FROM Troskovi WHERE ID_troska = {id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void UpdateExpense(Expense expense)
        {
            string sql = $"UPDATE Troskovi SET iznos_troska = {expense.Value}, description = '{expense.Description}', datum_troska = '{expense.ExpenseDate.ToString("yyyy-MM-dd HH:mm:ss")}', ID_korisnice = 1, ID_naziva = {expense.IdType} WHERE ID_troska = {expense.Id}";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

    }
}
