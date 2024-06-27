using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Features.PageSetting
{
    public class PageSettingModel
    {
        public int PageNo { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public int TotalCount {  get; set; }
        public int PageCount { get; set; }
        public bool IsEndOfPage { get { return PageCount == PageNo; } }

        #region PageSettingModel
        public PageSettingModel(int pageNo, int pageSize, int totalCount, int pageCount)
        {
            PageNo = pageNo;
            PageSize = pageSize;
            TotalCount = totalCount;
            PageCount = pageCount;
        }
        #endregion

    }
}
