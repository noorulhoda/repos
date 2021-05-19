using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcDay2.ViewModel
{
    public class productQtyColor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public string image { get; set; }
        public int Quantity { get; set; }
        public string Color { get; set; }
    }
}