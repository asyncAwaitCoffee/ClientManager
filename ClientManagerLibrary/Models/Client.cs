using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagerLibrary.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string SurName { get; set; }
        public string FullName { get; set; }
        public int AccountId { get; set; }

    }
}
