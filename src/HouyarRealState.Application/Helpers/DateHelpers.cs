using System.Globalization;

namespace HouyarRealState.Application.Helpers
{
    public class HijriEvent
    {
        public int HijriEventId { get; set; }
        public int Mounth { get; set; }
        public int DayInMounth { get; set; }
        public bool IsClosed { get; set; }
        public bool IsDelete { get; set; }
        public string Description { get; set; }
    }
    public class MiladiEvent
    {
        public int MiladiEventId { get; set; }
        public int Mounth { get; set; }
        public int DayInMounth { get; set; }
        public bool IsClosed { get; set; }
        public string Description { get; set; }
        public bool IsDelete { get; set; }
    }
    public class PersianEvent
    {
        public int PersianEventId { get; set; }
        public int Mounth { get; set; }
        public int DayInMounth { get; set; }
        public bool IsDelete { get; set; }
        public bool IsClosed { get; set; }
        public string Description { get; set; }
    }
    public class PersianMonths
    {
        public static string فروردین { get { return new string("فروردین"); } }
        public static string اردیبهشت { get { return new string("اردیبهشت"); } }
        public static string خرداد { get { return new string("خرداد"); } }
        public static string تیر { get { return new string("تیر"); } }
        public static string مرداد { get { return new string("مرداد"); } }
        public static string شهریور { get { return new string("شهریور"); } }
        public static string مهر { get { return new string("مهر"); } }
        public static string آبان { get { return new string("آبان"); } }
        public static string آذر { get { return new string("آذر"); } }
        public static string دی { get { return new string("دی"); } }
        public static string بهمن { get { return new string("بهمن"); } }
        public static string اسفند { get { return new string("اسفند"); } }
    }
    public class PersianDay
    {
        public int DayOfWeek { get; set; }
        public string DayName { get; set; }
        public bool IsClosed { get; set; }
        public bool FirstDay { get; set; }
    }
    public class PersianDays
    {
        public static PersianDay شنبه { get { return new PersianDay { DayOfWeek = 1, DayName = "شنبه", IsClosed = false, FirstDay = true }; } }
        public static PersianDay یکشنبه { get { return new PersianDay { DayOfWeek = 2, DayName = "یکشنبه", IsClosed = false, FirstDay = false }; } }
        public static PersianDay دوشنبه { get { return new PersianDay { DayOfWeek = 3, DayName = "دوشنبه", IsClosed = false, FirstDay = false }; } }
        public static PersianDay سه_شنبه { get { return new PersianDay { DayOfWeek = 4, DayName = "سه_شنبه", IsClosed = false, FirstDay = false }; } }
        public static PersianDay چهارشنبه { get { return new PersianDay { DayOfWeek = 5, DayName = "چهارشنبه", IsClosed = false, FirstDay = false }; } }
        public static PersianDay پنجشنبه { get { return new PersianDay { DayOfWeek = 6, DayName = "پنجشنبه", IsClosed = false, FirstDay = false }; } }
        public static PersianDay جمعه { get { return new PersianDay { DayOfWeek = 7, DayName = "جمعه", IsClosed = true, FirstDay = false }; } }
    }
    public static class DateHelpers
    {
        public static List<PersianEvent> GetPersianEvents()
        {
            List<PersianEvent> lstPersianEvents = new List<PersianEvent>()
            {
                new PersianEvent{ PersianEventId= 1, Mounth = 1, DayInMounth = 1, Description = "جشن نوروز/جشن سال نو", IsClosed = true},
new PersianEvent{ PersianEventId= 2, Mounth = 1, DayInMounth = 2, Description = "عیدنوروز", IsClosed = true},
new PersianEvent{ PersianEventId= 3, Mounth = 1, DayInMounth = 3, Description = "عیدنوروز", IsClosed = true},
new PersianEvent{ PersianEventId= 4, Mounth = 1, DayInMounth = 4, Description = "عیدنوروز", IsClosed = true},
new PersianEvent{ PersianEventId= 5, Mounth = 1, DayInMounth = 6, Description = "روز امید، روز شادباش نویسی", IsClosed = false},
new PersianEvent{ PersianEventId= 6, Mounth = 1, DayInMounth = 6, Description = "زادروز آشو زرتشت، اَبَراِنسان بزرگ تاریخ", IsClosed = false},
new PersianEvent{ PersianEventId= 7, Mounth = 1, DayInMounth = 10, Description = "جشن آبانگاه", IsClosed = false},
new PersianEvent{ PersianEventId= 8, Mounth = 1, DayInMounth = 12, Description = "روز جمهوری اسلامی", IsClosed = true},
new PersianEvent{ PersianEventId= 9, Mounth = 1, DayInMounth = 13, Description = "جشن سیزده به در", IsClosed = true},
new PersianEvent{ PersianEventId= 10, Mounth = 1, DayInMounth = 17, Description = "سروش روز،جشن سروشگان", IsClosed = false},
new PersianEvent{ PersianEventId= 11, Mounth = 1, DayInMounth = 19, Description = "فروردین روز،جشن فروردینگان", IsClosed = false},
new PersianEvent{ PersianEventId= 12, Mounth = 1, DayInMounth = 23, Description = "روز دندانپزشک", IsClosed = false},
new PersianEvent{ PersianEventId= 13, Mounth = 1, DayInMounth = 25, Description = "روز بزرگداشت عطار نیشابوری", IsClosed = false},
new PersianEvent{ PersianEventId= 14, Mounth = 1, DayInMounth = 29, Description = "روز ارتش جمهوری اسلامی ایران", IsClosed = false},
new PersianEvent{ PersianEventId= 15, Mounth = 1, DayInMounth = 30, Description = "روز علوم آزمایشگاهی، زاد روز حکیم سید اسماعیل جرجانی", IsClosed = false},
new PersianEvent{ PersianEventId= 16, Mounth = 2, DayInMounth = 1, Description = "روز بزرگداشت سعدی", IsClosed = false},
new PersianEvent{ PersianEventId= 17, Mounth = 2, DayInMounth = 3, Description = "روزبزرگداشت شیخ بهایی؛ روزملی کارآفرینی", IsClosed = false},
new PersianEvent{ PersianEventId= 18, Mounth = 2, DayInMounth = 9, Description = "روزشوراها", IsClosed = false},
new PersianEvent{ PersianEventId= 19, Mounth = 2, DayInMounth = 9, Description = "روز جهانی روانشناس و مشاور", IsClosed = false},
new PersianEvent{ PersianEventId= 20, Mounth = 2, DayInMounth = 10, Description = "جشن چهلم نوروز؛ روز ملی خلیج فارس", IsClosed = false},
new PersianEvent{ PersianEventId= 21, Mounth = 2, DayInMounth = 12, Description = "شهادت استاد مرتضی مطهری، روزمعلم", IsClosed = false},
new PersianEvent{ PersianEventId= 22, Mounth = 2, DayInMounth = 15, Description = "جشن میانه بهار/جشن بهاربد؛ روز شیراز", IsClosed = false},
new PersianEvent{ PersianEventId= 23, Mounth = 2, DayInMounth = 17, Description = "روز اسناد ملی و میراث مکتوب", IsClosed = false},
new PersianEvent{ PersianEventId= 24, Mounth = 2, DayInMounth = 17, Description = "روز جهانی قدس", IsClosed = false},
new PersianEvent{ PersianEventId= 25, Mounth = 2, DayInMounth = 25, Description = "روز بزرگداشت فردوسی", IsClosed = false},
new PersianEvent{ PersianEventId= 26, Mounth = 2, DayInMounth = 27, Description = "روز ارتباطات و روابط عمومی", IsClosed = false},
new PersianEvent{ PersianEventId= 27, Mounth = 2, DayInMounth = 28, Description = "روز بزرگداشت حکیم عمر خیام", IsClosed = false},
new PersianEvent{ PersianEventId= 28, Mounth = 3, DayInMounth = 1, Description = "روز بهره وری و بهینه سازی مصرف", IsClosed = false},
new PersianEvent{ PersianEventId= 29, Mounth = 3, DayInMounth = 1, Description = "روز بزرگداشت ملاصدرا", IsClosed = false},
new PersianEvent{ PersianEventId= 30, Mounth = 3, DayInMounth = 3, Description = "فتح خرمشهر در عملیات بیت المقدس و روز مقاومت، ایثار و پیروزی", IsClosed = false},
new PersianEvent{ PersianEventId= 31, Mounth = 3, DayInMounth = 4, Description = "روز دزفول، روز مقاومت و پایداری", IsClosed = false},
new PersianEvent{ PersianEventId= 32, Mounth = 3, DayInMounth = 6, Description = "خرداد روز،جشن خردادگان", IsClosed = false},
new PersianEvent{ PersianEventId= 33, Mounth = 3, DayInMounth = 14, Description = "رحلت حضرت امام خمینی", IsClosed = true},
new PersianEvent{ PersianEventId= 34, Mounth = 3, DayInMounth = 15, Description = "قیام 15 خرداد", IsClosed = true},
new PersianEvent{ PersianEventId= 35, Mounth = 3, DayInMounth = 25, Description = "روز ملی گل وگیاه", IsClosed = false},
new PersianEvent{ PersianEventId= 36, Mounth = 3, DayInMounth = 27, Description = "روز جهاد کشاورزی", IsClosed = false},
new PersianEvent{ PersianEventId= 37, Mounth = 4, DayInMounth = 1, Description = "جشن آب پاشونک، جشن آغاز تابستان", IsClosed = false},
new PersianEvent{ PersianEventId= 38, Mounth = 4, DayInMounth = 1, Description = "روز اصناف", IsClosed = false},
new PersianEvent{ PersianEventId= 39, Mounth = 4, DayInMounth = 7, Description = "انفجار دفتر حزب جمهوری اسلامی و شهادت دکتر بهشتی و 72 نفر از اعضای حزب؛ روز قوه قضاییه", IsClosed = false},
new PersianEvent{ PersianEventId= 40, Mounth = 4, DayInMounth = 8, Description = "روز مبارزه با سلاح های شیمیایی و میکروبی", IsClosed = false},
new PersianEvent{ PersianEventId= 41, Mounth = 4, DayInMounth = 10, Description = "روز صنعت و معدن", IsClosed = false},
new PersianEvent{ PersianEventId= 42, Mounth = 4, DayInMounth = 12, Description = "شلیک به پرواز 655 ایران ایر توسط ناو وینسنس [ 1367 خورشیدی ]", IsClosed = false},
new PersianEvent{ PersianEventId= 43, Mounth = 4, DayInMounth = 13, Description = "تیر روز،جشن تیرگان", IsClosed = false},
new PersianEvent{ PersianEventId= 44, Mounth = 4, DayInMounth = 14, Description = "روز قلم", IsClosed = false},
new PersianEvent{ PersianEventId= 45, Mounth = 4, DayInMounth = 15, Description = "جشن خام خواری", IsClosed = false},
new PersianEvent{ PersianEventId= 46, Mounth = 4, DayInMounth = 22, Description = "زادروز محمد خوارزمی، ریاضیدان و فیلسوف ایرانی و روز ملی فناوری اطلاعات", IsClosed = false},
new PersianEvent{ PersianEventId= 47, Mounth = 4, DayInMounth = 25, Description = "روز بهزیستی و تامین اجتماعی", IsClosed = false},
new PersianEvent{ PersianEventId= 48, Mounth = 4, DayInMounth = 27, Description = "اعلام پذیرش قطعنامه 598 شورای امنیت از سوی ایران [ 1367 خورشیدی ]", IsClosed = false},
new PersianEvent{ PersianEventId= 49, Mounth = 5, DayInMounth = 6, Description = "روز ترویج آموزش های فنی و حرفه ای", IsClosed = false},
new PersianEvent{ PersianEventId= 50, Mounth = 5, DayInMounth = 7, Description = "مرداد روز،جشن مردادگان", IsClosed = false},
new PersianEvent{ PersianEventId= 51, Mounth = 5, DayInMounth = 8, Description = "روز بزرگداشت شیخ شهاب الدین سهروردی", IsClosed = false},
new PersianEvent{ PersianEventId= 52, Mounth = 5, DayInMounth = 10, Description = "جشن چله تابستان", IsClosed = false},
new PersianEvent{ PersianEventId= 53, Mounth = 5, DayInMounth = 14, Description = " صدور فرمان مشروطیت", IsClosed = false},
new PersianEvent{ PersianEventId= 54, Mounth = 5, DayInMounth = 17, Description = " روز خبرنگار", IsClosed = false},
new PersianEvent{ PersianEventId= 55, Mounth = 5, DayInMounth = 26, Description = " سالروز ورود آزادگانِ سرافراز به وطن", IsClosed = false},
new PersianEvent{ PersianEventId= 56, Mounth = 5, DayInMounth = 28, Description = " سالروز وقایع 28 مرداد و برکناری دکتر محمد مصدق", IsClosed = false},
new PersianEvent{ PersianEventId= 57, Mounth = 5, DayInMounth = 28, Description = "سالروز فاجعه آتش زدن سینما رکس آبادان", IsClosed = false},
new PersianEvent{ PersianEventId= 58, Mounth = 6, DayInMounth = 1, Description = "روز بزرگداشت ابوعلی سینا و روز پزشک", IsClosed = false},
new PersianEvent{ PersianEventId= 59, Mounth = 6, DayInMounth = 2, Description = "آغاز هفته دولت", IsClosed = false},
new PersianEvent{ PersianEventId= 60, Mounth = 6, DayInMounth = 4, Description = "زادروز داراب (کوروش)", IsClosed = false},
new PersianEvent{ PersianEventId= 61, Mounth = 6, DayInMounth = 4, Description = "شهریور روز،جشن شهریورگان)", IsClosed = false},
new PersianEvent{ PersianEventId= 62, Mounth = 6, DayInMounth = 4, Description = "روز کارمند", IsClosed = false},
new PersianEvent{ PersianEventId= 63, Mounth = 6, DayInMounth = 5, Description = "روز بزرگداشت محمدبن زکریای رازی و روز داروساز", IsClosed = false},
new PersianEvent{ PersianEventId= 64, Mounth = 6, DayInMounth = 8, Description = "انفجار در دفتر نخست‌وزیری جمهوری اسلامی ایران، روز مبارزه با تروریسم", IsClosed = false},
new PersianEvent{ PersianEventId= 65, Mounth = 6, DayInMounth = 11, Description = "روزصنعت چاپ", IsClosed = false},
new PersianEvent{ PersianEventId= 66, Mounth = 6, DayInMounth = 13, Description = "روز بزرگداشت ابوریحان بیرونی", IsClosed = false},
new PersianEvent{ PersianEventId= 67, Mounth = 6, DayInMounth = 13, Description = "روز تعاون", IsClosed = false},
new PersianEvent{ PersianEventId= 68, Mounth = 6, DayInMounth = 17, Description = "قیام 17 شهریور", IsClosed = false},
new PersianEvent{ PersianEventId= 69, Mounth = 6, DayInMounth = 19, Description = "درگذشت آیت الله سید محمود طالقانی", IsClosed = false},
new PersianEvent{ PersianEventId= 70, Mounth = 6, DayInMounth = 21, Description = "روز سینما", IsClosed = false},
new PersianEvent{ PersianEventId= 71, Mounth = 6, DayInMounth = 27, Description = "روز سینما", IsClosed = false},
new PersianEvent{ PersianEventId= 72, Mounth = 6, DayInMounth = 27, Description = "روز شعر و ادب پارسی و روز بزرگداشت استاد شهریار", IsClosed = false},
new PersianEvent{ PersianEventId= 73, Mounth = 6, DayInMounth = 30, Description = "روز گفتگوی تمدنها", IsClosed = false},
new PersianEvent{ PersianEventId= 74, Mounth = 6, DayInMounth = 31, Description = "آغاز هفته دفاع مقدس", IsClosed = false},
new PersianEvent{ PersianEventId= 75, Mounth = 7, DayInMounth = 1, Description = "آغاز حمله مغول به ایران در پاییز 598 خورشیدی", IsClosed = false},
new PersianEvent{ PersianEventId= 76, Mounth = 7, DayInMounth = 7, Description = "روز آتش نشانی و ایمنی", IsClosed = false},
new PersianEvent{ PersianEventId= 77, Mounth = 7, DayInMounth = 7, Description = "سقوط هواپیمای حامل جمعی از فرماندهان جنگ (کلاهدوز، نامجو، فلاحی، فکوری، جهان آرا) در سال 1360", IsClosed = false},
new PersianEvent{ PersianEventId= 78, Mounth = 7, DayInMounth = 8, Description = "روزبزرگداشت مولوی", IsClosed = false},
new PersianEvent{ PersianEventId= 79, Mounth = 7, DayInMounth = 10, Description = "مهر روز،جشن مهرگان", IsClosed = false},
new PersianEvent{ PersianEventId= 80, Mounth = 7, DayInMounth = 13, Description = "روز نیروی انتظامی", IsClosed = false},
new PersianEvent{ PersianEventId= 81, Mounth = 7, DayInMounth = 14, Description = "روز دامپزشکی", IsClosed = false},
new PersianEvent{ PersianEventId= 82, Mounth = 7, DayInMounth = 16, Description = "روز ملی کودک", IsClosed = false},
new PersianEvent{ PersianEventId= 83, Mounth = 7, DayInMounth = 20, Description = "روز بزرگداشت حافظ", IsClosed = false},
new PersianEvent{ PersianEventId= 84, Mounth = 7, DayInMounth = 21, Description = "جشن پیروزی کاوه و فریدون", IsClosed = false},
new PersianEvent{ PersianEventId= 85, Mounth = 7, DayInMounth = 26, Description = "روز تربیت بدنی و ورزش", IsClosed = false},
new PersianEvent{ PersianEventId= 86, Mounth = 7, DayInMounth = 29, Description = "روز ملی کوهنورد", IsClosed = false},
new PersianEvent{ PersianEventId= 87, Mounth = 8, DayInMounth = 1, Description = "روز آمار و برنامه ریزی", IsClosed = false},
new PersianEvent{ PersianEventId= 88, Mounth = 8, DayInMounth = 7, Description = "سالروز ورود کوروش بزرگ به بابل در سال 539 پیش از میلاد", IsClosed = false},
new PersianEvent{ PersianEventId= 89, Mounth = 8, DayInMounth = 8, Description = "روز نوجوان", IsClosed = false},
new PersianEvent{ PersianEventId= 90, Mounth = 8, DayInMounth = 10, Description = "آبان روز، جشن آبانگان", IsClosed = false},
new PersianEvent{ PersianEventId= 91, Mounth = 8, DayInMounth = 13, Description = "روز دانش آموز", IsClosed = false},
new PersianEvent{ PersianEventId= 92, Mounth = 8, DayInMounth = 14, Description = "روز فرهنگ عمومی", IsClosed = false},
new PersianEvent{ PersianEventId= 93, Mounth = 8, DayInMounth = 15, Description = "جشن میانه پاییز", IsClosed = false},
new PersianEvent{ PersianEventId= 94, Mounth = 8, DayInMounth = 18, Description = "روز ملی کیفیت", IsClosed = false},
new PersianEvent{ PersianEventId= 95, Mounth = 8, DayInMounth = 24, Description = "روز کتاب و کتابخوانی", IsClosed = false},
new PersianEvent{ PersianEventId= 96, Mounth = 9, DayInMounth = 1, Description = "آذر جشن", IsClosed = false},
new PersianEvent{ PersianEventId= 97, Mounth = 9, DayInMounth = 5, Description = "روز بسیج مستضعفان", IsClosed = false},
new PersianEvent{ PersianEventId= 98, Mounth = 9, DayInMounth = 7, Description = "روز نیروی دریایی", IsClosed = false},
new PersianEvent{ PersianEventId= 99, Mounth = 9, DayInMounth = 9, Description = "جشن آذرگان ،آذر روز", IsClosed = false},
new PersianEvent{ PersianEventId= 100, Mounth = 9, DayInMounth = 10, Description = "روز مجلس", IsClosed = false},
new PersianEvent{ PersianEventId= 101, Mounth = 9, DayInMounth = 13, Description = "روز بیمه", IsClosed = false},
new PersianEvent{ PersianEventId= 102, Mounth = 9, DayInMounth = 15, Description = "روز حسابدار", IsClosed = false},
new PersianEvent{ PersianEventId= 103, Mounth = 9, DayInMounth = 16, Description = "روز دانشجو", IsClosed = false},
new PersianEvent{ PersianEventId= 104, Mounth = 9, DayInMounth = 25, Description = "روز پژوهش", IsClosed = false},
new PersianEvent{ PersianEventId= 105, Mounth = 9, DayInMounth = 26, Description = "روز حمل و نقل", IsClosed = false},
new PersianEvent{ PersianEventId= 106, Mounth = 9, DayInMounth = 30, Description = "جشن شب یلدا", IsClosed = false},
new PersianEvent{ PersianEventId= 107, Mounth = 10, DayInMounth = 1, Description = "روز میلاد خورشید؛ جشن خرم روز، نخستین جشن دیگان", IsClosed = false},
new PersianEvent{ PersianEventId= 108, Mounth = 10, DayInMounth = 5, Description = "زمین لرزه ی بم [1382 خورشیدی]", IsClosed = false},
new PersianEvent{ PersianEventId= 109, Mounth = 10, DayInMounth = 5, Description = "سالروز شهادت آشو زرتشت، اَبَراِنسان بزرگ تاریخ", IsClosed = false},
new PersianEvent{ PersianEventId= 110, Mounth = 10, DayInMounth = 8, Description = "دی به آذر روز، دومین جشن دیگان", IsClosed = false},
new PersianEvent{ PersianEventId= 111, Mounth = 10, DayInMounth = 13, Description = "شهادت سردار حاج قاسم سلیمانی [1398 خورشیدی]", IsClosed = false},
new PersianEvent{ PersianEventId= 112, Mounth = 10, DayInMounth = 15, Description = "دی به مهر روز، سومین جشن دیگان", IsClosed = false},
new PersianEvent{ PersianEventId= 113, Mounth = 10, DayInMounth = 16, Description = "غرق شدن کشتی سانچی [1396 خورشیدی]", IsClosed = false},
new PersianEvent{ PersianEventId= 114, Mounth = 10, DayInMounth = 18, Description = "شلیک به پرواز 752 هواپیمایی اوکراین [1398 خورشیدی]", IsClosed = false},
new PersianEvent{ PersianEventId= 115, Mounth = 10, DayInMounth = 19, Description = "درگذشت اکبر هاشمی رفسنجانی [1395 خورشیدی]", IsClosed = false},
new PersianEvent{ PersianEventId= 116, Mounth = 10, DayInMounth = 20, Description = "درگذشت اکبر هاشمی رفسنجانی [1395 خورشیدی]", IsClosed = false},
new PersianEvent{ PersianEventId= 117, Mounth = 10, DayInMounth = 23, Description = "دی به دین روز، چهارمین جشن دیگان", IsClosed = false},
new PersianEvent{ PersianEventId= 118, Mounth = 10, DayInMounth = 30, Description = "آتش‌سوزی و فروریختن ساختمان پلاسکو [1395 خورشیدی]", IsClosed = false},
new PersianEvent{ PersianEventId= 119, Mounth = 11, DayInMounth = 1, Description = "زادروز فردوسی", IsClosed = false},
new PersianEvent{ PersianEventId= 120, Mounth = 11, DayInMounth = 2, Description = "بهمن روز، جشن بهمنگان", IsClosed = false},
new PersianEvent{ PersianEventId= 121, Mounth = 11, DayInMounth = 5, Description = "جشن نوسره", IsClosed = false},
new PersianEvent{ PersianEventId= 122, Mounth = 11, DayInMounth = 10, Description = "جشن سده", IsClosed = false},
new PersianEvent{ PersianEventId= 123, Mounth = 11, DayInMounth = 12, Description = "بازگشت امام خمینی (ره) به ایران", IsClosed = false},
new PersianEvent{ PersianEventId= 124, Mounth = 11, DayInMounth = 15, Description = "جشن میانه زمستان", IsClosed = false},
new PersianEvent{ PersianEventId= 125, Mounth = 11, DayInMounth = 19, Description = "روز نیروی هوایی", IsClosed = false},
new PersianEvent{ PersianEventId= 126, Mounth = 11, DayInMounth = 22, Description = "پیروزی انقلاب اسلامی", IsClosed = true},
new PersianEvent{ PersianEventId= 127, Mounth = 11, DayInMounth = 29, Description = "جشن سپندارمذگان و روز عشق", IsClosed = false},
new PersianEvent{ PersianEventId= 128, Mounth = 12, DayInMounth = 5, Description = "روز بزرگداشت زمین و بانوان", IsClosed = false},
new PersianEvent{ PersianEventId= 129, Mounth = 12, DayInMounth = 5, Description = "روز بزرگداشت خواجه نصیر الدین طوسی و روز مهندس", IsClosed = false},
new PersianEvent{ PersianEventId= 130, Mounth = 12, DayInMounth = 7, Description = "سالروز استقلال کانون وکلای دادگستری و روز وکیل مدافع", IsClosed = false},
new PersianEvent{ PersianEventId= 131, Mounth = 12, DayInMounth = 7, Description = "سالروز درگذشت علی اکبر دهخدا", IsClosed = false},
new PersianEvent{ PersianEventId= 132, Mounth = 12, DayInMounth = 15, Description = "روز درختکاری", IsClosed = false},
new PersianEvent{ PersianEventId= 133, Mounth = 12, DayInMounth = 25, Description = "پایان سرایش شاهنامه", IsClosed = false},
new PersianEvent{ PersianEventId= 134, Mounth = 12, DayInMounth = 29, Description = "روز ملی شدن صنعت نفت ایران", IsClosed = true},

            };
            return lstPersianEvents;
        }
        public static List<MiladiEvent> GetMiladiEvents()
        {
            List<MiladiEvent> lstMiladiEvents = new List<MiladiEvent>()
            {
                new MiladiEvent{ MiladiEventId= 1, Mounth = 1, DayInMounth = 1, Description = "جشن آغاز سال نو میلادی", IsClosed = false},
new MiladiEvent{ MiladiEventId= 2, Mounth = 2, DayInMounth = 11, Description = "حمله به سفارت روسیه و قتل گریبایدوف سفیر روسیه تزاری در ایران", IsClosed = false},
new MiladiEvent{ MiladiEventId= 3, Mounth = 2, DayInMounth = 12, Description = "زادروز چارلز داروین بنیانگذار نظریه‌ی فرگشت از طریق انتخاب طبیعی", IsClosed = false},
new MiladiEvent{ MiladiEventId= 4, Mounth = 2, DayInMounth = 14, Description = "جشن ولنتاین", IsClosed = false},
new MiladiEvent{ MiladiEventId= 5, Mounth = 3, DayInMounth = 8, Description = "روزجهانی زنان", IsClosed = false},
new MiladiEvent{ MiladiEventId= 6, Mounth = 3, DayInMounth = 14, Description = "روز جهانی عدد پی π", IsClosed = false},
new MiladiEvent{ MiladiEventId= 7, Mounth = 3, DayInMounth = 20, Description = "روز جهانی شادی", IsClosed = false},
new MiladiEvent{ MiladiEventId= 8, Mounth = 3, DayInMounth = 27, Description = "روز جهانی تئاتر", IsClosed = false},
new MiladiEvent{ MiladiEventId= 9, Mounth = 4, DayInMounth = 7, Description = "روز جهانی بهداشت", IsClosed = false},
new MiladiEvent{ MiladiEventId= 10, Mounth = 4, DayInMounth = 22, Description = "جشن گیاه آوری؛ روز زمین", IsClosed = false},
new MiladiEvent{ MiladiEventId= 11, Mounth = 5, DayInMounth = 5, Description = "روز جهانی ماما", IsClosed = false},
new MiladiEvent{ MiladiEventId= 12, Mounth = 5, DayInMounth = 8, Description = "روز جهانی صلیب سرخ و هلال احمر", IsClosed = false},
new MiladiEvent{ MiladiEventId= 13, Mounth = 5, DayInMounth = 18, Description = "روز جهانی موزه و میراث فرهنگی", IsClosed = false},
new MiladiEvent{ MiladiEventId= 14, Mounth = 5, DayInMounth = 31, Description = "روز جهانی بدون دخانیات", IsClosed = false},
new MiladiEvent{ MiladiEventId= 15, Mounth = 6, DayInMounth = 5, Description = "روز جهانی محیط زیست", IsClosed = false},
new MiladiEvent{ MiladiEventId= 16, Mounth = 6, DayInMounth = 10, Description = "روز جهانی صنایع دستی", IsClosed = false},
new MiladiEvent{ MiladiEventId= 17, Mounth = 6, DayInMounth = 12, Description = "روز جهانی مبارزه با کار کودکان", IsClosed = false},
new MiladiEvent{ MiladiEventId= 18, Mounth = 6, DayInMounth = 14, Description = "روز جهانی اهدای خون", IsClosed = false},
new MiladiEvent{ MiladiEventId= 19, Mounth = 6, DayInMounth = 17, Description = "روز جهانی بیابان زدایی", IsClosed = false},
new MiladiEvent{ MiladiEventId= 20, Mounth = 6, DayInMounth = 26, Description = "روز جهانی مبارزه با مواد مخدر", IsClosed = false},
new MiladiEvent{ MiladiEventId= 21, Mounth = 8, DayInMounth = 1, Description = "آغاز هفته جهانی شیردهی", IsClosed = false},
new MiladiEvent{ MiladiEventId= 22, Mounth = 8, DayInMounth = 13, Description = "روز جهانی چپ دست ها", IsClosed = false},
new MiladiEvent{ MiladiEventId= 23, Mounth = 8, DayInMounth = 19, Description = "روز جهانی عکاسی", IsClosed = false},
new MiladiEvent{ MiladiEventId= 24, Mounth = 9, DayInMounth = 10, Description = "روز جهانی پیشگیری از خودکشی", IsClosed = false},
new MiladiEvent{ MiladiEventId= 25, Mounth = 9, DayInMounth = 11, Description = "روز جهانی پیشگیری از خودکشی", IsClosed = false},
new MiladiEvent{ MiladiEventId= 26, Mounth = 9, DayInMounth = 13, Description = "روز گرامیداشت برنامه نویسان", IsClosed = false},
new MiladiEvent{ MiladiEventId= 27, Mounth = 9, DayInMounth = 21, Description = "روز جهانی صلح", IsClosed = false},
new MiladiEvent{ MiladiEventId= 28, Mounth = 9, DayInMounth = 27, Description = "روز جهانی جهانگردی", IsClosed = false},
new MiladiEvent{ MiladiEventId= 29, Mounth = 9, DayInMounth = 30, Description = "روز جهانی ناشنوایان", IsClosed = false},
new MiladiEvent{ MiladiEventId= 30, Mounth = 9, DayInMounth = 30, Description = "روز جهانی ترجمه و مترجم", IsClosed = false},
new MiladiEvent{ MiladiEventId= 31, Mounth = 10, DayInMounth = 1, Description = "روز جهانی سالمندان", IsClosed = false},
new MiladiEvent{ MiladiEventId= 32, Mounth = 10, DayInMounth = 5, Description = "روز جهانی معلم", IsClosed = false},
new MiladiEvent{ MiladiEventId= 33, Mounth = 10, DayInMounth = 9, Description = "روز جهانی پست", IsClosed = false},
new MiladiEvent{ MiladiEventId= 34, Mounth = 10, DayInMounth = 10, Description = "روز جهانی مبارزه با حکم اعدام", IsClosed = false},
new MiladiEvent{ MiladiEventId= 35, Mounth = 10, DayInMounth = 11, Description = "روز جهانی دختر", IsClosed = false},
new MiladiEvent{ MiladiEventId= 36, Mounth = 10, DayInMounth = 14, Description = "روز جهانی استاندارد", IsClosed = false},
new MiladiEvent{ MiladiEventId= 37, Mounth = 10, DayInMounth = 15, Description = "روز جهانی عصای سفید", IsClosed = false},
new MiladiEvent{ MiladiEventId= 38, Mounth = 10, DayInMounth = 16, Description = "روز جهانی غذا", IsClosed = false},
new MiladiEvent{ MiladiEventId= 39, Mounth = 10, DayInMounth = 17, Description = "روز جهانی ریشه کنی فقر", IsClosed = false},
new MiladiEvent{ MiladiEventId= 40, Mounth = 11, DayInMounth = 14, Description = "روز جهانی دیابت", IsClosed = false},
new MiladiEvent{ MiladiEventId= 41, Mounth = 11, DayInMounth = 18, Description = "روز جهانی فلسفه", IsClosed = false},
new MiladiEvent{ MiladiEventId= 42, Mounth = 11, DayInMounth = 19, Description = "روز جهانی آقایان", IsClosed = false},
new MiladiEvent{ MiladiEventId= 43, Mounth = 11, DayInMounth = 20, Description = "روز جهانی کودک", IsClosed = false},
new MiladiEvent{ MiladiEventId= 44, Mounth = 11, DayInMounth = 25, Description = "روز جهانی مبارزه با خشونت علیه زنان", IsClosed = false},
new MiladiEvent{ MiladiEventId= 45, Mounth = 12, DayInMounth = 1, Description = "روز جهانی ایدز", IsClosed = false},
new MiladiEvent{ MiladiEventId= 46, Mounth = 12, DayInMounth = 3, Description = "روز جهانی معلولان", IsClosed = false},
new MiladiEvent{ MiladiEventId= 47, Mounth = 12, DayInMounth = 11, Description = "روز جهانی کوه نوردی", IsClosed = false},
new MiladiEvent{ MiladiEventId= 48, Mounth = 12, DayInMounth = 25, Description = "جشن کریسمس", IsClosed = false}

            };

            return lstMiladiEvents;
        }
        public static List<HijriEvent> GetHijriEvents()
        {

            List<HijriEvent> lstHijriEvents = new List<HijriEvent>()
            {
                new HijriEvent{ HijriEventId= 1, Mounth = 1, DayInMounth = 9, Description = "تاسوعای حسینی", IsClosed = true},
new HijriEvent{ HijriEventId= 2, Mounth = 1, DayInMounth = 10, Description = "عاشورای حسینی", IsClosed = true},
new HijriEvent{ HijriEventId= 3, Mounth = 1, DayInMounth = 12, Description = "شهادت امام زین العابدین علیه السلام", IsClosed = false},
new HijriEvent{ HijriEventId= 4, Mounth = 2, DayInMounth = 20, Description = "اربعین حسینی", IsClosed = true},
new HijriEvent{ HijriEventId= 5, Mounth = 2, DayInMounth = 28, Description = "رحلت رسول اکرم؛شهادت امام حسن مجتبی علیه السلام", IsClosed = true},
new HijriEvent{ HijriEventId= 6, Mounth = 2, DayInMounth = 30, Description = "شهادت امام رضا علیه السلام", IsClosed = true},
new HijriEvent{ HijriEventId= 7, Mounth = 3, DayInMounth = 1, Description = "هجرت پیامبر اکرم از مکه به مدینه", IsClosed = false},
new HijriEvent{ HijriEventId= 8, Mounth = 3, DayInMounth = 8, Description = "شهادت امام حسن عسکری علیه السلام", IsClosed = true},
new HijriEvent{ HijriEventId= 9, Mounth = 3, DayInMounth = 12, Description = "میلاد رسول اکرم به روایت اهل سنت", IsClosed = false},
new HijriEvent{ HijriEventId= 10, Mounth = 3, DayInMounth = 17, Description = "میلاد رسول اکرم و امام جعفر صادق علیه السلام", IsClosed = true},
new HijriEvent{ HijriEventId= 11, Mounth = 4, DayInMounth = 8, Description = "ولادت امام حسن عسکری علیه السلام", IsClosed = false},
new HijriEvent{ HijriEventId= 12, Mounth = 4, DayInMounth = 10, Description = "وفات حضرت معصومه سلام الله علیها", IsClosed = false},
new HijriEvent{ HijriEventId= 13, Mounth = 5, DayInMounth = 5, Description = "ولادت حضرت زینب سلام الله علیها و روز پرستار و بهورز", IsClosed = false},
new HijriEvent{ HijriEventId= 14, Mounth = 6, DayInMounth = 3, Description = "شهادت حضرت فاطمه زهرا سلام الله علیها", IsClosed = true},
new HijriEvent{ HijriEventId= 15, Mounth = 6, DayInMounth = 20, Description = "ولادت حضرت فاطمه زهرا سلام الله علیها و روز مادر", IsClosed = false},
new HijriEvent{ HijriEventId= 16, Mounth = 7, DayInMounth = 1, Description = "ولادت امام محمد باقر علیه السلام", IsClosed = false},
new HijriEvent{ HijriEventId= 17, Mounth = 7, DayInMounth = 3, Description = "شهادت امام علی النقی الهادی علیه السلام", IsClosed = false},
new HijriEvent{ HijriEventId= 18, Mounth = 7, DayInMounth = 10, Description = "ولادت امام محمد تقی علیه السلام", IsClosed = false},
new HijriEvent{ HijriEventId= 19, Mounth = 7, DayInMounth = 13, Description = "ولادت امام علی علیه السلام و روز پدر", IsClosed = true},
new HijriEvent{ HijriEventId= 20, Mounth = 7, DayInMounth = 15, Description = "وفات حضرت زینب سلام الله علیها", IsClosed = false},
new HijriEvent{ HijriEventId= 21, Mounth = 7, DayInMounth = 25, Description = "شهادت امام موسی کاظم علیه السلام", IsClosed = false},
new HijriEvent{ HijriEventId= 22, Mounth = 7, DayInMounth = 27, Description = "مبعث رسول اکرم (ص)", IsClosed = true},
new HijriEvent{ HijriEventId= 23, Mounth = 8, DayInMounth = 3, Description = "ولادت سالار شهیدان، امام حسین علیه السلام و روز پاسدار ", IsClosed = false},
new HijriEvent{ HijriEventId= 24, Mounth = 8, DayInMounth = 4, Description = "ولادت ابوالفضل العباس علیه السلام و روز جانباز ", IsClosed = false},
new HijriEvent{ HijriEventId= 25, Mounth = 8, DayInMounth = 5, Description = "ولادت امام زین العابدین علیه السلام", IsClosed = false},
new HijriEvent{ HijriEventId= 26, Mounth = 8, DayInMounth = 11, Description = "ولادت علی اکبر علیه السلام و روز جوان", IsClosed = false},
new HijriEvent{ HijriEventId= 27, Mounth = 8, DayInMounth = 15, Description = "ولادت حضرت قائم عجل الله تعالی فرجه و جشن نیمه شعبان", IsClosed = true},
new HijriEvent{ HijriEventId= 28, Mounth = 9, DayInMounth = 15, Description = "ولادت امام حسن مجتبی علیه السلام", IsClosed = false},
new HijriEvent{ HijriEventId= 29, Mounth = 9, DayInMounth = 18, Description = "شب قدر", IsClosed = false},
new HijriEvent{ HijriEventId= 30, Mounth = 9, DayInMounth = 19, Description = "ضربت خوردن حضرت علی علیه السلام", IsClosed = false},
new HijriEvent{ HijriEventId= 31, Mounth = 9, DayInMounth = 21, Description = "شهادت حضرت علی علیه السلام", IsClosed = true},
new HijriEvent{ HijriEventId= 32, Mounth = 9, DayInMounth = 22, Description = "شب قدر", IsClosed = false},
new HijriEvent{ HijriEventId= 33, Mounth = 10, DayInMounth = 1, Description = "عید سعید فطر", IsClosed = true},
new HijriEvent{ HijriEventId= 34, Mounth = 10, DayInMounth = 2, Description = "تعطیل به مناسبت عید سعید فطر", IsClosed = true},
new HijriEvent{ HijriEventId= 35, Mounth = 10, DayInMounth = 25, Description = "شهادت امام جعفر صادق علیه السلام", IsClosed = true},
new HijriEvent{ HijriEventId= 36, Mounth = 11, DayInMounth = 30, Description = "شهادت امام محمد تقی علیه السلام", IsClosed = false},
new HijriEvent{ HijriEventId= 37, Mounth = 12, DayInMounth = 7, Description = "شهادت امام محمد باقر علیه السلام", IsClosed = false},
new HijriEvent{ HijriEventId= 38, Mounth = 12, DayInMounth = 10, Description = "عید سعید قربان", IsClosed = true},
new HijriEvent{ HijriEventId= 40, Mounth = 12, DayInMounth = 15, Description = "ولادت امام علی النقی الهادی علیه السلام", IsClosed = false},
new HijriEvent{ HijriEventId= 41, Mounth = 12, DayInMounth = 18, Description = "عید سعید غدیر خم", IsClosed = true},
new HijriEvent{ HijriEventId= 42, Mounth = 12, DayInMounth = 18, Description = "ولادت امام موسی کاظم علیه السلام", IsClosed = false},

            };

            return lstHijriEvents;
        }
        public static string ToShamsi(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();
            try
            {
                return pc.GetYear(value) + "/" + pc.GetMonth(value).ToString("00") + "/" +
                        pc.GetDayOfMonth(value).ToString("00");
            }
            catch (Exception)
            {
                return "0000/00/00";
            }

        }
        public static string ToShamsiYear(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();

            try
            {
                return pc.GetYear(value).ToString();
            }
            catch (Exception)
            {
                return "0000";

            }

        }
        public static string ToShamsiTime(this DateTime value)
        {
            string t = "";
            int hour = value.Hour;

            if (value.Hour <= 12)
            {
                t = "قبل از ظهر";
            }

            if (value.Hour >= 12)
            {
                t = "بعد از ظهر";

                if (value.Hour != 12)
                {
                    hour = value.Hour - 12;
                }

            }

            return $"{hour}:{value.Minute} {t}";
        }
        public static string ToShamsiShortPersian(this DateTime value)
        {
            try
            {
                return $"{value.ToShamsiDayName()} {value.ToShamsiDay()} {DateTime.Now.AddHours(48).ToShamsiMonthPersian()}";
            }
            catch (Exception)
            {
                return "";

            }


        }
        public static string ToHijriMounthString(this DateTime value)
        {
            HijriCalendar hc = new HijriCalendar();
            int month = hc.GetMonth(value);
            string stringMonth = "";

            switch (month)
            {
                case 1:
                    stringMonth = "محرم";
                    break;

                case 2:
                    stringMonth = "صفر";
                    break;

                case 3:
                    stringMonth = "ربیع الاول";
                    break;

                case 4:
                    stringMonth = "ربیع الثانی";
                    break;

                case 5:
                    stringMonth = "جمادی الاول";
                    break;

                case 6:
                    stringMonth = "جمادی الثانیه";
                    break;

                case 7:
                    stringMonth = "رجب";
                    break;

                case 8:
                    stringMonth = "شعبان";
                    break;

                case 9:
                    stringMonth = "رمضان";
                    break;

                case 10:
                    stringMonth = "شوال";
                    break;

                case 11:
                    stringMonth = "ذوالقعده";
                    break;

                case 12:
                    stringMonth = "ذوالحجه";
                    break;

                default:
                    stringMonth = "";
                    break;
            }

            return stringMonth;
        }
        public static string ToShamsiMonthPersian(this DateTime value)
        {
            try
            {
                PersianCalendar pc = new PersianCalendar();
                int mount = pc.GetMonth(value);
                string persianMount = "";
                switch (mount)
                {
                    case 1:
                        persianMount = "فروردین";
                        break;
                    case 2:
                        persianMount = "اردیبهشت";
                        break;
                    case 3:
                        persianMount = "خرداد";
                        break;
                    case 4:
                        persianMount = "تیر";
                        break;
                    case 5:
                        persianMount = "مرداد";
                        break;
                    case 6:
                        persianMount = "شهریور";
                        break;
                    case 7:
                        persianMount = "مهر";
                        break;
                    case 8:
                        persianMount = "آبان";
                        break;
                    case 9:
                        persianMount = "آذر";
                        break;
                    case 10:
                        persianMount = "دی";
                        break;
                    case 11:
                        persianMount = "بهمن";
                        break;
                    case 12:
                        persianMount = "اسفند";
                        break;
                    default:
                        persianMount = "ماه نا معلوم";
                        break;
                }

                return persianMount;
            }
            catch (Exception)
            {
                return "";

            }

        }
        public static int ToHijriDay(this DateTime value)
        {
            HijriCalendar hc = new HijriCalendar();
            return hc.GetDayOfMonth(value);
        }
        public static int ToShamsiDay(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetDayOfMonth(value);
        }
        public static int ToHijriMonth(this DateTime value)
        {
            HijriCalendar hc = new HijriCalendar();
            return hc.GetMonth(value);
        }
        public static int ToShamsiMonth(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetMonth(value);
        }
        public static string ToShamsiLong(this DateTime value)
        {
            try
            {
                PersianCalendar pc = new PersianCalendar();
                string year = pc.GetYear(value).ToString();
                string day = pc.GetDayOfMonth(value).ToString("00");
                string month = pc.GetMonth(value).ToString();

                switch (month)
                {
                    case "1":
                        month = PersianMonths.فروردین;
                        break;

                    case "2":
                        month = PersianMonths.اردیبهشت;
                        break;

                    case "3":
                        month = PersianMonths.خرداد;
                        break;

                    case "4":
                        month = PersianMonths.تیر;
                        break;

                    case "5":
                        month = PersianMonths.مرداد;
                        break;

                    case "6":
                        month = PersianMonths.شهریور;
                        break;

                    case "7":
                        month = PersianMonths.مهر;
                        break;

                    case "8":
                        month = PersianMonths.آبان;
                        break;

                    case "9":
                        month = PersianMonths.آذر;
                        break;

                    case "10":
                        month = PersianMonths.دی;
                        break;

                    case "11":
                        month = PersianMonths.بهمن;
                        break;

                    case "12":
                        month = PersianMonths.اسفند;
                        break;

                    default:
                        break;
                }

                return $"{day} {month} {year}";
            }
            catch (Exception)
            {
                return "0000/00/00";
                throw;
            }

        }
        public static string ToShamsiDayName(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();
            string year = pc.GetYear(value).ToString();
            string day = pc.GetDayOfMonth(value).ToString("00");
            string month = pc.GetMonth(value).ToString();
            var dayOfWeek = pc.GetDayOfWeek(value);
            string dayName = "";


            switch (dayOfWeek)
            {
                case DayOfWeek.Sunday:
                    dayName = "یک شنبه";
                    break;

                case DayOfWeek.Monday:
                    dayName = "دوشنبه";
                    break;

                case DayOfWeek.Tuesday:
                    dayName = "سه شنبه";
                    break;

                case DayOfWeek.Wednesday:
                    dayName = "چهارشنبه";
                    break;

                case DayOfWeek.Thursday:
                    dayName = "پنجشنبه";
                    break;

                case DayOfWeek.Friday:
                    dayName = "جمعه";
                    break;

                case DayOfWeek.Saturday:
                    dayName = "شنبه";
                    break;

                default:
                    break;
            }

            return $"{dayName}";
        }
        public static string ToShamsiLongExtra(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();
            string year = pc.GetYear(value).ToString();
            string day = pc.GetDayOfMonth(value).ToString("00");
            string month = pc.GetMonth(value).ToString();
            var dayOfWeek = pc.GetDayOfWeek(value);
            string dayName = "";
            switch (month)
            {
                case "1":
                    month = PersianMonths.فروردین;
                    break;

                case "2":
                    month = PersianMonths.اردیبهشت;
                    break;

                case "3":
                    month = PersianMonths.خرداد;
                    break;

                case "4":
                    month = PersianMonths.تیر;
                    break;

                case "5":
                    month = PersianMonths.مرداد;
                    break;

                case "6":
                    month = PersianMonths.شهریور;
                    break;

                case "7":
                    month = PersianMonths.مهر;
                    break;

                case "8":
                    month = PersianMonths.آبان;
                    break;

                case "9":
                    month = PersianMonths.آذر;
                    break;

                case "10":
                    month = PersianMonths.دی;
                    break;

                case "11":
                    month = PersianMonths.بهمن;
                    break;

                case "12":
                    month = PersianMonths.اسفند;
                    break;

                default:
                    break;
            }

            switch (dayOfWeek)
            {
                case DayOfWeek.Sunday:
                    dayName = "یک شنبه";
                    break;

                case DayOfWeek.Monday:
                    dayName = "دوشنبه";
                    break;

                case DayOfWeek.Tuesday:
                    dayName = "سه شنبه";
                    break;

                case DayOfWeek.Wednesday:
                    dayName = "چهارشنبه";
                    break;

                case DayOfWeek.Thursday:
                    dayName = "پنجشنبه";
                    break;

                case DayOfWeek.Friday:
                    dayName = "جمعه";
                    break;

                case DayOfWeek.Saturday:
                    dayName = "شنبه";
                    break;

                default:
                    break;
            }

            return $"{dayName} {day} {month} {year}";
        }
        public static string ToHijriLong(this DateTime value)
        {
            HijriCalendar hc = new HijriCalendar();
            string year = hc.GetYear(value).ToString();
            string day = hc.GetDayOfMonth(value).ToString("00");
            string month = hc.GetMonth(value).ToString();
            var dayOfWeek = hc.GetDayOfWeek(value);
            string dayName = "";
            switch (month)
            {
                case "1":
                    month = "محرم";
                    break;

                case "2":
                    month = "صفر";
                    break;

                case "3":
                    month = "ربیع الاول";
                    break;

                case "4":
                    month = "ربیع الثانی";
                    break;

                case "5":
                    month = "جمادی الاول";
                    break;

                case "6":
                    month = "جمادی الثانیه";
                    break;

                case "7":
                    month = "رجب";
                    break;

                case "8":
                    month = "شعبان";
                    break;

                case "9":
                    month = "رمضان";
                    break;

                case "10":
                    month = "شوال";
                    break;

                case "11":
                    month = "ذوالقعده";
                    break;

                case "12":
                    month = "ذوالحجه";
                    break;

                default:
                    break;
            }

            switch (dayOfWeek)
            {
                case DayOfWeek.Sunday:
                    dayName = "یک شنبه";
                    break;

                case DayOfWeek.Monday:
                    dayName = "دوشنبه";
                    break;

                case DayOfWeek.Tuesday:
                    dayName = "سه شنبه";
                    break;

                case DayOfWeek.Wednesday:
                    dayName = "چهارشنبه";
                    break;

                case DayOfWeek.Thursday:
                    dayName = "پنجشنبه";
                    break;

                case DayOfWeek.Friday:
                    dayName = "جمعه";
                    break;

                case DayOfWeek.Saturday:
                    dayName = "شنبه";
                    break;

                default:
                    break;
            }

            return $"{day} {month} {year}";
        }
        public static string ToHijriLongExtra(this DateTime value)
        {
            HijriCalendar hc = new HijriCalendar();
            string year = hc.GetYear(value).ToString();
            string day = hc.GetDayOfMonth(value).ToString("00");
            string month = hc.GetMonth(value).ToString();
            var dayOfWeek = hc.GetDayOfWeek(value);
            string dayName = "";
            switch (month)
            {
                case "1":
                    month = "محرم";
                    break;

                case "2":
                    month = "صفر";
                    break;

                case "3":
                    month = "ربیع الاول";
                    break;

                case "4":
                    month = "ربیع الثانی";
                    break;

                case "5":
                    month = "جمادی الاول";
                    break;

                case "6":
                    month = "جمادی الثانیه";
                    break;

                case "7":
                    month = "رجب";
                    break;

                case "8":
                    month = "شعبان";
                    break;

                case "9":
                    month = "رمضان";
                    break;

                case "10":
                    month = "شوال";
                    break;

                case "11":
                    month = "ذوالقعده";
                    break;

                case "12":
                    month = "ذوالحجه";
                    break;

                default:
                    break;
            }

            switch (dayOfWeek)
            {
                case DayOfWeek.Sunday:
                    dayName = "یک شنبه";
                    break;

                case DayOfWeek.Monday:
                    dayName = "دوشنبه";
                    break;

                case DayOfWeek.Tuesday:
                    dayName = "سه شنبه";
                    break;

                case DayOfWeek.Wednesday:
                    dayName = "چهارشنبه";
                    break;

                case DayOfWeek.Thursday:
                    dayName = "پنجشنبه";
                    break;

                case DayOfWeek.Friday:
                    dayName = "جمعه";
                    break;

                case DayOfWeek.Saturday:
                    dayName = "شنبه";
                    break;

                default:
                    break;
            }

            return $"{dayName} {day} {month} {year}";
        }
        public static string ToShamsiDiff(this DateTime value)
        {
            TimeSpan span = (DateTime.Now - value);

            switch (span.Days)
            {
                case 1:
                    return "دیروز";

                case 2:
                    return "دو روز پیش";

                case 3:
                    return "سه روز پیش";

                case 4:
                    return "چهار روز پیش";

                case 5:
                    return "پنج روز پیش";

                case 7:
                    return "یک هفته پیش";

                case 14:
                    return "دو هفته هفته پیش";

                case 21:
                    return "سه هفته هفته پیش";

                case 28:
                    return "چهار هفته هفته پیش";

                case 365:
                    return "چهار هفته هفته پیش";

                default:
                    break;
            }

            if (span.Days < 1 && span.Hours < 1 && span.Minutes < 1)
            {
                return "لحظاتی پیش";
            }
            if (span.Days < 1 && span.Hours < 1 && span.Minutes > 1)
            {
                return "دقایقی پیش";
            }
            if (span.Days < 1 && span.Hours > 1)
            {
                return "ساعاتی پیش";
            }
            if (span.Days > 2 && span.Days < 7)
            {
                return "چند روز پیش";
            }
            if (span.Days > 7 && span.Days < 14)
            {
                return "بیشتر از یک هفته پیش";
            }
            if (span.Days > 14 && span.Days < 21)
            {
                return "بیشتر از دوه هفته پیش";
            }
            if (span.Days > 21 && span.Days < 28)
            {
                return "بیشتر از سه هفته پیش";
            }
            if (span.Days > 28 && span.Days < 30)
            {
                return "بیشتر از چهار هفته پیش";
            }
            if (span.Days >= 30 && span.Days <= 31)
            {
                return "یک ماه هفته پیش";
            }
            if (span.Days > 31 && span.Days <= 60)
            {
                return "بیشتر از یک ماه پیش";
            }
            if (span.Days > 60 && span.Days < 365)
            {
                return "چند ماه پیش";
            }
            if (span.Days > 365)
            {
                return "بیشتر از یک سال پیش";
            }

            return null;
        }
        public static DateTime ToMiladi(this string persianDate)
        {

            try
            {
                string[] shamsiDate = persianDate.Split('/');
                return new DateTime(
                    int.Parse(shamsiDate[0]),
                    int.Parse(shamsiDate[1]),
                    int.Parse(shamsiDate[2]),
                    new PersianCalendar()
                    );
            }

            catch (Exception)
            {
                return DateTime.MinValue;
            }


        }
        public static string ToMiladiDayString(this DateTime value)
        {
            var mounth = value.Month;

            string result = "";

            switch (value.DayOfWeek)
            {
                case DayOfWeek.Saturday:
                    result = "شنبه";
                    break;

                case DayOfWeek.Sunday:
                    result = "یکشنبه";
                    break;

                case DayOfWeek.Monday:
                    result = "دوشنبه";
                    break;

                case DayOfWeek.Tuesday:
                    result = "سه شنبه";
                    break;

                case DayOfWeek.Wednesday:
                    result = "چهارشنبه";
                    break;

                case DayOfWeek.Thursday:
                    result = "پنجشنبه";
                    break;
                case DayOfWeek.Friday:
                    result = "جمعه";
                    break;
                default:
                    result = "";
                    break;
            }

            return result;
        }
        public static string ToMiladiMounthString(this DateTime value)
        {
            var mounth = value.Month;

            string result = "";

            switch (value.Month)
            {
                case 1:
                    result = "ژانویه";
                    break;

                case 2:
                    result = "فوریه";
                    break;

                case 3:
                    result = "مارس";
                    break;

                case 4:
                    result = "آوریل";
                    break;

                case 5:
                    result = "مه";
                    break;

                case 6:
                    result = "ژوئن";
                    break;
                case 7:
                    result = "ژوئیه";
                    break;
                case 8:
                    result = "اوت";
                    break;
                case 9:
                    result = "سپتامبر";
                    break;
                case 10:
                    result = "اکتبر";
                    break;
                case 11:
                    result = "نوامبر";
                    break;
                case 12:
                    result = "دسامبر";
                    break;
                default:
                    result = "";
                    break;
            }

            return result;
        }

        public static string ConvertTimeToNumber(string time) { if (!TimeSpan.TryParse(time, out TimeSpan duration)) throw new ArgumentException("فرمت زمان باید به صورت 00:00:00 باشد."); int hours = duration.Hours; int minutes = duration.Minutes; if (hours > 0 && minutes > 0) return $"{hours} ساعت و {minutes} دقیقه"; if (hours > 0) return $"{hours} ساعت"; if (minutes > 0) return $"{minutes} دقیقه"; return "0 دقیقه"; }


        public static string ConvertTimeToWordsWithoutSeconds(string time)
        {
            if (!TimeSpan.TryParse(time, out TimeSpan duration)) throw new ArgumentException("فرمت زمان باید به صورت 00:00:00 باشد."); int hours = duration.Hours; int minutes = duration.Minutes; string result = ""; if (hours > 0) result += $"{NumberToPersianWords(hours)} ساعت"; if (minutes > 0) { if (!string.IsNullOrEmpty(result)) result += " و "; result += $"{NumberToPersianWords(minutes)} دقیقه"; }  if (string.IsNullOrEmpty(result)) result = "صفر دقیقه"; return result; 
        }


        public static string ConvertTimeToWords(string time)
        {
            if (!TimeSpan.TryParse(time, out TimeSpan duration)) throw new ArgumentException("فرمت زمان باید به صورت 00:00:00 باشد."); string hours = NumberToPersianWords((int)duration.TotalHours); string minutes = NumberToPersianWords(duration.Minutes); string seconds = NumberToPersianWords(duration.Seconds); return $"{hours} ساعت و {minutes} دقیقه و {seconds} ثانیه";
        }
        private static string NumberToPersianWords(int number) { string[] ones = { "صفر", "یک", "دو", "سه", "چهار", "پنج", "شش", "هفت", "هشت", "نه", "ده", "یازده", "دوازده", "سیزده", "چهارده", "پانزده", "شانزده", "هفده", "هجده", "نوزده" }; string[] tens = { "", "", "بیست", "سی", "چهل", "پنجاه", "شصت", "هفتاد", "هشتاد", "نود" }; string[] hundreds = { "", "صد", "دویست", "سیصد", "چهارصد", "پانصد", "ششصد", "هفتصد", "هشتصد", "نهصد" }; if (number < 20) return ones[number]; if (number < 100) { int ten = number / 10; int one = number % 10; return one == 0 ? tens[ten] : $"{tens[ten]} و {ones[one]}"; } if (number < 1000) { int hundred = number / 100; int remainder = number % 100; return remainder == 0 ? hundreds[hundred] : $"{hundreds[hundred]} و {NumberToPersianWords(remainder)}"; } return number.ToString(); }


    }
}
