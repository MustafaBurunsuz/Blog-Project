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
        public int AddAuthorBL(Author p)
        {
            if(p.AuthorName== "" | p.AuthorAbout == "" |p.Title == "")
            {
                return -1;
            }
            return repoblog.Insert(p);
        }  
        public Author FindAuthor (int id)
        {
            return repoblog.Find(x => x.AuthorID == id);
        }
        public int UpdateAuthor(Author p)
        {
            Author author = repoblog.Find(x => x.AuthorID == p.AuthorID);
            author.AboutShort = p.AboutShort ;
            author.AuthorAbout = p.AuthorAbout;
            author.AuthorImage = p.AuthorImage;
            author.AuthorName = p.AuthorName;
            author.Mail = p.Mail;
            author.Password = p.Password;
            author.PhoneNumber = p.PhoneNumber;
            return repoblog.Update(author);
            
        }
    }
}
