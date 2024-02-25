using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagerLibrary.Models
{
    public class Report
    {
        public string Header { get; set; } = "";
        public List<string> Lines { get; set; } = new List<string>();

        public override string ToString()
        {
            string text = $"{Header}\n";

            foreach (var line in Lines)
            {
                text += line + "\n";
            }

            return text;
        }
    }
}
