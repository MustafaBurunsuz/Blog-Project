using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concete
{
    public class CategoryManager
    {
        Repository<Category> repocategory = new Repository<Category>();
        public List <Category> GetAll()
        {
            return repocategory.List();
        }
    }
}
