using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BookDTO
    {
        BookManagementDb24Context db = new BookManagementDb24Context();
        public Book Get(int id)
        {
            return db.Books.FirstOrDefault(x => x.BookId == id);
        }
        public List<Book> GetAll()
        {
            return db.Books.ToList();
        }

        public void Create(Book book)
        {
            db.Books.Add(book);
            db.SaveChanges();

        }

        public void Update(Book book)
        {
            db.Books.Update(book);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var book = db.Books.FirstOrDefault(x => x.BookId == id);
            if (book != null)
            {
                db.Books.Remove(book);
                db.SaveChanges();
            }
        }
    }
}
