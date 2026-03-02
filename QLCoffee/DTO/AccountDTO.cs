using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCoffee.DTO
{
    public class AccountDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public AccountDTO(string user, string pass)
        {
            Username = user;
            Password = pass;
        }
    }
}