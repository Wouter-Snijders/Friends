using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friends.Model
{
    internal class Group
    {
        private string GroupName { get; set; }
        private List<Person> GroupMembers { get; set; }
        public Group(string groupName, List<Person> groupMembers)
        {
            GroupName = groupName;
            GroupMembers = groupMembers;
        }

        public Group()
        {
            throw new NotImplementedException();
        }

        public List<Person> GetMembers()
        {
            return GroupMembers;
        }

        public void AddMember(Person person)
        {
            GroupMembers.Add(person);
        }
        
        public void RemoveMember(Person person)
        {
            GroupMembers.Remove(person);
        }

        public void SetName(string newName)
        {
            GroupName = newName;
        }

        public string GetName()
        {
            return GroupName;
        }
    }
}
