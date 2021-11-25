using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceTrophies.Services
{
    public class ManageTrophies : IManageTrophies
    {
        public ManageTrophies()
        {

        }

        public IList<string> GetAllTrophiesNamesAsc(List<Trophy> trophies)
        {
            return trophies.OrderBy(t => t.Libelle).Select(t => t.Libelle).ToList();
        }
    }
}
