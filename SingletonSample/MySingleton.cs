using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonSample
{
    public sealed class MySingleton
    {
        private static readonly Lazy<MySingleton> _lazyIstance
            = new Lazy<MySingleton>(() => new MySingleton());

        public static MySingleton Instance => _lazyIstance.Value;

        private MySingleton() {}
    }
}
