using Microsoft.EntityFrameworkCore;
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
        public Book Get(int id)
        {
            BookManagementDb24Context db = new BookManagementDb24Context();

            return db.Books.FirstOrDefault(x => x.BookId == id);
        }
        public List<Book> GetAll()
        {
            BookManagementDb24Context db = new BookManagementDb24Context();

            return db.Books.ToList();
        }

        public void AddBook(Book book)
        {
            BookManagementDb24Context db = new BookManagementDb24Context();
            db.Books.Add(book);
            db.SaveChanges();
        }

        //this func will update a existing book through DbContext
        //somewhere will new Book() and push that book into this func
        public void Update(Book book)
        {
            BookManagementDb24Context db = new BookManagementDb24Context();
            db.Books.Update(book);
            db.SaveChanges();

        }

        public void Delete(int id)
        {
            BookManagementDb24Context db = new BookManagementDb24Context();

            var book = db.Books.FirstOrDefault(x => x.BookId == id);
            if (book != null)
            {
                db.Books.Remove(book);
                db.SaveChanges();
            }
        }
    }
}
