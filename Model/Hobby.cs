using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friends.Model
{
    internal class Hobby
    {
        private string HobbyName;
        public Hobby(string hobbyName)
        {
            HobbyName = hobbyName;
        }

        public string GetName()
        {
            return HobbyName;
        }
    }
}
