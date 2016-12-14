using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment1.Shared.Domain
{
    public class Car
    {
        public int Id { get; private set; }
        public string Model { get; set; }
        public string Engine { get; set; }

        public Car(int id)
        {
            Id = id;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Car)) return false;

            return this.GetHashCode() == obj.GetHashCode();
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}
