namespace Models.Features.Blog;

#region BlogListResponseModel

public class BlogListResponseModel
{
    public List<BlogModel> Blogs {  get; set; }
    public PageSettingModel PageSetting { get; set; }
}

#endregion