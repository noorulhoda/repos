
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCORE.Models
{
    public class Class
    {
        
            public int Id { get; set; }
            public string Name { get; set; }
            public virtual ICollection<Student> Studnet { get; set; }
        
    }
}
