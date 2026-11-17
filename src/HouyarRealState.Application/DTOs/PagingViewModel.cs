namespace HouyarRealState.Application.DTOs
{
    public class PagingViewModel
    {
        public int CurrentPage { get; set; }
        public int RoundPageCount { get; set; }
        public string Url { get; set; }
        public List<PagingFilterViewModel> Filters { get; set; }
    }



    public class PagingFilterViewModel
    {
        public string Parameter { get; set; }
        public string Value { get; set; }
    }

    public class PageList<T>
    {
        public T _tValue { get; set; }

        public PageList(T tValue)
        {
            _tValue = tValue;
        }

        public static Tuple<List<T>, int> CreatePagedList(List<T> model, int pageNumber, int take)
        {
            int skip = (pageNumber - 1) * take;
            float pageCount = (float)model.Count() / take;
            var roundPageCount = Convert.ToInt32(Math.Ceiling(pageCount));

            return Tuple.Create(model.Skip(skip).Take(take).ToList(), roundPageCount);
        }
    }
}
