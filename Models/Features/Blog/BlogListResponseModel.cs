namespace Models.Features.Blog
{
    public class BlogListResponseModel
    {
        public List<BlogModel> Blogs {  get; set; }
        public PageSettingModel PageSetting { get; set; }
    }
}
