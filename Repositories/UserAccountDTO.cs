using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserAccountDTO
    {
        BookManagementDb24Context db = new BookManagementDb24Context();

        public UserAccount Get(string email)
        {
            return db.UserAccounts.FirstOrDefault(x => x.Email == email);
        }
    }
}
