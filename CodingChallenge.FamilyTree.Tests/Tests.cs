using System;
using NUnit.Framework;

namespace CodingChallenge.FamilyTree.Tests
{
    [TestFixture]
    public class TreeTests
    {
        Person tree = FamilyTreeGenerator.Make();
       
        [TestCase(1)]
        [TestCase(22)]
        [TestCase(33)]
        public void if_the_person_exists_in_tree_the_result_should_be_their_birthday(int index)
        {
            var result = new Solution().GetBirthMonth(tree, "Name" + index);
            Assert.AreEqual(DateTime.Now.AddDays(index - 1).ToString("MMMM"), result);
        }

        [Test]
        public void if_the_person_does_not_exist_in_the_tree_the_result_should_be_empty()
        {
            var tree = FamilyTreeGenerator.Make();
            var result = new Solution().GetBirthMonth(tree, "Jeebus");
            Assert.AreEqual("", result);
        }
    }
}
