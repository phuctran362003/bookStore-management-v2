using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BookCategoryDTO
    {
        private BookManagementDb24Context db = new BookManagementDb24Context();

        public List<BookCategory> GetAll()
        {
            return db.BookCategories.ToList();
        }
    }
}
