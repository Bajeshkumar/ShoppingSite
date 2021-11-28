using Shopping_Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_Site.Repository
{
    public class CategoryRepository
    {
        public List<Category> GetAllCategory()
        {
            return DataSource();
        }
        public Category GetCategoryById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<Category> SearchCategory(string type,string name)
        {
            return DataSource().Where(x => x.Type.Contains(type) || x.Name.Contains(name)).ToList();
        }
        private List<Category> DataSource()
        {
            return new List<Category>()
            {
                new Category(){Id=1,Type="Shirt",Name="Cloth"},
                new Category(){Id=2,Type="Paint",Name="Electronic"},
                new Category(){Id=3,Type="Shoes",Name="RedChiff"},
                new Category(){Id=2,Type="Mobile",Name="Redmi"},
                new Category(){Id=1,Type="Mobile",Name="I-phone"},
                new Category(){Id=2,Type="Shoes",Name="woodLand"},
            };
        }
    }
}
