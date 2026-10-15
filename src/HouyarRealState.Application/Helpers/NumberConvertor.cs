namespace HouyarRealState.Application.Helpers
{
    public class NumberConvertor
    {
        private static string[] yakan = new string[10] { "صفر", "یک", "دو", "سه", "چهار", "پنج", "شش", "هفت", "هشت", "نه" };
        private static string[] dahgan = new string[10] { "", "", "بیست", "سی", "چهل", "پنجاه", "شصت", "هفتاد", "هشتاد", "نود" };
        private static string[] dahyek = new string[10] { "ده", "یازده", "دوازده", "سیزده", "چهارده", "پانزده", "شانزده", "هفده", "هجده", "نوزده" };
        private static string[] sadgan = new string[10] { "", "یکصد", "دویست", "سیصد", "چهارصد", "پانصد", "ششصد", "هفتصد", "هشتصد", "نهصد" };
        private static string[] basex = new string[5] { "", "هزار", "میلیون", "میلیارد", "تریلیون" };
        private static string getnum3(int num3)
        {
            string s = "";
            int d3, d12;
            d12 = num3 % 100;
            d3 = num3 / 100;
            if (d3 != 0)
                s = sadgan[d3] + " و ";
            if ((d12 >= 10) && (d12 <= 19))
            {
                s = s + dahyek[d12 - 10];
            }
            else
            {
                int d2 = d12 / 10;
                if (d2 != 0)
                    s = s + dahgan[d2] + " و ";
                int d1 = d12 % 10;
                if (d1 != 0)
                    s = s + yakan[d1] + " و ";
                s = s.Substring(0, s.Length - 3);
            }
            ;
            return s;
        }

        public static string NumberToPersian(string snum)
        {
            string stotal = "";

            try
            {
                if (double.Parse(snum) < 0)
                {
                    snum = (double.Parse(snum) * -1).ToString();

                    if (snum == "") return "صفر";
                    if (snum == "0")
                    {
                        return yakan[0];
                    }
                    else
                    {
                        snum = snum.PadLeft(((snum.Length - 1) / 3 + 1) * 3, '0');
                        int L = snum.Length / 3 - 1;
                        for (int i = 0; i <= L; i++)
                        {
                            int b = int.Parse(snum.Substring(i * 3, 3));
                            if (b != 0)
                                stotal = stotal + getnum3(b) + " " + basex[L - i] + " و ";
                        }
                        stotal = stotal.Substring(0, stotal.Length - 3);
                    }

                    return $"منفی {stotal}";
                }
                else
                {
                    if (snum == "") return "صفر";
                    if (snum == "0")
                    {
                        return yakan[0];
                    }
                    else
                    {
                        snum = snum.PadLeft(((snum.Length - 1) / 3 + 1) * 3, '0');
                        int L = snum.Length / 3 - 1;
                        for (int i = 0; i <= L; i++)
                        {
                            int b = int.Parse(snum.Substring(i * 3, 3));
                            if (b != 0)
                                stotal = stotal + getnum3(b) + " " + basex[L - i] + " و ";
                        }
                        stotal = stotal.Substring(0, stotal.Length - 3);
                    }
                }
            }
            catch (Exception)
            {
                return "خطا در پردازش عدد";
                throw;
            }






            return stotal;
        }


    }
    public static class MathTools
    {
        public static int FindMaxNumber(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                throw new InvalidOperationException("Empty list");
            }
            int maxNumber = int.MinValue;

            foreach (var number in numbers)
            {
                maxNumber = Math.Max(number, maxNumber);
            }
            return maxNumber;
        }


        public static int FindMaxNumber(List<string> stringNumbers)
        {
            if (stringNumbers.Count == 0)
            {
                throw new InvalidOperationException("Empty list");
            }
            int maxNumber = int.MinValue;

            foreach (var number in stringNumbers)
            {
                maxNumber = Math.Max(int.Parse(number), maxNumber);
            }
            return maxNumber;
        }

    }
}
