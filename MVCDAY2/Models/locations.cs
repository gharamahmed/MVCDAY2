using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCDAY2.Models
{
    public class locations
    {
        [StringLength(100)]
        public string location{ get; set; }
        [ForeignKey("department")]
         public int deptnum { get; set; }
    }
}
