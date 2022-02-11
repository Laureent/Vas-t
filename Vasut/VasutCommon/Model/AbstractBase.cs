using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace VasutCommon.Model
{
    public abstract class AbstractBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity]
        public long Id { get; set; }
    }
}
