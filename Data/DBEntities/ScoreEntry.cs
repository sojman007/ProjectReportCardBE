using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectReportCardBE.Data.DBEntities
{
    public class ScoreEntry
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [Range(0.0,100.0)]
        public double Score { get; set; }
        public string GradeType { get; set; } // set this to an enum value 
        public Course Course { get; set; }
    }
}
