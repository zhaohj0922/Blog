using BLOG.IBase;
using BLOG.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLOG.Base
{
    public class BaseDal<T> : IBaseDal<T> where T : class, new()
    {
        /// <summary>
        /// 上下文实例
        /// </summary>
        public DBContext dbCtx = Factory.CreateDbContext() as DBContext;
        public IQueryable<T> GetListByPage<TKey>(Expression<Func<T, bool>> where, Expression<Func<T, TKey>> orderBy, int pageIndex, int pageSize, out int total, bool desc)
        {
            throw new NotImplementedException();
        }
        public IQueryable<T> GetList(Expression<Func<T, bool>> where)
        {
            return  dbCtx.Set<T>().Where(where);
        }

        public bool Insert(T entity, bool isSave = true)
        {
            throw new NotImplementedException();
        }

        public bool Update(T entity, bool isSave = true)
        {
            throw new NotImplementedException();
        }
        public bool Delete(IEnumerable<T> entities, bool isSave = true)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEntity(Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }
    }
}
