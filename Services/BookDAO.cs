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

        public List<Book> GetAllBooks()
        {
            return bookDTO.GetAll();
        }

        public List<Book> Search(string keyword)
        {
            return bookDTO.GetAll().Where(x => x.BookName.ToString().ToLower().Contains(keyword.ToLower()) ||
                                               x.Description.ToString().ToLower().Contains(keyword.ToLower())).ToList();
        }

        public void Delete(int id)
        {
             bookDTO.Delete(id);
        }


        

        public void AddABook (Book book)
        {
            bookDTO.Create(book);   //try-catch, trùng mã số, bỏ trống ô nhập
        }

        public void UpdateABook(Book book)
        {
            bookDTO.Update(book); //try-catch, Validation
        }
    }
}
