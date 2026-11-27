using Masrwof1.Data;
using Masrwof1.Interfaces;
using Masrwof1.Models;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Masrwof1.Services
{
    public class CategoryServise : ICategoryServise
    {
        private readonly AppDbContext _context;
        public CategoryServise(AppDbContext context)
        {
            _context = context;
        }

        public void InitializeDatabase()
        {
            _context.Database.EnsureCreated();
        }

        public List<Category> GetAllCategories()
        {
            return _context.Categories.OrderBy(c => c.Name).ToList();
        }


        public void AddCategorry(Category category)
        {
            if (category == null) return;

            _context.Categories.Add(category);
            _context.SaveChanges();
        }
        public Category GetCategoryById(Guid id)
        {
            return _context.Categories.FirstOrDefault(c => c.Id == id) ?? new Category() ;
        }

        public void updateCategory(Category category)
        {
            if (category == null) return;

            _context.Categories.Update(category);
            _context.SaveChanges();
        }

        public void DeleteCategory(Guid id)
        {
            var category = _context.Categories.FirstOrDefault(e => e.Id== id);
            if(category !=null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
            }
        }

        public decimal GetTotalCategories()
        {
            return _context.Categories.Count();
        }
    }
}
