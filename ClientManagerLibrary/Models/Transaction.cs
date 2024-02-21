using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagerLibrary.Models
{
    public class Transaction
    {
        public required Client ClientFrom { get; set; }
        public required Client ClientTo { get; set; }
        public required string AccountFrom { get; set; }
        public required string AccountTo { get; set; }
        public required decimal Amount { get; set; }
        public required DateTime DateTimeCreated { get; set; }
        public DateTime? DateTimeTranfered { get; set; }
    }
}
