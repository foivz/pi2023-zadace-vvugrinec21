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

        public static string GetCategoryName()
        {
            string nazivKategorije = string.Empty;

            string sql = "SELECT naziv_kategorije FROM Kategorije,VrsteTroskova WHERE Kategorije.ID_kategorije = VrsteTroskova.ID_kategorije";
            DB.OpenConnection();
            {
                var reader = DB.GetDataReader(sql);
                while (reader.Read())
                {
                    Category category = CreateObject(reader);
                    if (category != null)
                    {
                        nazivKategorije = category.ToString();
                    }
                }
            }

            return nazivKategorije;
        }

        private static Category CreateObject(SqlDataReader reader)
        {
            string kategorije = reader["naziv_kategorije"].ToString();
            Category category= new Category(kategorije);

            return category;
        }
    }
}
