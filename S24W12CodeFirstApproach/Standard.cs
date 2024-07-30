using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S24W12CodeFirstApproach
{
    public class Standard
    {
        // scalar properties
        public int StandardId { get; set; }
        public string? Name { get; set; }

        // navigation properties
        public ICollection<Student>? Students { get; set; }
    }
}
