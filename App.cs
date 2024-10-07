using Friends.Model;

namespace Friends
{
    internal class App
    {
        Group? _ffc;
        Group? _hrMadness;
        Group _allColleagues;

        public App(Group ffc, Group hrMadness, Group allColleagues)
        {
            this._ffc = ffc;
            this._hrMadness = hrMadness;
            this._allColleagues = allColleagues;
        }

        public App()
        {
            _ffc = new Group();
            _hrMadness = new Group();
            _allColleagues = new Group();
        }

        internal void Run()
        {
            SetupGroupsAndPersons();
            if (_hrMadness != null)
            {
                foreach (Person p in _hrMadness.GetMembers())
                {
                    Console.WriteLine(p.GetName());
                }
            }
        }

        private void SetupGroupsAndPersons()
        {
            // Create 2 new Friends groups
            _ffc = new Group();
            _hrMadness = new Group();

            // Create a new Workplace
            _allColleagues = new Group();

            // Create 10 persons, set their names and add them to the list of persons
            Person p1 = new Person();
            p1.SetName("John");

            Person p2 = new Person();
            p2.SetName("Mary");

            Person p3 = new Person();
            p3.SetName("Peter");

            Person p4 = null!;

            Person p5 = new Person();
            p5.SetName("Susan");

            Person p6 = new Person();
            p6.SetName("Elizabeth");

            Person p7 = new Person();
            p7.SetName("James");

            Person p8 = new Person();
            p8.SetName("Michael");

            Person p9 = new Person();
            p9.SetName("Linda");

            Person p10 = new Person();
            p10.SetName("Barbara");

            // Add all 10 persons to the Workplace
            _allColleagues.AddMember(p1);
            _allColleagues.AddMember(p2);
            _allColleagues.AddMember(p3);
            _allColleagues.AddMember(p4);
            _allColleagues.AddMember(p5);
            _allColleagues.AddMember(p6);
            _allColleagues.AddMember(p7);
            _allColleagues.AddMember(p8);
            _allColleagues.AddMember(p9);
            _allColleagues.AddMember(p10);

            // Add 7 persons to the first Friends group
            _ffc?.AddMember(p1);
            _ffc?.AddMember(p2);
            _ffc?.AddMember(p3);
            _ffc?.AddMember(p4);
            _ffc?.AddMember(p5);
            _ffc?.AddMember(p6);
            _ffc?.AddMember(p7);

            // Add 7 persons to the second Friends group
            _hrMadness?.AddMember(p4);
            _hrMadness?.AddMember(p5);
            _hrMadness?.AddMember(p6);
            _hrMadness?.AddMember(p7);
            _hrMadness?.AddMember(p8);
            _hrMadness?.AddMember(p9);
            _hrMadness?.AddMember(p10);
        }
    }
}