using iRely.Common.Ioc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcDay2.Models
{
    [MetadataType(typeof(ProductMetaData))]
    public partial class Products
    {

    }
    public class ProductMetaData
    {

        public int Id { get; set; }

        [productExisted()]
        [Required(ErrorMessage = "you must enter the name")]
        [MinLength(3, ErrorMessage = "enter more than 3 letters")]
        [MaxLength(20, ErrorMessage = "cant be more than 20letters")]
        // [RegularExpression(pattern:"[a-z]{3,20}",ErrorMessage="")]
        public string Name { get; set; }

        //?? doesnt work
        [Remote("checkPrice","Product",ErrorMessage ="remoteValidator saying NOOO  >_<")]
        //[Range(minimum: 100, maximum: 10000)]
        public Nullable<double> Price { get; set; }
        public string Description { get; set; }
        public Nullable<int> ReviewsCounter { get; set; }
        public string Color { get; set; }
        public Nullable<double> Size { get; set; }
        public Nullable<double> Discout { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public string image { get; set; }

        [Required]
        [Range(minimum: 1, maximum: 1000)]
        [Display(Name = "Product Quantity")]
        public int Quantity { get; set; }
    }
}