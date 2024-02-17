using ClientManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagerLibrary
{
    public sealed class Manager : User
    {
        private static Manager? _currentManager = null;
        private static object _lock = new();

        private Manager(int id, string name, string surname)
            :base(id, name, surname)
        {

        }

        public static Manager Instance()
        {
            if (_currentManager is null)
            {
                lock(_lock)
                {
                    if (_currentManager is null)
                    {
                        // TODO - manager actual data
                        _currentManager = new Manager(1, "aaa", "bbb");
                    }
                }
            }
            return _currentManager;
        }
    }
}
