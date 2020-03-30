using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectReportCardBE.Data.DBEntities
{
    public class AcademicSession
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string StartYear { get; set; }
        
        [Required]
        public string EndYear { get; set; }
        
        [Required]
        [Range(2,4)]
        public int SemesterCount { get; set; }


        public User User { get; set; }

        public IList<Semester> Semesters { get; set; } = new List<Semester>();

    }
}
