using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonSample
{
    public sealed class MySingleton
    {
        private static MySingleton _instance;
        private static readonly object Padlock = new object();

        private MySingleton() {}

        public static MySingleton Instance
        {
            get
            {
                lock (Padlock)
                {
                    return _instance ?? (_instance = new MySingleton());
                }
            }
        }
    }
}
