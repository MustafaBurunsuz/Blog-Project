using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concete
{
    public class ContactManager
    {
        Repository<Contact> repocontact = new Repository<Contact>();

        public int BLContactAdd(Contact C)
        {
            if(C.Mail == "" || C.Message == "" ||  C.Name == "" || C.Subject == "" || C.SurName == "" || C.Mail.Length<=10 || C.Subject.Length<= 3)
            {
                return -1;
            }
            return repocontact.Insert(C);
        }
        public List<Contact> GetAll()
        {

            return repocontact.List();
        }
        public Contact GetContactDetails(int id)
        {

            return repocontact.Find(x => x.ConatctID == id);
        }

    }
}
