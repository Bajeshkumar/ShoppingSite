using Microsoft.AspNetCore.Mvc;
using Shopping_Site.Models;
using Shopping_Site.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_Site.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryRepository _categoryRepository = null;
        public CategoryController()
        {
            _categoryRepository = new CategoryRepository();
        }
        public IActionResult Index()
        {
            return View();
        }
        public List<Category> GetAllCategories()
        {
            return _categoryRepository.GetAllCategory();
        }
        public Category GetCategory(int id)
        {
            return _categoryRepository.GetCategoryById(id);
        }
        public List<Category> SearchCategories(string type,string name)
        {
            return _categoryRepository.SearchCategory(type,name);
        }
    }
}
