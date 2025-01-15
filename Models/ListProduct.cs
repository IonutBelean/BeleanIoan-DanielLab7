using SQLiteForeignKey = SQLiteNetExtensions.Attributes.ForeignKeyAttribute;
using DataAnnotationsForeignKey = System.ComponentModel.DataAnnotations.Schema.ForeignKeyAttribute;
using SQLite;

namespace BeleanIoan_DanielLab7.Models
{
    public class ListProduct
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [SQLiteForeignKey(typeof(ShopList))]
        public int ShopListID { get; set; }

        public int ProductID { get; set; }
    }
}
