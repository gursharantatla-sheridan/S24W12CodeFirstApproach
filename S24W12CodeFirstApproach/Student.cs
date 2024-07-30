using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S24W12CodeFirstApproach
{
    public class Student
    {
        // scalar properties
        public int StudentId { get; set; }
        public string? Name { get; set; }
        public int? StandardId { get; set; }

        // navigation properties
        public Standard? Standard { get; set; }
    }
}
