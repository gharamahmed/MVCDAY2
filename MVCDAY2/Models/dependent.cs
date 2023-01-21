using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCDAY2.Models
{
    public class dependent
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string? Name { get; set; }
        [StringLength(50)]
        public string? Sex { get; set; }
        [Column(TypeName ="date")]
        public DateTime? Birthdate{ get; set; }
        public string? Relationship { get; set; }

        [ForeignKey("employee")]
        public int? ESSN { get; set; }
        public employee?Employee { get; set; }
    }
}
