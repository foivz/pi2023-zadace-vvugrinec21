using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WalletWatch.Models
{
    public class Trosak
    {
        public int Id { get; set; }
        public int Iznos { get; set; }
        public string Opis { get; set; }   
        public DateTime DatumTroska { get; set; }
        public int IdVrste { get; set; }
        public string VrstaTroska { get; set; }
        
        public string Katgorije { get; set; }
        public Trosak(int id, int iznos, string opis, DateTime datumTroska, int idVrste,  string vrstaTroska, string katgorije)
        {
            Id = id;
            Iznos = iznos;
            Opis = opis;
            DatumTroska = datumTroska;
            VrstaTroska = vrstaTroska;
            Katgorije = katgorije;
            IdVrste = idVrste;
        }
        public Trosak() { }
    }
}
