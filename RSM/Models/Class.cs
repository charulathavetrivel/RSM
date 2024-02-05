using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RSM.Models
{
    [Table("Class")]
    public class Class
    {
        [Key]
        public int ClassId { get; set; }
        [Required]
        public string ClassName { get; set; }

    }
}