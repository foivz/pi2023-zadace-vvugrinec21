using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletWatch.Models
{
    public class Category : Trosak
    {
        public int Id_cateogry { get; set; }
        public string Name_category { get; set; }
        public Category(string katgorije)
        {
            
            Name_category = katgorije;
        }
    }
}
