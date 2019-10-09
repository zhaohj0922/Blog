using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOG.Model.UserManager
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string IDCard { get; set; }
        public string ProvinceCode { get; set; }
        public string CityCode { get; set; }
        public string AreaCode { get; set; }
        public string Address { get; set; }
        public string Hobby { get; set; }
        public int Height { get; set; }
        public decimal Weight { get; set; }
    }
}
