using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Project.Models
{
    public class Account
    {
        private string password;

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password
        {
            get { return "******"; }
            set { password = value; }
        }
    }
}
