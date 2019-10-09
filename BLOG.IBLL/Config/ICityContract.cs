using BLOG.Model.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLOG.IBLL.Config
{
    public interface ICityContract
    {
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        IQueryable<City> GetList(Expression<Func<City, bool>> where);
    }
}
