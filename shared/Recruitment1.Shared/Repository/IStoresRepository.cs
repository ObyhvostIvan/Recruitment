using Recruitment1.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruitment1.Shared.Repository
{
    public interface IStoresRepository
    {
        IEnumerable<Store> GetStores();
    }
}
