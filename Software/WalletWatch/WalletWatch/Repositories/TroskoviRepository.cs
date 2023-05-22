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
    public static class TroskoviRepository
    {
        public static Trosak GetTrosak(int id)
        {
            Trosak trosak = null;
            string sql = $"SELECT * FROM Troskovi WHERE ID_troska = {id}";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                trosak = CreateObject(reader);
                reader.Close();

            }
            DB.CloseConnection();
            return trosak;
        }
        public static List<Trosak> GetTrosaks(int id)
        {
            List<Trosak> troskovi = new List<Trosak>();

            string sql = "SELECT * FROM Troskovi";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Trosak trosak = CreateObject(reader);
                troskovi.Add(trosak);
            }
            reader.Close();
            DB.CloseConnection();

            return troskovi;
        }
        private static Trosak CreateObject(SqlDataReader reader)
        {
            
            int id = int.Parse(reader["ID_troska"].ToString());
            int iznos = int.Parse(reader["iznos_troska"].ToString());
            string opis = reader["opis"].ToString();
            DateTime datumTroska = DateTime.Parse(reader["datum_troska"].ToString());

            Trosak trosak = new Trosak(id,iznos,opis,datumTroska);

            return trosak;
        }   


    }
}
