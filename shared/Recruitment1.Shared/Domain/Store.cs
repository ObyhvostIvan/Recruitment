using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment1.Shared.Domain
{
    public class Store
    {
        public int Id { get; private set; }

        public string City { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
        public List<string> Phones { get; private set; }

        public List<BillEntry> Bill { get; private set; }

        public Store(int id)
        {
            Id = id;
            Phones = new List<string>();
            Bill = new List<BillEntry>();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Store)) return false;

            return this.GetHashCode() == obj.GetHashCode();
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}
