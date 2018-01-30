using CheckThisData.Managers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckThisTests
{
    [TestClass]
    public class ListsManagerTests
    {
        private CheckThisListsManager _listsManager;

        public ListsManagerTests()
        {
            _listsManager = new CheckThisListsManager();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var results = _listsManager.CountListsTest();
            Assert.IsNotNull(results);
            Assert.IsTrue(results > 0);
        }


    }
}
