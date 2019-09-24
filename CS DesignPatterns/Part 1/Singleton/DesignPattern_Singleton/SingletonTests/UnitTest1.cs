using Microsoft.VisualStudio.TestTools.UnitTesting;
using Singleton;

namespace SingletonTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsPolicyAsSigleton()
        {
            Assert.AreSame(Policy.Instance, Policy.Instance);
        }
    }
}
