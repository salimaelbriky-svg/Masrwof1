using Masrwof1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Masrwof1.Interfaces
{
    public interface ICategoryService
    {
         Category GetCategoryById(Guid id);
         void updateCategory(Category category);

         List<Category> GetAllCategories();

         void AddCategorry(Category category);

         void DeleteCategory(Guid id);

        decimal GetTotalCategories();
    }
}
