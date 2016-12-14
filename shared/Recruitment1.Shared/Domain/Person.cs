using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment1.Shared.Domain
{
    public class Person
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<string> Phones { get; private set; }

        public Person(int id)
        {
            Id = id;
            Phones = new List<string>();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Person)) return false;

            return this.GetHashCode() == obj.GetHashCode();
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}
