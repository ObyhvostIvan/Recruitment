using Recruitment1.Shared.Domain;
using Recruitment1.Shared.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment1.Repository
{
    internal class StoresRepository : IStoresRepository
    {
        public IEnumerable<Store> GetStores()
        {
            var storeKiev = new Store(1) { City = "Kiev", Street = "Zhytomyrska", Building = "111" };
            var storeKharkiv = new Store(2) { City = "Kharkiv", Street = "Kuznechna", Building = "23" };

            var person1 = new Person(1) { Name = "Adam", Surname = "Smith" };
            person1.Phones.Add("123456789");
            person1.Phones.Add("123456788");

            var person2 = new Person(2) { Name = "John", Surname = "Hall" };
            person2.Phones.Add("456789123");

            var person3 = new Person(3) { Name = "Mamie", Surname = "William" };
            person3.Phones.Add("78946132d");

            var person4 = new Person(4) { Name = "Doris", Surname = "Gravelle" };

            var person5 = new Person(5) { Name = "Patricia", Surname = "Wilbur" };
            person5.Phones.Add("432789159");
            person5.Phones.Add("434589159");
            person5.Phones.Add("437789559");

            var person6 = new Person(6) { Name = "Felix", Surname = "Medina" };
            person6.Phones.Add("433389559");
            person6.Phones.Add("434f89159");

            var car1 = new Car(1) { Engine = "Disel", Model = "VW Pasat" };
            var car2 = new Car(2) { Engine = "Pertol", Model = "Mazda 1.6" };
            var car3 = new Car(3) { Engine = "Hybrid", Model = "BMW I3" };
            var car4 = new Car(4) { Engine = "Hybrid", Model = "Toyota Prius" };
            var car5 = new Car(5) { Engine = "Electric", Model = "Tesla" };
            var car6 = new Car(6) { Engine = "Disel", Model = "VW Golf" };
            var car7 = new Car(7) { Engine = "Disel", Model = "Star 200" };

            storeKiev.Bill.Add(new BillEntry(car1, person1, new DateTime(2016, 5, 13), 50000));
            storeKiev.Bill.Add(new BillEntry(car2, person1, new DateTime(2016, 5, 13), 63000));
            storeKiev.Bill.Add(new BillEntry(car3, person2, new DateTime(2016, 5, 13), 89000));

            storeKharkiv.Bill.Add(new BillEntry(car4, person3, new DateTime(2012, 1, 11), 50000));
            storeKharkiv.Bill.Add(new BillEntry(car5, person4, new DateTime(2014, 2, 12), 100000));
            storeKharkiv.Bill.Add(new BillEntry(car6, person5, new DateTime(2015, 1, 2), 43000));
            storeKharkiv.Bill.Add(new BillEntry(car7, person6, new DateTime(2016, 4, 25), 21000));
            storeKharkiv.Bill.Add(new BillEntry(car6, person6, new DateTime(2016, 4, 25), 21000));

            return new Store[]
            {
                storeKiev,
                storeKharkiv
            };
        }
    }
}
