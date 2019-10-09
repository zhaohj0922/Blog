using BLOG.IBase;
using BLOG.Model;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BLOG.Base
{
    public class Factory 
    {
        public static DbContext CreateDbContext()
        {
            DbContext dbCtx = (DbContext)CallContext.GetData("dbContext");
            if (dbCtx==null)
            {
                dbCtx = new DBContext();
                CallContext.SetData("dbContext", dbCtx);
            }
            return dbCtx;
        }
    }
}
