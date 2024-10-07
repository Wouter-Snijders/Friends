using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friends.Model
{
    internal class Person
    {
        private string Name { get; set; }
        private Group MyFriends { get; set; }
        private Group MyColleagues { get; set; }

        private List<Hobby> Hobbies { get; set; }        

        public Person(string name, Group myFriends, Group myColleagues, List<Hobby> hobbies)
        {
            Name = name;
            MyFriends = myFriends;
            MyColleagues = myColleagues;
            Hobbies = hobbies;
        }

        public Person()
        {
            throw new NotImplementedException();
        }

        public List<Person> GetFriends()
        {
            return MyFriends.GetMembers();
        }

        public void AddFriend(Person person)
        {
            MyFriends.AddMember(person);
        }

        public List<Person> GetColleagues()
        {
            return MyColleagues.GetMembers();
        }

        public void AddColleague(Person person)
        {
            MyColleagues.AddMember(person);
        }

        public List<Hobby> GetHobbies()
        {
            return Hobbies;
        }

        public void AddHobby(Hobby hobby)
        {
            Hobbies.Add(hobby);
        }

        public void RemoveHobby(Hobby hobby)
        {
            Hobbies.Remove(hobby);
        }

        public void SetName(string newName)
        {
            Name = newName;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
