using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Singleton
{
    [TestFixture]
    public class SingletonTests
    {
        [Test]
        public void CreatedInstancesOfSingleton_ShouldBeTheSameInstances()
        {
            var firstInstance = MySingleton.Instance;
            var secondInstance = MySingleton.Instance;

            Assert.AreSame(firstInstance, secondInstance);
        }
    }
}
