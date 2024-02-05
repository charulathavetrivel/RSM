using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RSM.Models
{
    [Table("Subject")]
    public class Subject
    {

        [Key]
        public int SubjectId { get; set; }
        [Required]
        public string SubjectName { get; set; }

    }
}