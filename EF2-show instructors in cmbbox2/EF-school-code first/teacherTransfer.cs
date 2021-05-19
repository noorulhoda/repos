using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EF_school_code_first

{
    class teacherTransfer
    {
        public int ID { set; get; }
        public DateTime date { set; get; }

        [ForeignKey("teacher")]
        public int teacherID { set; get; }
        public teacher teacher { set; get; }

        [InverseProperty("from")]
        public school from { set; get; }

        [InverseProperty("to")]
        public school to { set; get; }

    }
}
