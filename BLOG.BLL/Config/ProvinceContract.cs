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
    public class ProvinceContract: IProvinceContract
    {
        public IProvinceRepository ProvinceRepository { get; set; }
        public IQueryable<Province> GetList(Expression<Func<Province, bool>> where)
        {
            return ProvinceRepository.GetList(where);
        }
    }
}
