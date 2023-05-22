﻿using System;
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

        public Trosak(int id, int iznos, string opis, DateTime datumTroska)
        {
            Id = id;
            Iznos = iznos;
            Opis = opis;
            DatumTroska = datumTroska;
        }
    }
}