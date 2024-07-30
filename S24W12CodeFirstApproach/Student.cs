using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace S24W12CodeFirstApproach
{
    public class Student
    {
        // scalar properties
        public int StudentId { get; set; }
        [Column("StudentName")]
        [MaxLength(50)]
        public string? Name { get; set; }
        public int? StandardId { get; set; }
        public int? Age { get; set; }

        // navigation properties
        public Standard? Standard { get; set; }
    }
}
