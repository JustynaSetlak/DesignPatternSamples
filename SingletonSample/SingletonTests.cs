using NUnit.Framework;
using System;

namespace SingletonSample
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
