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
        public static List<Trosak> GetTroskovi()
        {
            List<Trosak> troskovi = new List<Trosak>();

            string sql = $"SELECT * FROM Troskovi JOIN VrsteTroskova ON VrsteTroskova.ID_naziva = Troskovi.ID_naziva JOIN Kategorije ON VrsteTroskova.ID_kategorije = Kategorije.ID_kategorije";
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
            int idVrste = int.Parse(reader["ID_naziva"].ToString());
            string nazivVrste = reader["naziv_vrste"].ToString();
            string kategorije = reader["naziv_kategorije"].ToString();

            Trosak trosak = new Trosak(id, iznos , opis, datumTroska, idVrste, nazivVrste, kategorije);

            return trosak;
        }

        public static void InsertTrosak(Trosak trosak)
        {
            string sql = $"INSERT INTO Troskovi (iznos_troska, opis, datum_troska, ID_korisnice,ID_naziva) VALUES( '{trosak.Iznos}','{trosak.Opis}','{trosak.DatumTroska.ToString("yyyy-MM-dd HH:mm:ss")}',1,'{trosak.IdVrste}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static Dictionary<int, string> GetNaziviVrsta()
        {
            Dictionary<int, string> vrsteDictionary = new Dictionary<int, string>();

            string sql = "SELECT ID_naziva, naziv_vrste FROM VrsteTroskova";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                int id = int.Parse(reader["ID_naziva"].ToString());
                string nazivVrste = reader["naziv_vrste"].ToString();
                vrsteDictionary.Add(id, nazivVrste);
            }
            reader.Close();
            DB.CloseConnection();

            return vrsteDictionary;
        }

        public static void DeleteTrosak(int id)
        {
            string sql = $"DELETE FROM Troskovi WHERE ID_troska = {id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }


    }
}
