using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFromApp.Repositories
{
    public class GenericRepository<T> where T : class
    {
        private DbContext context;

        private DbSet<T> dbSet;
        public GenericRepository(DbContext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }

        public IEnumerable<T> GetAll() => dbSet;
        public T Get(int id) => dbSet.Find(id);
        public void CreateOrUpdate(T entity) => dbSet.AddOrUpdate(entity);
        public void Delete(T entity) => dbSet.Remove(entity);
        public void Save() => context.SaveChanges();
    }
}
