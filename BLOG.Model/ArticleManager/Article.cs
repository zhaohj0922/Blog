using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOG.Model.ArticleManager
{
    public class Article
    {
        public int Id { get; set; }
        public int ArticleTypeId { get; set; }
        public string Name { get; set; }
        public string Abstract { get; set; }
        public string ArticleContent { get; set; }
        public string AuthorIDCard  { get; set; }
        public string AuthorName { get; set; }
        public DateTime CreateTime { get; set; }
        public int IsPublish { get; set; }
        public int PublishTime { get; set; }
        public int IsTop { get; set; }
        public int Sort { get; set; }
        public int LookNum { get; set; }
        public int NumberOfPoints { get; set; }
        public int KnowledgeTypeId { get; set; }
        public int IsCommnet { get; set; }
        public int IsDelete { get; set; }
    }
}
