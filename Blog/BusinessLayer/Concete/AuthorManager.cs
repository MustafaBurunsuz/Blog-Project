using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concete
{
    public class AuthorManager
    {
        Repository<Author> repoblog = new Repository<Author>();
        public List<Author> GetAll()
        {

            return repoblog.List();
        }
    }
}
