using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace HouyarRealState.Application.Helpers
{
    public static class StringExtensions

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


        


        public static string NumberToPersian(this string snum)
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
            }






            return stotal;
        }

        public static TimeSpan SumDurations(this List<string> durations)
        {
            if (durations == null || durations.Count == 0)
                return TimeSpan.Zero;

            TimeSpan total = TimeSpan.Zero;

            foreach (var duration in durations)
            {
                if (string.IsNullOrWhiteSpace(duration))
                    continue;

                if (TimeSpan.TryParse(duration, CultureInfo.InvariantCulture, out TimeSpan parsed))
                {
                    total += parsed;
                }
                else
                {
                    throw new FormatException($"Invalid duration format: {duration}");
                }
            }

            return total;
        }



        public static string RemoveLeadingZeroMobileNumbe(this string mobileNumbe)
        {
            if (string.IsNullOrWhiteSpace(mobileNumbe))
                return mobileNumbe;

            return mobileNumbe.StartsWith("0") ? mobileNumbe.Substring(1) : mobileNumbe;
        }
        public static bool HasValue(this string value, bool ignoreWhiteSpace = true)
        {
            return ignoreWhiteSpace ? !string.IsNullOrWhiteSpace(value) : !string.IsNullOrEmpty(value);
        }

        public static int ToInt(this string value)
        {
            return Convert.ToInt32(value);
        }

        public static decimal ToDecimal(this string value)
        {
            return Convert.ToDecimal(value);
        }

        public static string ToNumeric(this int value)
        {
            return value.ToString("N0"); //"123,456"
        }

        public static string ToNumeric(this decimal value)
        {
            return value.ToString("N0");
        }

        public static string ToCardNumber(this string value)
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length > 16 || value.Length < 16)
            {
                return "0000-0000-0000-0000";
            }

            var take1 = value.Substring(0, 4);
            var take2 = value.Substring(4, 4);
            var take3 = value.Substring(8, 4);
            var take4 = value.Substring(12, 4);


            return $"{take1}-{take2}-{take3}-{take4}";
        }

        public static string ToCurrency(this int value)
        {
            //fa-IR => current culture currency symbol => ریال
            //123456 => "123,123ریال"
            return value.ToString("C0");
        }

        public static string ToCurrency(this decimal value)
        {
            return value.ToString("C0");
        }

        public static string En2Fa(this string str)
        {
            return str.Replace("0", "۰")
                .Replace("1", "۱")
                .Replace("2", "۲")
                .Replace("3", "۳")
                .Replace("4", "۴")
                .Replace("5", "۵")
                .Replace("6", "۶")
                .Replace("7", "۷")
                .Replace("8", "۸")
                .Replace("9", "۹");
        }


        public static bool IsPersianDate(this string shamsiDate)
        {
            try
            {
                var miladiDate = shamsiDate.ToMiladi();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }


        public static string Fa2En(this string str)
        {
            return str.Replace("۰", "0")
                .Replace("۱", "1")
                .Replace("۲", "2")
                .Replace("۳", "3")
                .Replace("۴", "4")
                .Replace("۵", "5")
                .Replace("۶", "6")
                .Replace("۷", "7")
                .Replace("۸", "8")
                .Replace("۹", "9")
                //iphone numeric
                .Replace("٠", "0")
                .Replace("١", "1")
                .Replace("٢", "2")
                .Replace("٣", "3")
                .Replace("٤", "4")
                .Replace("٥", "5")
                .Replace("٦", "6")
                .Replace("٧", "7")
                .Replace("٨", "8")
                .Replace("٩", "9");
        }

        public static string FixPersianChars(this string str)
        {
            return str.Replace("ﮎ", "ک")
                .Replace("ﮏ", "ک")
                .Replace("ﮐ", "ک")
                .Replace("ﮑ", "ک")
                .Replace("ك", "ک")
                .Replace("ي", "ی")
                .Replace(" ", " ")
                .Replace("‌", " ")
                .Replace("ھ", "ه");//.Replace("ئ", "ی");
        }

        public static string CleanString(this string str)
        {
            return str.Trim().FixPersianChars().Fa2En().NullIfEmpty();
        }

        public static string NullIfEmpty(this string str)
        {
            return str?.Length == 0 ? null : str;
        }


    }

    public static class StringTools
    {

        public static string GetFileNameFromUrl(string url)
        {
            var uri = new Uri(url);

            return Path.GetFileName(uri.LocalPath);
        }
        public static string BetweenText(this string word, string start, string end)
        {


            int pos1 = word.IndexOf(start) + start.Length;
            int pos2 = word.Substring(pos1).IndexOf(end);
            return word.Substring(pos1, pos2);
        }


        public static bool IsNullOrWhiteSpace(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }
        public static string GetUnicodeCodePoints(this string s)
        {
            // Convert a C# string to a byte array  
            byte[] bytes = Encoding.ASCII.GetBytes(s);

            // Convert a byte array to a C# string. 
            return Encoding.Unicode.GetString(bytes);
        }
        public static string OptimizeForUrl(this string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                return str.Trim()
                            .Replace(' ', '_')
                            .Replace('?', '_')
                                .Replace('/', '_')
    .Replace(@"\", "_")
    .Replace('@', '_')
    .Replace('#', '_')
    .Replace('$', '_')
    .Replace('%', '_')
    .Replace('&', '_')
    .Replace('+', '_')
    .Replace('*', '_')
    .Replace("!", "_")
    .Replace("؟", "_")
    .Replace(".", "_")
    .Replace(":", "_")
    .Replace("]", "_")
    .Replace("[", "_")
    .Replace("=", "_")
    .Replace("^", "_")
    .Replace("~", "_")
    .Replace("'", "_")
    .Replace(",", "_")
    .ToLower();
            }
            return str;

        }

        public static string OptimizeForFiles(this string str)
        {
            return str.Trim().Replace(' ', '_').Replace('?', '_').Replace('/', '_').Replace(@"\", "_").Replace('@', '_').Replace('#', '_').Replace('$', '_').Replace('%', '_').Replace('&', '_').Replace('+', '_').Replace('*', '_').Replace("!", "_").Replace("؟", "_").ToLower();
        }

        public static string FixedFileName(this string str)
        {
            return str.Trim().Replace(' ', '_').Replace('?', '_').Replace('/', '_').Replace(@"\", "_").Replace('@', '_').Replace('#', '_').Replace('$', '_').Replace('%', '_').Replace('&', '_').Replace('+', '_').Replace('*', '_').Replace("!", "_").Replace("؟", "_").ToLower();
        }

        public static bool IsMobile(this string mobile)
        {
            string pattern = @"^09\d{9}$";

            if (string.IsNullOrWhiteSpace(mobile)) return false;

            try
            {
                return Regex.IsMatch(mobile, pattern);   //Regex.Match(mobile, pattern);
            }
            catch (ArgumentException)
            {
                return false;
            }
        }
        public static bool IsIPAddress(this string ip) =>
    new Regex("^(?!0)(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(?!0)(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(?!0)(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(?!0)(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$")
        .IsMatch(ip);
        public static bool IsEmail(this string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


        public static bool IsNationalCode(this string nationalCode)
        {
            try
            {
                char[] chArray = nationalCode.ToCharArray();
                int[] numArray = new int[chArray.Length];
                for (int i = 0; i < chArray.Length; i++)
                {
                    numArray[i] = (int)char.GetNumericValue(chArray[i]);
                }
                int num2 = numArray[9];
                switch (nationalCode)
                {
                    case "0000000000":
                    case "1111111111":
                    case "22222222222":
                    case "33333333333":
                    case "4444444444":
                    case "5555555555":
                    case "6666666666":
                    case "7777777777":
                    case "8888888888":
                    case "9999999999":
                        return false;
                        break;
                }
                int num3 = ((((((((numArray[0] * 10) + (numArray[1] * 9)) + (numArray[2] * 8)) + (numArray[3] * 7)) + (numArray[4] * 6)) + (numArray[5] * 5)) + (numArray[6] * 4)) + (numArray[7] * 3)) + (numArray[8] * 2);
                int num4 = num3 - ((num3 / 11) * 11);
                if ((((num4 == 0) && (num2 == num4)) || ((num4 == 1) && (num2 == 1))) || ((num4 > 1) && (num2 == Math.Abs((int)(num4 - 11)))))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }



        public static bool IsValidCharacters(this string input, string allowCharacter)
        {
            foreach (var item in input)
            {
                if (!allowCharacter.Contains(item))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
