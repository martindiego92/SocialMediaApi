namespace SocialMedia.Core.CustomEntities
{
    public class Metadata
    {
        public int TotalCount { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HastNextPage { get; set; }
        public string NextPageUrl { get; set; }
        public string PreviusPageUrl { get; set; }

    }
}
