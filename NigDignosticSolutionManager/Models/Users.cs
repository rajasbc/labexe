using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NigDignosticSolutionManager.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class SessionTimeOut
    {
        public string Status { get; set; }
    }

    public class Users
    {
        public List<User> UsersList { get; set; }
    }
}
