using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserAccountDAO
    {
        UserAccountDTO accountDTO = new UserAccountDTO();
        public UserAccount CheckLogin(string email, string password)
        {
            UserAccount account = accountDTO.Get(email);
            return (account != null && account.Password == password) ? account : null;
        }

    }
}
