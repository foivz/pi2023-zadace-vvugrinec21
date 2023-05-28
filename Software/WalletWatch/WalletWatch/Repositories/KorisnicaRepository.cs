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
    public static class KorisnicaRepository
    {

    
    public static string GetPassword()
    {
        string password = null;
        string sql = $"SELECT lozinka FROM Korisnica WHERE id_korisnice = 1";

        DB.OpenConnection();
        var reader = DB.GetDataReader(sql);
        if (reader.HasRows)
        {
            reader.Read();
            password = reader["lozinka"].ToString();
        }
        reader.Close();
        DB.CloseConnection();

            return password;
        }

    }


}
