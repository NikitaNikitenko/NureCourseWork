using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFromApp.Context;

namespace WinFromApp.Repositories
{
    public class AdvertisementRepository : GenericRepository<Advertisements>
    {
        public AdvertisementRepository(DbContext context) : base(context)
        {
        }
    }
}
