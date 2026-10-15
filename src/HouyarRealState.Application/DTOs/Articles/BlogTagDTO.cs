using HouyarRealState.Application.DTOs.Common;

namespace HouyarRealState.Application.DTOs.Articles
{
    public class BlogTagDTO:BaseDTO
    {
        public string Tag { get; set; }

        public string TagUrl { get; set; }
    }
}
