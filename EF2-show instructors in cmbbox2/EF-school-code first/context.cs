using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_school_code_first
{
    class context:DbContext
    {
        public context() : base(@"Data Source=DESKTOP-5VBV4FQ;Initial Catalog=schoolsManagementSystem;Integrated Security=True")
        {

        }
        public virtual DbSet<teacher> teachers { set; get; }
        public virtual DbSet<school> schools { set; get; }
        public virtual DbSet<teacherTransfer> transfers { set; get; }
        public virtual DbSet<department> departments { set; get; }
    }
}
