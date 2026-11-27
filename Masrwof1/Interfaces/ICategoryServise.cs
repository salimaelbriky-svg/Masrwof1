using Masrwof1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Masrwof1.Interfaces
{
    public interface ICategoryServise
    {
        public Category GetCategoryById(Guid id);
        public void updateCategory(Category category);

        public List<Category> GetAllCategories();

        public void AddCategorry(Category category);

        public void DeleteCategory(Guid id);

        decimal GetTotalCategories();
    }
}
