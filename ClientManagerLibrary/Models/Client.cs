using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagerLibrary.Models
{
    public class Client
    {
        public required int Id { get; set; }
        public required string SurName { get; set; }
        public required string Name { get; set; }
        [DisplayName("VIP")]
        public bool isVIP { get; set; }
        [Browsable(false)]
        public int AccountsId { get; set; }
        [Browsable(false)]
        public int Gender { get; set; }
        [DisplayName("Gender")]
        public char GenderChar {
            get
            {
                return Gender == 1 ? 'M' : 'F';
            } }
        [Browsable(false)]
        public string FullName {
            get {
                return $"{SurName} {Name}";
            } }
        [DisplayName("Client Manager")]
        public string ClientManager { get; set; }

    }
}
