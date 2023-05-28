using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletWatch.Models;

namespace WalletWatch.Repositories
{
    public static class CategoryRepository
    {

        public static string GetCategoryName(int id)
        {
            string categoryName = null;
            string sql = $"SELECT Kategorije.naziv_kategorije FROM VrsteTroskova " +
                         $"JOIN Kategorije ON VrsteTroskova.ID_kategorije = Kategorije.ID_kategorije " +
                         $"WHERE VrsteTroskova.ID_naziva = {id}";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                categoryName = reader["naziv_kategorije"].ToString();
            }
            reader.Close();
            DB.CloseConnection();

            return categoryName;
        }

    }
}
