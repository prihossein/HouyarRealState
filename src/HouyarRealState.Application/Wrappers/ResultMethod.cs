using System;
using System.Collections.Generic;
using System.Text;

namespace HouyarRealState.Application.Wrappers
{
    public class ResultCart
    {
        public string Message { get; set; }
        public bool Result { get; set; }
        public int CartItemsCount { get; set; }
        public string HTMLHeaderCartItems { get; set; }
    }

    public class ResultMethod
    {
        public string Message { get; set; }
        public bool Result { get; set; }
    }
}
