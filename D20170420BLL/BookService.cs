using System;
using System.Collections.Generic;
using D20170420DAL;
using D20170420MODEL;

namespace D20170420BLL
{
    public class BookService
    {
        public IList<Book> searchBookBySubname(String subname)
        {
            BookDao dao = new BookDao();
            return dao.listBookBySubname(subname);
        }
    }
}
