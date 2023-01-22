using System.ComponentModel.DataAnnotations.Schema;

namespace MVCDAY2.Models
{
    public class works_on
    {
        public int? Hours { get; set; }

        [ForeignKey("employee")]
        public int? ESSN { get; set; }
        [ForeignKey("project")]
        public int? Pnum { get; set; }
        public project? Project { get; set; }
        public employee? Employee { get; set; }
    }
}
