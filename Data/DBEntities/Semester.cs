using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectReportCardBE.Data.DBEntities
{
    public class Semester
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        
        [Required]
        [Range(1,50)]
        public int CourseCount { get; set; }


        public IList<Course> Courses { get; set; }
        public AcademicSession Session { get; set; }

    }
}
