using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace BeleanIoan_DanielLab7.Models
{
    public class ShopList
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; } // Pentru Text="{Binding Name}"
        public DateTime Date { get; set; } // Pentru Detail="{Binding Date}"
    }
}
