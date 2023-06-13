using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFromApp.Context;

namespace WinFromApp.Repositories
{
    public class CategoryRepository : GenericRepository<Categories>
    {
        public CategoryRepository(DbContext context) : base(context)
        {
        }
    }
}
