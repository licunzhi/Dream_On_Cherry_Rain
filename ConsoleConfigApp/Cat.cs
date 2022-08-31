using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Data Annotation
namespace ConsoleConfigApp
{
    [Table("Cat")]
    class Cat
    {
        public int id { get; set; } // Primary key

        [Required]
        [MaxLength(256)]
        public string name { get; set; }// name

    }
}
