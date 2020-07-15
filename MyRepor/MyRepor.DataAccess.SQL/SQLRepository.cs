using MyRepor.Core.Contracts;
using MyRepor.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRepor.DataAccess.SQL
{
    public class SQLRepository<T> : IRepository<T> where T : BaseEntity
    {
        internal DataContext context;
        internal DbSet<T> dbSet;

        public SQLRepository(DataContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }
        public IQueryable<T> Collection()
        {
            return dbSet;
            //throw new NotImplementedException();
        }

        public void Commit()
        {
            context.SaveChanges();
            //throw new NotImplementedException();
        }

        public void Delete(string Id)
        {
            var t = Find(Id);
            if (context.Entry(t).State == EntityState.Detached)
                dbSet.Attach(t);
            // throw new NotImplementedException();

            dbSet.Remove(t);
        }

        public T Find(string Id)
        {
            return dbSet.Find(Id);
            //throw new NotImplementedException();
        }

        public void Insert(T t)
        {
            dbSet.Add(t);
            //throw new NotImplementedException();
        }

        public void Update(T t)
        {
            dbSet.Attach(t);
            context.Entry(t).State = EntityState.Modified;
            //throw new NotImplementedException();
        }
    }
}
