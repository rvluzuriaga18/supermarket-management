﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupermarketMgmt.CoreBusiness;

namespace SupermarketMgmt.UseCases.DataStorePluginInterfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();
        void AddCategory (Category category); 
        void UpdateCategory(Category category);
        Category GetCategoryById(int categoryId);
    }
}