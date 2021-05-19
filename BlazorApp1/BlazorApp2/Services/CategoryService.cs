using BlazorApp2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Services
{
    public class CategoryService
    {
        public List<Category> categories = new List<Category>() { };
        public CategoryService()
        {
            Category c1 = new Category() { id = 1, name = "c1" };
            Category c2 = new Category() { id = 2, name = "c2" };
            Category c3 = new Category() { id = 3, name = "c3" };
            categories.Add(c1);categories.Add(c2);categories.Add(c3);

        }

        public List<Category> getAll()
        {
            return categories;
        }
        public Category getById(int id)
        {
            return categories.FirstOrDefault(c => c.id == id);
        }
    }
}
