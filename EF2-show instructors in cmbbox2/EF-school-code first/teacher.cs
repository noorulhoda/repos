using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EF_school_code_first

{
    class teacher
    {
        public int ID { set; get; }
        public string name { set; get; }
        public ICollection<teacherTransfer> transfers { set; get; }
        [ForeignKey("school")]
        public int schoolID { set; get; }
        public school school { set; get; }

    }
}
