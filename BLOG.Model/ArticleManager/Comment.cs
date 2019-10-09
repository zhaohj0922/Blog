using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOG.Model.ArticleManager
{
    public class Comment
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public string CommentContent { get; set; }
        /// <summary>
        /// 回复引用（如果不为0，证明是引用/回复别人的评论）
        /// </summary>
        public int ReplyId { get; set; }
        public DateTime CreateTime { get; set; }
        public int IsDelete { get; set; }
    }
}
