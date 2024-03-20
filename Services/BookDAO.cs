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
            return bookDTO.GetAll().Where(x => x.BookId.ToString().ToLower().Contains(keyword.ToLower()) ||
                                               x.Description.ToString().ToLower().Contains(keyword.ToLower())).ToList();
        }
    }
}
