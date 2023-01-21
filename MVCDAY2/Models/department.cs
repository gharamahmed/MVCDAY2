using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCDAY2.Models
{
    public class department
    {
        [Key]
        public int? Number { get; set; }
        [StringLength(100)]
        public string? Name { get; set; }

        public List<locations> locations { get; set; }
        public List<project>? projects { get; set; }
    }
}
