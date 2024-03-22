using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookDAO
    {
        BookDTO bookDTO = new BookDTO();
        Book b = new Book();

        public List<Book> GetAllBooks()
        {
            return bookDTO.GetAll();
        }

        public bool CheckIfValidID(int id)
        {
            return b.BookId == id;
        }

        public List<Book> Search(string keyword)
        {
            return bookDTO.GetAll().Where(x => x.BookName.ToString().ToLower().Contains(keyword.ToLower()) ||
                                               x.Description.ToString().ToLower().Contains(keyword.ToLower())).ToList();
        }

        public void DeleteABookFromUI(int id)
        {
            bookDTO.Delete(id);
        }



        /// <summary>
        /// This function create a new Book. The information of a Book is taken from UI
        /// </summary>
        /// <param name="book"></param>
        public void AddABookForUI(Book book)
        {
            bookDTO.AddBook(book);   //try-catch, trùng mã số, bỏ trống ô nhập
            //what if we input the same ID
            // HINT:
            // - promt ChatGPT: how to handle duplication of Primary key exception during creating a new Book in BookManagement app using Entity Framework Core in C#
        }

        public void UpdateABook(Book book)
        {
            bookDTO.Update(book); //try-catch, Validation
        }
    }
}
