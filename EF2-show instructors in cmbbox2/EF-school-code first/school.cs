using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EF_school_code_first

{
    class school
    {
        public int ID { set; get; }
        public string name { set; get; }
        public string type { set; get; }
       
        public ICollection<teacherTransfer> from { set; get; }
        public ICollection<teacherTransfer> to { set; get; }

        [ForeignKey("department")]
        public int deptID { set; get; } 
        public virtual department department { set; get; }

        public ICollection<teacher> teachers { set; get; }
    }
}
