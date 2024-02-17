using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagerLibrary.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public User(int id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }
        public User(int id, string username)
        {
            UserName = username;
        }
    }
}
