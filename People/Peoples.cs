using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class Peoples
    {
        protected string Name;
        protected string SurName;
        protected DateTime Birthday;
        public Peoples(string name, string surname, DateTime birthday)
        {
            Name = name;
            SurName = surname;
            Birthday = birthday;
        }
    }
}
