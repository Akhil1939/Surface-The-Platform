
using Surface.Common.Constants;

namespace StudentJobs.Entities.DTOs
{
    public class BaseListRequestDTO
    {
        public int PageIndex { get; set; } = SystemConstant.DEFAULT_PAGE_INDEX;
        public int PageSize { get; set; } = SystemConstant.DEFAULT_PAGE_SIZE;
        public string SortOrder { get; set; } = string.Empty;
        public string SortColumn { get; set; } = SystemConstant.DEFAULT_SORTCOLUMN;
        public BaseListRequestDTO()
        {
            PageIndex = PageIndex < 1 ? 1 : PageIndex;
            PageSize = PageSize < 1 ? 10 : PageSize;
        }
    }
}
