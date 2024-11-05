using System.Collections.Generic;

namespace CodingChallenge.FamilyTree
{
    public class Solution
    {
        public string GetBirthMonth(Person person, string descendantName)
        {
            var list = new List<Person>();
            CreateList(person, descendantName, ref list);
            var result = string.Empty;
            foreach (var item in list) 
            { 
                if (item.Name == descendantName)
                {
                    result = item.Birthday.ToString("MMMM");
                    break;
                }
            }
            return result;
        }

        private void CreateList(Person person, string descendantName, ref List<Person> list)
        {
            if (person != null)
            {
                list.Add(person);
                foreach (var child in person.Descendants)
                {
                    CreateList(child, descendantName, ref list);
                }
            }
        }
    }
}
