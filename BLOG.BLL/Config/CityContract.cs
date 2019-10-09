using BLOG.IBLL.Config;
using BLOG.IDAL.Config;
using BLOG.Model.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLOG.BLL.Config
{
    public class CityContract : ICityContract
    {
        public ICityRepository CityRepository { get; set; }
        public IQueryable<City> GetList(Expression<Func<City, bool>> where)
        {
            return CityRepository.GetList(where);
        }
    }
}
