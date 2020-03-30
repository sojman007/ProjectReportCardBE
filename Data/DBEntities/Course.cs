using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectReportCardBE.Data.DBEntities
{
    public class Course
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string Title { get; set; }
        [Required]
        public string Code { get; set; }

        public ScoreEntry Entry { get; set; }

        [Required]
        public int Units { get; set; }

        public Semester ParentSemester { get; set; }

    }
}
