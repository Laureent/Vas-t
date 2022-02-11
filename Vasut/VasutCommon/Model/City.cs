using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VasutCommon.Model
{
    [Table("CITIES")]
    public class City : AbstractBase
    {
        [Column("CITY_NAME")]
        public string Name { get; set; }
    }
}
