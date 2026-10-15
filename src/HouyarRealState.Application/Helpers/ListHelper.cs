using System;
using System.Collections.Generic;
using System.Text;

namespace HouyarRealState.Application.Helpers
{
    public static class ListHelper
    {
        public static List<T> SplitList<T>(List<T> list, int part)
        {
            if (part != 1 && part != 2)
                throw new ArgumentException("مقدار part باید 1 یا 2 باشد.");

            int firstPartCount = (list.Count + 1) / 2;

            if (part == 1)
            {
                return list.Take(firstPartCount).ToList();
            }

            return list.Skip(firstPartCount).ToList();
        }

    }
}
