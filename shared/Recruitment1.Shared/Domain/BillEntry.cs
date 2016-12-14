using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment1.Shared.Domain
{
    public class BillEntry
    {
        public Car Item { get; private set; }
        public Person Client { get; private set; }
        public DateTime SoldDate { get; private set; }
        public decimal Price { get; private set; }

        public BillEntry(Car item, Person client, DateTime soldDate, decimal price)
        {
            Item = item;
            Client = client;
            SoldDate = soldDate;
            Price = price;
        }
    }
}
