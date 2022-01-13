using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concete
{
    public class CommentManager
    {
        Repository<Comment> repocomment = new Repository<Comment>();
        public List <Comment> CommentList()
        {
            return repocomment.List();

        }
        public List<Comment> CommentByBlock(int id)
        {
            return repocomment.List(x=>x.BlogID == id);

        }
    }
}
