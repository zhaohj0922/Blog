using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLOG.IBase
{
    public interface IBaseDal<T> where T : class,new()
    {
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="where"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="total"></param>
        /// <param name="desc"></param>
        /// <returns></returns>
        IQueryable<T> GetListByPage<TKey>(Expression<Func<T, bool>> where, Expression<Func<T, TKey>> orderBy, int pageIndex, int pageSize, out int total, bool desc);
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        IQueryable<T> GetList(Expression<Func<T, bool>> where);
        /// <summary>
        /// 插入
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="isSave"></param>
        /// <returns></returns>
        bool Insert(T entity, bool isSave = true);
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="isSave"></param>
        /// <returns></returns>
        bool Update(T entity, bool isSave = true);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        bool DeleteEntity(Expression<Func<T, bool>> where);
        /// <summary>
        /// 执行删除
        /// </summary>
        /// <param name="entities"></param>
        /// <param name="isSave"></param>
        /// <returns></returns>
        bool Delete(IEnumerable<T> entities, bool isSave = true);
    }
}
