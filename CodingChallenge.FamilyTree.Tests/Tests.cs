using System;
using NUnit.Framework;


namespace CodingChallenge.FamilyTree.Tests
{
    [TestFixture]
    public class TreeTests
    {
        [Test]
        public void if_the_person_exists_in_tree_the_result_should_be_their_birthday()
        {
            int index = 1;
            var tree = FamilyTreeGenerator.Make();
            var result = new Solution().GetBirthMonth(tree, "Name" + index);
            Assert.AreEqual(DateTime.Now.AddDays(index - 1).ToString("MMMM"), result);
        }

        [Test]
        public void if_the_person_exists_in_tree_the_result_should_be_their_birthday_22()
        {
            int index = 1;
            var tree = FamilyTreeGenerator.Make();
            var result = new Solution().GetBirthMonth(tree, "Name" + index);
            Assert.AreEqual(DateTime.Now.AddDays(index - 1).ToString("MMMM"), result);
        }

        [Test]
        public void if_the_person_exists_in_tree_the_result_should_be_their_birthday_33()
        {
            int index = 33;
            var tree = FamilyTreeGenerator.Make();
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
