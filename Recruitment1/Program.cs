using Recruitment1.Repository;
using Recruitment1.Shared.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recruitment1.Shared.Domain;

namespace Recruitment1
{
    class Program
    {
        static void Main(string[] args)
        {
            IStoresRepository repository = new StoresRepository();

            var stores = repository.GetStores();
            //foreach (var name in stores)
            //{
            //    if (name.Bill.Any(x => x.Item.Engine == "Electric"))
            //    {
            //        Console.WriteLine(name.City); 
            //    }
                
            //}
            //var q = stores.SelectMany(x => x.Bill.GroupBy(y => y.Client).Select(g => new {Name = g.Key.Name, Count = g.Count()}));
            //foreach (var store in q)
            //{
            //    if(store.Count > 1)
            //        Console.WriteLine("Name: " + store.Name + " count: " + store.Count);
            //}
            //var sumMoneyKharkov =
                //stores.Where(x => x.City == "Kharkiv").SelectMany(k => k.Bill.Where(y => y.SoldDate.Date.Year == DateTime.Today.Year)).Sum(h => h.Price);
            //var storeYears = stores.SelectMany(x => x.Bill.Where(y => y.SoldDate.Date.Year == DateTime.Today.Year)).ToList();
            //var storeYears = stores.SelectMany(x => x.Bill.GroupBy(y => y.Client));

            //количество транзакция за 2016 год = 4
            //var countTranzation = stores.SelectMany(x => x.Bill.Where(y => y.SoldDate.Year == new DateTime(2016, 1, 1).Year)).Count();
            //на какую сумуу продал киевский магазин за 2016 год
            //var kievStoreSum =
                //stores.Where(x => x.City == "Kiev")
                  //  .SelectMany(y => y.Bill.Where(h => h.SoldDate.Year == new DateTime(2016, 1, 1).Year))
                  //  .Sum(p => p.Price);
            //имя владельца, что имеет 2 машины
            var names = stores.SelectMany(x => x.Bill.GroupBy(y => y.Client).Select(q => new { Name = q.Key.Name, Count = q.Count() }));
            foreach (var name in names)
            {
                if (name.Count > 1)
                    Console.WriteLine(name.Name);
            }
        }
    }
}
