using SharedModel.Dtos;


namespace Repository.Extention
{
    public class PagedList<T> : List<T>
    {
        public MetaData MetaData { get; set; }

        public PagedList(List<T> items, int count, int pageNumber, int pageSize)
        {
            MetaData = new MetaData
            {
                TotalRecords = count,
                PageSize = pageSize,
                CurrentPage = pageNumber,
                TotalPages = (int)Math.Ceiling(count / (double)pageSize)
            };

            AddRange(items);
            CurrentUserPage.TotalPages = MetaData.TotalPages;// Handling redisCache paging // added on 14 Aug 2023
        }

        public static PagedList<T> ToPagedList(IEnumerable<T> source, int pageNumber, int pageSize)
        {
            var count = source.Count();
            var items = source
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize).ToList();

            return new PagedList<T>(items, count, pageNumber, pageSize);
        }

        /* Date added - 15 Nov 2022. This paging function created to allow direct paging to object in database.
          to provide .skip() and .take() to be applied to the object.  */
        public static PagedList<T> ToPagedList(IEnumerable<T> source, int totalRecords, int pageNumber, int pageSize)
        {
            return new PagedList<T>(source.ToList(), totalRecords, pageNumber, pageSize);
        }
    }
}
