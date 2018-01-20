using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Driver;
using Lists;

namespace Tests
{
    [TestClass]
    public class ListsManagerTests
    {
        private ListsManager _listsManager;

        public ListsManagerTests()
        {
            _listsManager = new ListsManager();
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
