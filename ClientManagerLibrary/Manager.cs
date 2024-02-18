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

        // TODO - remove defaults to 1 for tests
        private int _userId;
        private int _permissionsLevel;
        
        public int UserId
        {
            get { return _userId; }
            set { if (_userId == 0) _userId = value; }
        }
        public int PermissionsLevel
        {
            get { return _permissionsLevel; }
            set { if (_permissionsLevel == 0) _permissionsLevel = value; }
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

        public void Logout()
        {
            _userId = 0;
            _permissionsLevel = 0;
        }
    }
}
