using DevExpress.Xpo;
using System;

namespace EF3_codeFirst_school
{
    public class teacher : XPObject
    {
        public teacher() : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public teacher(Session session) : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }
    }

}