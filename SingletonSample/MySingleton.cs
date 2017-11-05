using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonSample
{
    public sealed class MySingleton
    {
        private static MySingleton _instance;

        private MySingleton() {}

        public static MySingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MySingleton();
                }
                return _instance;
            }
        }
    }
}
