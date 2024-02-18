using ClientManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagerLibrary
{
    public sealed class Manager
    {
        private static Manager? _currentManager = null;
        private static object _lock = new();

        // TODO - defaults to 1 for tests
        private int _userId = 1;

        public int UserId
        {
            get { return _userId; }
            set { if (_userId == 0) _userId = value; }
        }


        private Manager()
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
                        _currentManager = new Manager();
                    }
                }
            }
            return _currentManager;
        }
    }
}
