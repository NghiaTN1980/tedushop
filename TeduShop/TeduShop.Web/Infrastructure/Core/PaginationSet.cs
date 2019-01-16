using System.Collections.Generic;
using System.Linq;

namespace TeduShop.Web.Infrastructure.Core
{
    public class PaginationSet<T>
    {
        public int Page { set; get; }

        public int Count
        {
            get
            {
                return (Items != null) ? Items.Count() : 0;
            }
        }

        //Tổng số trang
        public int TotalPages { get; set; }
        //Tổng số dòng
        public int TotalCount { get; set; }
        public IEnumerable<T> Items { get; set; }
    }
}