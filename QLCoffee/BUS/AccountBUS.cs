using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCoffee.DAL;
using QLCoffee.DTO;

namespace QLCoffee.BUS
{
    public class AccountBUS
    {
        private AccountDAL accountDAL = new AccountDAL();

        public string Login(AccountDTO account)
        {
            return accountDAL.CheckLogin(account);
        }
    }


}
