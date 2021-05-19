using BlazorApp2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Services
{
    public class ProductService
    {
        public  List<Product> products = new List<Product>() { };
        public ProductService()
        {
            Product p1 = new Product() { id = 1, name = "p1",price=1000,CategoryID=1 };
            Product p2 = new Product() { id = 2, name = "p2" ,price=2000,CategoryID=1};
            Product p3 = new Product() { id = 3, name = "p3" ,price=3000,CategoryID=2};
            products.Add(p1); products.Add(p2); products.Add(p3);

        }

        public List<Product> getAll()
        {
            return products;
        }
        public Product getById(int id)
        {
            return products.FirstOrDefault(c => c.id == id);
        }
    }
}
