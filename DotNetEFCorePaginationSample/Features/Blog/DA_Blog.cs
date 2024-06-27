using DbService.AppDbContexts;
using Mapping;
using Microsoft.EntityFrameworkCore;
using Models.Features.Blog;
using Models.Features.PageSetting;
using Share;

namespace PresentationLayerApi.Features.Blog
{
    public class DA_Blog
    {
        private readonly AppDbContext _appDbContext;

        public DA_Blog(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<BlogListResponseModel>GetBlogs(int pageNo,int pageSize)
        {
            try
            {
                //pageNo = 1
                //pageSize = 10
                //(1-1) * 10 => 0 => 0 rows skipped

                //pageNo = 2
                //pageSize = 10
                //(2-1)*10 =>10 rows skipped (1 to 10 skipped) start from 11 to 20

                var query =  _appDbContext.Blogs
                    .OrderByDescending(x => x.BlogId);

                var dataLst = await query
                    .WithPagination(pageNo,pageSize)
                    .ToListAsync();
                var totalCount = await _appDbContext.Blogs.CountAsync();
                var pageCount = totalCount / pageSize; //101 / 2 => 50(1)

                if (totalCount % pageSize > 0)
                    pageCount++;

                var lst = dataLst.Select(x => x.Change()).ToList();
                return  new BlogListResponseModel()
                {
                    Blogs = lst,
                    PageSetting = new PageSettingModel(pageNo,pageSize,totalCount,pageCount)
                };

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
