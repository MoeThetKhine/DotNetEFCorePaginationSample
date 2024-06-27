using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Features.Blog
{
    public class BlogModel
    {
        [Key]
        public long BlogId { get; set; } 
        public string BlogTitle { get; set; }
        public string BlogAuthor {  get; set; }
        public string BlogContent {  get; set; }
    }
}
