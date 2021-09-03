using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsClasses
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public Person(string Name, string LastName)
        {
            this.Name = Name;
            this.LastName = LastName;
        }
    }
}
