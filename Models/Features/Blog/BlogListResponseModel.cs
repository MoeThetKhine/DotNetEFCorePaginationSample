using Models.Features.PageSetting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Features.Blog
{
    public class BlogListResponseModel
    {
        public List<BlogModel> Blogs {  get; set; }
        public PageSettingModel PageSetting { get; set; }
    }
}
