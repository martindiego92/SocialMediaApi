using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialMedia.Core.CustomEntities
{
    public class PagedList<T> : List<T>
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public bool HasPreviousPage => CurrentPage > 1;
        public bool HastNextPage => CurrentPage < TotalPages;
        public int? NextPageNumber => HastNextPage ? CurrentPage + 1 : (int?)null;

        public int? PreviusPageNumber => HastNextPage ? CurrentPage - 1 : (int?)null;
        public PagedList(List<T> items, int count, int pageNumber, int pageSize )
        {
            TotalCount = count;
            PageSize = pageSize;
            CurrentPage = pageNumber;
            TotalPages = (int)Math.Ceiling(count /(double) pageNumber);

            AddRange(items);

        }
        public static PagedList<T> Create(IEnumerable<T> source, int pageNumber,int pageSize )
        {
            var count = source.Count();
            var items = source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
           
            return new PagedList<T>(items, count, pageNumber, pageSize);
        }

    }
}
