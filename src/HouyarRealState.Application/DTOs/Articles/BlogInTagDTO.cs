using HouyarRealState.Application.DTOs.Common;

namespace HouyarRealState.Application.DTOs.Articles
{
    public class BlogInTagDTO : BaseDTO
    {
        public Guid BlogTagId { get; set; }


        public Guid BlogId { get; set; }
    }
}
