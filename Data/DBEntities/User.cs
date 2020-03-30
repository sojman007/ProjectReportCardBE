using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectReportCardBE.Data.DBEntities
{
    public class User
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; } = "Customer";
        public IList<AcademicSession> Sessions { get; set; } = new List<AcademicSession>();

        [Required]
        public string LogInKey { get; set; }
        
    }
}
