using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOG.Model.UserManager
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NickName { get; set; }
        public int Age { get; set; }
        public int Sex { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string IDCard { get; set; }
        public string PhoneNum { get; set; }
        public int UserType { get; set; }
        public int IsDelete { get; set; }
    }
}
