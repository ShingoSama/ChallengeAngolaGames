using ChallengeAngola;
using NUnit.Framework;
using System.Collections.Generic;

namespace ChallengeAngolaUnitTest
{
    public class CollectionExtensionTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FilterCollectionIntegersOk()
        {
            var original = new List<int> { -1, -2, 0, 1 };
            var filtered = original.FilterCollection<int>(x => x > 0);
            Assert.IsTrue(filtered.Value.Count == 1);
            Assert.AreEqual(1, filtered.Value[0]);
        }
    }
}