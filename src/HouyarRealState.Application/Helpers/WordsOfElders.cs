namespace HouyarRealState.Application.Helpers
{
    public class WordsOfElders
    {
        public string Words { get; set; }
        public string Speaker { get; set; }
    }
    public class Hafez
    {
        public int Id { get; set; }

        public int BeytNo { get; set; }
        public int GhazalNo { get; set; }

        public string Mesra1 { get; set; }
        public string Mesra2 { get; set; }
    }
    public static class WordsOfEldersTools
    {
        public static List<Hafez> GhazalHafez()
        {
            List<Hafez> hafezGhazal = new List<Hafez>()
            {

new Hafez{ Id= 1, BeytNo = 1, GhazalNo = 1, Mesra1 = "الا يا ايها الساقی ادر کاسا و ناولها", Mesra2 = "که عشق آسان نمود اول ولی افتاد مشکل‌ها",},
new Hafez{ Id= 2, BeytNo = 2, GhazalNo = 1, Mesra1 = "به بوی نافه‌ای کاخر صبا زان طره بگشايد", Mesra2 = "ز تاب جعد مشکينش چه خون افتاد در دل‌ها",},
new Hafez{ Id= 3, BeytNo = 3, GhazalNo = 1, Mesra1 = "مرا در منزل جانان چه امن عيش چون هر دم", Mesra2 = "جرس فرياد می‌دارد که بربنديد محمل‌ها",},
new Hafez{ Id= 4, BeytNo = 4, GhazalNo = 1, Mesra1 = "به می سجاده رنگين کن گرت پير مغان گويد", Mesra2 = "که سالک بی‌خبر نبود ز راه و رسم منزل‌ها",},
new Hafez{ Id= 5, BeytNo = 5, GhazalNo = 1, Mesra1 = "شب تاريک و بيم موج و گردابی چنين هايل", Mesra2 = "کجا دانند حال ما سبکباران ساحل‌ها",},
new Hafez{ Id= 6, BeytNo = 6, GhazalNo = 1, Mesra1 = "همه کارم ز خود کامی به بدنامی کشيد آخر", Mesra2 = "نهان کی ماند آن رازی کز او سازند محفل‌ها",},
new Hafez{ Id= 7, BeytNo = 7, GhazalNo = 1, Mesra1 = "حضوری گر همی‌خواهی از او غايب مشو حافظ", Mesra2 = "متی ما تلق من تهوی دع الدنيا و اهملها",},
new Hafez{ Id= 8, BeytNo = 1, GhazalNo = 2, Mesra1 = "صلاح کار کجا و من خراب کجا", Mesra2 = "ببين تفاوت ره کز کجاست تا به کجا",},
new Hafez{ Id= 9, BeytNo = 2, GhazalNo = 2, Mesra1 = "دلم ز صومعه بگرفت و خرقه سالوس", Mesra2 = "کجاست دير مغان و شراب ناب کجا",},
new Hafez{ Id= 10, BeytNo = 3, GhazalNo = 2, Mesra1 = "چه نسبت است به رندی صلاح و تقوا را", Mesra2 = "سماع وعظ کجا نغمه رباب کجا",},
new Hafez{ Id= 11, BeytNo = 4, GhazalNo = 2, Mesra1 = "ز روی دوست دل دشمنان چه دريابد", Mesra2 = "چراغ مرده کجا شمع آفتاب کجا",},
new Hafez{ Id= 12, BeytNo = 5, GhazalNo = 2, Mesra1 = "چو کحل بينش ما خاک آستان شماست", Mesra2 = "کجا رويم بفرما از اين جناب کجا",},
new Hafez{ Id= 13, BeytNo = 6, GhazalNo = 2, Mesra1 = "مبين به سيب زنخدان که چاه در راه است", Mesra2 = "کجا همی‌روی ای دل بدين شتاب کجا",},
new Hafez{ Id= 14, BeytNo = 7, GhazalNo = 2, Mesra1 = "بشد که ياد خوشش باد روزگار وصال", Mesra2 = "خود آن کرشمه کجا رفت و آن عتاب کجا",},
new Hafez{ Id= 15, BeytNo = 8, GhazalNo = 2, Mesra1 = "قرار و خواب ز حافظ طمع مدار ای دوست", Mesra2 = "قرار چيست صبوری کدام و خواب کجا",},
new Hafez{ Id= 16, BeytNo = 1, GhazalNo = 3, Mesra1 = "اگر آن ترک شيرازی به دست آرد دل ما را", Mesra2 = "به خال هندويش بخشم سمرقند و بخارا را",},
new Hafez{ Id= 17, BeytNo = 2, GhazalNo = 3, Mesra1 = "بده ساقی می باقی که در جنت نخواهی يافت", Mesra2 = "کنار آب رکن آباد و گلگشت مصلا را",},
new Hafez{ Id= 18, BeytNo = 3, GhazalNo = 3, Mesra1 = "فغان کاين لوليان شوخ شيرين کار شهرآشوب", Mesra2 = "چنان بردند صبر از دل که ترکان خوان يغما را",},
new Hafez{ Id= 19, BeytNo = 4, GhazalNo = 3, Mesra1 = "ز عشق ناتمام ما جمال يار مستغنی است", Mesra2 = "به آب و رنگ و خال و خط چه حاجت روی زيبا را",},
new Hafez{ Id= 20, BeytNo = 5, GhazalNo = 3, Mesra1 = "من از آن حسن روزافزون که يوسف داشت دانستم", Mesra2 = "که عشق از پرده عصمت برون آرد زليخا را",},
new Hafez{ Id= 21, BeytNo = 6, GhazalNo = 3, Mesra1 = "اگر دشنام فرمايی و گر نفرين دعا گويم", Mesra2 = "جواب تلخ می‌زيبد لب لعل شکرخا را",},
new Hafez{ Id= 22, BeytNo = 7, GhazalNo = 3, Mesra1 = "نصيحت گوش کن جانا که از جان دوست‌تر دارند", Mesra2 = "جوانان سعادتمند پند پير دانا را",},
new Hafez{ Id= 23, BeytNo = 8, GhazalNo = 3, Mesra1 = "حديث از مطرب و می گو و راز دهر کمتر جو", Mesra2 = "که کس نگشود و نگشايد به حکمت اين معما را",},
new Hafez{ Id= 24, BeytNo = 9, GhazalNo = 3, Mesra1 = "غزل گفتی و در سفتی بيا و خوش بخوان حافظ", Mesra2 = "که بر نظم تو افشاند فلک عقد ثريا را",},
new Hafez{ Id= 25, BeytNo = 1, GhazalNo = 4, Mesra1 = "صبا به لطف بگو آن غزال رعنا را", Mesra2 = "که سر به کوه و بيابان تو داده‌ای ما را",},
new Hafez{ Id= 26, BeytNo = 2, GhazalNo = 4, Mesra1 = "شکرفروش که عمرش دراز باد چرا", Mesra2 = "تفقدی نکند طوطی شکرخا را",},
new Hafez{ Id= 27, BeytNo = 3, GhazalNo = 4, Mesra1 = "غرور حسنت اجازت مگر نداد ای گل", Mesra2 = "که پرسشی نکنی عندليب شيدا را",},
new Hafez{ Id= 28, BeytNo = 4, GhazalNo = 4, Mesra1 = "به خلق و لطف توان کرد صيد اهل نظر", Mesra2 = "به بند و دام نگيرند مرغ دانا را",},
new Hafez{ Id= 29, BeytNo = 5, GhazalNo = 4, Mesra1 = "ندانم از چه سبب رنگ آشنايی نيست", Mesra2 = "سهی قدان سيه چشم ماه سيما را",},
new Hafez{ Id= 30, BeytNo = 6, GhazalNo = 4, Mesra1 = "چو با حبيب نشينی و باده پيمايی", Mesra2 = "به ياد دار محبان بادپيما را",},
new Hafez{ Id= 31, BeytNo = 7, GhazalNo = 4, Mesra1 = "جز اين قدر نتوان گفت در جمال تو عيب", Mesra2 = "که وضع مهر و وفا نيست روی زيبا را",},
new Hafez{ Id= 32, BeytNo = 8, GhazalNo = 4, Mesra1 = "در آسمان نه عجب گر به گفته حافظ", Mesra2 = "سرود زهره به رقص آورد مسيحا را",},
new Hafez{ Id= 33, BeytNo = 1, GhazalNo = 5, Mesra1 = "دل می‌رود ز دستم صاحب دلان خدا را", Mesra2 = "دردا که راز پنهان خواهد شد آشکارا",},
new Hafez{ Id= 34, BeytNo = 2, GhazalNo = 5, Mesra1 = "کشتی شکستگانيم ای باد شرطه برخيز", Mesra2 = "باشد که بازبينيم ديدار آشنا را",},
new Hafez{ Id= 35, BeytNo = 3, GhazalNo = 5, Mesra1 = "ده روزه مهر گردون افسانه است و افسون", Mesra2 = "نيکی به جای ياران فرصت شمار يارا",},
new Hafez{ Id= 36, BeytNo = 4, GhazalNo = 5, Mesra1 = "در حلقه گل و مل خوش خواند دوش بلبل", Mesra2 = "هات الصبوح هبوا يا ايها السکارا",},
new Hafez{ Id= 37, BeytNo = 5, GhazalNo = 5, Mesra1 = "ای صاحب کرامت شکرانه سلامت", Mesra2 = "روزی تفقدی کن درويش بی‌نوا را",},
new Hafez{ Id= 38, BeytNo = 6, GhazalNo = 5, Mesra1 = "آسايش دو گيتی تفسير اين دو حرف است", Mesra2 = "با دوستان مروت با دشمنان مدارا",},
new Hafez{ Id= 39, BeytNo = 7, GhazalNo = 5, Mesra1 = "در کوی نيک نامی ما را گذر ندادند", Mesra2 = "گر تو نمی‌پسندی تغيير کن قضا را",},
new Hafez{ Id= 40, BeytNo = 8, GhazalNo = 5, Mesra1 = "آن تلخ وش که صوفی ام الخباثش خواند", Mesra2 = "اشهی لنا و احلی من قبله العذارا",},
new Hafez{ Id= 41, BeytNo = 9, GhazalNo = 5, Mesra1 = "هنگام تنگدستی در عيش کوش و مستی", Mesra2 = "کاين کيميای هستی قارون کند گدا را",},
new Hafez{ Id= 42, BeytNo = 10, GhazalNo = 5, Mesra1 = "سرکش مشو که چون شمع از غيرتت بسوزد", Mesra2 = "دلبر که در کف او موم است سنگ خارا",},
new Hafez{ Id= 43, BeytNo = 11, GhazalNo = 5, Mesra1 = "آيينه سکندر جام می است بنگر", Mesra2 = "تا بر تو عرضه دارد احوال ملک دارا",},
new Hafez{ Id= 44, BeytNo = 12, GhazalNo = 5, Mesra1 = "خوبان پارسی گو بخشندگان عمرند", Mesra2 = "ساقی بده بشارت رندان پارسا را",},
new Hafez{ Id= 45, BeytNo = 13, GhazalNo = 5, Mesra1 = "حافظ به خود نپوشيد اين خرقه می آلود", Mesra2 = "ای شيخ پاکدامن معذور دار ما را",},
new Hafez{ Id= 46, BeytNo = 1, GhazalNo = 6, Mesra1 = "به ملازمان سلطان که رساند اين دعا را", Mesra2 = "که به شکر پادشاهی ز نظر مران گدا را",},
new Hafez{ Id= 47, BeytNo = 2, GhazalNo = 6, Mesra1 = "ز رقيب ديوسيرت به خدای خود پناهم", Mesra2 = "مگر آن شهاب ثاقب مددی دهد خدا را",},
new Hafez{ Id= 48, BeytNo = 3, GhazalNo = 6, Mesra1 = "مژه سياهت ار کرد به خون ما اشارت", Mesra2 = "ز فريب او بينديش و غلط مکن نگارا",},
new Hafez{ Id= 49, BeytNo = 4, GhazalNo = 6, Mesra1 = "دل عالمی بسوزی چو عذار برفروزی", Mesra2 = "تو از اين چه سود داری که نمی‌کنی مدارا",},
new Hafez{ Id= 50, BeytNo = 5, GhazalNo = 6, Mesra1 = "همه شب در اين اميدم که نسيم صبحگاهی", Mesra2 = "به پيام آشنايان بنوازد آشنا را",},
new Hafez{ Id= 51, BeytNo = 6, GhazalNo = 6, Mesra1 = "چه قيامت است جانا که به عاشقان نمودی", Mesra2 = "دل و جان فدای رويت بنما عذار ما را",},
new Hafez{ Id= 52, BeytNo = 7, GhazalNo = 6, Mesra1 = "به خدا که جرعه‌ای ده تو به حافظ سحرخيز", Mesra2 = "که دعای صبحگاهی اثری کند شما را",},
new Hafez{ Id= 53, BeytNo = 1, GhazalNo = 7, Mesra1 = "صوفی بيا که آينه صافيست جام را", Mesra2 = "تا بنگری صفای می لعل فام را",},
new Hafez{ Id= 54, BeytNo = 2, GhazalNo = 7, Mesra1 = "راز درون پرده ز رندان مست پرس", Mesra2 = "کاين حال نيست زاهد عالی مقام را",},
new Hafez{ Id= 55, BeytNo = 3, GhazalNo = 7, Mesra1 = "عنقا شکار کس نشود دام بازچين", Mesra2 = "کان جا هميشه باد به دست است دام را",},
new Hafez{ Id= 56, BeytNo = 4, GhazalNo = 7, Mesra1 = "در بزم دور يک دو قدح درکش و برو", Mesra2 = "يعنی طمع مدار وصال دوام را",},
new Hafez{ Id= 57, BeytNo = 5, GhazalNo = 7, Mesra1 = "ای دل شباب رفت و نچيدی گلی ز عيش", Mesra2 = "پيرانه سر مکن هنری ننگ و نام را",},
new Hafez{ Id= 58, BeytNo = 6, GhazalNo = 7, Mesra1 = "در عيش نقد کوش که چون آبخور نماند", Mesra2 = "آدم بهشت روضه دارالسلام را",},
new Hafez{ Id= 59, BeytNo = 7, GhazalNo = 7, Mesra1 = "ما را بر آستان تو بس حق خدمت است", Mesra2 = "ای خواجه بازبين به ترحم غلام را",},
new Hafez{ Id= 60, BeytNo = 8, GhazalNo = 7, Mesra1 = "حافظ مريد جام می است ای صبا برو", Mesra2 = "وز بنده بندگی برسان شيخ جام را",},
new Hafez{ Id= 61, BeytNo = 1, GhazalNo = 8, Mesra1 = "ساقيا برخيز و درده جام را", Mesra2 = "خاک بر سر کن غم ايام را",},
new Hafez{ Id= 62, BeytNo = 2, GhazalNo = 8, Mesra1 = "ساغر می بر کفم نه تا ز بر", Mesra2 = "برکشم اين دلق ازرق فام را",},
new Hafez{ Id= 63, BeytNo = 3, GhazalNo = 8, Mesra1 = "گر چه بدناميست نزد عاقلان", Mesra2 = "ما نمی‌خواهيم ننگ و نام را",},
new Hafez{ Id= 64, BeytNo = 4, GhazalNo = 8, Mesra1 = "باده درده چند از اين باد غرور", Mesra2 = "خاک بر سر نفس نافرجام را",},
new Hafez{ Id= 65, BeytNo = 5, GhazalNo = 8, Mesra1 = "دود آه سينه نالان من", Mesra2 = "سوخت اين افسردگان خام را",},
new Hafez{ Id= 66, BeytNo = 6, GhazalNo = 8, Mesra1 = "محرم راز دل شيدای خود", Mesra2 = "کس نمی‌بينم ز خاص و عام را",},
new Hafez{ Id= 67, BeytNo = 7, GhazalNo = 8, Mesra1 = "با دلارامی مرا خاطر خوش است", Mesra2 = "کز دلم يک باره برد آرام را",},
new Hafez{ Id= 68, BeytNo = 8, GhazalNo = 8, Mesra1 = "ننگرد ديگر به سرو اندر چمن", Mesra2 = "هر که ديد آن سرو سيم اندام را",},
new Hafez{ Id= 69, BeytNo = 9, GhazalNo = 8, Mesra1 = "صبر کن حافظ به سختی روز و شب", Mesra2 = "عاقبت روزی بيابی کام را",},
new Hafez{ Id= 70, BeytNo = 1, GhazalNo = 9, Mesra1 = "رونق عهد شباب است دگر بستان را", Mesra2 = "می‌رسد مژده گل بلبل خوش الحان را",},
new Hafez{ Id= 71, BeytNo = 2, GhazalNo = 9, Mesra1 = "ای صبا گر به جوانان چمن بازرسی", Mesra2 = "خدمت ما برسان سرو و گل و ريحان را",},
new Hafez{ Id= 72, BeytNo = 3, GhazalNo = 9, Mesra1 = "گر چنين جلوه کند مغبچه باده فروش", Mesra2 = "خاکروب در ميخانه کنم مژگان را",},
new Hafez{ Id= 73, BeytNo = 4, GhazalNo = 9, Mesra1 = "ای که بر مه کشی از عنبر سارا چوگان", Mesra2 = "مضطرب حال مگردان من سرگردان را",},
new Hafez{ Id= 74, BeytNo = 5, GhazalNo = 9, Mesra1 = "ترسم اين قوم که بر دردکشان می‌خندند", Mesra2 = "در سر کار خرابات کنند ايمان را",},
new Hafez{ Id= 75, BeytNo = 6, GhazalNo = 9, Mesra1 = "يار مردان خدا باش که در کشتی نوح", Mesra2 = "هست خاکی که به آبی نخرد طوفان را",},
new Hafez{ Id= 76, BeytNo = 7, GhazalNo = 9, Mesra1 = "برو از خانه گردون به در و نان مطلب", Mesra2 = "کان سيه کاسه در آخر بکشد مهمان را",},
new Hafez{ Id= 77, BeytNo = 8, GhazalNo = 9, Mesra1 = "هر که را خوابگه آخر مشتی خاک است", Mesra2 = "گو چه حاجت که به افلاک کشی ايوان را",},
new Hafez{ Id= 78, BeytNo = 9, GhazalNo = 9, Mesra1 = "ماه کنعانی من مسند مصر آن تو شد", Mesra2 = "وقت آن است که بدرود کنی زندان را",},
new Hafez{ Id= 79, BeytNo = 10, GhazalNo = 9, Mesra1 = "حافظا می خور و رندی کن و خوش باش ولی", Mesra2 = "دام تزوير مکن چون دگران قرآن را",},
new Hafez{ Id= 80, BeytNo = 1, GhazalNo = 10, Mesra1 = "دوش از مسجد سوی ميخانه آمد پير ما", Mesra2 = "چيست ياران طريقت بعد از اين تدبير ما",},
new Hafez{ Id= 81, BeytNo = 2, GhazalNo = 10, Mesra1 = "ما مريدان روی سوی قبله چون آريم چون", Mesra2 = "روی سوی خانه خمار دارد پير ما",},
new Hafez{ Id= 82, BeytNo = 3, GhazalNo = 10, Mesra1 = "در خرابات طريقت ما به هم منزل شويم", Mesra2 = "کاين چنين رفته‌ست در عهد ازل تقدير ما",},
new Hafez{ Id= 83, BeytNo = 4, GhazalNo = 10, Mesra1 = "عقل اگر داند که دل دربند زلفش چون خوش است", Mesra2 = "عاقلان ديوانه گردند از پی زنجير ما",},
new Hafez{ Id= 84, BeytNo = 5, GhazalNo = 10, Mesra1 = "روی خوبت آيتی از لطف بر ما کشف کرد", Mesra2 = "زان زمان جز لطف و خوبی نيست در تفسير ما",},
new Hafez{ Id= 85, BeytNo = 6, GhazalNo = 10, Mesra1 = "با دل سنگينت آيا هيچ درگيرد شبی", Mesra2 = "آه آتشناک و سوز سينه شبگير ما",},
new Hafez{ Id= 86, BeytNo = 7, GhazalNo = 10, Mesra1 = "تير آه ما ز گردون بگذرد حافظ خموش", Mesra2 = "رحم کن بر جان خود پرهيز کن از تير ما",},
new Hafez{ Id= 87, BeytNo = 1, GhazalNo = 11, Mesra1 = "ساقی به نور باده برافروز جام ما", Mesra2 = "مطرب بگو که کار جهان شد به کام ما",},
new Hafez{ Id= 88, BeytNo = 2, GhazalNo = 11, Mesra1 = "ما در پياله عکس رخ يار ديده‌ايم", Mesra2 = "ای بی‌خبر ز لذت شرب مدام ما",},
new Hafez{ Id= 89, BeytNo = 3, GhazalNo = 11, Mesra1 = "هرگز نميرد آن که دلش زنده شد به عشق", Mesra2 = "ثبت است بر جريده عالم دوام ما",},
new Hafez{ Id= 90, BeytNo = 4, GhazalNo = 11, Mesra1 = "چندان بود کرشمه و ناز سهی قدان", Mesra2 = "کايد به جلوه سرو صنوبرخرام ما",},
new Hafez{ Id= 91, BeytNo = 5, GhazalNo = 11, Mesra1 = "ای باد اگر به گلشن احباب بگذری", Mesra2 = "زنهار عرضه ده بر جانان پيام ما",},
new Hafez{ Id= 92, BeytNo = 6, GhazalNo = 11, Mesra1 = "گو نام ما ز ياد به عمدا چه می‌بری", Mesra2 = "خود آيد آن که ياد نياری ز نام ما",},
new Hafez{ Id= 93, BeytNo = 7, GhazalNo = 11, Mesra1 = "مستی به چشم شاهد دلبند ما خوش است", Mesra2 = "زان رو سپرده‌اند به مستی زمام ما",},
new Hafez{ Id= 94, BeytNo = 8, GhazalNo = 11, Mesra1 = "ترسم که صرفه‌ای نبرد روز بازخواست", Mesra2 = "نان حلال شيخ ز آب حرام ما",},
new Hafez{ Id= 95, BeytNo = 9, GhazalNo = 11, Mesra1 = "حافظ ز ديده دانه اشکی همی‌فشان", Mesra2 = "باشد که مرغ وصل کند قصد دام ما",},
new Hafez{ Id= 96, BeytNo = 10, GhazalNo = 11, Mesra1 = "دريای اخضر فلک و کشتی هلال", Mesra2 = "هستند غرق نعمت حاجی قوام ما",},
new Hafez{ Id= 97, BeytNo = 1, GhazalNo = 12, Mesra1 = "ای فروغ ماه حسن از روی رخشان شما", Mesra2 = "آب روی خوبی از چاه زنخدان شما",},
new Hafez{ Id= 98, BeytNo = 2, GhazalNo = 12, Mesra1 = "عزم ديدار تو دارد جان بر لب آمده", Mesra2 = "بازگردد يا برآيد چيست فرمان شما",},
new Hafez{ Id= 99, BeytNo = 3, GhazalNo = 12, Mesra1 = "کس به دور نرگست طرفی نبست از عافيت", Mesra2 = "به که نفروشند مستوری به مستان شما",},
new Hafez{ Id= 100, BeytNo = 4, GhazalNo = 12, Mesra1 = "بخت خواب آلود ما بيدار خواهد شد مگر", Mesra2 = "زان که زد بر ديده آبی روی رخشان شما",},
new Hafez{ Id= 101, BeytNo = 5, GhazalNo = 12, Mesra1 = "با صبا همراه بفرست از رخت گلدسته‌ای", Mesra2 = "بو که بويی بشنويم از خاک بستان شما",},
new Hafez{ Id= 102, BeytNo = 6, GhazalNo = 12, Mesra1 = "عمرتان باد و مراد ای ساقيان بزم جم", Mesra2 = "گر چه جام ما نشد پرمی به دوران شما",},
new Hafez{ Id= 103, BeytNo = 7, GhazalNo = 12, Mesra1 = "دل خرابی می‌کند دلدار را آگه کنيد", Mesra2 = "زينهار ای دوستان جان من و جان شما",},
new Hafez{ Id= 104, BeytNo = 8, GhazalNo = 12, Mesra1 = "کی دهد دست اين غرض يا رب که همدستان شوند", Mesra2 = "خاطر مجموع ما زلف پريشان شما",},
new Hafez{ Id= 105, BeytNo = 9, GhazalNo = 12, Mesra1 = "دور دار از خاک و خون دامن چو بر ما بگذری", Mesra2 = "کاندر اين ره کشته بسيارند قربان شما",},
new Hafez{ Id= 106, BeytNo = 10, GhazalNo = 12, Mesra1 = "ای صبا با ساکنان شهر يزد از ما بگو", Mesra2 = "کای سر حق ناشناسان گوی چوگان شما",},
new Hafez{ Id= 107, BeytNo = 11, GhazalNo = 12, Mesra1 = "گر چه دوريم از بساط قرب همت دور نيست", Mesra2 = "بنده شاه شماييم و ثناخوان شما",},
new Hafez{ Id= 108, BeytNo = 12, GhazalNo = 12, Mesra1 = "ای شهنشاه بلنداختر خدا را همتی", Mesra2 = "تا ببوسم همچو اختر خاک ايوان شما",},
new Hafez{ Id= 109, BeytNo = 13, GhazalNo = 12, Mesra1 = "می‌کند حافظ دعايی بشنو آمينی بگو", Mesra2 = "روزی ما باد لعل شکرافشان شما",},
new Hafez{ Id= 110, BeytNo = 1, GhazalNo = 13, Mesra1 = "می‌دمد صبح و کله بست سحاب", Mesra2 = "الصبوح الصبوح يا اصحاب",},
new Hafez{ Id= 111, BeytNo = 2, GhazalNo = 13, Mesra1 = "می‌چکد ژاله بر رخ لاله", Mesra2 = "المدام المدام يا احباب",},
new Hafez{ Id= 112, BeytNo = 3, GhazalNo = 13, Mesra1 = "می‌وزد از چمن نسيم بهشت", Mesra2 = "هان بنوشيد دم به دم می ناب",},
new Hafez{ Id= 113, BeytNo = 4, GhazalNo = 13, Mesra1 = "تخت زمرد زده است گل به چمن", Mesra2 = "راح چون لعل آتشين درياب",},
new Hafez{ Id= 114, BeytNo = 5, GhazalNo = 13, Mesra1 = "در ميخانه بسته‌اند دگر", Mesra2 = "افتتح يا مفتح الابواب",},
new Hafez{ Id= 115, BeytNo = 6, GhazalNo = 13, Mesra1 = "لب و دندانت را حقوق نمک", Mesra2 = "هست بر جان و سينه‌های کباب",},
new Hafez{ Id= 116, BeytNo = 7, GhazalNo = 13, Mesra1 = "اين چنين موسمی عجب باشد", Mesra2 = "که ببندند ميکده به شتاب",},
new Hafez{ Id= 117, BeytNo = 8, GhazalNo = 13, Mesra1 = "بر رخ ساقی پری پيکر", Mesra2 = "همچو حافظ بنوش باده ناب",},
new Hafez{ Id= 118, BeytNo = 1, GhazalNo = 14, Mesra1 = "گفتم ای سلطان خوبان رحم کن بر اين غريب", Mesra2 = "گفت در دنبال دل ره گم کند مسکين غريب",},
new Hafez{ Id= 119, BeytNo = 2, GhazalNo = 14, Mesra1 = "گفتمش مگذر زمانی گفت معذورم بدار", Mesra2 = "خانه پروردی چه تاب آرد غم چندين غريب",},
new Hafez{ Id= 120, BeytNo = 3, GhazalNo = 14, Mesra1 = "خفته بر سنجاب شاهی نازنينی را چه غم", Mesra2 = "گر ز خار و خاره سازد بستر و بالين غريب",},
new Hafez{ Id= 121, BeytNo = 4, GhazalNo = 14, Mesra1 = "ای که در زنجير زلفت جای چندين آشناست", Mesra2 = "خوش فتاد آن خال مشکين بر رخ رنگين غريب",},
new Hafez{ Id= 122, BeytNo = 5, GhazalNo = 14, Mesra1 = "می‌نمايد عکس می در رنگ روی مه وشت", Mesra2 = "همچو برگ ارغوان بر صفحه نسرين غريب",},
new Hafez{ Id= 123, BeytNo = 6, GhazalNo = 14, Mesra1 = "بس غريب افتاده است آن مور خط گرد رخت", Mesra2 = "گر چه نبود در نگارستان خط مشکين غريب",},
new Hafez{ Id= 124, BeytNo = 7, GhazalNo = 14, Mesra1 = "گفتم ای شام غريبان طره شبرنگ تو", Mesra2 = "در سحرگاهان حذر کن چون بنالد اين غريب",},
new Hafez{ Id= 125, BeytNo = 8, GhazalNo = 14, Mesra1 = "گفت حافظ آشنايان در مقام حيرتند", Mesra2 = "دور نبود گر نشيند خسته و مسکين غريب",},
new Hafez{ Id= 126, BeytNo = 1, GhazalNo = 15, Mesra1 = "ای شاهد قدسی که کشد بند نقابت", Mesra2 = "و ای مرغ بهشتی که دهد دانه و آبت",},
new Hafez{ Id= 127, BeytNo = 2, GhazalNo = 15, Mesra1 = "خوابم بشد از ديده در اين فکر جگرسوز", Mesra2 = "کاغوش که شد منزل آسايش و خوابت",},
new Hafez{ Id= 128, BeytNo = 3, GhazalNo = 15, Mesra1 = "درويش نمی‌پرسی و ترسم که نباشد", Mesra2 = "انديشه آمرزش و پروای ثوابت",},
new Hafez{ Id= 129, BeytNo = 4, GhazalNo = 15, Mesra1 = "راه دل عشاق زد آن چشم خماری", Mesra2 = "پيداست از اين شيوه که مست است شرابت",},
new Hafez{ Id= 130, BeytNo = 5, GhazalNo = 15, Mesra1 = "تيری که زدی بر دلم از غمزه خطا رفت", Mesra2 = "تا باز چه انديشه کند رای صوابت",},
new Hafez{ Id= 131, BeytNo = 6, GhazalNo = 15, Mesra1 = "هر ناله و فرياد که کردم نشنيدی", Mesra2 = "پيداست نگارا که بلند است جنابت",},
new Hafez{ Id= 132, BeytNo = 7, GhazalNo = 15, Mesra1 = "دور است سر آب از اين باديه هش دار", Mesra2 = "تا غول بيابان نفريبد به سرابت",},
new Hafez{ Id= 133, BeytNo = 8, GhazalNo = 15, Mesra1 = "تا در ره پيری به چه آيين روی ای دل", Mesra2 = "باری به غلط صرف شد ايام شبابت",},
new Hafez{ Id= 134, BeytNo = 9, GhazalNo = 15, Mesra1 = "ای قصر دل افروز که منزلگه انسی", Mesra2 = "يا رب مکناد آفت ايام خرابت",},
new Hafez{ Id= 135, BeytNo = 10, GhazalNo = 15, Mesra1 = "حافظ نه غلاميست که از خواجه گريزد", Mesra2 = "صلحی کن و بازآ که خرابم ز عتابت",},
new Hafez{ Id= 136, BeytNo = 1, GhazalNo = 16, Mesra1 = "خمی که ابروی شوخ تو در کمان انداخت", Mesra2 = "به قصد جان من زار ناتوان انداخت",},
new Hafez{ Id= 137, BeytNo = 2, GhazalNo = 16, Mesra1 = "نبود نقش دو عالم که رنگ الفت بود", Mesra2 = "زمانه طرح محبت نه اين زمان انداخت",},
new Hafez{ Id= 138, BeytNo = 3, GhazalNo = 16, Mesra1 = "به يک کرشمه که نرگس به خودفروشی کرد", Mesra2 = "فريب چشم تو صد فتنه در جهان انداخت",},
new Hafez{ Id= 139, BeytNo = 4, GhazalNo = 16, Mesra1 = "شراب خورده و خوی کرده می‌روی به چمن", Mesra2 = "که آب روی تو آتش در ارغوان انداخت",},
new Hafez{ Id= 140, BeytNo = 5, GhazalNo = 16, Mesra1 = "به بزمگاه چمن دوش مست بگذشتم", Mesra2 = "چو از دهان توام غنچه در گمان انداخت",},
new Hafez{ Id= 141, BeytNo = 6, GhazalNo = 16, Mesra1 = "بنفشه طره مفتول خود گره می‌زد", Mesra2 = "صبا حکايت زلف تو در ميان انداخت",},
new Hafez{ Id= 142, BeytNo = 7, GhazalNo = 16, Mesra1 = "ز شرم آن که به روی تو نسبتش کردم", Mesra2 = "سمن به دست صبا خاک در دهان انداخت",},
new Hafez{ Id= 143, BeytNo = 8, GhazalNo = 16, Mesra1 = "من از ورع می و مطرب نديدمی زين پيش", Mesra2 = "هوای مغبچگانم در اين و آن انداخت",},
new Hafez{ Id= 144, BeytNo = 9, GhazalNo = 16, Mesra1 = "کنون به آب می لعل خرقه می‌شويم", Mesra2 = "نصيبه ازل از خود نمی‌توان انداخت",},
new Hafez{ Id= 145, BeytNo = 10, GhazalNo = 16, Mesra1 = "مگر گشايش حافظ در اين خرابی بود", Mesra2 = "که بخشش ازلش در می مغان انداخت",},
new Hafez{ Id= 146, BeytNo = 11, GhazalNo = 16, Mesra1 = "جهان به کام من اکنون شود که دور زمان", Mesra2 = "مرا به بندگی خواجه جهان انداخت",},
new Hafez{ Id= 147, BeytNo = 1, GhazalNo = 17, Mesra1 = "سينه از آتش دل در غم جانانه بسوخت", Mesra2 = "آتشی بود در اين خانه که کاشانه بسوخت",},
new Hafez{ Id= 148, BeytNo = 2, GhazalNo = 17, Mesra1 = "تنم از واسطه دوری دلبر بگداخت", Mesra2 = "جانم از آتش مهر رخ جانانه بسوخت",},
new Hafez{ Id= 149, BeytNo = 3, GhazalNo = 17, Mesra1 = "سوز دل بين که ز بس آتش اشکم دل شمع", Mesra2 = "دوش بر من ز سر مهر چو پروانه بسوخت",},
new Hafez{ Id= 150, BeytNo = 4, GhazalNo = 17, Mesra1 = "آشنايی نه غريب است که دلسوز من است", Mesra2 = "چون من از خويش برفتم دل بيگانه بسوخت",},
new Hafez{ Id= 151, BeytNo = 5, GhazalNo = 17, Mesra1 = "خرقه زهد مرا آب خرابات ببرد", Mesra2 = "خانه عقل مرا آتش ميخانه بسوخت",},
new Hafez{ Id= 152, BeytNo = 6, GhazalNo = 17, Mesra1 = "چون پياله دلم از توبه که کردم بشکست", Mesra2 = "همچو لاله جگرم بی می و خمخانه بسوخت",},
new Hafez{ Id= 153, BeytNo = 7, GhazalNo = 17, Mesra1 = "ماجرا کم کن و بازآ که مرا مردم چشم", Mesra2 = "خرقه از سر به درآورد و به شکرانه بسوخت",},
new Hafez{ Id= 154, BeytNo = 8, GhazalNo = 17, Mesra1 = "ترک افسانه بگو حافظ و می نوش دمی", Mesra2 = "که نخفتيم شب و شمع به افسانه بسوخت",},
new Hafez{ Id= 155, BeytNo = 1, GhazalNo = 18, Mesra1 = "ساقيا آمدن عيد مبارک بادت", Mesra2 = "وان مواعيد که کردی مرواد از يادت",},
new Hafez{ Id= 156, BeytNo = 2, GhazalNo = 18, Mesra1 = "در شگفتم که در اين مدت ايام فراق", Mesra2 = "برگرفتی ز حريفان دل و دل می‌دادت",},
new Hafez{ Id= 157, BeytNo = 3, GhazalNo = 18, Mesra1 = "برسان بندگی دختر رز گو به درآی", Mesra2 = "که دم و همت ما کرد ز بند آزادت",},
new Hafez{ Id= 158, BeytNo = 4, GhazalNo = 18, Mesra1 = "شادی مجلسيان در قدم و مقدم توست", Mesra2 = "جای غم باد مر آن دل که نخواهد شادت",},
new Hafez{ Id= 159, BeytNo = 5, GhazalNo = 18, Mesra1 = "شکر ايزد که ز تاراج خزان رخنه نيافت", Mesra2 = "بوستان سمن و سرو و گل و شمشادت",},
new Hafez{ Id= 160, BeytNo = 6, GhazalNo = 18, Mesra1 = "چشم بد دور کز آن تفرقه‌ات بازآورد", Mesra2 = "طالع نامور و دولت مادرزادت",},
new Hafez{ Id= 161, BeytNo = 7, GhazalNo = 18, Mesra1 = "حافظ از دست مده دولت اين کشتی نوح", Mesra2 = "ور نه طوفان حوادث ببرد بنيادت",},
new Hafez{ Id= 162, BeytNo = 1, GhazalNo = 19, Mesra1 = "ای نسيم سحر آرامگه يار کجاست", Mesra2 = "منزل آن مه عاشق کش عيار کجاست",},
new Hafez{ Id= 163, BeytNo = 2, GhazalNo = 19, Mesra1 = "شب تار است و ره وادی ايمن در پيش", Mesra2 = "آتش طور کجا موعد ديدار کجاست",},
new Hafez{ Id= 164, BeytNo = 3, GhazalNo = 19, Mesra1 = "هر که آمد به جهان نقش خرابی دارد", Mesra2 = "در خرابات بگوييد که هشيار کجاست",},
new Hafez{ Id= 165, BeytNo = 4, GhazalNo = 19, Mesra1 = "آن کس است اهل بشارت که اشارت داند", Mesra2 = "نکته‌ها هست بسی محرم اسرار کجاست",},
new Hafez{ Id= 166, BeytNo = 5, GhazalNo = 19, Mesra1 = "هر سر موی مرا با تو هزاران کار است", Mesra2 = "ما کجاييم و ملامت گر بی‌کار کجاست",},
new Hafez{ Id= 167, BeytNo = 6, GhazalNo = 19, Mesra1 = "بازپرسيد ز گيسوی شکن در شکنش", Mesra2 = "کاين دل غمزده سرگشته گرفتار کجاست",},
new Hafez{ Id= 168, BeytNo = 7, GhazalNo = 19, Mesra1 = "عقل ديوانه شد آن سلسله مشکين کو", Mesra2 = "دل ز ما گوشه گرفت ابروی دلدار کجاست",},
new Hafez{ Id= 169, BeytNo = 8, GhazalNo = 19, Mesra1 = "ساقی و مطرب و می جمله مهياست ولی", Mesra2 = "عيش بی يار مهيا نشود يار کجاست",},
new Hafez{ Id= 170, BeytNo = 9, GhazalNo = 19, Mesra1 = "حافظ از باد خزان در چمن دهر مرنج", Mesra2 = "فکر معقول بفرما گل بی خار کجاست",},
new Hafez{ Id= 171, BeytNo = 1, GhazalNo = 20, Mesra1 = "روزه يک سو شد و عيد آمد و دل‌ها برخاست", Mesra2 = "می ز خمخانه به جوش آمد و می بايد خواست",},
new Hafez{ Id= 172, BeytNo = 2, GhazalNo = 20, Mesra1 = "نوبه زهدفروشان گران جان بگذشت", Mesra2 = "وقت رندی و طرب کردن رندان پيداست",},
new Hafez{ Id= 173, BeytNo = 3, GhazalNo = 20, Mesra1 = "چه ملامت بود آن را که چنين باده خورد", Mesra2 = "اين چه عيب است بدين بی‌خردی وين چه خطاست",},
new Hafez{ Id= 174, BeytNo = 4, GhazalNo = 20, Mesra1 = "باده نوشی که در او روی و ريايی نبود", Mesra2 = "بهتر از زهدفروشی که در او روی و رياست",},
new Hafez{ Id= 175, BeytNo = 5, GhazalNo = 20, Mesra1 = "ما نه رندان رياييم و حريفان نفاق", Mesra2 = "آن که او عالم سر است بدين حال گواست",},
new Hafez{ Id= 176, BeytNo = 6, GhazalNo = 20, Mesra1 = "فرض ايزد بگذاريم و به کس بد نکنيم", Mesra2 = "وان چه گويند روا نيست نگوييم رواست",},
new Hafez{ Id= 177, BeytNo = 7, GhazalNo = 20, Mesra1 = "چه شود گر من و تو چند قدح باده خوريم", Mesra2 = "باده از خون رزان است نه از خون شماست",},
new Hafez{ Id= 178, BeytNo = 8, GhazalNo = 20, Mesra1 = "اين چه عيب است کز آن عيب خلل خواهد بود", Mesra2 = "ور بود نيز چه شد مردم بی‌عيب کجاست",},
new Hafez{ Id= 179, BeytNo = 1, GhazalNo = 21, Mesra1 = "دل و دينم شد و دلبر به ملامت برخاست", Mesra2 = "گفت با ما منشين کز تو سلامت برخاست",},
new Hafez{ Id= 180, BeytNo = 2, GhazalNo = 21, Mesra1 = "که شنيدی که در اين بزم دمی خوش بنشست", Mesra2 = "که نه در آخر صحبت به ندامت برخاست",},
new Hafez{ Id= 181, BeytNo = 3, GhazalNo = 21, Mesra1 = "شمع اگر زان لب خندان به زبان لافی زد", Mesra2 = "پيش عشاق تو شب‌ها به غرامت برخاست",},
new Hafez{ Id= 182, BeytNo = 4, GhazalNo = 21, Mesra1 = "در چمن باد بهاری ز کنار گل و سرو", Mesra2 = "به هواداری آن عارض و قامت برخاست",},
new Hafez{ Id= 183, BeytNo = 5, GhazalNo = 21, Mesra1 = "مست بگذشتی و از خلوتيان ملکوت", Mesra2 = "به تماشای تو آشوب قيامت برخاست",},
new Hafez{ Id= 184, BeytNo = 6, GhazalNo = 21, Mesra1 = "پيش رفتار تو پا برنگرفت از خجلت", Mesra2 = "سرو سرکش که به ناز از قد و قامت برخاست",},
new Hafez{ Id= 185, BeytNo = 7, GhazalNo = 21, Mesra1 = "حافظ اين خرقه بينداز مگر جان ببری", Mesra2 = "کاتش از خرقه سالوس و کرامت برخاست",},
new Hafez{ Id= 186, BeytNo = 1, GhazalNo = 22, Mesra1 = "چو بشنوی سخن اهل دل مگو که خطاست", Mesra2 = "سخن شناس نه‌ای جان من خطا اين جاست",},
new Hafez{ Id= 187, BeytNo = 2, GhazalNo = 22, Mesra1 = "سرم به دنيی و عقبی فرو نمی‌آيد", Mesra2 = "تبارک الله از اين فتنه‌ها که در سر ماست",},
new Hafez{ Id= 188, BeytNo = 3, GhazalNo = 22, Mesra1 = "در اندرون من خسته دل ندانم کيست", Mesra2 = "که من خموشم و او در فغان و در غوغاست",},
new Hafez{ Id= 189, BeytNo = 4, GhazalNo = 22, Mesra1 = "دلم ز پرده برون شد کجايی ای مطرب", Mesra2 = "بنال هان که از اين پرده کار ما به نواست",},
new Hafez{ Id= 190, BeytNo = 5, GhazalNo = 22, Mesra1 = "مرا به کار جهان هرگز التفات نبود", Mesra2 = "رخ تو در نظر من چنين خوشش آراست",},
new Hafez{ Id= 191, BeytNo = 6, GhazalNo = 22, Mesra1 = "نخفته‌ام ز خيالی که می‌پزد دل من", Mesra2 = "خمار صدشبه دارم شرابخانه کجاست",},
new Hafez{ Id= 192, BeytNo = 7, GhazalNo = 22, Mesra1 = "چنين که صومعه آلوده شد ز خون دلم", Mesra2 = "گرم به باده بشوييد حق به دست شماست",},
new Hafez{ Id= 193, BeytNo = 8, GhazalNo = 22, Mesra1 = "از آن به دير مغانم عزيز می‌دارند", Mesra2 = "که آتشی که نميرد هميشه در دل ماست",},
new Hafez{ Id= 194, BeytNo = 9, GhazalNo = 22, Mesra1 = "چه ساز بود که در پرده می‌زد آن مطرب", Mesra2 = "که رفت عمر و هنوزم دماغ پر ز هواست",},
new Hafez{ Id= 195, BeytNo = 10, GhazalNo = 22, Mesra1 = "ندای عشق تو ديشب در اندرون دادند", Mesra2 = "فضای سينه حافظ هنوز پر ز صداست",},
new Hafez{ Id= 196, BeytNo = 1, GhazalNo = 23, Mesra1 = "خيال روی تو در هر طريق همره ماست", Mesra2 = "نسيم موی تو پيوند جان آگه ماست",},
new Hafez{ Id= 197, BeytNo = 2, GhazalNo = 23, Mesra1 = "به رغم مدعيانی که منع عشق کنند", Mesra2 = "جمال چهره تو حجت موجه ماست",},
new Hafez{ Id= 198, BeytNo = 3, GhazalNo = 23, Mesra1 = "ببين که سيب زنخدان تو چه می‌گويد", Mesra2 = "هزار يوسف مصری فتاده در چه ماست",},
new Hafez{ Id= 199, BeytNo = 4, GhazalNo = 23, Mesra1 = "اگر به زلف دراز تو دست ما نرسد", Mesra2 = "گناه بخت پريشان و دست کوته ماست",},
new Hafez{ Id= 200, BeytNo = 5, GhazalNo = 23, Mesra1 = "به حاجب در خلوت سرای خاص بگو", Mesra2 = "فلان ز گوشه نشينان خاک درگه ماست",},
new Hafez{ Id= 201, BeytNo = 6, GhazalNo = 23, Mesra1 = "به صورت از نظر ما اگر چه محجوب است", Mesra2 = "هميشه در نظر خاطر مرفه ماست",},
new Hafez{ Id= 202, BeytNo = 7, GhazalNo = 23, Mesra1 = "اگر به سالی حافظ دری زند بگشای", Mesra2 = "که سال‌هاست که مشتاق روی چون مه ماست",},
new Hafez{ Id= 203, BeytNo = 1, GhazalNo = 24, Mesra1 = "مطلب طاعت و پيمان و صلاح از من مست", Mesra2 = "که به پيمانه کشی شهره شدم روز الست",},
new Hafez{ Id= 204, BeytNo = 2, GhazalNo = 24, Mesra1 = "من همان دم که وضو ساختم از چشمه عشق", Mesra2 = "چارتکبير زدم يک سره بر هر چه که هست",},
new Hafez{ Id= 205, BeytNo = 3, GhazalNo = 24, Mesra1 = "می بده تا دهمت آگهی از سر قضا", Mesra2 = "که به روی که شدم عاشق و از بوی که مست",},
new Hafez{ Id= 206, BeytNo = 4, GhazalNo = 24, Mesra1 = "کمر کوه کم است از کمر مور اين جا", Mesra2 = "نااميد از در رحمت مشو ای باده پرست",},
new Hafez{ Id= 207, BeytNo = 5, GhazalNo = 24, Mesra1 = "بجز آن نرگس مستانه که چشمش مرساد", Mesra2 = "زير اين طارم فيروزه کسی خوش ننشست",},
new Hafez{ Id= 208, BeytNo = 6, GhazalNo = 24, Mesra1 = "جان فدای دهنش باد که در باغ نظر", Mesra2 = "چمن آرای جهان خوشتر از اين غنچه نبست",},
new Hafez{ Id= 209, BeytNo = 7, GhazalNo = 24, Mesra1 = "حافظ از دولت عشق تو سليمانی شد", Mesra2 = "يعنی از وصل تواش نيست بجز باد به دست",},
new Hafez{ Id= 210, BeytNo = 1, GhazalNo = 25, Mesra1 = "شکفته شد گل حمرا و گشت بلبل مست", Mesra2 = "صلای سرخوشی ای صوفيان باده پرست",},
new Hafez{ Id= 211, BeytNo = 2, GhazalNo = 25, Mesra1 = "اساس توبه که در محکمی چو سنگ نمود", Mesra2 = "ببين که جام زجاجی چه طرفه‌اش بشکست",},
new Hafez{ Id= 212, BeytNo = 3, GhazalNo = 25, Mesra1 = "بيار باده که در بارگاه استغنا", Mesra2 = "چه پاسبان و چه سلطان چه هوشيار و چه مست",},
new Hafez{ Id= 213, BeytNo = 4, GhazalNo = 25, Mesra1 = "از اين رباط دودر چون ضرورت است رحيل", Mesra2 = "رواق و طاق معيشت چه سربلند و چه پست",},
new Hafez{ Id= 214, BeytNo = 5, GhazalNo = 25, Mesra1 = "مقام عيش ميسر نمی‌شود بی‌رنج", Mesra2 = "بلی به حکم بلا بسته‌اند عهد الست",},
new Hafez{ Id= 215, BeytNo = 6, GhazalNo = 25, Mesra1 = "به هست و نيست مرنجان ضمير و خوش می‌باش", Mesra2 = "که نيستيست سرانجام هر کمال که هست",},
new Hafez{ Id= 216, BeytNo = 7, GhazalNo = 25, Mesra1 = "شکوه آصفی و اسب باد و منطق طير", Mesra2 = "به باد رفت و از او خواجه هيچ طرف نبست",},
new Hafez{ Id= 217, BeytNo = 8, GhazalNo = 25, Mesra1 = "به بال و پر مرو از ره که تير پرتابی", Mesra2 = "هوا گرفت زمانی ولی به خاک نشست",},
new Hafez{ Id= 218, BeytNo = 9, GhazalNo = 25, Mesra1 = "زبان کلک تو حافظ چه شکر آن گويد", Mesra2 = "که گفته سخنت می‌برند دست به دست",},
new Hafez{ Id= 219, BeytNo = 1, GhazalNo = 26, Mesra1 = "زلف آشفته و خوی کرده و خندان لب و مست", Mesra2 = "پيرهن چاک و غزل خوان و صراحی در دست",},
new Hafez{ Id= 220, BeytNo = 2, GhazalNo = 26, Mesra1 = "نرگسش عربده جوی و لبش افسوس کنان", Mesra2 = "نيم شب دوش به بالين من آمد بنشست",},
new Hafez{ Id= 221, BeytNo = 3, GhazalNo = 26, Mesra1 = "سر فرا گوش من آورد به آواز حزين", Mesra2 = "گفت ای عاشق ديرينه من خوابت هست",},
new Hafez{ Id= 222, BeytNo = 4, GhazalNo = 26, Mesra1 = "عاشقی را که چنين باده شبگير دهند", Mesra2 = "کافر عشق بود گر نشود باده پرست",},
new Hafez{ Id= 223, BeytNo = 5, GhazalNo = 26, Mesra1 = "برو ای زاهد و بر دردکشان خرده مگير", Mesra2 = "که ندادند جز اين تحفه به ما روز الست",},
new Hafez{ Id= 224, BeytNo = 6, GhazalNo = 26, Mesra1 = "آن چه او ريخت به پيمانه ما نوشيديم", Mesra2 = "اگر از خمر بهشت است وگر باده مست",},
new Hafez{ Id= 225, BeytNo = 7, GhazalNo = 26, Mesra1 = "خنده جام می و زلف گره گير نگار", Mesra2 = "ای بسا توبه که چون توبه حافظ بشکست",},
new Hafez{ Id= 226, BeytNo = 1, GhazalNo = 27, Mesra1 = "در دير مغان آمد يارم قدحی در دست", Mesra2 = "مست از می و ميخواران از نرگس مستش مست",},
new Hafez{ Id= 227, BeytNo = 2, GhazalNo = 27, Mesra1 = "در نعل سمند او شکل مه نو پيدا", Mesra2 = "وز قد بلند او بالای صنوبر پست",},
new Hafez{ Id= 228, BeytNo = 3, GhazalNo = 27, Mesra1 = "آخر به چه گويم هست از خود خبرم چون نيست", Mesra2 = "وز بهر چه گويم نيست با وی نظرم چون هست",},
new Hafez{ Id= 229, BeytNo = 4, GhazalNo = 27, Mesra1 = "شمع دل دمسازم بنشست چو او برخاست", Mesra2 = "و افغان ز نظربازان برخاست چو او بنشست",},
new Hafez{ Id= 230, BeytNo = 5, GhazalNo = 27, Mesra1 = "گر غاليه خوش بو شد در گيسوی او پيچيد", Mesra2 = "ور وسمه کمانکش گشت در ابروی او پيوست",},
new Hafez{ Id= 231, BeytNo = 6, GhazalNo = 27, Mesra1 = "بازآی که بازآيد عمر شده حافظ", Mesra2 = "هر چند که نايد باز تيری که بشد از شست",},
new Hafez{ Id= 232, BeytNo = 1, GhazalNo = 28, Mesra1 = "به جان خواجه و حق قديم و عهد درست", Mesra2 = "که مونس دم صبحم دعای دولت توست",},
new Hafez{ Id= 233, BeytNo = 2, GhazalNo = 28, Mesra1 = "سرشک من که ز طوفان نوح دست برد", Mesra2 = "ز لوح سينه نيارست نقش مهر تو شست",},
new Hafez{ Id= 234, BeytNo = 3, GhazalNo = 28, Mesra1 = "بکن معامله‌ای وين دل شکسته بخر", Mesra2 = "که با شکستگی ارزد به صد هزار درست",},
new Hafez{ Id= 235, BeytNo = 4, GhazalNo = 28, Mesra1 = "زبان مور به آصف دراز گشت و رواست", Mesra2 = "که خواجه خاتم جم ياوه کرد و بازنجست",},
new Hafez{ Id= 236, BeytNo = 5, GhazalNo = 28, Mesra1 = "دلا طمع مبر از لطف بی‌نهايت دوست", Mesra2 = "چو لاف عشق زدی سر بباز چابک و چست",},
new Hafez{ Id= 237, BeytNo = 6, GhazalNo = 28, Mesra1 = "به صدق کوش که خورشيد زايد از نفست", Mesra2 = "که از دروغ سيه روی گشت صبح نخست",},
new Hafez{ Id= 238, BeytNo = 7, GhazalNo = 28, Mesra1 = "شدم ز دست تو شيدای کوه و دشت و هنوز", Mesra2 = "نمی‌کنی به ترحم نطاق سلسله سست",},
new Hafez{ Id= 239, BeytNo = 8, GhazalNo = 28, Mesra1 = "مرنج حافظ و از دلبران حفاظ مجوی", Mesra2 = "گناه باغ چه باشد چو اين گياه نرست",},
new Hafez{ Id= 240, BeytNo = 1, GhazalNo = 29, Mesra1 = "ما را ز خيال تو چه پروای شراب است", Mesra2 = "خم گو سر خود گير که خمخانه خراب است",},
new Hafez{ Id= 241, BeytNo = 2, GhazalNo = 29, Mesra1 = "گر خمر بهشت است بريزيد که بی دوست", Mesra2 = "هر شربت عذبم که دهی عين عذاب است",},
new Hafez{ Id= 242, BeytNo = 3, GhazalNo = 29, Mesra1 = "افسوس که شد دلبر و در ديده گريان", Mesra2 = "تحرير خيال خط او نقش بر آب است",},
new Hafez{ Id= 243, BeytNo = 4, GhazalNo = 29, Mesra1 = "بيدار شو ای ديده که ايمن نتوان بود", Mesra2 = "زين سيل دمادم که در اين منزل خواب است",},
new Hafez{ Id= 244, BeytNo = 5, GhazalNo = 29, Mesra1 = "معشوق عيان می‌گذرد بر تو وليکن", Mesra2 = "اغيار همی‌بيند از آن بسته نقاب است",},
new Hafez{ Id= 245, BeytNo = 6, GhazalNo = 29, Mesra1 = "گل بر رخ رنگين تو تا لطف عرق ديد", Mesra2 = "در آتش شوق از غم دل غرق گلاب است",},
new Hafez{ Id= 246, BeytNo = 7, GhazalNo = 29, Mesra1 = "سبز است در و دشت بيا تا نگذاريم", Mesra2 = "دست از سر آبی که جهان جمله سراب است",},
new Hafez{ Id= 247, BeytNo = 8, GhazalNo = 29, Mesra1 = "در کنج دماغم مطلب جای نصيحت", Mesra2 = "کاين گوشه پر از زمزمه چنگ و رباب است",},
new Hafez{ Id= 248, BeytNo = 9, GhazalNo = 29, Mesra1 = "حافظ چه شد ار عاشق و رند است و نظرباز", Mesra2 = "بس طور عجب لازم ايام شباب است",},
new Hafez{ Id= 249, BeytNo = 1, GhazalNo = 30, Mesra1 = "زلفت هزار دل به يکی تار مو ببست", Mesra2 = "راه هزار چاره گر از چار سو ببست",},
new Hafez{ Id= 250, BeytNo = 2, GhazalNo = 30, Mesra1 = "تا عاشقان به بوی نسيمش دهند جان", Mesra2 = "بگشود نافه‌ای و در آرزو ببست",},
new Hafez{ Id= 251, BeytNo = 3, GhazalNo = 30, Mesra1 = "شيدا از آن شدم که نگارم چو ماه نو", Mesra2 = "ابرو نمود و جلوه گری کرد و رو ببست",},
new Hafez{ Id= 252, BeytNo = 4, GhazalNo = 30, Mesra1 = "ساقی به چند رنگ می اندر پياله ريخت", Mesra2 = "اين نقش‌ها نگر که چه خوش در کدو ببست",},
new Hafez{ Id= 253, BeytNo = 5, GhazalNo = 30, Mesra1 = "يا رب چه غمزه کرد صراحی که خون خم", Mesra2 = "با نعره‌های قلقلش اندر گلو ببست",},
new Hafez{ Id= 254, BeytNo = 6, GhazalNo = 30, Mesra1 = "مطرب چه پرده ساخت که در پرده سماع", Mesra2 = "بر اهل وجد و حال در های و هو ببست",},
new Hafez{ Id= 255, BeytNo = 7, GhazalNo = 30, Mesra1 = "حافظ هر آن که عشق نورزيد و وصل خواست", Mesra2 = "احرام طوف کعبه دل بی وضو ببست",},
new Hafez{ Id= 256, BeytNo = 1, GhazalNo = 31, Mesra1 = "آن شب قدری که گويند اهل خلوت امشب است", Mesra2 = "يا رب اين تاثير دولت در کدامين کوکب است",},
new Hafez{ Id= 257, BeytNo = 2, GhazalNo = 31, Mesra1 = "تا به گيسوی تو دست ناسزايان کم رسد", Mesra2 = "هر دلی از حلقه‌ای در ذکر يارب يارب است",},
new Hafez{ Id= 258, BeytNo = 3, GhazalNo = 31, Mesra1 = "کشته چاه زنخدان توام کز هر طرف", Mesra2 = "صد هزارش گردن جان زير طوق غبغب است",},
new Hafez{ Id= 259, BeytNo = 4, GhazalNo = 31, Mesra1 = "شهسوار من که مه آيينه دار روی اوست", Mesra2 = "تاج خورشيد بلندش خاک نعل مرکب است",},
new Hafez{ Id= 260, BeytNo = 5, GhazalNo = 31, Mesra1 = "عکس خوی بر عارضش بين کفتاب گرم رو", Mesra2 = "در هوای آن عرق تا هست هر روزش تب است",},
new Hafez{ Id= 261, BeytNo = 6, GhazalNo = 31, Mesra1 = "من نخواهم کرد ترک لعل يار و جام می", Mesra2 = "زاهدان معذور داريدم که اينم مذهب است",},
new Hafez{ Id= 262, BeytNo = 7, GhazalNo = 31, Mesra1 = "اندر آن ساعت که بر پشت صبا بندند زين", Mesra2 = "با سليمان چون برانم من که مورم مرکب است",},
new Hafez{ Id= 263, BeytNo = 8, GhazalNo = 31, Mesra1 = "آن که ناوک بر دل من زير چشمی می‌زند", Mesra2 = "قوت جان حافظش در خنده زير لب است",},
new Hafez{ Id= 264, BeytNo = 9, GhazalNo = 31, Mesra1 = "آب حيوانش ز منقار بلاغت می‌چکد", Mesra2 = "زاغ کلک من به نام ايزد چه عالی مشرب است",},
new Hafez{ Id= 265, BeytNo = 1, GhazalNo = 32, Mesra1 = "خدا چو صورت ابروی دلگشای تو بست", Mesra2 = "گشاد کار من اندر کرشمه‌های تو بست",},
new Hafez{ Id= 266, BeytNo = 2, GhazalNo = 32, Mesra1 = "مرا و سرو چمن را به خاک راه نشاند", Mesra2 = "زمانه تا قصب نرگس قبای تو بست",},
new Hafez{ Id= 267, BeytNo = 3, GhazalNo = 32, Mesra1 = "ز کار ما و دل غنچه صد گره بگشود", Mesra2 = "نسيم گل چو دل اندر پی هوای تو بست",},
new Hafez{ Id= 268, BeytNo = 4, GhazalNo = 32, Mesra1 = "مرا به بند تو دوران چرخ راضی کرد", Mesra2 = "ولی چه سود که سررشته در رضای تو بست",},
new Hafez{ Id= 269, BeytNo = 5, GhazalNo = 32, Mesra1 = "چو نافه بر دل مسکين من گره مفکن", Mesra2 = "که عهد با سر زلف گره گشای تو بست",},
new Hafez{ Id= 270, BeytNo = 6, GhazalNo = 32, Mesra1 = "تو خود وصال دگر بودی ای نسيم وصال", Mesra2 = "خطا نگر که دل اميد در وفای تو بست",},
new Hafez{ Id= 271, BeytNo = 7, GhazalNo = 32, Mesra1 = "ز دست جور تو گفتم ز شهر خواهم رفت", Mesra2 = "به خنده گفت که حافظ برو که پای تو بست",},
new Hafez{ Id= 272, BeytNo = 1, GhazalNo = 33, Mesra1 = "خلوت گزيده را به تماشا چه حاجت است", Mesra2 = "چون کوی دوست هست به صحرا چه حاجت است",},
new Hafez{ Id= 273, BeytNo = 2, GhazalNo = 33, Mesra1 = "جانا به حاجتی که تو را هست با خدا", Mesra2 = "کخر دمی بپرس که ما را چه حاجت است",},
new Hafez{ Id= 274, BeytNo = 3, GhazalNo = 33, Mesra1 = "ای پادشاه حسن خدا را بسوختيم", Mesra2 = "آخر سال کن که گدا را چه حاجت است",},
new Hafez{ Id= 275, BeytNo = 4, GhazalNo = 33, Mesra1 = "ارباب حاجتيم و زبان سال نيست", Mesra2 = "در حضرت کريم تمنا چه حاجت است",},
new Hafez{ Id= 276, BeytNo = 5, GhazalNo = 33, Mesra1 = "محتاج قصه نيست گرت قصد خون ماست", Mesra2 = "چون رخت از آن توست به يغما چه حاجت است",},
new Hafez{ Id= 277, BeytNo = 6, GhazalNo = 33, Mesra1 = "جام جهان نماست ضمير منير دوست", Mesra2 = "اظهار احتياج خود آن جا چه حاجت است",},
new Hafez{ Id= 278, BeytNo = 7, GhazalNo = 33, Mesra1 = "آن شد که بار منت ملاح بردمی", Mesra2 = "گوهر چو دست داد به دريا چه حاجت است",},
new Hafez{ Id= 279, BeytNo = 8, GhazalNo = 33, Mesra1 = "ای مدعی برو که مرا با تو کار نيست", Mesra2 = "احباب حاضرند به اعدا چه حاجت است",},
new Hafez{ Id= 280, BeytNo = 9, GhazalNo = 33, Mesra1 = "ای عاشق گدا چو لب روح بخش يار", Mesra2 = "می‌داندت وظيفه تقاضا چه حاجت است",},
new Hafez{ Id= 281, BeytNo = 10, GhazalNo = 33, Mesra1 = "حافظ تو ختم کن که هنر خود عيان شود", Mesra2 = "با مدعی نزاع و محاکا چه حاجت است",},
new Hafez{ Id= 282, BeytNo = 1, GhazalNo = 34, Mesra1 = "رواق منظر چشم من آشيانه توست", Mesra2 = "کرم نما و فرود آ که خانه خانه توست",},
new Hafez{ Id= 283, BeytNo = 2, GhazalNo = 34, Mesra1 = "به لطف خال و خط از عارفان ربودی دل", Mesra2 = "لطيفه‌های عجب زير دام و دانه توست",},
new Hafez{ Id= 284, BeytNo = 3, GhazalNo = 34, Mesra1 = "دلت به وصل گل ای بلبل صبا خوش باد", Mesra2 = "که در چمن همه گلبانگ عاشقانه توست",},
new Hafez{ Id= 285, BeytNo = 4, GhazalNo = 34, Mesra1 = "علاج ضعف دل ما به لب حوالت کن", Mesra2 = "که اين مفرح ياقوت در خزانه توست",},
new Hafez{ Id= 286, BeytNo = 5, GhazalNo = 34, Mesra1 = "به تن مقصرم از دولت ملازمتت", Mesra2 = "ولی خلاصه جان خاک آستانه توست",},
new Hafez{ Id= 287, BeytNo = 6, GhazalNo = 34, Mesra1 = "من آن نيم که دهم نقد دل به هر شوخی", Mesra2 = "در خزانه به مهر تو و نشانه توست",},
new Hafez{ Id= 288, BeytNo = 7, GhazalNo = 34, Mesra1 = "تو خود چه لعبتی ای شهسوار شيرين کار", Mesra2 = "که توسنی چو فلک رام تازيانه توست",},
new Hafez{ Id= 289, BeytNo = 8, GhazalNo = 34, Mesra1 = "چه جای من که بلغزد سپهر شعبده باز", Mesra2 = "از اين حيل که در انبانه بهانه توست",},
new Hafez{ Id= 290, BeytNo = 9, GhazalNo = 34, Mesra1 = "سرود مجلست اکنون فلک به رقص آرد", Mesra2 = "که شعر حافظ شيرين سخن ترانه توست",},
new Hafez{ Id= 291, BeytNo = 1, GhazalNo = 35, Mesra1 = "برو به کار خود ای واعظ اين چه فريادست", Mesra2 = "مرا فتاد دل از ره تو را چه افتادست",},
new Hafez{ Id= 292, BeytNo = 2, GhazalNo = 35, Mesra1 = "ميان او که خدا آفريده است از هيچ", Mesra2 = "دقيقه‌ايست که هيچ آفريده نگشادست",},
new Hafez{ Id= 293, BeytNo = 3, GhazalNo = 35, Mesra1 = "به کام تا نرساند مرا لبش چون نای", Mesra2 = "نصيحت همه عالم به گوش من بادست",},
new Hafez{ Id= 294, BeytNo = 4, GhazalNo = 35, Mesra1 = "گدای کوی تو از هشت خلد مستغنيست", Mesra2 = "اسير عشق تو از هر دو عالم آزادست",},
new Hafez{ Id= 295, BeytNo = 5, GhazalNo = 35, Mesra1 = "اگر چه مستی عشقم خراب کرد ولی", Mesra2 = "اساس هستی من زان خراب آبادست",},
new Hafez{ Id= 296, BeytNo = 6, GhazalNo = 35, Mesra1 = "دلا منال ز بيداد و جور يار که يار", Mesra2 = "تو را نصيب همين کرد و اين از آن دادست",},
new Hafez{ Id= 297, BeytNo = 7, GhazalNo = 35, Mesra1 = "برو فسانه مخوان و فسون مدم حافظ", Mesra2 = "کز اين فسانه و افسون مرا بسی يادست",},
new Hafez{ Id= 298, BeytNo = 1, GhazalNo = 36, Mesra1 = "تا سر زلف تو در دست نسيم افتادست", Mesra2 = "دل سودازده از غصه دو نيم افتادست",},
new Hafez{ Id= 299, BeytNo = 2, GhazalNo = 36, Mesra1 = "چشم جادوی تو خود عين سواد سحر است", Mesra2 = "ليکن اين هست که اين نسخه سقيم افتادست",},
new Hafez{ Id= 300, BeytNo = 3, GhazalNo = 36, Mesra1 = "در خم زلف تو آن خال سيه دانی چيست", Mesra2 = "نقطه دوده که در حلقه جيم افتادست",},
new Hafez{ Id= 301, BeytNo = 4, GhazalNo = 36, Mesra1 = "زلف مشکين تو در گلشن فردوس عذار", Mesra2 = "چيست طاووس که در باغ نعيم افتادست",},
new Hafez{ Id= 302, BeytNo = 5, GhazalNo = 36, Mesra1 = "دل من در هوس روی تو ای مونس جان", Mesra2 = "خاک راهيست که در دست نسيم افتادست",},
new Hafez{ Id= 303, BeytNo = 6, GhazalNo = 36, Mesra1 = "همچو گرد اين تن خاکی نتواند برخاست", Mesra2 = "از سر کوی تو زان رو که عظيم افتادست",},
new Hafez{ Id= 304, BeytNo = 7, GhazalNo = 36, Mesra1 = "سايه قد تو بر قالبم ای عيسی دم", Mesra2 = "عکس روحيست که بر عظم رميم افتادست",},
new Hafez{ Id= 305, BeytNo = 8, GhazalNo = 36, Mesra1 = "آن که جز کعبه مقامش نبد از ياد لبت", Mesra2 = "بر در ميکده ديدم که مقيم افتادست",},
new Hafez{ Id= 306, BeytNo = 9, GhazalNo = 36, Mesra1 = "حافظ گمشده را با غمت ای يار عزيز", Mesra2 = "اتحاديست که در عهد قديم افتادست",},
new Hafez{ Id= 307, BeytNo = 1, GhazalNo = 37, Mesra1 = "بيا که قصر امل سخت سست بنيادست", Mesra2 = "بيار باده که بنياد عمر بر بادست",},
new Hafez{ Id= 308, BeytNo = 2, GhazalNo = 37, Mesra1 = "غلام همت آنم که زير چرخ کبود", Mesra2 = "ز هر چه رنگ تعلق پذيرد آزادست",},
new Hafez{ Id= 309, BeytNo = 3, GhazalNo = 37, Mesra1 = "چه گويمت که به ميخانه دوش مست و خراب", Mesra2 = "سروش عالم غيبم چه مژده‌ها دادست",},
new Hafez{ Id= 310, BeytNo = 4, GhazalNo = 37, Mesra1 = "که ای بلندنظر شاهباز سدره نشين", Mesra2 = "نشيمن تو نه اين کنج محنت آبادست",},
new Hafez{ Id= 311, BeytNo = 5, GhazalNo = 37, Mesra1 = "تو را ز کنگره عرش می‌زنند صفير", Mesra2 = "ندانمت که در اين دامگه چه افتادست",},
new Hafez{ Id= 312, BeytNo = 6, GhazalNo = 37, Mesra1 = "نصيحتی کنمت ياد گير و در عمل آر", Mesra2 = "که اين حديث ز پير طريقتم يادست",},
new Hafez{ Id= 313, BeytNo = 7, GhazalNo = 37, Mesra1 = "غم جهان مخور و پند من مبر از ياد", Mesra2 = "که اين لطيفه عشقم ز ره روی يادست",},
new Hafez{ Id= 314, BeytNo = 8, GhazalNo = 37, Mesra1 = "رضا به داده بده وز جبين گره بگشای", Mesra2 = "که بر من و تو در اختيار نگشادست",},
new Hafez{ Id= 315, BeytNo = 9, GhazalNo = 37, Mesra1 = "مجو درستی عهد از جهان سست نهاد", Mesra2 = "که اين عجوز عروس هزاردامادست",},
new Hafez{ Id= 316, BeytNo = 10, GhazalNo = 37, Mesra1 = "نشان عهد و وفا نيست در تبسم گل", Mesra2 = "بنال بلبل بی دل که جای فريادست",},
new Hafez{ Id= 317, BeytNo = 11, GhazalNo = 37, Mesra1 = "حسد چه می‌بری ای سست نظم بر حافظ", Mesra2 = "قبول خاطر و لطف سخن خدادادست",},
new Hafez{ Id= 318, BeytNo = 1, GhazalNo = 38, Mesra1 = "بی مهر رخت روز مرا نور نماندست", Mesra2 = "وز عمر مرا جز شب ديجور نماندست",},
new Hafez{ Id= 319, BeytNo = 2, GhazalNo = 38, Mesra1 = "هنگام وداع تو ز بس گريه که کردم", Mesra2 = "دور از رخ تو چشم مرا نور نماندست",},
new Hafez{ Id= 320, BeytNo = 3, GhazalNo = 38, Mesra1 = "می‌رفت خيال تو ز چشم من و می‌گفت", Mesra2 = "هيهات از اين گوشه که معمور نماندست",},
new Hafez{ Id= 321, BeytNo = 4, GhazalNo = 38, Mesra1 = "وصل تو اجل را ز سرم دور همی‌داشت", Mesra2 = "از دولت هجر تو کنون دور نماندست",},
new Hafez{ Id= 322, BeytNo = 5, GhazalNo = 38, Mesra1 = "نزديک شد آن دم که رقيب تو بگويد", Mesra2 = "دور از رخت اين خسته رنجور نماندست",},
new Hafez{ Id= 323, BeytNo = 6, GhazalNo = 38, Mesra1 = "صبر است مرا چاره هجران تو ليکن", Mesra2 = "چون صبر توان کرد که مقدور نماندست",},
new Hafez{ Id= 324, BeytNo = 7, GhazalNo = 38, Mesra1 = "در هجر تو گر چشم مرا آب روان است", Mesra2 = "گو خون جگر ريز که معذور نماندست",},
new Hafez{ Id= 325, BeytNo = 8, GhazalNo = 38, Mesra1 = "حافظ ز غم از گريه نپرداخت به خنده", Mesra2 = "ماتم زده را داعيه سور نماندست",},
new Hafez{ Id= 326, BeytNo = 1, GhazalNo = 39, Mesra1 = "باغ مرا چه حاجت سرو و صنوبر است", Mesra2 = "شمشاد خانه پرور ما از که کمتر است",},
new Hafez{ Id= 327, BeytNo = 2, GhazalNo = 39, Mesra1 = "ای نازنين پسر تو چه مذهب گرفته‌ای", Mesra2 = "کت خون ما حلالتر از شير مادر است",},
new Hafez{ Id= 328, BeytNo = 3, GhazalNo = 39, Mesra1 = "چون نقش غم ز دور ببينی شراب خواه", Mesra2 = "تشخيص کرده‌ايم و مداوا مقرر است",},
new Hafez{ Id= 329, BeytNo = 4, GhazalNo = 39, Mesra1 = "از آستان پير مغان سر چرا کشيم", Mesra2 = "دولت در آن سرا و گشايش در آن در است",},
new Hafez{ Id= 330, BeytNo = 5, GhazalNo = 39, Mesra1 = "يک قصه بيش نيست غم عشق وين عجب", Mesra2 = "کز هر زبان که می‌شنوم نامکرر است",},
new Hafez{ Id= 331, BeytNo = 6, GhazalNo = 39, Mesra1 = "دی وعده داد وصلم و در سر شراب داشت", Mesra2 = "امروز تا چه گويد و بازش چه در سر است",},
new Hafez{ Id= 332, BeytNo = 7, GhazalNo = 39, Mesra1 = "شيراز و آب رکنی و اين باد خوش نسيم", Mesra2 = "عيبش مکن که خال رخ هفت کشور است",},
new Hafez{ Id= 333, BeytNo = 8, GhazalNo = 39, Mesra1 = "فرق است از آب خضر که ظلمات جای او است", Mesra2 = "تا آب ما که منبعش الله اکبر است",},
new Hafez{ Id= 334, BeytNo = 9, GhazalNo = 39, Mesra1 = "ما آبروی فقر و قناعت نمی‌بريم", Mesra2 = "با پادشه بگوی که روزی مقدر است",},
new Hafez{ Id= 335, BeytNo = 10, GhazalNo = 39, Mesra1 = "حافظ چه طرفه شاخ نباتيست کلک تو", Mesra2 = "کش ميوه دلپذيرتر از شهد و شکر است",},
new Hafez{ Id= 336, BeytNo = 1, GhazalNo = 40, Mesra1 = "المنه لله که در ميکده باز است", Mesra2 = "زان رو که مرا بر در او روی نياز است",},
new Hafez{ Id= 337, BeytNo = 2, GhazalNo = 40, Mesra1 = "خم‌ها همه در جوش و خروشند ز مستی", Mesra2 = "وان می که در آن جاست حقيقت نه مجاز است",},
new Hafez{ Id= 338, BeytNo = 3, GhazalNo = 40, Mesra1 = "از وی همه مستی و غرور است و تکبر", Mesra2 = "وز ما همه بيچارگی و عجز و نياز است",},
new Hafez{ Id= 339, BeytNo = 4, GhazalNo = 40, Mesra1 = "رازی که بر غير نگفتيم و نگوييم", Mesra2 = "با دوست بگوييم که او محرم راز است",},
new Hafez{ Id= 340, BeytNo = 5, GhazalNo = 40, Mesra1 = "شرح شکن زلف خم اندر خم جانان", Mesra2 = "کوته نتوان کرد که اين قصه دراز است",},
new Hafez{ Id= 341, BeytNo = 6, GhazalNo = 40, Mesra1 = "بار دل مجنون و خم طره ليلی", Mesra2 = "رخساره محمود و کف پای اياز است",},
new Hafez{ Id= 342, BeytNo = 7, GhazalNo = 40, Mesra1 = "بردوخته‌ام ديده چو باز از همه عالم", Mesra2 = "تا ديده من بر رخ زيبای تو باز است",},
new Hafez{ Id= 343, BeytNo = 8, GhazalNo = 40, Mesra1 = "در کعبه کوی تو هر آن کس که بيايد", Mesra2 = "از قبله ابروی تو در عين نماز است",},
new Hafez{ Id= 344, BeytNo = 9, GhazalNo = 40, Mesra1 = "ای مجلسيان سوز دل حافظ مسکين", Mesra2 = "از شمع بپرسيد که در سوز و گداز است",},
new Hafez{ Id= 345, BeytNo = 1, GhazalNo = 41, Mesra1 = "اگر چه باده فرح بخش و باد گل‌بيز است", Mesra2 = "به بانگ چنگ مخور می که محتسب تيز است",},
new Hafez{ Id= 346, BeytNo = 2, GhazalNo = 41, Mesra1 = "صراحی ای و حريفی گرت به چنگ افتد", Mesra2 = "به عقل نوش که ايام فتنه انگيز است",},
new Hafez{ Id= 347, BeytNo = 3, GhazalNo = 41, Mesra1 = "در آستين مرقع پياله پنهان کن", Mesra2 = "که همچو چشم صراحی زمانه خون‌ريز است",},
new Hafez{ Id= 348, BeytNo = 4, GhazalNo = 41, Mesra1 = "به آب ديده بشوييم خرقه‌ها از می", Mesra2 = "که موسم ورع و روزگار پرهيز است",},
new Hafez{ Id= 349, BeytNo = 5, GhazalNo = 41, Mesra1 = "مجوی عيش خوش از دور باژگون سپهر", Mesra2 = "که صاف اين سر خم جمله دردی آميز است",},
new Hafez{ Id= 350, BeytNo = 6, GhazalNo = 41, Mesra1 = "سپهر برشده پرويزنيست خون افشان", Mesra2 = "که ريزه‌اش سر کسری و تاج پرويز است",},
new Hafez{ Id= 351, BeytNo = 7, GhazalNo = 41, Mesra1 = "عراق و فارس گرفتی به شعر خوش حافظ", Mesra2 = "بيا که نوبت بغداد و وقت تبريز است",},
new Hafez{ Id= 352, BeytNo = 1, GhazalNo = 42, Mesra1 = "حال دل با تو گفتنم هوس است", Mesra2 = "خبر دل شنفتنم هوس است",},
new Hafez{ Id= 353, BeytNo = 2, GhazalNo = 42, Mesra1 = "طمع خام بين که قصه فاش", Mesra2 = "از رقيبان نهفتنم هوس است",},
new Hafez{ Id= 354, BeytNo = 3, GhazalNo = 42, Mesra1 = "شب قدری چنين عزيز و شريف", Mesra2 = "با تو تا روز خفتنم هوس است",},
new Hafez{ Id= 355, BeytNo = 4, GhazalNo = 42, Mesra1 = "وه که دردانه‌ای چنين نازک", Mesra2 = "در شب تار سفتنم هوس است",},
new Hafez{ Id= 356, BeytNo = 5, GhazalNo = 42, Mesra1 = "ای صبا امشبم مدد فرمای", Mesra2 = "که سحرگه شکفتنم هوس است",},
new Hafez{ Id= 357, BeytNo = 6, GhazalNo = 42, Mesra1 = "از برای شرف به نوک مژه", Mesra2 = "خاک راه تو رفتنم هوس است",},
new Hafez{ Id= 358, BeytNo = 7, GhazalNo = 42, Mesra1 = "همچو حافظ به رغم مدعيان", Mesra2 = "شعر رندانه گفتنم هوس است",},
new Hafez{ Id= 359, BeytNo = 1, GhazalNo = 43, Mesra1 = "صحن بستان ذوق بخش و صحبت ياران خوش است", Mesra2 = "وقت گل خوش باد کز وی وقت ميخواران خوش است",},
new Hafez{ Id= 360, BeytNo = 2, GhazalNo = 43, Mesra1 = "از صبا هر دم مشام جان ما خوش می‌شود", Mesra2 = "آری آری طيب انفاس هواداران خوش است",},
new Hafez{ Id= 361, BeytNo = 3, GhazalNo = 43, Mesra1 = "ناگشوده گل نقاب آهنگ رحلت ساز کرد", Mesra2 = "ناله کن بلبل که گلبانگ دل افکاران خوش است",},
new Hafez{ Id= 362, BeytNo = 4, GhazalNo = 43, Mesra1 = "مرغ خوشخوان را بشارت باد کاندر راه عشق", Mesra2 = "دوست را با ناله شب‌های بيداران خوش است",},
new Hafez{ Id= 363, BeytNo = 5, GhazalNo = 43, Mesra1 = "نيست در بازار عالم خوشدلی ور زان که هست", Mesra2 = "شيوه رندی و خوش باشی عياران خوش است",},
new Hafez{ Id= 364, BeytNo = 6, GhazalNo = 43, Mesra1 = "از زبان سوسن آزاده‌ام آمد به گوش", Mesra2 = "کاندر اين دير کهن کار سبکباران خوش است",},
new Hafez{ Id= 365, BeytNo = 7, GhazalNo = 43, Mesra1 = "حافظا ترک جهان گفتن طريق خوشدليست", Mesra2 = "تا نپنداری که احوال جهان داران خوش است",},
new Hafez{ Id= 366, BeytNo = 1, GhazalNo = 44, Mesra1 = "کنون که بر کف گل جام باده صاف است", Mesra2 = "به صد هزار زبان بلبلش در اوصاف است",},
new Hafez{ Id= 367, BeytNo = 2, GhazalNo = 44, Mesra1 = "بخواه دفتر اشعار و راه صحرا گير", Mesra2 = "چه وقت مدرسه و بحث کشف کشاف است",},
new Hafez{ Id= 368, BeytNo = 3, GhazalNo = 44, Mesra1 = "فقيه مدرسه دی مست بود و فتوی داد", Mesra2 = "که می حرام ولی به ز مال اوقاف است",},
new Hafez{ Id= 369, BeytNo = 4, GhazalNo = 44, Mesra1 = "به درد و صاف تو را حکم نيست خوش درکش", Mesra2 = "که هر چه ساقی ما کرد عين الطاف است",},
new Hafez{ Id= 370, BeytNo = 5, GhazalNo = 44, Mesra1 = "ببر ز خلق و چو عنقا قياس کار بگير", Mesra2 = "که صيت گوشه نشينان ز قاف تا قاف است",},
new Hafez{ Id= 371, BeytNo = 6, GhazalNo = 44, Mesra1 = "حديث مدعيان و خيال همکاران", Mesra2 = "همان حکايت زردوز و بورياباف است",},
new Hafez{ Id= 372, BeytNo = 7, GhazalNo = 44, Mesra1 = "خموش حافظ و اين نکته‌های چون زر سرخ", Mesra2 = "نگاه دار که قلاب شهر صراف است",},
new Hafez{ Id= 373, BeytNo = 1, GhazalNo = 45, Mesra1 = "در اين زمانه رفيقی که خالی از خلل است", Mesra2 = "صراحی می ناب و سفينه غزل است",},
new Hafez{ Id= 374, BeytNo = 2, GhazalNo = 45, Mesra1 = "جريده رو که گذرگاه عافيت تنگ است", Mesra2 = "پياله گير که عمر عزيز بی‌بدل است",},
new Hafez{ Id= 375, BeytNo = 3, GhazalNo = 45, Mesra1 = "نه من ز بی عملی در جهان ملولم و بس", Mesra2 = "ملالت علما هم ز علم بی عمل است",},
new Hafez{ Id= 376, BeytNo = 4, GhazalNo = 45, Mesra1 = "به چشم عقل در اين رهگذار پرآشوب", Mesra2 = "جهان و کار جهان بی‌ثبات و بی‌محل است",},
new Hafez{ Id= 377, BeytNo = 5, GhazalNo = 45, Mesra1 = "بگير طره مه چهره‌ای و قصه مخوان", Mesra2 = "که سعد و نحس ز تاثير زهره و زحل است",},
new Hafez{ Id= 378, BeytNo = 6, GhazalNo = 45, Mesra1 = "دلم اميد فراوان به وصل روی تو داشت", Mesra2 = "ولی اجل به ره عمر رهزن امل است",},
new Hafez{ Id= 379, BeytNo = 7, GhazalNo = 45, Mesra1 = "به هيچ دور نخواهند يافت هشيارش", Mesra2 = "چنين که حافظ ما مست باده ازل است",},
new Hafez{ Id= 380, BeytNo = 1, GhazalNo = 46, Mesra1 = "گل در بر و می در کف و معشوق به کام است", Mesra2 = "سلطان جهانم به چنين روز غلام است",},
new Hafez{ Id= 381, BeytNo = 2, GhazalNo = 46, Mesra1 = "گو شمع مياريد در اين جمع که امشب", Mesra2 = "در مجلس ما ماه رخ دوست تمام است",},
new Hafez{ Id= 382, BeytNo = 3, GhazalNo = 46, Mesra1 = "در مذهب ما باده حلال است وليکن", Mesra2 = "بی روی تو ای سرو گل اندام حرام است",},
new Hafez{ Id= 383, BeytNo = 4, GhazalNo = 46, Mesra1 = "گوشم همه بر قول نی و نغمه چنگ است", Mesra2 = "چشمم همه بر لعل لب و گردش جام است",},
new Hafez{ Id= 384, BeytNo = 5, GhazalNo = 46, Mesra1 = "در مجلس ما عطر مياميز که ما را", Mesra2 = "هر لحظه ز گيسوی تو خوش بوی مشام است",},
new Hafez{ Id= 385, BeytNo = 6, GhazalNo = 46, Mesra1 = "از چاشنی قند مگو هيچ و ز شکر", Mesra2 = "زان رو که مرا از لب شيرين تو کام است",},
new Hafez{ Id= 386, BeytNo = 7, GhazalNo = 46, Mesra1 = "تا گنج غمت در دل ويرانه مقيم است", Mesra2 = "همواره مرا کوی خرابات مقام است",},
new Hafez{ Id= 387, BeytNo = 8, GhazalNo = 46, Mesra1 = "از ننگ چه گويی که مرا نام ز ننگ است", Mesra2 = "وز نام چه پرسی که مرا ننگ ز نام است",},
new Hafez{ Id= 388, BeytNo = 9, GhazalNo = 46, Mesra1 = "ميخواره و سرگشته و رنديم و نظرباز", Mesra2 = "وان کس که چو ما نيست در اين شهر کدام است",},
new Hafez{ Id= 389, BeytNo = 10, GhazalNo = 46, Mesra1 = "با محتسبم عيب مگوييد که او نيز", Mesra2 = "پيوسته چو ما در طلب عيش مدام است",},
new Hafez{ Id= 390, BeytNo = 11, GhazalNo = 46, Mesra1 = "حافظ منشين بی می و معشوق زمانی", Mesra2 = "کايام گل و ياسمن و عيد صيام است",},
new Hafez{ Id= 391, BeytNo = 1, GhazalNo = 47, Mesra1 = "به کوی ميکده هر سالکی که ره دانست", Mesra2 = "دری دگر زدن انديشه تبه دانست",},
new Hafez{ Id= 392, BeytNo = 2, GhazalNo = 47, Mesra1 = "زمانه افسر رندی نداد جز به کسی", Mesra2 = "که سرفرازی عالم در اين کله دانست",},
new Hafez{ Id= 393, BeytNo = 3, GhazalNo = 47, Mesra1 = "بر آستانه ميخانه هر که يافت رهی", Mesra2 = "ز فيض جام می اسرار خانقه دانست",},
new Hafez{ Id= 394, BeytNo = 4, GhazalNo = 47, Mesra1 = "هر آن که راز دو عالم ز خط ساغر خواند", Mesra2 = "رموز جام جم از نقش خاک ره دانست",},
new Hafez{ Id= 395, BeytNo = 5, GhazalNo = 47, Mesra1 = "ورای طاعت ديوانگان ز ما مطلب", Mesra2 = "که شيخ مذهب ما عاقلی گنه دانست",},
new Hafez{ Id= 396, BeytNo = 6, GhazalNo = 47, Mesra1 = "دلم ز نرگس ساقی امان نخواست به جان", Mesra2 = "چرا که شيوه آن ترک دل سيه دانست",},
new Hafez{ Id= 397, BeytNo = 7, GhazalNo = 47, Mesra1 = "ز جور کوکب طالع سحرگهان چشمم", Mesra2 = "چنان گريست که ناهيد ديد و مه دانست",},
new Hafez{ Id= 398, BeytNo = 8, GhazalNo = 47, Mesra1 = "حديث حافظ و ساغر که می‌زند پنهان", Mesra2 = "چه جای محتسب و شحنه پادشه دانست",},
new Hafez{ Id= 399, BeytNo = 9, GhazalNo = 47, Mesra1 = "بلندمرتبه شاهی که نه رواق سپهر", Mesra2 = "نمونه‌ای ز خم طاق بارگه دانست",},
new Hafez{ Id= 400, BeytNo = 1, GhazalNo = 48, Mesra1 = "صوفی از پرتو می راز نهانی دانست", Mesra2 = "گوهر هر کس از اين لعل توانی دانست",},
new Hafez{ Id= 401, BeytNo = 2, GhazalNo = 48, Mesra1 = "قدر مجموعه گل مرغ سحر داند و بس", Mesra2 = "که نه هر کو ورقی خواند معانی دانست",},
new Hafez{ Id= 402, BeytNo = 3, GhazalNo = 48, Mesra1 = "عرضه کردم دو جهان بر دل کارافتاده", Mesra2 = "بجز از عشق تو باقی همه فانی دانست",},
new Hafez{ Id= 403, BeytNo = 4, GhazalNo = 48, Mesra1 = "آن شد اکنون که ز ابنای عوام انديشم", Mesra2 = "محتسب نيز در اين عيش نهانی دانست",},
new Hafez{ Id= 404, BeytNo = 5, GhazalNo = 48, Mesra1 = "دلبر آسايش ما مصلحت وقت نديد", Mesra2 = "ور نه از جانب ما دل نگرانی دانست",},
new Hafez{ Id= 405, BeytNo = 6, GhazalNo = 48, Mesra1 = "سنگ و گل را کند از يمن نظر لعل و عقيق", Mesra2 = "هر که قدر نفس باد يمانی دانست",},
new Hafez{ Id= 406, BeytNo = 7, GhazalNo = 48, Mesra1 = "ای که از دفتر عقل آيت عشق آموزی", Mesra2 = "ترسم اين نکته به تحقيق ندانی دانست",},
new Hafez{ Id= 407, BeytNo = 8, GhazalNo = 48, Mesra1 = "می بياور که ننازد به گل باغ جهان", Mesra2 = "هر که غارتگری باد خزانی دانست",},
new Hafez{ Id= 408, BeytNo = 9, GhazalNo = 48, Mesra1 = "حافظ اين گوهر منظوم که از طبع انگيخت", Mesra2 = "ز اثر تربيت آصف ثانی دانست",},
new Hafez{ Id= 409, BeytNo = 1, GhazalNo = 49, Mesra1 = "روضه خلد برين خلوت درويشان است", Mesra2 = "مايه محتشمی خدمت درويشان است",},
new Hafez{ Id= 410, BeytNo = 2, GhazalNo = 49, Mesra1 = "گنج عزلت که طلسمات عجايب دارد", Mesra2 = "فتح آن در نظر رحمت درويشان است",},
new Hafez{ Id= 411, BeytNo = 3, GhazalNo = 49, Mesra1 = "قصر فردوس که رضوانش به دربانی رفت", Mesra2 = "منظری از چمن نزهت درويشان است",},
new Hafez{ Id= 412, BeytNo = 4, GhazalNo = 49, Mesra1 = "آن چه زر می‌شود از پرتو آن قلب سياه", Mesra2 = "کيمياييست که در صحبت درويشان است",},
new Hafez{ Id= 413, BeytNo = 5, GhazalNo = 49, Mesra1 = "آن که پيشش بنهد تاج تکبر خورشيد", Mesra2 = "کبرياييست که در حشمت درويشان است",},
new Hafez{ Id= 414, BeytNo = 6, GhazalNo = 49, Mesra1 = "دولتی را که نباشد غم از آسيب زوال", Mesra2 = "بی تکلف بشنو دولت درويشان است",},
new Hafez{ Id= 415, BeytNo = 7, GhazalNo = 49, Mesra1 = "خسروان قبله حاجات جهانند ولی", Mesra2 = "سببش بندگی حضرت درويشان است",},
new Hafez{ Id= 416, BeytNo = 8, GhazalNo = 49, Mesra1 = "روی مقصود که شاهان به دعا می‌طلبند", Mesra2 = "مظهرش آينه طلعت درويشان است",},
new Hafez{ Id= 417, BeytNo = 9, GhazalNo = 49, Mesra1 = "از کران تا به کران لشکر ظلم است ولی", Mesra2 = "از ازل تا به ابد فرصت درويشان است",},
new Hafez{ Id= 418, BeytNo = 10, GhazalNo = 49, Mesra1 = "ای توانگر مفروش اين همه نخوت که تو را", Mesra2 = "سر و زر در کنف همت درويشان است",},
new Hafez{ Id= 419, BeytNo = 11, GhazalNo = 49, Mesra1 = "گنج قارون که فرو می‌شود از قهر هنوز", Mesra2 = "خوانده باشی که هم از غيرت درويشان است",},
new Hafez{ Id= 420, BeytNo = 12, GhazalNo = 49, Mesra1 = "من غلام نظر آصف عهدم کو را", Mesra2 = "صورت خواجگی و سيرت درويشان است",},
new Hafez{ Id= 421, BeytNo = 13, GhazalNo = 49, Mesra1 = "حافظ ار آب حيات ازلی می‌خواهی", Mesra2 = "منبعش خاک در خلوت درويشان است",},
new Hafez{ Id= 422, BeytNo = 1, GhazalNo = 50, Mesra1 = "به دام زلف تو دل مبتلای خويشتن است", Mesra2 = "بکش به غمزه که اينش سزای خويشتن است",},
new Hafez{ Id= 423, BeytNo = 2, GhazalNo = 50, Mesra1 = "گرت ز دست برآيد مراد خاطر ما", Mesra2 = "به دست باش که خيری به جای خويشتن است",},
new Hafez{ Id= 424, BeytNo = 3, GhazalNo = 50, Mesra1 = "به جانت ای بت شيرين دهن که همچون شمع", Mesra2 = "شبان تيره مرادم فنای خويشتن است",},
new Hafez{ Id= 425, BeytNo = 4, GhazalNo = 50, Mesra1 = "چو رای عشق زدی با تو گفتم ای بلبل", Mesra2 = "مکن که آن گل خندان برای خويشتن است",},
new Hafez{ Id= 426, BeytNo = 5, GhazalNo = 50, Mesra1 = "به مشک چين و چگل نيست بوی گل محتاج", Mesra2 = "که نافه‌هاش ز بند قبای خويشتن است",},
new Hafez{ Id= 427, BeytNo = 6, GhazalNo = 50, Mesra1 = "مرو به خانه ارباب بی‌مروت دهر", Mesra2 = "که گنج عافيتت در سرای خويشتن است",},
new Hafez{ Id= 428, BeytNo = 7, GhazalNo = 50, Mesra1 = "بسوخت حافظ و در شرط عشقبازی او", Mesra2 = "هنوز بر سر عهد و وفای خويشتن است",},
new Hafez{ Id= 429, BeytNo = 1, GhazalNo = 51, Mesra1 = "لعل سيراب به خون تشنه لب يار من است", Mesra2 = "وز پی ديدن او دادن جان کار من است",},
new Hafez{ Id= 430, BeytNo = 2, GhazalNo = 51, Mesra1 = "شرم از آن چشم سيه بادش و مژگان دراز", Mesra2 = "هر که دل بردن او ديد و در انکار من است",},
new Hafez{ Id= 431, BeytNo = 3, GhazalNo = 51, Mesra1 = "ساروان رخت به دروازه مبر کان سر کو", Mesra2 = "شاهراهيست که منزلگه دلدار من است",},
new Hafez{ Id= 432, BeytNo = 4, GhazalNo = 51, Mesra1 = "بنده طالع خويشم که در اين قحط وفا", Mesra2 = "عشق آن لولی سرمست خريدار من است",},
new Hafez{ Id= 433, BeytNo = 5, GhazalNo = 51, Mesra1 = "طبله عطر گل و زلف عبيرافشانش", Mesra2 = "فيض يک شمه ز بوی خوش عطار من است",},
new Hafez{ Id= 434, BeytNo = 6, GhazalNo = 51, Mesra1 = "باغبان همچو نسيمم ز در خويش مران", Mesra2 = "کب گلزار تو از اشک چو گلنار من است",},
new Hafez{ Id= 435, BeytNo = 7, GhazalNo = 51, Mesra1 = "شربت قند و گلاب از لب يارم فرمود", Mesra2 = "نرگس او که طبيب دل بيمار من است",},
new Hafez{ Id= 436, BeytNo = 8, GhazalNo = 51, Mesra1 = "آن که در طرز غزل نکته به حافظ آموخت", Mesra2 = "يار شيرين سخن نادره گفتار من است",},
new Hafez{ Id= 437, BeytNo = 1, GhazalNo = 52, Mesra1 = "روزگاريست که سودای بتان دين من است", Mesra2 = "غم اين کار نشاط دل غمگين من است",},
new Hafez{ Id= 438, BeytNo = 2, GhazalNo = 52, Mesra1 = "ديدن روی تو را ديده جان بين بايد", Mesra2 = "وين کجا مرتبه چشم جهان بين من است",},
new Hafez{ Id= 439, BeytNo = 3, GhazalNo = 52, Mesra1 = "يار من باش که زيب فلک و زينت دهر", Mesra2 = "از مه روی تو و اشک چو پروين من است",},
new Hafez{ Id= 440, BeytNo = 4, GhazalNo = 52, Mesra1 = "تا مرا عشق تو تعليم سخن گفتن کرد", Mesra2 = "خلق را ورد زبان مدحت و تحسين من است",},
new Hafez{ Id= 441, BeytNo = 5, GhazalNo = 52, Mesra1 = "دولت فقر خدايا به من ارزانی دار", Mesra2 = "کاين کرامت سبب حشمت و تمکين من است",},
new Hafez{ Id= 442, BeytNo = 6, GhazalNo = 52, Mesra1 = "واعظ شحنه شناس اين عظمت گو مفروش", Mesra2 = "زان که منزلگه سلطان دل مسکين من است",},
new Hafez{ Id= 443, BeytNo = 7, GhazalNo = 52, Mesra1 = "يا رب اين کعبه مقصود تماشاگه کيست", Mesra2 = "که مغيلان طريقش گل و نسرين من است",},
new Hafez{ Id= 444, BeytNo = 8, GhazalNo = 52, Mesra1 = "حافظ از حشمت پرويز دگر قصه مخوان", Mesra2 = "که لبش جرعه کش خسرو شيرين من است",},
new Hafez{ Id= 445, BeytNo = 1, GhazalNo = 53, Mesra1 = "منم که گوشه ميخانه خانقاه من است", Mesra2 = "دعای پير مغان ورد صبحگاه من است",},
new Hafez{ Id= 446, BeytNo = 2, GhazalNo = 53, Mesra1 = "گرم ترانه چنگ صبوح نيست چه باک", Mesra2 = "نوای من به سحر آه عذرخواه من است",},
new Hafez{ Id= 447, BeytNo = 3, GhazalNo = 53, Mesra1 = "ز پادشاه و گدا فارغم بحمدالله", Mesra2 = "گدای خاک در دوست پادشاه من است",},
new Hafez{ Id= 448, BeytNo = 4, GhazalNo = 53, Mesra1 = "غرض ز مسجد و ميخانه‌ام وصال شماست", Mesra2 = "جز اين خيال ندارم خدا گواه من است",},
new Hafez{ Id= 449, BeytNo = 5, GhazalNo = 53, Mesra1 = "مگر به تيغ اجل خيمه برکنم ور نی", Mesra2 = "رميدن از در دولت نه رسم و راه من است",},
new Hafez{ Id= 450, BeytNo = 6, GhazalNo = 53, Mesra1 = "از آن زمان که بر اين آستان نهادم روی", Mesra2 = "فراز مسند خورشيد تکيه گاه من است",},
new Hafez{ Id= 451, BeytNo = 7, GhazalNo = 53, Mesra1 = "گناه اگر چه نبود اختيار ما حافظ", Mesra2 = "تو در طريق ادب باش و گو گناه من است",},
new Hafez{ Id= 452, BeytNo = 1, GhazalNo = 54, Mesra1 = "ز گريه مردم چشمم نشسته در خون است", Mesra2 = "ببين که در طلبت حال مردمان چون است",},
new Hafez{ Id= 453, BeytNo = 2, GhazalNo = 54, Mesra1 = "به ياد لعل تو و چشم مست ميگونت", Mesra2 = "ز جام غم می لعلی که می‌خورم خون است",},
new Hafez{ Id= 454, BeytNo = 3, GhazalNo = 54, Mesra1 = "ز مشرق سر کو آفتاب طلعت تو", Mesra2 = "اگر طلوع کند طالعم همايون است",},
new Hafez{ Id= 455, BeytNo = 4, GhazalNo = 54, Mesra1 = "حکايت لب شيرين کلام فرهاد است", Mesra2 = "شکنج طره ليلی مقام مجنون است",},
new Hafez{ Id= 456, BeytNo = 5, GhazalNo = 54, Mesra1 = "دلم بجو که قدت همچو سرو دلجوی است", Mesra2 = "سخن بگو که کلامت لطيف و موزون است",},
new Hafez{ Id= 457, BeytNo = 6, GhazalNo = 54, Mesra1 = "ز دور باده به جان راحتی رسان ساقی", Mesra2 = "که رنج خاطرم از جور دور گردون است",},
new Hafez{ Id= 458, BeytNo = 7, GhazalNo = 54, Mesra1 = "از آن دمی که ز چشمم برفت رود عزيز", Mesra2 = "کنار دامن من همچو رود جيحون است",},
new Hafez{ Id= 459, BeytNo = 8, GhazalNo = 54, Mesra1 = "چگونه شاد شود اندرون غمگينم", Mesra2 = "به اختيار که از اختيار بيرون است",},
new Hafez{ Id= 460, BeytNo = 9, GhazalNo = 54, Mesra1 = "ز بيخودی طلب يار می‌کند حافظ", Mesra2 = "چو مفلسی که طلبکار گنج قارون است",},
new Hafez{ Id= 461, BeytNo = 1, GhazalNo = 55, Mesra1 = "خم زلف تو دام کفر و دين است", Mesra2 = "ز کارستان او يک شمه اين است",},
new Hafez{ Id= 462, BeytNo = 2, GhazalNo = 55, Mesra1 = "جمالت معجز حسن است ليکن", Mesra2 = "حديث غمزه‌ات سحر مبين است",},
new Hafez{ Id= 463, BeytNo = 3, GhazalNo = 55, Mesra1 = "ز چشم شوخ تو جان کی توان برد", Mesra2 = "که دايم با کمان اندر کمين است",},
new Hafez{ Id= 464, BeytNo = 4, GhazalNo = 55, Mesra1 = "بر آن چشم سيه صد آفرين باد", Mesra2 = "که در عاشق کشی سحرآفرين است",},
new Hafez{ Id= 465, BeytNo = 5, GhazalNo = 55, Mesra1 = "عجب علميست علم هيت عشق", Mesra2 = "که چرخ هشتمش هفتم زمين است",},
new Hafez{ Id= 466, BeytNo = 6, GhazalNo = 55, Mesra1 = "تو پنداری که بدگو رفت و جان برد", Mesra2 = "حسابش با کرام الکاتبين است",},
new Hafez{ Id= 467, BeytNo = 7, GhazalNo = 55, Mesra1 = "مشو حافظ ز کيد زلفش ايمن", Mesra2 = "که دل برد و کنون دربند دين است",},
new Hafez{ Id= 468, BeytNo = 1, GhazalNo = 56, Mesra1 = "دل سراپرده محبت اوست", Mesra2 = "ديده آيينه دار طلعت اوست",},
new Hafez{ Id= 469, BeytNo = 2, GhazalNo = 56, Mesra1 = "من که سر درنياورم به دو کون", Mesra2 = "گردنم زير بار منت اوست",},
new Hafez{ Id= 470, BeytNo = 3, GhazalNo = 56, Mesra1 = "تو و طوبی و ما و قامت يار", Mesra2 = "فکر هر کس به قدر همت اوست",},
new Hafez{ Id= 471, BeytNo = 4, GhazalNo = 56, Mesra1 = "گر من آلوده دامنم چه عجب", Mesra2 = "همه عالم گواه عصمت اوست",},
new Hafez{ Id= 472, BeytNo = 5, GhazalNo = 56, Mesra1 = "من که باشم در آن حرم که صبا", Mesra2 = "پرده دار حريم حرمت اوست",},
new Hafez{ Id= 473, BeytNo = 6, GhazalNo = 56, Mesra1 = "بی خيالش مباد منظر چشم", Mesra2 = "زان که اين گوشه جای خلوت اوست",},
new Hafez{ Id= 474, BeytNo = 7, GhazalNo = 56, Mesra1 = "هر گل نو که شد چمن آرای", Mesra2 = "ز اثر رنگ و بوی صحبت اوست",},
new Hafez{ Id= 475, BeytNo = 8, GhazalNo = 56, Mesra1 = "دور مجنون گذشت و نوبت ماست", Mesra2 = "هر کسی پنج روز نوبت اوست",},
new Hafez{ Id= 476, BeytNo = 9, GhazalNo = 56, Mesra1 = "ملکت عاشقی و گنج طرب", Mesra2 = "هر چه دارم ز يمن همت اوست",},
new Hafez{ Id= 477, BeytNo = 10, GhazalNo = 56, Mesra1 = "من و دل گر فدا شديم چه باک", Mesra2 = "غرض اندر ميان سلامت اوست",},
new Hafez{ Id= 478, BeytNo = 11, GhazalNo = 56, Mesra1 = "فقر ظاهر مبين که حافظ را", Mesra2 = "سينه گنجينه محبت اوست",},
new Hafez{ Id= 479, BeytNo = 1, GhazalNo = 57, Mesra1 = "آن سيه چرده که شيرينی عالم با اوست", Mesra2 = "چشم ميگون لب خندان دل خرم با اوست",},
new Hafez{ Id= 480, BeytNo = 2, GhazalNo = 57, Mesra1 = "گر چه شيرين دهنان پادشهانند ولی", Mesra2 = "او سليمان زمان است که خاتم با اوست",},
new Hafez{ Id= 481, BeytNo = 3, GhazalNo = 57, Mesra1 = "روی خوب است و کمال هنر و دامن پاک", Mesra2 = "لاجرم همت پاکان دو عالم با اوست",},
new Hafez{ Id= 482, BeytNo = 4, GhazalNo = 57, Mesra1 = "خال مشکين که بدان عارض گندمگون است", Mesra2 = "سر آن دانه که شد رهزن آدم با اوست",},
new Hafez{ Id= 483, BeytNo = 5, GhazalNo = 57, Mesra1 = "دلبرم عزم سفر کرد خدا را ياران", Mesra2 = "چه کنم با دل مجروح که مرهم با اوست",},
new Hafez{ Id= 484, BeytNo = 6, GhazalNo = 57, Mesra1 = "با که اين نکته توان گفت که آن سنگين دل", Mesra2 = "کشت ما را و دم عيسی مريم با اوست",},
new Hafez{ Id= 485, BeytNo = 7, GhazalNo = 57, Mesra1 = "حافظ از معتقدان است گرامی دارش", Mesra2 = "زان که بخشايش بس روح مکرم با اوست",},
new Hafez{ Id= 486, BeytNo = 1, GhazalNo = 58, Mesra1 = "سر ارادت ما و آستان حضرت دوست", Mesra2 = "که هر چه بر سر ما می‌رود ارادت اوست",},
new Hafez{ Id= 487, BeytNo = 2, GhazalNo = 58, Mesra1 = "نظير دوست نديدم اگر چه از مه و مهر", Mesra2 = "نهادم آينه‌ها در مقابل رخ دوست",},
new Hafez{ Id= 488, BeytNo = 3, GhazalNo = 58, Mesra1 = "صبا ز حال دل تنگ ما چه شرح دهد", Mesra2 = "که چون شکنج ورق‌های غنچه تو بر توست",},
new Hafez{ Id= 489, BeytNo = 4, GhazalNo = 58, Mesra1 = "نه من سبوکش اين دير رندسوزم و بس", Mesra2 = "بسا سرا که در اين کارخانه سنگ و سبوست",},
new Hafez{ Id= 490, BeytNo = 5, GhazalNo = 58, Mesra1 = "مگر تو شانه زدی زلف عنبرافشان را", Mesra2 = "که باد غاليه سا گشت و خاک عنبربوست",},
new Hafez{ Id= 491, BeytNo = 6, GhazalNo = 58, Mesra1 = "نثار روی تو هر برگ گل که در چمن است", Mesra2 = "فدای قد تو هر سروبن که بر لب جوست",},
new Hafez{ Id= 492, BeytNo = 7, GhazalNo = 58, Mesra1 = "زبان ناطقه در وصف شوق نالان است", Mesra2 = "چه جای کلک بريده زبان بيهده گوست",},
new Hafez{ Id= 493, BeytNo = 8, GhazalNo = 58, Mesra1 = "رخ تو در دلم آمد مراد خواهم يافت", Mesra2 = "چرا که حال نکو در قفای فال نکوست",},
new Hafez{ Id= 494, BeytNo = 9, GhazalNo = 58, Mesra1 = "نه اين زمان دل حافظ در آتش هوس است", Mesra2 = "که داغدار ازل همچو لاله خودروست",},
new Hafez{ Id= 495, BeytNo = 1, GhazalNo = 59, Mesra1 = "دارم اميد عاطفتی از جانب دوست", Mesra2 = "کردم جنايتی و اميدم به عفو اوست",},
new Hafez{ Id= 496, BeytNo = 2, GhazalNo = 59, Mesra1 = "دانم که بگذرد ز سر جرم من که او", Mesra2 = "گر چه پريوش است وليکن فرشته خوست",},
new Hafez{ Id= 497, BeytNo = 3, GhazalNo = 59, Mesra1 = "چندان گريستم که هر کس که برگذشت", Mesra2 = "در اشک ما چو ديد روان گفت کاين چه جوست",},
new Hafez{ Id= 498, BeytNo = 4, GhazalNo = 59, Mesra1 = "هيچ است آن دهان و نبينم از او نشان", Mesra2 = "موی است آن ميان و ندانم که آن چه موست",},
new Hafez{ Id= 499, BeytNo = 5, GhazalNo = 59, Mesra1 = "دارم عجب ز نقش خيالش که چون نرفت", Mesra2 = "از ديده‌ام که دم به دمش کار شست و شوست",},
new Hafez{ Id= 500, BeytNo = 6, GhazalNo = 59, Mesra1 = "بی گفت و گوی زلف تو دل را همی‌کشد", Mesra2 = "با زلف دلکش تو که را روی گفت و گوست",},
new Hafez{ Id= 501, BeytNo = 7, GhazalNo = 59, Mesra1 = "عمريست تا ز زلف تو بويی شنيده‌ام", Mesra2 = "زان بوی در مشام دل من هنوز بوست",},
new Hafez{ Id= 502, BeytNo = 8, GhazalNo = 59, Mesra1 = "حافظ بد است حال پريشان تو ولی", Mesra2 = "بر بوی زلف يار پريشانيت نکوست",},
new Hafez{ Id= 503, BeytNo = 1, GhazalNo = 60, Mesra1 = "آن پيک نامور که رسيد از ديار دوست", Mesra2 = "آورد حرز جان ز خط مشکبار دوست",},
new Hafez{ Id= 504, BeytNo = 2, GhazalNo = 60, Mesra1 = "خوش می‌دهد نشان جلال و جمال يار", Mesra2 = "خوش می‌کند حکايت عز و وقار دوست",},
new Hafez{ Id= 505, BeytNo = 3, GhazalNo = 60, Mesra1 = "دل دادمش به مژده و خجلت همی‌برم", Mesra2 = "زين نقد قلب خويش که کردم نثار دوست",},
new Hafez{ Id= 506, BeytNo = 4, GhazalNo = 60, Mesra1 = "شکر خدا که از مدد بخت کارساز", Mesra2 = "بر حسب آرزوست همه کار و بار دوست",},
new Hafez{ Id= 507, BeytNo = 5, GhazalNo = 60, Mesra1 = "سير سپهر و دور قمر را چه اختيار", Mesra2 = "در گردشند بر حسب اختيار دوست",},
new Hafez{ Id= 508, BeytNo = 6, GhazalNo = 60, Mesra1 = "گر باد فتنه هر دو جهان را به هم زند", Mesra2 = "ما و چراغ چشم و ره انتظار دوست",},
new Hafez{ Id= 509, BeytNo = 7, GhazalNo = 60, Mesra1 = "کحل الجواهری به من آر ای نسيم صبح", Mesra2 = "زان خاک نيکبخت که شد رهگذار دوست",},
new Hafez{ Id= 510, BeytNo = 8, GhazalNo = 60, Mesra1 = "ماييم و آستانه عشق و سر نياز", Mesra2 = "تا خواب خوش که را برد اندر کنار دوست",},
new Hafez{ Id= 511, BeytNo = 9, GhazalNo = 60, Mesra1 = "دشمن به قصد حافظ اگر دم زند چه باک", Mesra2 = "منت خدای را که نيم شرمسار دوست",},
new Hafez{ Id= 512, BeytNo = 1, GhazalNo = 61, Mesra1 = "صبا اگر گذری افتدت به کشور دوست", Mesra2 = "بيار نفحه‌ای از گيسوی معنبر دوست",},
new Hafez{ Id= 513, BeytNo = 2, GhazalNo = 61, Mesra1 = "به جان او که به شکرانه جان برافشانم", Mesra2 = "اگر به سوی من آری پيامی از بر دوست",},
new Hafez{ Id= 514, BeytNo = 3, GhazalNo = 61, Mesra1 = "و گر چنان که در آن حضرتت نباشد بار", Mesra2 = "برای ديده بياور غباری از در دوست",},
new Hafez{ Id= 515, BeytNo = 4, GhazalNo = 61, Mesra1 = "من گدا و تمنای وصل او هيهات", Mesra2 = "مگر به خواب ببينم خيال منظر دوست",},
new Hafez{ Id= 516, BeytNo = 5, GhazalNo = 61, Mesra1 = "دل صنوبريم همچو بيد لرزان است", Mesra2 = "ز حسرت قد و بالای چون صنوبر دوست",},
new Hafez{ Id= 517, BeytNo = 6, GhazalNo = 61, Mesra1 = "اگر چه دوست به چيزی نمی‌خرد ما را", Mesra2 = "به عالمی نفروشيم مويی از سر دوست",},
new Hafez{ Id= 518, BeytNo = 7, GhazalNo = 61, Mesra1 = "چه باشد ار شود از بند غم دلش آزاد", Mesra2 = "چو هست حافظ مسکين غلام و چاکر دوست",},
new Hafez{ Id= 519, BeytNo = 1, GhazalNo = 62, Mesra1 = "مرحبا ای پيک مشتاقان بده پيغام دوست", Mesra2 = "تا کنم جان از سر رغبت فدای نام دوست",},
new Hafez{ Id= 520, BeytNo = 2, GhazalNo = 62, Mesra1 = "واله و شيداست دايم همچو بلبل در قفس", Mesra2 = "طوطی طبعم ز عشق شکر و بادام دوست",},
new Hafez{ Id= 521, BeytNo = 3, GhazalNo = 62, Mesra1 = "زلف او دام است و خالش دانه آن دام و من", Mesra2 = "بر اميد دانه‌ای افتاده‌ام در دام دوست",},
new Hafez{ Id= 522, BeytNo = 4, GhazalNo = 62, Mesra1 = "سر ز مستی برنگيرد تا به صبح روز حشر", Mesra2 = "هر که چون من در ازل يک جرعه خورد از جام دوست",},
new Hafez{ Id= 523, BeytNo = 5, GhazalNo = 62, Mesra1 = "بس نگويم شمه‌ای از شرح شوق خود از آنک", Mesra2 = "دردسر باشد نمودن بيش از اين ابرام دوست",},
new Hafez{ Id= 524, BeytNo = 6, GhazalNo = 62, Mesra1 = "گر دهد دستم کشم در ديده همچون توتيا", Mesra2 = "خاک راهی کان مشرف گردد از اقدام دوست",},
new Hafez{ Id= 525, BeytNo = 7, GhazalNo = 62, Mesra1 = "ميل من سوی وصال و قصد او سوی فراق", Mesra2 = "ترک کام خود گرفتم تا برآيد کام دوست",},
new Hafez{ Id= 526, BeytNo = 8, GhazalNo = 62, Mesra1 = "حافظ اندر درد او می‌سوز و بی‌درمان بساز", Mesra2 = "زان که درمانی ندارد درد بی‌آرام دوست",},
new Hafez{ Id= 527, BeytNo = 1, GhazalNo = 63, Mesra1 = "روی تو کس نديد و هزارت رقيب هست", Mesra2 = "در غنچه‌ای هنوز و صدت عندليب هست",},
new Hafez{ Id= 528, BeytNo = 2, GhazalNo = 63, Mesra1 = "گر آمدم به کوی تو چندان غريب نيست", Mesra2 = "چون من در آن ديار هزاران غريب هست",},
new Hafez{ Id= 529, BeytNo = 3, GhazalNo = 63, Mesra1 = "در عشق خانقاه و خرابات فرق نيست", Mesra2 = "هر جا که هست پرتو روی حبيب هست",},
new Hafez{ Id= 530, BeytNo = 4, GhazalNo = 63, Mesra1 = "آن جا که کار صومعه را جلوه می‌دهند", Mesra2 = "ناقوس دير راهب و نام صليب هست",},
new Hafez{ Id= 531, BeytNo = 5, GhazalNo = 63, Mesra1 = "عاشق که شد که يار به حالش نظر نکرد", Mesra2 = "ای خواجه درد نيست وگرنه طبيب هست",},
new Hafez{ Id= 532, BeytNo = 6, GhazalNo = 63, Mesra1 = "فرياد حافظ اين همه آخر به هرزه نيست", Mesra2 = "هم قصه‌ای غريب و حديثی عجيب هست",},
new Hafez{ Id= 533, BeytNo = 1, GhazalNo = 64, Mesra1 = "اگر چه عرض هنر پيش يار بی‌ادبيست", Mesra2 = "زبان خموش وليکن دهان پر از عربيست",},
new Hafez{ Id= 534, BeytNo = 2, GhazalNo = 64, Mesra1 = "پری نهفته رخ و ديو در کرشمه حسن", Mesra2 = "بسوخت ديده ز حيرت که اين چه بوالعجبيست",},
new Hafez{ Id= 535, BeytNo = 3, GhazalNo = 64, Mesra1 = "در اين چمن گل بی خار کس نچيد آری", Mesra2 = "چراغ مصطفوی با شرار بولهبيست",},
new Hafez{ Id= 536, BeytNo = 4, GhazalNo = 64, Mesra1 = "سبب مپرس که چرخ از چه سفله پرور شد", Mesra2 = "که کام بخشی او را بهانه بی سببيست",},
new Hafez{ Id= 537, BeytNo = 5, GhazalNo = 64, Mesra1 = "به نيم جو نخرم طاق خانقاه و رباط", Mesra2 = "مرا که مصطبه ايوان و پای خم طنبيست",},
new Hafez{ Id= 538, BeytNo = 6, GhazalNo = 64, Mesra1 = "جمال دختر رز نور چشم ماست مگر", Mesra2 = "که در نقاب زجاجی و پرده عنبيست",},
new Hafez{ Id= 539, BeytNo = 7, GhazalNo = 64, Mesra1 = "هزار عقل و ادب داشتم من ای خواجه", Mesra2 = "کنون که مست خرابم صلاح بی‌ادبيست",},
new Hafez{ Id= 540, BeytNo = 8, GhazalNo = 64, Mesra1 = "بيار می که چو حافظ هزارم استظهار", Mesra2 = "به گريه سحری و نياز نيم شبيست",},
new Hafez{ Id= 541, BeytNo = 1, GhazalNo = 65, Mesra1 = "خوشتر ز عيش و صحبت و باغ و بهار چيست", Mesra2 = "ساقی کجاست گو سبب انتظار چيست",},
new Hafez{ Id= 542, BeytNo = 2, GhazalNo = 65, Mesra1 = "هر وقت خوش که دست دهد مغتنم شمار", Mesra2 = "کس را وقوف نيست که انجام کار چيست",},
new Hafez{ Id= 543, BeytNo = 3, GhazalNo = 65, Mesra1 = "پيوند عمر بسته به موييست هوش دار", Mesra2 = "غمخوار خويش باش غم روزگار چيست",},
new Hafez{ Id= 544, BeytNo = 4, GhazalNo = 65, Mesra1 = "معنی آب زندگی و روضه ارم", Mesra2 = "جز طرف جويبار و می خوشگوار چيست",},
new Hafez{ Id= 545, BeytNo = 5, GhazalNo = 65, Mesra1 = "مستور و مست هر دو چو از يک قبيله‌اند", Mesra2 = "ما دل به عشوه که دهيم اختيار چيست",},
new Hafez{ Id= 546, BeytNo = 6, GhazalNo = 65, Mesra1 = "راز درون پرده چه داند فلک خموش", Mesra2 = "ای مدعی نزاع تو با پرده دار چيست",},
new Hafez{ Id= 547, BeytNo = 7, GhazalNo = 65, Mesra1 = "سهو و خطای بنده گرش اعتبار نيست", Mesra2 = "معنی عفو و رحمت آمرزگار چيست",},
new Hafez{ Id= 548, BeytNo = 8, GhazalNo = 65, Mesra1 = "زاهد شراب کوثر و حافظ پياله خواست", Mesra2 = "تا در ميانه خواسته کردگار چيست",},
new Hafez{ Id= 549, BeytNo = 1, GhazalNo = 66, Mesra1 = "بنال بلبل اگر با منت سر ياريست", Mesra2 = "که ما دو عاشق زاريم و کار ما زاريست",},
new Hafez{ Id= 550, BeytNo = 2, GhazalNo = 66, Mesra1 = "در آن زمين که نسيمی وزد ز طره دوست", Mesra2 = "چه جای دم زدن نافه‌های تاتاريست",},
new Hafez{ Id= 551, BeytNo = 3, GhazalNo = 66, Mesra1 = "بيار باده که رنگين کنيم جامه زرق", Mesra2 = "که مست جام غروريم و نام هشياريست",},
new Hafez{ Id= 552, BeytNo = 4, GhazalNo = 66, Mesra1 = "خيال زلف تو پختن نه کار هر خاميست", Mesra2 = "که زير سلسله رفتن طريق عياريست",},
new Hafez{ Id= 553, BeytNo = 5, GhazalNo = 66, Mesra1 = "لطيفه‌ايست نهانی که عشق از او خيزد", Mesra2 = "که نام آن نه لب لعل و خط زنگاريست",},
new Hafez{ Id= 554, BeytNo = 6, GhazalNo = 66, Mesra1 = "جمال شخص نه چشم است و زلف و عارض و خال", Mesra2 = "هزار نکته در اين کار و بار دلداريست",},
new Hafez{ Id= 555, BeytNo = 7, GhazalNo = 66, Mesra1 = "قلندران حقيقت به نيم جو نخرند", Mesra2 = "قبای اطلس آن کس که از هنر عاريست",},
new Hafez{ Id= 556, BeytNo = 8, GhazalNo = 66, Mesra1 = "بر آستان تو مشکل توان رسيد آری", Mesra2 = "عروج بر فلک سروری به دشواريست",},
new Hafez{ Id= 557, BeytNo = 9, GhazalNo = 66, Mesra1 = "سحر کرشمه چشمت به خواب می‌ديدم", Mesra2 = "زهی مراتب خوابی که به ز بيداريست",},
new Hafez{ Id= 558, BeytNo = 10, GhazalNo = 66, Mesra1 = "دلش به ناله ميازار و ختم کن حافظ", Mesra2 = "که رستگاری جاويد در کم آزاريست",},
new Hafez{ Id= 559, BeytNo = 1, GhazalNo = 67, Mesra1 = "يا رب اين شمع دل افروز ز کاشانه کيست", Mesra2 = "جان ما سوخت بپرسيد که جانانه کيست",},
new Hafez{ Id= 560, BeytNo = 2, GhazalNo = 67, Mesra1 = "حاليا خانه برانداز دل و دين من است", Mesra2 = "تا در آغوش که می‌خسبد و همخانه کيست",},
new Hafez{ Id= 561, BeytNo = 3, GhazalNo = 67, Mesra1 = "باده لعل لبش کز لب من دور مباد", Mesra2 = "راح روح که و پيمان ده پيمانه کيست",},
new Hafez{ Id= 562, BeytNo = 4, GhazalNo = 67, Mesra1 = "دولت صحبت آن شمع سعادت پرتو", Mesra2 = "بازپرسيد خدا را که به پروانه کيست",},
new Hafez{ Id= 563, BeytNo = 5, GhazalNo = 67, Mesra1 = "می‌دهد هر کسش افسونی و معلوم نشد", Mesra2 = "که دل نازک او مايل افسانه کيست",},
new Hafez{ Id= 564, BeytNo = 6, GhazalNo = 67, Mesra1 = "يا رب آن شاهوش ماه رخ زهره جبين", Mesra2 = "در يکتای که و گوهر يک دانه کيست",},
new Hafez{ Id= 565, BeytNo = 7, GhazalNo = 67, Mesra1 = "گفتم آه از دل ديوانه حافظ بی تو", Mesra2 = "زير لب خنده زنان گفت که ديوانه کيست",},
new Hafez{ Id= 566, BeytNo = 1, GhazalNo = 68, Mesra1 = "ماهم اين هفته برون رفت و به چشمم ساليست", Mesra2 = "حال هجران تو چه دانی که چه مشکل حاليست",},
new Hafez{ Id= 567, BeytNo = 2, GhazalNo = 68, Mesra1 = "مردم ديده ز لطف رخ او در رخ او", Mesra2 = "عکس خود ديد گمان برد که مشکين خاليست",},
new Hafez{ Id= 568, BeytNo = 3, GhazalNo = 68, Mesra1 = "می‌چکد شير هنوز از لب همچون شکرش", Mesra2 = "گر چه در شيوه گری هر مژه‌اش قتاليست",},
new Hafez{ Id= 569, BeytNo = 4, GhazalNo = 68, Mesra1 = "ای که انگشت نمايی به کرم در همه شهر", Mesra2 = "وه که در کار غريبان عجبت اهماليست",},
new Hafez{ Id= 570, BeytNo = 5, GhazalNo = 68, Mesra1 = "بعد از اينم نبود شابه در جوهر فرد", Mesra2 = "که دهان تو در اين نکته خوش استدلاليست",},
new Hafez{ Id= 571, BeytNo = 6, GhazalNo = 68, Mesra1 = "مژده دادند که بر ما گذری خواهی کرد", Mesra2 = "نيت خير مگردان که مبارک فاليست",},
new Hafez{ Id= 572, BeytNo = 7, GhazalNo = 68, Mesra1 = "کوه اندوه فراقت به چه حالت بکشد", Mesra2 = "حافظ خسته که از ناله تنش چون ناليست",},
new Hafez{ Id= 573, BeytNo = 1, GhazalNo = 69, Mesra1 = "کس نيست که افتاده آن زلف دوتا نيست", Mesra2 = "در رهگذر کيست که دامی ز بلا نيست",},
new Hafez{ Id= 574, BeytNo = 2, GhazalNo = 69, Mesra1 = "چون چشم تو دل می‌برد از گوشه نشينان", Mesra2 = "همراه تو بودن گنه از جانب ما نيست",},
new Hafez{ Id= 575, BeytNo = 3, GhazalNo = 69, Mesra1 = "روی تو مگر آينه لطف الهيست", Mesra2 = "حقا که چنين است و در اين روی و ريا نيست",},
new Hafez{ Id= 576, BeytNo = 4, GhazalNo = 69, Mesra1 = "نرگس طلبد شيوه چشم تو زهی چشم", Mesra2 = "مسکين خبرش از سر و در ديده حيا نيست",},
new Hafez{ Id= 577, BeytNo = 5, GhazalNo = 69, Mesra1 = "از بهر خدا زلف مپيرای که ما را", Mesra2 = "شب نيست که صد عربده با باد صبا نيست",},
new Hafez{ Id= 578, BeytNo = 6, GhazalNo = 69, Mesra1 = "بازآی که بی روی تو ای شمع دل افروز", Mesra2 = "در بزم حريفان اثر نور و صفا نيست",},
new Hafez{ Id= 579, BeytNo = 7, GhazalNo = 69, Mesra1 = "تيمار غريبان اثر ذکر جميل است", Mesra2 = "جانا مگر اين قاعده در شهر شما نيست",},
new Hafez{ Id= 580, BeytNo = 8, GhazalNo = 69, Mesra1 = "دی می‌شد و گفتم صنما عهد به جای آر", Mesra2 = "گفتا غلطی خواجه در اين عهد وفا نيست",},
new Hafez{ Id= 581, BeytNo = 9, GhazalNo = 69, Mesra1 = "گر پير مغان مرشد من شد چه تفاوت", Mesra2 = "در هيچ سری نيست که سری ز خدا نيست",},
new Hafez{ Id= 582, BeytNo = 10, GhazalNo = 69, Mesra1 = "عاشق چه کند گر نکشد بار ملامت", Mesra2 = "با هيچ دلاور سپر تير قضا نيست",},
new Hafez{ Id= 583, BeytNo = 11, GhazalNo = 69, Mesra1 = "در صومعه زاهد و در خلوت صوفی", Mesra2 = "جز گوشه ابروی تو محراب دعا نيست",},
new Hafez{ Id= 584, BeytNo = 12, GhazalNo = 69, Mesra1 = "ای چنگ فروبرده به خون دل حافظ", Mesra2 = "فکرت مگر از غيرت قرآن و خدا نيست",},
new Hafez{ Id= 585, BeytNo = 1, GhazalNo = 70, Mesra1 = "مردم ديده ما جز به رخت ناظر نيست", Mesra2 = "دل سرگشته ما غير تو را ذاکر نيست",},
new Hafez{ Id= 586, BeytNo = 2, GhazalNo = 70, Mesra1 = "اشکم احرام طواف حرمت می‌بندد", Mesra2 = "گر چه از خون دل ريش دمی طاهر نيست",},
new Hafez{ Id= 587, BeytNo = 3, GhazalNo = 70, Mesra1 = "بسته دام و قفس باد چو مرغ وحشی", Mesra2 = "طاير سدره اگر در طلبت طاير نيست",},
new Hafez{ Id= 588, BeytNo = 4, GhazalNo = 70, Mesra1 = "عاشق مفلس اگر قلب دلش کرد نثار", Mesra2 = "مکنش عيب که بر نقد روان قادر نيست",},
new Hafez{ Id= 589, BeytNo = 5, GhazalNo = 70, Mesra1 = "عاقبت دست بدان سرو بلندش برسد", Mesra2 = "هر که را در طلبت همت او قاصر نيست",},
new Hafez{ Id= 590, BeytNo = 6, GhazalNo = 70, Mesra1 = "از روان بخشی عيسی نزنم دم هرگز", Mesra2 = "زان که در روح فزايی چو لبت ماهر نيست",},
new Hafez{ Id= 591, BeytNo = 7, GhazalNo = 70, Mesra1 = "من که در آتش سودای تو آهی نزنم", Mesra2 = "کی توان گفت که بر داغ دلم صابر نيست",},
new Hafez{ Id= 592, BeytNo = 8, GhazalNo = 70, Mesra1 = "روز اول که سر زلف تو ديدم گفتم", Mesra2 = "که پريشانی اين سلسله را آخر نيست",},
new Hafez{ Id= 593, BeytNo = 9, GhazalNo = 70, Mesra1 = "سر پيوند تو تنها نه دل حافظ راست", Mesra2 = "کيست آن کش سر پيوند تو در خاطر نيست",},
new Hafez{ Id= 594, BeytNo = 1, GhazalNo = 71, Mesra1 = "زاهد ظاهرپرست از حال ما آگاه نيست", Mesra2 = "در حق ما هر چه گويد جای هيچ اکراه نيست",},
new Hafez{ Id= 595, BeytNo = 2, GhazalNo = 71, Mesra1 = "در طريقت هر چه پيش سالک آيد خير اوست", Mesra2 = "در صراط مستقيم ای دل کسی گمراه نيست",},
new Hafez{ Id= 596, BeytNo = 3, GhazalNo = 71, Mesra1 = "تا چه بازی رخ نمايد بيدقی خواهيم راند", Mesra2 = "عرصه شطرنج رندان را مجال شاه نيست",},
new Hafez{ Id= 597, BeytNo = 4, GhazalNo = 71, Mesra1 = "چيست اين سقف بلند ساده بسيارنقش", Mesra2 = "زين معما هيچ دانا در جهان آگاه نيست",},
new Hafez{ Id= 598, BeytNo = 5, GhazalNo = 71, Mesra1 = "اين چه استغناست يا رب وين چه قادر حکمت است", Mesra2 = "کاين همه زخم نهان هست و مجال آه نيست",},
new Hafez{ Id= 599, BeytNo = 6, GhazalNo = 71, Mesra1 = "صاحب ديوان ما گويی نمی‌داند حساب", Mesra2 = "کاندر اين طغرا نشان حسبه لله نيست",},
new Hafez{ Id= 600, BeytNo = 7, GhazalNo = 71, Mesra1 = "هر که خواهد گو بيا و هر چه خواهد گو بگو", Mesra2 = "کبر و ناز و حاجب و دربان بدين درگاه نيست",},
new Hafez{ Id= 601, BeytNo = 8, GhazalNo = 71, Mesra1 = "بر در ميخانه رفتن کار يک رنگان بود", Mesra2 = "خودفروشان را به کوی می فروشان راه نيست",},
new Hafez{ Id= 602, BeytNo = 9, GhazalNo = 71, Mesra1 = "هر چه هست از قامت ناساز بی اندام ماست", Mesra2 = "ور نه تشريف تو بر بالای کس کوتاه نيست",},
new Hafez{ Id= 603, BeytNo = 10, GhazalNo = 71, Mesra1 = "بنده پير خراباتم که لطفش دايم است", Mesra2 = "ور نه لطف شيخ و زاهد گاه هست و گاه نيست",},
new Hafez{ Id= 604, BeytNo = 11, GhazalNo = 71, Mesra1 = "حافظ ار بر صدر ننشيند ز عالی مشربيست", Mesra2 = "عاشق دردی کش اندربند مال و جاه نيست",},
new Hafez{ Id= 605, BeytNo = 1, GhazalNo = 72, Mesra1 = "راهيست راه عشق که هيچش کناره نيست", Mesra2 = "آن جا جز آن که جان بسپارند چاره نيست",},
new Hafez{ Id= 606, BeytNo = 2, GhazalNo = 72, Mesra1 = "هر گه که دل به عشق دهی خوش دمی بود", Mesra2 = "در کار خير حاجت هيچ استخاره نيست",},
new Hafez{ Id= 607, BeytNo = 3, GhazalNo = 72, Mesra1 = "ما را ز منع عقل مترسان و می بيار", Mesra2 = "کان شحنه در ولايت ما هيچ کاره نيست",},
new Hafez{ Id= 608, BeytNo = 4, GhazalNo = 72, Mesra1 = "از چشم خود بپرس که ما را که می‌کشد", Mesra2 = "جانا گناه طالع و جرم ستاره نيست",},
new Hafez{ Id= 609, BeytNo = 5, GhazalNo = 72, Mesra1 = "او را به چشم پاک توان ديد چون هلال", Mesra2 = "هر ديده جای جلوه آن ماه پاره نيست",},
new Hafez{ Id= 610, BeytNo = 6, GhazalNo = 72, Mesra1 = "فرصت شمر طريقه رندی که اين نشان", Mesra2 = "چون راه گنج بر همه کس آشکاره نيست",},
new Hafez{ Id= 611, BeytNo = 7, GhazalNo = 72, Mesra1 = "نگرفت در تو گريه حافظ به هيچ رو", Mesra2 = "حيران آن دلم که کم از سنگ خاره نيست",},
new Hafez{ Id= 612, BeytNo = 1, GhazalNo = 73, Mesra1 = "روشن از پرتو رويت نظری نيست که نيست", Mesra2 = "منت خاک درت بر بصری نيست که نيست",},
new Hafez{ Id= 613, BeytNo = 2, GhazalNo = 73, Mesra1 = "ناظر روی تو صاحب نظرانند آری", Mesra2 = "سر گيسوی تو در هيچ سری نيست که نيست",},
new Hafez{ Id= 614, BeytNo = 3, GhazalNo = 73, Mesra1 = "اشک غماز من ار سرخ برآمد چه عجب", Mesra2 = "خجل از کرده خود پرده دری نيست که نيست",},
new Hafez{ Id= 615, BeytNo = 4, GhazalNo = 73, Mesra1 = "تا به دامن ننشيند ز نسيمش گردی", Mesra2 = "سيل خيز از نظرم رهگذری نيست که نيست",},
new Hafez{ Id= 616, BeytNo = 5, GhazalNo = 73, Mesra1 = "تا دم از شام سر زلف تو هر جا نزنند", Mesra2 = "با صبا گفت و شنيدم سحری نيست که نيست",},
new Hafez{ Id= 617, BeytNo = 6, GhazalNo = 73, Mesra1 = "من از اين طالع شوريده برنجم ور نی", Mesra2 = "بهره مند از سر کويت دگری نيست که نيست",},
new Hafez{ Id= 618, BeytNo = 7, GhazalNo = 73, Mesra1 = "از حيای لب شيرين تو ای چشمه نوش", Mesra2 = "غرق آب و عرق اکنون شکری نيست که نيست",},
new Hafez{ Id= 619, BeytNo = 8, GhazalNo = 73, Mesra1 = "مصلحت نيست که از پرده برون افتد راز", Mesra2 = "ور نه در مجلس رندان خبری نيست که نيست",},
new Hafez{ Id= 620, BeytNo = 9, GhazalNo = 73, Mesra1 = "شير در باديه عشق تو روباه شود", Mesra2 = "آه از اين راه که در وی خطری نيست که نيست",},
new Hafez{ Id= 621, BeytNo = 10, GhazalNo = 73, Mesra1 = "آب چشمم که بر او منت خاک در توست", Mesra2 = "زير صد منت او خاک دری نيست که نيست",},
new Hafez{ Id= 622, BeytNo = 11, GhazalNo = 73, Mesra1 = "از وجودم قدری نام و نشان هست که هست", Mesra2 = "ور نه از ضعف در آن جا اثری نيست که نيست",},
new Hafez{ Id= 623, BeytNo = 12, GhazalNo = 73, Mesra1 = "غير از اين نکته که حافظ ز تو ناخشنود است", Mesra2 = "در سراپای وجودت هنری نيست که نيست",},
new Hafez{ Id= 624, BeytNo = 1, GhazalNo = 74, Mesra1 = "حاصل کارگه کون و مکان اين همه نيست", Mesra2 = "باده پيش آر که اسباب جهان اين همه نيست",},
new Hafez{ Id= 625, BeytNo = 2, GhazalNo = 74, Mesra1 = "از دل و جان شرف صحبت جانان غرض است", Mesra2 = "غرض اين است وگرنه دل و جان اين همه نيست",},
new Hafez{ Id= 626, BeytNo = 3, GhazalNo = 74, Mesra1 = "منت سدره و طوبی ز پی سايه مکش", Mesra2 = "که چو خوش بنگری ای سرو روان اين همه نيست",},
new Hafez{ Id= 627, BeytNo = 4, GhazalNo = 74, Mesra1 = "دولت آن است که بی خون دل آيد به کنار", Mesra2 = "ور نه با سعی و عمل باغ جنان اين همه نيست",},
new Hafez{ Id= 628, BeytNo = 5, GhazalNo = 74, Mesra1 = "پنج روزی که در اين مرحله مهلت داری", Mesra2 = "خوش بياسای زمانی که زمان اين همه نيست",},
new Hafez{ Id= 629, BeytNo = 6, GhazalNo = 74, Mesra1 = "بر لب بحر فنا منتظريم ای ساقی", Mesra2 = "فرصتی دان که ز لب تا به دهان اين همه نيست",},
new Hafez{ Id= 630, BeytNo = 7, GhazalNo = 74, Mesra1 = "زاهد ايمن مشو از بازی غيرت زنهار", Mesra2 = "که ره از صومعه تا دير مغان اين همه نيست",},
new Hafez{ Id= 631, BeytNo = 8, GhazalNo = 74, Mesra1 = "دردمندی من سوخته زار و نزار", Mesra2 = "ظاهرا حاجت تقرير و بيان اين همه نيست",},
new Hafez{ Id= 632, BeytNo = 9, GhazalNo = 74, Mesra1 = "نام حافظ رقم نيک پذيرفت ولی", Mesra2 = "پيش رندان رقم سود و زيان اين همه نيست",},
new Hafez{ Id= 633, BeytNo = 1, GhazalNo = 75, Mesra1 = "خواب آن نرگس فتان تو بی چيزی نيست", Mesra2 = "تاب آن زلف پريشان تو بی چيزی نيست",},
new Hafez{ Id= 634, BeytNo = 2, GhazalNo = 75, Mesra1 = "از لبت شير روان بود که من می‌گفتم", Mesra2 = "اين شکر گرد نمکدان تو بی چيزی نيست",},
new Hafez{ Id= 635, BeytNo = 3, GhazalNo = 75, Mesra1 = "جان درازی تو بادا که يقين می‌دانم", Mesra2 = "در کمان ناوک مژگان تو بی چيزی نيست",},
new Hafez{ Id= 636, BeytNo = 4, GhazalNo = 75, Mesra1 = "مبتلايی به غم محنت و اندوه فراق", Mesra2 = "ای دل اين ناله و افغان تو بی چيزی نيست",},
new Hafez{ Id= 637, BeytNo = 5, GhazalNo = 75, Mesra1 = "دوش باد از سر کويش به گلستان بگذشت", Mesra2 = "ای گل اين چاک گريبان تو بی چيزی نيست",},
new Hafez{ Id= 638, BeytNo = 6, GhazalNo = 75, Mesra1 = "درد عشق ار چه دل از خلق نهان می‌دارد", Mesra2 = "حافظ اين ديده گريان تو بی چيزی نيست",},
new Hafez{ Id= 639, BeytNo = 1, GhazalNo = 76, Mesra1 = "جز آستان توام در جهان پناهی نيست", Mesra2 = "سر مرا بجز اين در حواله گاهی نيست",},
new Hafez{ Id= 640, BeytNo = 2, GhazalNo = 76, Mesra1 = "عدو چو تيغ کشد من سپر بيندازم", Mesra2 = "که تيغ ما بجز از ناله‌ای و آهی نيست",},
new Hafez{ Id= 641, BeytNo = 3, GhazalNo = 76, Mesra1 = "چرا ز کوی خرابات روی برتابم", Mesra2 = "کز اين به هم به جهان هيچ رسم و راهی نيست",},
new Hafez{ Id= 642, BeytNo = 4, GhazalNo = 76, Mesra1 = "زمانه گر بزند آتشم به خرمن عمر", Mesra2 = "بگو بسوز که بر من به برگ کاهی نيست",},
new Hafez{ Id= 643, BeytNo = 5, GhazalNo = 76, Mesra1 = "غلام نرگس جماش آن سهی سروم", Mesra2 = "که از شراب غرورش به کس نگاهی نيست",},
new Hafez{ Id= 644, BeytNo = 6, GhazalNo = 76, Mesra1 = "مباش در پی آزار و هر چه خواهی کن", Mesra2 = "که در شريعت ما غير از اين گناهی نيست",},
new Hafez{ Id= 645, BeytNo = 7, GhazalNo = 76, Mesra1 = "عنان کشيده رو ای پادشاه کشور حسن", Mesra2 = "که نيست بر سر راهی که دادخواهی نيست",},
new Hafez{ Id= 646, BeytNo = 8, GhazalNo = 76, Mesra1 = "چنين که از همه سو دام راه می‌بينم", Mesra2 = "به از حمايت زلفش مرا پناهی نيست",},
new Hafez{ Id= 647, BeytNo = 9, GhazalNo = 76, Mesra1 = "خزينه دل حافظ به زلف و خال مده", Mesra2 = "که کارهای چنين حد هر سياهی نيست",},
new Hafez{ Id= 648, BeytNo = 1, GhazalNo = 77, Mesra1 = "بلبلی برگ گلی خوش رنگ در منقار داشت", Mesra2 = "و اندر آن برگ و نوا خوش ناله‌های زار داشت",},
new Hafez{ Id= 649, BeytNo = 2, GhazalNo = 77, Mesra1 = "گفتمش در عين وصل اين ناله و فرياد چيست", Mesra2 = "گفت ما را جلوه معشوق در اين کار داشت",},
new Hafez{ Id= 650, BeytNo = 3, GhazalNo = 77, Mesra1 = "يار اگر ننشست با ما نيست جای اعتراض", Mesra2 = "پادشاهی کامران بود از گدايی عار داشت",},
new Hafez{ Id= 651, BeytNo = 4, GhazalNo = 77, Mesra1 = "در نمی‌گيرد نياز و ناز ما با حسن دوست", Mesra2 = "خرم آن کز نازنينان بخت برخوردار داشت",},
new Hafez{ Id= 652, BeytNo = 5, GhazalNo = 77, Mesra1 = "خيز تا بر کلک آن نقاش جان افشان کنيم", Mesra2 = "کاين همه نقش عجب در گردش پرگار داشت",},
new Hafez{ Id= 653, BeytNo = 6, GhazalNo = 77, Mesra1 = "گر مريد راه عشقی فکر بدنامی مکن", Mesra2 = "شيخ صنعان خرقه رهن خانه خمار داشت",},
new Hafez{ Id= 654, BeytNo = 7, GhazalNo = 77, Mesra1 = "وقت آن شيرين قلندر خوش که در اطوار سير", Mesra2 = "ذکر تسبيح ملک در حلقه زنار داشت",},
new Hafez{ Id= 655, BeytNo = 8, GhazalNo = 77, Mesra1 = "چشم حافظ زير بام قصر آن حوری سرشت", Mesra2 = "شيوه جنات تجری تحتها الانهار داشت",},
new Hafez{ Id= 656, BeytNo = 1, GhazalNo = 78, Mesra1 = "ديدی که يار جز سر جور و ستم نداشت", Mesra2 = "بشکست عهد وز غم ما هيچ غم نداشت",},
new Hafez{ Id= 657, BeytNo = 2, GhazalNo = 78, Mesra1 = "يا رب مگيرش ار چه دل چون کبوترم", Mesra2 = "افکند و کشت و عزت صيد حرم نداشت",},
new Hafez{ Id= 658, BeytNo = 3, GhazalNo = 78, Mesra1 = "بر من جفا ز بخت من آمد وگرنه يار", Mesra2 = "حاشا که رسم لطف و طريق کرم نداشت",},
new Hafez{ Id= 659, BeytNo = 4, GhazalNo = 78, Mesra1 = "با اين همه هر آن که نه خواری کشيد از او", Mesra2 = "هر جا که رفت هيچ کسش محترم نداشت",},
new Hafez{ Id= 660, BeytNo = 5, GhazalNo = 78, Mesra1 = "ساقی بيار باده و با محتسب بگو", Mesra2 = "انکار ما مکن که چنين جام جم نداشت",},
new Hafez{ Id= 661, BeytNo = 6, GhazalNo = 78, Mesra1 = "هر راهرو که ره به حريم درش نبرد", Mesra2 = "مسکين بريد وادی و ره در حرم نداشت",},
new Hafez{ Id= 662, BeytNo = 7, GhazalNo = 78, Mesra1 = "حافظ ببر تو گوی فصاحت که مدعی", Mesra2 = "هيچش هنر نبود و خبر نيز هم نداشت",},
new Hafez{ Id= 663, BeytNo = 1, GhazalNo = 79, Mesra1 = "کنون که می‌دمد از بوستان نسيم بهشت", Mesra2 = "من و شراب فرح بخش و يار حورسرشت",},
new Hafez{ Id= 664, BeytNo = 2, GhazalNo = 79, Mesra1 = "گدا چرا نزند لاف سلطنت امروز", Mesra2 = "که خيمه سايه ابر است و بزمگه لب کشت",},
new Hafez{ Id= 665, BeytNo = 3, GhazalNo = 79, Mesra1 = "چمن حکايت ارديبهشت می‌گويد", Mesra2 = "نه عاقل است که نسيه خريد و نقد بهشت",},
new Hafez{ Id= 666, BeytNo = 4, GhazalNo = 79, Mesra1 = "به می عمارت دل کن که اين جهان خراب", Mesra2 = "بر آن سر است که از خاک ما بسازد خشت",},
new Hafez{ Id= 667, BeytNo = 5, GhazalNo = 79, Mesra1 = "وفا مجوی ز دشمن که پرتوی ندهد", Mesra2 = "چو شمع صومعه افروزی از چراغ کنشت",},
new Hafez{ Id= 668, BeytNo = 6, GhazalNo = 79, Mesra1 = "مکن به نامه سياهی ملامت من مست", Mesra2 = "که آگه است که تقدير بر سرش چه نوشت",},
new Hafez{ Id= 669, BeytNo = 7, GhazalNo = 79, Mesra1 = "قدم دريغ مدار از جنازه حافظ", Mesra2 = "که گر چه غرق گناه است می‌رود به بهشت",},
new Hafez{ Id= 670, BeytNo = 1, GhazalNo = 80, Mesra1 = "عيب رندان مکن ای زاهد پاکيزه سرشت", Mesra2 = "که گناه دگران بر تو نخواهند نوشت",},
new Hafez{ Id= 671, BeytNo = 2, GhazalNo = 80, Mesra1 = "من اگر نيکم و گر بد تو برو خود را باش", Mesra2 = "هر کسی آن درود عاقبت کار که کشت",},
new Hafez{ Id= 672, BeytNo = 3, GhazalNo = 80, Mesra1 = "همه کس طالب يارند چه هشيار و چه مست", Mesra2 = "همه جا خانه عشق است چه مسجد چه کنشت",},
new Hafez{ Id= 673, BeytNo = 4, GhazalNo = 80, Mesra1 = "سر تسليم من و خشت در ميکده‌ها", Mesra2 = "مدعی گر نکند فهم سخن گو سر و خشت",},
new Hafez{ Id= 674, BeytNo = 5, GhazalNo = 80, Mesra1 = "نااميدم مکن از سابقه لطف ازل", Mesra2 = "تو پس پرده چه دانی که که خوب است و که زشت",},
new Hafez{ Id= 675, BeytNo = 6, GhazalNo = 80, Mesra1 = "نه من از پرده تقوا به درافتادم و بس", Mesra2 = "پدرم نيز بهشت ابد از دست بهشت",},
new Hafez{ Id= 676, BeytNo = 7, GhazalNo = 80, Mesra1 = "حافظا روز اجل گر به کف آری جامی", Mesra2 = "يک سر از کوی خرابات برندت به بهشت",},
new Hafez{ Id= 677, BeytNo = 1, GhazalNo = 81, Mesra1 = "صبحدم مرغ چمن با گل نوخاسته گفت", Mesra2 = "ناز کم کن که در اين باغ بسی چون تو شکفت",},
new Hafez{ Id= 678, BeytNo = 2, GhazalNo = 81, Mesra1 = "گل بخنديد که از راست نرنجيم ولی", Mesra2 = "هيچ عاشق سخن سخت به معشوق نگفت",},
new Hafez{ Id= 679, BeytNo = 3, GhazalNo = 81, Mesra1 = "گر طمع داری از آن جام مرصع می لعل", Mesra2 = "ای بسا در که به نوک مژه‌ات بايد سفت",},
new Hafez{ Id= 680, BeytNo = 4, GhazalNo = 81, Mesra1 = "تا ابد بوی محبت به مشامش نرسد", Mesra2 = "هر که خاک در ميخانه به رخساره نرفت",},
new Hafez{ Id= 681, BeytNo = 5, GhazalNo = 81, Mesra1 = "در گلستان ارم دوش چو از لطف هوا", Mesra2 = "زلف سنبل به نسيم سحری می‌آشفت",},
new Hafez{ Id= 682, BeytNo = 6, GhazalNo = 81, Mesra1 = "گفتم ای مسند جم جام جهان بينت کو", Mesra2 = "گفت افسوس که آن دولت بيدار بخفت",},
new Hafez{ Id= 683, BeytNo = 7, GhazalNo = 81, Mesra1 = "سخن عشق نه آن است که آيد به زبان", Mesra2 = "ساقيا می ده و کوتاه کن اين گفت و شنفت",},
new Hafez{ Id= 684, BeytNo = 8, GhazalNo = 81, Mesra1 = "اشک حافظ خرد و صبر به دريا انداخت", Mesra2 = "چه کند سوز غم عشق نيارست نهفت",},
new Hafez{ Id= 685, BeytNo = 1, GhazalNo = 82, Mesra1 = "آن ترک پری چهره که دوش از بر ما رفت", Mesra2 = "آيا چه خطا ديد که از راه خطا رفت",},
new Hafez{ Id= 686, BeytNo = 2, GhazalNo = 82, Mesra1 = "تا رفت مرا از نظر آن چشم جهان بين", Mesra2 = "کس واقف ما نيست که از ديده چه‌ها رفت",},
new Hafez{ Id= 687, BeytNo = 3, GhazalNo = 82, Mesra1 = "بر شمع نرفت از گذر آتش دل دوش", Mesra2 = "آن دود که از سوز جگر بر سر ما رفت",},
new Hafez{ Id= 688, BeytNo = 4, GhazalNo = 82, Mesra1 = "دور از رخ تو دم به دم از گوشه چشمم", Mesra2 = "سيلاب سرشک آمد و طوفان بلا رفت",},
new Hafez{ Id= 689, BeytNo = 5, GhazalNo = 82, Mesra1 = "از پای فتاديم چو آمد غم هجران", Mesra2 = "در درد بمرديم چو از دست دوا رفت",},
new Hafez{ Id= 690, BeytNo = 6, GhazalNo = 82, Mesra1 = "دل گفت وصالش به دعا باز توان يافت", Mesra2 = "عمريست که عمرم همه در کار دعا رفت",},
new Hafez{ Id= 691, BeytNo = 7, GhazalNo = 82, Mesra1 = "احرام چه بنديم چو آن قبله نه اين جاست", Mesra2 = "در سعی چه کوشيم چو از مروه صفا رفت",},
new Hafez{ Id= 692, BeytNo = 8, GhazalNo = 82, Mesra1 = "دی گفت طبيب از سر حسرت چو مرا ديد", Mesra2 = "هيهات که رنج تو ز قانون شفا رفت",},
new Hafez{ Id= 693, BeytNo = 9, GhazalNo = 82, Mesra1 = "ای دوست به پرسيدن حافظ قدمی نه", Mesra2 = "زان پيش که گويند که از دار فنا رفت",},
new Hafez{ Id= 694, BeytNo = 1, GhazalNo = 83, Mesra1 = "گر ز دست زلف مشکينت خطايی رفت رفت", Mesra2 = "ور ز هندوی شما بر ما جفايی رفت رفت",},
new Hafez{ Id= 695, BeytNo = 2, GhazalNo = 83, Mesra1 = "برق عشق ار خرمن پشمينه پوشی سوخت سوخت", Mesra2 = "جور شاه کامران گر بر گدايی رفت رفت",},
new Hafez{ Id= 696, BeytNo = 3, GhazalNo = 83, Mesra1 = "در طريقت رنجش خاطر نباشد می بيار", Mesra2 = "هر کدورت را که بينی چون صفايی رفت رفت",},
new Hafez{ Id= 697, BeytNo = 4, GhazalNo = 83, Mesra1 = "عشقبازی را تحمل بايد ای دل پای دار", Mesra2 = "گر ملالی بود بود و گر خطايی رفت رفت",},
new Hafez{ Id= 698, BeytNo = 5, GhazalNo = 83, Mesra1 = "گر دلی از غمزه دلدار باری برد برد", Mesra2 = "ور ميان جان و جانان ماجرايی رفت رفت",},
new Hafez{ Id= 699, BeytNo = 6, GhazalNo = 83, Mesra1 = "از سخن چينان ملالت‌ها پديد آمد ولی", Mesra2 = "گر ميان همنشينان ناسزايی رفت رفت",},
new Hafez{ Id= 700, BeytNo = 7, GhazalNo = 83, Mesra1 = "عيب حافظ گو مکن واعظ که رفت از خانقاه", Mesra2 = "پای آزادی چه بندی گر به جايی رفت رفت",},
new Hafez{ Id= 701, BeytNo = 1, GhazalNo = 84, Mesra1 = "ساقی بيار باده که ماه صيام رفت", Mesra2 = "درده قدح که موسم ناموس و نام رفت",},
new Hafez{ Id= 702, BeytNo = 2, GhazalNo = 84, Mesra1 = "وقت عزيز رفت بيا تا قضا کنيم", Mesra2 = "عمری که بی حضور صراحی و جام رفت",},
new Hafez{ Id= 703, BeytNo = 3, GhazalNo = 84, Mesra1 = "مستم کن آن چنان که ندانم ز بيخودی", Mesra2 = "در عرصه خيال که آمد کدام رفت",},
new Hafez{ Id= 704, BeytNo = 4, GhazalNo = 84, Mesra1 = "بر بوی آن که جرعه جامت به ما رسد", Mesra2 = "در مصطبه دعای تو هر صبح و شام رفت",},
new Hafez{ Id= 705, BeytNo = 5, GhazalNo = 84, Mesra1 = "دل را که مرده بود حياتی به جان رسيد", Mesra2 = "تا بويی از نسيم می‌اش در مشام رفت",},
new Hafez{ Id= 706, BeytNo = 6, GhazalNo = 84, Mesra1 = "زاهد غرور داشت سلامت نبرد راه", Mesra2 = "رند از ره نياز به دارالسلام رفت",},
new Hafez{ Id= 707, BeytNo = 7, GhazalNo = 84, Mesra1 = "نقد دلی که بود مرا صرف باده شد", Mesra2 = "قلب سياه بود از آن در حرام رفت",},
new Hafez{ Id= 708, BeytNo = 8, GhazalNo = 84, Mesra1 = "در تاب توبه چند توان سوخت همچو عود", Mesra2 = "می ده که عمر در سر سودای خام رفت",},
new Hafez{ Id= 709, BeytNo = 9, GhazalNo = 84, Mesra1 = "ديگر مکن نصيحت حافظ که ره نيافت", Mesra2 = "گمگشته‌ای که باده نابش به کام رفت",},
new Hafez{ Id= 710, BeytNo = 1, GhazalNo = 85, Mesra1 = "شربتی از لب لعلش نچشيديم و برفت", Mesra2 = "روی مه پيکر او سير نديديم و برفت",},
new Hafez{ Id= 711, BeytNo = 2, GhazalNo = 85, Mesra1 = "گويی از صحبت ما نيک به تنگ آمده بود", Mesra2 = "بار بربست و به گردش نرسيديم و برفت",},
new Hafez{ Id= 712, BeytNo = 3, GhazalNo = 85, Mesra1 = "بس که ما فاتحه و حرز يمانی خوانديم", Mesra2 = "وز پی اش سوره اخلاص دميديم و برفت",},
new Hafez{ Id= 713, BeytNo = 4, GhazalNo = 85, Mesra1 = "عشوه دادند که بر ما گذری خواهی کرد", Mesra2 = "ديدی آخر که چنين عشوه خريديم و برفت",},
new Hafez{ Id= 714, BeytNo = 5, GhazalNo = 85, Mesra1 = "شد چمان در چمن حسن و لطافت ليکن", Mesra2 = "در گلستان وصالش نچميديم و برفت",},
new Hafez{ Id= 715, BeytNo = 6, GhazalNo = 85, Mesra1 = "همچو حافظ همه شب ناله و زاری کرديم", Mesra2 = "کای دريغا به وداعش نرسيديم و برفت",},
new Hafez{ Id= 716, BeytNo = 1, GhazalNo = 86, Mesra1 = "ساقی بيا که يار ز رخ پرده برگرفت", Mesra2 = "کار چراغ خلوتيان باز درگرفت",},
new Hafez{ Id= 717, BeytNo = 2, GhazalNo = 86, Mesra1 = "آن شمع سرگرفته دگر چهره برفروخت", Mesra2 = "وين پير سالخورده جوانی ز سر گرفت",},
new Hafez{ Id= 718, BeytNo = 3, GhazalNo = 86, Mesra1 = "آن عشوه داد عشق که مفتی ز ره برفت", Mesra2 = "وان لطف کرد دوست که دشمن حذر گرفت",},
new Hafez{ Id= 719, BeytNo = 4, GhazalNo = 86, Mesra1 = "زنهار از آن عبارت شيرين دلفريب", Mesra2 = "گويی که پسته تو سخن در شکر گرفت",},
new Hafez{ Id= 720, BeytNo = 5, GhazalNo = 86, Mesra1 = "بار غمی که خاطر ما خسته کرده بود", Mesra2 = "عيسی دمی خدا بفرستاد و برگرفت",},
new Hafez{ Id= 721, BeytNo = 6, GhazalNo = 86, Mesra1 = "هر سروقد که بر مه و خور حسن می‌فروخت", Mesra2 = "چون تو درآمدی پی کاری دگر گرفت",},
new Hafez{ Id= 722, BeytNo = 7, GhazalNo = 86, Mesra1 = "زين قصه هفت گنبد افلاک پرصداست", Mesra2 = "کوته نظر ببين که سخن مختصر گرفت",},
new Hafez{ Id= 723, BeytNo = 8, GhazalNo = 86, Mesra1 = "حافظ تو اين سخن ز که آموختی که بخت", Mesra2 = "تعويذ کرد شعر تو را و به زر گرفت",},
new Hafez{ Id= 724, BeytNo = 1, GhazalNo = 87, Mesra1 = "حسنت به اتفاق ملاحت جهان گرفت", Mesra2 = "آری به اتفاق جهان می‌توان گرفت",},
new Hafez{ Id= 725, BeytNo = 2, GhazalNo = 87, Mesra1 = "افشای راز خلوتيان خواست کرد شمع", Mesra2 = "شکر خدا که سر دلش در زبان گرفت",},
new Hafez{ Id= 726, BeytNo = 3, GhazalNo = 87, Mesra1 = "زين آتش نهفته که در سينه من است", Mesra2 = "خورشيد شعله‌ايست که در آسمان گرفت",},
new Hafez{ Id= 727, BeytNo = 4, GhazalNo = 87, Mesra1 = "می‌خواست گل که دم زند از رنگ و بوی دوست", Mesra2 = "از غيرت صبا نفسش در دهان گرفت",},
new Hafez{ Id= 728, BeytNo = 5, GhazalNo = 87, Mesra1 = "آسوده بر کنار چو پرگار می‌شدم", Mesra2 = "دوران چو نقطه عاقبتم در ميان گرفت",},
new Hafez{ Id= 729, BeytNo = 6, GhazalNo = 87, Mesra1 = "آن روز شوق ساغر می خرمنم بسوخت", Mesra2 = "کتش ز عکس عارض ساقی در آن گرفت",},
new Hafez{ Id= 730, BeytNo = 7, GhazalNo = 87, Mesra1 = "خواهم شدن به کوی مغان آستين فشان", Mesra2 = "زين فتنه‌ها که دامن آخرزمان گرفت",},
new Hafez{ Id= 731, BeytNo = 8, GhazalNo = 87, Mesra1 = "می خور که هر که آخر کار جهان بديد", Mesra2 = "از غم سبک برآمد و رطل گران گرفت",},
new Hafez{ Id= 732, BeytNo = 9, GhazalNo = 87, Mesra1 = "بر برگ گل به خون شقايق نوشته‌اند", Mesra2 = "کان کس که پخته شد می چون ارغوان گرفت",},
new Hafez{ Id= 733, BeytNo = 10, GhazalNo = 87, Mesra1 = "حافظ چو آب لطف ز نظم تو می‌چکد", Mesra2 = "حاسد چگونه نکته تواند بر آن گرفت",},
new Hafez{ Id= 734, BeytNo = 1, GhazalNo = 88, Mesra1 = "شنيده‌ام سخنی خوش که پير کنعان گفت", Mesra2 = "فراق يار نه آن می‌کند که بتوان گفت",},
new Hafez{ Id= 735, BeytNo = 2, GhazalNo = 88, Mesra1 = "حديث هول قيامت که گفت واعظ شهر", Mesra2 = "کنايتيست که از روزگار هجران گفت",},
new Hafez{ Id= 736, BeytNo = 3, GhazalNo = 88, Mesra1 = "نشان يار سفرکرده از که پرسم باز", Mesra2 = "که هر چه گفت بريد صبا پريشان گفت",},
new Hafez{ Id= 737, BeytNo = 4, GhazalNo = 88, Mesra1 = "فغان که آن مه نامهربان مهرگسل", Mesra2 = "به ترک صحبت ياران خود چه آسان گفت",},
new Hafez{ Id= 738, BeytNo = 5, GhazalNo = 88, Mesra1 = "من و مقام رضا بعد از اين و شکر رقيب", Mesra2 = "که دل به درد تو خو کرد و ترک درمان گفت",},
new Hafez{ Id= 739, BeytNo = 6, GhazalNo = 88, Mesra1 = "غم کهن به می سالخورده دفع کنيد", Mesra2 = "که تخم خوشدلی اين است پير دهقان گفت",},
new Hafez{ Id= 740, BeytNo = 7, GhazalNo = 88, Mesra1 = "گره به باد مزن گر چه بر مراد رود", Mesra2 = "که اين سخن به مثل باد با سليمان گفت",},
new Hafez{ Id= 741, BeytNo = 8, GhazalNo = 88, Mesra1 = "به مهلتی که سپهرت دهد ز راه مرو", Mesra2 = "تو را که گفت که اين زال ترک دستان گفت",},
new Hafez{ Id= 742, BeytNo = 9, GhazalNo = 88, Mesra1 = "مزن ز چون و چرا دم که بنده مقبل", Mesra2 = "قبول کرد به جان هر سخن که جانان گفت",},
new Hafez{ Id= 743, BeytNo = 10, GhazalNo = 88, Mesra1 = "که گفت حافظ از انديشه تو آمد باز", Mesra2 = "من اين نگفته‌ام آن کس که گفت بهتان گفت",},
new Hafez{ Id= 744, BeytNo = 1, GhazalNo = 89, Mesra1 = "يا رب سببی ساز که يارم به سلامت", Mesra2 = "بازآيد و برهاندم از بند ملامت",},
new Hafez{ Id= 745, BeytNo = 2, GhazalNo = 89, Mesra1 = "خاک ره آن يار سفرکرده بياريد", Mesra2 = "تا چشم جهان بين کنمش جای اقامت",},
new Hafez{ Id= 746, BeytNo = 3, GhazalNo = 89, Mesra1 = "فرياد که از شش جهتم راه ببستند", Mesra2 = "آن خال و خط و زلف و رخ و عارض و قامت",},
new Hafez{ Id= 747, BeytNo = 4, GhazalNo = 89, Mesra1 = "امروز که در دست توام مرحمتی کن", Mesra2 = "فردا که شوم خاک چه سود اشک ندامت",},
new Hafez{ Id= 748, BeytNo = 5, GhazalNo = 89, Mesra1 = "ای آن که به تقرير و بيان دم زنی از عشق", Mesra2 = "ما با تو نداريم سخن خير و سلامت",},
new Hafez{ Id= 749, BeytNo = 6, GhazalNo = 89, Mesra1 = "درويش مکن ناله ز شمشير احبا", Mesra2 = "کاين طايفه از کشته ستانند غرامت",},
new Hafez{ Id= 750, BeytNo = 7, GhazalNo = 89, Mesra1 = "در خرقه زن آتش که خم ابروی ساقی", Mesra2 = "بر می‌شکند گوشه محراب امامت",},
new Hafez{ Id= 751, BeytNo = 8, GhazalNo = 89, Mesra1 = "حاشا که من از جور و جفای تو بنالم", Mesra2 = "بيداد لطيفان همه لطف است و کرامت",},
new Hafez{ Id= 752, BeytNo = 9, GhazalNo = 89, Mesra1 = "کوته نکند بحث سر زلف تو حافظ", Mesra2 = "پيوسته شد اين سلسله تا روز قيامت",},
new Hafez{ Id= 753, BeytNo = 1, GhazalNo = 90, Mesra1 = "ای هدهد صبا به سبا می‌فرستمت", Mesra2 = "بنگر که از کجا به کجا می‌فرستمت",},
new Hafez{ Id= 754, BeytNo = 2, GhazalNo = 90, Mesra1 = "حيف است طايری چو تو در خاکدان غم", Mesra2 = "زين جا به آشيان وفا می‌فرستمت",},
new Hafez{ Id= 755, BeytNo = 3, GhazalNo = 90, Mesra1 = "در راه عشق مرحله قرب و بعد نيست", Mesra2 = "می‌بينمت عيان و دعا می‌فرستمت",},
new Hafez{ Id= 756, BeytNo = 4, GhazalNo = 90, Mesra1 = "هر صبح و شام قافله‌ای از دعای خير", Mesra2 = "در صحبت شمال و صبا می‌فرستمت",},
new Hafez{ Id= 757, BeytNo = 5, GhazalNo = 90, Mesra1 = "تا لشکر غمت نکند ملک دل خراب", Mesra2 = "جان عزيز خود به نوا می‌فرستمت",},
new Hafez{ Id= 758, BeytNo = 6, GhazalNo = 90, Mesra1 = "ای غايب از نظر که شدی همنشين دل", Mesra2 = "می‌گويمت دعا و ثنا می‌فرستمت",},
new Hafez{ Id= 759, BeytNo = 7, GhazalNo = 90, Mesra1 = "در روی خود تفرج صنع خدای کن", Mesra2 = "کيينه خدای نما می‌فرستمت",},
new Hafez{ Id= 760, BeytNo = 8, GhazalNo = 90, Mesra1 = "تا مطربان ز شوق منت آگهی دهند", Mesra2 = "قول و غزل به ساز و نوا می‌فرستمت",},
new Hafez{ Id= 761, BeytNo = 9, GhazalNo = 90, Mesra1 = "ساقی بيا که هاتف غيبم به مژده گفت", Mesra2 = "با درد صبر کن که دوا می‌فرستمت",},
new Hafez{ Id= 762, BeytNo = 10, GhazalNo = 90, Mesra1 = "حافظ سرود مجلس ما ذکر خير توست", Mesra2 = "بشتاب هان که اسب و قبا می‌فرستمت",},
new Hafez{ Id= 763, BeytNo = 1, GhazalNo = 91, Mesra1 = "ای غايب از نظر به خدا می‌سپارمت", Mesra2 = "جانم بسوختی و به دل دوست دارمت",},
new Hafez{ Id= 764, BeytNo = 2, GhazalNo = 91, Mesra1 = "تا دامن کفن نکشم زير پای خاک", Mesra2 = "باور مکن که دست ز دامن بدارمت",},
new Hafez{ Id= 765, BeytNo = 3, GhazalNo = 91, Mesra1 = "محراب ابرويت بنما تا سحرگهی", Mesra2 = "دست دعا برآرم و در گردن آرمت",},
new Hafez{ Id= 766, BeytNo = 4, GhazalNo = 91, Mesra1 = "گر بايدم شدن سوی هاروت بابلی", Mesra2 = "صد گونه جادويی بکنم تا بيارمت",},
new Hafez{ Id= 767, BeytNo = 5, GhazalNo = 91, Mesra1 = "خواهم که پيش ميرمت ای بی‌وفا طبيب", Mesra2 = "بيمار بازپرس که در انتظارمت",},
new Hafez{ Id= 768, BeytNo = 6, GhazalNo = 91, Mesra1 = "صد جوی آب بسته‌ام از ديده بر کنار", Mesra2 = "بر بوی تخم مهر که در دل بکارمت",},
new Hafez{ Id= 769, BeytNo = 7, GhazalNo = 91, Mesra1 = "خونم بريخت و از غم عشقم خلاص داد", Mesra2 = "منت پذير غمزه خنجر گذارمت",},
new Hafez{ Id= 770, BeytNo = 8, GhazalNo = 91, Mesra1 = "می‌گريم و مرادم از اين سيل اشکبار", Mesra2 = "تخم محبت است که در دل بکارمت",},
new Hafez{ Id= 771, BeytNo = 9, GhazalNo = 91, Mesra1 = "بارم ده از کرم سوی خود تا به سوز دل", Mesra2 = "در پای دم به دم گهر از ديده بارمت",},
new Hafez{ Id= 772, BeytNo = 10, GhazalNo = 91, Mesra1 = "حافظ شراب و شاهد و رندی نه وضع توست", Mesra2 = "فی الجمله می‌کنی و فرو می‌گذارمت",},
new Hafez{ Id= 773, BeytNo = 1, GhazalNo = 92, Mesra1 = "مير من خوش می‌روی کاندر سر و پا ميرمت", Mesra2 = "خوش خرامان شو که پيش قد رعنا ميرمت",},
new Hafez{ Id= 774, BeytNo = 2, GhazalNo = 92, Mesra1 = "گفته بودی کی بميری پيش من تعجيل چيست", Mesra2 = "خوش تقاضا می‌کنی پيش تقاضا ميرمت",},
new Hafez{ Id= 775, BeytNo = 3, GhazalNo = 92, Mesra1 = "عاشق و مخمور و مهجورم بت ساقی کجاست", Mesra2 = "گو که بخرامد که پيش سروبالا ميرمت",},
new Hafez{ Id= 776, BeytNo = 4, GhazalNo = 92, Mesra1 = "آن که عمری شد که تا بيمارم از سودای او", Mesra2 = "گو نگاهی کن که پيش چشم شهلا ميرمت",},
new Hafez{ Id= 777, BeytNo = 5, GhazalNo = 92, Mesra1 = "گفته لعل لبم هم درد بخشد هم دوا", Mesra2 = "گاه پيش درد و گه پيش مداوا ميرمت",},
new Hafez{ Id= 778, BeytNo = 6, GhazalNo = 92, Mesra1 = "خوش خرامان می‌روی چشم بد از روی تو دور", Mesra2 = "دارم اندر سر خيال آن که در پا ميرمت",},
new Hafez{ Id= 779, BeytNo = 7, GhazalNo = 92, Mesra1 = "گر چه جای حافظ اندر خلوت وصل تو نيست", Mesra2 = "ای همه جای تو خوش پيش همه جا ميرمت",},
new Hafez{ Id= 780, BeytNo = 1, GhazalNo = 93, Mesra1 = "چه لطف بود که ناگاه رشحه قلمت", Mesra2 = "حقوق خدمت ما عرضه کرد بر کرمت",},
new Hafez{ Id= 781, BeytNo = 2, GhazalNo = 93, Mesra1 = "به نوک خامه رقم کرده‌ای سلام مرا", Mesra2 = "که کارخانه دوران مباد بی رقمت",},
new Hafez{ Id= 782, BeytNo = 3, GhazalNo = 93, Mesra1 = "نگويم از من بی‌دل به سهو کردی ياد", Mesra2 = "که در حساب خرد نيست سهو بر قلمت",},
new Hafez{ Id= 783, BeytNo = 4, GhazalNo = 93, Mesra1 = "مرا ذليل مگردان به شکر اين نعمت", Mesra2 = "که داشت دولت سرمد عزيز و محترمت",},
new Hafez{ Id= 784, BeytNo = 5, GhazalNo = 93, Mesra1 = "بيا که با سر زلفت قرار خواهم کرد", Mesra2 = "که گر سرم برود برندارم از قدمت",},
new Hafez{ Id= 785, BeytNo = 6, GhazalNo = 93, Mesra1 = "ز حال ما دلت آگه شود مگر وقتی", Mesra2 = "که لاله بردمد از خاک کشتگان غمت",},
new Hafez{ Id= 786, BeytNo = 7, GhazalNo = 93, Mesra1 = "روان تشنه ما را به جرعه‌ای درياب", Mesra2 = "چو می‌دهند زلال خضر ز جام جمت",},
new Hafez{ Id= 787, BeytNo = 8, GhazalNo = 93, Mesra1 = "هميشه وقت تو ای عيسی صبا خوش باد", Mesra2 = "که جان حافظ دلخسته زنده شد به دمت",},
new Hafez{ Id= 788, BeytNo = 1, GhazalNo = 94, Mesra1 = "زان يار دلنوازم شکريست با شکايت", Mesra2 = "گر نکته دان عشقی بشنو تو اين حکايت",},
new Hafez{ Id= 789, BeytNo = 2, GhazalNo = 94, Mesra1 = "بی مزد بود و منت هر خدمتی که کردم", Mesra2 = "يا رب مباد کس را مخدوم بی عنايت",},
new Hafez{ Id= 790, BeytNo = 3, GhazalNo = 94, Mesra1 = "رندان تشنه لب را آبی نمی‌دهد کس", Mesra2 = "گويی ولی شناسان رفتند از اين ولايت",},
new Hafez{ Id= 791, BeytNo = 4, GhazalNo = 94, Mesra1 = "در زلف چون کمندش ای دل مپيچ کان جا", Mesra2 = "سرها بريده بينی بی جرم و بی جنايت",},
new Hafez{ Id= 792, BeytNo = 5, GhazalNo = 94, Mesra1 = "چشمت به غمزه ما را خون خورد و می‌پسندی", Mesra2 = "جانا روا نباشد خون ريز را حمايت",},
new Hafez{ Id= 793, BeytNo = 6, GhazalNo = 94, Mesra1 = "در اين شب سياهم گم گشت راه مقصود", Mesra2 = "از گوشه‌ای برون آی ای کوکب هدايت",},
new Hafez{ Id= 794, BeytNo = 7, GhazalNo = 94, Mesra1 = "از هر طرف که رفتم جز وحشتم نيفزود", Mesra2 = "زنهار از اين بيابان وين راه بی‌نهايت",},
new Hafez{ Id= 795, BeytNo = 8, GhazalNo = 94, Mesra1 = "ای آفتاب خوبان می‌جوشد اندرونم", Mesra2 = "يک ساعتم بگنجان در سايه عنايت",},
new Hafez{ Id= 796, BeytNo = 9, GhazalNo = 94, Mesra1 = "اين راه را نهايت صورت کجا توان بست", Mesra2 = "کش صد هزار منزل بيش است در بدايت",},
new Hafez{ Id= 797, BeytNo = 10, GhazalNo = 94, Mesra1 = "هر چند بردی آبم روی از درت نتابم", Mesra2 = "جور از حبيب خوشتر کز مدعی رعايت",},
new Hafez{ Id= 798, BeytNo = 11, GhazalNo = 94, Mesra1 = "عشقت رسد به فرياد ار خود به سان حافظ", Mesra2 = "قرآن ز بر بخوانی در چارده روايت",},
new Hafez{ Id= 799, BeytNo = 1, GhazalNo = 95, Mesra1 = "مدامم مست می‌دارد نسيم جعد گيسويت", Mesra2 = "خرابم می‌کند هر دم فريب چشم جادويت",},
new Hafez{ Id= 800, BeytNo = 2, GhazalNo = 95, Mesra1 = "پس از چندين شکيبايی شبی يا رب توان ديدن", Mesra2 = "که شمع ديده افروزيم در محراب ابرويت",},
new Hafez{ Id= 801, BeytNo = 3, GhazalNo = 95, Mesra1 = "سواد لوح بينش را عزيز از بهر آن دارم", Mesra2 = "که جان را نسخه‌ای باشد ز لوح خال هندويت",},
new Hafez{ Id= 802, BeytNo = 4, GhazalNo = 95, Mesra1 = "تو گر خواهی که جاويدان جهان يک سر بيارايی", Mesra2 = "صبا را گو که بردارد زمانی برقع از رويت",},
new Hafez{ Id= 803, BeytNo = 5, GhazalNo = 95, Mesra1 = "و گر رسم فنا خواهی که از عالم براندازی", Mesra2 = "برافشان تا فروريزد هزاران جان ز هر مويت",},
new Hafez{ Id= 804, BeytNo = 6, GhazalNo = 95, Mesra1 = "من و باد صبا مسکين دو سرگردان بی‌حاصل", Mesra2 = "من از افسون چشمت مست و او از بوی گيسويت",},
new Hafez{ Id= 805, BeytNo = 7, GhazalNo = 95, Mesra1 = "زهی همت که حافظ راست از دنيی و از عقبی", Mesra2 = "نيايد هيچ در چشمش بجز خاک سر کويت",},
new Hafez{ Id= 806, BeytNo = 1, GhazalNo = 96, Mesra1 = "درد ما را نيست درمان الغياث", Mesra2 = "هجر ما را نيست پايان الغياث",},
new Hafez{ Id= 807, BeytNo = 2, GhazalNo = 96, Mesra1 = "دين و دل بردند و قصد جان کنند", Mesra2 = "الغياث از جور خوبان الغياث",},
new Hafez{ Id= 808, BeytNo = 3, GhazalNo = 96, Mesra1 = "در بهای بوسه‌ای جانی طلب", Mesra2 = "می‌کنند اين دلستانان الغياث",},
new Hafez{ Id= 809, BeytNo = 4, GhazalNo = 96, Mesra1 = "خون ما خوردند اين کافردلان", Mesra2 = "ای مسلمانان چه درمان الغياث",},
new Hafez{ Id= 810, BeytNo = 5, GhazalNo = 96, Mesra1 = "همچو حافظ روز و شب بی خويشتن", Mesra2 = "گشته‌ام سوزان و گريان الغياث",},
new Hafez{ Id= 811, BeytNo = 1, GhazalNo = 97, Mesra1 = "تويی که بر سر خوبان کشوری چون تاج", Mesra2 = "سزد اگر همه دلبران دهندت باج",},
new Hafez{ Id= 812, BeytNo = 2, GhazalNo = 97, Mesra1 = "دو چشم شوخ تو برهم زده خطا و حبش", Mesra2 = "به چين زلف تو ماچين و هند داده خراج",},
new Hafez{ Id= 813, BeytNo = 3, GhazalNo = 97, Mesra1 = "بياض روی تو روشن چو عارض رخ روز", Mesra2 = "سواد زلف سياه تو هست ظلمت داج",},
new Hafez{ Id= 814, BeytNo = 4, GhazalNo = 97, Mesra1 = "دهان شهد تو داده رواج آب خضر", Mesra2 = "لب چو قند تو برد از نبات مصر رواج",},
new Hafez{ Id= 815, BeytNo = 5, GhazalNo = 97, Mesra1 = "از اين مرض به حقيقت شفا نخواهم يافت", Mesra2 = "که از تو درد دل ای جان نمی‌رسد به علاج",},
new Hafez{ Id= 816, BeytNo = 6, GhazalNo = 97, Mesra1 = "چرا همی‌شکنی جان من ز سنگ دلی", Mesra2 = "دل ضعيف که باشد به نازکی چو زجاج",},
new Hafez{ Id= 817, BeytNo = 7, GhazalNo = 97, Mesra1 = "لب تو خضر و دهان تو آب حيوان است", Mesra2 = "قد تو سرو و ميان موی و بر به هيت عاج",},
new Hafez{ Id= 818, BeytNo = 8, GhazalNo = 97, Mesra1 = "فتاد در دل حافظ هوای چون تو شهی", Mesra2 = "کمينه ذره خاک در تو بودی کاج",},
new Hafez{ Id= 819, BeytNo = 1, GhazalNo = 98, Mesra1 = "اگر به مذهب تو خون عاشق است مباح", Mesra2 = "صلاح ما همه آن است کان تو راست صلاح",},
new Hafez{ Id= 820, BeytNo = 2, GhazalNo = 98, Mesra1 = "سواد زلف سياه تو جاعل الظلمات", Mesra2 = "بياض روی چو ماه تو فالق الاصباح",},
new Hafez{ Id= 821, BeytNo = 3, GhazalNo = 98, Mesra1 = "ز چين زلف کمندت کسی نيافت خلاص", Mesra2 = "از آن کمانچه ابرو و تير چشم نجاح",},
new Hafez{ Id= 822, BeytNo = 4, GhazalNo = 98, Mesra1 = "ز ديده‌ام شده يک چشمه در کنار روان", Mesra2 = "که آشنا نکند در ميان آن ملاح",},
new Hafez{ Id= 823, BeytNo = 5, GhazalNo = 98, Mesra1 = "لب چو آب حيات تو هست قوت جان", Mesra2 = "وجود خاکی ما را از اوست ذکر رواح",},
new Hafez{ Id= 824, BeytNo = 6, GhazalNo = 98, Mesra1 = "بداد لعل لبت بوسه‌ای به صد زاری", Mesra2 = "گرفت کام دلم ز او به صد هزار الحاح",},
new Hafez{ Id= 825, BeytNo = 7, GhazalNo = 98, Mesra1 = "دعای جان تو ورد زبان مشتاقان", Mesra2 = "هميشه تا که بود متصل مسا و صباح",},
new Hafez{ Id= 826, BeytNo = 8, GhazalNo = 98, Mesra1 = "صلاح و توبه و تقوی ز ما مجو حافظ", Mesra2 = "ز رند و عاشق و مجنون کسی نيافت صلاح",},
new Hafez{ Id= 827, BeytNo = 1, GhazalNo = 99, Mesra1 = "بود آشفته همچون موی فرخ", Mesra2 = "دل من در هوای روی فرخ",},
new Hafez{ Id= 828, BeytNo = 2, GhazalNo = 99, Mesra1 = "که برخوردار شد از روی فرخ", Mesra2 = "بجز هندوی زلفش هيچ کس نيست",},
new Hafez{ Id= 829, BeytNo = 3, GhazalNo = 99, Mesra1 = "بود همراز و هم زانوی فرخ", Mesra2 = "سياهی نيکبخت است آن که دايم",},
new Hafez{ Id= 830, BeytNo = 4, GhazalNo = 99, Mesra1 = "اگر بيند قد دلجوی فرخ", Mesra2 = "شود چون بيد لرزان سرو آزاد",},
new Hafez{ Id= 831, BeytNo = 5, GhazalNo = 99, Mesra1 = "به ياد نرگس جادوی فرخ", Mesra2 = "بده ساقی شراب ارغوانی",},
new Hafez{ Id= 832, BeytNo = 6, GhazalNo = 99, Mesra1 = "ز غم پيوسته چون ابروی فرخ", Mesra2 = "دوتا شد قامتم همچون کمانی",},
new Hafez{ Id= 833, BeytNo = 7, GhazalNo = 99, Mesra1 = "شميم زلف عنبربوی فرخ", Mesra2 = "نسيم مشک تاتاری خجل کرد",},
new Hafez{ Id= 834, BeytNo = 8, GhazalNo = 99, Mesra1 = "بود ميل دل من سوی فرخ", Mesra2 = "اگر ميل دل هر کس به جايست",},
new Hafez{ Id= 835, BeytNo = 9, GhazalNo = 99, Mesra1 = "چو حافظ بنده و هندوی فرخ", Mesra2 = "غلام همت آنم که باشد",},
new Hafez{ Id= 836, BeytNo = 1, GhazalNo = 100, Mesra1 = "گفتا شراب نوش و غم دل ببر ز ياد", Mesra2 = "دی پير می فروش که ذکرش به خير باد",},
new Hafez{ Id= 837, BeytNo = 2, GhazalNo = 100, Mesra1 = "گفتا قبول کن سخن و هر چه باد باد", Mesra2 = "گفتم به باد می‌دهدم باده نام و ننگ",},
new Hafez{ Id= 838, BeytNo = 3, GhazalNo = 100, Mesra1 = "از بهر اين معامله غمگين مباش و شاد", Mesra2 = "سود و زيان و مايه چو خواهد شدن ز دست",},
new Hafez{ Id= 839, BeytNo = 4, GhazalNo = 100, Mesra1 = "در معرضی که تخت سليمان رود به باد", Mesra2 = "بادت به دست باشد اگر دل نهی به هيچ",},
new Hafez{ Id= 840, BeytNo = 5, GhazalNo = 100, Mesra1 = "کوته کنيم قصه که عمرت دراز باد", Mesra2 = "حافظ گرت ز پند حکيمان ملالت است",},
new Hafez{ Id= 841, BeytNo = 1, GhazalNo = 101, Mesra1 = "زديم بر صف رندان و هر چه بادا باد", Mesra2 = "شراب و عيش نهان چيست کار بی‌بنياد",},
new Hafez{ Id= 842, BeytNo = 2, GhazalNo = 101, Mesra1 = "که فکر هيچ مهندس چنين گره نگشاد", Mesra2 = "گره ز دل بگشا و از سپهر ياد مکن",},
new Hafez{ Id= 843, BeytNo = 3, GhazalNo = 101, Mesra1 = "از اين فسانه هزاران هزار دارد ياد", Mesra2 = "ز انقلاب زمانه عجب مدار که چرخ",},
new Hafez{ Id= 844, BeytNo = 4, GhazalNo = 101, Mesra1 = "ز کاسه سر جمشيد و بهمن است و قباد", Mesra2 = "قدح به شرط ادب گير زان که ترکيبش",},
new Hafez{ Id= 845, BeytNo = 5, GhazalNo = 101, Mesra1 = "که واقف است که چون رفت تخت جم بر باد", Mesra2 = "که آگه است که کاووس و کی کجا رفتند",},
new Hafez{ Id= 846, BeytNo = 6, GhazalNo = 101, Mesra1 = "که لاله می‌دمد از خون ديده فرهاد", Mesra2 = "ز حسرت لب شيرين هنوز می‌بينم",},
new Hafez{ Id= 847, BeytNo = 7, GhazalNo = 101, Mesra1 = "که تا بزاد و بشد جام می ز کف ننهاد", Mesra2 = "مگر که لاله بدانست بی‌وفايی دهر",},
new Hafez{ Id= 848, BeytNo = 8, GhazalNo = 101, Mesra1 = "مگر رسيم به گنجی در اين خراب آباد", Mesra2 = "بيا بيا که زمانی ز می خراب شويم",},
new Hafez{ Id= 849, BeytNo = 9, GhazalNo = 101, Mesra1 = "نسيم باد مصلا و آب رکن آباد", Mesra2 = "نمی‌دهند اجازت مرا به سير و سفر",},
new Hafez{ Id= 850, BeytNo = 10, GhazalNo = 101, Mesra1 = "که بسته‌اند بر ابريشم طرب دل شاد", Mesra2 = "قدح مگير چو حافظ مگر به ناله چنگ",},
new Hafez{ Id= 851, BeytNo = 1, GhazalNo = 102, Mesra1 = "من نيز دل به باد دهم هر چه باد باد", Mesra2 = "دوش آگهی ز يار سفرکرده داد باد",},
new Hafez{ Id= 852, BeytNo = 2, GhazalNo = 102, Mesra1 = "کارم بدان رسيد که همراز خود کنم", Mesra2 = "هر شام برق لامع و هر بامداد باد",},
new Hafez{ Id= 853, BeytNo = 3, GhazalNo = 102, Mesra1 = "در چين طره تو دل بی حفاظ من", Mesra2 = "هرگز نگفت مسکن مالوف ياد باد",},
new Hafez{ Id= 854, BeytNo = 4, GhazalNo = 102, Mesra1 = "امروز قدر پند عزيزان شناختم", Mesra2 = "يا رب روان ناصح ما از تو شاد باد",},
new Hafez{ Id= 855, BeytNo = 5, GhazalNo = 102, Mesra1 = "خون شد دلم به ياد تو هر گه که در چمن", Mesra2 = "بند قبای غنچه گل می‌گشاد باد",},
new Hafez{ Id= 856, BeytNo = 6, GhazalNo = 102, Mesra1 = "از دست رفته بود وجود ضعيف من", Mesra2 = "صبحم به بوی وصل تو جان بازداد باد",},
new Hafez{ Id= 857, BeytNo = 7, GhazalNo = 102, Mesra1 = "حافظ نهاد نيک تو کامت برآورد", Mesra2 = "جان‌ها فدای مردم نيکونهاد باد",},
new Hafez{ Id= 858, BeytNo = 1, GhazalNo = 103, Mesra1 = "روز وصل دوستداران ياد باد", Mesra2 = "ياد باد آن روزگاران ياد باد",},
new Hafez{ Id= 859, BeytNo = 2, GhazalNo = 103, Mesra1 = "کامم از تلخی غم چون زهر گشت", Mesra2 = "بانگ نوش شادخواران ياد باد",},
new Hafez{ Id= 860, BeytNo = 3, GhazalNo = 103, Mesra1 = "گر چه ياران فارغند از ياد من", Mesra2 = "از من ايشان را هزاران ياد باد",},
new Hafez{ Id= 861, BeytNo = 4, GhazalNo = 103, Mesra1 = "مبتلا گشتم در اين بند و بلا", Mesra2 = "کوشش آن حق گزاران ياد باد",},
new Hafez{ Id= 862, BeytNo = 5, GhazalNo = 103, Mesra1 = "گر چه صد رود است در چشمم مدام", Mesra2 = "زنده رود باغ کاران ياد باد",},
new Hafez{ Id= 863, BeytNo = 6, GhazalNo = 103, Mesra1 = "راز حافظ بعد از اين ناگفته ماند", Mesra2 = "ای دريغا رازداران ياد باد",},
new Hafez{ Id= 864, BeytNo = 1, GhazalNo = 104, Mesra1 = "جمالت آفتاب هر نظر باد", Mesra2 = "ز خوبی روی خوبت خوبتر باد",},
new Hafez{ Id= 865, BeytNo = 2, GhazalNo = 104, Mesra1 = "همای زلف شاهين شهپرت را", Mesra2 = "دل شاهان عالم زير پر باد",},
new Hafez{ Id= 866, BeytNo = 3, GhazalNo = 104, Mesra1 = "کسی کو بسته زلفت نباشد", Mesra2 = "چو زلفت درهم و زير و زبر باد",},
new Hafez{ Id= 867, BeytNo = 4, GhazalNo = 104, Mesra1 = "دلی کو عاشق رويت نباشد", Mesra2 = "هميشه غرقه در خون جگر باد",},
new Hafez{ Id= 868, BeytNo = 5, GhazalNo = 104, Mesra1 = "بتا چون غمزه‌ات ناوک فشاند", Mesra2 = "دل مجروح من پيشش سپر باد",},
new Hafez{ Id= 869, BeytNo = 6, GhazalNo = 104, Mesra1 = "چو لعل شکرينت بوسه بخشد", Mesra2 = "مذاق جان من ز او پرشکر باد",},
new Hafez{ Id= 870, BeytNo = 7, GhazalNo = 104, Mesra1 = "مرا از توست هر دم تازه عشقی", Mesra2 = "تو را هر ساعتی حسنی دگر باد",},
new Hafez{ Id= 871, BeytNo = 8, GhazalNo = 104, Mesra1 = "به جان مشتاق روی توست حافظ", Mesra2 = "تو را در حال مشتاقان نظر باد",},
new Hafez{ Id= 872, BeytNo = 1, GhazalNo = 105, Mesra1 = "صوفی ار باده به اندازه خورد نوشش باد", Mesra2 = "ور نه انديشه اين کار فراموشش باد",},
new Hafez{ Id= 873, BeytNo = 2, GhazalNo = 105, Mesra1 = "آن که يک جرعه می از دست تواند دادن", Mesra2 = "دست با شاهد مقصود در آغوشش باد",},
new Hafez{ Id= 874, BeytNo = 3, GhazalNo = 105, Mesra1 = "پير ما گفت خطا بر قلم صنع نرفت", Mesra2 = "آفرين بر نظر پاک خطاپوشش باد",},
new Hafez{ Id= 875, BeytNo = 4, GhazalNo = 105, Mesra1 = "شاه ترکان سخن مدعيان می‌شنود", Mesra2 = "شرمی از مظلمه خون سياووشش باد",},
new Hafez{ Id= 876, BeytNo = 5, GhazalNo = 105, Mesra1 = "گر چه از کبر سخن با من درويش نگفت", Mesra2 = "جان فدای شکرين پسته خاموشش باد",},
new Hafez{ Id= 877, BeytNo = 6, GhazalNo = 105, Mesra1 = "چشمم از آينه داران خط و خالش گشت", Mesra2 = "لبم از بوسه ربايان بر و دوشش باد",},
new Hafez{ Id= 878, BeytNo = 7, GhazalNo = 105, Mesra1 = "نرگس مست نوازش کن مردم دارش", Mesra2 = "خون عاشق به قدح گر بخورد نوشش باد",},
new Hafez{ Id= 879, BeytNo = 8, GhazalNo = 105, Mesra1 = "به غلامی تو مشهور جهان شد حافظ", Mesra2 = "حلقه بندگی زلف تو در گوشش باد",},
new Hafez{ Id= 880, BeytNo = 1, GhazalNo = 106, Mesra1 = "تنت به ناز طبيبان نيازمند مباد", Mesra2 = "وجود نازکت آزرده گزند مباد",},
new Hafez{ Id= 881, BeytNo = 2, GhazalNo = 106, Mesra1 = "سلامت همه آفاق در سلامت توست", Mesra2 = "به هيچ عارضه شخص تو دردمند مباد",},
new Hafez{ Id= 882, BeytNo = 3, GhazalNo = 106, Mesra1 = "جمال صورت و معنی ز امن صحت توست", Mesra2 = "که ظاهرت دژم و باطنت نژند مباد",},
new Hafez{ Id= 883, BeytNo = 4, GhazalNo = 106, Mesra1 = "در اين چمن چو درآيد خزان به يغمايی", Mesra2 = "رهش به سرو سهی قامت بلند مباد",},
new Hafez{ Id= 884, BeytNo = 5, GhazalNo = 106, Mesra1 = "در آن بساط که حسن تو جلوه آغازد", Mesra2 = "مجال طعنه بدبين و بدپسند مباد",},
new Hafez{ Id= 885, BeytNo = 6, GhazalNo = 106, Mesra1 = "هر آن که روی چو ماهت به چشم بد بيند", Mesra2 = "بر آتش تو بجز جان او سپند مباد",},
new Hafez{ Id= 886, BeytNo = 7, GhazalNo = 106, Mesra1 = "شفا ز گفته شکرفشان حافظ جوی", Mesra2 = "که حاجتت به علاج گلاب و قند مباد",},
new Hafez{ Id= 887, BeytNo = 1, GhazalNo = 107, Mesra1 = "حسن تو هميشه در فزون باد", Mesra2 = "رويت همه ساله لاله گون باد",},
new Hafez{ Id= 888, BeytNo = 2, GhazalNo = 107, Mesra1 = "اندر سر ما خيال عشقت", Mesra2 = "هر روز که باد در فزون باد",},
new Hafez{ Id= 889, BeytNo = 3, GhazalNo = 107, Mesra1 = "هر سرو که در چمن درآيد", Mesra2 = "در خدمت قامتت نگون باد",},
new Hafez{ Id= 890, BeytNo = 4, GhazalNo = 107, Mesra1 = "چشمی که نه فتنه تو باشد", Mesra2 = "چون گوهر اشک غرق خون باد",},
new Hafez{ Id= 891, BeytNo = 5, GhazalNo = 107, Mesra1 = "چشم تو ز بهر دلربايی", Mesra2 = "در کردن سحر ذوفنون باد",},
new Hafez{ Id= 892, BeytNo = 6, GhazalNo = 107, Mesra1 = "هر جا که دليست در غم تو", Mesra2 = "بی صبر و قرار و بی سکون باد",},
new Hafez{ Id= 893, BeytNo = 7, GhazalNo = 107, Mesra1 = "قد همه دلبران عالم", Mesra2 = "پيش الف قدت چو نون باد",},
new Hafez{ Id= 894, BeytNo = 8, GhazalNo = 107, Mesra1 = "هر دل که ز عشق توست خالی", Mesra2 = "از حلقه وصل تو برون باد",},
new Hafez{ Id= 895, BeytNo = 9, GhazalNo = 107, Mesra1 = "لعل تو که هست جان حافظ", Mesra2 = "دور از لب مردمان دون باد",},
new Hafez{ Id= 896, BeytNo = 1, GhazalNo = 108, Mesra1 = "خسروا گوی فلک در خم چوگان تو باد", Mesra2 = "ساحت کون و مکان عرصه ميدان تو باد",},
new Hafez{ Id= 897, BeytNo = 2, GhazalNo = 108, Mesra1 = "زلف خاتون ظفر شيفته پرچم توست", Mesra2 = "ديده فتح ابد عاشق جولان تو باد",},
new Hafez{ Id= 898, BeytNo = 3, GhazalNo = 108, Mesra1 = "ای که انشا عطارد صفت شوکت توست", Mesra2 = "عقل کل چاکر طغراکش ديوان تو باد",},
new Hafez{ Id= 899, BeytNo = 4, GhazalNo = 108, Mesra1 = "طيره جلوه طوبی قد چون سرو تو شد", Mesra2 = "غيرت خلد برين ساحت بستان تو باد",},
new Hafez{ Id= 900, BeytNo = 5, GhazalNo = 108, Mesra1 = "نه به تنها حيوانات و نباتات و جماد", Mesra2 = "هر چه در عالم امر است به فرمان تو باد",},
new Hafez{ Id= 901, BeytNo = 1, GhazalNo = 109, Mesra1 = "دير است که دلدار پيامی نفرستاد", Mesra2 = "ننوشت سلامی و کلامی نفرستاد",},
new Hafez{ Id= 902, BeytNo = 2, GhazalNo = 109, Mesra1 = "صد نامه فرستادم و آن شاه سواران", Mesra2 = "پيکی ندوانيد و سلامی نفرستاد",},
new Hafez{ Id= 903, BeytNo = 3, GhazalNo = 109, Mesra1 = "سوی من وحشی صفت عقل رميده", Mesra2 = "آهوروشی کبک خرامی نفرستاد",},
new Hafez{ Id= 904, BeytNo = 4, GhazalNo = 109, Mesra1 = "دانست که خواهد شدنم مرغ دل از دست", Mesra2 = "و از آن خط چون سلسله دامی نفرستاد",},
new Hafez{ Id= 905, BeytNo = 5, GhazalNo = 109, Mesra1 = "فرياد که آن ساقی شکرلب سرمست", Mesra2 = "دانست که مخمورم و جامی نفرستاد",},
new Hafez{ Id= 906, BeytNo = 6, GhazalNo = 109, Mesra1 = "چندان که زدم لاف کرامات و مقامات", Mesra2 = "هيچم خبر از هيچ مقامی نفرستاد",},
new Hafez{ Id= 907, BeytNo = 7, GhazalNo = 109, Mesra1 = "حافظ به ادب باش که واخواست نباشد", Mesra2 = "گر شاه پيامی به غلامی نفرستاد",},
new Hafez{ Id= 908, BeytNo = 1, GhazalNo = 110, Mesra1 = "پيرانه سرم عشق جوانی به سر افتاد", Mesra2 = "وان راز که در دل بنهفتم به درافتاد",},
new Hafez{ Id= 909, BeytNo = 2, GhazalNo = 110, Mesra1 = "از راه نظر مرغ دلم گشت هواگير", Mesra2 = "ای ديده نگه کن که به دام که درافتاد",},
new Hafez{ Id= 910, BeytNo = 3, GhazalNo = 110, Mesra1 = "دردا که از آن آهوی مشکين سيه چشم", Mesra2 = "چون نافه بسی خون دلم در جگر افتاد",},
new Hafez{ Id= 911, BeytNo = 4, GhazalNo = 110, Mesra1 = "از رهگذر خاک سر کوی شما بود", Mesra2 = "هر نافه که در دست نسيم سحر افتاد",},
new Hafez{ Id= 912, BeytNo = 5, GhazalNo = 110, Mesra1 = "مژگان تو تا تيغ جهان گير برآورد", Mesra2 = "بس کشته دل زنده که بر يک دگر افتاد",},
new Hafez{ Id= 913, BeytNo = 6, GhazalNo = 110, Mesra1 = "بس تجربه کرديم در اين دير مکافات", Mesra2 = "با دردکشان هر که درافتاد برافتاد",},
new Hafez{ Id= 914, BeytNo = 7, GhazalNo = 110, Mesra1 = "گر جان بدهد سنگ سيه لعل نگردد", Mesra2 = "با طينت اصلی چه کند بدگهر افتاد",},
new Hafez{ Id= 915, BeytNo = 8, GhazalNo = 110, Mesra1 = "حافظ که سر زلف بتان دست کشش بود", Mesra2 = "بس طرفه حريفيست کش اکنون به سر افتاد",},
new Hafez{ Id= 916, BeytNo = 1, GhazalNo = 111, Mesra1 = "عکس روی تو چو در آينه جام افتاد", Mesra2 = "عارف از خنده می در طمع خام افتاد",},
new Hafez{ Id= 917, BeytNo = 2, GhazalNo = 111, Mesra1 = "حسن روی تو به يک جلوه که در آينه کرد", Mesra2 = "اين همه نقش در آيينه اوهام افتاد",},
new Hafez{ Id= 918, BeytNo = 3, GhazalNo = 111, Mesra1 = "اين همه عکس می و نقش نگارين که نمود", Mesra2 = "يک فروغ رخ ساقيست که در جام افتاد",},
new Hafez{ Id= 919, BeytNo = 4, GhazalNo = 111, Mesra1 = "غيرت عشق زبان همه خاصان ببريد", Mesra2 = "کز کجا سر غمش در دهن عام افتاد",},
new Hafez{ Id= 920, BeytNo = 5, GhazalNo = 111, Mesra1 = "من ز مسجد به خرابات نه خود افتادم", Mesra2 = "اينم از عهد ازل حاصل فرجام افتاد",},
new Hafez{ Id= 921, BeytNo = 6, GhazalNo = 111, Mesra1 = "چه کند کز پی دوران نرود چون پرگار", Mesra2 = "هر که در دايره گردش ايام افتاد",},
new Hafez{ Id= 922, BeytNo = 7, GhazalNo = 111, Mesra1 = "در خم زلف تو آويخت دل از چاه زنخ", Mesra2 = "آه کز چاه برون آمد و در دام افتاد",},
new Hafez{ Id= 923, BeytNo = 8, GhazalNo = 111, Mesra1 = "آن شد ای خواجه که در صومعه بازم بينی", Mesra2 = "کار ما با رخ ساقی و لب جام افتاد",},
new Hafez{ Id= 924, BeytNo = 9, GhazalNo = 111, Mesra1 = "زير شمشير غمش رقص کنان بايد رفت", Mesra2 = "کان که شد کشته او نيک سرانجام افتاد",},
new Hafez{ Id= 925, BeytNo = 10, GhazalNo = 111, Mesra1 = "هر دمش با من دلسوخته لطفی دگر است", Mesra2 = "اين گدا بين که چه شايسته انعام افتاد",},
new Hafez{ Id= 926, BeytNo = 11, GhazalNo = 111, Mesra1 = "صوفيان جمله حريفند و نظرباز ولی", Mesra2 = "زين ميان حافظ دلسوخته بدنام افتاد",},
new Hafez{ Id= 927, BeytNo = 1, GhazalNo = 112, Mesra1 = "آن که رخسار تو را رنگ گل و نسرين داد", Mesra2 = "صبر و آرام تواند به من مسکين داد",},
new Hafez{ Id= 928, BeytNo = 2, GhazalNo = 112, Mesra1 = "وان که گيسوی تو را رسم تطاول آموخت", Mesra2 = "هم تواند کرمش داد من غمگين داد",},
new Hafez{ Id= 929, BeytNo = 3, GhazalNo = 112, Mesra1 = "من همان روز ز فرهاد طمع ببريدم", Mesra2 = "که عنان دل شيدا به لب شيرين داد",},
new Hafez{ Id= 930, BeytNo = 4, GhazalNo = 112, Mesra1 = "گنج زر گر نبود کنج قناعت باقيست", Mesra2 = "آن که آن داد به شاهان به گدايان اين داد",},
new Hafez{ Id= 931, BeytNo = 5, GhazalNo = 112, Mesra1 = "خوش عروسيست جهان از ره صورت ليکن", Mesra2 = "هر که پيوست بدو عمر خودش کاوين داد",},
new Hafez{ Id= 932, BeytNo = 6, GhazalNo = 112, Mesra1 = "بعد از اين دست من و دامن سرو و لب جوی", Mesra2 = "خاصه اکنون که صبا مژده فروردين داد",},
new Hafez{ Id= 933, BeytNo = 7, GhazalNo = 112, Mesra1 = "در کف غصه دوران دل حافظ خون شد", Mesra2 = "از فراق رخت ای خواجه قوام الدين داد",},
new Hafez{ Id= 934, BeytNo = 1, GhazalNo = 113, Mesra1 = "بنفشه دوش به گل گفت و خوش نشانی داد", Mesra2 = "که تاب من به جهان طره فلانی داد",},
new Hafez{ Id= 935, BeytNo = 2, GhazalNo = 113, Mesra1 = "دلم خزانه اسرار بود و دست قضا", Mesra2 = "درش ببست و کليدش به دلستانی داد",},
new Hafez{ Id= 936, BeytNo = 3, GhazalNo = 113, Mesra1 = "شکسته وار به درگاهت آمدم که طبيب", Mesra2 = "به موميايی لطف توام نشانی داد",},
new Hafez{ Id= 937, BeytNo = 4, GhazalNo = 113, Mesra1 = "تنش درست و دلش شاد باد و خاطر خوش", Mesra2 = "که دست دادش و ياری ناتوانی داد",},
new Hafez{ Id= 938, BeytNo = 5, GhazalNo = 113, Mesra1 = "برو معالجه خود کن ای نصيحتگو", Mesra2 = "شراب و شاهد شيرين که را زيانی داد",},
new Hafez{ Id= 939, BeytNo = 6, GhazalNo = 113, Mesra1 = "گذشت بر من مسکين و با رقيبان گفت", Mesra2 = "دريغ حافظ مسکين من چه جانی داد",},
new Hafez{ Id= 940, BeytNo = 1, GhazalNo = 114, Mesra1 = "همای اوج سعادت به دام ما افتد", Mesra2 = "اگر تو را گذری بر مقام ما افتد",},
new Hafez{ Id= 941, BeytNo = 2, GhazalNo = 114, Mesra1 = "حباب وار براندازم از نشاط کلاه", Mesra2 = "اگر ز روی تو عکسی به جام ما افتد",},
new Hafez{ Id= 942, BeytNo = 3, GhazalNo = 114, Mesra1 = "شبی که ماه مراد از افق شود طالع", Mesra2 = "بود که پرتو نوری به بام ما افتد",},
new Hafez{ Id= 943, BeytNo = 4, GhazalNo = 114, Mesra1 = "به بارگاه تو چون باد را نباشد بار", Mesra2 = "کی اتفاق مجال سلام ما افتد",},
new Hafez{ Id= 944, BeytNo = 5, GhazalNo = 114, Mesra1 = "چو جان فدای لبش شد خيال می‌بستم", Mesra2 = "که قطره‌ای ز زلالش به کام ما افتد",},
new Hafez{ Id= 945, BeytNo = 6, GhazalNo = 114, Mesra1 = "خيال زلف تو گفتا که جان وسيله مساز", Mesra2 = "کز اين شکار فراوان به دام ما افتد",},
new Hafez{ Id= 946, BeytNo = 7, GhazalNo = 114, Mesra1 = "به نااميدی از اين در مرو بزن فالی", Mesra2 = "بود که قرعه دولت به نام ما افتد",},
new Hafez{ Id= 947, BeytNo = 8, GhazalNo = 114, Mesra1 = "ز خاک کوی تو هر گه که دم زند حافظ", Mesra2 = "نسيم گلشن جان در مشام ما افتد",},
new Hafez{ Id= 948, BeytNo = 1, GhazalNo = 115, Mesra1 = "درخت دوستی بنشان که کام دل به بار آرد", Mesra2 = "نهال دشمنی برکن که رنج بی‌شمار آرد",},
new Hafez{ Id= 949, BeytNo = 2, GhazalNo = 115, Mesra1 = "چو مهمان خراباتی به عزت باش با رندان", Mesra2 = "که درد سر کشی جانا گرت مستی خمار آرد",},
new Hafez{ Id= 950, BeytNo = 3, GhazalNo = 115, Mesra1 = "شب صحبت غنيمت دان که بعد از روزگار ما", Mesra2 = "بسی گردش کند گردون بسی ليل و نهار آرد",},
new Hafez{ Id= 951, BeytNo = 4, GhazalNo = 115, Mesra1 = "عماری دار ليلی را که مهد ماه در حکم است", Mesra2 = "خدا را در دل اندازش که بر مجنون گذار آرد",},
new Hafez{ Id= 952, BeytNo = 5, GhazalNo = 115, Mesra1 = "بهار عمر خواه ای دل وگرنه اين چمن هر سال", Mesra2 = "چو نسرين صد گل آرد بار و چون بلبل هزار آرد",},
new Hafez{ Id= 953, BeytNo = 6, GhazalNo = 115, Mesra1 = "خدا را چون دل ريشم قراری بست با زلفت", Mesra2 = "بفرما لعل نوشين را که زودش باقرار آرد",},
new Hafez{ Id= 954, BeytNo = 7, GhazalNo = 115, Mesra1 = "در اين باغ از خدا خواهد دگر پيرانه سر حافظ", Mesra2 = "نشيند بر لب جويی و سروی در کنار آرد",},
new Hafez{ Id= 955, BeytNo = 1, GhazalNo = 116, Mesra1 = "کسی که حسن و خط دوست در نظر دارد", Mesra2 = "محقق است که او حاصل بصر دارد",},
new Hafez{ Id= 956, BeytNo = 2, GhazalNo = 116, Mesra1 = "چو خامه در ره فرمان او سر طاعت", Mesra2 = "نهاده‌ايم مگر او به تيغ بردارد",},
new Hafez{ Id= 957, BeytNo = 3, GhazalNo = 116, Mesra1 = "کسی به وصل تو چون شمع يافت پروانه", Mesra2 = "که زير تيغ تو هر دم سری دگر دارد",},
new Hafez{ Id= 958, BeytNo = 4, GhazalNo = 116, Mesra1 = "به پای بوس تو دست کسی رسيد که او", Mesra2 = "چو آستانه بدين در هميشه سر دارد",},
new Hafez{ Id= 959, BeytNo = 5, GhazalNo = 116, Mesra1 = "ز زهد خشک ملولم کجاست باده ناب", Mesra2 = "که بوی باده مدامم دماغ تر دارد",},
new Hafez{ Id= 960, BeytNo = 6, GhazalNo = 116, Mesra1 = "ز باده هيچت اگر نيست اين نه بس که تو را", Mesra2 = "دمی ز وسوسه عقل بی‌خبر دارد",},
new Hafez{ Id= 961, BeytNo = 7, GhazalNo = 116, Mesra1 = "کسی که از ره تقوا قدم برون ننهاد", Mesra2 = "به عزم ميکده اکنون ره سفر دارد",},
new Hafez{ Id= 962, BeytNo = 8, GhazalNo = 116, Mesra1 = "دل شکسته حافظ به خاک خواهد برد", Mesra2 = "چو لاله داغ هوايی که بر جگر دارد",},
new Hafez{ Id= 963, BeytNo = 1, GhazalNo = 117, Mesra1 = "دل ما به دور رويت ز چمن فراغ دارد", Mesra2 = "که چو سرو پايبند است و چو لاله داغ دارد",},
new Hafez{ Id= 964, BeytNo = 2, GhazalNo = 117, Mesra1 = "سر ما فرونيايد به کمان ابروی کس", Mesra2 = "که درون گوشه گيران ز جهان فراغ دارد",},
new Hafez{ Id= 965, BeytNo = 3, GhazalNo = 117, Mesra1 = "ز بنفشه تاب دارم که ز زلف او زند دم", Mesra2 = "تو سياه کم بها بين که چه در دماغ دارد",},
new Hafez{ Id= 966, BeytNo = 4, GhazalNo = 117, Mesra1 = "به چمن خرام و بنگر بر تخت گل که لاله", Mesra2 = "به نديم شاه ماند که به کف اياغ دارد",},
new Hafez{ Id= 967, BeytNo = 5, GhazalNo = 117, Mesra1 = "شب ظلمت و بيابان به کجا توان رسيدن", Mesra2 = "مگر آن که شمع رويت به رهم چراغ دارد",},
new Hafez{ Id= 968, BeytNo = 6, GhazalNo = 117, Mesra1 = "من و شمع صبحگاهی سزد ار به هم بگرييم", Mesra2 = "که بسوختيم و از ما بت ما فراغ دارد",},
new Hafez{ Id= 969, BeytNo = 7, GhazalNo = 117, Mesra1 = "سزدم چو ابر بهمن که بر اين چمن بگريم", Mesra2 = "طرب آشيان بلبل بنگر که زاغ دارد",},
new Hafez{ Id= 970, BeytNo = 8, GhazalNo = 117, Mesra1 = "سر درس عشق دارد دل دردمند حافظ", Mesra2 = "که نه خاطر تماشا نه هوای باغ دارد",},
new Hafez{ Id= 971, BeytNo = 1, GhazalNo = 118, Mesra1 = "آن کس که به دست جام دارد", Mesra2 = "سلطانی جم مدام دارد",},
new Hafez{ Id= 972, BeytNo = 2, GhazalNo = 118, Mesra1 = "آبی که خضر حيات از او يافت", Mesra2 = "در ميکده جو که جام دارد",},
new Hafez{ Id= 973, BeytNo = 3, GhazalNo = 118, Mesra1 = "سررشته جان به جام بگذار", Mesra2 = "کاين رشته از او نظام دارد",},
new Hafez{ Id= 974, BeytNo = 4, GhazalNo = 118, Mesra1 = "ما و می و زاهدان و تقوا", Mesra2 = "تا يار سر کدام دارد",},
new Hafez{ Id= 975, BeytNo = 5, GhazalNo = 118, Mesra1 = "بيرون ز لب تو ساقيا نيست", Mesra2 = "در دور کسی که کام دارد",},
new Hafez{ Id= 976, BeytNo = 6, GhazalNo = 118, Mesra1 = "نرگس همه شيوه‌های مستی", Mesra2 = "از چشم خوشت به وام دارد",},
new Hafez{ Id= 977, BeytNo = 7, GhazalNo = 118, Mesra1 = "ذکر رخ و زلف تو دلم را", Mesra2 = "ورديست که صبح و شام دارد",},
new Hafez{ Id= 978, BeytNo = 8, GhazalNo = 118, Mesra1 = "بر سينه ريش دردمندان", Mesra2 = "لعلت نمکی تمام دارد",},
new Hafez{ Id= 979, BeytNo = 9, GhazalNo = 118, Mesra1 = "در چاه ذقن چو حافظ ای جان", Mesra2 = "حسن تو دو صد غلام دارد",},
new Hafez{ Id= 980, BeytNo = 1, GhazalNo = 119, Mesra1 = "دلی که غيب نمای است و جام جم دارد", Mesra2 = "ز خاتمی که دمی گم شود چه غم دارد",},
new Hafez{ Id= 981, BeytNo = 2, GhazalNo = 119, Mesra1 = "به خط و خال گدايان مده خزينه دل", Mesra2 = "به دست شاهوشی ده که محترم دارد",},
new Hafez{ Id= 982, BeytNo = 3, GhazalNo = 119, Mesra1 = "نه هر درخت تحمل کند جفای خزان", Mesra2 = "غلام همت سروم که اين قدم دارد",},
new Hafez{ Id= 983, BeytNo = 4, GhazalNo = 119, Mesra1 = "رسيد موسم آن کز طرب چو نرگس مست", Mesra2 = "نهد به پای قدح هر که شش درم دارد",},
new Hafez{ Id= 984, BeytNo = 5, GhazalNo = 119, Mesra1 = "زر از بهای می اکنون چو گل دريغ مدار", Mesra2 = "که عقل کل به صدت عيب متهم دارد",},
new Hafez{ Id= 985, BeytNo = 6, GhazalNo = 119, Mesra1 = "ز سر غيب کس آگاه نيست قصه مخوان", Mesra2 = "کدام محرم دل ره در اين حرم دارد",},
new Hafez{ Id= 986, BeytNo = 7, GhazalNo = 119, Mesra1 = "دلم که لاف تجرد زدی کنون صد شغل", Mesra2 = "به بوی زلف تو با باد صبحدم دارد",},
new Hafez{ Id= 987, BeytNo = 8, GhazalNo = 119, Mesra1 = "مراد دل ز که پرسم که نيست دلداری", Mesra2 = "که جلوه نظر و شيوه کرم دارد",},
new Hafez{ Id= 988, BeytNo = 9, GhazalNo = 119, Mesra1 = "ز جيب خرقه حافظ چه طرف بتوان بست", Mesra2 = "که ما صمد طلبيديم و او صنم دارد",},
new Hafez{ Id= 989, BeytNo = 1, GhazalNo = 120, Mesra1 = "بتی دارم که گرد گل ز سنبل سايه بان دارد", Mesra2 = "بهار عارضش خطی به خون ارغوان دارد",},
new Hafez{ Id= 990, BeytNo = 2, GhazalNo = 120, Mesra1 = "غبار خط بپوشانيد خورشيد رخش يا رب", Mesra2 = "بقای جاودانش ده که حسن جاودان دارد",},
new Hafez{ Id= 991, BeytNo = 3, GhazalNo = 120, Mesra1 = "چو عاشق می‌شدم گفتم که بردم گوهر مقصود", Mesra2 = "ندانستم که اين دريا چه موج خون فشان دارد",},
new Hafez{ Id= 992, BeytNo = 4, GhazalNo = 120, Mesra1 = "ز چشمت جان نشايد برد کز هر سو که می‌بينم", Mesra2 = "کمين از گوشه‌ای کرده‌ست و تير اندر کمان دارد",},
new Hafez{ Id= 993, BeytNo = 5, GhazalNo = 120, Mesra1 = "چو دام طره افشاند ز گرد خاطر عشاق", Mesra2 = "به غماز صبا گويد که راز ما نهان دارد",},
new Hafez{ Id= 994, BeytNo = 6, GhazalNo = 120, Mesra1 = "بيفشان جرعه‌ای بر خاک و حال اهل دل بشنو", Mesra2 = "که از جمشيد و کيخسرو فراوان داستان دارد",},
new Hafez{ Id= 995, BeytNo = 7, GhazalNo = 120, Mesra1 = "چو در رويت بخندد گل مشو در دامش ای بلبل", Mesra2 = "که بر گل اعتمادی نيست گر حسن جهان دارد",},
new Hafez{ Id= 996, BeytNo = 8, GhazalNo = 120, Mesra1 = "خدا را داد من بستان از او ای شحنه مجلس", Mesra2 = "که می با ديگری خورده‌ست و با من سر گران دارد",},
new Hafez{ Id= 997, BeytNo = 9, GhazalNo = 120, Mesra1 = "به فتراک ار همی‌بندی خدا را زود صيدم کن", Mesra2 = "که آفت‌هاست در تاخير و طالب را زيان دارد",},
new Hafez{ Id= 998, BeytNo = 10, GhazalNo = 120, Mesra1 = "ز سروقد دلجويت مکن محروم چشمم را", Mesra2 = "بدين سرچشمه‌اش بنشان که خوش آبی روان دارد",},
new Hafez{ Id= 999, BeytNo = 11, GhazalNo = 120, Mesra1 = "ز خوف هجرم ايمن کن اگر اميد آن داری", Mesra2 = "که از چشم بدانديشان خدايت در امان دارد",},
new Hafez{ Id= 1000, BeytNo = 12, GhazalNo = 120, Mesra1 = "چه عذر بخت خود گويم که آن عيار شهرآشوب", Mesra2 = "به تلخی کشت حافظ را و شکر در دهان دارد",},
new Hafez{ Id= 1001, BeytNo = 1, GhazalNo = 121, Mesra1 = "هر آن کو خاطر مجموع و يار نازنين دارد", Mesra2 = "سعادت همدم او گشت و دولت همنشين دارد",},
new Hafez{ Id= 1002, BeytNo = 2, GhazalNo = 121, Mesra1 = "حريم عشق را درگه بسی بالاتر از عقل است", Mesra2 = "کسی آن آستان بوسد که جان در آستين دارد",},
new Hafez{ Id= 1003, BeytNo = 3, GhazalNo = 121, Mesra1 = "دهان تنگ شيرينش مگر ملک سليمان است", Mesra2 = "که نقش خاتم لعلش جهان زير نگين دارد",},
new Hafez{ Id= 1004, BeytNo = 4, GhazalNo = 121, Mesra1 = "لب لعل و خط مشکين چو آنش هست و اينش هست", Mesra2 = "بنازم دلبر خود را که حسنش آن و اين دارد",},
new Hafez{ Id= 1005, BeytNo = 5, GhazalNo = 121, Mesra1 = "به خواری منگر ای منعم ضعيفان و نحيفان را", Mesra2 = "که صدر مجلس عشرت گدای رهنشين دارد",},
new Hafez{ Id= 1006, BeytNo = 6, GhazalNo = 121, Mesra1 = "چو بر روی زمين باشی توانايی غنيمت دان", Mesra2 = "که دوران ناتوانی‌ها بسی زير زمين دارد",},
new Hafez{ Id= 1007, BeytNo = 7, GhazalNo = 121, Mesra1 = "بلاگردان جان و تن دعای مستمندان است", Mesra2 = "که بيند خير از آن خرمن که ننگ از خوشه چين دارد",},
new Hafez{ Id= 1008, BeytNo = 8, GhazalNo = 121, Mesra1 = "صبا از عشق من رمزی بگو با آن شه خوبان", Mesra2 = "که صد جمشيد و کيخسرو غلام کمترين دارد",},
new Hafez{ Id= 1009, BeytNo = 9, GhazalNo = 121, Mesra1 = "و گر گويد نمی‌خواهم چو حافظ عاشق مفلس", Mesra2 = "بگوييدش که سلطانی گدايی همنشين دارد",},
new Hafez{ Id= 1010, BeytNo = 1, GhazalNo = 122, Mesra1 = "هر آن که جانب اهل خدا نگه دارد", Mesra2 = "خداش در همه حال از بلا نگه دارد",},
new Hafez{ Id= 1011, BeytNo = 2, GhazalNo = 122, Mesra1 = "حديث دوست نگويم مگر به حضرت دوست", Mesra2 = "که آشنا سخن آشنا نگه دارد",},
new Hafez{ Id= 1012, BeytNo = 3, GhazalNo = 122, Mesra1 = "دلا معاش چنان کن که گر بلغزد پای", Mesra2 = "فرشته‌ات به دو دست دعا نگه دارد",},
new Hafez{ Id= 1013, BeytNo = 4, GhazalNo = 122, Mesra1 = "گرت هواست که معشوق نگسلد پيمان", Mesra2 = "نگاه دار سر رشته تا نگه دارد",},
new Hafez{ Id= 1014, BeytNo = 5, GhazalNo = 122, Mesra1 = "صبا بر آن سر زلف ار دل مرا بينی", Mesra2 = "ز روی لطف بگويش که جا نگه دارد",},
new Hafez{ Id= 1015, BeytNo = 6, GhazalNo = 122, Mesra1 = "چو گفتمش که دلم را نگاه دار چه گفت", Mesra2 = "ز دست بنده چه خيزد خدا نگه دارد",},
new Hafez{ Id= 1016, BeytNo = 7, GhazalNo = 122, Mesra1 = "سر و زر و دل و جانم فدای آن ياری", Mesra2 = "که حق صحبت مهر و وفا نگه دارد",},
new Hafez{ Id= 1017, BeytNo = 8, GhazalNo = 122, Mesra1 = "غبار راه راهگذارت کجاست تا حافظ", Mesra2 = "به يادگار نسيم صبا نگه دارد",},
new Hafez{ Id= 1018, BeytNo = 1, GhazalNo = 123, Mesra1 = "مطرب عشق عجب ساز و نوايی دارد", Mesra2 = "نقش هر نغمه که زد راه به جايی دارد",},
new Hafez{ Id= 1019, BeytNo = 2, GhazalNo = 123, Mesra1 = "عالم از ناله عشاق مبادا خالی", Mesra2 = "که خوش آهنگ و فرح بخش هوايی دارد",},
new Hafez{ Id= 1020, BeytNo = 3, GhazalNo = 123, Mesra1 = "پير دردی کش ما گر چه ندارد زر و زور", Mesra2 = "خوش عطابخش و خطاپوش خدايی دارد",},
new Hafez{ Id= 1021, BeytNo = 4, GhazalNo = 123, Mesra1 = "محترم دار دلم کاين مگس قندپرست", Mesra2 = "تا هواخواه تو شد فر همايی دارد",},
new Hafez{ Id= 1022, BeytNo = 5, GhazalNo = 123, Mesra1 = "از عدالت نبود دور گرش پرسد حال", Mesra2 = "پادشاهی که به همسايه گدايی دارد",},
new Hafez{ Id= 1023, BeytNo = 6, GhazalNo = 123, Mesra1 = "اشک خونين بنمودم به طبيبان گفتند", Mesra2 = "درد عشق است و جگرسوز دوايی دارد",},
new Hafez{ Id= 1024, BeytNo = 7, GhazalNo = 123, Mesra1 = "ستم از غمزه مياموز که در مذهب عشق", Mesra2 = "هر عمل اجری و هر کرده جزايی دارد",},
new Hafez{ Id= 1025, BeytNo = 8, GhazalNo = 123, Mesra1 = "نغز گفت آن بت ترسابچه باده پرست", Mesra2 = "شادی روی کسی خور که صفايی دارد",},
new Hafez{ Id= 1026, BeytNo = 9, GhazalNo = 123, Mesra1 = "خسروا حافظ درگاه نشين فاتحه خواند", Mesra2 = "و از زبان تو تمنای دعايی دارد",},
new Hafez{ Id= 1027, BeytNo = 1, GhazalNo = 124, Mesra1 = "آن که از سنبل او غاليه تابی دارد", Mesra2 = "باز با دلشدگان ناز و عتابی دارد",},
new Hafez{ Id= 1028, BeytNo = 2, GhazalNo = 124, Mesra1 = "از سر کشته خود می‌گذری همچون باد", Mesra2 = "چه توان کرد که عمر است و شتابی دارد",},
new Hafez{ Id= 1029, BeytNo = 3, GhazalNo = 124, Mesra1 = "ماه خورشيد نمايش ز پس پرده زلف", Mesra2 = "آفتابيست که در پيش سحابی دارد",},
new Hafez{ Id= 1030, BeytNo = 4, GhazalNo = 124, Mesra1 = "چشم من کرد به هر گوشه روان سيل سرشک", Mesra2 = "تا سهی سرو تو را تازه‌تر آبی دارد",},
new Hafez{ Id= 1031, BeytNo = 5, GhazalNo = 124, Mesra1 = "غمزه شوخ تو خونم به خطا می‌ريزد", Mesra2 = "فرصتش باد که خوش فکر صوابی دارد",},
new Hafez{ Id= 1032, BeytNo = 6, GhazalNo = 124, Mesra1 = "آب حيوان اگر اين است که دارد لب دوست", Mesra2 = "روشن است اين که خضر بهره سرابی دارد",},
new Hafez{ Id= 1033, BeytNo = 7, GhazalNo = 124, Mesra1 = "چشم مخمور تو دارد ز دلم قصد جگر", Mesra2 = "ترک مست است مگر ميل کبابی دارد",},
new Hafez{ Id= 1034, BeytNo = 8, GhazalNo = 124, Mesra1 = "جان بيمار مرا نيست ز تو روی سال", Mesra2 = "ای خوش آن خسته که از دوست جوابی دارد",},
new Hafez{ Id= 1035, BeytNo = 9, GhazalNo = 124, Mesra1 = "کی کند سوی دل خسته حافظ نظری", Mesra2 = "چشم مستش که به هر گوشه خرابی دارد",},
new Hafez{ Id= 1036, BeytNo = 1, GhazalNo = 125, Mesra1 = "شاهد آن نيست که مويی و ميانی دارد", Mesra2 = "بنده طلعت آن باش که آنی دارد",},
new Hafez{ Id= 1037, BeytNo = 2, GhazalNo = 125, Mesra1 = "شيوه حور و پری گر چه لطيف است ولی", Mesra2 = "خوبی آن است و لطافت که فلانی دارد",},
new Hafez{ Id= 1038, BeytNo = 3, GhazalNo = 125, Mesra1 = "چشمه چشم مرا ای گل خندان درياب", Mesra2 = "که به اميد تو خوش آب روانی دارد",},
new Hafez{ Id= 1039, BeytNo = 4, GhazalNo = 125, Mesra1 = "گوی خوبی که برد از تو که خورشيد آن جا", Mesra2 = "نه سواريست که در دست عنانی دارد",},
new Hafez{ Id= 1040, BeytNo = 5, GhazalNo = 125, Mesra1 = "دل نشان شد سخنم تا تو قبولش کردی", Mesra2 = "آری آری سخن عشق نشانی دارد",},
new Hafez{ Id= 1041, BeytNo = 6, GhazalNo = 125, Mesra1 = "خم ابروی تو در صنعت تيراندازی", Mesra2 = "برده از دست هر آن کس که کمانی دارد",},
new Hafez{ Id= 1042, BeytNo = 7, GhazalNo = 125, Mesra1 = "در ره عشق نشد کس به يقين محرم راز", Mesra2 = "هر کسی بر حسب فکر گمانی دارد",},
new Hafez{ Id= 1043, BeytNo = 8, GhazalNo = 125, Mesra1 = "با خرابات نشينان ز کرامات ملاف", Mesra2 = "هر سخن وقتی و هر نکته مکانی دارد",},
new Hafez{ Id= 1044, BeytNo = 9, GhazalNo = 125, Mesra1 = "مرغ زيرک نزند در چمنش پرده سرای", Mesra2 = "هر بهاری که به دنباله خزانی دارد",},
new Hafez{ Id= 1045, BeytNo = 10, GhazalNo = 125, Mesra1 = "مدعی گو لغز و نکته به حافظ مفروش", Mesra2 = "کلک ما نيز زبانی و بيانی دارد",},
new Hafez{ Id= 1046, BeytNo = 1, GhazalNo = 126, Mesra1 = "جان بی جمال جانان ميل جهان ندارد", Mesra2 = "هر کس که اين ندارد حقا که آن ندارد",},
new Hafez{ Id= 1047, BeytNo = 2, GhazalNo = 126, Mesra1 = "با هيچ کس نشانی زان دلستان نديدم", Mesra2 = "يا من خبر ندارم يا او نشان ندارد",},
new Hafez{ Id= 1048, BeytNo = 3, GhazalNo = 126, Mesra1 = "هر شبنمی در اين ره صد بحر آتشين است", Mesra2 = "دردا که اين معما شرح و بيان ندارد",},
new Hafez{ Id= 1049, BeytNo = 4, GhazalNo = 126, Mesra1 = "سرمنزل فراغت نتوان ز دست دادن", Mesra2 = "ای ساروان فروکش کاين ره کران ندارد",},
new Hafez{ Id= 1050, BeytNo = 5, GhazalNo = 126, Mesra1 = "چنگ خميده قامت می‌خواندت به عشرت", Mesra2 = "بشنو که پند پيران هيچت زيان ندارد",},
new Hafez{ Id= 1051, BeytNo = 6, GhazalNo = 126, Mesra1 = "ای دل طريق رندی از محتسب بياموز", Mesra2 = "مست است و در حق او کس اين گمان ندارد",},
new Hafez{ Id= 1052, BeytNo = 7, GhazalNo = 126, Mesra1 = "احوال گنج قارون کايام داد بر باد", Mesra2 = "در گوش دل فروخوان تا زر نهان ندارد",},
new Hafez{ Id= 1053, BeytNo = 8, GhazalNo = 126, Mesra1 = "گر خود رقيب شمع است اسرار از او بپوشان", Mesra2 = "کان شوخ سربريده بند زبان ندارد",},
new Hafez{ Id= 1054, BeytNo = 9, GhazalNo = 126, Mesra1 = "کس در جهان ندارد يک بنده همچو حافظ", Mesra2 = "زيرا که چون تو شاهی کس در جهان ندارد",},
new Hafez{ Id= 1055, BeytNo = 1, GhazalNo = 127, Mesra1 = "روشنی طلعت تو ماه ندارد", Mesra2 = "پيش تو گل رونق گياه ندارد",},
new Hafez{ Id= 1056, BeytNo = 2, GhazalNo = 127, Mesra1 = "گوشه ابروی توست منزل جانم", Mesra2 = "خوشتر از اين گوشه پادشاه ندارد",},
new Hafez{ Id= 1057, BeytNo = 3, GhazalNo = 127, Mesra1 = "تا چه کند با رخ تو دود دل من", Mesra2 = "آينه دانی که تاب آه ندارد",},
new Hafez{ Id= 1058, BeytNo = 4, GhazalNo = 127, Mesra1 = "شوخی نرگس نگر که پيش تو بشکفت", Mesra2 = "چشم دريده ادب نگاه ندارد",},
new Hafez{ Id= 1059, BeytNo = 5, GhazalNo = 127, Mesra1 = "ديدم و آن چشم دل سيه که تو داری", Mesra2 = "جانب هيچ آشنا نگاه ندارد",},
new Hafez{ Id= 1060, BeytNo = 6, GhazalNo = 127, Mesra1 = "رطل گرانم ده ای مريد خرابات", Mesra2 = "شادی شيخی که خانقاه ندارد",},
new Hafez{ Id= 1061, BeytNo = 7, GhazalNo = 127, Mesra1 = "خون خور و خامش نشين که آن دل نازک", Mesra2 = "طاقت فرياد دادخواه ندارد",},
new Hafez{ Id= 1062, BeytNo = 8, GhazalNo = 127, Mesra1 = "گو برو و آستين به خون جگر شوی", Mesra2 = "هر که در اين آستانه راه ندارد",},
new Hafez{ Id= 1063, BeytNo = 9, GhazalNo = 127, Mesra1 = "نی من تنها کشم تطاول زلفت", Mesra2 = "کيست که او داغ آن سياه ندارد",},
new Hafez{ Id= 1064, BeytNo = 10, GhazalNo = 127, Mesra1 = "حافظ اگر سجده تو کرد مکن عيب", Mesra2 = "کافر عشق ای صنم گناه ندارد",},
new Hafez{ Id= 1065, BeytNo = 1, GhazalNo = 128, Mesra1 = "نيست در شهر نگاری که دل ما ببرد", Mesra2 = "بختم ار يار شود رختم از اين جا ببرد",},
new Hafez{ Id= 1066, BeytNo = 2, GhazalNo = 128, Mesra1 = "کو حريفی کش سرمست که پيش کرمش", Mesra2 = "عاشق سوخته دل نام تمنا ببرد",},
new Hafez{ Id= 1067, BeytNo = 3, GhazalNo = 128, Mesra1 = "باغبانا ز خزان بی‌خبرت می‌بينم", Mesra2 = "آه از آن روز که بادت گل رعنا ببرد",},
new Hafez{ Id= 1068, BeytNo = 4, GhazalNo = 128, Mesra1 = "رهزن دهر نخفته‌ست مشو ايمن از او", Mesra2 = "اگر امروز نبرده‌ست که فردا ببرد",},
new Hafez{ Id= 1069, BeytNo = 5, GhazalNo = 128, Mesra1 = "در خيال اين همه لعبت به هوس می‌بازم", Mesra2 = "بو که صاحب نظری نام تماشا ببرد",},
new Hafez{ Id= 1070, BeytNo = 6, GhazalNo = 128, Mesra1 = "علم و فضلی که به چل سال دلم جمع آورد", Mesra2 = "ترسم آن نرگس مستانه به يغما ببرد",},
new Hafez{ Id= 1071, BeytNo = 7, GhazalNo = 128, Mesra1 = "بانگ گاوی چه صدا بازدهد عشوه مخر", Mesra2 = "سامری کيست که دست از يد بيضا ببرد",},
new Hafez{ Id= 1072, BeytNo = 8, GhazalNo = 128, Mesra1 = "جام مينايی می سد ره تنگ دليست", Mesra2 = "منه از دست که سيل غمت از جا ببرد",},
new Hafez{ Id= 1073, BeytNo = 9, GhazalNo = 128, Mesra1 = "راه عشق ار چه کمينگاه کمانداران است", Mesra2 = "هر که دانسته رود صرفه ز اعدا ببرد",},
new Hafez{ Id= 1074, BeytNo = 10, GhazalNo = 128, Mesra1 = "حافظ ار جان طلبد غمزه مستانه يار", Mesra2 = "خانه از غير بپرداز و بهل تا ببرد",},
new Hafez{ Id= 1075, BeytNo = 1, GhazalNo = 129, Mesra1 = "اگر نه باده غم دل ز ياد ما ببرد", Mesra2 = "نهيب حادثه بنياد ما ز جا ببرد",},
new Hafez{ Id= 1076, BeytNo = 2, GhazalNo = 129, Mesra1 = "اگر نه عقل به مستی فروکشد لنگر", Mesra2 = "چگونه کشتی از اين ورطه بلا ببرد",},
new Hafez{ Id= 1077, BeytNo = 3, GhazalNo = 129, Mesra1 = "فغان که با همه کس غايبانه باخت فلک", Mesra2 = "که کس نبود که دستی از اين دغا ببرد",},
new Hafez{ Id= 1078, BeytNo = 4, GhazalNo = 129, Mesra1 = "گذار بر ظلمات است خضر راهی کو", Mesra2 = "مباد کتش محرومی آب ما ببرد",},
new Hafez{ Id= 1079, BeytNo = 5, GhazalNo = 129, Mesra1 = "دل ضعيفم از آن می‌کشد به طرف چمن", Mesra2 = "که جان ز مرگ به بيماری صبا ببرد",},
new Hafez{ Id= 1080, BeytNo = 6, GhazalNo = 129, Mesra1 = "طبيب عشق منم باده ده که اين معجون", Mesra2 = "فراغت آرد و انديشه خطا ببرد",},
new Hafez{ Id= 1081, BeytNo = 7, GhazalNo = 129, Mesra1 = "بسوخت حافظ و کس حال او به يار نگفت", Mesra2 = "مگر نسيم پيامی خدای را ببرد",},
new Hafez{ Id= 1082, BeytNo = 1, GhazalNo = 130, Mesra1 = "سحر بلبل حکايت با صبا کرد", Mesra2 = "که عشق روی گل با ما چه‌ها کرد",},
new Hafez{ Id= 1083, BeytNo = 2, GhazalNo = 130, Mesra1 = "از آن رنگ رخم خون در دل افتاد", Mesra2 = "و از آن گلشن به خارم مبتلا کرد",},
new Hafez{ Id= 1084, BeytNo = 3, GhazalNo = 130, Mesra1 = "غلام همت آن نازنينم", Mesra2 = "که کار خير بی روی و ريا کرد",},
new Hafez{ Id= 1085, BeytNo = 4, GhazalNo = 130, Mesra1 = "من از بيگانگان ديگر ننالم", Mesra2 = "که با من هر چه کرد آن آشنا کرد",},
new Hafez{ Id= 1086, BeytNo = 5, GhazalNo = 130, Mesra1 = "گر از سلطان طمع کردم خطا بود", Mesra2 = "ور از دلبر وفا جستم جفا کرد",},
new Hafez{ Id= 1087, BeytNo = 6, GhazalNo = 130, Mesra1 = "خوشش باد آن نسيم صبحگاهی", Mesra2 = "که درد شب نشينان را دوا کرد",},
new Hafez{ Id= 1088, BeytNo = 7, GhazalNo = 130, Mesra1 = "نقاب گل کشيد و زلف سنبل", Mesra2 = "گره بند قبای غنچه وا کرد",},
new Hafez{ Id= 1089, BeytNo = 8, GhazalNo = 130, Mesra1 = "به هر سو بلبل عاشق در افغان", Mesra2 = "تنعم از ميان باد صبا کرد",},
new Hafez{ Id= 1090, BeytNo = 9, GhazalNo = 130, Mesra1 = "بشارت بر به کوی می فروشان", Mesra2 = "که حافظ توبه از زهد ريا کرد",},
new Hafez{ Id= 1091, BeytNo = 10, GhazalNo = 130, Mesra1 = "وفا از خواجگان شهر با من", Mesra2 = "کمال دولت و دين بوالوفا کرد",},
new Hafez{ Id= 1092, BeytNo = 1, GhazalNo = 131, Mesra1 = "بيا که ترک فلک خوان روزه غارت کرد", Mesra2 = "هلال عيد به دور قدح اشارت کرد",},
new Hafez{ Id= 1093, BeytNo = 2, GhazalNo = 131, Mesra1 = "ثواب روزه و حج قبول آن کس برد", Mesra2 = "که خاک ميکده عشق را زيارت کرد",},
new Hafez{ Id= 1094, BeytNo = 3, GhazalNo = 131, Mesra1 = "مقام اصلی ما گوشه خرابات است", Mesra2 = "خداش خير دهاد آن که اين عمارت کرد",},
new Hafez{ Id= 1095, BeytNo = 4, GhazalNo = 131, Mesra1 = "بهای باده چون لعل چيست جوهر عقل", Mesra2 = "بيا که سود کسی برد کاين تجارت کرد",},
new Hafez{ Id= 1096, BeytNo = 5, GhazalNo = 131, Mesra1 = "نماز در خم آن ابروان محرابی", Mesra2 = "کسی کند که به خون جگر طهارت کرد",},
new Hafez{ Id= 1097, BeytNo = 6, GhazalNo = 131, Mesra1 = "فغان که نرگس جماش شيخ شهر امروز", Mesra2 = "نظر به دردکشان از سر حقارت کرد",},
new Hafez{ Id= 1098, BeytNo = 7, GhazalNo = 131, Mesra1 = "به روی يار نظر کن ز ديده منت دار", Mesra2 = "که کار ديده نظر از سر بصارت کرد",},
new Hafez{ Id= 1099, BeytNo = 8, GhazalNo = 131, Mesra1 = "حديث عشق ز حافظ شنو نه از واعظ", Mesra2 = "اگر چه صنعت بسيار در عبارت کرد",},
new Hafez{ Id= 1100, BeytNo = 1, GhazalNo = 132, Mesra1 = "به آب روشن می عارفی طهارت کرد", Mesra2 = "علی الصباح که ميخانه را زيارت کرد",},
new Hafez{ Id= 1101, BeytNo = 2, GhazalNo = 132, Mesra1 = "همين که ساغر زرين خور نهان گرديد", Mesra2 = "هلال عيد به دور قدح اشارت کرد",},
new Hafez{ Id= 1102, BeytNo = 3, GhazalNo = 132, Mesra1 = "خوشا نماز و نياز کسی که از سر درد", Mesra2 = "به آب ديده و خون جگر طهارت کرد",},
new Hafez{ Id= 1103, BeytNo = 4, GhazalNo = 132, Mesra1 = "امام خواجه که بودش سر نماز دراز", Mesra2 = "به خون دختر رز خرقه را قصارت کرد",},
new Hafez{ Id= 1104, BeytNo = 5, GhazalNo = 132, Mesra1 = "دلم ز حلقه زلفش به جان خريد آشوب", Mesra2 = "چه سود ديد ندانم که اين تجارت کرد",},
new Hafez{ Id= 1105, BeytNo = 6, GhazalNo = 132, Mesra1 = "اگر امام جماعت طلب کند امروز", Mesra2 = "خبر دهيد که حافظ به می طهارت کرد",},
new Hafez{ Id= 1106, BeytNo = 1, GhazalNo = 133, Mesra1 = "صوفی نهاد دام و سر حقه باز کرد", Mesra2 = "بنياد مکر با فلک حقه باز کرد",},
new Hafez{ Id= 1107, BeytNo = 2, GhazalNo = 133, Mesra1 = "بازی چرخ بشکندش بيضه در کلاه", Mesra2 = "زيرا که عرض شعبده با اهل راز کرد",},
new Hafez{ Id= 1108, BeytNo = 3, GhazalNo = 133, Mesra1 = "ساقی بيا که شاهد رعنای صوفيان", Mesra2 = "ديگر به جلوه آمد و آغاز ناز کرد",},
new Hafez{ Id= 1109, BeytNo = 4, GhazalNo = 133, Mesra1 = "اين مطرب از کجاست که ساز عراق ساخت", Mesra2 = "و آهنگ بازگشت به راه حجاز کرد",},
new Hafez{ Id= 1110, BeytNo = 5, GhazalNo = 133, Mesra1 = "ای دل بيا که ما به پناه خدا رويم", Mesra2 = "زان چه آستين کوته و دست دراز کرد",},
new Hafez{ Id= 1111, BeytNo = 6, GhazalNo = 133, Mesra1 = "صنعت مکن که هر که محبت نه راست باخت", Mesra2 = "عشقش به روی دل در معنی فراز کرد",},
new Hafez{ Id= 1112, BeytNo = 7, GhazalNo = 133, Mesra1 = "فردا که پيشگاه حقيقت شود پديد", Mesra2 = "شرمنده ره روی که عمل بر مجاز کرد",},
new Hafez{ Id= 1113, BeytNo = 8, GhazalNo = 133, Mesra1 = "ای کبک خوش خرام کجا می‌روی بايست", Mesra2 = "غره مشو که گربه زاهد نماز کرد",},
new Hafez{ Id= 1114, BeytNo = 9, GhazalNo = 133, Mesra1 = "حافظ مکن ملامت رندان که در ازل", Mesra2 = "ما را خدا ز زهد ريا بی‌نياز کرد",},
new Hafez{ Id= 1115, BeytNo = 1, GhazalNo = 134, Mesra1 = "بلبلی خون دلی خورد و گلی حاصل کرد", Mesra2 = "باد غيرت به صدش خار پريشان دل کرد",},
new Hafez{ Id= 1116, BeytNo = 2, GhazalNo = 134, Mesra1 = "طوطی ای را به خيال شکری دل خوش بود", Mesra2 = "ناگهش سيل فنا نقش امل باطل کرد",},
new Hafez{ Id= 1117, BeytNo = 3, GhazalNo = 134, Mesra1 = "قره العين من آن ميوه دل يادش باد", Mesra2 = "که چه آسان بشد و کار مرا مشکل کرد",},
new Hafez{ Id= 1118, BeytNo = 4, GhazalNo = 134, Mesra1 = "ساروان بار من افتاد خدا را مددی", Mesra2 = "که اميد کرمم همره اين محمل کرد",},
new Hafez{ Id= 1119, BeytNo = 5, GhazalNo = 134, Mesra1 = "روی خاکی و نم چشم مرا خوار مدار", Mesra2 = "چرخ فيروزه طربخانه از اين کهگل کرد",},
new Hafez{ Id= 1120, BeytNo = 6, GhazalNo = 134, Mesra1 = "آه و فرياد که از چشم حسود مه چرخ", Mesra2 = "در لحد ماه کمان ابروی من منزل کرد",},
new Hafez{ Id= 1121, BeytNo = 7, GhazalNo = 134, Mesra1 = "نزدی شاه رخ و فوت شد امکان حافظ", Mesra2 = "چه کنم بازی ايام مرا غافل کرد",},
new Hafez{ Id= 1122, BeytNo = 1, GhazalNo = 135, Mesra1 = "چو باد عزم سر کوی يار خواهم کرد", Mesra2 = "نفس به بوی خوشش مشکبار خواهم کرد",},
new Hafez{ Id= 1123, BeytNo = 2, GhazalNo = 135, Mesra1 = "به هرزه بی می و معشوق عمر می‌گذرد", Mesra2 = "بطالتم بس از امروز کار خواهم کرد",},
new Hafez{ Id= 1124, BeytNo = 3, GhazalNo = 135, Mesra1 = "هر آبروی که اندوختم ز دانش و دين", Mesra2 = "نثار خاک ره آن نگار خواهم کرد",},
new Hafez{ Id= 1125, BeytNo = 4, GhazalNo = 135, Mesra1 = "چو شمع صبحدمم شد ز مهر او روشن", Mesra2 = "که عمر در سر اين کار و بار خواهم کرد",},
new Hafez{ Id= 1126, BeytNo = 5, GhazalNo = 135, Mesra1 = "به ياد چشم تو خود را خراب خواهم ساخت", Mesra2 = "بنای عهد قديم استوار خواهم کرد",},
new Hafez{ Id= 1127, BeytNo = 6, GhazalNo = 135, Mesra1 = "صبا کجاست که اين جان خون گرفته چو گل", Mesra2 = "فدای نکهت گيسوی يار خواهم کرد",},
new Hafez{ Id= 1128, BeytNo = 7, GhazalNo = 135, Mesra1 = "نفاق و زرق نبخشد صفای دل حافظ", Mesra2 = "طريق رندی و عشق اختيار خواهم کرد",},
new Hafez{ Id= 1129, BeytNo = 1, GhazalNo = 136, Mesra1 = "دست در حلقه آن زلف دوتا نتوان کرد", Mesra2 = "تکيه بر عهد تو و باد صبا نتوان کرد",},
new Hafez{ Id= 1130, BeytNo = 2, GhazalNo = 136, Mesra1 = "آن چه سعی است من اندر طلبت بنمايم", Mesra2 = "اين قدر هست که تغيير قضا نتوان کرد",},
new Hafez{ Id= 1131, BeytNo = 3, GhazalNo = 136, Mesra1 = "دامن دوست به صد خون دل افتاد به دست", Mesra2 = "به فسوسی که کند خصم رها نتوان کرد",},
new Hafez{ Id= 1132, BeytNo = 4, GhazalNo = 136, Mesra1 = "عارضش را به مثل ماه فلک نتوان گفت", Mesra2 = "نسبت دوست به هر بی سر و پا نتوان کرد",},
new Hafez{ Id= 1133, BeytNo = 5, GhazalNo = 136, Mesra1 = "سروبالای من آن گه که درآيد به سماع", Mesra2 = "چه محل جامه جان را که قبا نتوان کرد",},
new Hafez{ Id= 1134, BeytNo = 6, GhazalNo = 136, Mesra1 = "نظر پاک تواند رخ جانان ديدن", Mesra2 = "که در آيينه نظر جز به صفا نتوان کرد",},
new Hafez{ Id= 1135, BeytNo = 7, GhazalNo = 136, Mesra1 = "مشکل عشق نه در حوصله دانش ماست", Mesra2 = "حل اين نکته بدين فکر خطا نتوان کرد",},
new Hafez{ Id= 1136, BeytNo = 8, GhazalNo = 136, Mesra1 = "غيرتم کشت که محبوب جهانی ليکن", Mesra2 = "روز و شب عربده با خلق خدا نتوان کرد",},
new Hafez{ Id= 1137, BeytNo = 9, GhazalNo = 136, Mesra1 = "من چه گويم که تو را نازکی طبع لطيف", Mesra2 = "تا به حديست که آهسته دعا نتوان کرد",},
new Hafez{ Id= 1138, BeytNo = 10, GhazalNo = 136, Mesra1 = "بجز ابروی تو محراب دل حافظ نيست", Mesra2 = "طاعت غير تو در مذهب ما نتوان کرد",},
new Hafez{ Id= 1139, BeytNo = 1, GhazalNo = 137, Mesra1 = "دل از من برد و روی از من نهان کرد", Mesra2 = "خدا را با که اين بازی توان کرد",},
new Hafez{ Id= 1140, BeytNo = 2, GhazalNo = 137, Mesra1 = "شب تنهاييم در قصد جان بود", Mesra2 = "خيالش لطف‌های بی‌کران کرد",},
new Hafez{ Id= 1141, BeytNo = 3, GhazalNo = 137, Mesra1 = "چرا چون لاله خونين دل نباشم", Mesra2 = "که با ما نرگس او سرگران کرد",},
new Hafez{ Id= 1142, BeytNo = 4, GhazalNo = 137, Mesra1 = "که را گويم که با اين درد جان سوز", Mesra2 = "طبيبم قصد جان ناتوان کرد",},
new Hafez{ Id= 1143, BeytNo = 5, GhazalNo = 137, Mesra1 = "بدان سان سوخت چون شمعم که بر من", Mesra2 = "صراحی گريه و بربط فغان کرد",},
new Hafez{ Id= 1144, BeytNo = 6, GhazalNo = 137, Mesra1 = "صبا گر چاره داری وقت وقت است", Mesra2 = "که درد اشتياقم قصد جان کرد",},
new Hafez{ Id= 1145, BeytNo = 7, GhazalNo = 137, Mesra1 = "ميان مهربانان کی توان گفت", Mesra2 = "که يار ما چنين گفت و چنان کرد",},
new Hafez{ Id= 1146, BeytNo = 8, GhazalNo = 137, Mesra1 = "عدو با جان حافظ آن نکردی", Mesra2 = "که تير چشم آن ابروکمان کرد",},
new Hafez{ Id= 1147, BeytNo = 1, GhazalNo = 138, Mesra1 = "ياد باد آن که ز ما وقت سفر ياد نکرد", Mesra2 = "به وداعی دل غمديده ما شاد نکرد",},
new Hafez{ Id= 1148, BeytNo = 2, GhazalNo = 138, Mesra1 = "آن جوان بخت که می‌زد رقم خير و قبول", Mesra2 = "بنده پير ندانم ز چه آزاد نکرد",},
new Hafez{ Id= 1149, BeytNo = 3, GhazalNo = 138, Mesra1 = "کاغذين جامه به خوناب بشويم که فلک", Mesra2 = "رهنمونيم به پای علم داد نکرد",},
new Hafez{ Id= 1150, BeytNo = 4, GhazalNo = 138, Mesra1 = "دل به اميد صدايی که مگر در تو رسد", Mesra2 = "ناله‌ها کرد در اين کوه که فرهاد نکرد",},
new Hafez{ Id= 1151, BeytNo = 5, GhazalNo = 138, Mesra1 = "سايه تا بازگرفتی ز چمن مرغ سحر", Mesra2 = "آشيان در شکن طره شمشاد نکرد",},
new Hafez{ Id= 1152, BeytNo = 6, GhazalNo = 138, Mesra1 = "شايد ار پيک صبا از تو بياموزد کار", Mesra2 = "زان که چالاکتر از اين حرکت باد نکرد",},
new Hafez{ Id= 1153, BeytNo = 7, GhazalNo = 138, Mesra1 = "کلک مشاطه صنعش نکشد نقش مراد", Mesra2 = "هر که اقرار بدين حسن خداداد نکرد",},
new Hafez{ Id= 1154, BeytNo = 8, GhazalNo = 138, Mesra1 = "مطربا پرده بگردان و بزن راه عراق", Mesra2 = "که بدين راه بشد يار و ز ما ياد نکرد",},
new Hafez{ Id= 1155, BeytNo = 9, GhazalNo = 138, Mesra1 = "غزليات عراقيست سرود حافظ", Mesra2 = "که شنيد اين ره دلسوز که فرياد نکرد",},
new Hafez{ Id= 1156, BeytNo = 1, GhazalNo = 139, Mesra1 = "رو بر رهش نهادم و بر من گذر نکرد", Mesra2 = "صد لطف چشم داشتم و يک نظر نکرد",},
new Hafez{ Id= 1157, BeytNo = 2, GhazalNo = 139, Mesra1 = "سيل سرشک ما ز دلش کين به درنبرد", Mesra2 = "در سنگ خاره قطره باران اثر نکرد",},
new Hafez{ Id= 1158, BeytNo = 3, GhazalNo = 139, Mesra1 = "يا رب تو آن جوان دلاور نگاه دار", Mesra2 = "کز تير آه گوشه نشينان حذر نکرد",},
new Hafez{ Id= 1159, BeytNo = 4, GhazalNo = 139, Mesra1 = "ماهی و مرغ دوش ز افغان من نخفت", Mesra2 = "وان شوخ ديده بين که سر از خواب برنکرد",},
new Hafez{ Id= 1160, BeytNo = 5, GhazalNo = 139, Mesra1 = "می‌خواستم که ميرمش اندر قدم چو شمع", Mesra2 = "او خود گذر به ما چو نسيم سحر نکرد",},
new Hafez{ Id= 1161, BeytNo = 6, GhazalNo = 139, Mesra1 = "جانا کدام سنگ‌دل بی‌کفايتيست", Mesra2 = "کو پيش زخم تيغ تو جان را سپر نکرد",},
new Hafez{ Id= 1162, BeytNo = 7, GhazalNo = 139, Mesra1 = "کلک زبان بريده حافظ در انجمن", Mesra2 = "با کس نگفت راز تو تا ترک سر نکرد",},
new Hafez{ Id= 1163, BeytNo = 1, GhazalNo = 140, Mesra1 = "دلبر برفت و دلشدگان را خبر نکرد", Mesra2 = "ياد حريف شهر و رفيق سفر نکرد",},
new Hafez{ Id= 1164, BeytNo = 2, GhazalNo = 140, Mesra1 = "يا بخت من طريق مروت فروگذاشت", Mesra2 = "يا او به شاهراه طريقت گذر نکرد",},
new Hafez{ Id= 1165, BeytNo = 3, GhazalNo = 140, Mesra1 = "گفتم مگر به گريه دلش مهربان کنم", Mesra2 = "چون سخت بود در دل سنگش اثر نکرد",},
new Hafez{ Id= 1166, BeytNo = 4, GhazalNo = 140, Mesra1 = "شوخی مکن که مرغ دل بی‌قرار من", Mesra2 = "سودای دام عاشقی از سر به درنکرد",},
new Hafez{ Id= 1167, BeytNo = 5, GhazalNo = 140, Mesra1 = "هر کس که ديد روی تو بوسيد چشم من", Mesra2 = "کاری که کرد ديده من بی نظر نکرد",},
new Hafez{ Id= 1168, BeytNo = 6, GhazalNo = 140, Mesra1 = "من ايستاده تا کنمش جان فدا چو شمع", Mesra2 = "او خود گذر به ما چو نسيم سحر نکرد",},
new Hafez{ Id= 1169, BeytNo = 1, GhazalNo = 141, Mesra1 = "ديدی ای دل که غم عشق دگربار چه کرد", Mesra2 = "چون بشد دلبر و با يار وفادار چه کرد",},
new Hafez{ Id= 1170, BeytNo = 2, GhazalNo = 141, Mesra1 = "آه از آن نرگس جادو که چه بازی انگيخت", Mesra2 = "آه از آن مست که با مردم هشيار چه کرد",},
new Hafez{ Id= 1171, BeytNo = 3, GhazalNo = 141, Mesra1 = "اشک من رنگ شفق يافت ز بی‌مهری يار", Mesra2 = "طالع بی‌شفقت بين که در اين کار چه کرد",},
new Hafez{ Id= 1172, BeytNo = 4, GhazalNo = 141, Mesra1 = "برقی از منزل ليلی بدرخشيد سحر", Mesra2 = "وه که با خرمن مجنون دل افگار چه کرد",},
new Hafez{ Id= 1173, BeytNo = 5, GhazalNo = 141, Mesra1 = "ساقيا جام می‌ام ده که نگارنده غيب", Mesra2 = "نيست معلوم که در پرده اسرار چه کرد",},
new Hafez{ Id= 1174, BeytNo = 6, GhazalNo = 141, Mesra1 = "آن که پرنقش زد اين دايره مينايی", Mesra2 = "کس ندانست که در گردش پرگار چه کرد",},
new Hafez{ Id= 1175, BeytNo = 7, GhazalNo = 141, Mesra1 = "فکر عشق آتش غم در دل حافظ زد و سوخت", Mesra2 = "يار ديرينه ببينيد که با يار چه کرد",},
new Hafez{ Id= 1176, BeytNo = 1, GhazalNo = 142, Mesra1 = "دوستان دختر رز توبه ز مستوری کرد", Mesra2 = "شد سوی محتسب و کار به دستوری کرد",},
new Hafez{ Id= 1177, BeytNo = 2, GhazalNo = 142, Mesra1 = "آمد از پرده به مجلس عرقش پاک کنيد", Mesra2 = "تا نگويند حريفان که چرا دوری کرد",},
new Hafez{ Id= 1178, BeytNo = 3, GhazalNo = 142, Mesra1 = "مژدگانی بده ای دل که دگر مطرب عشق", Mesra2 = "راه مستانه زد و چاره مخموری کرد",},
new Hafez{ Id= 1179, BeytNo = 4, GhazalNo = 142, Mesra1 = "نه به هفت آب که رنگش به صد آتش نرود", Mesra2 = "آن چه با خرقه زاهد می انگوری کرد",},
new Hafez{ Id= 1180, BeytNo = 5, GhazalNo = 142, Mesra1 = "غنچه گلبن وصلم ز نسيمش بشکفت", Mesra2 = "مرغ خوشخوان طرب از برگ گل سوری کرد",},
new Hafez{ Id= 1181, BeytNo = 6, GhazalNo = 142, Mesra1 = "حافظ افتادگی از دست مده زان که حسود", Mesra2 = "عرض و مال و دل و دين در سر مغروری کرد",},
new Hafez{ Id= 1182, BeytNo = 1, GhazalNo = 143, Mesra1 = "سال‌ها دل طلب جام جم از ما می‌کرد", Mesra2 = "وان چه خود داشت ز بيگانه تمنا می‌کرد",},
new Hafez{ Id= 1183, BeytNo = 2, GhazalNo = 143, Mesra1 = "گوهری کز صدف کون و مکان بيرون است", Mesra2 = "طلب از گمشدگان لب دريا می‌کرد",},
new Hafez{ Id= 1184, BeytNo = 3, GhazalNo = 143, Mesra1 = "مشکل خويش بر پير مغان بردم دوش", Mesra2 = "کو به تاييد نظر حل معما می‌کرد",},
new Hafez{ Id= 1185, BeytNo = 4, GhazalNo = 143, Mesra1 = "ديدمش خرم و خندان قدح باده به دست", Mesra2 = "و اندر آن آينه صد گونه تماشا می‌کرد",},
new Hafez{ Id= 1186, BeytNo = 5, GhazalNo = 143, Mesra1 = "گفتم اين جام جهان بين به تو کی داد حکيم", Mesra2 = "گفت آن روز که اين گنبد مينا می‌کرد",},
new Hafez{ Id= 1187, BeytNo = 6, GhazalNo = 143, Mesra1 = "بی دلی در همه احوال خدا با او بود", Mesra2 = "او نمی‌ديدش و از دور خدا را می‌کرد",},
new Hafez{ Id= 1188, BeytNo = 7, GhazalNo = 143, Mesra1 = "اين همه شعبده خويش که می‌کرد اين جا", Mesra2 = "سامری پيش عصا و يد بيضا می‌کرد",},
new Hafez{ Id= 1189, BeytNo = 8, GhazalNo = 143, Mesra1 = "گفت آن يار کز او گشت سر دار بلند", Mesra2 = "جرمش اين بود که اسرار هويدا می‌کرد",},
new Hafez{ Id= 1190, BeytNo = 9, GhazalNo = 143, Mesra1 = "فيض روح القدس ار باز مدد فرمايد", Mesra2 = "ديگران هم بکنند آن چه مسيحا می‌کرد",},
new Hafez{ Id= 1191, BeytNo = 10, GhazalNo = 143, Mesra1 = "گفتمش سلسله زلف بتان از پی چيست", Mesra2 = "گفت حافظ گله‌ای از دل شيدا می‌کرد",},
new Hafez{ Id= 1192, BeytNo = 1, GhazalNo = 144, Mesra1 = "به سر جام جم آن گه نظر توانی کرد", Mesra2 = "که خاک ميکده کحل بصر توانی کرد",},
new Hafez{ Id= 1193, BeytNo = 2, GhazalNo = 144, Mesra1 = "مباش بی می و مطرب که زير طاق سپهر", Mesra2 = "بدين ترانه غم از دل به در توانی کرد",},
new Hafez{ Id= 1194, BeytNo = 3, GhazalNo = 144, Mesra1 = "گل مراد تو آن گه نقاب بگشايد", Mesra2 = "که خدمتش چو نسيم سحر توانی کرد",},
new Hafez{ Id= 1195, BeytNo = 4, GhazalNo = 144, Mesra1 = "گدايی در ميخانه طرفه اکسيريست", Mesra2 = "گر اين عمل بکنی خاک زر توانی کرد",},
new Hafez{ Id= 1196, BeytNo = 5, GhazalNo = 144, Mesra1 = "به عزم مرحله عشق پيش نه قدمی", Mesra2 = "که سودها کنی ار اين سفر توانی کرد",},
new Hafez{ Id= 1197, BeytNo = 6, GhazalNo = 144, Mesra1 = "تو کز سرای طبيعت نمی‌روی بيرون", Mesra2 = "کجا به کوی طريقت گذر توانی کرد",},
new Hafez{ Id= 1198, BeytNo = 7, GhazalNo = 144, Mesra1 = "جمال يار ندارد نقاب و پرده ولی", Mesra2 = "غبار ره بنشان تا نظر توانی کرد",},
new Hafez{ Id= 1199, BeytNo = 8, GhazalNo = 144, Mesra1 = "بيا که چاره ذوق حضور و نظم امور", Mesra2 = "به فيض بخشی اهل نظر توانی کرد",},
new Hafez{ Id= 1200, BeytNo = 9, GhazalNo = 144, Mesra1 = "ولی تو تا لب معشوق و جام می خواهی", Mesra2 = "طمع مدار که کار دگر توانی کرد",},
new Hafez{ Id= 1201, BeytNo = 10, GhazalNo = 144, Mesra1 = "دلا ز نور هدايت گر آگهی يابی", Mesra2 = "چو شمع خنده زنان ترک سر توانی کرد",},
new Hafez{ Id= 1202, BeytNo = 11, GhazalNo = 144, Mesra1 = "گر اين نصيحت شاهانه بشنوی حافظ", Mesra2 = "به شاهراه حقيقت گذر توانی کرد",},
new Hafez{ Id= 1203, BeytNo = 1, GhazalNo = 145, Mesra1 = "چه مستيست ندانم که رو به ما آورد", Mesra2 = "که بود ساقی و اين باده از کجا آورد",},
new Hafez{ Id= 1204, BeytNo = 2, GhazalNo = 145, Mesra1 = "تو نيز باده به چنگ آر و راه صحرا گير", Mesra2 = "که مرغ نغمه سرا ساز خوش نوا آورد",},
new Hafez{ Id= 1205, BeytNo = 3, GhazalNo = 145, Mesra1 = "دلا چو غنچه شکايت ز کار بسته مکن", Mesra2 = "که باد صبح نسيم گره گشا آورد",},
new Hafez{ Id= 1206, BeytNo = 4, GhazalNo = 145, Mesra1 = "رسيدن گل و نسرين به خير و خوبی باد", Mesra2 = "بنفشه شاد و کش آمد سمن صفا آورد",},
new Hafez{ Id= 1207, BeytNo = 5, GhazalNo = 145, Mesra1 = "صبا به خوش خبری هدهد سليمان است", Mesra2 = "که مژده طرب از گلشن سبا آورد",},
new Hafez{ Id= 1208, BeytNo = 6, GhazalNo = 145, Mesra1 = "علاج ضعف دل ما کرشمه ساقيست", Mesra2 = "برآر سر که طبيب آمد و دوا آورد",},
new Hafez{ Id= 1209, BeytNo = 7, GhazalNo = 145, Mesra1 = "مريد پير مغانم ز من مرنج ای شيخ", Mesra2 = "چرا که وعده تو کردی و او به جا آورد",},
new Hafez{ Id= 1210, BeytNo = 8, GhazalNo = 145, Mesra1 = "به تنگ چشمی آن ترک لشکری نازم", Mesra2 = "که حمله بر من درويش يک قبا آورد",},
new Hafez{ Id= 1211, BeytNo = 9, GhazalNo = 145, Mesra1 = "فلک غلامی حافظ کنون به طوع کند", Mesra2 = "که التجا به در دولت شما آورد",},
new Hafez{ Id= 1212, BeytNo = 1, GhazalNo = 146, Mesra1 = "صبا وقت سحر بويی ز زلف يار می‌آورد", Mesra2 = "دل شوريده ما را به بو در کار می‌آورد",},
new Hafez{ Id= 1213, BeytNo = 2, GhazalNo = 146, Mesra1 = "من آن شکل صنوبر را ز باغ ديده برکندم", Mesra2 = "که هر گل کز غمش بشکفت محنت بار می‌آورد",},
new Hafez{ Id= 1214, BeytNo = 3, GhazalNo = 146, Mesra1 = "فروغ ماه می‌ديدم ز بام قصر او روشن", Mesra2 = "که رو از شرم آن خورشيد در ديوار می‌آورد",},
new Hafez{ Id= 1215, BeytNo = 4, GhazalNo = 146, Mesra1 = "ز بيم غارت عشقش دل پرخون رها کردم", Mesra2 = "ولی می‌ريخت خون و ره بدان هنجار می‌آورد",},
new Hafez{ Id= 1216, BeytNo = 5, GhazalNo = 146, Mesra1 = "به قول مطرب و ساقی برون رفتم گه و بی‌گه", Mesra2 = "کز آن راه گران قاصد خبر دشوار می‌آورد",},
new Hafez{ Id= 1217, BeytNo = 6, GhazalNo = 146, Mesra1 = "سراسر بخشش جانان طريق لطف و احسان بود", Mesra2 = "اگر تسبيح می‌فرمود اگر زنار می‌آورد",},
new Hafez{ Id= 1218, BeytNo = 7, GhazalNo = 146, Mesra1 = "عفاالله چين ابرويش اگر چه ناتوانم کرد", Mesra2 = "به عشوه هم پيامی بر سر بيمار می‌آورد",},
new Hafez{ Id= 1219, BeytNo = 8, GhazalNo = 146, Mesra1 = "عجب می‌داشتم ديشب ز حافظ جام و پيمانه", Mesra2 = "ولی منعش نمی‌کردم که صوفی وار می‌آورد",},
new Hafez{ Id= 1220, BeytNo = 1, GhazalNo = 147, Mesra1 = "نسيم باد صبا دوشم آگهی آورد", Mesra2 = "که روز محنت و غم رو به کوتهی آورد",},
new Hafez{ Id= 1221, BeytNo = 2, GhazalNo = 147, Mesra1 = "به مطربان صبوحی دهيم جامه چاک", Mesra2 = "بدين نويد که باد سحرگهی آورد",},
new Hafez{ Id= 1222, BeytNo = 3, GhazalNo = 147, Mesra1 = "بيا بيا که تو حور بهشت را رضوان", Mesra2 = "در اين جهان ز برای دل رهی آورد",},
new Hafez{ Id= 1223, BeytNo = 4, GhazalNo = 147, Mesra1 = "همی‌رويم به شيراز با عنايت بخت", Mesra2 = "زهی رفيق که بختم به همرهی آورد",},
new Hafez{ Id= 1224, BeytNo = 5, GhazalNo = 147, Mesra1 = "به جبر خاطر ما کوش کاين کلاه نمد", Mesra2 = "بسا شکست که با افسر شهی آورد",},
new Hafez{ Id= 1225, BeytNo = 6, GhazalNo = 147, Mesra1 = "چه ناله‌ها که رسيد از دلم به خرمن ماه", Mesra2 = "چو ياد عارض آن ماه خرگهی آورد",},
new Hafez{ Id= 1226, BeytNo = 7, GhazalNo = 147, Mesra1 = "رساند رايت منصور بر فلک حافظ", Mesra2 = "که التجا به جناب شهنشهی آورد",},
new Hafez{ Id= 1227, BeytNo = 1, GhazalNo = 148, Mesra1 = "يارم چو قدح به دست گيرد", Mesra2 = "بازار بتان شکست گيرد",},
new Hafez{ Id= 1228, BeytNo = 2, GhazalNo = 148, Mesra1 = "هر کس که بديد چشم او گفت", Mesra2 = "کو محتسبی که مست گيرد",},
new Hafez{ Id= 1229, BeytNo = 3, GhazalNo = 148, Mesra1 = "در بحر فتاده‌ام چو ماهی", Mesra2 = "تا يار مرا به شست گيرد",},
new Hafez{ Id= 1230, BeytNo = 4, GhazalNo = 148, Mesra1 = "در پاش فتاده‌ام به زاری", Mesra2 = "آيا بود آن که دست گيرد",},
new Hafez{ Id= 1231, BeytNo = 5, GhazalNo = 148, Mesra1 = "خرم دل آن که همچو حافظ", Mesra2 = "جامی ز می الست گيرد",},
new Hafez{ Id= 1232, BeytNo = 1, GhazalNo = 149, Mesra1 = "دلم جز مهر مه رويان طريقی بر نمی‌گيرد", Mesra2 = "ز هر در می‌دهم پندش وليکن در نمی‌گيرد",},
new Hafez{ Id= 1233, BeytNo = 2, GhazalNo = 149, Mesra1 = "خدا را ای نصيحتگو حديث ساغر و می گو", Mesra2 = "که نقشی در خيال ما از اين خوشتر نمی‌گيرد",},
new Hafez{ Id= 1234, BeytNo = 3, GhazalNo = 149, Mesra1 = "بيا ای ساقی گلرخ بياور باده رنگين", Mesra2 = "که فکری در درون ما از اين بهتر نمی‌گيرد",},
new Hafez{ Id= 1235, BeytNo = 4, GhazalNo = 149, Mesra1 = "صراحی می‌کشم پنهان و مردم دفتر انگارند", Mesra2 = "عجب گر آتش اين زرق در دفتر نمی‌گيرد",},
new Hafez{ Id= 1236, BeytNo = 5, GhazalNo = 149, Mesra1 = "من اين دلق مرقع را بخواهم سوختن روزی", Mesra2 = "که پير می فروشانش به جامی بر نمی‌گيرد",},
new Hafez{ Id= 1237, BeytNo = 6, GhazalNo = 149, Mesra1 = "از آن رو هست ياران را صفاها با می لعلش", Mesra2 = "که غير از راستی نقشی در آن جوهر نمی‌گيرد",},
new Hafez{ Id= 1238, BeytNo = 7, GhazalNo = 149, Mesra1 = "سر و چشمی چنين دلکش تو گويی چشم از او بردوز", Mesra2 = "برو کاين وعظ بی‌معنی مرا در سر نمی‌گيرد",},
new Hafez{ Id= 1239, BeytNo = 8, GhazalNo = 149, Mesra1 = "نصيحتگوی رندان را که با حکم قضا جنگ است", Mesra2 = "دلش بس تنگ می‌بينم مگر ساغر نمی‌گيرد",},
new Hafez{ Id= 1240, BeytNo = 9, GhazalNo = 149, Mesra1 = "ميان گريه می‌خندم که چون شمع اندر اين مجلس", Mesra2 = "زبان آتشينم هست ليکن در نمی‌گيرد",},
new Hafez{ Id= 1241, BeytNo = 10, GhazalNo = 149, Mesra1 = "چه خوش صيد دلم کردی بنازم چشم مستت را", Mesra2 = "که کس مرغان وحشی را از اين خوشتر نمی‌گيرد",},
new Hafez{ Id= 1242, BeytNo = 11, GhazalNo = 149, Mesra1 = "سخن در احتياج ما و استغنای معشوق است", Mesra2 = "چه سود افسونگری ای دل که در دلبر نمی‌گيرد",},
new Hafez{ Id= 1243, BeytNo = 12, GhazalNo = 149, Mesra1 = "من آن آيينه را روزی به دست آرم سکندروار", Mesra2 = "اگر می‌گيرد اين آتش زمانی ور نمی‌گيرد",},
new Hafez{ Id= 1244, BeytNo = 13, GhazalNo = 149, Mesra1 = "خدا را رحمی ای منعم که درويش سر کويت", Mesra2 = "دری ديگر نمی‌داند رهی ديگر نمی‌گيرد",},
new Hafez{ Id= 1245, BeytNo = 14, GhazalNo = 149, Mesra1 = "بدين شعر تر شيرين ز شاهنشه عجب دارم", Mesra2 = "که سر تا پای حافظ را چرا در زر نمی‌گيرد",},
new Hafez{ Id= 1246, BeytNo = 1, GhazalNo = 150, Mesra1 = "ساقی ار باده از اين دست به جام اندازد", Mesra2 = "عارفان را همه در شرب مدام اندازد",},
new Hafez{ Id= 1247, BeytNo = 2, GhazalNo = 150, Mesra1 = "ور چنين زير خم زلف نهد دانه خال", Mesra2 = "ای بسا مرغ خرد را که به دام اندازد",},
new Hafez{ Id= 1248, BeytNo = 3, GhazalNo = 150, Mesra1 = "ای خوشا دولت آن مست که در پای حريف", Mesra2 = "سر و دستار نداند که کدام اندازد",},
new Hafez{ Id= 1249, BeytNo = 4, GhazalNo = 150, Mesra1 = "زاهد خام که انکار می و جام کند", Mesra2 = "پخته گردد چو نظر بر می خام اندازد",},
new Hafez{ Id= 1250, BeytNo = 5, GhazalNo = 150, Mesra1 = "روز در کسب هنر کوش که می خوردن روز", Mesra2 = "دل چون آينه در زنگ ظلام اندازد",},
new Hafez{ Id= 1251, BeytNo = 6, GhazalNo = 150, Mesra1 = "آن زمان وقت می صبح فروغ است که شب", Mesra2 = "گرد خرگاه افق پرده شام اندازد",},
new Hafez{ Id= 1252, BeytNo = 7, GhazalNo = 150, Mesra1 = "باده با محتسب شهر ننوشی زنهار", Mesra2 = "بخورد باده‌ات و سنگ به جام اندازد",},
new Hafez{ Id= 1253, BeytNo = 8, GhazalNo = 150, Mesra1 = "حافظا سر ز کله گوشه خورشيد برآر", Mesra2 = "بختت ار قرعه بدان ماه تمام اندازد",},
new Hafez{ Id= 1254, BeytNo = 1, GhazalNo = 151, Mesra1 = "دمی با غم به سر بردن جهان يک سر نمی‌ارزد", Mesra2 = "به می بفروش دلق ما کز اين بهتر نمی‌ارزد",},
new Hafez{ Id= 1255, BeytNo = 2, GhazalNo = 151, Mesra1 = "به کوی می فروشانش به جامی بر نمی‌گيرند", Mesra2 = "زهی سجاده تقوا که يک ساغر نمی‌ارزد",},
new Hafez{ Id= 1256, BeytNo = 3, GhazalNo = 151, Mesra1 = "رقيبم سرزنش‌ها کرد کز اين به آب رخ برتاب", Mesra2 = "چه افتاد اين سر ما را که خاک در نمی‌ارزد",},
new Hafez{ Id= 1257, BeytNo = 4, GhazalNo = 151, Mesra1 = "شکوه تاج سلطانی که بيم جان در او درج است", Mesra2 = "کلاهی دلکش است اما به ترک سر نمی‌ارزد",},
new Hafez{ Id= 1258, BeytNo = 5, GhazalNo = 151, Mesra1 = "چه آسان می‌نمود اول غم دريا به بوی سود", Mesra2 = "غلط کردم که اين طوفان به صد گوهر نمی‌ارزد",},
new Hafez{ Id= 1259, BeytNo = 6, GhazalNo = 151, Mesra1 = "تو را آن به که روی خود ز مشتاقان بپوشانی", Mesra2 = "که شادی جهان گيری غم لشکر نمی‌ارزد",},
new Hafez{ Id= 1260, BeytNo = 7, GhazalNo = 151, Mesra1 = "چو حافظ در قناعت کوش و از دنيی دون بگذر", Mesra2 = "که يک جو منت دونان دو صد من زر نمی‌ارزد",},
new Hafez{ Id= 1261, BeytNo = 1, GhazalNo = 152, Mesra1 = "در ازل پرتو حسنت ز تجلی دم زد", Mesra2 = "عشق پيدا شد و آتش به همه عالم زد",},
new Hafez{ Id= 1262, BeytNo = 2, GhazalNo = 152, Mesra1 = "جلوه‌ای کرد رخت ديد ملک عشق نداشت", Mesra2 = "عين آتش شد از اين غيرت و بر آدم زد",},
new Hafez{ Id= 1263, BeytNo = 3, GhazalNo = 152, Mesra1 = "عقل می‌خواست کز آن شعله چراغ افروزد", Mesra2 = "برق غيرت بدرخشيد و جهان برهم زد",},
new Hafez{ Id= 1264, BeytNo = 4, GhazalNo = 152, Mesra1 = "مدعی خواست که آيد به تماشاگه راز", Mesra2 = "دست غيب آمد و بر سينه نامحرم زد",},
new Hafez{ Id= 1265, BeytNo = 5, GhazalNo = 152, Mesra1 = "ديگران قرعه قسمت همه بر عيش زدند", Mesra2 = "دل غمديده ما بود که هم بر غم زد",},
new Hafez{ Id= 1266, BeytNo = 6, GhazalNo = 152, Mesra1 = "جان علوی هوس چاه زنخدان تو داشت", Mesra2 = "دست در حلقه آن زلف خم اندر خم زد",},
new Hafez{ Id= 1267, BeytNo = 7, GhazalNo = 152, Mesra1 = "حافظ آن روز طربنامه عشق تو نوشت", Mesra2 = "که قلم بر سر اسباب دل خرم زد",},
new Hafez{ Id= 1268, BeytNo = 1, GhazalNo = 153, Mesra1 = "سحر چون خسرو خاور علم بر کوهساران زد", Mesra2 = "به دست مرحمت يارم در اميدواران زد",},
new Hafez{ Id= 1269, BeytNo = 2, GhazalNo = 153, Mesra1 = "چو پيش صبح روشن شد که حال مهر گردون چيست", Mesra2 = "برآمد خنده خوش بر غرور کامگاران زد",},
new Hafez{ Id= 1270, BeytNo = 3, GhazalNo = 153, Mesra1 = "نگارم دوش در مجلس به عزم رقص چون برخاست", Mesra2 = "گره بگشود از ابرو و بر دل‌های ياران زد",},
new Hafez{ Id= 1271, BeytNo = 4, GhazalNo = 153, Mesra1 = "من از رنگ صلاح آن دم به خون دل بشستم دست", Mesra2 = "که چشم باده پيمايش صلا بر هوشياران زد",},
new Hafez{ Id= 1272, BeytNo = 5, GhazalNo = 153, Mesra1 = "کدام آهن دلش آموخت اين آيين عياری", Mesra2 = "کز اول چون برون آمد ره شب زنده داران زد",},
new Hafez{ Id= 1273, BeytNo = 6, GhazalNo = 153, Mesra1 = "خيال شهسواری پخت و شد ناگه دل مسکين", Mesra2 = "خداوندا نگه دارش که بر قلب سواران زد",},
new Hafez{ Id= 1274, BeytNo = 7, GhazalNo = 153, Mesra1 = "در آب و رنگ رخسارش چه جان داديم و خون خورديم", Mesra2 = "چو نقشش دست داد اول رقم بر جان سپاران زد",},
new Hafez{ Id= 1275, BeytNo = 8, GhazalNo = 153, Mesra1 = "منش با خرقه پشمين کجا اندر کمند آرم", Mesra2 = "زره مويی که مژگانش ره خنجرگزاران زد",},
new Hafez{ Id= 1276, BeytNo = 9, GhazalNo = 153, Mesra1 = "شهنشاه مظفر فر شجاع ملک و دين منصور", Mesra2 = "که جود بی‌دريغش خنده بر ابر بهاران زد",},
new Hafez{ Id= 1277, BeytNo = 10, GhazalNo = 153, Mesra1 = "از آن ساعت که جام می به دست او مشرف شد", Mesra2 = "زمانه ساغر شادی به ياد ميگساران زد",},
new Hafez{ Id= 1278, BeytNo = 11, GhazalNo = 153, Mesra1 = "ز شمشير سرافشانش ظفر آن روز بدرخشيد", Mesra2 = "که چون خورشيد انجم سوز تنها بر هزاران زد",},
new Hafez{ Id= 1279, BeytNo = 12, GhazalNo = 153, Mesra1 = "دوام عمر و ملک او بخواه از لطف حق ای دل", Mesra2 = "که چرخ اين سکه دولت به دور روزگاران زد",},
new Hafez{ Id= 1280, BeytNo = 13, GhazalNo = 153, Mesra1 = "نظر بر قرعه توفيق و يمن دولت شاه است", Mesra2 = "بده کام دل حافظ که فال بختياران زد",},
new Hafez{ Id= 1281, BeytNo = 1, GhazalNo = 154, Mesra1 = "راهی بزن که آهی بر ساز آن توان زد", Mesra2 = "شعری بخوان که با او رطل گران توان زد",},
new Hafez{ Id= 1282, BeytNo = 2, GhazalNo = 154, Mesra1 = "بر آستان جانان گر سر توان نهادن", Mesra2 = "گلبانگ سربلندی بر آسمان توان زد",},
new Hafez{ Id= 1283, BeytNo = 3, GhazalNo = 154, Mesra1 = "قد خميده ما سهلت نمايد اما", Mesra2 = "بر چشم دشمنان تير از اين کمان توان زد",},
new Hafez{ Id= 1284, BeytNo = 4, GhazalNo = 154, Mesra1 = "در خانقه نگنجد اسرار عشقبازی", Mesra2 = "جام می مغانه هم با مغان توان زد",},
new Hafez{ Id= 1285, BeytNo = 5, GhazalNo = 154, Mesra1 = "درويش را نباشد برگ سرای سلطان", Mesra2 = "ماييم و کهنه دلقی کتش در آن توان زد",},
new Hafez{ Id= 1286, BeytNo = 6, GhazalNo = 154, Mesra1 = "اهل نظر دو عالم در يک نظر ببازند", Mesra2 = "عشق است و داو اول بر نقد جان توان زد",},
new Hafez{ Id= 1287, BeytNo = 7, GhazalNo = 154, Mesra1 = "گر دولت وصالت خواهد دری گشودن", Mesra2 = "سرها بدين تخيل بر آستان توان زد",},
new Hafez{ Id= 1288, BeytNo = 8, GhazalNo = 154, Mesra1 = "عشق و شباب و رندی مجموعه مراد است", Mesra2 = "چون جمع شد معانی گوی بيان توان زد",},
new Hafez{ Id= 1289, BeytNo = 9, GhazalNo = 154, Mesra1 = "شد رهزن سلامت زلف تو وين عجب نيست", Mesra2 = "گر راه زن تو باشی صد کاروان توان زد",},
new Hafez{ Id= 1290, BeytNo = 10, GhazalNo = 154, Mesra1 = "حافظ به حق قرآن کز شيد و زرق بازآی", Mesra2 = "باشد که گوی عيشی در اين جهان توان زد",},
new Hafez{ Id= 1291, BeytNo = 1, GhazalNo = 155, Mesra1 = "اگر روم ز پی اش فتنه‌ها برانگيزد", Mesra2 = "ور از طلب بنشينم به کينه برخيزد",},
new Hafez{ Id= 1292, BeytNo = 2, GhazalNo = 155, Mesra1 = "و گر به رهگذری يک دم از وفاداری", Mesra2 = "چو گرد در پی اش افتم چو باد بگريزد",},
new Hafez{ Id= 1293, BeytNo = 3, GhazalNo = 155, Mesra1 = "و گر کنم طلب نيم بوسه صد افسوس", Mesra2 = "ز حقه دهنش چون شکر فروريزد",},
new Hafez{ Id= 1294, BeytNo = 4, GhazalNo = 155, Mesra1 = "من آن فريب که در نرگس تو می‌بينم", Mesra2 = "بس آب روی که با خاک ره برآميزد",},
new Hafez{ Id= 1295, BeytNo = 5, GhazalNo = 155, Mesra1 = "فراز و شيب بيابان عشق دام بلاست", Mesra2 = "کجاست شيردلی کز بلا نپرهيزد",},
new Hafez{ Id= 1296, BeytNo = 6, GhazalNo = 155, Mesra1 = "تو عمر خواه و صبوری که چرخ شعبده باز", Mesra2 = "هزار بازی از اين طرفه‌تر برانگيزد",},
new Hafez{ Id= 1297, BeytNo = 7, GhazalNo = 155, Mesra1 = "بر آستانه تسليم سر بنه حافظ", Mesra2 = "که گر ستيزه کنی روزگار بستيزد",},
new Hafez{ Id= 1298, BeytNo = 1, GhazalNo = 156, Mesra1 = "به حسن و خلق و وفا کس به يار ما نرسد", Mesra2 = "تو را در اين سخن انکار کار ما نرسد",},
new Hafez{ Id= 1299, BeytNo = 2, GhazalNo = 156, Mesra1 = "اگر چه حسن فروشان به جلوه آمده‌اند", Mesra2 = "کسی به حسن و ملاحت به يار ما نرسد",},
new Hafez{ Id= 1300, BeytNo = 3, GhazalNo = 156, Mesra1 = "به حق صحبت ديرين که هيچ محرم راز", Mesra2 = "به يار يک جهت حق گزار ما نرسد",},
new Hafez{ Id= 1301, BeytNo = 4, GhazalNo = 156, Mesra1 = "هزار نقش برآيد ز کلک صنع و يکی", Mesra2 = "به دلپذيری نقش نگار ما نرسد",},
new Hafez{ Id= 1302, BeytNo = 5, GhazalNo = 156, Mesra1 = "هزار نقد به بازار کانات آرند", Mesra2 = "يکی به سکه صاحب عيار ما نرسد",},
new Hafez{ Id= 1303, BeytNo = 6, GhazalNo = 156, Mesra1 = "دريغ قافله عمر کان چنان رفتند", Mesra2 = "که گردشان به هوای ديار ما نرسد",},
new Hafez{ Id= 1304, BeytNo = 7, GhazalNo = 156, Mesra1 = "دلا ز رنج حسودان مرنج و واثق باش", Mesra2 = "که بد به خاطر اميدوار ما نرسد",},
new Hafez{ Id= 1305, BeytNo = 8, GhazalNo = 156, Mesra1 = "چنان بزی که اگر خاک ره شوی کس را", Mesra2 = "غبار خاطری از ره گذار ما نرسد",},
new Hafez{ Id= 1306, BeytNo = 9, GhazalNo = 156, Mesra1 = "بسوخت حافظ و ترسم که شرح قصه او", Mesra2 = "به سمع پادشه کامگار ما نرسد",},
new Hafez{ Id= 1307, BeytNo = 1, GhazalNo = 157, Mesra1 = "هر که را با خط سبزت سر سودا باشد", Mesra2 = "پای از اين دايره بيرون ننهد تا باشد",},
new Hafez{ Id= 1308, BeytNo = 2, GhazalNo = 157, Mesra1 = "من چو از خاک لحد لاله صفت برخيزم", Mesra2 = "داغ سودای توام سر سويدا باشد",},
new Hafez{ Id= 1309, BeytNo = 3, GhazalNo = 157, Mesra1 = "تو خود ای گوهر يک دانه کجايی آخر", Mesra2 = "کز غمت ديده مردم همه دريا باشد",},
new Hafez{ Id= 1310, BeytNo = 4, GhazalNo = 157, Mesra1 = "از بن هر مژه‌ام آب روان است بيا", Mesra2 = "اگرت ميل لب جوی و تماشا باشد",},
new Hafez{ Id= 1311, BeytNo = 5, GhazalNo = 157, Mesra1 = "چون گل و می دمی از پرده برون آی و درآ", Mesra2 = "که دگرباره ملاقات نه پيدا باشد",},
new Hafez{ Id= 1312, BeytNo = 6, GhazalNo = 157, Mesra1 = "ظل ممدود خم زلف توام بر سر باد", Mesra2 = "کاندر اين سايه قرار دل شيدا باشد",},
new Hafez{ Id= 1313, BeytNo = 7, GhazalNo = 157, Mesra1 = "چشمت از ناز به حافظ نکند ميل آری", Mesra2 = "سرگرانی صفت نرگس رعنا باشد",},
new Hafez{ Id= 1314, BeytNo = 1, GhazalNo = 158, Mesra1 = "من و انکار شراب اين چه حکايت باشد", Mesra2 = "غالبا اين قدرم عقل و کفايت باشد",},
new Hafez{ Id= 1315, BeytNo = 2, GhazalNo = 158, Mesra1 = "تا به غايت ره ميخانه نمی‌دانستم", Mesra2 = "ور نه مستوری ما تا به چه غايت باشد",},
new Hafez{ Id= 1316, BeytNo = 3, GhazalNo = 158, Mesra1 = "زاهد و عجب و نماز و من و مستی و نياز", Mesra2 = "تا تو را خود ز ميان با که عنايت باشد",},
new Hafez{ Id= 1317, BeytNo = 4, GhazalNo = 158, Mesra1 = "زاهد ار راه به رندی نبرد معذور است", Mesra2 = "عشق کاريست که موقوف هدايت باشد",},
new Hafez{ Id= 1318, BeytNo = 5, GhazalNo = 158, Mesra1 = "من که شب‌ها ره تقوا زده‌ام با دف و چنگ", Mesra2 = "اين زمان سر به ره آرم چه حکايت باشد",},
new Hafez{ Id= 1319, BeytNo = 6, GhazalNo = 158, Mesra1 = "بنده پير مغانم که ز جهلم برهاند", Mesra2 = "پير ما هر چه کند عين عنايت باشد",},
new Hafez{ Id= 1320, BeytNo = 7, GhazalNo = 158, Mesra1 = "دوش از اين غصه نخفتم که رفيقی می‌گفت", Mesra2 = "حافظ ار مست بود جای شکايت باشد",},
new Hafez{ Id= 1321, BeytNo = 1, GhazalNo = 159, Mesra1 = "نقد صوفی نه همه صافی بی‌غش باشد", Mesra2 = "ای بسا خرقه که مستوجب آتش باشد",},
new Hafez{ Id= 1322, BeytNo = 2, GhazalNo = 159, Mesra1 = "صوفی ما که ز ورد سحری مست شدی", Mesra2 = "شامگاهش نگران باش که سرخوش باشد",},
new Hafez{ Id= 1323, BeytNo = 3, GhazalNo = 159, Mesra1 = "خوش بود گر محک تجربه آيد به ميان", Mesra2 = "تا سيه روی شود هر که در او غش باشد",},
new Hafez{ Id= 1324, BeytNo = 4, GhazalNo = 159, Mesra1 = "خط ساقی گر از اين گونه زند نقش بر آب", Mesra2 = "ای بسا رخ که به خونابه منقش باشد",},
new Hafez{ Id= 1325, BeytNo = 5, GhazalNo = 159, Mesra1 = "ناز پرورد تنعم نبرد راه به دوست", Mesra2 = "عاشقی شيوه رندان بلاکش باشد",},
new Hafez{ Id= 1326, BeytNo = 6, GhazalNo = 159, Mesra1 = "غم دنيی دنی چند خوری باده بخور", Mesra2 = "حيف باشد دل دانا که مشوش باشد",},
new Hafez{ Id= 1327, BeytNo = 7, GhazalNo = 159, Mesra1 = "دلق و سجاده حافظ ببرد باده فروش", Mesra2 = "گر شرابش ز کف ساقی مه وش باشد",},
new Hafez{ Id= 1328, BeytNo = 1, GhazalNo = 160, Mesra1 = "خوش است خلوت اگر يار يار من باشد", Mesra2 = "نه من بسوزم و او شمع انجمن باشد",},
new Hafez{ Id= 1329, BeytNo = 2, GhazalNo = 160, Mesra1 = "من آن نگين سليمان به هيچ نستانم", Mesra2 = "که گاه گاه بر او دست اهرمن باشد",},
new Hafez{ Id= 1330, BeytNo = 3, GhazalNo = 160, Mesra1 = "روا مدار خدايا که در حريم وصال", Mesra2 = "رقيب محرم و حرمان نصيب من باشد",},
new Hafez{ Id= 1331, BeytNo = 4, GhazalNo = 160, Mesra1 = "همای گو مفکن سايه شرف هرگز", Mesra2 = "در آن ديار که طوطی کم از زغن باشد",},
new Hafez{ Id= 1332, BeytNo = 5, GhazalNo = 160, Mesra1 = "بيان شوق چه حاجت که سوز آتش دل", Mesra2 = "توان شناخت ز سوزی که در سخن باشد",},
new Hafez{ Id= 1333, BeytNo = 6, GhazalNo = 160, Mesra1 = "هوای کوی تو از سر نمی‌رود آری", Mesra2 = "غريب را دل سرگشته با وطن باشد",},
new Hafez{ Id= 1334, BeytNo = 7, GhazalNo = 160, Mesra1 = "به سان سوسن اگر ده زبان شود حافظ", Mesra2 = "چو غنچه پيش تواش مهر بر دهن باشد",},
new Hafez{ Id= 1335, BeytNo = 1, GhazalNo = 161, Mesra1 = "کی شعر تر انگيزد خاطر که حزين باشد", Mesra2 = "يک نکته از اين معنی گفتيم و همين باشد",},
new Hafez{ Id= 1336, BeytNo = 2, GhazalNo = 161, Mesra1 = "از لعل تو گر يابم انگشتری زنهار", Mesra2 = "صد ملک سليمانم در زير نگين باشد",},
new Hafez{ Id= 1337, BeytNo = 3, GhazalNo = 161, Mesra1 = "غمناک نبايد بود از طعن حسود ای دل", Mesra2 = "شايد که چو وابينی خير تو در اين باشد",},
new Hafez{ Id= 1338, BeytNo = 4, GhazalNo = 161, Mesra1 = "هر کو نکند فهمی زين کلک خيال انگيز", Mesra2 = "نقشش به حرام ار خود صورتگر چين باشد",},
new Hafez{ Id= 1339, BeytNo = 5, GhazalNo = 161, Mesra1 = "جام می و خون دل هر يک به کسی دادند", Mesra2 = "در دايره قسمت اوضاع چنين باشد",},
new Hafez{ Id= 1340, BeytNo = 6, GhazalNo = 161, Mesra1 = "در کار گلاب و گل حکم ازلی اين بود", Mesra2 = "کاين شاهد بازاری وان پرده نشين باشد",},
new Hafez{ Id= 1341, BeytNo = 7, GhazalNo = 161, Mesra1 = "آن نيست که حافظ را رندی بشد از خاطر", Mesra2 = "کاين سابقه پيشين تا روز پسين باشد",},
new Hafez{ Id= 1342, BeytNo = 1, GhazalNo = 162, Mesra1 = "خوش آمد گل وز آن خوشتر نباشد", Mesra2 = "که در دستت بجز ساغر نباشد",},
new Hafez{ Id= 1343, BeytNo = 2, GhazalNo = 162, Mesra1 = "زمان خوشدلی درياب و در ياب", Mesra2 = "که دايم در صدف گوهر نباشد",},
new Hafez{ Id= 1344, BeytNo = 3, GhazalNo = 162, Mesra1 = "غنيمت دان و می خور در گلستان", Mesra2 = "که گل تا هفته ديگر نباشد",},
new Hafez{ Id= 1345, BeytNo = 4, GhazalNo = 162, Mesra1 = "ايا پرلعل کرده جام زرين", Mesra2 = "ببخشا بر کسی کش زر نباشد",},
new Hafez{ Id= 1346, BeytNo = 5, GhazalNo = 162, Mesra1 = "بيا ای شيخ و از خمخانه ما", Mesra2 = "شرابی خور که در کوثر نباشد",},
new Hafez{ Id= 1347, BeytNo = 6, GhazalNo = 162, Mesra1 = "بشوی اوراق اگر همدرس مايی", Mesra2 = "که علم عشق در دفتر نباشد",},
new Hafez{ Id= 1348, BeytNo = 7, GhazalNo = 162, Mesra1 = "ز من بنيوش و دل در شاهدی بند", Mesra2 = "که حسنش بسته زيور نباشد",},
new Hafez{ Id= 1349, BeytNo = 8, GhazalNo = 162, Mesra1 = "شرابی بی خمارم بخش يا رب", Mesra2 = "که با وی هيچ درد سر نباشد",},
new Hafez{ Id= 1350, BeytNo = 9, GhazalNo = 162, Mesra1 = "من از جان بنده سلطان اويسم", Mesra2 = "اگر چه يادش از چاکر نباشد",},
new Hafez{ Id= 1351, BeytNo = 10, GhazalNo = 162, Mesra1 = "به تاج عالم آرايش که خورشيد", Mesra2 = "چنين زيبنده افسر نباشد",},
new Hafez{ Id= 1352, BeytNo = 11, GhazalNo = 162, Mesra1 = "کسی گيرد خطا بر نظم حافظ", Mesra2 = "که هيچش لطف در گوهر نباشد",},
new Hafez{ Id= 1353, BeytNo = 1, GhazalNo = 163, Mesra1 = "گل بی رخ يار خوش نباشد", Mesra2 = "بی باده بهار خوش نباشد",},
new Hafez{ Id= 1354, BeytNo = 2, GhazalNo = 163, Mesra1 = "طرف چمن و طواف بستان", Mesra2 = "بی لاله عذار خوش نباشد",},
new Hafez{ Id= 1355, BeytNo = 3, GhazalNo = 163, Mesra1 = "رقصيدن سرو و حالت گل", Mesra2 = "بی صوت هزار خوش نباشد",},
new Hafez{ Id= 1356, BeytNo = 4, GhazalNo = 163, Mesra1 = "با يار شکرلب گل اندام", Mesra2 = "بی بوس و کنار خوش نباشد",},
new Hafez{ Id= 1357, BeytNo = 5, GhazalNo = 163, Mesra1 = "هر نقش که دست عقل بندد", Mesra2 = "جز نقش نگار خوش نباشد",},
new Hafez{ Id= 1358, BeytNo = 6, GhazalNo = 163, Mesra1 = "جان نقد محقر است حافظ", Mesra2 = "از بهر نثار خوش نباشد",},
new Hafez{ Id= 1359, BeytNo = 1, GhazalNo = 164, Mesra1 = "نفس باد صبا مشک فشان خواهد شد", Mesra2 = "عالم پير دگرباره جوان خواهد شد",},
new Hafez{ Id= 1360, BeytNo = 2, GhazalNo = 164, Mesra1 = "ارغوان جام عقيقی به سمن خواهد داد", Mesra2 = "چشم نرگس به شقايق نگران خواهد شد",},
new Hafez{ Id= 1361, BeytNo = 3, GhazalNo = 164, Mesra1 = "اين تطاول که کشيد از غم هجران بلبل", Mesra2 = "تا سراپرده گل نعره زنان خواهد شد",},
new Hafez{ Id= 1362, BeytNo = 4, GhazalNo = 164, Mesra1 = "گر ز مسجد به خرابات شدم خرده مگير", Mesra2 = "مجلس وعظ دراز است و زمان خواهد شد",},
new Hafez{ Id= 1363, BeytNo = 5, GhazalNo = 164, Mesra1 = "ای دل ار عشرت امروز به فردا فکنی", Mesra2 = "مايه نقد بقا را که ضمان خواهد شد",},
new Hafez{ Id= 1364, BeytNo = 6, GhazalNo = 164, Mesra1 = "ماه شعبان منه از دست قدح کاين خورشيد", Mesra2 = "از نظر تا شب عيد رمضان خواهد شد",},
new Hafez{ Id= 1365, BeytNo = 7, GhazalNo = 164, Mesra1 = "گل عزيز است غنيمت شمريدش صحبت", Mesra2 = "که به باغ آمد از اين راه و از آن خواهد شد",},
new Hafez{ Id= 1366, BeytNo = 8, GhazalNo = 164, Mesra1 = "مطربا مجلس انس است غزل خوان و سرود", Mesra2 = "چند گويی که چنين رفت و چنان خواهد شد",},
new Hafez{ Id= 1367, BeytNo = 9, GhazalNo = 164, Mesra1 = "حافظ از بهر تو آمد سوی اقليم وجود", Mesra2 = "قدمی نه به وداعش که روان خواهد شد",},
new Hafez{ Id= 1368, BeytNo = 1, GhazalNo = 165, Mesra1 = "مرا مهر سيه چشمان ز سر بيرون نخواهد شد", Mesra2 = "قضای آسمان است اين و ديگرگون نخواهد شد",},
new Hafez{ Id= 1369, BeytNo = 2, GhazalNo = 165, Mesra1 = "رقيب آزارها فرمود و جای آشتی نگذاشت", Mesra2 = "مگر آه سحرخيزان سوی گردون نخواهد شد",},
new Hafez{ Id= 1370, BeytNo = 3, GhazalNo = 165, Mesra1 = "مرا روز ازل کاری بجز رندی نفرمودند", Mesra2 = "هر آن قسمت که آن جا رفت از آن افزون نخواهد شد",},
new Hafez{ Id= 1371, BeytNo = 4, GhazalNo = 165, Mesra1 = "خدا را محتسب ما را به فرياد دف و نی بخش", Mesra2 = "که ساز شرع از اين افسانه بی‌قانون نخواهد شد",},
new Hafez{ Id= 1372, BeytNo = 5, GhazalNo = 165, Mesra1 = "مجال من همين باشد که پنهان عشق او ورزم", Mesra2 = "کنار و بوس و آغوشش چه گويم چون نخواهد شد",},
new Hafez{ Id= 1373, BeytNo = 6, GhazalNo = 165, Mesra1 = "شراب لعل و جای امن و يار مهربان ساقی", Mesra2 = "دلا کی به شود کارت اگر اکنون نخواهد شد",},
new Hafez{ Id= 1374, BeytNo = 7, GhazalNo = 165, Mesra1 = "مشوی ای ديده نقش غم ز لوح سينه حافظ", Mesra2 = "که زخم تيغ دلدار است و رنگ خون نخواهد شد",},
new Hafez{ Id= 1375, BeytNo = 1, GhazalNo = 166, Mesra1 = "روز هجران و شب فرقت يار آخر شد", Mesra2 = "زدم اين فال و گذشت اختر و کار آخر شد",},
new Hafez{ Id= 1376, BeytNo = 2, GhazalNo = 166, Mesra1 = "آن همه ناز و تنعم که خزان می‌فرمود", Mesra2 = "عاقبت در قدم باد بهار آخر شد",},
new Hafez{ Id= 1377, BeytNo = 3, GhazalNo = 166, Mesra1 = "شکر ايزد که به اقبال کله گوشه گل", Mesra2 = "نخوت باد دی و شوکت خار آخر شد",},
new Hafez{ Id= 1378, BeytNo = 4, GhazalNo = 166, Mesra1 = "صبح اميد که بد معتکف پرده غيب", Mesra2 = "گو برون آی که کار شب تار آخر شد",},
new Hafez{ Id= 1379, BeytNo = 5, GhazalNo = 166, Mesra1 = "آن پريشانی شب‌های دراز و غم دل", Mesra2 = "همه در سايه گيسوی نگار آخر شد",},
new Hafez{ Id= 1380, BeytNo = 6, GhazalNo = 166, Mesra1 = "باورم نيست ز بدعهدی ايام هنوز", Mesra2 = "قصه غصه که در دولت يار آخر شد",},
new Hafez{ Id= 1381, BeytNo = 7, GhazalNo = 166, Mesra1 = "ساقيا لطف نمودی قدحت پرمی باد", Mesra2 = "که به تدبير تو تشويش خمار آخر شد",},
new Hafez{ Id= 1382, BeytNo = 8, GhazalNo = 166, Mesra1 = "در شمار ار چه نياورد کسی حافظ را", Mesra2 = "شکر کان محنت بی‌حد و شمار آخر شد",},
new Hafez{ Id= 1383, BeytNo = 1, GhazalNo = 167, Mesra1 = "ستاره‌ای بدرخشيد و ماه مجلس شد", Mesra2 = "دل رميده ما را رفيق و مونس شد",},
new Hafez{ Id= 1384, BeytNo = 2, GhazalNo = 167, Mesra1 = "نگار من که به مکتب نرفت و خط ننوشت", Mesra2 = "به غمزه مسله آموز صد مدرس شد",},
new Hafez{ Id= 1385, BeytNo = 3, GhazalNo = 167, Mesra1 = "به بوی او دل بيمار عاشقان چو صبا", Mesra2 = "فدای عارض نسرين و چشم نرگس شد",},
new Hafez{ Id= 1386, BeytNo = 4, GhazalNo = 167, Mesra1 = "به صدر مصطبه‌ام می‌نشاند اکنون دوست", Mesra2 = "گدای شهر نگه کن که مير مجلس شد",},
new Hafez{ Id= 1387, BeytNo = 5, GhazalNo = 167, Mesra1 = "خيال آب خضر بست و جام اسکندر", Mesra2 = "به جرعه نوشی سلطان ابوالفوارس شد",},
new Hafez{ Id= 1388, BeytNo = 6, GhazalNo = 167, Mesra1 = "طربسرای محبت کنون شود معمور", Mesra2 = "که طاق ابروی يار منش مهندس شد",},
new Hafez{ Id= 1389, BeytNo = 7, GhazalNo = 167, Mesra1 = "لب از ترشح می پاک کن برای خدا", Mesra2 = "که خاطرم به هزاران گنه موسوس شد",},
new Hafez{ Id= 1390, BeytNo = 8, GhazalNo = 167, Mesra1 = "کرشمه تو شرابی به عاشقان پيمود", Mesra2 = "که علم بی‌خبر افتاد و عقل بی‌حس شد",},
new Hafez{ Id= 1391, BeytNo = 9, GhazalNo = 167, Mesra1 = "چو زر عزيز وجود است نظم من آری", Mesra2 = "قبول دولتيان کيميای اين مس شد",},
new Hafez{ Id= 1392, BeytNo = 10, GhazalNo = 167, Mesra1 = "ز راه ميکده ياران عنان بگردانيد", Mesra2 = "چرا که حافظ از اين راه رفت و مفلس شد",},
new Hafez{ Id= 1393, BeytNo = 1, GhazalNo = 168, Mesra1 = "گداخت جان که شود کار دل تمام و نشد", Mesra2 = "بسوختيم در اين آرزوی خام و نشد",},
new Hafez{ Id= 1394, BeytNo = 2, GhazalNo = 168, Mesra1 = "به لابه گفت شبی مير مجلس تو شوم", Mesra2 = "شدم به رغبت خويشش کمين غلام و نشد",},
new Hafez{ Id= 1395, BeytNo = 3, GhazalNo = 168, Mesra1 = "پيام داد که خواهم نشست با رندان", Mesra2 = "بشد به رندی و دردی کشيم نام و نشد",},
new Hafez{ Id= 1396, BeytNo = 4, GhazalNo = 168, Mesra1 = "رواست در بر اگر می‌طپد کبوتر دل", Mesra2 = "که ديد در ره خود تاب و پيچ دام و نشد",},
new Hafez{ Id= 1397, BeytNo = 5, GhazalNo = 168, Mesra1 = "بدان هوس که به مستی ببوسم آن لب لعل", Mesra2 = "چه خون که در دلم افتاد همچو جام و نشد",},
new Hafez{ Id= 1398, BeytNo = 6, GhazalNo = 168, Mesra1 = "به کوی عشق منه بی‌دليل راه قدم", Mesra2 = "که من به خويش نمودم صد اهتمام و نشد",},
new Hafez{ Id= 1399, BeytNo = 7, GhazalNo = 168, Mesra1 = "فغان که در طلب گنج نامه مقصود", Mesra2 = "شدم خراب جهانی ز غم تمام و نشد",},
new Hafez{ Id= 1400, BeytNo = 8, GhazalNo = 168, Mesra1 = "دريغ و درد که در جست و جوی گنج حضور", Mesra2 = "بسی شدم به گدايی بر کرام و نشد",},
new Hafez{ Id= 1401, BeytNo = 9, GhazalNo = 168, Mesra1 = "هزار حيله برانگيخت حافظ از سر فکر", Mesra2 = "در آن هوس که شود آن نگار رام و نشد",},
new Hafez{ Id= 1402, BeytNo = 1, GhazalNo = 169, Mesra1 = "ياری اندر کس نمی‌بينيم ياران را چه شد", Mesra2 = "دوستی کی آخر آمد دوستداران را چه شد",},
new Hafez{ Id= 1403, BeytNo = 2, GhazalNo = 169, Mesra1 = "آب حيوان تيره گون شد خضر فرخ پی کجاست", Mesra2 = "خون چکيد از شاخ گل باد بهاران را چه شد",},
new Hafez{ Id= 1404, BeytNo = 3, GhazalNo = 169, Mesra1 = "کس نمی‌گويد که ياری داشت حق دوستی", Mesra2 = "حق شناسان را چه حال افتاد ياران را چه شد",},
new Hafez{ Id= 1405, BeytNo = 4, GhazalNo = 169, Mesra1 = "لعلی از کان مروت برنيامد سال‌هاست", Mesra2 = "تابش خورشيد و سعی باد و باران را چه شد",},
new Hafez{ Id= 1406, BeytNo = 5, GhazalNo = 169, Mesra1 = "شهر ياران بود و خاک مهربانان اين ديار", Mesra2 = "مهربانی کی سر آمد شهرياران را چه شد",},
new Hafez{ Id= 1407, BeytNo = 6, GhazalNo = 169, Mesra1 = "گوی توفيق و کرامت در ميان افکنده‌اند", Mesra2 = "کس به ميدان در نمی‌آيد سواران را چه شد",},
new Hafez{ Id= 1408, BeytNo = 7, GhazalNo = 169, Mesra1 = "صد هزاران گل شکفت و بانگ مرغی برنخاست", Mesra2 = "عندليبان را چه پيش آمد هزاران را چه شد",},
new Hafez{ Id= 1409, BeytNo = 8, GhazalNo = 169, Mesra1 = "زهره سازی خوش نمی‌سازد مگر عودش بسوخت", Mesra2 = "کس ندارد ذوق مستی ميگساران را چه شد",},
new Hafez{ Id= 1410, BeytNo = 9, GhazalNo = 169, Mesra1 = "حافظ اسرار الهی کس نمی‌داند خموش", Mesra2 = "از که می‌پرسی که دور روزگاران را چه شد",},
new Hafez{ Id= 1411, BeytNo = 1, GhazalNo = 170, Mesra1 = "زاهد خلوت نشين دوش به ميخانه شد", Mesra2 = "از سر پيمان برفت با سر پيمانه شد",},
new Hafez{ Id= 1412, BeytNo = 2, GhazalNo = 170, Mesra1 = "صوفی مجلس که دی جام و قدح می‌شکست", Mesra2 = "باز به يک جرعه می عاقل و فرزانه شد",},
new Hafez{ Id= 1413, BeytNo = 3, GhazalNo = 170, Mesra1 = "شاهد عهد شباب آمده بودش به خواب", Mesra2 = "باز به پيرانه سر عاشق و ديوانه شد",},
new Hafez{ Id= 1414, BeytNo = 4, GhazalNo = 170, Mesra1 = "مغبچه‌ای می‌گذشت راه زن دين و دل", Mesra2 = "در پی آن آشنا از همه بيگانه شد",},
new Hafez{ Id= 1415, BeytNo = 5, GhazalNo = 170, Mesra1 = "آتش رخسار گل خرمن بلبل بسوخت", Mesra2 = "چهره خندان شمع آفت پروانه شد",},
new Hafez{ Id= 1416, BeytNo = 6, GhazalNo = 170, Mesra1 = "گريه شام و سحر شکر که ضايع نگشت", Mesra2 = "قطره باران ما گوهر يک دانه شد",},
new Hafez{ Id= 1417, BeytNo = 7, GhazalNo = 170, Mesra1 = "نرگس ساقی بخواند آيت افسونگری", Mesra2 = "حلقه اوراد ما مجلس افسانه شد",},
new Hafez{ Id= 1418, BeytNo = 8, GhazalNo = 170, Mesra1 = "منزل حافظ کنون بارگه پادشاست", Mesra2 = "دل بر دلدار رفت جان بر جانانه شد",},
new Hafez{ Id= 1419, BeytNo = 1, GhazalNo = 171, Mesra1 = "دوش از جناب آصف پيک بشارت آمد", Mesra2 = "کز حضرت سليمان عشرت اشارت آمد",},
new Hafez{ Id= 1420, BeytNo = 2, GhazalNo = 171, Mesra1 = "خاک وجود ما را از آب ديده گل کن", Mesra2 = "ويرانسرای دل را گاه عمارت آمد",},
new Hafez{ Id= 1421, BeytNo = 3, GhazalNo = 171, Mesra1 = "اين شرح بی‌نهايت کز زلف يار گفتند", Mesra2 = "حرفيست از هزاران کاندر عبارت آمد",},
new Hafez{ Id= 1422, BeytNo = 4, GhazalNo = 171, Mesra1 = "عيبم بپوش زنهار ای خرقه می آلود", Mesra2 = "کان پاک پاکدامن بهر زيارت آمد",},
new Hafez{ Id= 1423, BeytNo = 5, GhazalNo = 171, Mesra1 = "امروز جای هر کس پيدا شود ز خوبان", Mesra2 = "کان ماه مجلس افروز اندر صدارت آمد",},
new Hafez{ Id= 1424, BeytNo = 6, GhazalNo = 171, Mesra1 = "بر تخت جم که تاجش معراج آسمان است", Mesra2 = "همت نگر که موری با آن حقارت آمد",},
new Hafez{ Id= 1425, BeytNo = 7, GhazalNo = 171, Mesra1 = "از چشم شوخش ای دل ايمان خود نگه دار", Mesra2 = "کان جادوی کمانکش بر عزم غارت آمد",},
new Hafez{ Id= 1426, BeytNo = 8, GhazalNo = 171, Mesra1 = "آلوده‌ای تو حافظ فيضی ز شاه درخواه", Mesra2 = "کان عنصر سماحت بهر طهارت آمد",},
new Hafez{ Id= 1427, BeytNo = 9, GhazalNo = 171, Mesra1 = "درياست مجلس او درياب وقت و در ياب", Mesra2 = "هان ای زيان رسيده وقت تجارت آمد",},
new Hafez{ Id= 1428, BeytNo = 1, GhazalNo = 172, Mesra1 = "عشق تو نهال حيرت آمد", Mesra2 = "وصل تو کمال حيرت آمد",},
new Hafez{ Id= 1429, BeytNo = 2, GhazalNo = 172, Mesra1 = "بس غرقه حال وصل کخر", Mesra2 = "هم بر سر حال حيرت آمد",},
new Hafez{ Id= 1430, BeytNo = 3, GhazalNo = 172, Mesra1 = "يک دل بنما که در ره او", Mesra2 = "بر چهره نه خال حيرت آمد",},
new Hafez{ Id= 1431, BeytNo = 4, GhazalNo = 172, Mesra1 = "نه وصل بماند و نه واصل", Mesra2 = "آن جا که خيال حيرت آمد",},
new Hafez{ Id= 1432, BeytNo = 5, GhazalNo = 172, Mesra1 = "از هر طرفی که گوش کردم", Mesra2 = "آواز سال حيرت آمد",},
new Hafez{ Id= 1433, BeytNo = 6, GhazalNo = 172, Mesra1 = "شد منهزم از کمال عزت", Mesra2 = "آن را که جلال حيرت آمد",},
new Hafez{ Id= 1434, BeytNo = 7, GhazalNo = 172, Mesra1 = "سر تا قدم وجود حافظ", Mesra2 = "در عشق نهال حيرت آمد",},
new Hafez{ Id= 1435, BeytNo = 1, GhazalNo = 173, Mesra1 = "در نمازم خم ابروی تو با ياد آمد", Mesra2 = "حالتی رفت که محراب به فرياد آمد",},
new Hafez{ Id= 1436, BeytNo = 2, GhazalNo = 173, Mesra1 = "از من اکنون طمع صبر و دل و هوش مدار", Mesra2 = "کان تحمل که تو ديدی همه بر باد آمد",},
new Hafez{ Id= 1437, BeytNo = 3, GhazalNo = 173, Mesra1 = "باده صافی شد و مرغان چمن مست شدند", Mesra2 = "موسم عاشقی و کار به بنياد آمد",},
new Hafez{ Id= 1438, BeytNo = 4, GhazalNo = 173, Mesra1 = "بوی بهبود ز اوضاع جهان می‌شنوم", Mesra2 = "شادی آورد گل و باد صبا شاد آمد",},
new Hafez{ Id= 1439, BeytNo = 5, GhazalNo = 173, Mesra1 = "ای عروس هنر از بخت شکايت منما", Mesra2 = "حجله حسن بيارای که داماد آمد",},
new Hafez{ Id= 1440, BeytNo = 6, GhazalNo = 173, Mesra1 = "دلفريبان نباتی همه زيور بستند", Mesra2 = "دلبر ماست که با حسن خداداد آمد",},
new Hafez{ Id= 1441, BeytNo = 7, GhazalNo = 173, Mesra1 = "زير بارند درختان که تعلق دارند", Mesra2 = "ای خوشا سرو که از بار غم آزاد آمد",},
new Hafez{ Id= 1442, BeytNo = 8, GhazalNo = 173, Mesra1 = "مطرب از گفته حافظ غزلی نغز بخوان", Mesra2 = "تا بگويم که ز عهد طربم ياد آمد",},
new Hafez{ Id= 1443, BeytNo = 1, GhazalNo = 174, Mesra1 = "مژده ای دل که دگر باد صبا بازآمد", Mesra2 = "هدهد خوش خبر از طرف سبا بازآمد",},
new Hafez{ Id= 1444, BeytNo = 2, GhazalNo = 174, Mesra1 = "برکش ای مرغ سحر نغمه داوودی باز", Mesra2 = "که سليمان گل از باد هوا بازآمد",},
new Hafez{ Id= 1445, BeytNo = 3, GhazalNo = 174, Mesra1 = "عارفی کو که کند فهم زبان سوسن", Mesra2 = "تا بپرسد که چرا رفت و چرا بازآمد",},
new Hafez{ Id= 1446, BeytNo = 4, GhazalNo = 174, Mesra1 = "مردمی کرد و کرم لطف خداداد به من", Mesra2 = "کان بت ماه رخ از راه وفا بازآمد",},
new Hafez{ Id= 1447, BeytNo = 5, GhazalNo = 174, Mesra1 = "لاله بوی می نوشين بشنيد از دم صبح", Mesra2 = "داغ دل بود به اميد دوا بازآمد",},
new Hafez{ Id= 1448, BeytNo = 6, GhazalNo = 174, Mesra1 = "چشم من در ره اين قافله راه بماند", Mesra2 = "تا به گوش دلم آواز درا بازآمد",},
new Hafez{ Id= 1449, BeytNo = 7, GhazalNo = 174, Mesra1 = "گر چه حافظ در رنجش زد و پيمان بشکست", Mesra2 = "لطف او بين که به لطف از در ما بازآمد",},
new Hafez{ Id= 1450, BeytNo = 1, GhazalNo = 175, Mesra1 = "صبا به تهنيت پير می فروش آمد", Mesra2 = "که موسم طرب و عيش و ناز و نوش آمد",},
new Hafez{ Id= 1451, BeytNo = 2, GhazalNo = 175, Mesra1 = "هوا مسيح نفس گشت و باد نافه گشای", Mesra2 = "درخت سبز شد و مرغ در خروش آمد",},
new Hafez{ Id= 1452, BeytNo = 3, GhazalNo = 175, Mesra1 = "تنور لاله چنان برفروخت باد بهار", Mesra2 = "که غنچه غرق عرق گشت و گل به جوش آمد",},
new Hafez{ Id= 1453, BeytNo = 4, GhazalNo = 175, Mesra1 = "به گوش هوش نيوش از من و به عشرت کوش", Mesra2 = "که اين سخن سحر از هاتفم به گوش آمد",},
new Hafez{ Id= 1454, BeytNo = 5, GhazalNo = 175, Mesra1 = "ز فکر تفرقه بازآی تا شوی مجموع", Mesra2 = "به حکم آن که چو شد اهرمن سروش آمد",},
new Hafez{ Id= 1455, BeytNo = 6, GhazalNo = 175, Mesra1 = "ز مرغ صبح ندانم که سوسن آزاد", Mesra2 = "چه گوش کرد که با ده زبان خموش آمد",},
new Hafez{ Id= 1456, BeytNo = 7, GhazalNo = 175, Mesra1 = "چه جای صحبت نامحرم است مجلس انس", Mesra2 = "سر پياله بپوشان که خرقه پوش آمد",},
new Hafez{ Id= 1457, BeytNo = 8, GhazalNo = 175, Mesra1 = "ز خانقاه به ميخانه می‌رود حافظ", Mesra2 = "مگر ز مستی زهد ريا به هوش آمد",},
new Hafez{ Id= 1458, BeytNo = 1, GhazalNo = 176, Mesra1 = "سحرم دولت بيدار به بالين آمد", Mesra2 = "گفت برخيز که آن خسرو شيرين آمد",},
new Hafez{ Id= 1459, BeytNo = 2, GhazalNo = 176, Mesra1 = "قدحی درکش و سرخوش به تماشا بخرام", Mesra2 = "تا ببينی که نگارت به چه آيين آمد",},
new Hafez{ Id= 1460, BeytNo = 3, GhazalNo = 176, Mesra1 = "مژدگانی بده ای خلوتی نافه گشای", Mesra2 = "که ز صحرای ختن آهوی مشکين آمد",},
new Hafez{ Id= 1461, BeytNo = 4, GhazalNo = 176, Mesra1 = "گريه آبی به رخ سوختگان بازآورد", Mesra2 = "ناله فريادرس عاشق مسکين آمد",},
new Hafez{ Id= 1462, BeytNo = 5, GhazalNo = 176, Mesra1 = "مرغ دل باز هوادار کمان ابرويست", Mesra2 = "ای کبوتر نگران باش که شاهين آمد",},
new Hafez{ Id= 1463, BeytNo = 6, GhazalNo = 176, Mesra1 = "ساقيا می بده و غم مخور از دشمن و دوست", Mesra2 = "که به کام دل ما آن بشد و اين آمد",},
new Hafez{ Id= 1464, BeytNo = 7, GhazalNo = 176, Mesra1 = "رسم بدعهدی ايام چو ديد ابر بهار", Mesra2 = "گريه‌اش بر سمن و سنبل و نسرين آمد",},
new Hafez{ Id= 1465, BeytNo = 8, GhazalNo = 176, Mesra1 = "چون صبا گفته حافظ بشنيد از بلبل", Mesra2 = "عنبرافشان به تماشای رياحين آمد",},
new Hafez{ Id= 1466, BeytNo = 1, GhazalNo = 177, Mesra1 = "نه هر که چهره برافروخت دلبری داند", Mesra2 = "نه هر که آينه سازد سکندری داند",},
new Hafez{ Id= 1467, BeytNo = 2, GhazalNo = 177, Mesra1 = "نه هر که طرف کله کج نهاد و تند نشست", Mesra2 = "کلاه داری و آيين سروری داند",},
new Hafez{ Id= 1468, BeytNo = 3, GhazalNo = 177, Mesra1 = "تو بندگی چو گدايان به شرط مزد مکن", Mesra2 = "که دوست خود روش بنده پروری داند",},
new Hafez{ Id= 1469, BeytNo = 4, GhazalNo = 177, Mesra1 = "غلام همت آن رند عافيت سوزم", Mesra2 = "که در گداصفتی کيمياگری داند",},
new Hafez{ Id= 1470, BeytNo = 5, GhazalNo = 177, Mesra1 = "وفا و عهد نکو باشد ار بياموزی", Mesra2 = "وگرنه هر که تو بينی ستمگری داند",},
new Hafez{ Id= 1471, BeytNo = 6, GhazalNo = 177, Mesra1 = "بباختم دل ديوانه و ندانستم", Mesra2 = "که آدمی بچه‌ای شيوه پری داند",},
new Hafez{ Id= 1472, BeytNo = 7, GhazalNo = 177, Mesra1 = "هزار نکته باريکتر ز مو اين جاست", Mesra2 = "نه هر که سر بتراشد قلندری داند",},
new Hafez{ Id= 1473, BeytNo = 8, GhazalNo = 177, Mesra1 = "مدار نقطه بينش ز خال توست مرا", Mesra2 = "که قدر گوهر يک دانه جوهری داند",},
new Hafez{ Id= 1474, BeytNo = 9, GhazalNo = 177, Mesra1 = "به قد و چهره هر آن کس که شاه خوبان شد", Mesra2 = "جهان بگيرد اگر دادگستری داند",},
new Hafez{ Id= 1475, BeytNo = 10, GhazalNo = 177, Mesra1 = "ز شعر دلکش حافظ کسی بود آگاه", Mesra2 = "که لطف طبع و سخن گفتن دری داند",},
new Hafez{ Id= 1476, BeytNo = 1, GhazalNo = 178, Mesra1 = "هر که شد محرم دل در حرم يار بماند", Mesra2 = "وان که اين کار ندانست در انکار بماند",},
new Hafez{ Id= 1477, BeytNo = 2, GhazalNo = 178, Mesra1 = "اگر از پرده برون شد دل من عيب مکن", Mesra2 = "شکر ايزد که نه در پرده پندار بماند",},
new Hafez{ Id= 1478, BeytNo = 3, GhazalNo = 178, Mesra1 = "صوفيان واستدند از گرو می همه رخت", Mesra2 = "دلق ما بود که در خانه خمار بماند",},
new Hafez{ Id= 1479, BeytNo = 4, GhazalNo = 178, Mesra1 = "محتسب شيخ شد و فسق خود از ياد ببرد", Mesra2 = "قصه ماست که در هر سر بازار بماند",},
new Hafez{ Id= 1480, BeytNo = 5, GhazalNo = 178, Mesra1 = "هر می لعل کز آن دست بلورين ستديم", Mesra2 = "آب حسرت شد و در چشم گهربار بماند",},
new Hafez{ Id= 1481, BeytNo = 6, GhazalNo = 178, Mesra1 = "جز دل من کز ازل تا به ابد عاشق رفت", Mesra2 = "جاودان کس نشنيديم که در کار بماند",},
new Hafez{ Id= 1482, BeytNo = 7, GhazalNo = 178, Mesra1 = "گشت بيمار که چون چشم تو گردد نرگس", Mesra2 = "شيوه تو نشدش حاصل و بيمار بماند",},
new Hafez{ Id= 1483, BeytNo = 8, GhazalNo = 178, Mesra1 = "از صدای سخن عشق نديدم خوشتر", Mesra2 = "يادگاری که در اين گنبد دوار بماند",},
new Hafez{ Id= 1484, BeytNo = 9, GhazalNo = 178, Mesra1 = "داشتم دلقی و صد عيب مرا می‌پوشيد", Mesra2 = "خرقه رهن می و مطرب شد و زنار بماند",},
new Hafez{ Id= 1485, BeytNo = 10, GhazalNo = 178, Mesra1 = "بر جمال تو چنان صورت چين حيران شد", Mesra2 = "که حديثش همه جا در در و ديوار بماند",},
new Hafez{ Id= 1486, BeytNo = 11, GhazalNo = 178, Mesra1 = "به تماشاگه زلفش دل حافظ روزی", Mesra2 = "شد که بازآيد و جاويد گرفتار بماند",},
new Hafez{ Id= 1487, BeytNo = 1, GhazalNo = 179, Mesra1 = "رسيد مژده که ايام غم نخواهد ماند", Mesra2 = "چنان نماند چنين نيز هم نخواهد ماند",},
new Hafez{ Id= 1488, BeytNo = 2, GhazalNo = 179, Mesra1 = "من ار چه در نظر يار خاکسار شدم", Mesra2 = "رقيب نيز چنين محترم نخواهد ماند",},
new Hafez{ Id= 1489, BeytNo = 3, GhazalNo = 179, Mesra1 = "چو پرده دار به شمشير می‌زند همه را", Mesra2 = "کسی مقيم حريم حرم نخواهد ماند",},
new Hafez{ Id= 1490, BeytNo = 4, GhazalNo = 179, Mesra1 = "چه جای شکر و شکايت ز نقش نيک و بد است", Mesra2 = "چو بر صحيفه هستی رقم نخواهد ماند",},
new Hafez{ Id= 1491, BeytNo = 5, GhazalNo = 179, Mesra1 = "سرود مجلس جمشيد گفته‌اند اين بود", Mesra2 = "که جام باده بياور که جم نخواهد ماند",},
new Hafez{ Id= 1492, BeytNo = 6, GhazalNo = 179, Mesra1 = "غنيمتی شمر ای شمع وصل پروانه", Mesra2 = "که اين معامله تا صبحدم نخواهد ماند",},
new Hafez{ Id= 1493, BeytNo = 7, GhazalNo = 179, Mesra1 = "توانگرا دل درويش خود به دست آور", Mesra2 = "که مخزن زر و گنج درم نخواهد ماند",},
new Hafez{ Id= 1494, BeytNo = 8, GhazalNo = 179, Mesra1 = "بدين رواق زبرجد نوشته‌اند به زر", Mesra2 = "که جز نکويی اهل کرم نخواهد ماند",},
new Hafez{ Id= 1495, BeytNo = 9, GhazalNo = 179, Mesra1 = "ز مهربانی جانان طمع مبر حافظ", Mesra2 = "که نقش جور و نشان ستم نخواهد ماند",},
new Hafez{ Id= 1496, BeytNo = 1, GhazalNo = 180, Mesra1 = "ای پسته تو خنده زده بر حديث قند", Mesra2 = "مشتاقم از برای خدا يک شکر بخند",},
new Hafez{ Id= 1497, BeytNo = 2, GhazalNo = 180, Mesra1 = "طوبی ز قامت تو نيارد که دم زند", Mesra2 = "زين قصه بگذرم که سخن می‌شود بلند",},
new Hafez{ Id= 1498, BeytNo = 3, GhazalNo = 180, Mesra1 = "خواهی که برنخيزدت از ديده رود خون", Mesra2 = "دل در وفای صحبت رود کسان مبند",},
new Hafez{ Id= 1499, BeytNo = 4, GhazalNo = 180, Mesra1 = "گر جلوه می‌نمايی و گر طعنه می‌زنی", Mesra2 = "ما نيستيم معتقد شيخ خودپسند",},
new Hafez{ Id= 1500, BeytNo = 5, GhazalNo = 180, Mesra1 = "ز آشفتگی حال من آگاه کی شود", Mesra2 = "آن را که دل نگشت گرفتار اين کمند",},
new Hafez{ Id= 1501, BeytNo = 6, GhazalNo = 180, Mesra1 = "بازار شوق گرم شد آن سروقد کجاست", Mesra2 = "تا جان خود بر آتش رويش کنم سپند",},
new Hafez{ Id= 1502, BeytNo = 7, GhazalNo = 180, Mesra1 = "جايی که يار ما به شکرخنده دم زند", Mesra2 = "ای پسته کيستی تو خدا را به خود مخند",},
new Hafez{ Id= 1503, BeytNo = 8, GhazalNo = 180, Mesra1 = "حافظ چو ترک غمزه ترکان نمی‌کنی", Mesra2 = "دانی کجاست جای تو خوارزم يا خجند",},
new Hafez{ Id= 1504, BeytNo = 1, GhazalNo = 181, Mesra1 = "بعد از اين دست من و دامن آن سرو بلند", Mesra2 = "که به بالای چمان از بن و بيخم برکند",},
new Hafez{ Id= 1505, BeytNo = 2, GhazalNo = 181, Mesra1 = "حاجت مطرب و می نيست تو برقع بگشا", Mesra2 = "که به رقص آوردم آتش رويت چو سپند",},
new Hafez{ Id= 1506, BeytNo = 3, GhazalNo = 181, Mesra1 = "هيچ رويی نشود آينه حجله بخت", Mesra2 = "مگر آن روی که مالند در آن سم سمند",},
new Hafez{ Id= 1507, BeytNo = 4, GhazalNo = 181, Mesra1 = "گفتم اسرار غمت هر چه بود گو می‌باش", Mesra2 = "صبر از اين بيش ندارم چه کنم تا کی و چند",},
new Hafez{ Id= 1508, BeytNo = 5, GhazalNo = 181, Mesra1 = "مکش آن آهوی مشکين مرا ای صياد", Mesra2 = "شرم از آن چشم سيه دار و مبندش به کمند",},
new Hafez{ Id= 1509, BeytNo = 6, GhazalNo = 181, Mesra1 = "من خاکی که از اين در نتوانم برخاست", Mesra2 = "از کجا بوسه زنم بر لب آن قصر بلند",},
new Hafez{ Id= 1510, BeytNo = 7, GhazalNo = 181, Mesra1 = "باز مستان دل از آن گيسوی مشکين حافظ", Mesra2 = "زان که ديوانه همان به که بود اندر بند",},
new Hafez{ Id= 1511, BeytNo = 1, GhazalNo = 182, Mesra1 = "حسب حالی ننوشتی و شد ايامی چند", Mesra2 = "محرمی کو که فرستم به تو پيغامی چند",},
new Hafez{ Id= 1512, BeytNo = 2, GhazalNo = 182, Mesra1 = "ما بدان مقصد عالی نتوانيم رسيد", Mesra2 = "هم مگر پيش نهد لطف شما گامی چند",},
new Hafez{ Id= 1513, BeytNo = 3, GhazalNo = 182, Mesra1 = "چون می از خم به سبو رفت و گل افکند نقاب", Mesra2 = "فرصت عيش نگه دار و بزن جامی چند",},
new Hafez{ Id= 1514, BeytNo = 4, GhazalNo = 182, Mesra1 = "قند آميخته با گل نه علاج دل ماست", Mesra2 = "بوسه‌ای چند برآميز به دشنامی چند",},
new Hafez{ Id= 1515, BeytNo = 5, GhazalNo = 182, Mesra1 = "زاهد از کوچه رندان به سلامت بگذر", Mesra2 = "تا خرابت نکند صحبت بدنامی چند",},
new Hafez{ Id= 1516, BeytNo = 6, GhazalNo = 182, Mesra1 = "عيب می جمله چو گفتی هنرش نيز بگو", Mesra2 = "نفی حکمت مکن از بهر دل عامی چند",},
new Hafez{ Id= 1517, BeytNo = 7, GhazalNo = 182, Mesra1 = "ای گدايان خرابات خدا يار شماست", Mesra2 = "چشم انعام مداريد ز انعامی چند",},
new Hafez{ Id= 1518, BeytNo = 8, GhazalNo = 182, Mesra1 = "پير ميخانه چه خوش گفت به دردی کش خويش", Mesra2 = "که مگو حال دل سوخته با خامی چند",},
new Hafez{ Id= 1519, BeytNo = 9, GhazalNo = 182, Mesra1 = "حافظ از شوق رخ مهر فروغ تو بسوخت", Mesra2 = "کامگارا نظری کن سوی ناکامی چند",},
new Hafez{ Id= 1520, BeytNo = 1, GhazalNo = 183, Mesra1 = "دوش وقت سحر از غصه نجاتم دادند", Mesra2 = "واندر آن ظلمت شب آب حياتم دادند",},
new Hafez{ Id= 1521, BeytNo = 2, GhazalNo = 183, Mesra1 = "بيخود از شعشعه پرتو ذاتم کردند", Mesra2 = "باده از جام تجلی صفاتم دادند",},
new Hafez{ Id= 1522, BeytNo = 3, GhazalNo = 183, Mesra1 = "چه مبارک سحری بود و چه فرخنده شبی", Mesra2 = "آن شب قدر که اين تازه براتم دادند",},
new Hafez{ Id= 1523, BeytNo = 4, GhazalNo = 183, Mesra1 = "بعد از اين روی من و آينه وصف جمال", Mesra2 = "که در آن جا خبر از جلوه ذاتم دادند",},
new Hafez{ Id= 1524, BeytNo = 5, GhazalNo = 183, Mesra1 = "من اگر کامروا گشتم و خوشدل چه عجب", Mesra2 = "مستحق بودم و اين‌ها به زکاتم دادند",},
new Hafez{ Id= 1525, BeytNo = 6, GhazalNo = 183, Mesra1 = "هاتف آن روز به من مژده اين دولت داد", Mesra2 = "که بدان جور و جفا صبر و ثباتم دادند",},
new Hafez{ Id= 1526, BeytNo = 7, GhazalNo = 183, Mesra1 = "اين همه شهد و شکر کز سخنم می‌ريزد", Mesra2 = "اجر صبريست کز آن شاخ نباتم دادند",},
new Hafez{ Id= 1527, BeytNo = 8, GhazalNo = 183, Mesra1 = "همت حافظ و انفاس سحرخيزان بود", Mesra2 = "که ز بند غم ايام نجاتم دادند",},
new Hafez{ Id= 1528, BeytNo = 1, GhazalNo = 184, Mesra1 = "دوش ديدم که ملايک در ميخانه زدند", Mesra2 = "گل آدم بسرشتند و به پيمانه زدند",},
new Hafez{ Id= 1529, BeytNo = 2, GhazalNo = 184, Mesra1 = "ساکنان حرم ستر و عفاف ملکوت", Mesra2 = "با من راه نشين باده مستانه زدند",},
new Hafez{ Id= 1530, BeytNo = 3, GhazalNo = 184, Mesra1 = "آسمان بار امانت نتوانست کشيد", Mesra2 = "قرعه کار به نام من ديوانه زدند",},
new Hafez{ Id= 1531, BeytNo = 4, GhazalNo = 184, Mesra1 = "جنگ هفتاد و دو ملت همه را عذر بنه", Mesra2 = "چون نديدند حقيقت ره افسانه زدند",},
new Hafez{ Id= 1532, BeytNo = 5, GhazalNo = 184, Mesra1 = "شکر ايزد که ميان من و او صلح افتاد", Mesra2 = "صوفيان رقص کنان ساغر شکرانه زدند",},
new Hafez{ Id= 1533, BeytNo = 6, GhazalNo = 184, Mesra1 = "آتش آن نيست که از شعله او خندد شمع", Mesra2 = "آتش آن است که در خرمن پروانه زدند",},
new Hafez{ Id= 1534, BeytNo = 7, GhazalNo = 184, Mesra1 = "کس چو حافظ نگشاد از رخ انديشه نقاب", Mesra2 = "تا سر زلف سخن را به قلم شانه زدند",},
new Hafez{ Id= 1535, BeytNo = 1, GhazalNo = 185, Mesra1 = "نقدها را بود آيا که عياری گيرند", Mesra2 = "تا همه صومعه داران پی کاری گيرند",},
new Hafez{ Id= 1536, BeytNo = 2, GhazalNo = 185, Mesra1 = "مصلحت ديد من آن است که ياران همه کار", Mesra2 = "بگذارند و خم طره ياری گيرند",},
new Hafez{ Id= 1537, BeytNo = 3, GhazalNo = 185, Mesra1 = "خوش گرفتند حريفان سر زلف ساقی", Mesra2 = "گر فلکشان بگذارد که قراری گيرند",},
new Hafez{ Id= 1538, BeytNo = 4, GhazalNo = 185, Mesra1 = "قوت بازوی پرهيز به خوبان مفروش", Mesra2 = "که در اين خيل حصاری به سواری گيرند",},
new Hafez{ Id= 1539, BeytNo = 5, GhazalNo = 185, Mesra1 = "يا رب اين بچه ترکان چه دليرند به خون", Mesra2 = "که به تير مژه هر لحظه شکاری گيرند",},
new Hafez{ Id= 1540, BeytNo = 6, GhazalNo = 185, Mesra1 = "رقص بر شعر تر و ناله نی خوش باشد", Mesra2 = "خاصه رقصی که در آن دست نگاری گيرند",},
new Hafez{ Id= 1541, BeytNo = 7, GhazalNo = 185, Mesra1 = "حافظ ابنای زمان را غم مسکينان نيست", Mesra2 = "زين ميان گر بتوان به که کناری گيرند",},
new Hafez{ Id= 1542, BeytNo = 1, GhazalNo = 186, Mesra1 = "گر می فروش حاجت رندان روا کند", Mesra2 = "ايزد گنه ببخشد و دفع بلا کند",},
new Hafez{ Id= 1543, BeytNo = 2, GhazalNo = 186, Mesra1 = "ساقی به جام عدل بده باده تا گدا", Mesra2 = "غيرت نياورد که جهان پربلا کند",},
new Hafez{ Id= 1544, BeytNo = 3, GhazalNo = 186, Mesra1 = "حقا کز اين غمان برسد مژده امان", Mesra2 = "گر سالکی به عهد امانت وفا کند",},
new Hafez{ Id= 1545, BeytNo = 4, GhazalNo = 186, Mesra1 = "گر رنج پيش آيد و گر راحت ای حکيم", Mesra2 = "نسبت مکن به غير که اين‌ها خدا کند",},
new Hafez{ Id= 1546, BeytNo = 5, GhazalNo = 186, Mesra1 = "در کارخانه‌ای که ره عقل و فضل نيست", Mesra2 = "فهم ضعيف رای فضولی چرا کند",},
new Hafez{ Id= 1547, BeytNo = 6, GhazalNo = 186, Mesra1 = "مطرب بساز پرده که کس بی اجل نمرد", Mesra2 = "وان کو نه اين ترانه سرايد خطا کند",},
new Hafez{ Id= 1548, BeytNo = 7, GhazalNo = 186, Mesra1 = "ما را که درد عشق و بلای خمار کشت", Mesra2 = "يا وصل دوست يا می صافی دوا کند",},
new Hafez{ Id= 1549, BeytNo = 8, GhazalNo = 186, Mesra1 = "جان رفت در سر می و حافظ به عشق سوخت", Mesra2 = "عيسی دمی کجاست که احيای ما کند",},
new Hafez{ Id= 1550, BeytNo = 1, GhazalNo = 187, Mesra1 = "دلا بسوز که سوز تو کارها بکند", Mesra2 = "نياز نيم شبی دفع صد بلا بکند",},
new Hafez{ Id= 1551, BeytNo = 2, GhazalNo = 187, Mesra1 = "عتاب يار پری چهره عاشقانه بکش", Mesra2 = "که يک کرشمه تلافی صد جفا بکند",},
new Hafez{ Id= 1552, BeytNo = 3, GhazalNo = 187, Mesra1 = "ز ملک تا ملکوتش حجاب بردارند", Mesra2 = "هر آن که خدمت جام جهان نما بکند",},
new Hafez{ Id= 1553, BeytNo = 4, GhazalNo = 187, Mesra1 = "طبيب عشق مسيحادم است و مشفق ليک", Mesra2 = "چو درد در تو نبيند که را دوا بکند",},
new Hafez{ Id= 1554, BeytNo = 5, GhazalNo = 187, Mesra1 = "تو با خدای خود انداز کار و دل خوش دار", Mesra2 = "که رحم اگر نکند مدعی خدا بکند",},
new Hafez{ Id= 1555, BeytNo = 6, GhazalNo = 187, Mesra1 = "ز بخت خفته ملولم بود که بيداری", Mesra2 = "به وقت فاتحه صبح يک دعا بکند",},
new Hafez{ Id= 1556, BeytNo = 7, GhazalNo = 187, Mesra1 = "بسوخت حافظ و بويی به زلف يار نبرد", Mesra2 = "مگر دلالت اين دولتش صبا بکند",},
new Hafez{ Id= 1557, BeytNo = 1, GhazalNo = 188, Mesra1 = "مرا به رندی و عشق آن فضول عيب کند", Mesra2 = "که اعتراض بر اسرار علم غيب کند",},
new Hafez{ Id= 1558, BeytNo = 2, GhazalNo = 188, Mesra1 = "کمال سر محبت ببين نه نقص گناه", Mesra2 = "که هر که بی‌هنر افتد نظر به عيب کند",},
new Hafez{ Id= 1559, BeytNo = 3, GhazalNo = 188, Mesra1 = "ز عطر حور بهشت آن نفس برآيد بوی", Mesra2 = "که خاک ميکده ما عبير جيب کند",},
new Hafez{ Id= 1560, BeytNo = 4, GhazalNo = 188, Mesra1 = "چنان زند ره اسلام غمزه ساقی", Mesra2 = "که اجتناب ز صهبا مگر صهيب کند",},
new Hafez{ Id= 1561, BeytNo = 5, GhazalNo = 188, Mesra1 = "کليد گنج سعادت قبول اهل دل است", Mesra2 = "مباد آن که در اين نکته شک و ريب کند",},
new Hafez{ Id= 1562, BeytNo = 6, GhazalNo = 188, Mesra1 = "شبان وادی ايمن گهی رسد به مراد", Mesra2 = "که چند سال به جان خدمت شعيب کند",},
new Hafez{ Id= 1563, BeytNo = 7, GhazalNo = 188, Mesra1 = "ز ديده خون بچکاند فسانه حافظ", Mesra2 = "چو ياد وقت زمان شباب و شيب کند",},
new Hafez{ Id= 1564, BeytNo = 1, GhazalNo = 189, Mesra1 = "طاير دولت اگر باز گذاری بکند", Mesra2 = "يار بازآيد و با وصل قراری بکند",},
new Hafez{ Id= 1565, BeytNo = 2, GhazalNo = 189, Mesra1 = "ديده را دستگه در و گهر گر چه نماند", Mesra2 = "بخورد خونی و تدبير نثاری بکند",},
new Hafez{ Id= 1566, BeytNo = 3, GhazalNo = 189, Mesra1 = "دوش گفتم بکند لعل لبش چاره من", Mesra2 = "هاتف غيب ندا داد که آری بکند",},
new Hafez{ Id= 1567, BeytNo = 4, GhazalNo = 189, Mesra1 = "کس نيارد بر او دم زند از قصه ما", Mesra2 = "مگرش باد صبا گوش گذاری بکند",},
new Hafez{ Id= 1568, BeytNo = 5, GhazalNo = 189, Mesra1 = "داده‌ام باز نظر را به تذروی پرواز", Mesra2 = "بازخواند مگرش نقش و شکاری بکند",},
new Hafez{ Id= 1569, BeytNo = 6, GhazalNo = 189, Mesra1 = "شهر خاليست ز عشاق بود کز طرفی", Mesra2 = "مردی از خويش برون آيد و کاری بکند",},
new Hafez{ Id= 1570, BeytNo = 7, GhazalNo = 189, Mesra1 = "کو کريمی که ز بزم طربش غمزده‌ای", Mesra2 = "جرعه‌ای درکشد و دفع خماری بکند",},
new Hafez{ Id= 1571, BeytNo = 8, GhazalNo = 189, Mesra1 = "يا وفا يا خبر وصل تو يا مرگ رقيب", Mesra2 = "بود آيا که فلک زين دو سه کاری بکند",},
new Hafez{ Id= 1572, BeytNo = 9, GhazalNo = 189, Mesra1 = "حافظا گر نروی از در او هم روزی", Mesra2 = "گذری بر سرت از گوشه کناری بکند",},
new Hafez{ Id= 1573, BeytNo = 1, GhazalNo = 190, Mesra1 = "کلک مشکين تو روزی که ز ما ياد کند", Mesra2 = "ببرد اجر دو صد بنده که آزاد کند",},
new Hafez{ Id= 1574, BeytNo = 2, GhazalNo = 190, Mesra1 = "قاصد منزل سلمی که سلامت بادش", Mesra2 = "چه شود گر به سلامی دل ما شاد کند",},
new Hafez{ Id= 1575, BeytNo = 3, GhazalNo = 190, Mesra1 = "امتحان کن که بسی گنج مرادت بدهند", Mesra2 = "گر خرابی چو مرا لطف تو آباد کند",},
new Hafez{ Id= 1576, BeytNo = 4, GhazalNo = 190, Mesra1 = "يا رب اندر دل آن خسرو شيرين انداز", Mesra2 = "که به رحمت گذری بر سر فرهاد کند",},
new Hafez{ Id= 1577, BeytNo = 5, GhazalNo = 190, Mesra1 = "شاه را به بود از طاعت صدساله و زهد", Mesra2 = "قدر يک ساعته عمری که در او داد کند",},
new Hafez{ Id= 1578, BeytNo = 6, GhazalNo = 190, Mesra1 = "حاليا عشوه ناز تو ز بنيادم برد", Mesra2 = "تا دگرباره حکيمانه چه بنياد کند",},
new Hafez{ Id= 1579, BeytNo = 7, GhazalNo = 190, Mesra1 = "گوهر پاک تو از مدحت ما مستغنيست", Mesra2 = "فکر مشاطه چه با حسن خداداد کند",},
new Hafez{ Id= 1580, BeytNo = 8, GhazalNo = 190, Mesra1 = "ره نبرديم به مقصود خود اندر شيراز", Mesra2 = "خرم آن روز که حافظ ره بغداد کند",},
new Hafez{ Id= 1581, BeytNo = 1, GhazalNo = 191, Mesra1 = "آن کيست کز روی کرم با ما وفاداری کند", Mesra2 = "بر جای بدکاری چو من يک دم نکوکاری کند",},
new Hafez{ Id= 1582, BeytNo = 2, GhazalNo = 191, Mesra1 = "اول به بانگ نای و نی آرد به دل پيغام وی", Mesra2 = "وان گه به يک پيمانه می با من وفاداری کند",},
new Hafez{ Id= 1583, BeytNo = 3, GhazalNo = 191, Mesra1 = "دلبر که جان فرسود از او کام دلم نگشود از او", Mesra2 = "نوميد نتوان بود از او باشد که دلداری کند",},
new Hafez{ Id= 1584, BeytNo = 4, GhazalNo = 191, Mesra1 = "گفتم گره نگشوده‌ام زان طره تا من بوده‌ام", Mesra2 = "گفتا منش فرموده‌ام تا با تو طراری کند",},
new Hafez{ Id= 1585, BeytNo = 5, GhazalNo = 191, Mesra1 = "پشمينه پوش تندخو از عشق نشنيده‌است بو", Mesra2 = "از مستيش رمزی بگو تا ترک هشياری کند",},
new Hafez{ Id= 1586, BeytNo = 6, GhazalNo = 191, Mesra1 = "چون من گدای بی‌نشان مشکل بود ياری چنان", Mesra2 = "سلطان کجا عيش نهان با رند بازاری کند",},
new Hafez{ Id= 1587, BeytNo = 7, GhazalNo = 191, Mesra1 = "زان طره پرپيچ و خم سهل است اگر بينم ستم", Mesra2 = "از بند و زنجيرش چه غم هر کس که عياری کند",},
new Hafez{ Id= 1588, BeytNo = 8, GhazalNo = 191, Mesra1 = "شد لشکر غم بی عدد از بخت می‌خواهم مدد", Mesra2 = "تا فخر دين عبدالصمد باشد که غمخواری کند",},
new Hafez{ Id= 1589, BeytNo = 9, GhazalNo = 191, Mesra1 = "با چشم پرنيرنگ او حافظ مکن آهنگ او", Mesra2 = "کان طره شبرنگ او بسيار طراری کند",},
new Hafez{ Id= 1590, BeytNo = 1, GhazalNo = 192, Mesra1 = "سرو چمان من چرا ميل چمن نمی‌کند", Mesra2 = "همدم گل نمی‌شود ياد سمن نمی‌کند",},
new Hafez{ Id= 1591, BeytNo = 2, GhazalNo = 192, Mesra1 = "دی گله‌ای ز طره‌اش کردم و از سر فسوس", Mesra2 = "گفت که اين سياه کج گوش به من نمی‌کند",},
new Hafez{ Id= 1592, BeytNo = 3, GhazalNo = 192, Mesra1 = "تا دل هرزه گرد من رفت به چين زلف او", Mesra2 = "زان سفر دراز خود عزم وطن نمی‌کند",},
new Hafez{ Id= 1593, BeytNo = 4, GhazalNo = 192, Mesra1 = "پيش کمان ابرويش لابه همی‌کنم ولی", Mesra2 = "گوش کشيده است از آن گوش به من نمی‌کند",},
new Hafez{ Id= 1594, BeytNo = 5, GhazalNo = 192, Mesra1 = "با همه عطف دامنت آيدم از صبا عجب", Mesra2 = "کز گذر تو خاک را مشک ختن نمی‌کند",},
new Hafez{ Id= 1595, BeytNo = 6, GhazalNo = 192, Mesra1 = "چون ز نسيم می‌شود زلف بنفشه پرشکن", Mesra2 = "وه که دلم چه ياد از آن عهدشکن نمی‌کند",},
new Hafez{ Id= 1596, BeytNo = 7, GhazalNo = 192, Mesra1 = "دل به اميد روی او همدم جان نمی‌شود", Mesra2 = "جان به هوای کوی او خدمت تن نمی‌کند",},
new Hafez{ Id= 1597, BeytNo = 8, GhazalNo = 192, Mesra1 = "ساقی سيم ساق من گر همه درد می‌دهد", Mesra2 = "کيست که تن چو جام می جمله دهن نمی‌کند",},
new Hafez{ Id= 1598, BeytNo = 9, GhazalNo = 192, Mesra1 = "دستخوش جفا مکن آب رخم که فيض ابر", Mesra2 = "بی مدد سرشک من در عدن نمی‌کند",},
new Hafez{ Id= 1599, BeytNo = 10, GhazalNo = 192, Mesra1 = "کشته غمزه تو شد حافظ ناشنيده پند", Mesra2 = "تيغ سزاست هر که را درد سخن نمی‌کند",},
new Hafez{ Id= 1600, BeytNo = 1, GhazalNo = 193, Mesra1 = "در نظربازی ما بی‌خبران حيرانند", Mesra2 = "من چنينم که نمودم دگر ايشان دانند",},
new Hafez{ Id= 1601, BeytNo = 2, GhazalNo = 193, Mesra1 = "عاقلان نقطه پرگار وجودند ولی", Mesra2 = "عشق داند که در اين دايره سرگردانند",},
new Hafez{ Id= 1602, BeytNo = 3, GhazalNo = 193, Mesra1 = "جلوه گاه رخ او ديده من تنها نيست", Mesra2 = "ماه و خورشيد همين آينه می‌گردانند",},
new Hafez{ Id= 1603, BeytNo = 4, GhazalNo = 193, Mesra1 = "عهد ما با لب شيرين دهنان بست خدا", Mesra2 = "ما همه بنده و اين قوم خداوندانند",},
new Hafez{ Id= 1604, BeytNo = 5, GhazalNo = 193, Mesra1 = "مفلسانيم و هوای می و مطرب داريم", Mesra2 = "آه اگر خرقه پشمين به گرو نستانند",},
new Hafez{ Id= 1605, BeytNo = 6, GhazalNo = 193, Mesra1 = "وصل خورشيد به شبپره اعمی نرسد", Mesra2 = "که در آن آينه صاحب نظران حيرانند",},
new Hafez{ Id= 1606, BeytNo = 7, GhazalNo = 193, Mesra1 = "لاف عشق و گله از يار زهی لاف دروغ", Mesra2 = "عشقبازان چنين مستحق هجرانند",},
new Hafez{ Id= 1607, BeytNo = 8, GhazalNo = 193, Mesra1 = "مگرم چشم سياه تو بياموزد کار", Mesra2 = "ور نه مستوری و مستی همه کس نتوانند",},
new Hafez{ Id= 1608, BeytNo = 9, GhazalNo = 193, Mesra1 = "گر به نزهتگه ارواح برد بوی تو باد", Mesra2 = "عقل و جان گوهر هستی به نثار افشانند",},
new Hafez{ Id= 1609, BeytNo = 10, GhazalNo = 193, Mesra1 = "زاهد ار رندی حافظ نکند فهم چه شد", Mesra2 = "ديو بگريزد از آن قوم که قرآن خوانند",},
new Hafez{ Id= 1610, BeytNo = 11, GhazalNo = 193, Mesra1 = "گر شوند آگه از انديشه ما مغبچگان", Mesra2 = "بعد از اين خرقه صوفی به گرو نستانند",},
new Hafez{ Id= 1611, BeytNo = 1, GhazalNo = 194, Mesra1 = "سمن بويان غبار غم چو بنشينند بنشانند", Mesra2 = "پری رويان قرار از دل چو بستيزند بستانند",},
new Hafez{ Id= 1612, BeytNo = 2, GhazalNo = 194, Mesra1 = "به فتراک جفا دل‌ها چو بربندند بربندند", Mesra2 = "ز زلف عنبرين جان‌ها چو بگشايند بفشانند",},
new Hafez{ Id= 1613, BeytNo = 3, GhazalNo = 194, Mesra1 = "به عمری يک نفس با ما چو بنشينند برخيزند", Mesra2 = "نهال شوق در خاطر چو برخيزند بنشانند",},
new Hafez{ Id= 1614, BeytNo = 4, GhazalNo = 194, Mesra1 = "سرشک گوشه گيران را چو دريابند در يابند", Mesra2 = "رخ مهر از سحرخيزان نگردانند اگر دانند",},
new Hafez{ Id= 1615, BeytNo = 5, GhazalNo = 194, Mesra1 = "ز چشمم لعل رمانی چو می‌خندند می‌بارند", Mesra2 = "ز رويم راز پنهانی چو می‌بينند می‌خوانند",},
new Hafez{ Id= 1616, BeytNo = 6, GhazalNo = 194, Mesra1 = "دوای درد عاشق را کسی کو سهل پندارد", Mesra2 = "ز فکر آنان که در تدبير درمانند در مانند",},
new Hafez{ Id= 1617, BeytNo = 7, GhazalNo = 194, Mesra1 = "چو منصور از مراد آنان که بردارند بر دارند", Mesra2 = "بدين درگاه حافظ را چو می‌خوانند می‌رانند",},
new Hafez{ Id= 1618, BeytNo = 8, GhazalNo = 194, Mesra1 = "در اين حضرت چو مشتاقان نياز آرند ناز آرند", Mesra2 = "که با اين درد اگر دربند درمانند درمانند",},
new Hafez{ Id= 1619, BeytNo = 1, GhazalNo = 195, Mesra1 = "غلام نرگس مست تو تاجدارانند", Mesra2 = "خراب باده لعل تو هوشيارانند",},
new Hafez{ Id= 1620, BeytNo = 2, GhazalNo = 195, Mesra1 = "تو را صبا و مرا آب ديده شد غماز", Mesra2 = "و گر نه عاشق و معشوق رازدارانند",},
new Hafez{ Id= 1621, BeytNo = 3, GhazalNo = 195, Mesra1 = "ز زير زلف دوتا چون گذر کنی بنگر", Mesra2 = "که از يمين و يسارت چه سوگوارانند",},
new Hafez{ Id= 1622, BeytNo = 4, GhazalNo = 195, Mesra1 = "گذار کن چو صبا بر بنفشه زار و ببين", Mesra2 = "که از تطاول زلفت چه بی‌قرارانند",},
new Hafez{ Id= 1623, BeytNo = 5, GhazalNo = 195, Mesra1 = "نصيب ماست بهشت ای خداشناس برو", Mesra2 = "که مستحق کرامت گناهکارانند",},
new Hafez{ Id= 1624, BeytNo = 6, GhazalNo = 195, Mesra1 = "نه من بر آن گل عارض غزل سرايم و بس", Mesra2 = "که عندليب تو از هر طرف هزارانند",},
new Hafez{ Id= 1625, BeytNo = 7, GhazalNo = 195, Mesra1 = "تو دستگير شو ای خضر پی خجسته که من", Mesra2 = "پياده می‌روم و همرهان سوارانند",},
new Hafez{ Id= 1626, BeytNo = 8, GhazalNo = 195, Mesra1 = "بيا به ميکده و چهره ارغوانی کن", Mesra2 = "مرو به صومعه کان جا سياه کارانند",},
new Hafez{ Id= 1627, BeytNo = 9, GhazalNo = 195, Mesra1 = "خلاص حافظ از آن زلف تابدار مباد", Mesra2 = "که بستگان کمند تو رستگارانند",},
new Hafez{ Id= 1628, BeytNo = 1, GhazalNo = 196, Mesra1 = "آنان که خاک را به نظر کيميا کنند", Mesra2 = "آيا بود که گوشه چشمی به ما کنند",},
new Hafez{ Id= 1629, BeytNo = 2, GhazalNo = 196, Mesra1 = "دردم نهفته به ز طبيبان مدعی", Mesra2 = "باشد که از خزانه غيبم دوا کنند",},
new Hafez{ Id= 1630, BeytNo = 3, GhazalNo = 196, Mesra1 = "معشوق چون نقاب ز رخ در نمی‌کشد", Mesra2 = "هر کس حکايتی به تصور چرا کنند",},
new Hafez{ Id= 1631, BeytNo = 4, GhazalNo = 196, Mesra1 = "چون حسن عاقبت نه به رندی و زاهديست", Mesra2 = "آن به که کار خود به عنايت رها کنند",},
new Hafez{ Id= 1632, BeytNo = 5, GhazalNo = 196, Mesra1 = "بی معرفت مباش که در من يزيد عشق", Mesra2 = "اهل نظر معامله با آشنا کنند",},
new Hafez{ Id= 1633, BeytNo = 6, GhazalNo = 196, Mesra1 = "حالی درون پرده بسی فتنه می‌رود", Mesra2 = "تا آن زمان که پرده برافتد چه‌ها کنند",},
new Hafez{ Id= 1634, BeytNo = 7, GhazalNo = 196, Mesra1 = "گر سنگ از اين حديث بنالد عجب مدار", Mesra2 = "صاحب دلان حکايت دل خوش ادا کنند",},
new Hafez{ Id= 1635, BeytNo = 8, GhazalNo = 196, Mesra1 = "می خور که صد گناه ز اغيار در حجاب", Mesra2 = "بهتر ز طاعتی که به روی و ريا کنند",},
new Hafez{ Id= 1636, BeytNo = 9, GhazalNo = 196, Mesra1 = "پيراهنی که آيد از او بوی يوسفم", Mesra2 = "ترسم برادران غيورش قبا کنند",},
new Hafez{ Id= 1637, BeytNo = 10, GhazalNo = 196, Mesra1 = "بگذر به کوی ميکده تا زمره حضور", Mesra2 = "اوقات خود ز بهر تو صرف دعا کنند",},
new Hafez{ Id= 1638, BeytNo = 11, GhazalNo = 196, Mesra1 = "پنهان ز حاسدان به خودم خوان که منعمان", Mesra2 = "خير نهان برای رضای خدا کنند",},
new Hafez{ Id= 1639, BeytNo = 12, GhazalNo = 196, Mesra1 = "حافظ دوام وصل ميسر نمی‌شود", Mesra2 = "شاهان کم التفات به حال گدا کنند",},
new Hafez{ Id= 1640, BeytNo = 1, GhazalNo = 197, Mesra1 = "شاهدان گر دلبری زين سان کنند", Mesra2 = "زاهدان را رخنه در ايمان کنند",},
new Hafez{ Id= 1641, BeytNo = 2, GhazalNo = 197, Mesra1 = "هر کجا آن شاخ نرگس بشکفد", Mesra2 = "گلرخانش ديده نرگسدان کنند",},
new Hafez{ Id= 1642, BeytNo = 3, GhazalNo = 197, Mesra1 = "ای جوان سروقد گويی ببر", Mesra2 = "پيش از آن کز قامتت چوگان کنند",},
new Hafez{ Id= 1643, BeytNo = 4, GhazalNo = 197, Mesra1 = "عاشقان را بر سر خود حکم نيست", Mesra2 = "هر چه فرمان تو باشد آن کنند",},
new Hafez{ Id= 1644, BeytNo = 5, GhazalNo = 197, Mesra1 = "پيش چشمم کمتر است از قطره‌ای", Mesra2 = "اين حکايت‌ها که از طوفان کنند",},
new Hafez{ Id= 1645, BeytNo = 6, GhazalNo = 197, Mesra1 = "يار ما چون گيرد آغاز سماع", Mesra2 = "قدسيان بر عرش دست افشان کنند",},
new Hafez{ Id= 1646, BeytNo = 7, GhazalNo = 197, Mesra1 = "مردم چشمم به خون آغشته شد", Mesra2 = "در کجا اين ظلم بر انسان کنند",},
new Hafez{ Id= 1647, BeytNo = 8, GhazalNo = 197, Mesra1 = "خوش برآ با غصه‌ای دل کاهل راز", Mesra2 = "عيش خوش در بوته هجران کنند",},
new Hafez{ Id= 1648, BeytNo = 9, GhazalNo = 197, Mesra1 = "سر مکش حافظ ز آه نيم شب", Mesra2 = "تا چو صبحت آينه رخشان کنند",},
new Hafez{ Id= 1649, BeytNo = 1, GhazalNo = 198, Mesra1 = "گفتم کی ام دهان و لبت کامران کنند", Mesra2 = "گفتا به چشم هر چه تو گويی چنان کنند",},
new Hafez{ Id= 1650, BeytNo = 2, GhazalNo = 198, Mesra1 = "گفتم خراج مصر طلب می‌کند لبت", Mesra2 = "گفتا در اين معامله کمتر زيان کنند",},
new Hafez{ Id= 1651, BeytNo = 3, GhazalNo = 198, Mesra1 = "گفتم به نقطه دهنت خود که برد راه", Mesra2 = "گفت اين حکايتيست که با نکته دان کنند",},
new Hafez{ Id= 1652, BeytNo = 4, GhazalNo = 198, Mesra1 = "گفتم صنم پرست مشو با صمد نشين", Mesra2 = "گفتا به کوی عشق هم اين و هم آن کنند",},
new Hafez{ Id= 1653, BeytNo = 5, GhazalNo = 198, Mesra1 = "گفتم هوای ميکده غم می‌برد ز دل", Mesra2 = "گفتا خوش آن کسان که دلی شادمان کنند",},
new Hafez{ Id= 1654, BeytNo = 6, GhazalNo = 198, Mesra1 = "گفتم شراب و خرقه نه آيين مذهب است", Mesra2 = "گفت اين عمل به مذهب پير مغان کنند",},
new Hafez{ Id= 1655, BeytNo = 7, GhazalNo = 198, Mesra1 = "گفتم ز لعل نوش لبان پير را چه سود", Mesra2 = "گفتا به بوسه شکرينش جوان کنند",},
new Hafez{ Id= 1656, BeytNo = 8, GhazalNo = 198, Mesra1 = "گفتم که خواجه کی به سر حجله می‌رود", Mesra2 = "گفت آن زمان که مشتری و مه قران کنند",},
new Hafez{ Id= 1657, BeytNo = 9, GhazalNo = 198, Mesra1 = "گفتم دعای دولت او ورد حافظ است", Mesra2 = "گفت اين دعا ملايک هفت آسمان کنند",},
new Hafez{ Id= 1658, BeytNo = 1, GhazalNo = 199, Mesra1 = "واعظان کاين جلوه در محراب و منبر می‌کنند", Mesra2 = "چون به خلوت می‌روند آن کار ديگر می‌کنند",},
new Hafez{ Id= 1659, BeytNo = 2, GhazalNo = 199, Mesra1 = "مشکلی دارم ز دانشمند مجلس بازپرس", Mesra2 = "توبه فرمايان چرا خود توبه کمتر می‌کنند",},
new Hafez{ Id= 1660, BeytNo = 3, GhazalNo = 199, Mesra1 = "گوييا باور نمی‌دارند روز داوری", Mesra2 = "کاين همه قلب و دغل در کار داور می‌کنند",},
new Hafez{ Id= 1661, BeytNo = 4, GhazalNo = 199, Mesra1 = "يا رب اين نودولتان را با خر خودشان نشان", Mesra2 = "کاين همه ناز از غلام ترک و استر می‌کنند",},
new Hafez{ Id= 1662, BeytNo = 5, GhazalNo = 199, Mesra1 = "ای گدای خانقه برجه که در دير مغان", Mesra2 = "می‌دهند آبی که دل‌ها را توانگر می‌کنند",},
new Hafez{ Id= 1663, BeytNo = 6, GhazalNo = 199, Mesra1 = "حسن بی‌پايان او چندان که عاشق می‌کشد", Mesra2 = "زمره ديگر به عشق از غيب سر بر می‌کنند",},
new Hafez{ Id= 1664, BeytNo = 7, GhazalNo = 199, Mesra1 = "بر در ميخانه عشق ای ملک تسبيح گوی", Mesra2 = "کاندر آن جا طينت آدم مخمر می‌کنند",},
new Hafez{ Id= 1665, BeytNo = 8, GhazalNo = 199, Mesra1 = "صبحدم از عرش می‌آمد خروشی عقل گفت", Mesra2 = "قدسيان گويی که شعر حافظ از بر می‌کنند",},
new Hafez{ Id= 1666, BeytNo = 1, GhazalNo = 200, Mesra1 = "دانی که چنگ و عود چه تقرير می‌کنند", Mesra2 = "پنهان خوريد باده که تعزير می‌کنند",},
new Hafez{ Id= 1667, BeytNo = 2, GhazalNo = 200, Mesra1 = "ناموس عشق و رونق عشاق می‌برند", Mesra2 = "عيب جوان و سرزنش پير می‌کنند",},
new Hafez{ Id= 1668, BeytNo = 3, GhazalNo = 200, Mesra1 = "جز قلب تيره هيچ نشد حاصل و هنوز", Mesra2 = "باطل در اين خيال که اکسير می‌کنند",},
new Hafez{ Id= 1669, BeytNo = 4, GhazalNo = 200, Mesra1 = "گويند رمز عشق مگوييد و مشنويد", Mesra2 = "مشکل حکايتيست که تقرير می‌کنند",},
new Hafez{ Id= 1670, BeytNo = 5, GhazalNo = 200, Mesra1 = "ما از برون در شده مغرور صد فريب", Mesra2 = "تا خود درون پرده چه تدبير می‌کنند",},
new Hafez{ Id= 1671, BeytNo = 6, GhazalNo = 200, Mesra1 = "تشويش وقت پير مغان می‌دهند باز", Mesra2 = "اين سالکان نگر که چه با پير می‌کنند",},
new Hafez{ Id= 1672, BeytNo = 7, GhazalNo = 200, Mesra1 = "صد ملک دل به نيم نظر می‌توان خريد", Mesra2 = "خوبان در اين معامله تقصير می‌کنند",},
new Hafez{ Id= 1673, BeytNo = 8, GhazalNo = 200, Mesra1 = "قومی به جد و جهد نهادند وصل دوست", Mesra2 = "قومی دگر حواله به تقدير می‌کنند",},
new Hafez{ Id= 1674, BeytNo = 9, GhazalNo = 200, Mesra1 = "فی الجمله اعتماد مکن بر ثبات دهر", Mesra2 = "کاين کارخانه‌ايست که تغيير می‌کنند",},
new Hafez{ Id= 1675, BeytNo = 10, GhazalNo = 200, Mesra1 = "می خور که شيخ و حافظ و مفتی و محتسب", Mesra2 = "چون نيک بنگری همه تزوير می‌کنند",},
new Hafez{ Id= 1676, BeytNo = 1, GhazalNo = 201, Mesra1 = "شراب بی‌غش و ساقی خوش دو دام رهند", Mesra2 = "که زيرکان جهان از کمندشان نرهند",},
new Hafez{ Id= 1677, BeytNo = 2, GhazalNo = 201, Mesra1 = "من ار چه عاشقم و رند و مست و نامه سياه", Mesra2 = "هزار شکر که ياران شهر بی‌گنهند",},
new Hafez{ Id= 1678, BeytNo = 3, GhazalNo = 201, Mesra1 = "جفا نه پيشه درويشيست و راهروی", Mesra2 = "بيار باده که اين سالکان نه مرد رهند",},
new Hafez{ Id= 1679, BeytNo = 4, GhazalNo = 201, Mesra1 = "مبين حقير گدايان عشق را کاين قوم", Mesra2 = "شهان بی کمر و خسروان بی کلهند",},
new Hafez{ Id= 1680, BeytNo = 5, GhazalNo = 201, Mesra1 = "به هوش باش که هنگام باد استغنا", Mesra2 = "هزار خرمن طاعت به نيم جو ننهند",},
new Hafez{ Id= 1681, BeytNo = 6, GhazalNo = 201, Mesra1 = "مکن که کوکبه دلبری شکسته شود", Mesra2 = "چو بندگان بگريزند و چاکران بجهند",},
new Hafez{ Id= 1682, BeytNo = 7, GhazalNo = 201, Mesra1 = "غلام همت دردی کشان يک رنگم", Mesra2 = "نه آن گروه که ازرق لباس و دل سيهند",},
new Hafez{ Id= 1683, BeytNo = 8, GhazalNo = 201, Mesra1 = "قدم منه به خرابات جز به شرط ادب", Mesra2 = "که سالکان درش محرمان پادشهند",},
new Hafez{ Id= 1684, BeytNo = 9, GhazalNo = 201, Mesra1 = "جناب عشق بلند است همتی حافظ", Mesra2 = "که عاشقان ره بی‌همتان به خود ندهند",},
new Hafez{ Id= 1685, BeytNo = 1, GhazalNo = 202, Mesra1 = "بود آيا که در ميکده‌ها بگشايند", Mesra2 = "گره از کار فروبسته ما بگشايند",},
new Hafez{ Id= 1686, BeytNo = 2, GhazalNo = 202, Mesra1 = "اگر از بهر دل زاهد خودبين بستند", Mesra2 = "دل قوی دار که از بهر خدا بگشايند",},
new Hafez{ Id= 1687, BeytNo = 3, GhazalNo = 202, Mesra1 = "به صفای دل رندان صبوحی زدگان", Mesra2 = "بس در بسته به مفتاح دعا بگشايند",},
new Hafez{ Id= 1688, BeytNo = 4, GhazalNo = 202, Mesra1 = "نامه تعزيت دختر رز بنويسيد", Mesra2 = "تا همه مغبچگان زلف دوتا بگشايند",},
new Hafez{ Id= 1689, BeytNo = 5, GhazalNo = 202, Mesra1 = "گيسوی چنگ ببريد به مرگ می ناب", Mesra2 = "تا حريفان همه خون از مژه‌ها بگشايند",},
new Hafez{ Id= 1690, BeytNo = 6, GhazalNo = 202, Mesra1 = "در ميخانه ببستند خدايا مپسند", Mesra2 = "که در خانه تزوير و ريا بگشايند",},
new Hafez{ Id= 1691, BeytNo = 7, GhazalNo = 202, Mesra1 = "حافظ اين خرقه که داری تو ببينی فردا", Mesra2 = "که چه زنار ز زيرش به دغا بگشايند",},
new Hafez{ Id= 1692, BeytNo = 1, GhazalNo = 203, Mesra1 = "سال‌ها دفتر ما در گرو صهبا بود", Mesra2 = "رونق ميکده از درس و دعای ما بود",},
new Hafez{ Id= 1693, BeytNo = 2, GhazalNo = 203, Mesra1 = "نيکی پير مغان بين که چو ما بدمستان", Mesra2 = "هر چه کرديم به چشم کرمش زيبا بود",},
new Hafez{ Id= 1694, BeytNo = 3, GhazalNo = 203, Mesra1 = "دفتر دانش ما جمله بشوييد به می", Mesra2 = "که فلک ديدم و در قصد دل دانا بود",},
new Hafez{ Id= 1695, BeytNo = 4, GhazalNo = 203, Mesra1 = "از بتان آن طلب ار حسن شناسی ای دل", Mesra2 = "کاين کسی گفت که در علم نظر بينا بود",},
new Hafez{ Id= 1696, BeytNo = 5, GhazalNo = 203, Mesra1 = "دل چو پرگار به هر سو دورانی می‌کرد", Mesra2 = "و اندر آن دايره سرگشته پابرجا بود",},
new Hafez{ Id= 1697, BeytNo = 6, GhazalNo = 203, Mesra1 = "مطرب از درد محبت عملی می‌پرداخت", Mesra2 = "که حکيمان جهان را مژه خون پالا بود",},
new Hafez{ Id= 1698, BeytNo = 7, GhazalNo = 203, Mesra1 = "می‌شکفتم ز طرب زان که چو گل بر لب جوی", Mesra2 = "بر سرم سايه آن سرو سهی بالا بود",},
new Hafez{ Id= 1699, BeytNo = 8, GhazalNo = 203, Mesra1 = "پير گلرنگ من اندر حق ازرق پوشان", Mesra2 = "رخصت خبث نداد ار نه حکايت‌ها بود",},
new Hafez{ Id= 1700, BeytNo = 9, GhazalNo = 203, Mesra1 = "قلب اندوده حافظ بر او خرج نشد", Mesra2 = "کاين معامل به همه عيب نهان بينا بود",},
new Hafez{ Id= 1701, BeytNo = 1, GhazalNo = 204, Mesra1 = "ياد باد آن که نهانت نظری با ما بود", Mesra2 = "رقم مهر تو بر چهره ما پيدا بود",},
new Hafez{ Id= 1702, BeytNo = 2, GhazalNo = 204, Mesra1 = "ياد باد آن که چو چشمت به عتابم می‌کشت", Mesra2 = "معجز عيسويت در لب شکرخا بود",},
new Hafez{ Id= 1703, BeytNo = 3, GhazalNo = 204, Mesra1 = "ياد باد آن که صبوحی زده در مجلس انس", Mesra2 = "جز من و يار نبوديم و خدا با ما بود",},
new Hafez{ Id= 1704, BeytNo = 4, GhazalNo = 204, Mesra1 = "ياد باد آن که رخت شمع طرب می‌افروخت", Mesra2 = "وين دل سوخته پروانه ناپروا بود",},
new Hafez{ Id= 1705, BeytNo = 5, GhazalNo = 204, Mesra1 = "ياد باد آن که در آن بزمگه خلق و ادب", Mesra2 = "آن که او خنده مستانه زدی صهبا بود",},
new Hafez{ Id= 1706, BeytNo = 6, GhazalNo = 204, Mesra1 = "ياد باد آن که چو ياقوت قدح خنده زدی", Mesra2 = "در ميان من و لعل تو حکايت‌ها بود",},
new Hafez{ Id= 1707, BeytNo = 7, GhazalNo = 204, Mesra1 = "ياد باد آن که نگارم چو کمر بربستی", Mesra2 = "در رکابش مه نو پيک جهان پيما بود",},
new Hafez{ Id= 1708, BeytNo = 8, GhazalNo = 204, Mesra1 = "ياد باد آن که خرابات نشين بودم و مست", Mesra2 = "وآنچه در مسجدم امروز کم است آن جا بود",},
new Hafez{ Id= 1709, BeytNo = 9, GhazalNo = 204, Mesra1 = "ياد باد آن که به اصلاح شما می‌شد راست", Mesra2 = "نظم هر گوهر ناسفته که حافظ را بود",},
new Hafez{ Id= 1710, BeytNo = 1, GhazalNo = 205, Mesra1 = "تا ز ميخانه و می نام و نشان خواهد بود", Mesra2 = "سر ما خاک ره پير مغان خواهد بود",},
new Hafez{ Id= 1711, BeytNo = 2, GhazalNo = 205, Mesra1 = "حلقه پير مغان از ازلم در گوش است", Mesra2 = "بر همانيم که بوديم و همان خواهد بود",},
new Hafez{ Id= 1712, BeytNo = 3, GhazalNo = 205, Mesra1 = "بر سر تربت ما چون گذری همت خواه", Mesra2 = "که زيارتگه رندان جهان خواهد بود",},
new Hafez{ Id= 1713, BeytNo = 4, GhazalNo = 205, Mesra1 = "برو ای زاهد خودبين که ز چشم من و تو", Mesra2 = "راز اين پرده نهان است و نهان خواهد بود",},
new Hafez{ Id= 1714, BeytNo = 5, GhazalNo = 205, Mesra1 = "ترک عاشق کش من مست برون رفت امروز", Mesra2 = "تا دگر خون که از ديده روان خواهد بود",},
new Hafez{ Id= 1715, BeytNo = 6, GhazalNo = 205, Mesra1 = "چشمم آن دم که ز شوق تو نهد سر به لحد", Mesra2 = "تا دم صبح قيامت نگران خواهد بود",},
new Hafez{ Id= 1716, BeytNo = 7, GhazalNo = 205, Mesra1 = "بخت حافظ گر از اين گونه مدد خواهد کرد", Mesra2 = "زلف معشوقه به دست دگران خواهد بود",},
new Hafez{ Id= 1717, BeytNo = 1, GhazalNo = 206, Mesra1 = "پيش از اينت بيش از اين انديشه عشاق بود", Mesra2 = "مهرورزی تو با ما شهره آفاق بود",},
new Hafez{ Id= 1718, BeytNo = 2, GhazalNo = 206, Mesra1 = "ياد باد آن صحبت شب‌ها که با نوشين لبان", Mesra2 = "بحث سر عشق و ذکر حلقه عشاق بود",},
new Hafez{ Id= 1719, BeytNo = 3, GhazalNo = 206, Mesra1 = "پيش از اين کاين سقف سبز و طاق مينا برکشند", Mesra2 = "منظر چشم مرا ابروی جانان طاق بود",},
new Hafez{ Id= 1720, BeytNo = 4, GhazalNo = 206, Mesra1 = "از دم صبح ازل تا آخر شام ابد", Mesra2 = "دوستی و مهر بر يک عهد و يک ميثاق بود",},
new Hafez{ Id= 1721, BeytNo = 5, GhazalNo = 206, Mesra1 = "سايه معشوق اگر افتاد بر عاشق چه شد", Mesra2 = "ما به او محتاج بوديم او به ما مشتاق بود",},
new Hafez{ Id= 1722, BeytNo = 6, GhazalNo = 206, Mesra1 = "حسن مه رويان مجلس گر چه دل می‌برد و دين", Mesra2 = "بحث ما در لطف طبع و خوبی اخلاق بود",},
new Hafez{ Id= 1723, BeytNo = 7, GhazalNo = 206, Mesra1 = "بر در شاهم گدايی نکته‌ای در کار کرد", Mesra2 = "گفت بر هر خوان که بنشستم خدا رزاق بود",},
new Hafez{ Id= 1724, BeytNo = 8, GhazalNo = 206, Mesra1 = "رشته تسبيح اگر بگسست معذورم بدار", Mesra2 = "دستم اندر دامن ساقی سيمين ساق بود",},
new Hafez{ Id= 1725, BeytNo = 9, GhazalNo = 206, Mesra1 = "در شب قدر ار صبوحی کرده‌ام عيبم مکن", Mesra2 = "سرخوش آمد يار و جامی بر کنار طاق بود",},
new Hafez{ Id= 1726, BeytNo = 10, GhazalNo = 206, Mesra1 = "شعر حافظ در زمان آدم اندر باغ خلد", Mesra2 = "دفتر نسرين و گل را زينت اوراق بود",},
new Hafez{ Id= 1727, BeytNo = 1, GhazalNo = 207, Mesra1 = "ياد باد آن که سر کوی توام منزل بود", Mesra2 = "ديده را روشنی از خاک درت حاصل بود",},
new Hafez{ Id= 1728, BeytNo = 2, GhazalNo = 207, Mesra1 = "راست چون سوسن و گل از اثر صحبت پاک", Mesra2 = "بر زبان بود مرا آن چه تو را در دل بود",},
new Hafez{ Id= 1729, BeytNo = 3, GhazalNo = 207, Mesra1 = "دل چو از پير خرد نقل معانی می‌کرد", Mesra2 = "عشق می‌گفت به شرح آن چه بر او مشکل بود",},
new Hafez{ Id= 1730, BeytNo = 4, GhazalNo = 207, Mesra1 = "آه از آن جور و تطاول که در اين دامگه است", Mesra2 = "آه از آن سوز و نيازی که در آن محفل بود",},
new Hafez{ Id= 1731, BeytNo = 5, GhazalNo = 207, Mesra1 = "در دلم بود که بی دوست نباشم هرگز", Mesra2 = "چه توان کرد که سعی من و دل باطل بود",},
new Hafez{ Id= 1732, BeytNo = 6, GhazalNo = 207, Mesra1 = "دوش بر ياد حريفان به خرابات شدم", Mesra2 = "خم می ديدم خون در دل و پا در گل بود",},
new Hafez{ Id= 1733, BeytNo = 7, GhazalNo = 207, Mesra1 = "بس بگشتم که بپرسم سبب درد فراق", Mesra2 = "مفتی عقل در اين مسله لايعقل بود",},
new Hafez{ Id= 1734, BeytNo = 8, GhazalNo = 207, Mesra1 = "راستی خاتم فيروزه بواسحاقی", Mesra2 = "خوش درخشيد ولی دولت مستعجل بود",},
new Hafez{ Id= 1735, BeytNo = 9, GhazalNo = 207, Mesra1 = "ديدی آن قهقهه کبک خرامان حافظ", Mesra2 = "که ز سرپنجه شاهين قضا غافل بود",},
new Hafez{ Id= 1736, BeytNo = 1, GhazalNo = 208, Mesra1 = "خستگان را چو طلب باشد و قوت نبود", Mesra2 = "گر تو بيداد کنی شرط مروت نبود",},
new Hafez{ Id= 1737, BeytNo = 2, GhazalNo = 208, Mesra1 = "ما جفا از تو نديديم و تو خود نپسندی", Mesra2 = "آن چه در مذهب ارباب طريقت نبود",},
new Hafez{ Id= 1738, BeytNo = 3, GhazalNo = 208, Mesra1 = "خيره آن ديده که آبش نبرد گريه عشق", Mesra2 = "تيره آن دل که در او شمع محبت نبود",},
new Hafez{ Id= 1739, BeytNo = 4, GhazalNo = 208, Mesra1 = "دولت از مرغ همايون طلب و سايه او", Mesra2 = "زان که با زاغ و زغن شهپر دولت نبود",},
new Hafez{ Id= 1740, BeytNo = 5, GhazalNo = 208, Mesra1 = "گر مدد خواستم از پير مغان عيب مکن", Mesra2 = "شيخ ما گفت که در صومعه همت نبود",},
new Hafez{ Id= 1741, BeytNo = 6, GhazalNo = 208, Mesra1 = "چون طهارت نبود کعبه و بتخانه يکيست", Mesra2 = "نبود خير در آن خانه که عصمت نبود",},
new Hafez{ Id= 1742, BeytNo = 7, GhazalNo = 208, Mesra1 = "حافظا علم و ادب ورز که در مجلس شاه", Mesra2 = "هر که را نيست ادب لايق صحبت نبود",},
new Hafez{ Id= 1743, BeytNo = 1, GhazalNo = 209, Mesra1 = "قتل اين خسته به شمشير تو تقدير نبود", Mesra2 = "ور نه هيچ از دل بی‌رحم تو تقصير نبود",},
new Hafez{ Id= 1744, BeytNo = 2, GhazalNo = 209, Mesra1 = "من ديوانه چو زلف تو رها می‌کردم", Mesra2 = "هيچ لايقترم از حلقه زنجير نبود",},
new Hafez{ Id= 1745, BeytNo = 3, GhazalNo = 209, Mesra1 = "يا رب اين آينه حسن چه جوهر دارد", Mesra2 = "که در او آه مرا قوت تاثير نبود",},
new Hafez{ Id= 1746, BeytNo = 4, GhazalNo = 209, Mesra1 = "سر ز حسرت به در ميکده‌ها برگردم", Mesra2 = "چون شناسای تو در صومعه يک پير نبود",},
new Hafez{ Id= 1747, BeytNo = 5, GhazalNo = 209, Mesra1 = "نازنينتر ز قدت در چمن ناز نرست", Mesra2 = "خوشتر از نقش تو در عالم تصوير نبود",},
new Hafez{ Id= 1748, BeytNo = 6, GhazalNo = 209, Mesra1 = "تا مگر همچو صبا باز به کوی تو رسم", Mesra2 = "حاصلم دوش بجز ناله شبگير نبود",},
new Hafez{ Id= 1749, BeytNo = 7, GhazalNo = 209, Mesra1 = "آن کشيدم ز تو ای آتش هجران که چو شمع", Mesra2 = "جز فنای خودم از دست تو تدبير نبود",},
new Hafez{ Id= 1750, BeytNo = 8, GhazalNo = 209, Mesra1 = "آيتی بود عذاب انده حافظ بی تو", Mesra2 = "که بر هيچ کسش حاجت تفسير نبود",},
new Hafez{ Id= 1751, BeytNo = 1, GhazalNo = 210, Mesra1 = "دوش در حلقه ما قصه گيسوی تو بود", Mesra2 = "تا دل شب سخن از سلسله موی تو بود",},
new Hafez{ Id= 1752, BeytNo = 2, GhazalNo = 210, Mesra1 = "دل که از ناوک مژگان تو در خون می‌گشت", Mesra2 = "باز مشتاق کمانخانه ابروی تو بود",},
new Hafez{ Id= 1753, BeytNo = 3, GhazalNo = 210, Mesra1 = "هم عفاالله صبا کز تو پيامی می‌داد", Mesra2 = "ور نه در کس نرسيديم که از کوی تو بود",},
new Hafez{ Id= 1754, BeytNo = 4, GhazalNo = 210, Mesra1 = "عالم از شور و شر عشق خبر هيچ نداشت", Mesra2 = "فتنه انگيز جهان غمزه جادوی تو بود",},
new Hafez{ Id= 1755, BeytNo = 5, GhazalNo = 210, Mesra1 = "من سرگشته هم از اهل سلامت بودم", Mesra2 = "دام راهم شکن طره هندوی تو بود",},
new Hafez{ Id= 1756, BeytNo = 6, GhazalNo = 210, Mesra1 = "بگشا بند قبا تا بگشايد دل من", Mesra2 = "که گشادی که مرا بود ز پهلوی تو بود",},
new Hafez{ Id= 1757, BeytNo = 7, GhazalNo = 210, Mesra1 = "به وفای تو که بر تربت حافظ بگذر", Mesra2 = "کز جهان می‌شد و در آرزوی روی تو بود",},
new Hafez{ Id= 1758, BeytNo = 1, GhazalNo = 211, Mesra1 = "دوش می‌آمد و رخساره برافروخته بود", Mesra2 = "تا کجا باز دل غمزده‌ای سوخته بود",},
new Hafez{ Id= 1759, BeytNo = 2, GhazalNo = 211, Mesra1 = "رسم عاشق کشی و شيوه شهرآشوبی", Mesra2 = "جامه‌ای بود که بر قامت او دوخته بود",},
new Hafez{ Id= 1760, BeytNo = 3, GhazalNo = 211, Mesra1 = "جان عشاق سپند رخ خود می‌دانست", Mesra2 = "و آتش چهره بدين کار برافروخته بود",},
new Hafez{ Id= 1761, BeytNo = 4, GhazalNo = 211, Mesra1 = "گر چه می‌گفت که زارت بکشم می‌ديدم", Mesra2 = "که نهانش نظری با من دلسوخته بود",},
new Hafez{ Id= 1762, BeytNo = 5, GhazalNo = 211, Mesra1 = "کفر زلفش ره دين می‌زد و آن سنگين دل", Mesra2 = "در پی اش مشعلی از چهره برافروخته بود",},
new Hafez{ Id= 1763, BeytNo = 6, GhazalNo = 211, Mesra1 = "دل بسی خون به کف آورد ولی ديده بريخت", Mesra2 = "الله الله که تلف کرد و که اندوخته بود",},
new Hafez{ Id= 1764, BeytNo = 7, GhazalNo = 211, Mesra1 = "يار مفروش به دنيا که بسی سود نکرد", Mesra2 = "آن که يوسف به زر ناسره بفروخته بود",},
new Hafez{ Id= 1765, BeytNo = 8, GhazalNo = 211, Mesra1 = "گفت و خوش گفت برو خرقه بسوزان حافظ", Mesra2 = "يا رب اين قلب شناسی ز که آموخته بود",},
new Hafez{ Id= 1766, BeytNo = 1, GhazalNo = 212, Mesra1 = "يک دو جامم دی سحرگه اتفاق افتاده بود", Mesra2 = "و از لب ساقی شرابم در مذاق افتاده بود",},
new Hafez{ Id= 1767, BeytNo = 2, GhazalNo = 212, Mesra1 = "از سر مستی دگر با شاهد عهد شباب", Mesra2 = "رجعتی می‌خواستم ليکن طلاق افتاده بود",},
new Hafez{ Id= 1768, BeytNo = 3, GhazalNo = 212, Mesra1 = "در مقامات طريقت هر کجا کرديم سير", Mesra2 = "عافيت را با نظربازی فراق افتاده بود",},
new Hafez{ Id= 1769, BeytNo = 4, GhazalNo = 212, Mesra1 = "ساقيا جام دمادم ده که در سير طريق", Mesra2 = "هر که عاشق وش نيامد در نفاق افتاده بود",},
new Hafez{ Id= 1770, BeytNo = 5, GhazalNo = 212, Mesra1 = "ای معبر مژده‌ای فرما که دوشم آفتاب", Mesra2 = "در شکرخواب صبوحی هم وثاق افتاده بود",},
new Hafez{ Id= 1771, BeytNo = 6, GhazalNo = 212, Mesra1 = "نقش می‌بستم که گيرم گوشه‌ای زان چشم مست", Mesra2 = "طاقت و صبر از خم ابروش طاق افتاده بود",},
new Hafez{ Id= 1772, BeytNo = 7, GhazalNo = 212, Mesra1 = "گر نکردی نصرت دين شاه يحيی از کرم", Mesra2 = "کار ملک و دين ز نظم و اتساق افتاده بود",},
new Hafez{ Id= 1773, BeytNo = 8, GhazalNo = 212, Mesra1 = "حافظ آن ساعت که اين نظم پريشان می‌نوشت", Mesra2 = "طاير فکرش به دام اشتياق افتاده بود",},
new Hafez{ Id= 1774, BeytNo = 1, GhazalNo = 213, Mesra1 = "گوهر مخزن اسرار همان است که بود", Mesra2 = "حقه مهر بدان مهر و نشان است که بود",},
new Hafez{ Id= 1775, BeytNo = 2, GhazalNo = 213, Mesra1 = "عاشقان زمره ارباب امانت باشند", Mesra2 = "لاجرم چشم گهربار همان است که بود",},
new Hafez{ Id= 1776, BeytNo = 3, GhazalNo = 213, Mesra1 = "از صبا پرس که ما را همه شب تا دم صبح", Mesra2 = "بوی زلف تو همان مونس جان است که بود",},
new Hafez{ Id= 1777, BeytNo = 4, GhazalNo = 213, Mesra1 = "طالب لعل و گهر نيست وگرنه خورشيد", Mesra2 = "همچنان در عمل معدن و کان است که بود",},
new Hafez{ Id= 1778, BeytNo = 5, GhazalNo = 213, Mesra1 = "کشته غمزه خود را به زيارت درياب", Mesra2 = "زان که بيچاره همان دل‌نگران است که بود",},
new Hafez{ Id= 1779, BeytNo = 6, GhazalNo = 213, Mesra1 = "رنگ خون دل ما را که نهان می‌داری", Mesra2 = "همچنان در لب لعل تو عيان است که بود",},
new Hafez{ Id= 1780, BeytNo = 7, GhazalNo = 213, Mesra1 = "زلف هندوی تو گفتم که دگر ره نزند", Mesra2 = "سال‌ها رفت و بدان سيرت و سان است که بود",},
new Hafez{ Id= 1781, BeytNo = 8, GhazalNo = 213, Mesra1 = "حافظا بازنما قصه خونابه چشم", Mesra2 = "که بر اين چشمه همان آب روان است که بود",},
new Hafez{ Id= 1782, BeytNo = 1, GhazalNo = 214, Mesra1 = "ديدم به خواب خوش که به دستم پياله بود", Mesra2 = "تعبير رفت و کار به دولت حواله بود",},
new Hafez{ Id= 1783, BeytNo = 2, GhazalNo = 214, Mesra1 = "چهل سال رنج و غصه کشيديم و عاقبت", Mesra2 = "تدبير ما به دست شراب دوساله بود",},
new Hafez{ Id= 1784, BeytNo = 3, GhazalNo = 214, Mesra1 = "آن نافه مراد که می‌خواستم ز بخت", Mesra2 = "در چين زلف آن بت مشکين کلاله بود",},
new Hafez{ Id= 1785, BeytNo = 4, GhazalNo = 214, Mesra1 = "از دست برده بود خمار غمم سحر", Mesra2 = "دولت مساعد آمد و می در پياله بود",},
new Hafez{ Id= 1786, BeytNo = 5, GhazalNo = 214, Mesra1 = "بر آستان ميکده خون می‌خورم مدام", Mesra2 = "روزی ما ز خوان قدر اين نواله بود",},
new Hafez{ Id= 1787, BeytNo = 6, GhazalNo = 214, Mesra1 = "هر کو نکاشت مهر و ز خوبی گلی نچيد", Mesra2 = "در رهگذار باد نگهبان لاله بود",},
new Hafez{ Id= 1788, BeytNo = 7, GhazalNo = 214, Mesra1 = "بر طرف گلشنم گذر افتاد وقت صبح", Mesra2 = "آن دم که کار مرغ سحر آه و ناله بود",},
new Hafez{ Id= 1789, BeytNo = 8, GhazalNo = 214, Mesra1 = "ديديم شعر دلکش حافظ به مدح شاه", Mesra2 = "يک بيت از اين قصيده به از صد رساله بود",},
new Hafez{ Id= 1790, BeytNo = 9, GhazalNo = 214, Mesra1 = "آن شاه تندحمله که خورشيد شيرگير", Mesra2 = "پيشش به روز معرکه کمتر غزاله بود",},
new Hafez{ Id= 1791, BeytNo = 1, GhazalNo = 215, Mesra1 = "به کوی ميکده يا رب سحر چه مشغله بود", Mesra2 = "که جوش شاهد و ساقی و شمع و مشعله بود",},
new Hafez{ Id= 1792, BeytNo = 2, GhazalNo = 215, Mesra1 = "حديث عشق که از حرف و صوت مستغنيست", Mesra2 = "به ناله دف و نی در خروش و ولوله بود",},
new Hafez{ Id= 1793, BeytNo = 3, GhazalNo = 215, Mesra1 = "مباحثی که در آن مجلس جنون می‌رفت", Mesra2 = "ورای مدرسه و قال و قيل مسله بود",},
new Hafez{ Id= 1794, BeytNo = 4, GhazalNo = 215, Mesra1 = "دل از کرشمه ساقی به شکر بود ولی", Mesra2 = "ز نامساعدی بختش اندکی گله بود",},
new Hafez{ Id= 1795, BeytNo = 5, GhazalNo = 215, Mesra1 = "قياس کردم و آن چشم جادوانه مست", Mesra2 = "هزار ساحر چون سامريش در گله بود",},
new Hafez{ Id= 1796, BeytNo = 6, GhazalNo = 215, Mesra1 = "بگفتمش به لبم بوسه‌ای حوالت کن", Mesra2 = "به خنده گفت کی ات با من اين معامله بود",},
new Hafez{ Id= 1797, BeytNo = 7, GhazalNo = 215, Mesra1 = "ز اخترم نظری سعد در ره است که دوش", Mesra2 = "ميان ماه و رخ يار من مقابله بود",},
new Hafez{ Id= 1798, BeytNo = 8, GhazalNo = 215, Mesra1 = "دهان يار که درمان درد حافظ داشت", Mesra2 = "فغان که وقت مروت چه تنگ حوصله بود",},
new Hafez{ Id= 1799, BeytNo = 1, GhazalNo = 216, Mesra1 = "آن يار کز او خانه ما جای پری بود", Mesra2 = "سر تا قدمش چون پری از عيب بری بود",},
new Hafez{ Id= 1800, BeytNo = 2, GhazalNo = 216, Mesra1 = "دل گفت فروکش کنم اين شهر به بويش", Mesra2 = "بيچاره ندانست که يارش سفری بود",},
new Hafez{ Id= 1801, BeytNo = 3, GhazalNo = 216, Mesra1 = "تنها نه ز راز دل من پرده برافتاد", Mesra2 = "تا بود فلک شيوه او پرده دری بود",},
new Hafez{ Id= 1802, BeytNo = 4, GhazalNo = 216, Mesra1 = "منظور خردمند من آن ماه که او را", Mesra2 = "با حسن ادب شيوه صاحب نظری بود",},
new Hafez{ Id= 1803, BeytNo = 5, GhazalNo = 216, Mesra1 = "از چنگ منش اختر بدمهر به دربرد", Mesra2 = "آری چه کنم دولت دور قمری بود",},
new Hafez{ Id= 1804, BeytNo = 6, GhazalNo = 216, Mesra1 = "عذری بنه ای دل که تو درويشی و او را", Mesra2 = "در مملکت حسن سر تاجوری بود",},
new Hafez{ Id= 1805, BeytNo = 7, GhazalNo = 216, Mesra1 = "اوقات خوش آن بود که با دوست به سر رفت", Mesra2 = "باقی همه بی‌حاصلی و بی‌خبری بود",},
new Hafez{ Id= 1806, BeytNo = 8, GhazalNo = 216, Mesra1 = "خوش بود لب آب و گل و سبزه و نسرين", Mesra2 = "افسوس که آن گنج روان رهگذری بود",},
new Hafez{ Id= 1807, BeytNo = 9, GhazalNo = 216, Mesra1 = "خود را بکش ای بلبل از اين رشک که گل را", Mesra2 = "با باد صبا وقت سحر جلوه گری بود",},
new Hafez{ Id= 1808, BeytNo = 10, GhazalNo = 216, Mesra1 = "هر گنج سعادت که خدا داد به حافظ", Mesra2 = "از يمن دعای شب و ورد سحری بود",},
new Hafez{ Id= 1809, BeytNo = 1, GhazalNo = 217, Mesra1 = "مسلمانان مرا وقتی دلی بود", Mesra2 = "که با وی گفتمی گر مشکلی بود",},
new Hafez{ Id= 1810, BeytNo = 2, GhazalNo = 217, Mesra1 = "به گردابی چو می‌افتادم از غم", Mesra2 = "به تدبيرش اميد ساحلی بود",},
new Hafez{ Id= 1811, BeytNo = 3, GhazalNo = 217, Mesra1 = "دلی همدرد و ياری مصلحت بين", Mesra2 = "که استظهار هر اهل دلی بود",},
new Hafez{ Id= 1812, BeytNo = 4, GhazalNo = 217, Mesra1 = "ز من ضايع شد اندر کوی جانان", Mesra2 = "چه دامنگير يا رب منزلی بود",},
new Hafez{ Id= 1813, BeytNo = 5, GhazalNo = 217, Mesra1 = "هنر بی‌عيب حرمان نيست ليکن", Mesra2 = "ز من محرومتر کی سالی بود",},
new Hafez{ Id= 1814, BeytNo = 6, GhazalNo = 217, Mesra1 = "بر اين جان پريشان رحمت آريد", Mesra2 = "که وقتی کاردانی کاملی بود",},
new Hafez{ Id= 1815, BeytNo = 7, GhazalNo = 217, Mesra1 = "مرا تا عشق تعليم سخن کرد", Mesra2 = "حديثم نکته هر محفلی بود",},
new Hafez{ Id= 1816, BeytNo = 8, GhazalNo = 217, Mesra1 = "مگو ديگر که حافظ نکته‌دان است", Mesra2 = "که ما ديديم و محکم جاهلی بود",},
new Hafez{ Id= 1817, BeytNo = 1, GhazalNo = 218, Mesra1 = "در ازل هر کو به فيض دولت ارزانی بود", Mesra2 = "تا ابد جام مرادش همدم جانی بود",},
new Hafez{ Id= 1818, BeytNo = 2, GhazalNo = 218, Mesra1 = "من همان ساعت که از می خواستم شد توبه کار", Mesra2 = "گفتم اين شاخ ار دهد باری پشيمانی بود",},
new Hafez{ Id= 1819, BeytNo = 3, GhazalNo = 218, Mesra1 = "خود گرفتم کافکنم سجاده چون سوسن به دوش", Mesra2 = "همچو گل بر خرقه رنگ می مسلمانی بود",},
new Hafez{ Id= 1820, BeytNo = 4, GhazalNo = 218, Mesra1 = "بی چراغ جام در خلوت نمی‌يارم نشست", Mesra2 = "زان که کنج اهل دل بايد که نورانی بود",},
new Hafez{ Id= 1821, BeytNo = 5, GhazalNo = 218, Mesra1 = "همت عالی طلب جام مرصع گو مباش", Mesra2 = "رند را آب عنب ياقوت رمانی بود",},
new Hafez{ Id= 1822, BeytNo = 6, GhazalNo = 218, Mesra1 = "گر چه بی‌سامان نمايد کار ما سهلش مبين", Mesra2 = "کاندر اين کشور گدايی رشک سلطانی بود",},
new Hafez{ Id= 1823, BeytNo = 7, GhazalNo = 218, Mesra1 = "نيک نامی خواهی ای دل با بدان صحبت مدار", Mesra2 = "خودپسندی جان من برهان نادانی بود",},
new Hafez{ Id= 1824, BeytNo = 8, GhazalNo = 218, Mesra1 = "مجلس انس و بهار و بحث شعر اندر ميان", Mesra2 = "نستدن جام می از جانان گران جانی بود",},
new Hafez{ Id= 1825, BeytNo = 9, GhazalNo = 218, Mesra1 = "دی عزيزی گفت حافظ می‌خورد پنهان شراب", Mesra2 = "ای عزيز من نه عيب آن به که پنهانی بود",},
new Hafez{ Id= 1826, BeytNo = 1, GhazalNo = 219, Mesra1 = "کنون که در چمن آمد گل از عدم به وجود", Mesra2 = "بنفشه در قدم او نهاد سر به سجود",},
new Hafez{ Id= 1827, BeytNo = 2, GhazalNo = 219, Mesra1 = "بنوش جام صبوحی به ناله دف و چنگ", Mesra2 = "ببوس غبغب ساقی به نغمه نی و عود",},
new Hafez{ Id= 1828, BeytNo = 3, GhazalNo = 219, Mesra1 = "به دور گل منشين بی شراب و شاهد و چنگ", Mesra2 = "که همچو روز بقا هفته‌ای بود معدود",},
new Hafez{ Id= 1829, BeytNo = 4, GhazalNo = 219, Mesra1 = "شد از خروج رياحين چو آسمان روشن", Mesra2 = "زمين به اختر ميمون و طالع مسعود",},
new Hafez{ Id= 1830, BeytNo = 5, GhazalNo = 219, Mesra1 = "ز دست شاهد نازک عذار عيسی دم", Mesra2 = "شراب نوش و رها کن حديث عاد و ثمود",},
new Hafez{ Id= 1831, BeytNo = 6, GhazalNo = 219, Mesra1 = "جهان چو خلد برين شد به دور سوسن و گل", Mesra2 = "ولی چه سود که در وی نه ممکن است خلود",},
new Hafez{ Id= 1832, BeytNo = 7, GhazalNo = 219, Mesra1 = "چو گل سوار شود بر هوا سليمان وار", Mesra2 = "سحر که مرغ درآيد به نغمه داوود",},
new Hafez{ Id= 1833, BeytNo = 8, GhazalNo = 219, Mesra1 = "به باغ تازه کن آيين دين زردشتی", Mesra2 = "کنون که لاله برافروخت آتش نمرود",},
new Hafez{ Id= 1834, BeytNo = 9, GhazalNo = 219, Mesra1 = "بخواه جام صبوحی به ياد آصف عهد", Mesra2 = "وزير ملک سليمان عماد دين محمود",},
new Hafez{ Id= 1835, BeytNo = 10, GhazalNo = 219, Mesra1 = "بود که مجلس حافظ به يمن تربيتش", Mesra2 = "هر آن چه می‌طلبد جمله باشدش موجود",},
new Hafez{ Id= 1836, BeytNo = 1, GhazalNo = 220, Mesra1 = "از ديده خون دل همه بر روی ما رود", Mesra2 = "بر روی ما ز ديده چه گويم چه‌ها رود",},
new Hafez{ Id= 1837, BeytNo = 2, GhazalNo = 220, Mesra1 = "ما در درون سينه هوايی نهفته‌ايم", Mesra2 = "بر باد اگر رود دل ما زان هوا رود",},
new Hafez{ Id= 1838, BeytNo = 3, GhazalNo = 220, Mesra1 = "خورشيد خاوری کند از رشک جامه چاک", Mesra2 = "گر ماه مهرپرور من در قبا رود",},
new Hafez{ Id= 1839, BeytNo = 4, GhazalNo = 220, Mesra1 = "بر خاک راه يار نهاديم روی خويش", Mesra2 = "بر روی ما رواست اگر آشنا رود",},
new Hafez{ Id= 1840, BeytNo = 5, GhazalNo = 220, Mesra1 = "سيل است آب ديده و هر کس که بگذرد", Mesra2 = "گر خود دلش ز سنگ بود هم ز جا رود",},
new Hafez{ Id= 1841, BeytNo = 6, GhazalNo = 220, Mesra1 = "ما را به آب ديده شب و روز ماجراست", Mesra2 = "زان رهگذر که بر سر کويش چرا رود",},
new Hafez{ Id= 1842, BeytNo = 7, GhazalNo = 220, Mesra1 = "حافظ به کوی ميکده دايم به صدق دل", Mesra2 = "چون صوفيان صومعه دار از صفا رود",},
new Hafez{ Id= 1843, BeytNo = 1, GhazalNo = 221, Mesra1 = "چو دست بر سر زلفش زنم به تاب رود", Mesra2 = "ور آشتی طلبم با سر عتاب رود",},
new Hafez{ Id= 1844, BeytNo = 2, GhazalNo = 221, Mesra1 = "چو ماه نو ره بيچارگان نظاره", Mesra2 = "زند به گوشه ابرو و در نقاب رود",},
new Hafez{ Id= 1845, BeytNo = 3, GhazalNo = 221, Mesra1 = "شب شراب خرابم کند به بيداری", Mesra2 = "وگر به روز شکايت کنم به خواب رود",},
new Hafez{ Id= 1846, BeytNo = 4, GhazalNo = 221, Mesra1 = "طريق عشق پرآشوب و فتنه است ای دل", Mesra2 = "بيفتد آن که در اين راه با شتاب رود",},
new Hafez{ Id= 1847, BeytNo = 5, GhazalNo = 221, Mesra1 = "گدايی در جانان به سلطنت مفروش", Mesra2 = "کسی ز سايه اين در به آفتاب رود",},
new Hafez{ Id= 1848, BeytNo = 6, GhazalNo = 221, Mesra1 = "سواد نامه موی سياه چون طی شد", Mesra2 = "بياض کم نشود گر صد انتخاب رود",},
new Hafez{ Id= 1849, BeytNo = 7, GhazalNo = 221, Mesra1 = "حباب را چو فتد باد نخوت اندر سر", Mesra2 = "کلاه داريش اندر سر شراب رود",},
new Hafez{ Id= 1850, BeytNo = 8, GhazalNo = 221, Mesra1 = "حجاب راه تويی حافظ از ميان برخيز", Mesra2 = "خوشا کسی که در اين راه بی‌حجاب رود",},
new Hafez{ Id= 1851, BeytNo = 1, GhazalNo = 222, Mesra1 = "از سر کوی تو هر کو به ملالت برود", Mesra2 = "نرود کارش و آخر به خجالت برود",},
new Hafez{ Id= 1852, BeytNo = 2, GhazalNo = 222, Mesra1 = "کاروانی که بود بدرقه‌اش حفظ خدا", Mesra2 = "به تجمل بنشيند به جلالت برود",},
new Hafez{ Id= 1853, BeytNo = 3, GhazalNo = 222, Mesra1 = "سالک از نور هدايت ببرد راه به دوست", Mesra2 = "که به جايی نرسد گر به ضلالت برود",},
new Hafez{ Id= 1854, BeytNo = 4, GhazalNo = 222, Mesra1 = "کام خود آخر عمر از می و معشوق بگير", Mesra2 = "حيف اوقات که يک سر به بطالت برود",},
new Hafez{ Id= 1855, BeytNo = 5, GhazalNo = 222, Mesra1 = "ای دليل دل گمگشته خدا را مددی", Mesra2 = "که غريب ار نبرد ره به دلالت ببرد",},
new Hafez{ Id= 1856, BeytNo = 6, GhazalNo = 222, Mesra1 = "حکم مستوری و مستی همه بر خاتم تست", Mesra2 = "کس ندانست که آخر به چه حالت برود",},
new Hafez{ Id= 1857, BeytNo = 7, GhazalNo = 222, Mesra1 = "حافظ از چشمه حکمت به کف آور جامی", Mesra2 = "بو که از لوح دلت نقش جهالت برود",},
new Hafez{ Id= 1858, BeytNo = 1, GhazalNo = 223, Mesra1 = "هرگزم نقش تو از لوح دل و جان نرود", Mesra2 = "هرگز از ياد من آن سرو خرامان نرود",},
new Hafez{ Id= 1859, BeytNo = 2, GhazalNo = 223, Mesra1 = "از دماغ من سرگشته خيال دهنت", Mesra2 = "به جفای فلک و غصه دوران نرود",},
new Hafez{ Id= 1860, BeytNo = 3, GhazalNo = 223, Mesra1 = "در ازل بست دلم با سر زلفت پيوند", Mesra2 = "تا ابد سر نکشد و از سر پيمان نرود",},
new Hafez{ Id= 1861, BeytNo = 4, GhazalNo = 223, Mesra1 = "هر چه جز بار غمت بر دل مسکين من است", Mesra2 = "برود از دل من و از دل من آن نرود",},
new Hafez{ Id= 1862, BeytNo = 5, GhazalNo = 223, Mesra1 = "آن چنان مهر توام در دل و جان جای گرفت", Mesra2 = "که اگر سر برود از دل و از جان نرود",},
new Hafez{ Id= 1863, BeytNo = 6, GhazalNo = 223, Mesra1 = "گر رود از پی خوبان دل من معذور است", Mesra2 = "درد دارد چه کند کز پی درمان نرود",},
new Hafez{ Id= 1864, BeytNo = 7, GhazalNo = 223, Mesra1 = "هر که خواهد که چو حافظ نشود سرگردان", Mesra2 = "دل به خوبان ندهد و از پی ايشان نرود",},
new Hafez{ Id= 1865, BeytNo = 1, GhazalNo = 224, Mesra1 = "خوشا دلی که مدام از پی نظر نرود", Mesra2 = "به هر درش که بخوانند بی‌خبر نرود",},
new Hafez{ Id= 1866, BeytNo = 2, GhazalNo = 224, Mesra1 = "طمع در آن لب شيرين نکردنم اولی", Mesra2 = "ولی چگونه مگس از پی شکر نرود",},
new Hafez{ Id= 1867, BeytNo = 3, GhazalNo = 224, Mesra1 = "سواد ديده غمديده‌ام به اشک مشوی", Mesra2 = "که نقش خال توام هرگز از نظر نرود",},
new Hafez{ Id= 1868, BeytNo = 4, GhazalNo = 224, Mesra1 = "ز من چو باد صبا بوی خود دريغ مدار", Mesra2 = "چرا که بی سر زلف توام به سر نرود",},
new Hafez{ Id= 1869, BeytNo = 5, GhazalNo = 224, Mesra1 = "دلا مباش چنين هرزه گرد و هرجايی", Mesra2 = "که هيچ کار ز پيشت بدين هنر نرود",},
new Hafez{ Id= 1870, BeytNo = 6, GhazalNo = 224, Mesra1 = "مکن به چشم حقارت نگاه در من مست", Mesra2 = "که آبروی شريعت بدين قدر نرود",},
new Hafez{ Id= 1871, BeytNo = 7, GhazalNo = 224, Mesra1 = "من گدا هوس سروقامتی دارم", Mesra2 = "که دست در کمرش جز به سيم و زر نرود",},
new Hafez{ Id= 1872, BeytNo = 8, GhazalNo = 224, Mesra1 = "تو کز مکارم اخلاق عالمی دگری", Mesra2 = "وفای عهد من از خاطرت به درنرود",},
new Hafez{ Id= 1873, BeytNo = 9, GhazalNo = 224, Mesra1 = "سياه نامه‌تر از خود کسی نمی‌بينم", Mesra2 = "چگونه چون قلمم دود دل به سر نرود",},
new Hafez{ Id= 1874, BeytNo = 10, GhazalNo = 224, Mesra1 = "به تاج هدهدم از ره مبر که باز سفيد", Mesra2 = "چو باشه در پی هر صيد مختصر نرود",},
new Hafez{ Id= 1875, BeytNo = 11, GhazalNo = 224, Mesra1 = "بيار باده و اول به دست حافظ ده", Mesra2 = "به شرط آن که ز مجلس سخن به درنرود",},
new Hafez{ Id= 1876, BeytNo = 1, GhazalNo = 225, Mesra1 = "ساقی حديث سرو و گل و لاله می‌رود", Mesra2 = "وين بحث با ثلاثه غساله می‌رود",},
new Hafez{ Id= 1877, BeytNo = 2, GhazalNo = 225, Mesra1 = "می ده که نوعروس چمن حد حسن يافت", Mesra2 = "کار اين زمان ز صنعت دلاله می‌رود",},
new Hafez{ Id= 1878, BeytNo = 3, GhazalNo = 225, Mesra1 = "شکرشکن شوند همه طوطيان هند", Mesra2 = "زين قند پارسی که به بنگاله می‌رود",},
new Hafez{ Id= 1879, BeytNo = 4, GhazalNo = 225, Mesra1 = "طی مکان ببين و زمان در سلوک شعر", Mesra2 = "کاين طفل يک شبه ره يک ساله می‌رود",},
new Hafez{ Id= 1880, BeytNo = 5, GhazalNo = 225, Mesra1 = "آن چشم جادوانه عابدفريب بين", Mesra2 = "کش کاروان سحر ز دنباله می‌رود",},
new Hafez{ Id= 1881, BeytNo = 6, GhazalNo = 225, Mesra1 = "از ره مرو به عشوه دنيا که اين عجوز", Mesra2 = "مکاره می‌نشيند و محتاله می‌رود",},
new Hafez{ Id= 1882, BeytNo = 7, GhazalNo = 225, Mesra1 = "باد بهار می‌وزد از گلستان شاه", Mesra2 = "و از ژاله باده در قدح لاله می‌رود",},
new Hafez{ Id= 1883, BeytNo = 8, GhazalNo = 225, Mesra1 = "حافظ ز شوق مجلس سلطان غياث دين", Mesra2 = "غافل مشو که کار تو از ناله می‌رود",},
new Hafez{ Id= 1884, BeytNo = 1, GhazalNo = 226, Mesra1 = "ترسم که اشک در غم ما پرده در شود", Mesra2 = "وين راز سر به مهر به عالم سمر شود",},
new Hafez{ Id= 1885, BeytNo = 2, GhazalNo = 226, Mesra1 = "گويند سنگ لعل شود در مقام صبر", Mesra2 = "آری شود وليک به خون جگر شود",},
new Hafez{ Id= 1886, BeytNo = 3, GhazalNo = 226, Mesra1 = "خواهم شدن به ميکده گريان و دادخواه", Mesra2 = "کز دست غم خلاص من آن جا مگر شود",},
new Hafez{ Id= 1887, BeytNo = 4, GhazalNo = 226, Mesra1 = "از هر کرانه تير دعا کرده‌ام روان", Mesra2 = "باشد کز آن ميانه يکی کارگر شود",},
new Hafez{ Id= 1888, BeytNo = 5, GhazalNo = 226, Mesra1 = "ای جان حديث ما بر دلدار بازگو", Mesra2 = "ليکن چنان مگو که صبا را خبر شود",},
new Hafez{ Id= 1889, BeytNo = 6, GhazalNo = 226, Mesra1 = "از کيميای مهر تو زر گشت روی من", Mesra2 = "آری به يمن لطف شما خاک زر شود",},
new Hafez{ Id= 1890, BeytNo = 7, GhazalNo = 226, Mesra1 = "در تنگنای حيرتم از نخوت رقيب", Mesra2 = "يا رب مباد آن که گدا معتبر شود",},
new Hafez{ Id= 1891, BeytNo = 8, GhazalNo = 226, Mesra1 = "بس نکته غير حسن ببايد که تا کسی", Mesra2 = "مقبول طبع مردم صاحب نظر شود",},
new Hafez{ Id= 1892, BeytNo = 9, GhazalNo = 226, Mesra1 = "اين سرکشی که کنگره کاخ وصل راست", Mesra2 = "سرها بر آستانه او خاک در شود",},
new Hafez{ Id= 1893, BeytNo = 10, GhazalNo = 226, Mesra1 = "حافظ چو نافه سر زلفش به دست توست", Mesra2 = "دم درکش ار نه باد صبا را خبر شود",},
new Hafez{ Id= 1894, BeytNo = 1, GhazalNo = 227, Mesra1 = "گر چه بر واعظ شهر اين سخن آسان نشود", Mesra2 = "تا ريا ورزد و سالوس مسلمان نشود",},
new Hafez{ Id= 1895, BeytNo = 2, GhazalNo = 227, Mesra1 = "رندی آموز و کرم کن که نه چندان هنر است", Mesra2 = "حيوانی که ننوشد می و انسان نشود",},
new Hafez{ Id= 1896, BeytNo = 3, GhazalNo = 227, Mesra1 = "گوهر پاک ببايد که شود قابل فيض", Mesra2 = "ور نه هر سنگ و گلی لل و مرجان نشود",},
new Hafez{ Id= 1897, BeytNo = 4, GhazalNo = 227, Mesra1 = "اسم اعظم بکند کار خود ای دل خوش باش", Mesra2 = "که به تلبيس و حيل ديو مسلمان نشود",},
new Hafez{ Id= 1898, BeytNo = 5, GhazalNo = 227, Mesra1 = "عشق می‌ورزم و اميد که اين فن شريف", Mesra2 = "چون هنرهای دگر موجب حرمان نشود",},
new Hafez{ Id= 1899, BeytNo = 6, GhazalNo = 227, Mesra1 = "دوش می‌گفت که فردا بدهم کام دلت", Mesra2 = "سببی ساز خدايا که پشيمان نشود",},
new Hafez{ Id= 1900, BeytNo = 7, GhazalNo = 227, Mesra1 = "حسن خلقی ز خدا می‌طلبم خوی تو را", Mesra2 = "تا دگر خاطر ما از تو پريشان نشود",},
new Hafez{ Id= 1901, BeytNo = 8, GhazalNo = 227, Mesra1 = "ذره را تا نبود همت عالی حافظ", Mesra2 = "طالب چشمه خورشيد درخشان نشود",},
new Hafez{ Id= 1902, BeytNo = 1, GhazalNo = 228, Mesra1 = "گر من از باغ تو يک ميوه بچينم چه شود", Mesra2 = "پيش پايی به چراغ تو ببينم چه شود",},
new Hafez{ Id= 1903, BeytNo = 2, GhazalNo = 228, Mesra1 = "يا رب اندر کنف سايه آن سرو بلند", Mesra2 = "گر من سوخته يک دم بنشينم چه شود",},
new Hafez{ Id= 1904, BeytNo = 3, GhazalNo = 228, Mesra1 = "آخر ای خاتم جمشيد همايون آثار", Mesra2 = "گر فتد عکس تو بر نقش نگينم چه شود",},
new Hafez{ Id= 1905, BeytNo = 4, GhazalNo = 228, Mesra1 = "واعظ شهر چو مهر ملک و شحنه گزيد", Mesra2 = "من اگر مهر نگاری بگزينم چه شود",},
new Hafez{ Id= 1906, BeytNo = 5, GhazalNo = 228, Mesra1 = "عقلم از خانه به دررفت و گر می اين است", Mesra2 = "ديدم از پيش که در خانه دينم چه شود",},
new Hafez{ Id= 1907, BeytNo = 6, GhazalNo = 228, Mesra1 = "صرف شد عمر گران مايه به معشوقه و می", Mesra2 = "تا از آنم چه به پيش آيد از اينم چه شود",},
new Hafez{ Id= 1908, BeytNo = 7, GhazalNo = 228, Mesra1 = "خواجه دانست که من عاشقم و هيچ نگفت", Mesra2 = "حافظ ار نيز بداند که چنينم چه شود",},
new Hafez{ Id= 1909, BeytNo = 1, GhazalNo = 229, Mesra1 = "بخت از دهان دوست نشانم نمی‌دهد", Mesra2 = "دولت خبر ز راز نهانم نمی‌دهد",},
new Hafez{ Id= 1910, BeytNo = 2, GhazalNo = 229, Mesra1 = "از بهر بوسه‌ای ز لبش جان همی‌دهم", Mesra2 = "اينم همی‌ستاند و آنم نمی‌دهد",},
new Hafez{ Id= 1911, BeytNo = 3, GhazalNo = 229, Mesra1 = "مردم در اين فراق و در آن پرده راه نيست", Mesra2 = "يا هست و پرده دار نشانم نمی‌دهد",},
new Hafez{ Id= 1912, BeytNo = 4, GhazalNo = 229, Mesra1 = "زلفش کشيد باد صبا چرخ سفله بين", Mesra2 = "کان جا مجال بادوزانم نمی‌دهد",},
new Hafez{ Id= 1913, BeytNo = 5, GhazalNo = 229, Mesra1 = "چندان که بر کنار چو پرگار می‌شدم", Mesra2 = "دوران چو نقطه ره به ميانم نمی‌دهد",},
new Hafez{ Id= 1914, BeytNo = 6, GhazalNo = 229, Mesra1 = "شکر به صبر دست دهد عاقبت ولی", Mesra2 = "بدعهدی زمانه زمانم نمی‌دهد",},
new Hafez{ Id= 1915, BeytNo = 7, GhazalNo = 229, Mesra1 = "گفتم روم به خواب و ببينم جمال دوست", Mesra2 = "حافظ ز آه و ناله امانم نمی‌دهد",},
new Hafez{ Id= 1916, BeytNo = 1, GhazalNo = 230, Mesra1 = "اگر به باده مشکين دلم کشد شايد", Mesra2 = "که بوی خير ز زهد ريا نمی‌آيد",},
new Hafez{ Id= 1917, BeytNo = 2, GhazalNo = 230, Mesra1 = "جهانيان همه گر منع من کنند از عشق", Mesra2 = "من آن کنم که خداوندگار فرمايد",},
new Hafez{ Id= 1918, BeytNo = 3, GhazalNo = 230, Mesra1 = "طمع ز فيض کرامت مبر که خلق کريم", Mesra2 = "گنه ببخشد و بر عاشقان ببخشايد",},
new Hafez{ Id= 1919, BeytNo = 4, GhazalNo = 230, Mesra1 = "مقيم حلقه ذکر است دل بدان اميد", Mesra2 = "که حلقه‌ای ز سر زلف يار بگشايد",},
new Hafez{ Id= 1920, BeytNo = 5, GhazalNo = 230, Mesra1 = "تو را که حسن خداداده هست و حجله بخت", Mesra2 = "چه حاجت است که مشاطه‌ات بيارايد",},
new Hafez{ Id= 1921, BeytNo = 6, GhazalNo = 230, Mesra1 = "چمن خوش است و هوا دلکش است و می بی‌غش", Mesra2 = "کنون بجز دل خوش هيچ در نمی‌بايد",},
new Hafez{ Id= 1922, BeytNo = 7, GhazalNo = 230, Mesra1 = "جميله‌ايست عروس جهان ولی هش دار", Mesra2 = "که اين مخدره در عقد کس نمی‌آيد",},
new Hafez{ Id= 1923, BeytNo = 8, GhazalNo = 230, Mesra1 = "به لابه گفتمش ای ماه رخ چه باشد اگر", Mesra2 = "به يک شکر ز تو دلخسته‌ای بياسايد",},
new Hafez{ Id= 1924, BeytNo = 9, GhazalNo = 230, Mesra1 = "به خنده گفت که حافظ خدای را مپسند", Mesra2 = "که بوسه تو رخ ماه را بيالايد",},
new Hafez{ Id= 1925, BeytNo = 1, GhazalNo = 231, Mesra1 = "گفتم غم تو دارم گفتا غمت سر آيد", Mesra2 = "گفتم که ماه من شو گفتا اگر برآيد",},
new Hafez{ Id= 1926, BeytNo = 2, GhazalNo = 231, Mesra1 = "گفتم ز مهرورزان رسم وفا بياموز", Mesra2 = "گفتا ز خوبرويان اين کار کمتر آيد",},
new Hafez{ Id= 1927, BeytNo = 3, GhazalNo = 231, Mesra1 = "گفتم که بر خيالت راه نظر ببندم", Mesra2 = "گفتا که شب رو است او از راه ديگر آيد",},
new Hafez{ Id= 1928, BeytNo = 4, GhazalNo = 231, Mesra1 = "گفتم که بوی زلفت گمراه عالمم کرد", Mesra2 = "گفتا اگر بدانی هم اوت رهبر آيد",},
new Hafez{ Id= 1929, BeytNo = 5, GhazalNo = 231, Mesra1 = "گفتم خوشا هوايی کز باد صبح خيزد", Mesra2 = "گفتا خنک نسيمی کز کوی دلبر آيد",},
new Hafez{ Id= 1930, BeytNo = 6, GhazalNo = 231, Mesra1 = "گفتم که نوش لعلت ما را به آرزو کشت", Mesra2 = "گفتا تو بندگی کن کو بنده پرور آيد",},
new Hafez{ Id= 1931, BeytNo = 7, GhazalNo = 231, Mesra1 = "گفتم دل رحيمت کی عزم صلح دارد", Mesra2 = "گفتا مگوی با کس تا وقت آن درآيد",},
new Hafez{ Id= 1932, BeytNo = 8, GhazalNo = 231, Mesra1 = "گفتم زمان عشرت ديدی که چون سر آمد", Mesra2 = "گفتا خموش حافظ کاين غصه هم سر آيد",},
new Hafez{ Id= 1933, BeytNo = 1, GhazalNo = 232, Mesra1 = "بر سر آنم که گر ز دست برآيد", Mesra2 = "دست به کاری زنم که غصه سر آيد",},
new Hafez{ Id= 1934, BeytNo = 2, GhazalNo = 232, Mesra1 = "خلوت دل نيست جای صحبت اضداد", Mesra2 = "ديو چو بيرون رود فرشته درآيد",},
new Hafez{ Id= 1935, BeytNo = 3, GhazalNo = 232, Mesra1 = "صحبت حکام ظلمت شب يلداست", Mesra2 = "نور ز خورشيد جوی بو که برآيد",},
new Hafez{ Id= 1936, BeytNo = 4, GhazalNo = 232, Mesra1 = "بر در ارباب بی‌مروت دنيا", Mesra2 = "چند نشينی که خواجه کی به درآيد",},
new Hafez{ Id= 1937, BeytNo = 5, GhazalNo = 232, Mesra1 = "ترک گدايی مکن که گنج بيابی", Mesra2 = "از نظر ره روی که در گذر آيد",},
new Hafez{ Id= 1938, BeytNo = 6, GhazalNo = 232, Mesra1 = "صالح و طالح متاع خويش نمودند", Mesra2 = "تا که قبول افتد و که در نظر آيد",},
new Hafez{ Id= 1939, BeytNo = 7, GhazalNo = 232, Mesra1 = "بلبل عاشق تو عمر خواه که آخر", Mesra2 = "باغ شود سبز و شاخ گل به بر آيد",},
new Hafez{ Id= 1940, BeytNo = 8, GhazalNo = 232, Mesra1 = "غفلت حافظ در اين سراچه عجب نيست", Mesra2 = "هر که به ميخانه رفت بی‌خبر آيد",},
new Hafez{ Id= 1941, BeytNo = 1, GhazalNo = 233, Mesra1 = "دست از طلب ندارم تا کام من برآيد", Mesra2 = "يا تن رسد به جانان يا جان ز تن برآيد",},
new Hafez{ Id= 1942, BeytNo = 2, GhazalNo = 233, Mesra1 = "بگشای تربتم را بعد از وفات و بنگر", Mesra2 = "کز آتش درونم دود از کفن برآيد",},
new Hafez{ Id= 1943, BeytNo = 3, GhazalNo = 233, Mesra1 = "بنمای رخ که خلقی واله شوند و حيران", Mesra2 = "بگشای لب که فرياد از مرد و زن برآيد",},
new Hafez{ Id= 1944, BeytNo = 4, GhazalNo = 233, Mesra1 = "جان بر لب است و حسرت در دل که از لبانش", Mesra2 = "نگرفته هيچ کامی جان از بدن برآيد",},
new Hafez{ Id= 1945, BeytNo = 5, GhazalNo = 233, Mesra1 = "از حسرت دهانش آمد به تنگ جانم", Mesra2 = "خود کام تنگدستان کی زان دهن برآيد",},
new Hafez{ Id= 1946, BeytNo = 6, GhazalNo = 233, Mesra1 = "گويند ذکر خيرش در خيل عشقبازان", Mesra2 = "هر جا که نام حافظ در انجمن برآيد",},
new Hafez{ Id= 1947, BeytNo = 1, GhazalNo = 234, Mesra1 = "چو آفتاب می از مشرق پياله برآيد", Mesra2 = "ز باغ عارض ساقی هزار لاله برآيد",},
new Hafez{ Id= 1948, BeytNo = 2, GhazalNo = 234, Mesra1 = "نسيم در سر گل بشکند کلاله سنبل", Mesra2 = "چو از ميان چمن بوی آن کلاله برآيد",},
new Hafez{ Id= 1949, BeytNo = 3, GhazalNo = 234, Mesra1 = "حکايت شب هجران نه آن حکايت حاليست", Mesra2 = "که شمه‌ای ز بيانش به صد رساله برآيد",},
new Hafez{ Id= 1950, BeytNo = 4, GhazalNo = 234, Mesra1 = "ز گرد خوان نگون فلک طمع نتوان داشت", Mesra2 = "که بی ملالت صد غصه يک نواله برآيد",},
new Hafez{ Id= 1951, BeytNo = 5, GhazalNo = 234, Mesra1 = "به سعی خود نتوان برد پی به گوهر مقصود", Mesra2 = "خيال باشد کاين کار بی حواله برآيد",},
new Hafez{ Id= 1952, BeytNo = 6, GhazalNo = 234, Mesra1 = "گرت چو نوح نبی صبر هست در غم طوفان", Mesra2 = "بلا بگردد و کام هزارساله برآيد",},
new Hafez{ Id= 1953, BeytNo = 7, GhazalNo = 234, Mesra1 = "نسيم زلف تو چون بگذرد به تربت حافظ", Mesra2 = "ز خاک کالبدش صد هزار لاله برآيد",},
new Hafez{ Id= 1954, BeytNo = 1, GhazalNo = 235, Mesra1 = "زهی خجسته زمانی که يار بازآيد", Mesra2 = "به کام غمزدگان غمگسار بازآيد",},
new Hafez{ Id= 1955, BeytNo = 2, GhazalNo = 235, Mesra1 = "به پيش خيل خيالش کشيدم ابلق چشم", Mesra2 = "بدان اميد که آن شهسوار بازآيد",},
new Hafez{ Id= 1956, BeytNo = 3, GhazalNo = 235, Mesra1 = "اگر نه در خم چوگان او رود سر من", Mesra2 = "ز سر نگويم و سر خود چه کار بازآيد",},
new Hafez{ Id= 1957, BeytNo = 4, GhazalNo = 235, Mesra1 = "مقيم بر سر راهش نشسته‌ام چون گرد", Mesra2 = "بدان هوس که بدين رهگذار بازآيد",},
new Hafez{ Id= 1958, BeytNo = 5, GhazalNo = 235, Mesra1 = "دلی که با سر زلفين او قراری داد", Mesra2 = "گمان مبر که بدان دل قرار بازآيد",},
new Hafez{ Id= 1959, BeytNo = 6, GhazalNo = 235, Mesra1 = "چه جورها که کشيدند بلبلان از دی", Mesra2 = "به بوی آن که دگر نوبهار بازآيد",},
new Hafez{ Id= 1960, BeytNo = 7, GhazalNo = 235, Mesra1 = "ز نقش بند قضا هست اميد آن حافظ", Mesra2 = "که همچو سرو به دستم نگار بازآيد",},
new Hafez{ Id= 1961, BeytNo = 1, GhazalNo = 236, Mesra1 = "اگر آن طاير قدسی ز درم بازآيد", Mesra2 = "عمر بگذشته به پيرانه سرم بازآيد",},
new Hafez{ Id= 1962, BeytNo = 2, GhazalNo = 236, Mesra1 = "دارم اميد بر اين اشک چو باران که دگر", Mesra2 = "برق دولت که برفت از نظرم بازآيد",},
new Hafez{ Id= 1963, BeytNo = 3, GhazalNo = 236, Mesra1 = "آن که تاج سر من خاک کف پايش بود", Mesra2 = "از خدا می‌طلبم تا به سرم بازآيد",},
new Hafez{ Id= 1964, BeytNo = 4, GhazalNo = 236, Mesra1 = "خواهم اندر عقبش رفت به ياران عزيز", Mesra2 = "شخصم ار بازنيايد خبرم بازآيد",},
new Hafez{ Id= 1965, BeytNo = 5, GhazalNo = 236, Mesra1 = "گر نثار قدم يار گرامی نکنم", Mesra2 = "گوهر جان به چه کار دگرم بازآيد",},
new Hafez{ Id= 1966, BeytNo = 6, GhazalNo = 236, Mesra1 = "کوس نودولتی از بام سعادت بزنم", Mesra2 = "گر ببينم که مه نوسفرم بازآيد",},
new Hafez{ Id= 1967, BeytNo = 7, GhazalNo = 236, Mesra1 = "مانعش غلغل چنگ است و شکرخواب صبوح", Mesra2 = "ور نه گر بشنود آه سحرم بازآيد",},
new Hafez{ Id= 1968, BeytNo = 8, GhazalNo = 236, Mesra1 = "آرزومند رخ شاه چو ماهم حافظ", Mesra2 = "همتی تا به سلامت ز درم بازآيد",},
new Hafez{ Id= 1969, BeytNo = 1, GhazalNo = 237, Mesra1 = "نفس برآمد و کام از تو بر نمی‌آيد", Mesra2 = "فغان که بخت من از خواب در نمی‌آيد",},
new Hafez{ Id= 1970, BeytNo = 2, GhazalNo = 237, Mesra1 = "صبا به چشم من انداخت خاکی از کويش", Mesra2 = "که آب زندگيم در نظر نمی‌آيد",},
new Hafez{ Id= 1971, BeytNo = 3, GhazalNo = 237, Mesra1 = "قد بلند تو را تا به بر نمی‌گيرم", Mesra2 = "درخت کام و مرادم به بر نمی‌آيد",},
new Hafez{ Id= 1972, BeytNo = 4, GhazalNo = 237, Mesra1 = "مگر به روی دلارای يار ما ور نی", Mesra2 = "به هيچ وجه دگر کار بر نمی‌آيد",},
new Hafez{ Id= 1973, BeytNo = 5, GhazalNo = 237, Mesra1 = "مقيم زلف تو شد دل که خوش سوادی ديد", Mesra2 = "وز آن غريب بلاکش خبر نمی‌آيد",},
new Hafez{ Id= 1974, BeytNo = 6, GhazalNo = 237, Mesra1 = "ز شست صدق گشادم هزار تير دعا", Mesra2 = "ولی چه سود يکی کارگر نمی‌آيد",},
new Hafez{ Id= 1975, BeytNo = 7, GhazalNo = 237, Mesra1 = "بسم حکايت دل هست با نسيم سحر", Mesra2 = "ولی به بخت من امشب سحر نمی‌آيد",},
new Hafez{ Id= 1976, BeytNo = 8, GhazalNo = 237, Mesra1 = "در اين خيال به سر شد زمان عمر و هنوز", Mesra2 = "بلای زلف سياهت به سر نمی‌آيد",},
new Hafez{ Id= 1977, BeytNo = 9, GhazalNo = 237, Mesra1 = "ز بس که شد دل حافظ رميده از همه کس", Mesra2 = "کنون ز حلقه زلفت به در نمی‌آيد",},
new Hafez{ Id= 1978, BeytNo = 1, GhazalNo = 238, Mesra1 = "جهان بر ابروی عيد از هلال وسمه کشيد", Mesra2 = "هلال عيد در ابروی يار بايد ديد",},
new Hafez{ Id= 1979, BeytNo = 2, GhazalNo = 238, Mesra1 = "شکسته گشت چو پشت هلال قامت من", Mesra2 = "کمان ابروی يارم چو وسمه بازکشيد",},
new Hafez{ Id= 1980, BeytNo = 3, GhazalNo = 238, Mesra1 = "مگر نسيم خطت صبح در چمن بگذشت", Mesra2 = "که گل به بوی تو بر تن چو صبح جامه دريد",},
new Hafez{ Id= 1981, BeytNo = 4, GhazalNo = 238, Mesra1 = "نبود چنگ و رباب و نبيد و عود که بود", Mesra2 = "گل وجود من آغشته گلاب و نبيد",},
new Hafez{ Id= 1982, BeytNo = 5, GhazalNo = 238, Mesra1 = "بيا که با تو بگويم غم ملالت دل", Mesra2 = "چرا که بی تو ندارم مجال گفت و شنيد",},
new Hafez{ Id= 1983, BeytNo = 6, GhazalNo = 238, Mesra1 = "بهای وصل تو گر جان بود خريدارم", Mesra2 = "که جنس خوب مبصر به هر چه ديد خريد",},
new Hafez{ Id= 1984, BeytNo = 7, GhazalNo = 238, Mesra1 = "چو ماه روی تو در شام زلف می‌ديدم", Mesra2 = "شبم به روی تو روشن چو روز می‌گرديد",},
new Hafez{ Id= 1985, BeytNo = 8, GhazalNo = 238, Mesra1 = "به لب رسيد مرا جان و برنيامد کام", Mesra2 = "به سر رسيد اميد و طلب به سر نرسيد",},
new Hafez{ Id= 1986, BeytNo = 9, GhazalNo = 238, Mesra1 = "ز شوق روی تو حافظ نوشت حرفی چند", Mesra2 = "بخوان ز نظمش و در گوش کن چو مرواريد",},
new Hafez{ Id= 1987, BeytNo = 1, GhazalNo = 239, Mesra1 = "رسيد مژده که آمد بهار و سبزه دميد", Mesra2 = "وظيفه گر برسد مصرفش گل است و نبيد",},
new Hafez{ Id= 1988, BeytNo = 2, GhazalNo = 239, Mesra1 = "صفير مرغ برآمد بط شراب کجاست", Mesra2 = "فغان فتاد به بلبل نقاب گل که کشيد",},
new Hafez{ Id= 1989, BeytNo = 3, GhazalNo = 239, Mesra1 = "ز ميوه‌های بهشتی چه ذوق دريابد", Mesra2 = "هر آن که سيب زنخدان شاهدی نگزيد",},
new Hafez{ Id= 1990, BeytNo = 4, GhazalNo = 239, Mesra1 = "مکن ز غصه شکايت که در طريق طلب", Mesra2 = "به راحتی نرسيد آن که زحمتی نکشيد",},
new Hafez{ Id= 1991, BeytNo = 5, GhazalNo = 239, Mesra1 = "ز روی ساقی مه وش گلی بچين امروز", Mesra2 = "که گرد عارض بستان خط بنفشه دميد",},
new Hafez{ Id= 1992, BeytNo = 6, GhazalNo = 239, Mesra1 = "چنان کرشمه ساقی دلم ز دست ببرد", Mesra2 = "که با کسی دگرم نيست برگ گفت و شنيد",},
new Hafez{ Id= 1993, BeytNo = 7, GhazalNo = 239, Mesra1 = "من اين مرقع رنگين چو گل بخواهم سوخت", Mesra2 = "که پير باده فروشش به جرعه‌ای نخريد",},
new Hafez{ Id= 1994, BeytNo = 8, GhazalNo = 239, Mesra1 = "بهار می‌گذرد دادگسترا درياب", Mesra2 = "که رفت موسم و حافظ هنوز می‌نچشيد",},
new Hafez{ Id= 1995, BeytNo = 1, GhazalNo = 240, Mesra1 = "ابر آذاری برآمد باد نوروزی وزيد", Mesra2 = "وجه می می‌خواهم و مطرب که می‌گويد رسيد",},
new Hafez{ Id= 1996, BeytNo = 2, GhazalNo = 240, Mesra1 = "شاهدان در جلوه و من شرمسار کيسه‌ام", Mesra2 = "بار عشق و مفلسی صعب است می‌بايد کشيد",},
new Hafez{ Id= 1997, BeytNo = 3, GhazalNo = 240, Mesra1 = "قحط جود است آبروی خود نمی‌بايد فروخت", Mesra2 = "باده و گل از بهای خرقه می‌بايد خريد",},
new Hafez{ Id= 1998, BeytNo = 4, GhazalNo = 240, Mesra1 = "گوييا خواهد گشود از دولتم کاری که دوش", Mesra2 = "من همی‌کردم دعا و صبح صادق می‌دميد",},
new Hafez{ Id= 1999, BeytNo = 5, GhazalNo = 240, Mesra1 = "با لبی و صد هزاران خنده آمد گل به باغ", Mesra2 = "از کريمی گوييا در گوشه‌ای بويی شنيد",},
new Hafez{ Id= 2000, BeytNo = 6, GhazalNo = 240, Mesra1 = "دامنی گر چاک شد در عالم رندی چه باک", Mesra2 = "جامه‌ای در نيک نامی نيز می‌بايد دريد",},
new Hafez{ Id= 2001, BeytNo = 7, GhazalNo = 240, Mesra1 = "اين لطايف کز لب لعل تو من گفتم که گفت", Mesra2 = "وين تطاول کز سر زلف تو من ديدم که ديد",},
new Hafez{ Id= 2002, BeytNo = 8, GhazalNo = 240, Mesra1 = "عدل سلطان گر نپرسد حال مظلومان عشق", Mesra2 = "گوشه گيران را ز آسايش طمع بايد بريد",},
new Hafez{ Id= 2003, BeytNo = 9, GhazalNo = 240, Mesra1 = "تير عاشق کش ندانم بر دل حافظ که زد", Mesra2 = "اين قدر دانم که از شعر ترش خون می‌چکيد",},
new Hafez{ Id= 2004, BeytNo = 1, GhazalNo = 241, Mesra1 = "معاشران ز حريف شبانه ياد آريد", Mesra2 = "حقوق بندگی مخلصانه ياد آريد",},
new Hafez{ Id= 2005, BeytNo = 2, GhazalNo = 241, Mesra1 = "به وقت سرخوشی از آه و ناله عشاق", Mesra2 = "به صوت و نغمه چنگ و چغانه ياد آريد",},
new Hafez{ Id= 2006, BeytNo = 3, GhazalNo = 241, Mesra1 = "چو لطف باده کند جلوه در رخ ساقی", Mesra2 = "ز عاشقان به سرود و ترانه ياد آريد",},
new Hafez{ Id= 2007, BeytNo = 4, GhazalNo = 241, Mesra1 = "چو در ميان مراد آوريد دست اميد", Mesra2 = "ز عهد صحبت ما در ميانه ياد آريد",},
new Hafez{ Id= 2008, BeytNo = 5, GhazalNo = 241, Mesra1 = "سمند دولت اگر چند سرکشيده رود", Mesra2 = "ز همرهان به سر تازيانه ياد آريد",},
new Hafez{ Id= 2009, BeytNo = 6, GhazalNo = 241, Mesra1 = "نمی‌خوريد زمانی غم وفاداران", Mesra2 = "ز بی‌وفايی دور زمانه ياد آريد",},
new Hafez{ Id= 2010, BeytNo = 7, GhazalNo = 241, Mesra1 = "به وجه مرحمت ای ساکنان صدر جلال", Mesra2 = "ز روی حافظ و اين آستانه ياد آريد",},
new Hafez{ Id= 2011, BeytNo = 1, GhazalNo = 242, Mesra1 = "بيا که رايت منصور پادشاه رسيد", Mesra2 = "نويد فتح و بشارت به مهر و ماه رسيد",},
new Hafez{ Id= 2012, BeytNo = 2, GhazalNo = 242, Mesra1 = "جمال بخت ز روی ظفر نقاب انداخت", Mesra2 = "کمال عدل به فرياد دادخواه رسيد",},
new Hafez{ Id= 2013, BeytNo = 3, GhazalNo = 242, Mesra1 = "سپهر دور خوش اکنون کند که ماه آمد", Mesra2 = "جهان به کام دل اکنون رسد که شاه رسيد",},
new Hafez{ Id= 2014, BeytNo = 4, GhazalNo = 242, Mesra1 = "ز قاطعان طريق اين زمان شوند ايمن", Mesra2 = "قوافل دل و دانش که مرد راه رسيد",},
new Hafez{ Id= 2015, BeytNo = 5, GhazalNo = 242, Mesra1 = "عزيز مصر به رغم برادران غيور", Mesra2 = "ز قعر چاه برآمد به اوج ماه رسيد",},
new Hafez{ Id= 2016, BeytNo = 6, GhazalNo = 242, Mesra1 = "کجاست صوفی دجال فعل ملحدشکل", Mesra2 = "بگو بسوز که مهدی دين پناه رسيد",},
new Hafez{ Id= 2017, BeytNo = 7, GhazalNo = 242, Mesra1 = "صبا بگو که چه‌ها بر سرم در اين غم عشق", Mesra2 = "ز آتش دل سوزان و دود آه رسيد",},
new Hafez{ Id= 2018, BeytNo = 8, GhazalNo = 242, Mesra1 = "ز شوق روی تو شاها بدين اسير فراق", Mesra2 = "همان رسيد کز آتش به برگ کاه رسيد",},
new Hafez{ Id= 2019, BeytNo = 9, GhazalNo = 242, Mesra1 = "مرو به خواب که حافظ به بارگاه قبول", Mesra2 = "ز ورد نيم شب و درس صبحگاه رسيد",},
new Hafez{ Id= 2020, BeytNo = 1, GhazalNo = 243, Mesra1 = "بوی خوش تو هر که ز باد صبا شنيد", Mesra2 = "از يار آشنا سخن آشنا شنيد",},
new Hafez{ Id= 2021, BeytNo = 2, GhazalNo = 243, Mesra1 = "ای شاه حسن چشم به حال گدا فکن", Mesra2 = "کاين گوش بس حکايت شاه و گدا شنيد",},
new Hafez{ Id= 2022, BeytNo = 3, GhazalNo = 243, Mesra1 = "خوش می‌کنم به باده مشکين مشام جان", Mesra2 = "کز دلق پوش صومعه بوی ريا شنيد",},
new Hafez{ Id= 2023, BeytNo = 4, GhazalNo = 243, Mesra1 = "سر خدا که عارف سالک به کس نگفت", Mesra2 = "در حيرتم که باده فروش از کجا شنيد",},
new Hafez{ Id= 2024, BeytNo = 5, GhazalNo = 243, Mesra1 = "يا رب کجاست محرم رازی که يک زمان", Mesra2 = "دل شرح آن دهد که چه گفت و چه‌ها شنيد",},
new Hafez{ Id= 2025, BeytNo = 6, GhazalNo = 243, Mesra1 = "اينش سزا نبود دل حق گزار من", Mesra2 = "کز غمگسار خود سخن ناسزا شنيد",},
new Hafez{ Id= 2026, BeytNo = 7, GhazalNo = 243, Mesra1 = "محروم اگر شدم ز سر کوی او چه شد", Mesra2 = "از گلشن زمانه که بوی وفا شنيد",},
new Hafez{ Id= 2027, BeytNo = 8, GhazalNo = 243, Mesra1 = "ساقی بيا که عشق ندا می‌کند بلند", Mesra2 = "کان کس که گفت قصه ما هم ز ما شنيد",},
new Hafez{ Id= 2028, BeytNo = 9, GhazalNo = 243, Mesra1 = "ما باده زير خرقه نه امروز می‌خوريم", Mesra2 = "صد بار پير ميکده اين ماجرا شنيد",},
new Hafez{ Id= 2029, BeytNo = 10, GhazalNo = 243, Mesra1 = "ما می به بانگ چنگ نه امروز می‌کشيم", Mesra2 = "بس دور شد که گنبد چرخ اين صدا شنيد",},
new Hafez{ Id= 2030, BeytNo = 11, GhazalNo = 243, Mesra1 = "پند حکيم محض صواب است و عين خير", Mesra2 = "فرخنده آن کسی که به سمع رضا شنيد",},
new Hafez{ Id= 2031, BeytNo = 12, GhazalNo = 243, Mesra1 = "حافظ وظيفه تو دعا گفتن است و بس", Mesra2 = "دربند آن مباش که نشنيد يا شنيد",},
new Hafez{ Id= 2032, BeytNo = 1, GhazalNo = 244, Mesra1 = "معاشران گره از زلف يار باز کنيد", Mesra2 = "شبی خوش است بدين قصه‌اش دراز کنيد",},
new Hafez{ Id= 2033, BeytNo = 2, GhazalNo = 244, Mesra1 = "حضور خلوت انس است و دوستان جمعند", Mesra2 = "و ان يکاد بخوانيد و در فراز کنيد",},
new Hafez{ Id= 2034, BeytNo = 3, GhazalNo = 244, Mesra1 = "رباب و چنگ به بانگ بلند می‌گويند", Mesra2 = "که گوش هوش به پيغام اهل راز کنيد",},
new Hafez{ Id= 2035, BeytNo = 4, GhazalNo = 244, Mesra1 = "به جان دوست که غم پرده بر شما ندرد", Mesra2 = "گر اعتماد بر الطاف کارساز کنيد",},
new Hafez{ Id= 2036, BeytNo = 5, GhazalNo = 244, Mesra1 = "ميان عاشق و معشوق فرق بسيار است", Mesra2 = "چو يار ناز نمايد شما نياز کنيد",},
new Hafez{ Id= 2037, BeytNo = 6, GhazalNo = 244, Mesra1 = "نخست موعظه پير صحبت اين حرف است", Mesra2 = "که از مصاحب ناجنس احتراز کنيد",},
new Hafez{ Id= 2038, BeytNo = 7, GhazalNo = 244, Mesra1 = "هر آن کسی که در اين حلقه نيست زنده به عشق", Mesra2 = "بر او نمرده به فتوای من نماز کنيد",},
new Hafez{ Id= 2039, BeytNo = 8, GhazalNo = 244, Mesra1 = "وگر طلب کند انعامی از شما حافظ", Mesra2 = "حوالتش به لب يار دلنواز کنيد",},
new Hafez{ Id= 2040, BeytNo = 1, GhazalNo = 245, Mesra1 = "الا ای طوطی گويای اسرار", Mesra2 = "مبادا خاليت شکر ز منقار",},
new Hafez{ Id= 2041, BeytNo = 2, GhazalNo = 245, Mesra1 = "سرت سبز و دلت خوش باد جاويد", Mesra2 = "که خوش نقشی نمودی از خط يار",},
new Hafez{ Id= 2042, BeytNo = 3, GhazalNo = 245, Mesra1 = "سخن سربسته گفتی با حريفان", Mesra2 = "خدا را زين معما پرده بردار",},
new Hafez{ Id= 2043, BeytNo = 4, GhazalNo = 245, Mesra1 = "به روی ما زن از ساغر گلابی", Mesra2 = "که خواب آلوده‌ايم ای بخت بيدار",},
new Hafez{ Id= 2044, BeytNo = 5, GhazalNo = 245, Mesra1 = "چه ره بود اين که زد در پرده مطرب", Mesra2 = "که می‌رقصند با هم مست و هشيار",},
new Hafez{ Id= 2045, BeytNo = 6, GhazalNo = 245, Mesra1 = "از آن افيون که ساقی در می‌افکند", Mesra2 = "حريفان را نه سر ماند نه دستار",},
new Hafez{ Id= 2046, BeytNo = 7, GhazalNo = 245, Mesra1 = "سکندر را نمی‌بخشند آبی", Mesra2 = "به زور و زر ميسر نيست اين کار",},
new Hafez{ Id= 2047, BeytNo = 8, GhazalNo = 245, Mesra1 = "بيا و حال اهل درد بشنو", Mesra2 = "به لفظ اندک و معنی بسيار",},
new Hafez{ Id= 2048, BeytNo = 9, GhazalNo = 245, Mesra1 = "بت چينی عدوی دين و دل‌هاست", Mesra2 = "خداوندا دل و دينم نگه دار",},
new Hafez{ Id= 2049, BeytNo = 10, GhazalNo = 245, Mesra1 = "به مستوران مگو اسرار مستی", Mesra2 = "حديث جان مگو با نقش ديوار",},
new Hafez{ Id= 2050, BeytNo = 11, GhazalNo = 245, Mesra1 = "به يمن دولت منصور شاهی", Mesra2 = "علم شد حافظ اندر نظم اشعار",},
new Hafez{ Id= 2051, BeytNo = 12, GhazalNo = 245, Mesra1 = "خداوندی به جای بندگان کرد", Mesra2 = "خداوندا ز آفاتش نگه دار",},
new Hafez{ Id= 2052, BeytNo = 1, GhazalNo = 246, Mesra1 = "عيد است و آخر گل و ياران در انتظار", Mesra2 = "ساقی به روی شاه ببين ماه و می بيار",},
new Hafez{ Id= 2053, BeytNo = 2, GhazalNo = 246, Mesra1 = "دل برگرفته بودم از ايام گل ولی", Mesra2 = "کاری بکرد همت پاکان روزه دار",},
new Hafez{ Id= 2054, BeytNo = 3, GhazalNo = 246, Mesra1 = "دل در جهان مبند و به مستی سال کن", Mesra2 = "از فيض جام و قصه جمشيد کامگار",},
new Hafez{ Id= 2055, BeytNo = 4, GhazalNo = 246, Mesra1 = "جز نقد جان به دست ندارم شراب کو", Mesra2 = "کان نيز بر کرشمه ساقی کنم نثار",},
new Hafez{ Id= 2056, BeytNo = 5, GhazalNo = 246, Mesra1 = "خوش دولتيست خرم و خوش خسروی کريم", Mesra2 = "يا رب ز چشم زخم زمانش نگاه دار",},
new Hafez{ Id= 2057, BeytNo = 6, GhazalNo = 246, Mesra1 = "می خور به شعر بنده که زيبی دگر دهد", Mesra2 = "جام مرصع تو بدين در شاهوار",},
new Hafez{ Id= 2058, BeytNo = 7, GhazalNo = 246, Mesra1 = "گر فوت شد سحور چه نقصان صبوح هست", Mesra2 = "از می کنند روزه گشا طالبان يار",},
new Hafez{ Id= 2059, BeytNo = 8, GhazalNo = 246, Mesra1 = "زان جا که پرده پوشی عفو کريم توست", Mesra2 = "بر قلب ما ببخش که نقديست کم عيار",},
new Hafez{ Id= 2060, BeytNo = 9, GhazalNo = 246, Mesra1 = "ترسم که روز حشر عنان بر عنان رود", Mesra2 = "تسبيح شيخ و خرقه رند شرابخوار",},
new Hafez{ Id= 2061, BeytNo = 10, GhazalNo = 246, Mesra1 = "حافظ چو رفت روزه و گل نيز می‌رود", Mesra2 = "ناچار باده نوش که از دست رفت کار",},
new Hafez{ Id= 2062, BeytNo = 1, GhazalNo = 247, Mesra1 = "صبا ز منزل جانان گذر دريغ مدار", Mesra2 = "وز او به عاشق بی‌دل خبر دريغ مدار",},
new Hafez{ Id= 2063, BeytNo = 2, GhazalNo = 247, Mesra1 = "به شکر آن که شکفتی به کام بخت ای گل", Mesra2 = "نسيم وصل ز مرغ سحر دريغ مدار",},
new Hafez{ Id= 2064, BeytNo = 3, GhazalNo = 247, Mesra1 = "حريف عشق تو بودم چو ماه نو بودی", Mesra2 = "کنون که ماه تمامی نظر دريغ مدار",},
new Hafez{ Id= 2065, BeytNo = 4, GhazalNo = 247, Mesra1 = "جهان و هر چه در او هست سهل و مختصر است", Mesra2 = "ز اهل معرفت اين مختصر دريغ مدار",},
new Hafez{ Id= 2066, BeytNo = 5, GhazalNo = 247, Mesra1 = "کنون که چشمه قند است لعل نوشينت", Mesra2 = "سخن بگوی و ز طوطی شکر دريغ مدار",},
new Hafez{ Id= 2067, BeytNo = 6, GhazalNo = 247, Mesra1 = "مکارم تو به آفاق می‌برد شاعر", Mesra2 = "از او وظيفه و زاد سفر دريغ مدار",},
new Hafez{ Id= 2068, BeytNo = 7, GhazalNo = 247, Mesra1 = "چو ذکر خير طلب می‌کنی سخن اين است", Mesra2 = "که در بهای سخن سيم و زر دريغ مدار",},
new Hafez{ Id= 2069, BeytNo = 8, GhazalNo = 247, Mesra1 = "غبار غم برود حال خوش شود حافظ", Mesra2 = "تو آب ديده از اين رهگذر دريغ مدار",},
new Hafez{ Id= 2070, BeytNo = 1, GhazalNo = 248, Mesra1 = "ای صبا نکهتی از کوی فلانی به من آر", Mesra2 = "زار و بيمار غمم راحت جانی به من آر",},
new Hafez{ Id= 2071, BeytNo = 2, GhazalNo = 248, Mesra1 = "قلب بی‌حاصل ما را بزن اکسير مراد", Mesra2 = "يعنی از خاک در دوست نشانی به من آر",},
new Hafez{ Id= 2072, BeytNo = 3, GhazalNo = 248, Mesra1 = "در کمينگاه نظر با دل خويشم جنگ است", Mesra2 = "ز ابرو و غمزه او تير و کمانی به من آر",},
new Hafez{ Id= 2073, BeytNo = 4, GhazalNo = 248, Mesra1 = "در غريبی و فراق و غم دل پير شدم", Mesra2 = "ساغر می ز کف تازه جوانی به من آر",},
new Hafez{ Id= 2074, BeytNo = 5, GhazalNo = 248, Mesra1 = "منکران را هم از اين می دو سه ساغر بچشان", Mesra2 = "وگر ايشان نستانند روانی به من آر",},
new Hafez{ Id= 2075, BeytNo = 6, GhazalNo = 248, Mesra1 = "ساقيا عشرت امروز به فردا مفکن", Mesra2 = "يا ز ديوان قضا خط امانی به من آر",},
new Hafez{ Id= 2076, BeytNo = 7, GhazalNo = 248, Mesra1 = "دلم از دست بشد دوش چو حافظ می‌گفت", Mesra2 = "کای صبا نکهتی از کوی فلانی به من آر",},
new Hafez{ Id= 2077, BeytNo = 1, GhazalNo = 249, Mesra1 = "ای صبا نکهتی از خاک ره يار بيار", Mesra2 = "ببر اندوه دل و مژده دلدار بيار",},
new Hafez{ Id= 2078, BeytNo = 2, GhazalNo = 249, Mesra1 = "نکته‌ای روح فزا از دهن دوست بگو", Mesra2 = "نامه‌ای خوش خبر از عالم اسرار بيار",},
new Hafez{ Id= 2079, BeytNo = 3, GhazalNo = 249, Mesra1 = "تا معطر کنم از لطف نسيم تو مشام", Mesra2 = "شمه‌ای از نفحات نفس يار بيار",},
new Hafez{ Id= 2080, BeytNo = 4, GhazalNo = 249, Mesra1 = "به وفای تو که خاک ره آن يار عزيز", Mesra2 = "بی غباری که پديد آيد از اغيار بيار",},
new Hafez{ Id= 2081, BeytNo = 5, GhazalNo = 249, Mesra1 = "گردی از رهگذر دوست به کوری رقيب", Mesra2 = "بهر آسايش اين ديده خونبار بيار",},
new Hafez{ Id= 2082, BeytNo = 6, GhazalNo = 249, Mesra1 = "خامی و ساده دلی شيوه جانبازان نيست", Mesra2 = "خبری از بر آن دلبر عيار بيار",},
new Hafez{ Id= 2083, BeytNo = 7, GhazalNo = 249, Mesra1 = "شکر آن را که تو در عشرتی ای مرغ چمن", Mesra2 = "به اسيران قفس مژده گلزار بيار",},
new Hafez{ Id= 2084, BeytNo = 8, GhazalNo = 249, Mesra1 = "کام جان تلخ شد از صبر که کردم بی دوست", Mesra2 = "عشوه‌ای زان لب شيرين شکربار بيار",},
new Hafez{ Id= 2085, BeytNo = 9, GhazalNo = 249, Mesra1 = "روزگاريست که دل چهره مقصود نديد", Mesra2 = "ساقيا آن قدح آينه کردار بيار",},
new Hafez{ Id= 2086, BeytNo = 10, GhazalNo = 249, Mesra1 = "دلق حافظ به چه ارزد به می‌اش رنگين کن", Mesra2 = "وان گهش مست و خراب از سر بازار بيار",},
new Hafez{ Id= 2087, BeytNo = 1, GhazalNo = 250, Mesra1 = "روی بنمای و وجود خودم از ياد ببر", Mesra2 = "خرمن سوختگان را همه گو باد ببر",},
new Hafez{ Id= 2088, BeytNo = 2, GhazalNo = 250, Mesra1 = "ما چو داديم دل و ديده به طوفان بلا", Mesra2 = "گو بيا سيل غم و خانه ز بنياد ببر",},
new Hafez{ Id= 2089, BeytNo = 3, GhazalNo = 250, Mesra1 = "زلف چون عنبر خامش که ببويد هيهات", Mesra2 = "ای دل خام طمع اين سخن از ياد ببر",},
new Hafez{ Id= 2090, BeytNo = 4, GhazalNo = 250, Mesra1 = "سينه گو شعله آتشکده فارس بکش", Mesra2 = "ديده گو آب رخ دجله بغداد ببر",},
new Hafez{ Id= 2091, BeytNo = 5, GhazalNo = 250, Mesra1 = "دولت پير مغان باد که باقی سهل است", Mesra2 = "ديگری گو برو و نام من از ياد ببر",},
new Hafez{ Id= 2092, BeytNo = 6, GhazalNo = 250, Mesra1 = "سعی نابرده در اين راه به جايی نرسی", Mesra2 = "مزد اگر می‌طلبی طاعت استاد ببر",},
new Hafez{ Id= 2093, BeytNo = 7, GhazalNo = 250, Mesra1 = "روز مرگم نفسی وعده ديدار بده", Mesra2 = "وان گهم تا به لحد فارغ و آزاد ببر",},
new Hafez{ Id= 2094, BeytNo = 8, GhazalNo = 250, Mesra1 = "دوش می‌گفت به مژگان درازت بکشم", Mesra2 = "يا رب از خاطرش انديشه بيداد ببر",},
new Hafez{ Id= 2095, BeytNo = 9, GhazalNo = 250, Mesra1 = "حافظ انديشه کن از نازکی خاطر يار", Mesra2 = "برو از درگهش اين ناله و فرياد ببر",},
new Hafez{ Id= 2096, BeytNo = 1, GhazalNo = 251, Mesra1 = "شب وصل است و طی شد نامه هجر", Mesra2 = "سلام فيه حتی مطلع الفجر",},
new Hafez{ Id= 2097, BeytNo = 2, GhazalNo = 251, Mesra1 = "دلا در عاشقی ثابت قدم باش", Mesra2 = "که در اين ره نباشد کار بی اجر",},
new Hafez{ Id= 2098, BeytNo = 3, GhazalNo = 251, Mesra1 = "من از رندی نخواهم کرد توبه", Mesra2 = "و لو آذيتنی بالهجر و الحجر",},
new Hafez{ Id= 2099, BeytNo = 4, GhazalNo = 251, Mesra1 = "برآی ای صبح روشن دل خدا را", Mesra2 = "که بس تاريک می‌بينم شب هجر",},
new Hafez{ Id= 2100, BeytNo = 5, GhazalNo = 251, Mesra1 = "دلم رفت و نديدم روی دلدار", Mesra2 = "فغان از اين تطاول آه از اين زجر",},
new Hafez{ Id= 2101, BeytNo = 6, GhazalNo = 251, Mesra1 = "وفا خواهی جفاکش باش حافظ", Mesra2 = "فان الربح و الخسران فی التجر",},
new Hafez{ Id= 2102, BeytNo = 1, GhazalNo = 252, Mesra1 = "گر بود عمر به ميخانه رسم بار دگر", Mesra2 = "بجز از خدمت رندان نکنم کار دگر",},
new Hafez{ Id= 2103, BeytNo = 2, GhazalNo = 252, Mesra1 = "خرم آن روز که با ديده گريان بروم", Mesra2 = "تا زنم آب در ميکده يک بار دگر",},
new Hafez{ Id= 2104, BeytNo = 3, GhazalNo = 252, Mesra1 = "معرفت نيست در اين قوم خدا را سببی", Mesra2 = "تا برم گوهر خود را به خريدار دگر",},
new Hafez{ Id= 2105, BeytNo = 4, GhazalNo = 252, Mesra1 = "يار اگر رفت و حق صحبت ديرين نشناخت", Mesra2 = "حاش لله که روم من ز پی يار دگر",},
new Hafez{ Id= 2106, BeytNo = 5, GhazalNo = 252, Mesra1 = "گر مساعد شودم دايره چرخ کبود", Mesra2 = "هم به دست آورمش باز به پرگار دگر",},
new Hafez{ Id= 2107, BeytNo = 6, GhazalNo = 252, Mesra1 = "عافيت می‌طلبد خاطرم ار بگذارند", Mesra2 = "غمزه شوخش و آن طره طرار دگر",},
new Hafez{ Id= 2108, BeytNo = 7, GhazalNo = 252, Mesra1 = "راز سربسته ما بين که به دستان گفتند", Mesra2 = "هر زمان با دف و نی بر سر بازار دگر",},
new Hafez{ Id= 2109, BeytNo = 8, GhazalNo = 252, Mesra1 = "هر دم از درد بنالم که فلک هر ساعت", Mesra2 = "کندم قصد دل ريش به آزار دگر",},
new Hafez{ Id= 2110, BeytNo = 9, GhazalNo = 252, Mesra1 = "بازگويم نه در اين واقعه حافظ تنهاست", Mesra2 = "غرقه گشتند در اين باديه بسيار دگر",},
new Hafez{ Id= 2111, BeytNo = 1, GhazalNo = 253, Mesra1 = "ای خرم از فروغ رخت لاله زار عمر", Mesra2 = "بازآ که ريخت بی گل رويت بهار عمر",},
new Hafez{ Id= 2112, BeytNo = 2, GhazalNo = 253, Mesra1 = "از ديده گر سرشک چو باران چکد رواست", Mesra2 = "کاندر غمت چو برق بشد روزگار عمر",},
new Hafez{ Id= 2113, BeytNo = 3, GhazalNo = 253, Mesra1 = "اين يک دو دم که مهلت ديدار ممکن است", Mesra2 = "درياب کار ما که نه پيداست کار عمر",},
new Hafez{ Id= 2114, BeytNo = 4, GhazalNo = 253, Mesra1 = "تا کی می صبوح و شکرخواب بامداد", Mesra2 = "هشيار گرد هان که گذشت اختيار عمر",},
new Hafez{ Id= 2115, BeytNo = 5, GhazalNo = 253, Mesra1 = "دی در گذار بود و نظر سوی ما نکرد", Mesra2 = "بيچاره دل که هيچ نديد از گذار عمر",},
new Hafez{ Id= 2116, BeytNo = 6, GhazalNo = 253, Mesra1 = "انديشه از محيط فنا نيست هر که را", Mesra2 = "بر نقطه دهان تو باشد مدار عمر",},
new Hafez{ Id= 2117, BeytNo = 7, GhazalNo = 253, Mesra1 = "در هر طرف که ز خيل حوادث کمين‌گهيست", Mesra2 = "زان رو عنان گسسته دواند سوار عمر",},
new Hafez{ Id= 2118, BeytNo = 8, GhazalNo = 253, Mesra1 = "بی عمر زنده‌ام من و اين بس عجب مدار", Mesra2 = "روز فراق را که نهد در شمار عمر",},
new Hafez{ Id= 2119, BeytNo = 9, GhazalNo = 253, Mesra1 = "حافظ سخن بگوی که بر صفحه جهان", Mesra2 = "اين نقش ماند از قلمت يادگار عمر",},
new Hafez{ Id= 2120, BeytNo = 1, GhazalNo = 254, Mesra1 = "ديگر ز شاخ سرو سهی بلبل صبور", Mesra2 = "گلبانگ زد که چشم بد از روی گل به دور",},
new Hafez{ Id= 2121, BeytNo = 2, GhazalNo = 254, Mesra1 = "ای گلبشکر آن که تويی پادشاه حسن", Mesra2 = "با بلبلان بی‌دل شيدا مکن غرور",},
new Hafez{ Id= 2122, BeytNo = 3, GhazalNo = 254, Mesra1 = "از دست غيبت تو شکايت نمی‌کنم", Mesra2 = "تا نيست غيبتی نبود لذت حضور",},
new Hafez{ Id= 2123, BeytNo = 4, GhazalNo = 254, Mesra1 = "گر ديگران به عيش و طرب خرمند و شاد", Mesra2 = "ما را غم نگار بود مايه سرور",},
new Hafez{ Id= 2124, BeytNo = 5, GhazalNo = 254, Mesra1 = "زاهد اگر به حور و قصور است اميدوار", Mesra2 = "ما را شرابخانه قصور است و يار حور",},
new Hafez{ Id= 2125, BeytNo = 6, GhazalNo = 254, Mesra1 = "می خور به بانگ چنگ و مخور غصه ور کسی", Mesra2 = "گويد تو را که باده مخور گو هوالغفور",},
new Hafez{ Id= 2126, BeytNo = 7, GhazalNo = 254, Mesra1 = "حافظ شکايت از غم هجران چه می‌کنی", Mesra2 = "در هجر وصل باشد و در ظلمت است نور",},
new Hafez{ Id= 2127, BeytNo = 1, GhazalNo = 255, Mesra1 = "يوسف گمگشته بازآيد به کنعان غم مخور", Mesra2 = "کلبه احزان شود روزی گلستان غم مخور",},
new Hafez{ Id= 2128, BeytNo = 2, GhazalNo = 255, Mesra1 = "ای دل غمديده حالت به شود دل بد مکن", Mesra2 = "وين سر شوريده بازآيد به سامان غم مخور",},
new Hafez{ Id= 2129, BeytNo = 3, GhazalNo = 255, Mesra1 = "گر بهار عمر باشد باز بر تخت چمن", Mesra2 = "چتر گل در سر کشی ای مرغ خوشخوان غم مخور",},
new Hafez{ Id= 2130, BeytNo = 4, GhazalNo = 255, Mesra1 = "دور گردون گر دو روزی بر مراد ما نرفت", Mesra2 = "دايما يک سان نباشد حال دوران غم مخور",},
new Hafez{ Id= 2131, BeytNo = 5, GhazalNo = 255, Mesra1 = "هان مشو نوميد چون واقف نه‌ای از سر غيب", Mesra2 = "باشد اندر پرده بازی‌های پنهان غم مخور",},
new Hafez{ Id= 2132, BeytNo = 6, GhazalNo = 255, Mesra1 = "ای دل ار سيل فنا بنياد هستی برکند", Mesra2 = "چون تو را نوح است کشتيبان ز طوفان غم مخور",},
new Hafez{ Id= 2133, BeytNo = 7, GhazalNo = 255, Mesra1 = "در بيابان گر به شوق کعبه خواهی زد قدم", Mesra2 = "سرزنش‌ها گر کند خار مغيلان غم مخور",},
new Hafez{ Id= 2134, BeytNo = 8, GhazalNo = 255, Mesra1 = "گر چه منزل بس خطرناک است و مقصد بس بعيد", Mesra2 = "هيچ راهی نيست کان را نيست پايان غم مخور",},
new Hafez{ Id= 2135, BeytNo = 9, GhazalNo = 255, Mesra1 = "حال ما در فرقت جانان و ابرام رقيب", Mesra2 = "جمله می‌داند خدای حال گردان غم مخور",},
new Hafez{ Id= 2136, BeytNo = 10, GhazalNo = 255, Mesra1 = "حافظا در کنج فقر و خلوت شب‌های تار", Mesra2 = "تا بود وردت دعا و درس قرآن غم مخور",},
new Hafez{ Id= 2137, BeytNo = 1, GhazalNo = 256, Mesra1 = "نصيحتی کنمت بشنو و بهانه مگير", Mesra2 = "هر آن چه ناصح مشفق بگويدت بپذير",},
new Hafez{ Id= 2138, BeytNo = 2, GhazalNo = 256, Mesra1 = "ز وصل روی جوانان تمتعی بردار", Mesra2 = "که در کمينگه عمر است مکر عالم پير",},
new Hafez{ Id= 2139, BeytNo = 3, GhazalNo = 256, Mesra1 = "نعيم هر دو جهان پيش عاشقان بجوی", Mesra2 = "که اين متاع قليل است و آن عطای کثير",},
new Hafez{ Id= 2140, BeytNo = 4, GhazalNo = 256, Mesra1 = "معاشری خوش و رودی بساز می‌خواهم", Mesra2 = "که درد خويش بگويم به ناله بم و زير",},
new Hafez{ Id= 2141, BeytNo = 5, GhazalNo = 256, Mesra1 = "بر آن سرم که ننوشم می و گنه نکنم", Mesra2 = "اگر موافق تدبير من شود تقدير",},
new Hafez{ Id= 2142, BeytNo = 6, GhazalNo = 256, Mesra1 = "چو قسمت ازلی بی حضور ما کردند", Mesra2 = "گر اندکی نه به وفق رضاست خرده مگير",},
new Hafez{ Id= 2143, BeytNo = 7, GhazalNo = 256, Mesra1 = "چو لاله در قدحم ريز ساقيا می و مشک", Mesra2 = "که نقش خال نگارم نمی‌رود ز ضمير",},
new Hafez{ Id= 2144, BeytNo = 8, GhazalNo = 256, Mesra1 = "بيار ساغر در خوشاب ای ساقی", Mesra2 = "حسود گو کرم آصفی ببين و بمير",},
new Hafez{ Id= 2145, BeytNo = 9, GhazalNo = 256, Mesra1 = "به عزم توبه نهادم قدح ز کف صد بار", Mesra2 = "ولی کرشمه ساقی نمی‌کند تقصير",},
new Hafez{ Id= 2146, BeytNo = 10, GhazalNo = 256, Mesra1 = "می دوساله و محبوب چارده ساله", Mesra2 = "همين بس است مرا صحبت صغير و کبير",},
new Hafez{ Id= 2147, BeytNo = 11, GhazalNo = 256, Mesra1 = "دل رميده ما را که پيش می‌گيرد", Mesra2 = "خبر دهيد به مجنون خسته از زنجير",},
new Hafez{ Id= 2148, BeytNo = 12, GhazalNo = 256, Mesra1 = "حديث توبه در اين بزمگه مگو حافظ", Mesra2 = "که ساقيان کمان ابرويت زنند به تير",},
new Hafez{ Id= 2149, BeytNo = 1, GhazalNo = 257, Mesra1 = "روی بنما و مرا گو که ز جان دل برگير", Mesra2 = "پيش شمع آتش پروا نه به جان گو درگير",},
new Hafez{ Id= 2150, BeytNo = 2, GhazalNo = 257, Mesra1 = "در لب تشنه ما بين و مدار آب دريغ", Mesra2 = "بر سر کشته خويش آی و ز خاکش برگير",},
new Hafez{ Id= 2151, BeytNo = 3, GhazalNo = 257, Mesra1 = "ترک درويش مگير ار نبود سيم و زرش", Mesra2 = "در غمت سيم شمار اشک و رخش را زر گير",},
new Hafez{ Id= 2152, BeytNo = 4, GhazalNo = 257, Mesra1 = "چنگ بنواز و بساز ار نبود عود چه باک", Mesra2 = "آتشم عشق و دلم عود و تنم مجمر گير",},
new Hafez{ Id= 2153, BeytNo = 5, GhazalNo = 257, Mesra1 = "در سماع آی و ز سر خرقه برانداز و برقص", Mesra2 = "ور نه با گوشه رو و خرقه ما در سر گير",},
new Hafez{ Id= 2154, BeytNo = 6, GhazalNo = 257, Mesra1 = "صوف برکش ز سر و باده صافی درکش", Mesra2 = "سيم درباز و به زر سيمبری در بر گير",},
new Hafez{ Id= 2155, BeytNo = 7, GhazalNo = 257, Mesra1 = "دوست گو يار شو و هر دو جهان دشمن باش", Mesra2 = "بخت گو پشت مکن روی زمين لشکر گير",},
new Hafez{ Id= 2156, BeytNo = 8, GhazalNo = 257, Mesra1 = "ميل رفتن مکن ای دوست دمی با ما باش", Mesra2 = "بر لب جوی طرب جوی و به کف ساغر گير",},
new Hafez{ Id= 2157, BeytNo = 9, GhazalNo = 257, Mesra1 = "رفته گير از برم وز آتش و آب دل و چشم", Mesra2 = "گونه‌ام زرد و لبم خشک و کنارم تر گير",},
new Hafez{ Id= 2158, BeytNo = 10, GhazalNo = 257, Mesra1 = "حافظ آراسته کن بزم و بگو واعظ را", Mesra2 = "که ببين مجلسم و ترک سر منبر گير",},
new Hafez{ Id= 2159, BeytNo = 1, GhazalNo = 258, Mesra1 = "هزار شکر که ديدم به کام خويشت باز", Mesra2 = "ز روی صدق و صفا گشته با دلم دمساز",},
new Hafez{ Id= 2160, BeytNo = 2, GhazalNo = 258, Mesra1 = "روندگان طريقت ره بلا سپرند", Mesra2 = "رفيق عشق چه غم دارد از نشيب و فراز",},
new Hafez{ Id= 2161, BeytNo = 3, GhazalNo = 258, Mesra1 = "غم حبيب نهان به ز گفت و گوی رقيب", Mesra2 = "که نيست سينه ارباب کينه محرم راز",},
new Hafez{ Id= 2162, BeytNo = 4, GhazalNo = 258, Mesra1 = "اگر چه حسن تو از عشق غير مستغنيست", Mesra2 = "من آن نيم که از اين عشقبازی آيم باز",},
new Hafez{ Id= 2163, BeytNo = 5, GhazalNo = 258, Mesra1 = "چه گويمت که ز سوز درون چه می‌بينم", Mesra2 = "ز اشک پرس حکايت که من نيم غماز",},
new Hafez{ Id= 2164, BeytNo = 6, GhazalNo = 258, Mesra1 = "چه فتنه بود که مشاطه قضا انگيخت", Mesra2 = "که کرد نرگس مستش سيه به سرمه ناز",},
new Hafez{ Id= 2165, BeytNo = 7, GhazalNo = 258, Mesra1 = "بدين سپاس که مجلس منور است به دوست", Mesra2 = "گرت چو شمع جفايی رسد بسوز و بساز",},
new Hafez{ Id= 2166, BeytNo = 8, GhazalNo = 258, Mesra1 = "غرض کرشمه حسن است ور نه حاجت نيست", Mesra2 = "جمال دولت محمود را به زلف اياز",},
new Hafez{ Id= 2167, BeytNo = 9, GhazalNo = 258, Mesra1 = "غزل سرايی ناهيد صرفه‌ای نبرد", Mesra2 = "در آن مقام که حافظ برآورد آواز",},
new Hafez{ Id= 2168, BeytNo = 1, GhazalNo = 259, Mesra1 = "منم که ديده به ديدار دوست کردم باز", Mesra2 = "چه شکر گويمت ای کارساز بنده نواز",},
new Hafez{ Id= 2169, BeytNo = 2, GhazalNo = 259, Mesra1 = "نيازمند بلا گو رخ از غبار مشوی", Mesra2 = "که کيميای مراد است خاک کوی نياز",},
new Hafez{ Id= 2170, BeytNo = 3, GhazalNo = 259, Mesra1 = "ز مشکلات طريقت عنان متاب ای دل", Mesra2 = "که مرد راه نينديشد از نشيب و فراز",},
new Hafez{ Id= 2171, BeytNo = 4, GhazalNo = 259, Mesra1 = "طهارت ار نه به خون جگر کند عاشق", Mesra2 = "به قول مفتی عشقش درست نيست نماز",},
new Hafez{ Id= 2172, BeytNo = 5, GhazalNo = 259, Mesra1 = "در اين مقام مجازی بجز پياله مگير", Mesra2 = "در اين سراچه بازيچه غير عشق مباز",},
new Hafez{ Id= 2173, BeytNo = 6, GhazalNo = 259, Mesra1 = "به نيم بوسه دعايی بخر ز اهل دلی", Mesra2 = "که کيد دشمنت از جان و جسم دارد باز",},
new Hafez{ Id= 2174, BeytNo = 7, GhazalNo = 259, Mesra1 = "فکند زمزمه عشق در حجاز و عراق", Mesra2 = "نوای بانگ غزل‌های حافظ از شيراز",},
new Hafez{ Id= 2175, BeytNo = 1, GhazalNo = 260, Mesra1 = "ای سرو ناز حسن که خوش می‌روی به ناز", Mesra2 = "عشاق را به ناز تو هر لحظه صد نياز",},
new Hafez{ Id= 2176, BeytNo = 2, GhazalNo = 260, Mesra1 = "فرخنده باد طلعت خوبت که در ازل", Mesra2 = "ببريده‌اند بر قد سروت قبای ناز",},
new Hafez{ Id= 2177, BeytNo = 3, GhazalNo = 260, Mesra1 = "آن را که بوی عنبر زلف تو آرزوست", Mesra2 = "چون عود گو بر آتش سودا بسوز و ساز",},
new Hafez{ Id= 2178, BeytNo = 4, GhazalNo = 260, Mesra1 = "پروانه را ز شمع بود سوز دل ولی", Mesra2 = "بی شمع عارض تو دلم را بود گداز",},
new Hafez{ Id= 2179, BeytNo = 5, GhazalNo = 260, Mesra1 = "صوفی که بی تو توبه ز می کرده بود دوش", Mesra2 = "بشکست عهد چون در ميخانه ديد باز",},
new Hafez{ Id= 2180, BeytNo = 6, GhazalNo = 260, Mesra1 = "از طعنه رقيب نگردد عيار من", Mesra2 = "چون زر اگر برند مرا در دهان گاز",},
new Hafez{ Id= 2181, BeytNo = 7, GhazalNo = 260, Mesra1 = "دل کز طواف کعبه کويت وقوف يافت", Mesra2 = "از شوق آن حريم ندارد سر حجاز",},
new Hafez{ Id= 2182, BeytNo = 8, GhazalNo = 260, Mesra1 = "هر دم به خون ديده چه حاجت وضو چو نيست", Mesra2 = "بی طاق ابروی تو نماز مرا جواز",},
new Hafez{ Id= 2183, BeytNo = 9, GhazalNo = 260, Mesra1 = "چون باده باز بر سر خم رفت کف زنان", Mesra2 = "حافظ که دوش از لب ساقی شنيد راز",},
new Hafez{ Id= 2184, BeytNo = 1, GhazalNo = 261, Mesra1 = "درآ که در دل خسته توان درآيد باز", Mesra2 = "بيا که در تن مرده روان درآيد باز",},
new Hafez{ Id= 2185, BeytNo = 2, GhazalNo = 261, Mesra1 = "بيا که فرقت تو چشم من چنان در بست", Mesra2 = "که فتح باب وصالت مگر گشايد باز",},
new Hafez{ Id= 2186, BeytNo = 3, GhazalNo = 261, Mesra1 = "غمی که چون سپه زنگ ملک دل بگرفت", Mesra2 = "ز خيل شادی روم رخت زدايد باز",},
new Hafez{ Id= 2187, BeytNo = 4, GhazalNo = 261, Mesra1 = "به پيش آينه دل هر آن چه می‌دارم", Mesra2 = "بجز خيال جمالت نمی‌نمايد باز",},
new Hafez{ Id= 2188, BeytNo = 5, GhazalNo = 261, Mesra1 = "بدان مثل که شب آبستن است روز از تو", Mesra2 = "ستاره می‌شمرم تا که شب چه زايد باز",},
new Hafez{ Id= 2189, BeytNo = 6, GhazalNo = 261, Mesra1 = "بيا که بلبل مطبوع خاطر حافظ", Mesra2 = "به بوی گلبن وصل تو می‌سرايد باز",},
new Hafez{ Id= 2190, BeytNo = 1, GhazalNo = 262, Mesra1 = "حال خونين دلان که گويد باز", Mesra2 = "و از فلک خون خم که جويد باز",},
new Hafez{ Id= 2191, BeytNo = 2, GhazalNo = 262, Mesra1 = "شرمش از چشم می پرستان باد", Mesra2 = "نرگس مست اگر برويد باز",},
new Hafez{ Id= 2192, BeytNo = 3, GhazalNo = 262, Mesra1 = "جز فلاطون خم نشين شراب", Mesra2 = "سر حکمت به ما که گويد باز",},
new Hafez{ Id= 2193, BeytNo = 4, GhazalNo = 262, Mesra1 = "هر که چون لاله کاسه گردان شد", Mesra2 = "زين جفا رخ به خون بشويد باز",},
new Hafez{ Id= 2194, BeytNo = 5, GhazalNo = 262, Mesra1 = "نگشايد دلم چو غنچه اگر", Mesra2 = "ساغری از لبش نبويد باز",},
new Hafez{ Id= 2195, BeytNo = 6, GhazalNo = 262, Mesra1 = "بس که در پرده چنگ گفت سخن", Mesra2 = "ببرش موی تا نمويد باز",},
new Hafez{ Id= 2196, BeytNo = 7, GhazalNo = 262, Mesra1 = "گرد بيت الحرام خم حافظ", Mesra2 = "گر نميرد به سر بپويد باز",},
new Hafez{ Id= 2197, BeytNo = 1, GhazalNo = 263, Mesra1 = "بيا و کشتی ما در شط شراب انداز", Mesra2 = "خروش و ولوله در جان شيخ و شاب انداز",},
new Hafez{ Id= 2198, BeytNo = 2, GhazalNo = 263, Mesra1 = "مرا به کشتی باده درافکن ای ساقی", Mesra2 = "که گفته‌اند نکويی کن و در آب انداز",},
new Hafez{ Id= 2199, BeytNo = 3, GhazalNo = 263, Mesra1 = "ز کوی ميکده برگشته‌ام ز راه خطا", Mesra2 = "مرا دگر ز کرم با ره صواب انداز",},
new Hafez{ Id= 2200, BeytNo = 4, GhazalNo = 263, Mesra1 = "بيار زان می گلرنگ مشک بو جامی", Mesra2 = "شرار رشک و حسد در دل گلاب انداز",},
new Hafez{ Id= 2201, BeytNo = 5, GhazalNo = 263, Mesra1 = "اگر چه مست و خرابم تو نيز لطفی کن", Mesra2 = "نظر بر اين دل سرگشته خراب انداز",},
new Hafez{ Id= 2202, BeytNo = 6, GhazalNo = 263, Mesra1 = "به نيم شب اگرت آفتاب می‌بايد", Mesra2 = "ز روی دختر گلچهر رز نقاب انداز",},
new Hafez{ Id= 2203, BeytNo = 7, GhazalNo = 263, Mesra1 = "مهل که روز وفاتم به خاک بسپارند", Mesra2 = "مرا به ميکده بر در خم شراب انداز",},
new Hafez{ Id= 2204, BeytNo = 8, GhazalNo = 263, Mesra1 = "ز جور چرخ چو حافظ به جان رسيد دلت", Mesra2 = "به سوی ديو محن ناوک شهاب انداز",},
new Hafez{ Id= 2205, BeytNo = 1, GhazalNo = 264, Mesra1 = "خيز و در کاسه زر آب طربناک انداز", Mesra2 = "پيشتر زان که شود کاسه سر خاک انداز",},
new Hafez{ Id= 2206, BeytNo = 2, GhazalNo = 264, Mesra1 = "عاقبت منزل ما وادی خاموشان است", Mesra2 = "حاليا غلغله در گنبد افلاک انداز",},
new Hafez{ Id= 2207, BeytNo = 3, GhazalNo = 264, Mesra1 = "چشم آلوده نظر از رخ جانان دور است", Mesra2 = "بر رخ او نظر از آينه پاک انداز",},
new Hafez{ Id= 2208, BeytNo = 4, GhazalNo = 264, Mesra1 = "به سر سبز تو ای سرو که گر خاک شوم", Mesra2 = "ناز از سر بنه و سايه بر اين خاک انداز",},
new Hafez{ Id= 2209, BeytNo = 5, GhazalNo = 264, Mesra1 = "دل ما را که ز مار سر زلف تو بخست", Mesra2 = "از لب خود به شفاخانه ترياک انداز",},
new Hafez{ Id= 2210, BeytNo = 6, GhazalNo = 264, Mesra1 = "ملک اين مزرعه دانی که ثباتی ندهد", Mesra2 = "آتشی از جگر جام در املاک انداز",},
new Hafez{ Id= 2211, BeytNo = 7, GhazalNo = 264, Mesra1 = "غسل در اشک زدم کاهل طريقت گويند", Mesra2 = "پاک شو اول و پس ديده بر آن پاک انداز",},
new Hafez{ Id= 2212, BeytNo = 8, GhazalNo = 264, Mesra1 = "يا رب آن زاهد خودبين که بجز عيب نديد", Mesra2 = "دود آهيش در آيينه ادراک انداز",},
new Hafez{ Id= 2213, BeytNo = 9, GhazalNo = 264, Mesra1 = "چون گل از نکهت او جامه قبا کن حافظ", Mesra2 = "وين قبا در ره آن قامت چالاک انداز",},
new Hafez{ Id= 2214, BeytNo = 1, GhazalNo = 265, Mesra1 = "برنيامد از تمنای لبت کامم هنوز", Mesra2 = "بر اميد جام لعلت دردی آشامم هنوز",},
new Hafez{ Id= 2215, BeytNo = 2, GhazalNo = 265, Mesra1 = "روز اول رفت دينم در سر زلفين تو", Mesra2 = "تا چه خواهد شد در اين سودا سرانجامم هنوز",},
new Hafez{ Id= 2216, BeytNo = 3, GhazalNo = 265, Mesra1 = "ساقيا يک جرعه‌ای زان آب آتشگون که من", Mesra2 = "در ميان پختگان عشق او خامم هنوز",},
new Hafez{ Id= 2217, BeytNo = 4, GhazalNo = 265, Mesra1 = "از خطا گفتم شبی زلف تو را مشک ختن", Mesra2 = "می‌زند هر لحظه تيغی مو بر اندامم هنوز",},
new Hafez{ Id= 2218, BeytNo = 5, GhazalNo = 265, Mesra1 = "پرتو روی تو تا در خلوتم ديد آفتاب", Mesra2 = "می‌رود چون سايه هر دم بر در و بامم هنوز",},
new Hafez{ Id= 2219, BeytNo = 6, GhazalNo = 265, Mesra1 = "نام من رفته‌ست روزی بر لب جانان به سهو", Mesra2 = "اهل دل را بوی جان می‌آيد از نامم هنوز",},
new Hafez{ Id= 2220, BeytNo = 7, GhazalNo = 265, Mesra1 = "در ازل داده‌ست ما را ساقی لعل لبت", Mesra2 = "جرعه جامی که من مدهوش آن جامم هنوز",},
new Hafez{ Id= 2221, BeytNo = 8, GhazalNo = 265, Mesra1 = "ای که گفتی جان بده تا باشدت آرام جان", Mesra2 = "جان به غم‌هايش سپردم نيست آرامم هنوز",},
new Hafez{ Id= 2222, BeytNo = 9, GhazalNo = 265, Mesra1 = "در قلم آورد حافظ قصه لعل لبش", Mesra2 = "آب حيوان می‌رود هر دم ز اقلامم هنوز",},
new Hafez{ Id= 2223, BeytNo = 1, GhazalNo = 266, Mesra1 = "دلم رميده لولی‌وشيست شورانگيز", Mesra2 = "دروغ وعده و قتال وضع و رنگ آميز",},
new Hafez{ Id= 2224, BeytNo = 2, GhazalNo = 266, Mesra1 = "فدای پيرهن چاک ماه رويان باد", Mesra2 = "هزار جامه تقوا و خرقه پرهيز",},
new Hafez{ Id= 2225, BeytNo = 3, GhazalNo = 266, Mesra1 = "خيال خال تو با خود به خاک خواهم برد", Mesra2 = "که تا ز خال تو خاکم شود عبيرآميز",},
new Hafez{ Id= 2226, BeytNo = 4, GhazalNo = 266, Mesra1 = "فرشته عشق نداند که چيست ای ساقی", Mesra2 = "بخواه جام و گلابی به خاک آدم ريز",},
new Hafez{ Id= 2227, BeytNo = 5, GhazalNo = 266, Mesra1 = "پياله بر کفنم بند تا سحرگه حشر", Mesra2 = "به می ز دل ببرم هول روز رستاخيز",},
new Hafez{ Id= 2228, BeytNo = 6, GhazalNo = 266, Mesra1 = "فقير و خسته به درگاهت آمدم رحمی", Mesra2 = "که جز ولای توام نيست هيچ دست آويز",},
new Hafez{ Id= 2229, BeytNo = 7, GhazalNo = 266, Mesra1 = "بيا که هاتف ميخانه دوش با من گفت", Mesra2 = "که در مقام رضا باش و از قضا مگريز",},
new Hafez{ Id= 2230, BeytNo = 8, GhazalNo = 266, Mesra1 = "ميان عاشق و معشوق هيچ حال نيست", Mesra2 = "تو خود حجاب خودی حافظ از ميان برخيز",},
new Hafez{ Id= 2231, BeytNo = 1, GhazalNo = 267, Mesra1 = "ای صبا گر بگذری بر ساحل رود ارس", Mesra2 = "بوسه زن بر خاک آن وادی و مشکين کن نفس",},
new Hafez{ Id= 2232, BeytNo = 2, GhazalNo = 267, Mesra1 = "منزل سلمی که بادش هر دم از ما صد سلام", Mesra2 = "پرصدای ساربانان بينی و بانگ جرس",},
new Hafez{ Id= 2233, BeytNo = 3, GhazalNo = 267, Mesra1 = "محمل جانان ببوس آن گه به زاری عرضه دار", Mesra2 = "کز فراقت سوختم ای مهربان فرياد رس",},
new Hafez{ Id= 2234, BeytNo = 4, GhazalNo = 267, Mesra1 = "من که قول ناصحان را خواندمی قول رباب", Mesra2 = "گوشمالی ديدم از هجران که اينم پند بس",},
new Hafez{ Id= 2235, BeytNo = 5, GhazalNo = 267, Mesra1 = "عشرت شبگير کن می نوش کاندر راه عشق", Mesra2 = "شب روان را آشنايی‌هاست با مير عسس",},
new Hafez{ Id= 2236, BeytNo = 6, GhazalNo = 267, Mesra1 = "عشقبازی کار بازی نيست ای دل سر بباز", Mesra2 = "زان که گوی عشق نتوان زد به چوگان هوس",},
new Hafez{ Id= 2237, BeytNo = 7, GhazalNo = 267, Mesra1 = "دل به رغبت می‌سپارد جان به چشم مست يار", Mesra2 = "گر چه هشياران ندادند اختيار خود به کس",},
new Hafez{ Id= 2238, BeytNo = 8, GhazalNo = 267, Mesra1 = "طوطيان در شکرستان کامرانی می‌کنند", Mesra2 = "و از تحسر دست بر سر می‌زند مسکين مگس",},
new Hafez{ Id= 2239, BeytNo = 9, GhazalNo = 267, Mesra1 = "نام حافظ گر برآيد بر زبان کلک دوست", Mesra2 = "از جناب حضرت شاهم بس است اين ملتمس",},
new Hafez{ Id= 2240, BeytNo = 1, GhazalNo = 268, Mesra1 = "گلعذاری ز گلستان جهان ما را بس", Mesra2 = "زين چمن سايه آن سرو روان ما را بس",},
new Hafez{ Id= 2241, BeytNo = 2, GhazalNo = 268, Mesra1 = "من و همصحبتی اهل ريا دورم باد", Mesra2 = "از گرانان جهان رطل گران ما را بس",},
new Hafez{ Id= 2242, BeytNo = 3, GhazalNo = 268, Mesra1 = "قصر فردوس به پاداش عمل می‌بخشند", Mesra2 = "ما که رنديم و گدا دير مغان ما را بس",},
new Hafez{ Id= 2243, BeytNo = 4, GhazalNo = 268, Mesra1 = "بنشين بر لب جوی و گذر عمر ببين", Mesra2 = "کاين اشارت ز جهان گذران ما را بس",},
new Hafez{ Id= 2244, BeytNo = 5, GhazalNo = 268, Mesra1 = "نقد بازار جهان بنگر و آزار جهان", Mesra2 = "گر شما را نه بس اين سود و زيان ما را بس",},
new Hafez{ Id= 2245, BeytNo = 6, GhazalNo = 268, Mesra1 = "يار با ماست چه حاجت که زيادت طلبيم", Mesra2 = "دولت صحبت آن مونس جان ما را بس",},
new Hafez{ Id= 2246, BeytNo = 7, GhazalNo = 268, Mesra1 = "از در خويش خدا را به بهشتم مفرست", Mesra2 = "که سر کوی تو از کون و مکان ما را بس",},
new Hafez{ Id= 2247, BeytNo = 8, GhazalNo = 268, Mesra1 = "حافظ از مشرب قسمت گله ناانصافيست", Mesra2 = "طبع چون آب و غزل‌های روان ما را بس",},
new Hafez{ Id= 2248, BeytNo = 1, GhazalNo = 269, Mesra1 = "دلا رفيق سفر بخت نيکخواهت بس", Mesra2 = "نسيم روضه شيراز پيک راهت بس",},
new Hafez{ Id= 2249, BeytNo = 2, GhazalNo = 269, Mesra1 = "دگر ز منزل جانان سفر مکن درويش", Mesra2 = "که سير معنوی و کنج خانقاهت بس",},
new Hafez{ Id= 2250, BeytNo = 3, GhazalNo = 269, Mesra1 = "وگر کمين بگشايد غمی ز گوشه دل", Mesra2 = "حريم درگه پير مغان پناهت بس",},
new Hafez{ Id= 2251, BeytNo = 4, GhazalNo = 269, Mesra1 = "به صدر مصطبه بنشين و ساغر می‌نوش", Mesra2 = "که اين قدر ز جهان کسب مال و جاهت بس",},
new Hafez{ Id= 2252, BeytNo = 5, GhazalNo = 269, Mesra1 = "زيادتی مطلب کار بر خود آسان کن", Mesra2 = "صراحی می لعل و بتی چو ماهت بس",},
new Hafez{ Id= 2253, BeytNo = 6, GhazalNo = 269, Mesra1 = "فلک به مردم نادان دهد زمام مراد", Mesra2 = "تو اهل فضلی و دانش همين گناهت بس",},
new Hafez{ Id= 2254, BeytNo = 7, GhazalNo = 269, Mesra1 = "هوای مسکن ملوف و عهد يار قديم", Mesra2 = "ز ره روان سفرکرده عذرخواهت بس",},
new Hafez{ Id= 2255, BeytNo = 8, GhazalNo = 269, Mesra1 = "به منت دگران خو مکن که در دو جهان", Mesra2 = "رضای ايزد و انعام پادشاهت بس",},
new Hafez{ Id= 2256, BeytNo = 9, GhazalNo = 269, Mesra1 = "به هيچ ورد دگر نيست حاجت ای حافظ", Mesra2 = "دعای نيم شب و درس صبحگاهت بس",},
new Hafez{ Id= 2257, BeytNo = 1, GhazalNo = 270, Mesra1 = "درد عشقی کشيده‌ام که مپرس", Mesra2 = "زهر هجری چشيده‌ام که مپرس",},
new Hafez{ Id= 2258, BeytNo = 2, GhazalNo = 270, Mesra1 = "گشته‌ام در جهان و آخر کار", Mesra2 = "دلبری برگزيده‌ام که مپرس",},
new Hafez{ Id= 2259, BeytNo = 3, GhazalNo = 270, Mesra1 = "آن چنان در هوای خاک درش", Mesra2 = "می‌رود آب ديده‌ام که مپرس",},
new Hafez{ Id= 2260, BeytNo = 4, GhazalNo = 270, Mesra1 = "من به گوش خود از دهانش دوش", Mesra2 = "سخنانی شنيده‌ام که مپرس",},
new Hafez{ Id= 2261, BeytNo = 5, GhazalNo = 270, Mesra1 = "سوی من لب چه می‌گزی که مگوی", Mesra2 = "لب لعلی گزيده‌ام که مپرس",},
new Hafez{ Id= 2262, BeytNo = 6, GhazalNo = 270, Mesra1 = "بی تو در کلبه گدايی خويش", Mesra2 = "رنج‌هايی کشيده‌ام که مپرس",},
new Hafez{ Id= 2263, BeytNo = 7, GhazalNo = 270, Mesra1 = "همچو حافظ غريب در ره عشق", Mesra2 = "به مقامی رسيده‌ام که مپرس",},
new Hafez{ Id= 2264, BeytNo = 1, GhazalNo = 271, Mesra1 = "دارم از زلف سياهش گله چندان که مپرس", Mesra2 = "که چنان ز او شده‌ام بی سر و سامان که مپرس",},
new Hafez{ Id= 2265, BeytNo = 2, GhazalNo = 271, Mesra1 = "کس به اميد وفا ترک دل و دين مکناد", Mesra2 = "که چنانم من از اين کرده پشيمان که مپرس",},
new Hafez{ Id= 2266, BeytNo = 3, GhazalNo = 271, Mesra1 = "به يکی جرعه که آزار کسش در پی نيست", Mesra2 = "زحمتی می‌کشم از مردم نادان که مپرس",},
new Hafez{ Id= 2267, BeytNo = 4, GhazalNo = 271, Mesra1 = "زاهد از ما به سلامت بگذر کاين می لعل", Mesra2 = "دل و دين می‌برد از دست بدان سان که مپرس",},
new Hafez{ Id= 2268, BeytNo = 5, GhazalNo = 271, Mesra1 = "گفت‌وگوهاست در اين راه که جان بگدازد", Mesra2 = "هر کسی عربده‌ای اين که مبين آن که مپرس",},
new Hafez{ Id= 2269, BeytNo = 6, GhazalNo = 271, Mesra1 = "پارسايی و سلامت هوسم بود ولی", Mesra2 = "شيوه‌ای می‌کند آن نرگس فتان که مپرس",},
new Hafez{ Id= 2270, BeytNo = 7, GhazalNo = 271, Mesra1 = "گفتم از گوی فلک صورت حالی پرسم", Mesra2 = "گفت آن می‌کشم اندر خم چوگان که مپرس",},
new Hafez{ Id= 2271, BeytNo = 8, GhazalNo = 271, Mesra1 = "گفتمش زلف به خون که شکستی گفتا", Mesra2 = "حافظ اين قصه دراز است به قرآن که مپرس",},
new Hafez{ Id= 2272, BeytNo = 1, GhazalNo = 272, Mesra1 = "بازآی و دل تنگ مرا مونس جان باش", Mesra2 = "وين سوخته را محرم اسرار نهان باش",},
new Hafez{ Id= 2273, BeytNo = 2, GhazalNo = 272, Mesra1 = "زان باده که در ميکده عشق فروشند", Mesra2 = "ما را دو سه ساغر بده و گو رمضان باش",},
new Hafez{ Id= 2274, BeytNo = 3, GhazalNo = 272, Mesra1 = "در خرقه چو آتش زدی ای عارف سالک", Mesra2 = "جهدی کن و سرحلقه رندان جهان باش",},
new Hafez{ Id= 2275, BeytNo = 4, GhazalNo = 272, Mesra1 = "دلدار که گفتا به توام دل نگران است", Mesra2 = "گو می‌رسم اينک به سلامت نگران باش",},
new Hafez{ Id= 2276, BeytNo = 5, GhazalNo = 272, Mesra1 = "خون شد دلم از حسرت آن لعل روان بخش", Mesra2 = "ای درج محبت به همان مهر و نشان باش",},
new Hafez{ Id= 2277, BeytNo = 6, GhazalNo = 272, Mesra1 = "تا بر دلش از غصه غباری ننشيند", Mesra2 = "ای سيل سرشک از عقب نامه روان باش",},
new Hafez{ Id= 2278, BeytNo = 7, GhazalNo = 272, Mesra1 = "حافظ که هوس می‌کندش جام جهان بين", Mesra2 = "گو در نظر آصف جمشيد مکان باش",},
new Hafez{ Id= 2279, BeytNo = 1, GhazalNo = 273, Mesra1 = "اگر رفيق شفيقی درست پيمان باش", Mesra2 = "حريف خانه و گرمابه و گلستان باش",},
new Hafez{ Id= 2280, BeytNo = 2, GhazalNo = 273, Mesra1 = "شکنج زلف پريشان به دست باد مده", Mesra2 = "مگو که خاطر عشاق گو پريشان باش",},
new Hafez{ Id= 2281, BeytNo = 3, GhazalNo = 273, Mesra1 = "گرت هواست که با خضر همنشين باشی", Mesra2 = "نهان ز چشم سکندر چو آب حيوان باش",},
new Hafez{ Id= 2282, BeytNo = 4, GhazalNo = 273, Mesra1 = "زبور عشق نوازی نه کار هر مرغيست", Mesra2 = "بيا و نوگل اين بلبل غزل خوان باش",},
new Hafez{ Id= 2283, BeytNo = 5, GhazalNo = 273, Mesra1 = "طريق خدمت و آيين بندگی کردن", Mesra2 = "خدای را که رها کن به ما و سلطان باش",},
new Hafez{ Id= 2284, BeytNo = 6, GhazalNo = 273, Mesra1 = "دگر به صيد حرم تيغ برمکش زنهار", Mesra2 = "و از آن که با دل ما کرده‌ای پشيمان باش",},
new Hafez{ Id= 2285, BeytNo = 7, GhazalNo = 273, Mesra1 = "تو شمع انجمنی يک زبان و يک دل شو", Mesra2 = "خيال و کوشش پروانه بين و خندان باش",},
new Hafez{ Id= 2286, BeytNo = 8, GhazalNo = 273, Mesra1 = "کمال دلبری و حسن در نظربازيست", Mesra2 = "به شيوه نظر از نادران دوران باش",},
new Hafez{ Id= 2287, BeytNo = 9, GhazalNo = 273, Mesra1 = "خموش حافظ و از جور يار ناله مکن", Mesra2 = "تو را که گفت که در روی خوب حيران باش",},
new Hafez{ Id= 2288, BeytNo = 1, GhazalNo = 274, Mesra1 = "به دور لاله قدح گير و بی‌ريا می‌باش", Mesra2 = "به بوی گل نفسی همدم صبا می‌باش",},
new Hafez{ Id= 2289, BeytNo = 2, GhazalNo = 274, Mesra1 = "نگويمت که همه ساله می پرستی کن", Mesra2 = "سه ماه می خور و نه ماه پارسا می‌باش",},
new Hafez{ Id= 2290, BeytNo = 3, GhazalNo = 274, Mesra1 = "چو پير سالک عشقت به می حواله کند", Mesra2 = "بنوش و منتظر رحمت خدا می‌باش",},
new Hafez{ Id= 2291, BeytNo = 4, GhazalNo = 274, Mesra1 = "گرت هواست که چون جم به سر غيب رسی", Mesra2 = "بيا و همدم جام جهان نما می‌باش",},
new Hafez{ Id= 2292, BeytNo = 5, GhazalNo = 274, Mesra1 = "چو غنچه گر چه فروبستگيست کار جهان", Mesra2 = "تو همچو باد بهاری گره گشا می‌باش",},
new Hafez{ Id= 2293, BeytNo = 6, GhazalNo = 274, Mesra1 = "وفا مجوی ز کس ور سخن نمی‌شنوی", Mesra2 = "به هرزه طالب سيمرغ و کيميا می‌باش",},
new Hafez{ Id= 2294, BeytNo = 7, GhazalNo = 274, Mesra1 = "مريد طاعت بيگانگان مشو حافظ", Mesra2 = "ولی معاشر رندان پارسا می‌باش",},
new Hafez{ Id= 2295, BeytNo = 1, GhazalNo = 275, Mesra1 = "صوفی گلی بچين و مرقع به خار بخش", Mesra2 = "وين زهد خشک را به می خوشگوار بخش",},
new Hafez{ Id= 2296, BeytNo = 2, GhazalNo = 275, Mesra1 = "طامات و شطح در ره آهنگ چنگ نه", Mesra2 = "تسبيح و طيلسان به می و ميگسار بخش",},
new Hafez{ Id= 2297, BeytNo = 3, GhazalNo = 275, Mesra1 = "زهد گران که شاهد و ساقی نمی‌خرند", Mesra2 = "در حلقه چمن به نسيم بهار بخش",},
new Hafez{ Id= 2298, BeytNo = 4, GhazalNo = 275, Mesra1 = "راهم شراب لعل زد ای مير عاشقان", Mesra2 = "خون مرا به چاه زنخدان يار بخش",},
new Hafez{ Id= 2299, BeytNo = 5, GhazalNo = 275, Mesra1 = "يا رب به وقت گل گنه بنده عفو کن", Mesra2 = "وين ماجرا به سرو لب جويبار بخش",},
new Hafez{ Id= 2300, BeytNo = 6, GhazalNo = 275, Mesra1 = "ای آن که ره به مشرب مقصود برده‌ای", Mesra2 = "زين بحر قطره‌ای به من خاکسار بخش",},
new Hafez{ Id= 2301, BeytNo = 7, GhazalNo = 275, Mesra1 = "شکرانه را که چشم تو روی بتان نديد", Mesra2 = "ما را به عفو و لطف خداوندگار بخش",},
new Hafez{ Id= 2302, BeytNo = 8, GhazalNo = 275, Mesra1 = "ساقی چو شاه نوش کند باده صبوح", Mesra2 = "گو جام زر به حافظ شب زنده دار بخش",},
new Hafez{ Id= 2303, BeytNo = 1, GhazalNo = 276, Mesra1 = "باغبان گر پنج روزی صحبت گل بايدش", Mesra2 = "بر جفای خار هجران صبر بلبل بايدش",},
new Hafez{ Id= 2304, BeytNo = 2, GhazalNo = 276, Mesra1 = "ای دل اندربند زلفش از پريشانی منال", Mesra2 = "مرغ زيرک چون به دام افتد تحمل بايدش",},
new Hafez{ Id= 2305, BeytNo = 3, GhazalNo = 276, Mesra1 = "رند عالم سوز را با مصلحت بينی چه کار", Mesra2 = "کار ملک است آن که تدبير و تامل بايدش",},
new Hafez{ Id= 2306, BeytNo = 4, GhazalNo = 276, Mesra1 = "تکيه بر تقوا و دانش در طريقت کافريست", Mesra2 = "راهرو گر صد هنر دارد توکل بايدش",},
new Hafez{ Id= 2307, BeytNo = 5, GhazalNo = 276, Mesra1 = "با چنين زلف و رخش بادا نظربازی حرام", Mesra2 = "هر که روی ياسمين و جعد سنبل بايدش",},
new Hafez{ Id= 2308, BeytNo = 6, GhazalNo = 276, Mesra1 = "نازها زان نرگس مستانه‌اش بايد کشيد", Mesra2 = "اين دل شوريده تا آن جعد و کاکل بايدش",},
new Hafez{ Id= 2309, BeytNo = 7, GhazalNo = 276, Mesra1 = "ساقيا در گردش ساغر تعلل تا به چند", Mesra2 = "دور چون با عاشقان افتد تسلسل بايدش",},
new Hafez{ Id= 2310, BeytNo = 8, GhazalNo = 276, Mesra1 = "کيست حافظ تا ننوشد باده بی آواز رود", Mesra2 = "عاشق مسکين چرا چندين تجمل بايدش",},
new Hafez{ Id= 2311, BeytNo = 1, GhazalNo = 277, Mesra1 = "فکر بلبل همه آن است که گل شد يارش", Mesra2 = "گل در انديشه که چون عشوه کند در کارش",},
new Hafez{ Id= 2312, BeytNo = 2, GhazalNo = 277, Mesra1 = "دلربايی همه آن نيست که عاشق بکشند", Mesra2 = "خواجه آن است که باشد غم خدمتگارش",},
new Hafez{ Id= 2313, BeytNo = 3, GhazalNo = 277, Mesra1 = "جای آن است که خون موج زند در دل لعل", Mesra2 = "زين تغابن که خزف می‌شکند بازارش",},
new Hafez{ Id= 2314, BeytNo = 4, GhazalNo = 277, Mesra1 = "بلبل از فيض گل آموخت سخن ور نه نبود", Mesra2 = "اين همه قول و غزل تعبيه در منقارش",},
new Hafez{ Id= 2315, BeytNo = 5, GhazalNo = 277, Mesra1 = "ای که در کوچه معشوقه ما می‌گذری", Mesra2 = "بر حذر باش که سر می‌شکند ديوارش",},
new Hafez{ Id= 2316, BeytNo = 6, GhazalNo = 277, Mesra1 = "آن سفرکرده که صد قافله دل همره اوست", Mesra2 = "هر کجا هست خدايا به سلامت دارش",},
new Hafez{ Id= 2317, BeytNo = 7, GhazalNo = 277, Mesra1 = "صحبت عافيتت گر چه خوش افتاد ای دل", Mesra2 = "جانب عشق عزيز است فرومگذارش",},
new Hafez{ Id= 2318, BeytNo = 8, GhazalNo = 277, Mesra1 = "صوفی سرخوش از اين دست که کج کرد کلاه", Mesra2 = "به دو جام دگر آشفته شود دستارش",},
new Hafez{ Id= 2319, BeytNo = 9, GhazalNo = 277, Mesra1 = "دل حافظ که به ديدار تو خوگر شده بود", Mesra2 = "نازپرورد وصال است مجو آزارش",},
new Hafez{ Id= 2320, BeytNo = 1, GhazalNo = 278, Mesra1 = "شراب تلخ می‌خواهم که مردافکن بود زورش", Mesra2 = "که تا يک دم بياسايم ز دنيا و شر و شورش",},
new Hafez{ Id= 2321, BeytNo = 2, GhazalNo = 278, Mesra1 = "سماط دهر دون پرور ندارد شهد آسايش", Mesra2 = "مذاق حرص و آز ای دل بشو از تلخ و از شورش",},
new Hafez{ Id= 2322, BeytNo = 3, GhazalNo = 278, Mesra1 = "بياور می که نتوان شد ز مکر آسمان ايمن", Mesra2 = "به لعب زهره چنگی و مريخ سلحشورش",},
new Hafez{ Id= 2323, BeytNo = 4, GhazalNo = 278, Mesra1 = "کمند صيد بهرامی بيفکن جام جم بردار", Mesra2 = "که من پيمودم اين صحرا نه بهرام است و نه گورش",},
new Hafez{ Id= 2324, BeytNo = 5, GhazalNo = 278, Mesra1 = "بيا تا در می صافيت راز دهر بنمايم", Mesra2 = "به شرط آن که ننمايی به کج طبعان دل کورش",},
new Hafez{ Id= 2325, BeytNo = 6, GhazalNo = 278, Mesra1 = "نظر کردن به درويشان منافی بزرگی نيست", Mesra2 = "سليمان با چنان حشمت نظرها بود با مورش",},
new Hafez{ Id= 2326, BeytNo = 7, GhazalNo = 278, Mesra1 = "کمان ابروی جانان نمی‌پيچد سر از حافظ", Mesra2 = "وليکن خنده می‌آيد بدين بازوی بی زورش",},
new Hafez{ Id= 2327, BeytNo = 1, GhazalNo = 279, Mesra1 = "خوشا شيراز و وضع بی‌مثالش", Mesra2 = "خداوندا نگه دار از زوالش",},
new Hafez{ Id= 2328, BeytNo = 2, GhazalNo = 279, Mesra1 = "ز رکن آباد ما صد لوحش الله", Mesra2 = "که عمر خضر می‌بخشد زلالش",},
new Hafez{ Id= 2329, BeytNo = 3, GhazalNo = 279, Mesra1 = "ميان جعفرآباد و مصلا", Mesra2 = "عبيرآميز می‌آيد شمالش",},
new Hafez{ Id= 2330, BeytNo = 4, GhazalNo = 279, Mesra1 = "به شيراز آی و فيض روح قدسی", Mesra2 = "بجوی از مردم صاحب کمالش",},
new Hafez{ Id= 2331, BeytNo = 5, GhazalNo = 279, Mesra1 = "که نام قند مصری برد آن جا", Mesra2 = "که شيرينان ندادند انفعالش",},
new Hafez{ Id= 2332, BeytNo = 6, GhazalNo = 279, Mesra1 = "صبا زان لولی شنگول سرمست", Mesra2 = "چه داری آگهی چون است حالش",},
new Hafez{ Id= 2333, BeytNo = 7, GhazalNo = 279, Mesra1 = "گر آن شيرين پسر خونم بريزد", Mesra2 = "دلا چون شير مادر کن حلالش",},
new Hafez{ Id= 2334, BeytNo = 8, GhazalNo = 279, Mesra1 = "مکن از خواب بيدارم خدا را", Mesra2 = "که دارم خلوتی خوش با خيالش",},
new Hafez{ Id= 2335, BeytNo = 9, GhazalNo = 279, Mesra1 = "چرا حافظ چو می‌ترسيدی از هجر", Mesra2 = "نکردی شکر ايام وصالش",},
new Hafez{ Id= 2336, BeytNo = 1, GhazalNo = 280, Mesra1 = "چو برشکست صبا زلف عنبرافشانش", Mesra2 = "به هر شکسته که پيوست تازه شد جانش",},
new Hafez{ Id= 2337, BeytNo = 2, GhazalNo = 280, Mesra1 = "کجاست همنفسی تا به شرح عرضه دهم", Mesra2 = "که دل چه می‌کشد از روزگار هجرانش",},
new Hafez{ Id= 2338, BeytNo = 3, GhazalNo = 280, Mesra1 = "زمانه از ورق گل مثال روی تو بست", Mesra2 = "ولی ز شرم تو در غنچه کرد پنهانش",},
new Hafez{ Id= 2339, BeytNo = 4, GhazalNo = 280, Mesra1 = "تو خفته‌ای و نشد عشق را کرانه پديد", Mesra2 = "تبارک الله از اين ره که نيست پايانش",},
new Hafez{ Id= 2340, BeytNo = 5, GhazalNo = 280, Mesra1 = "جمال کعبه مگر عذر ره روان خواهد", Mesra2 = "که جان زنده دلان سوخت در بيابانش",},
new Hafez{ Id= 2341, BeytNo = 6, GhazalNo = 280, Mesra1 = "بدين شکسته بيت الحزن که می‌آرد", Mesra2 = "نشان يوسف دل از چه زنخدانش",},
new Hafez{ Id= 2342, BeytNo = 7, GhazalNo = 280, Mesra1 = "بگيرم آن سر زلف و به دست خواجه دهم", Mesra2 = "که سوخت حافظ بی‌دل ز مکر و دستانش",},
new Hafez{ Id= 2343, BeytNo = 1, GhazalNo = 281, Mesra1 = "يا رب اين نوگل خندان که سپردی به منش", Mesra2 = "می‌سپارم به تو از چشم حسود چمنش",},
new Hafez{ Id= 2344, BeytNo = 2, GhazalNo = 281, Mesra1 = "گر چه از کوی وفا گشت به صد مرحله دور", Mesra2 = "دور باد آفت دور فلک از جان و تنش",},
new Hafez{ Id= 2345, BeytNo = 3, GhazalNo = 281, Mesra1 = "گر به سرمنزل سلمی رسی ای باد صبا", Mesra2 = "چشم دارم که سلامی برسانی ز منش",},
new Hafez{ Id= 2346, BeytNo = 4, GhazalNo = 281, Mesra1 = "به ادب نافه گشايی کن از آن زلف سياه", Mesra2 = "جای دل‌های عزيز است به هم برمزنش",},
new Hafez{ Id= 2347, BeytNo = 5, GhazalNo = 281, Mesra1 = "گو دلم حق وفا با خط و خالت دارد", Mesra2 = "محترم دار در آن طره عنبرشکنش",},
new Hafez{ Id= 2348, BeytNo = 6, GhazalNo = 281, Mesra1 = "در مقامی که به ياد لب او می نوشند", Mesra2 = "سفله آن مست که باشد خبر از خويشتنش",},
new Hafez{ Id= 2349, BeytNo = 7, GhazalNo = 281, Mesra1 = "عرض و مال از در ميخانه نشايد اندوخت", Mesra2 = "هر که اين آب خورد رخت به دريا فکنش",},
new Hafez{ Id= 2350, BeytNo = 8, GhazalNo = 281, Mesra1 = "هر که ترسد ز ملال انده عشقش نه حلال", Mesra2 = "سر ما و قدمش يا لب ما و دهنش",},
new Hafez{ Id= 2351, BeytNo = 9, GhazalNo = 281, Mesra1 = "شعر حافظ همه بيت الغزل معرفت است", Mesra2 = "آفرين بر نفس دلکش و لطف سخنش",},
new Hafez{ Id= 2352, BeytNo = 1, GhazalNo = 282, Mesra1 = "ببرد از من قرار و طاقت و هوش", Mesra2 = "بت سنگين دل سيمين بناگوش",},
new Hafez{ Id= 2353, BeytNo = 2, GhazalNo = 282, Mesra1 = "نگاری چابکی شنگی کلهدار", Mesra2 = "ظريفی مه وشی ترکی قباپوش",},
new Hafez{ Id= 2354, BeytNo = 3, GhazalNo = 282, Mesra1 = "ز تاب آتش سودای عشقش", Mesra2 = "به سان ديگ دايم می‌زنم جوش",},
new Hafez{ Id= 2355, BeytNo = 4, GhazalNo = 282, Mesra1 = "چو پيراهن شوم آسوده خاطر", Mesra2 = "گرش همچون قبا گيرم در آغوش",},
new Hafez{ Id= 2356, BeytNo = 5, GhazalNo = 282, Mesra1 = "اگر پوسيده گردد استخوانم", Mesra2 = "نگردد مهرت از جانم فراموش",},
new Hafez{ Id= 2357, BeytNo = 6, GhazalNo = 282, Mesra1 = "دل و دينم دل و دينم ببرده‌ست", Mesra2 = "بر و دوشش بر و دوشش بر و دوش",},
new Hafez{ Id= 2358, BeytNo = 7, GhazalNo = 282, Mesra1 = "دوای تو دوای توست حافظ", Mesra2 = "لب نوشش لب نوشش لب نوش",},
new Hafez{ Id= 2359, BeytNo = 1, GhazalNo = 283, Mesra1 = "سحر ز هاتف غيبم رسيد مژده به گوش", Mesra2 = "که دور شاه شجاع است می دلير بنوش",},
new Hafez{ Id= 2360, BeytNo = 2, GhazalNo = 283, Mesra1 = "شد آن که اهل نظر بر کناره می‌رفتند", Mesra2 = "هزار گونه سخن در دهان و لب خاموش",},
new Hafez{ Id= 2361, BeytNo = 3, GhazalNo = 283, Mesra1 = "به صوت چنگ بگوييم آن حکايت‌ها", Mesra2 = "که از نهفتن آن ديگ سينه می‌زد جوش",},
new Hafez{ Id= 2362, BeytNo = 4, GhazalNo = 283, Mesra1 = "شراب خانگی ترس محتسب خورده", Mesra2 = "به روی يار بنوشيم و بانگ نوشانوش",},
new Hafez{ Id= 2363, BeytNo = 5, GhazalNo = 283, Mesra1 = "ز کوی ميکده دوشش به دوش می‌بردند", Mesra2 = "امام شهر که سجاده می‌کشيد به دوش",},
new Hafez{ Id= 2364, BeytNo = 6, GhazalNo = 283, Mesra1 = "دلا دلالت خيرت کنم به راه نجات", Mesra2 = "مکن به فسق مباهات و زهد هم مفروش",},
new Hafez{ Id= 2365, BeytNo = 7, GhazalNo = 283, Mesra1 = "محل نور تجليست رای انور شاه", Mesra2 = "چو قرب او طلبی در صفای نيت کوش",},
new Hafez{ Id= 2366, BeytNo = 8, GhazalNo = 283, Mesra1 = "بجز ثنای جلالش مساز ورد ضمير", Mesra2 = "که هست گوش دلش محرم پيام سروش",},
new Hafez{ Id= 2367, BeytNo = 9, GhazalNo = 283, Mesra1 = "رموز مصلحت ملک خسروان دانند", Mesra2 = "گدای گوشه نشينی تو حافظا مخروش",},
new Hafez{ Id= 2368, BeytNo = 1, GhazalNo = 284, Mesra1 = "هاتفی از گوشه ميخانه دوش", Mesra2 = "گفت ببخشند گنه می بنوش",},
new Hafez{ Id= 2369, BeytNo = 2, GhazalNo = 284, Mesra1 = "لطف الهی بکند کار خويش", Mesra2 = "مژده رحمت برساند سروش",},
new Hafez{ Id= 2370, BeytNo = 3, GhazalNo = 284, Mesra1 = "اين خرد خام به ميخانه بر", Mesra2 = "تا می لعل آوردش خون به جوش",},
new Hafez{ Id= 2371, BeytNo = 4, GhazalNo = 284, Mesra1 = "گر چه وصالش نه به کوشش دهند", Mesra2 = "هر قدر ای دل که توانی بکوش",},
new Hafez{ Id= 2372, BeytNo = 5, GhazalNo = 284, Mesra1 = "لطف خدا بيشتر از جرم ماست", Mesra2 = "نکته سربسته چه دانی خموش",},
new Hafez{ Id= 2373, BeytNo = 6, GhazalNo = 284, Mesra1 = "گوش من و حلقه گيسوی يار", Mesra2 = "روی من و خاک در می فروش",},
new Hafez{ Id= 2374, BeytNo = 7, GhazalNo = 284, Mesra1 = "رندی حافظ نه گناهيست صعب", Mesra2 = "با کرم پادشه عيب پوش",},
new Hafez{ Id= 2375, BeytNo = 8, GhazalNo = 284, Mesra1 = "داور دين شاه شجاع آن که کرد", Mesra2 = "روح قدس حلقه امرش به گوش",},
new Hafez{ Id= 2376, BeytNo = 9, GhazalNo = 284, Mesra1 = "ای ملک العرش مرادش بده", Mesra2 = "و از خطر چشم بدش دار گوش",},
new Hafez{ Id= 2377, BeytNo = 1, GhazalNo = 285, Mesra1 = "در عهد پادشاه خطابخش جرم پوش", Mesra2 = "حافظ قرابه کش شد و مفتی پياله نوش",},
new Hafez{ Id= 2378, BeytNo = 2, GhazalNo = 285, Mesra1 = "صوفی ز کنج صومعه با پای خم نشست", Mesra2 = "تا ديد محتسب که سبو می‌کشد به دوش",},
new Hafez{ Id= 2379, BeytNo = 3, GhazalNo = 285, Mesra1 = "احوال شيخ و قاضی و شرب اليهودشان", Mesra2 = "کردم سال صبحدم از پير می فروش",},
new Hafez{ Id= 2380, BeytNo = 4, GhazalNo = 285, Mesra1 = "گفتا نه گفتنيست سخن گر چه محرمی", Mesra2 = "درکش زبان و پرده نگه دار و می بنوش",},
new Hafez{ Id= 2381, BeytNo = 5, GhazalNo = 285, Mesra1 = "ساقی بهار می‌رسد و وجه می‌نماند", Mesra2 = "فکری بکن که خون دل آمد ز غم به جوش",},
new Hafez{ Id= 2382, BeytNo = 6, GhazalNo = 285, Mesra1 = "عشق است و مفلسی و جوانی و نوبهار", Mesra2 = "عذرم پذير و جرم به ذيل کرم بپوش",},
new Hafez{ Id= 2383, BeytNo = 7, GhazalNo = 285, Mesra1 = "تا چند همچو شمع زبان آوری کنی", Mesra2 = "پروانه مراد رسيد ای محب خموش",},
new Hafez{ Id= 2384, BeytNo = 8, GhazalNo = 285, Mesra1 = "ای پادشاه صورت و معنی که مثل تو", Mesra2 = "ناديده هيچ ديده و نشنيده هيچ گوش",},
new Hafez{ Id= 2385, BeytNo = 9, GhazalNo = 285, Mesra1 = "چندان بمان که خرقه ازرق کند قبول", Mesra2 = "بخت جوانت از فلک پير ژنده پوش",},
new Hafez{ Id= 2386, BeytNo = 1, GhazalNo = 286, Mesra1 = "دوش با من گفت پنهان کاردانی تيزهوش", Mesra2 = "و از شما پنهان نشايد کرد سر می فروش",},
new Hafez{ Id= 2387, BeytNo = 2, GhazalNo = 286, Mesra1 = "گفت آسان گير بر خود کارها کز روی طبع", Mesra2 = "سخت می‌گردد جهان بر مردمان سختکوش",},
new Hafez{ Id= 2388, BeytNo = 3, GhazalNo = 286, Mesra1 = "وان گهم درداد جامی کز فروغش بر فلک", Mesra2 = "زهره در رقص آمد و بربط زنان می‌گفت نوش",},
new Hafez{ Id= 2389, BeytNo = 4, GhazalNo = 286, Mesra1 = "با دل خونين لب خندان بياور همچو جام", Mesra2 = "نی گرت زخمی رسد آيی چو چنگ اندر خروش",},
new Hafez{ Id= 2390, BeytNo = 5, GhazalNo = 286, Mesra1 = "تا نگردی آشنا زين پرده رمزی نشنوی", Mesra2 = "گوش نامحرم نباشد جای پيغام سروش",},
new Hafez{ Id= 2391, BeytNo = 6, GhazalNo = 286, Mesra1 = "گوش کن پند ای پسر و از بهر دنيا غم مخور", Mesra2 = "گفتمت چون در حديثی گر توانی داشت هوش",},
new Hafez{ Id= 2392, BeytNo = 7, GhazalNo = 286, Mesra1 = "در حريم عشق نتوان زد دم از گفت و شنيد", Mesra2 = "زان که آن جا جمله اعضا چشم بايد بود و گوش",},
new Hafez{ Id= 2393, BeytNo = 8, GhazalNo = 286, Mesra1 = "بر بساط نکته دانان خودفروشی شرط نيست", Mesra2 = "يا سخن دانسته گو ای مرد عاقل يا خموش",},
new Hafez{ Id= 2394, BeytNo = 9, GhazalNo = 286, Mesra1 = "ساقيا می ده که رندی‌های حافظ فهم کرد", Mesra2 = "آصف صاحب قران جرم بخش عيب پوش",},
new Hafez{ Id= 2395, BeytNo = 1, GhazalNo = 287, Mesra1 = "ای همه شکل تو مطبوع و همه جای تو خوش", Mesra2 = "دلم از عشوه شيرين شکرخای تو خوش",},
new Hafez{ Id= 2396, BeytNo = 2, GhazalNo = 287, Mesra1 = "همچو گلبرگ طری هست وجود تو لطيف", Mesra2 = "همچو سرو چمن خلد سراپای تو خوش",},
new Hafez{ Id= 2397, BeytNo = 3, GhazalNo = 287, Mesra1 = "شيوه و ناز تو شيرين خط و خال تو مليح", Mesra2 = "چشم و ابروی تو زيبا قد و بالای تو خوش",},
new Hafez{ Id= 2398, BeytNo = 4, GhazalNo = 287, Mesra1 = "هم گلستان خيالم ز تو پرنقش و نگار", Mesra2 = "هم مشام دلم از زلف سمن سای تو خوش",},
new Hafez{ Id= 2399, BeytNo = 5, GhazalNo = 287, Mesra1 = "در ره عشق که از سيل بلا نيست گذار", Mesra2 = "کرده‌ام خاطر خود را به تمنای تو خوش",},
new Hafez{ Id= 2400, BeytNo = 6, GhazalNo = 287, Mesra1 = "شکر چشم تو چه گويم که بدان بيماری", Mesra2 = "می کند درد مرا از رخ زيبای تو خوش",},
new Hafez{ Id= 2401, BeytNo = 7, GhazalNo = 287, Mesra1 = "در بيابان طلب گر چه ز هر سو خطريست", Mesra2 = "می‌رود حافظ بی‌دل به تولای تو خوش",},
new Hafez{ Id= 2402, BeytNo = 1, GhazalNo = 288, Mesra1 = "کنار آب و پای بيد و طبع شعر و ياری خوش", Mesra2 = "معاشر دلبری شيرين و ساقی گلعذاری خوش",},
new Hafez{ Id= 2403, BeytNo = 2, GhazalNo = 288, Mesra1 = "الا ای دولتی طالع که قدر وقت می‌دانی", Mesra2 = "گوارا بادت اين عشرت که داری روزگاری خوش",},
new Hafez{ Id= 2404, BeytNo = 3, GhazalNo = 288, Mesra1 = "هر آن کس را که در خاطر ز عشق دلبری باريست", Mesra2 = "سپندی گو بر آتش نه که دارد کار و باری خوش",},
new Hafez{ Id= 2405, BeytNo = 4, GhazalNo = 288, Mesra1 = "عروس طبع را زيور ز فکر بکر می‌بندم", Mesra2 = "بود کز دست ايامم به دست افتد نگاری خوش",},
new Hafez{ Id= 2406, BeytNo = 5, GhazalNo = 288, Mesra1 = "شب صحبت غنيمت دان و داد خوشدلی بستان", Mesra2 = "که مهتابی دل افروز است و طرف لاله زاری خوش",},
new Hafez{ Id= 2407, BeytNo = 6, GhazalNo = 288, Mesra1 = "می‌ای در کاسه چشم است ساقی را بناميزد", Mesra2 = "که مستی می‌کند با عقل و می‌بخشد خماری خوش",},
new Hafez{ Id= 2408, BeytNo = 7, GhazalNo = 288, Mesra1 = "به غفلت عمر شد حافظ بيا با ما به ميخانه", Mesra2 = "که شنگولان خوش باشت بياموزند کاری خوش",},
new Hafez{ Id= 2409, BeytNo = 1, GhazalNo = 289, Mesra1 = "مجمع خوبی و لطف است عذار چو مهش", Mesra2 = "ليکنش مهر و وفا نيست خدايا بدهش",},
new Hafez{ Id= 2410, BeytNo = 2, GhazalNo = 289, Mesra1 = "دلبرم شاهد و طفل است و به بازی روزی", Mesra2 = "بکشد زارم و در شرع نباشد گنهش",},
new Hafez{ Id= 2411, BeytNo = 3, GhazalNo = 289, Mesra1 = "من همان به که از او نيک نگه دارم دل", Mesra2 = "که بد و نيک نديده‌ست و ندارد نگهش",},
new Hafez{ Id= 2412, BeytNo = 4, GhazalNo = 289, Mesra1 = "بوی شير از لب همچون شکرش می‌آيد", Mesra2 = "گر چه خون می‌چکد از شيوه چشم سيهش",},
new Hafez{ Id= 2413, BeytNo = 5, GhazalNo = 289, Mesra1 = "چارده ساله بتی چابک شيرين دارم", Mesra2 = "که به جان حلقه به گوش است مه چاردهش",},
new Hafez{ Id= 2414, BeytNo = 6, GhazalNo = 289, Mesra1 = "از پی آن گل نورسته دل ما يا رب", Mesra2 = "خود کجا شد که نديديم در اين چند گهش",},
new Hafez{ Id= 2415, BeytNo = 7, GhazalNo = 289, Mesra1 = "يار دلدار من ار قلب بدين سان شکند", Mesra2 = "ببرد زود به جانداری خود پادشهش",},
new Hafez{ Id= 2416, BeytNo = 8, GhazalNo = 289, Mesra1 = "جان به شکرانه کنم صرف گر آن دانه در", Mesra2 = "صدف سينه حافظ بود آرامگهش",},
new Hafez{ Id= 2417, BeytNo = 1, GhazalNo = 290, Mesra1 = "دلم رميده شد و غافلم من درويش", Mesra2 = "که آن شکاری سرگشته را چه آمد پيش",},
new Hafez{ Id= 2418, BeytNo = 2, GhazalNo = 290, Mesra1 = "چو بيد بر سر ايمان خويش می‌لرزم", Mesra2 = "که دل به دست کمان ابروييست کافرکيش",},
new Hafez{ Id= 2419, BeytNo = 3, GhazalNo = 290, Mesra1 = "خيال حوصله بحر می‌پزد هيهات", Mesra2 = "چه‌هاست در سر اين قطره محال انديش",},
new Hafez{ Id= 2420, BeytNo = 4, GhazalNo = 290, Mesra1 = "بنازم آن مژه شوخ عافيت کش را", Mesra2 = "که موج می‌زندش آب نوش بر سر نيش",},
new Hafez{ Id= 2421, BeytNo = 5, GhazalNo = 290, Mesra1 = "ز آستين طبيبان هزار خون بچکد", Mesra2 = "گرم به تجربه دستی نهند بر دل ريش",},
new Hafez{ Id= 2422, BeytNo = 6, GhazalNo = 290, Mesra1 = "به کوی ميکده گريان و سرفکنده روم", Mesra2 = "چرا که شرم همی‌آيدم ز حاصل خويش",},
new Hafez{ Id= 2423, BeytNo = 7, GhazalNo = 290, Mesra1 = "نه عمر خضر بماند نه ملک اسکندر", Mesra2 = "نزاع بر سر دنيی دون مکن درويش",},
new Hafez{ Id= 2424, BeytNo = 8, GhazalNo = 290, Mesra1 = "بدان کمر نرسد دست هر گدا حافظ", Mesra2 = "خزانه‌ای به کف آور ز گنج قارون بيش",},
new Hafez{ Id= 2425, BeytNo = 1, GhazalNo = 291, Mesra1 = "ما آزموده‌ايم در اين شهر بخت خويش", Mesra2 = "بيرون کشيد بايد از اين ورطه رخت خويش",},
new Hafez{ Id= 2426, BeytNo = 2, GhazalNo = 291, Mesra1 = "از بس که دست می‌گزم و آه می‌کشم", Mesra2 = "آتش زدم چو گل به تن لخت لخت خويش",},
new Hafez{ Id= 2427, BeytNo = 3, GhazalNo = 291, Mesra1 = "دوشم ز بلبلی چه خوش آمد که می‌سرود", Mesra2 = "گل گوش پهن کرده ز شاخ درخت خويش",},
new Hafez{ Id= 2428, BeytNo = 4, GhazalNo = 291, Mesra1 = "کای دل تو شاد باش که آن يار تندخو", Mesra2 = "بسيار تندروی نشيند ز بخت خويش",},
new Hafez{ Id= 2429, BeytNo = 5, GhazalNo = 291, Mesra1 = "خواهی که سخت و سست جهان بر تو بگذرد", Mesra2 = "بگذر ز عهد سست و سخن‌های سخت خويش",},
new Hafez{ Id= 2430, BeytNo = 6, GhazalNo = 291, Mesra1 = "وقت است کز فراق تو وز سوز اندرون", Mesra2 = "آتش درافکنم به همه رخت و پخت خويش",},
new Hafez{ Id= 2431, BeytNo = 7, GhazalNo = 291, Mesra1 = "ای حافظ ار مراد ميسر شدی مدام", Mesra2 = "جمشيد نيز دور نماندی ز تخت خويش",},
new Hafez{ Id= 2432, BeytNo = 1, GhazalNo = 292, Mesra1 = "قسم به حشمت و جاه و جلال شاه شجاع", Mesra2 = "که نيست با کسم از بهر مال و جاه نزاع",},
new Hafez{ Id= 2433, BeytNo = 2, GhazalNo = 292, Mesra1 = "شراب خانگيم بس می مغانه بيار", Mesra2 = "حريف باده رسيد ای رفيق توبه وداع",},
new Hafez{ Id= 2434, BeytNo = 3, GhazalNo = 292, Mesra1 = "خدای را به می‌ام شست و شوی خرقه کنيد", Mesra2 = "که من نمی‌شنوم بوی خير از اين اوضاع",},
new Hafez{ Id= 2435, BeytNo = 4, GhazalNo = 292, Mesra1 = "ببين که رقص کنان می‌رود به ناله چنگ", Mesra2 = "کسی که رخصه نفرمودی استماع سماع",},
new Hafez{ Id= 2436, BeytNo = 5, GhazalNo = 292, Mesra1 = "به عاشقان نظری کن به شکر اين نعمت", Mesra2 = "که من غلام مطيعم تو پادشاه مطاع",},
new Hafez{ Id= 2437, BeytNo = 6, GhazalNo = 292, Mesra1 = "به فيض جرعه جام تو تشنه‌ايم ولی", Mesra2 = "نمی‌کنيم دليری نمی‌دهيم صداع",},
new Hafez{ Id= 2438, BeytNo = 7, GhazalNo = 292, Mesra1 = "جبين و چهره حافظ خدا جدا مکناد", Mesra2 = "ز خاک بارگه کبريای شاه شجاع",},
new Hafez{ Id= 2439, BeytNo = 1, GhazalNo = 293, Mesra1 = "بامدادان که ز خلوتگه کاخ ابداع", Mesra2 = "شمع خاور فکند بر همه اطراف شعاع",},
new Hafez{ Id= 2440, BeytNo = 2, GhazalNo = 293, Mesra1 = "برکشد آينه از جيب افق چرخ و در آن", Mesra2 = "بنمايد رخ گيتی به هزاران انواع",},
new Hafez{ Id= 2441, BeytNo = 3, GhazalNo = 293, Mesra1 = "در زوايای طربخانه جمشيد فلک", Mesra2 = "ارغنون ساز کند زهره به آهنگ سماع",},
new Hafez{ Id= 2442, BeytNo = 4, GhazalNo = 293, Mesra1 = "چنگ در غلغله آيد که کجا شد منکر", Mesra2 = "جام در قهقهه آيد که کجا شد مناع",},
new Hafez{ Id= 2443, BeytNo = 5, GhazalNo = 293, Mesra1 = "وضع دوران بنگر ساغر عشرت برگير", Mesra2 = "که به هر حالتی اين است بهين اوضاع",},
new Hafez{ Id= 2444, BeytNo = 6, GhazalNo = 293, Mesra1 = "طره شاهد دنيی همه بند است و فريب", Mesra2 = "عارفان بر سر اين رشته نجويند نزاع",},
new Hafez{ Id= 2445, BeytNo = 7, GhazalNo = 293, Mesra1 = "عمر خسرو طلب ار نفع جهان می‌خواهی", Mesra2 = "که وجوديست عطابخش کريم نفاع",},
new Hafez{ Id= 2446, BeytNo = 8, GhazalNo = 293, Mesra1 = "مظهر لطف ازل روشنی چشم امل", Mesra2 = "جامع علم و عمل جان جهان شاه شجاع",},
new Hafez{ Id= 2447, BeytNo = 1, GhazalNo = 294, Mesra1 = "در وفای عشق تو مشهور خوبانم چو شمع", Mesra2 = "شب نشين کوی سربازان و رندانم چو شمع",},
new Hafez{ Id= 2448, BeytNo = 2, GhazalNo = 294, Mesra1 = "روز و شب خوابم نمی‌آيد به چشم غم پرست", Mesra2 = "بس که در بيماری هجر تو گريانم چو شمع",},
new Hafez{ Id= 2449, BeytNo = 3, GhazalNo = 294, Mesra1 = "رشته صبرم به مقراض غمت ببريده شد", Mesra2 = "همچنان در آتش مهر تو سوزانم چو شمع",},
new Hafez{ Id= 2450, BeytNo = 4, GhazalNo = 294, Mesra1 = "گر کميت اشک گلگونم نبودی گرم رو", Mesra2 = "کی شدی روشن به گيتی راز پنهانم چو شمع",},
new Hafez{ Id= 2451, BeytNo = 5, GhazalNo = 294, Mesra1 = "در ميان آب و آتش همچنان سرگرم توست", Mesra2 = "اين دل زار نزار اشک بارانم چو شمع",},
new Hafez{ Id= 2452, BeytNo = 6, GhazalNo = 294, Mesra1 = "در شب هجران مرا پروانه وصلی فرست", Mesra2 = "ور نه از دردت جهانی را بسوزانم چو شمع",},
new Hafez{ Id= 2453, BeytNo = 7, GhazalNo = 294, Mesra1 = "بی جمال عالم آرای تو روزم چون شب است", Mesra2 = "با کمال عشق تو در عين نقصانم چو شمع",},
new Hafez{ Id= 2454, BeytNo = 8, GhazalNo = 294, Mesra1 = "کوه صبرم نرم شد چون موم در دست غمت", Mesra2 = "تا در آب و آتش عشقت گدازانم چو شمع",},
new Hafez{ Id= 2455, BeytNo = 9, GhazalNo = 294, Mesra1 = "همچو صبحم يک نفس باقيست با ديدار تو", Mesra2 = "چهره بنما دلبرا تا جان برافشانم چو شمع",},
new Hafez{ Id= 2456, BeytNo = 10, GhazalNo = 294, Mesra1 = "سرفرازم کن شبی از وصل خود ای نازنين", Mesra2 = "تا منور گردد از ديدارت ايوانم چو شمع",},
new Hafez{ Id= 2457, BeytNo = 11, GhazalNo = 294, Mesra1 = "آتش مهر تو را حافظ عجب در سر گرفت", Mesra2 = "آتش دل کی به آب ديده بنشانم چو شمع",},
new Hafez{ Id= 2458, BeytNo = 1, GhazalNo = 295, Mesra1 = "سحر به بوی گلستان دمی شدم در باغ", Mesra2 = "که تا چو بلبل بی‌دل کنم علاج دماغ",},
new Hafez{ Id= 2459, BeytNo = 2, GhazalNo = 295, Mesra1 = "به جلوه گل سوری نگاه می‌کردم", Mesra2 = "که بود در شب تيره به روشنی چو چراغ",},
new Hafez{ Id= 2460, BeytNo = 3, GhazalNo = 295, Mesra1 = "چنان به حسن و جوانی خويشتن مغرور", Mesra2 = "که داشت از دل بلبل هزار گونه فراغ",},
new Hafez{ Id= 2461, BeytNo = 4, GhazalNo = 295, Mesra1 = "گشاده نرگس رعنا ز حسرت آب از چشم", Mesra2 = "نهاده لاله ز سودا به جان و دل صد داغ",},
new Hafez{ Id= 2462, BeytNo = 5, GhazalNo = 295, Mesra1 = "زبان کشيده چو تيغی به سرزنش سوسن", Mesra2 = "دهان گشاده شقايق چو مردم ايغاغ",},
new Hafez{ Id= 2463, BeytNo = 6, GhazalNo = 295, Mesra1 = "يکی چو باده پرستان صراحی اندر دست", Mesra2 = "يکی چو ساقی مستان به کف گرفته اياغ",},
new Hafez{ Id= 2464, BeytNo = 7, GhazalNo = 295, Mesra1 = "نشاط و عيش و جوانی چو گل غنيمت دان", Mesra2 = "که حافظا نبود بر رسول غير بلاغ",},
new Hafez{ Id= 2465, BeytNo = 1, GhazalNo = 296, Mesra1 = "طالع اگر مدد دهد دامنش آورم به کف", Mesra2 = "گر بکشم زهی طرب ور بکشد زهی شرف",},
new Hafez{ Id= 2466, BeytNo = 2, GhazalNo = 296, Mesra1 = "طرف کرم ز کس نبست اين دل پراميد من", Mesra2 = "گر چه سخن همی‌برد قصه من به هر طرف",},
new Hafez{ Id= 2467, BeytNo = 3, GhazalNo = 296, Mesra1 = "از خم ابروی توام هيچ گشايشی نشد", Mesra2 = "وه که در اين خيال کج عمر عزيز شد تلف",},
new Hafez{ Id= 2468, BeytNo = 4, GhazalNo = 296, Mesra1 = "ابروی دوست کی شود دست کش خيال من", Mesra2 = "کس نزده‌ست از اين کمان تير مراد بر هدف",},
new Hafez{ Id= 2469, BeytNo = 5, GhazalNo = 296, Mesra1 = "چند به ناز پرورم مهر بتان سنگ دل", Mesra2 = "ياد پدر نمی‌کنند اين پسران ناخلف",},
new Hafez{ Id= 2470, BeytNo = 6, GhazalNo = 296, Mesra1 = "من به خيال زاهدی گوشه نشين و طرفه آنک", Mesra2 = "مغبچه‌ای ز هر طرف می‌زندم به چنگ و دف",},
new Hafez{ Id= 2471, BeytNo = 7, GhazalNo = 296, Mesra1 = "بی خبرند زاهدان نقش بخوان و لا تقل", Mesra2 = "مست رياست محتسب باده بده و لا تخف",},
new Hafez{ Id= 2472, BeytNo = 8, GhazalNo = 296, Mesra1 = "صوفی شهر بين که چون لقمه شبهه می‌خورد", Mesra2 = "پاردمش دراز باد آن حيوان خوش علف",},
new Hafez{ Id= 2473, BeytNo = 9, GhazalNo = 296, Mesra1 = "حافظ اگر قدم زنی در ره خاندان به صدق", Mesra2 = "بدرقه رهت شود همت شحنه نجف",},
new Hafez{ Id= 2474, BeytNo = 1, GhazalNo = 297, Mesra1 = "زبان خامه ندارد سر بيان فراق", Mesra2 = "وگرنه شرح دهم با تو داستان فراق",},
new Hafez{ Id= 2475, BeytNo = 2, GhazalNo = 297, Mesra1 = "دريغ مدت عمرم که بر اميد وصال", Mesra2 = "به سر رسيد و نيامد به سر زمان فراق",},
new Hafez{ Id= 2476, BeytNo = 3, GhazalNo = 297, Mesra1 = "سری که بر سر گردون به فخر می‌سودم", Mesra2 = "به راستان که نهادم بر آستان فراق",},
new Hafez{ Id= 2477, BeytNo = 4, GhazalNo = 297, Mesra1 = "چگونه باز کنم بال در هوای وصال", Mesra2 = "که ريخت مرغ دلم پر در آشيان فراق",},
new Hafez{ Id= 2478, BeytNo = 5, GhazalNo = 297, Mesra1 = "کنون چه چاره که در بحر غم به گردابی", Mesra2 = "فتاد زورق صبرم ز بادبان فراق",},
new Hafez{ Id= 2479, BeytNo = 6, GhazalNo = 297, Mesra1 = "بسی نماند که کشتی عمر غرقه شود", Mesra2 = "ز موج شوق تو در بحر بی‌کران فراق",},
new Hafez{ Id= 2480, BeytNo = 7, GhazalNo = 297, Mesra1 = "اگر به دست من افتد فراق را بکشم", Mesra2 = "که روز هجر سيه باد و خان و مان فراق",},
new Hafez{ Id= 2481, BeytNo = 8, GhazalNo = 297, Mesra1 = "رفيق خيل خياليم و همنشين شکيب", Mesra2 = "قرين آتش هجران و هم قران فراق",},
new Hafez{ Id= 2482, BeytNo = 9, GhazalNo = 297, Mesra1 = "چگونه دعوی وصلت کنم به جان که شده‌ست", Mesra2 = "تنم وکيل قضا و دلم ضمان فراق",},
new Hafez{ Id= 2483, BeytNo = 10, GhazalNo = 297, Mesra1 = "ز سوز شوق دلم شد کباب دور از يار", Mesra2 = "مدام خون جگر می‌خورم ز خوان فراق",},
new Hafez{ Id= 2484, BeytNo = 11, GhazalNo = 297, Mesra1 = "فلک چو ديد سرم را اسير چنبر عشق", Mesra2 = "ببست گردن صبرم به ريسمان فراق",},
new Hafez{ Id= 2485, BeytNo = 12, GhazalNo = 297, Mesra1 = "به پای شوق گر اين ره به سر شدی حافظ", Mesra2 = "به دست هجر ندادی کسی عنان فراق",},
new Hafez{ Id= 2486, BeytNo = 1, GhazalNo = 298, Mesra1 = "مقام امن و می بی‌غش و رفيق شفيق", Mesra2 = "گرت مدام ميسر شود زهی توفيق",},
new Hafez{ Id= 2487, BeytNo = 2, GhazalNo = 298, Mesra1 = "جهان و کار جهان جمله هيچ بر هيچ است", Mesra2 = "هزار بار من اين نکته کرده‌ام تحقيق",},
new Hafez{ Id= 2488, BeytNo = 3, GhazalNo = 298, Mesra1 = "دريغ و درد که تا اين زمان ندانستم", Mesra2 = "که کيميای سعادت رفيق بود رفيق",},
new Hafez{ Id= 2489, BeytNo = 4, GhazalNo = 298, Mesra1 = "به ممنی رو و فرصت شمر غنيمت وقت", Mesra2 = "که در کمينگه عمرند قاطعان طريق",},
new Hafez{ Id= 2490, BeytNo = 5, GhazalNo = 298, Mesra1 = "بيا که توبه ز لعل نگار و خنده جام", Mesra2 = "حکايتيست که عقلش نمی‌کند تصديق",},
new Hafez{ Id= 2491, BeytNo = 6, GhazalNo = 298, Mesra1 = "اگر چه موی ميانت به چون منی نرسد", Mesra2 = "خوش است خاطرم از فکر اين خيال دقيق",},
new Hafez{ Id= 2492, BeytNo = 7, GhazalNo = 298, Mesra1 = "حلاوتی که تو را در چه زنخدان است", Mesra2 = "به کنه آن نرسد صد هزار فکر عميق",},
new Hafez{ Id= 2493, BeytNo = 8, GhazalNo = 298, Mesra1 = "اگر به رنگ عقيقی شد اشک من چه عجب", Mesra2 = "که مهر خاتم لعل تو هست همچو عقيق",},
new Hafez{ Id= 2494, BeytNo = 9, GhazalNo = 298, Mesra1 = "به خنده گفت که حافظ غلام طبع توام", Mesra2 = "ببين که تا به چه حدم همی‌کند تحميق",},
new Hafez{ Id= 2495, BeytNo = 1, GhazalNo = 299, Mesra1 = "اگر شراب خوری جرعه‌ای فشان بر خاک", Mesra2 = "از آن گناه که نفعی رسد به غير چه باک",},
new Hafez{ Id= 2496, BeytNo = 2, GhazalNo = 299, Mesra1 = "برو به هر چه تو داری بخور دريغ مخور", Mesra2 = "که بی‌دريغ زند روزگار تيغ هلاک",},
new Hafez{ Id= 2497, BeytNo = 3, GhazalNo = 299, Mesra1 = "به خاک پای تو ای سرو نازپرور من", Mesra2 = "که روز واقعه پا وامگيرم از سر خاک",},
new Hafez{ Id= 2498, BeytNo = 4, GhazalNo = 299, Mesra1 = "چه دوزخی چه بهشتی چه آدمی چه پری", Mesra2 = "به مذهب همه کفر طريقت است امساک",},
new Hafez{ Id= 2499, BeytNo = 5, GhazalNo = 299, Mesra1 = "مهندس فلکی راه دير شش جهتی", Mesra2 = "چنان ببست که ره نيست زير دير مغاک",},
new Hafez{ Id= 2500, BeytNo = 6, GhazalNo = 299, Mesra1 = "فريب دختر رز طرفه می‌زند ره عقل", Mesra2 = "مباد تا به قيامت خراب طارم تاک",},
new Hafez{ Id= 2501, BeytNo = 7, GhazalNo = 299, Mesra1 = "به راه ميکده حافظ خوش از جهان رفتی", Mesra2 = "دعای اهل دلت باد مونس دل پاک",},
new Hafez{ Id= 2502, BeytNo = 1, GhazalNo = 300, Mesra1 = "هزار دشمنم ار می‌کنند قصد هلاک", Mesra2 = "گرم تو دوستی از دشمنان ندارم باک",},
new Hafez{ Id= 2503, BeytNo = 2, GhazalNo = 300, Mesra1 = "مرا اميد وصال تو زنده می‌دارد", Mesra2 = "و گر نه هر دمم از هجر توست بيم هلاک",},
new Hafez{ Id= 2504, BeytNo = 3, GhazalNo = 300, Mesra1 = "نفس نفس اگر از باد نشنوم بويش", Mesra2 = "زمان زمان چو گل از غم کنم گريبان چاک",},
new Hafez{ Id= 2505, BeytNo = 4, GhazalNo = 300, Mesra1 = "رود به خواب دو چشم از خيال تو هيهات", Mesra2 = "بود صبور دل اندر فراق تو حاشاک",},
new Hafez{ Id= 2506, BeytNo = 5, GhazalNo = 300, Mesra1 = "اگر تو زخم زنی به که ديگری مرهم", Mesra2 = "و گر تو زهر دهی به که ديگری ترياک",},
new Hafez{ Id= 2507, BeytNo = 6, GhazalNo = 300, Mesra1 = "بضرب سيفک قتلی حياتنا ابدا", Mesra2 = "لان روحی قد طاب ان يکون فداک",},
new Hafez{ Id= 2508, BeytNo = 7, GhazalNo = 300, Mesra1 = "عنان مپيچ که گر می‌زنی به شمشيرم", Mesra2 = "سپر کنم سر و دستت ندارم از فتراک",},
new Hafez{ Id= 2509, BeytNo = 8, GhazalNo = 300, Mesra1 = "تو را چنان که تويی هر نظر کجا بيند", Mesra2 = "به قدر دانش خود هر کسی کند ادراک",},
new Hafez{ Id= 2510, BeytNo = 9, GhazalNo = 300, Mesra1 = "به چشم خلق عزيز جهان شود حافظ", Mesra2 = "که بر در تو نهد روی مسکنت بر خاک",},
new Hafez{ Id= 2511, BeytNo = 1, GhazalNo = 301, Mesra1 = "ای دل ريش مرا با لب تو حق نمک", Mesra2 = "حق نگه دار که من می‌روم الله معک",},
new Hafez{ Id= 2512, BeytNo = 2, GhazalNo = 301, Mesra1 = "تويی آن گوهر پاکيزه که در عالم قدس", Mesra2 = "ذکر خير تو بود حاصل تسبيح ملک",},
new Hafez{ Id= 2513, BeytNo = 3, GhazalNo = 301, Mesra1 = "در خلوص منت ار هست شکی تجربه کن", Mesra2 = "کس عيار زر خالص نشناسد چو محک",},
new Hafez{ Id= 2514, BeytNo = 4, GhazalNo = 301, Mesra1 = "گفته بودی که شوم مست و دو بوست بدهم", Mesra2 = "وعده از حد بشد و ما نه دو ديديم و نه يک",},
new Hafez{ Id= 2515, BeytNo = 5, GhazalNo = 301, Mesra1 = "بگشا پسته خندان و شکرريزی کن", Mesra2 = "خلق را از دهن خويش مينداز به شک",},
new Hafez{ Id= 2516, BeytNo = 6, GhazalNo = 301, Mesra1 = "چرخ برهم زنم ار غير مرادم گردد", Mesra2 = "من نه آنم که زبونی کشم از چرخ فلک",},
new Hafez{ Id= 2517, BeytNo = 7, GhazalNo = 301, Mesra1 = "چون بر حافظ خويشش نگذاری باری", Mesra2 = "ای رقيب از بر او يک دو قدم دورترک",},
new Hafez{ Id= 2518, BeytNo = 1, GhazalNo = 302, Mesra1 = "خوش خبر باشی ای نسيم شمال", Mesra2 = "که به ما می‌رسد زمان وصال",},
new Hafez{ Id= 2519, BeytNo = 2, GhazalNo = 302, Mesra1 = "قصه العشق لا انفصام لها", Mesra2 = "فصمت‌ها هنا لسان القال",},
new Hafez{ Id= 2520, BeytNo = 3, GhazalNo = 302, Mesra1 = "مالسلمی و من بذی سلم", Mesra2 = "اين جيراننا و کيف الحال",},
new Hafez{ Id= 2521, BeytNo = 4, GhazalNo = 302, Mesra1 = "عفت الدار بعد عافيه", Mesra2 = "فاسالوا حالها عن الاطلال",},
new Hafez{ Id= 2522, BeytNo = 5, GhazalNo = 302, Mesra1 = "فی جمال الکمال نلت منی", Mesra2 = "صرف الله عنک عين کمال",},
new Hafez{ Id= 2523, BeytNo = 6, GhazalNo = 302, Mesra1 = "يا بريد الحمی حماک الله", Mesra2 = "مرحبا مرحبا تعال تعال",},
new Hafez{ Id= 2524, BeytNo = 7, GhazalNo = 302, Mesra1 = "عرصه بزمگاه خالی ماند", Mesra2 = "از حريفان و جام مالامال",},
new Hafez{ Id= 2525, BeytNo = 8, GhazalNo = 302, Mesra1 = "سايه افکند حاليا شب هجر", Mesra2 = "تا چه بازند شب روان خيال",},
new Hafez{ Id= 2526, BeytNo = 9, GhazalNo = 302, Mesra1 = "ترک ما سوی کس نمی‌نگرد", Mesra2 = "آه از اين کبريا و جاه و جلال",},
new Hafez{ Id= 2527, BeytNo = 10, GhazalNo = 302, Mesra1 = "حافظا عشق و صابری تا چند", Mesra2 = "ناله عاشقان خوش است بنال",},
new Hafez{ Id= 2528, BeytNo = 1, GhazalNo = 303, Mesra1 = "شممت روح وداد و شمت برق وصال", Mesra2 = "بيا که بوی تو را ميرم ای نسيم شمال",},
new Hafez{ Id= 2529, BeytNo = 2, GhazalNo = 303, Mesra1 = "احاديا بجمال الحبيب قف و انزل", Mesra2 = "که نيست صبر جميلم ز اشتياق جمال",},
new Hafez{ Id= 2530, BeytNo = 3, GhazalNo = 303, Mesra1 = "حکايت شب هجران فروگذاشته به", Mesra2 = "به شکر آن که برافکند پرده روز وصال",},
new Hafez{ Id= 2531, BeytNo = 4, GhazalNo = 303, Mesra1 = "بيا که پرده گلريز هفت خانه چشم", Mesra2 = "کشيده‌ايم به تحرير کارگاه خيال",},
new Hafez{ Id= 2532, BeytNo = 5, GhazalNo = 303, Mesra1 = "چو يار بر سر صلح است و عذر می‌طلبد", Mesra2 = "توان گذشت ز جور رقيب در همه حال",},
new Hafez{ Id= 2533, BeytNo = 6, GhazalNo = 303, Mesra1 = "بجز خيال دهان تو نيست در دل تنگ", Mesra2 = "که کس مباد چو من در پی خيال محال",},
new Hafez{ Id= 2534, BeytNo = 7, GhazalNo = 303, Mesra1 = "قتيل عشق تو شد حافظ غريب ولی", Mesra2 = "به خاک ما گذری کن که خون مات حلال",},
new Hafez{ Id= 2535, BeytNo = 1, GhazalNo = 304, Mesra1 = "دارای جهان نصرت دين خسرو کامل", Mesra2 = "يحيی بن مظفر ملک عالم عادل",},
new Hafez{ Id= 2536, BeytNo = 2, GhazalNo = 304, Mesra1 = "ای درگه اسلام پناه تو گشاده", Mesra2 = "بر روی زمين روزنه جان و در دل",},
new Hafez{ Id= 2537, BeytNo = 3, GhazalNo = 304, Mesra1 = "تعظيم تو بر جان و خرد واجب و لازم", Mesra2 = "انعام تو بر کون و مکان فايض و شامل",},
new Hafez{ Id= 2538, BeytNo = 4, GhazalNo = 304, Mesra1 = "روز ازل از کلک تو يک قطره سياهی", Mesra2 = "بر روی مه افتاد که شد حل مسال",},
new Hafez{ Id= 2539, BeytNo = 5, GhazalNo = 304, Mesra1 = "خورشيد چو آن خال سيه ديد به دل گفت", Mesra2 = "ای کاج که من بودمی آن هندوی مقبل",},
new Hafez{ Id= 2540, BeytNo = 6, GhazalNo = 304, Mesra1 = "شاها فلک از بزم تو در رقص و سماع است", Mesra2 = "دست طرب از دامن اين زمزمه مگسل",},
new Hafez{ Id= 2541, BeytNo = 7, GhazalNo = 304, Mesra1 = "می نوش و جهان بخش که از زلف کمندت", Mesra2 = "شد گردن بدخواه گرفتار سلاسل",},
new Hafez{ Id= 2542, BeytNo = 8, GhazalNo = 304, Mesra1 = "دور فلکی يک سره بر منهج عدل است", Mesra2 = "خوش باش که ظالم نبرد راه به منزل",},
new Hafez{ Id= 2543, BeytNo = 9, GhazalNo = 304, Mesra1 = "حافظ قلم شاه جهان مقسم رزق است", Mesra2 = "از بهر معيشت مکن انديشه باطل",},
new Hafez{ Id= 2544, BeytNo = 1, GhazalNo = 305, Mesra1 = "به وقت گل شدم از توبه شراب خجل", Mesra2 = "که کس مباد ز کردار ناصواب خجل",},
new Hafez{ Id= 2545, BeytNo = 2, GhazalNo = 305, Mesra1 = "صلاح ما همه دام ره است و من زين بحث", Mesra2 = "نيم ز شاهد و ساقی به هيچ باب خجل",},
new Hafez{ Id= 2546, BeytNo = 3, GhazalNo = 305, Mesra1 = "بود که يار نرنجد ز ما به خلق کريم", Mesra2 = "که از سال ملوليم و از جواب خجل",},
new Hafez{ Id= 2547, BeytNo = 4, GhazalNo = 305, Mesra1 = "ز خون که رفت شب دوش از سراچه چشم", Mesra2 = "شديم در نظر ره روان خواب خجل",},
new Hafez{ Id= 2548, BeytNo = 5, GhazalNo = 305, Mesra1 = "رواست نرگس مست ار فکند سر در پيش", Mesra2 = "که شد ز شيوه آن چشم پرعتاب خجل",},
new Hafez{ Id= 2549, BeytNo = 6, GhazalNo = 305, Mesra1 = "تويی که خوبتری ز آفتاب و شکر خدا", Mesra2 = "که نيستم ز تو در روی آفتاب خجل",},
new Hafez{ Id= 2550, BeytNo = 7, GhazalNo = 305, Mesra1 = "حجاب ظلمت از آن بست آب خضر که گشت", Mesra2 = "ز شعر حافظ و آن طبع همچو آب خجل",},
new Hafez{ Id= 2551, BeytNo = 1, GhazalNo = 306, Mesra1 = "اگر به کوی تو باشد مرا مجال وصول", Mesra2 = "رسد به دولت وصل تو کار من به اصول",},
new Hafez{ Id= 2552, BeytNo = 2, GhazalNo = 306, Mesra1 = "قرار برده ز من آن دو نرگس رعنا", Mesra2 = "فراغ برده ز من آن دو جادوی مکحول",},
new Hafez{ Id= 2553, BeytNo = 3, GhazalNo = 306, Mesra1 = "چو بر در تو من بی‌نوای بی زر و زور", Mesra2 = "به هيچ باب ندارم ره خروج و دخول",},
new Hafez{ Id= 2554, BeytNo = 4, GhazalNo = 306, Mesra1 = "کجا روم چه کنم چاره از کجا جويم", Mesra2 = "که گشته‌ام ز غم و جور روزگار ملول",},
new Hafez{ Id= 2555, BeytNo = 5, GhazalNo = 306, Mesra1 = "من شکسته بدحال زندگی يابم", Mesra2 = "در آن زمان که به تيغ غمت شوم مقتول",},
new Hafez{ Id= 2556, BeytNo = 6, GhazalNo = 306, Mesra1 = "خرابتر ز دل من غم تو جای نيافت", Mesra2 = "که ساخت در دل تنگم قرارگاه نزول",},
new Hafez{ Id= 2557, BeytNo = 7, GhazalNo = 306, Mesra1 = "دل از جواهر مهرت چو صيقلی دارد", Mesra2 = "بود ز زنگ حوادث هر آينه مصقول",},
new Hafez{ Id= 2558, BeytNo = 8, GhazalNo = 306, Mesra1 = "چه جرم کرده‌ام ای جان و دل به حضرت تو", Mesra2 = "که طاعت من بی‌دل نمی‌شود مقبول",},
new Hafez{ Id= 2559, BeytNo = 9, GhazalNo = 306, Mesra1 = "به درد عشق بساز و خموش کن حافظ", Mesra2 = "رموز عشق مکن فاش پيش اهل عقول",},
new Hafez{ Id= 2560, BeytNo = 1, GhazalNo = 307, Mesra1 = "هر نکته‌ای که گفتم در وصف آن شمايل", Mesra2 = "هر کو شنيد گفتا لله در قال",},
new Hafez{ Id= 2561, BeytNo = 2, GhazalNo = 307, Mesra1 = "تحصيل عشق و رندی آسان نمود اول", Mesra2 = "آخر بسوخت جانم در کسب اين فضايل",},
new Hafez{ Id= 2562, BeytNo = 3, GhazalNo = 307, Mesra1 = "حلاج بر سر دار اين نکته خوش سرايد", Mesra2 = "از شافعی نپرسند امثال اين مسال",},
new Hafez{ Id= 2563, BeytNo = 4, GhazalNo = 307, Mesra1 = "گفتم که کی ببخشی بر جان ناتوانم", Mesra2 = "گفت آن زمان که نبود جان در ميانه حال",},
new Hafez{ Id= 2564, BeytNo = 5, GhazalNo = 307, Mesra1 = "دل داده‌ام به ياری شوخی کشی نگاری", Mesra2 = "مرضيه السجايا محموده الخصال",},
new Hafez{ Id= 2565, BeytNo = 6, GhazalNo = 307, Mesra1 = "در عين گوشه گيری بودم چو چشم مستت", Mesra2 = "و اکنون شدم به مستان چون ابروی تو مايل",},
new Hafez{ Id= 2566, BeytNo = 7, GhazalNo = 307, Mesra1 = "از آب ديده صد ره طوفان نوح ديدم", Mesra2 = "و از لوح سينه نقشت هرگز نگشت زايل",},
new Hafez{ Id= 2567, BeytNo = 8, GhazalNo = 307, Mesra1 = "ای دوست دست حافظ تعويذ چشم زخم است", Mesra2 = "يا رب ببينم آن را در گردنت حمايل",},
new Hafez{ Id= 2568, BeytNo = 1, GhazalNo = 308, Mesra1 = "ای رخت چون خلد و لعلت سلسبيل", Mesra2 = "سلسبيلت کرده جان و دل سبيل",},
new Hafez{ Id= 2569, BeytNo = 2, GhazalNo = 308, Mesra1 = "سبزپوشان خطت بر گرد لب", Mesra2 = "همچو مورانند گرد سلسبيل",},
new Hafez{ Id= 2570, BeytNo = 3, GhazalNo = 308, Mesra1 = "ناوک چشم تو در هر گوشه‌ای", Mesra2 = "همچو من افتاده دارد صد قتيل",},
new Hafez{ Id= 2571, BeytNo = 4, GhazalNo = 308, Mesra1 = "يا رب اين آتش که در جان من است", Mesra2 = "سرد کن زان سان که کردی بر خليل",},
new Hafez{ Id= 2572, BeytNo = 5, GhazalNo = 308, Mesra1 = "من نمی‌يابم مجال ای دوستان", Mesra2 = "گر چه دارد او جمالی بس جميل",},
new Hafez{ Id= 2573, BeytNo = 6, GhazalNo = 308, Mesra1 = "پای ما لنگ است و منزل بس دراز", Mesra2 = "دست ما کوتاه و خرما بر نخيل",},
new Hafez{ Id= 2574, BeytNo = 7, GhazalNo = 308, Mesra1 = "حافظ از سرپنجه عشق نگار", Mesra2 = "همچو مور افتاده شد در پای پيل",},
new Hafez{ Id= 2575, BeytNo = 8, GhazalNo = 308, Mesra1 = "شاه عالم را بقا و عز و ناز", Mesra2 = "باد و هر چيزی که باشد زين قبيل",},
new Hafez{ Id= 2576, BeytNo = 1, GhazalNo = 309, Mesra1 = "عشقبازی و جوانی و شراب لعل فام", Mesra2 = "مجلس انس و حريف همدم و شرب مدام",},
new Hafez{ Id= 2577, BeytNo = 2, GhazalNo = 309, Mesra1 = "ساقی شکردهان و مطرب شيرين سخن", Mesra2 = "همنشينی نيک کردار و نديمی نيک نام",},
new Hafez{ Id= 2578, BeytNo = 3, GhazalNo = 309, Mesra1 = "شاهدی از لطف و پاکی رشک آب زندگی", Mesra2 = "دلبری در حسن و خوبی غيرت ماه تمام",},
new Hafez{ Id= 2579, BeytNo = 4, GhazalNo = 309, Mesra1 = "بزمگاهی دل نشان چون قصر فردوس برين", Mesra2 = "گلشنی پيرامنش چون روضه دارالسلام",},
new Hafez{ Id= 2580, BeytNo = 5, GhazalNo = 309, Mesra1 = "صف نشينان نيکخواه و پيشکاران باادب", Mesra2 = "دوستداران صاحب اسرار و حريفان دوستکام",},
new Hafez{ Id= 2581, BeytNo = 6, GhazalNo = 309, Mesra1 = "باده گلرنگ تلخ تيز خوش خوار سبک", Mesra2 = "نقلش از لعل نگار و نقلش از ياقوت خام",},
new Hafez{ Id= 2582, BeytNo = 7, GhazalNo = 309, Mesra1 = "غمزه ساقی به يغمای خرد آهخته تيغ", Mesra2 = "زلف جانان از برای صيد دل گسترده دام",},
new Hafez{ Id= 2583, BeytNo = 8, GhazalNo = 309, Mesra1 = "نکته دانی بذله گو چون حافظ شيرين سخن", Mesra2 = "بخشش آموزی جهان افروز چون حاجی قوام",},
new Hafez{ Id= 2584, BeytNo = 9, GhazalNo = 309, Mesra1 = "هر که اين عشرت نخواهد خوشدلی بر وی تباه", Mesra2 = "وان که اين مجلس نجويد زندگی بر وی حرام",},
new Hafez{ Id= 2585, BeytNo = 1, GhazalNo = 310, Mesra1 = "مرحبا طاير فرخ پی فرخنده پيام", Mesra2 = "خير مقدم چه خبر دوست کجا راه کدام",},
new Hafez{ Id= 2586, BeytNo = 2, GhazalNo = 310, Mesra1 = "يا رب اين قافله را لطف ازل بدرقه باد", Mesra2 = "که از او خصم به دام آمد و معشوقه به کام",},
new Hafez{ Id= 2587, BeytNo = 3, GhazalNo = 310, Mesra1 = "ماجرای من و معشوق مرا پايان نيست", Mesra2 = "هر چه آغاز ندارد نپذيرد انجام",},
new Hafez{ Id= 2588, BeytNo = 4, GhazalNo = 310, Mesra1 = "گل ز حد برد تنعم نفسی رخ بنما", Mesra2 = "سرو می‌نازد و خوش نيست خدا را بخرام",},
new Hafez{ Id= 2589, BeytNo = 5, GhazalNo = 310, Mesra1 = "زلف دلدار چو زنار همی‌فرمايد", Mesra2 = "برو ای شيخ که شد بر تن ما خرقه حرام",},
new Hafez{ Id= 2590, BeytNo = 6, GhazalNo = 310, Mesra1 = "مرغ روحم که همی‌زد ز سر سدره صفير", Mesra2 = "عاقبت دانه خال تو فکندش در دام",},
new Hafez{ Id= 2591, BeytNo = 7, GhazalNo = 310, Mesra1 = "چشم بيمار مرا خواب نه درخور باشد", Mesra2 = "من له يقتل داY دنف کيف ينام",},
new Hafez{ Id= 2592, BeytNo = 8, GhazalNo = 310, Mesra1 = "تو ترحم نکنی بر من مخلص گفتم", Mesra2 = "ذاک دعوای و ها انت و تلک الايام",},
new Hafez{ Id= 2593, BeytNo = 9, GhazalNo = 310, Mesra1 = "حافظ ار ميل به ابروی تو دارد شايد", Mesra2 = "جای در گوشه محراب کنند اهل کلام",},
new Hafez{ Id= 2594, BeytNo = 1, GhazalNo = 311, Mesra1 = "عاشق روی جوانی خوش نوخاسته‌ام", Mesra2 = "و از خدا دولت اين غم به دعا خواسته‌ام",},
new Hafez{ Id= 2595, BeytNo = 2, GhazalNo = 311, Mesra1 = "عاشق و رند و نظربازم و می‌گويم فاش", Mesra2 = "تا بدانی که به چندين هنر آراسته‌ام",},
new Hafez{ Id= 2596, BeytNo = 3, GhazalNo = 311, Mesra1 = "شرمم از خرقه آلوده خود می‌آيد", Mesra2 = "که بر او وصله به صد شعبده پيراسته‌ام",},
new Hafez{ Id= 2597, BeytNo = 4, GhazalNo = 311, Mesra1 = "خوش بسوز از غمش ای شمع که اينک من نيز", Mesra2 = "هم بدين کار کمربسته و برخاسته‌ام",},
new Hafez{ Id= 2598, BeytNo = 5, GhazalNo = 311, Mesra1 = "با چنين حيرتم از دست بشد صرفه کار", Mesra2 = "در غم افزوده‌ام آنچ از دل و جان کاسته‌ام",},
new Hafez{ Id= 2599, BeytNo = 6, GhazalNo = 311, Mesra1 = "همچو حافظ به خرابات روم جامه قبا", Mesra2 = "بو که در بر کشد آن دلبر نوخاسته‌ام",},
new Hafez{ Id= 2600, BeytNo = 1, GhazalNo = 312, Mesra1 = "بشری اذ السلامه حلت بذی سلم", Mesra2 = "لله حمد معترف غايه النعم",},
new Hafez{ Id= 2601, BeytNo = 2, GhazalNo = 312, Mesra1 = "آن خوش خبر کجاست که اين فتح مژده داد", Mesra2 = "تا جان فشانمش چو زر و سيم در قدم",},
new Hafez{ Id= 2602, BeytNo = 3, GhazalNo = 312, Mesra1 = "از بازگشت شاه در اين طرفه منزل است", Mesra2 = "آهنگ خصم او به سراپرده عدم",},
new Hafez{ Id= 2603, BeytNo = 4, GhazalNo = 312, Mesra1 = "پيمان شکن هرآينه گردد شکسته حال", Mesra2 = "ان العهود عند مليک النهی ذمم",},
new Hafez{ Id= 2604, BeytNo = 5, GhazalNo = 312, Mesra1 = "می‌جست از سحاب امل رحمتی ولی", Mesra2 = "جز ديده‌اش معاينه بيرون نداد نم",},
new Hafez{ Id= 2605, BeytNo = 6, GhazalNo = 312, Mesra1 = "در نيل غم فتاد سپهرش به طنز گفت", Mesra2 = "ان قد ندمت و ما ينفع الندم",},
new Hafez{ Id= 2606, BeytNo = 7, GhazalNo = 312, Mesra1 = "ساقی چو يار مه رخ و از اهل راز بود", Mesra2 = "حافظ بخورد باده و شيخ و فقيه هم",},
new Hafez{ Id= 2607, BeytNo = 1, GhazalNo = 313, Mesra1 = "بازآی ساقيا که هواخواه خدمتم", Mesra2 = "مشتاق بندگی و دعاگوی دولتم",},
new Hafez{ Id= 2608, BeytNo = 2, GhazalNo = 313, Mesra1 = "زان جا که فيض جام سعادت فروغ توست", Mesra2 = "بيرون شدی نمای ز ظلمات حيرتم",},
new Hafez{ Id= 2609, BeytNo = 3, GhazalNo = 313, Mesra1 = "هر چند غرق بحر گناهم ز صد جهت", Mesra2 = "تا آشنای عشق شدم ز اهل رحمتم",},
new Hafez{ Id= 2610, BeytNo = 4, GhazalNo = 313, Mesra1 = "عيبم مکن به رندی و بدنامی ای حکيم", Mesra2 = "کاين بود سرنوشت ز ديوان قسمتم",},
new Hafez{ Id= 2611, BeytNo = 5, GhazalNo = 313, Mesra1 = "می خور که عاشقی نه به کسب است و اختيار", Mesra2 = "اين موهبت رسيد ز ميراث فطرتم",},
new Hafez{ Id= 2612, BeytNo = 6, GhazalNo = 313, Mesra1 = "من کز وطن سفر نگزيدم به عمر خويش", Mesra2 = "در عشق ديدن تو هواخواه غربتم",},
new Hafez{ Id= 2613, BeytNo = 7, GhazalNo = 313, Mesra1 = "دريا و کوه در ره و من خسته و ضعيف", Mesra2 = "ای خضر پی خجسته مدد کن به همتم",},
new Hafez{ Id= 2614, BeytNo = 8, GhazalNo = 313, Mesra1 = "دورم به صورت از در دولتسرای تو", Mesra2 = "ليکن به جان و دل ز مقيمان حضرتم",},
new Hafez{ Id= 2615, BeytNo = 9, GhazalNo = 313, Mesra1 = "حافظ به پيش چشم تو خواهد سپرد جان", Mesra2 = "در اين خيالم ار بدهد عمر مهلتم",},
new Hafez{ Id= 2616, BeytNo = 1, GhazalNo = 314, Mesra1 = "دوش بيماری چشم تو ببرد از دستم", Mesra2 = "ليکن از لطف لبت صورت جان می‌بستم",},
new Hafez{ Id= 2617, BeytNo = 2, GhazalNo = 314, Mesra1 = "عشق من با خط مشکين تو امروزی نيست", Mesra2 = "ديرگاه است کز اين جام هلالی مستم",},
new Hafez{ Id= 2618, BeytNo = 3, GhazalNo = 314, Mesra1 = "از ثبات خودم اين نکته خوش آمد که به جور", Mesra2 = "در سر کوی تو از پای طلب ننشستم",},
new Hafez{ Id= 2619, BeytNo = 4, GhazalNo = 314, Mesra1 = "عافيت چشم مدار از من ميخانه نشين", Mesra2 = "که دم از خدمت رندان زده‌ام تا هستم",},
new Hafez{ Id= 2620, BeytNo = 5, GhazalNo = 314, Mesra1 = "در ره عشق از آن سوی فنا صد خطر است", Mesra2 = "تا نگويی که چو عمرم به سر آمد رستم",},
new Hafez{ Id= 2621, BeytNo = 6, GhazalNo = 314, Mesra1 = "بعد از اينم چه غم از تير کج انداز حسود", Mesra2 = "چون به محبوب کمان ابروی خود پيوستم",},
new Hafez{ Id= 2622, BeytNo = 7, GhazalNo = 314, Mesra1 = "بوسه بر درج عقيق تو حلال است مرا", Mesra2 = "که به افسوس و جفا مهر وفا نشکستم",},
new Hafez{ Id= 2623, BeytNo = 8, GhazalNo = 314, Mesra1 = "صنمی لشکريم غارت دل کرد و برفت", Mesra2 = "آه اگر عاطفت شاه نگيرد دستم",},
new Hafez{ Id= 2624, BeytNo = 9, GhazalNo = 314, Mesra1 = "رتبت دانش حافظ به فلک برشده بود", Mesra2 = "کرد غمخواری شمشاد بلندت پستم",},
new Hafez{ Id= 2625, BeytNo = 1, GhazalNo = 315, Mesra1 = "به غير از آن که بشد دين و دانش از دستم", Mesra2 = "بيا بگو که ز عشقت چه طرف بربستم",},
new Hafez{ Id= 2626, BeytNo = 2, GhazalNo = 315, Mesra1 = "اگر چه خرمن عمرم غم تو داد به باد", Mesra2 = "به خاک پای عزيزت که عهد نشکستم",},
new Hafez{ Id= 2627, BeytNo = 3, GhazalNo = 315, Mesra1 = "چو ذره گر چه حقيرم ببين به دولت عشق", Mesra2 = "که در هوای رخت چون به مهر پيوستم",},
new Hafez{ Id= 2628, BeytNo = 4, GhazalNo = 315, Mesra1 = "بيار باده که عمريست تا من از سر امن", Mesra2 = "به کنج عافيت از بهر عيش ننشستم",},
new Hafez{ Id= 2629, BeytNo = 5, GhazalNo = 315, Mesra1 = "اگر ز مردم هشياری ای نصيحتگو", Mesra2 = "سخن به خاک ميفکن چرا که من مستم",},
new Hafez{ Id= 2630, BeytNo = 6, GhazalNo = 315, Mesra1 = "چگونه سر ز خجالت برآورم بر دوست", Mesra2 = "که خدمتی به سزا برنيامد از دستم",},
new Hafez{ Id= 2631, BeytNo = 7, GhazalNo = 315, Mesra1 = "بسوخت حافظ و آن يار دلنواز نگفت", Mesra2 = "که مرهمی بفرستم که خاطرش خستم",},
new Hafez{ Id= 2632, BeytNo = 1, GhazalNo = 316, Mesra1 = "زلف بر باد مده تا ندهی بر بادم", Mesra2 = "ناز بنياد مکن تا نکنی بنيادم",},
new Hafez{ Id= 2633, BeytNo = 2, GhazalNo = 316, Mesra1 = "می مخور با همه کس تا نخورم خون جگر", Mesra2 = "سر مکش تا نکشد سر به فلک فريادم",},
new Hafez{ Id= 2634, BeytNo = 3, GhazalNo = 316, Mesra1 = "زلف را حلقه مکن تا نکنی دربندم", Mesra2 = "طره را تاب مده تا ندهی بر بادم",},
new Hafez{ Id= 2635, BeytNo = 4, GhazalNo = 316, Mesra1 = "يار بيگانه مشو تا نبری از خويشم", Mesra2 = "غم اغيار مخور تا نکنی ناشادم",},
new Hafez{ Id= 2636, BeytNo = 5, GhazalNo = 316, Mesra1 = "رخ برافروز که فارغ کنی از برگ گلم", Mesra2 = "قد برافراز که از سرو کنی آزادم",},
new Hafez{ Id= 2637, BeytNo = 6, GhazalNo = 316, Mesra1 = "شمع هر جمع مشو ور نه بسوزی ما را", Mesra2 = "ياد هر قوم مکن تا نروی از يادم",},
new Hafez{ Id= 2638, BeytNo = 7, GhazalNo = 316, Mesra1 = "شهره شهر مشو تا ننهم سر در کوه", Mesra2 = "شور شيرين منما تا نکنی فرهادم",},
new Hafez{ Id= 2639, BeytNo = 8, GhazalNo = 316, Mesra1 = "رحم کن بر من مسکين و به فريادم رس", Mesra2 = "تا به خاک در آصف نرسد فريادم",},
new Hafez{ Id= 2640, BeytNo = 9, GhazalNo = 316, Mesra1 = "حافظ از جور تو حاشا که بگرداند روی", Mesra2 = "من از آن روز که دربند توام آزادم",},
new Hafez{ Id= 2641, BeytNo = 1, GhazalNo = 317, Mesra1 = "فاش می‌گويم و از گفته خود دلشادم", Mesra2 = "بنده عشقم و از هر دو جهان آزادم",},
new Hafez{ Id= 2642, BeytNo = 2, GhazalNo = 317, Mesra1 = "طاير گلشن قدسم چه دهم شرح فراق", Mesra2 = "که در اين دامگه حادثه چون افتادم",},
new Hafez{ Id= 2643, BeytNo = 3, GhazalNo = 317, Mesra1 = "من ملک بودم و فردوس برين جايم بود", Mesra2 = "آدم آورد در اين دير خراب آبادم",},
new Hafez{ Id= 2644, BeytNo = 4, GhazalNo = 317, Mesra1 = "سايه طوبی و دلجويی حور و لب حوض", Mesra2 = "به هوای سر کوی تو برفت از يادم",},
new Hafez{ Id= 2645, BeytNo = 5, GhazalNo = 317, Mesra1 = "نيست بر لوح دلم جز الف قامت دوست", Mesra2 = "چه کنم حرف دگر ياد نداد استادم",},
new Hafez{ Id= 2646, BeytNo = 6, GhazalNo = 317, Mesra1 = "کوکب بخت مرا هيچ منجم نشناخت", Mesra2 = "يا رب از مادر گيتی به چه طالع زادم",},
new Hafez{ Id= 2647, BeytNo = 7, GhazalNo = 317, Mesra1 = "تا شدم حلقه به گوش در ميخانه عشق", Mesra2 = "هر دم آيد غمی از نو به مبارک بادم",},
new Hafez{ Id= 2648, BeytNo = 8, GhazalNo = 317, Mesra1 = "می خورد خون دلم مردمک ديده سزاست", Mesra2 = "که چرا دل به جگرگوشه مردم دادم",},
new Hafez{ Id= 2649, BeytNo = 9, GhazalNo = 317, Mesra1 = "پاک کن چهره حافظ به سر زلف ز اشک", Mesra2 = "ور نه اين سيل دمادم ببرد بنيادم",},
new Hafez{ Id= 2650, BeytNo = 1, GhazalNo = 318, Mesra1 = "مرا می‌بينی و هر دم زيادت می‌کنی دردم", Mesra2 = "تو را می‌بينم و ميلم زيادت می‌شود هر دم",},
new Hafez{ Id= 2651, BeytNo = 2, GhazalNo = 318, Mesra1 = "به سامانم نمی‌پرسی نمی‌دانم چه سر داری", Mesra2 = "به درمانم نمی‌کوشی نمی‌دانی مگر دردم",},
new Hafez{ Id= 2652, BeytNo = 3, GhazalNo = 318, Mesra1 = "نه راه است اين که بگذاری مرا بر خاک و بگريزی", Mesra2 = "گذاری آر و بازم پرس تا خاک رهت گردم",},
new Hafez{ Id= 2653, BeytNo = 4, GhazalNo = 318, Mesra1 = "ندارم دستت از دامن بجز در خاک و آن دم هم", Mesra2 = "که بر خاکم روان گردی به گرد دامنت گردم",},
new Hafez{ Id= 2654, BeytNo = 5, GhazalNo = 318, Mesra1 = "فرورفت از غم عشقت دمم دم می‌دهی تا کی", Mesra2 = "دمار از من برآوردی نمی‌گويی برآوردم",},
new Hafez{ Id= 2655, BeytNo = 6, GhazalNo = 318, Mesra1 = "شبی دل را به تاريکی ز زلفت باز می‌جستم", Mesra2 = "رخت می‌ديدم و جامی هلالی باز می‌خوردم",},
new Hafez{ Id= 2656, BeytNo = 7, GhazalNo = 318, Mesra1 = "کشيدم در برت ناگاه و شد در تاب گيسويت", Mesra2 = "نهادم بر لبت لب را و جان و دل فدا کردم",},
new Hafez{ Id= 2657, BeytNo = 8, GhazalNo = 318, Mesra1 = "تو خوش می‌باش با حافظ برو گو خصم جان می‌ده", Mesra2 = "چو گرمی از تو می‌بينم چه باک از خصم دم سردم",},
new Hafez{ Id= 2658, BeytNo = 1, GhazalNo = 319, Mesra1 = "سال‌ها پيروی مذهب رندان کردم", Mesra2 = "تا به فتوی خرد حرص به زندان کردم",},
new Hafez{ Id= 2659, BeytNo = 2, GhazalNo = 319, Mesra1 = "من به سرمنزل عنقا نه به خود بردم راه", Mesra2 = "قطع اين مرحله با مرغ سليمان کردم",},
new Hafez{ Id= 2660, BeytNo = 3, GhazalNo = 319, Mesra1 = "سايه‌ای بر دل ريشم فکن ای گنج روان", Mesra2 = "که من اين خانه به سودای تو ويران کردم",},
new Hafez{ Id= 2661, BeytNo = 4, GhazalNo = 319, Mesra1 = "توبه کردم که نبوسم لب ساقی و کنون", Mesra2 = "می‌گزم لب که چرا گوش به نادان کردم",},
new Hafez{ Id= 2662, BeytNo = 5, GhazalNo = 319, Mesra1 = "در خلاف آمد عادت بطلب کام که من", Mesra2 = "کسب جمعيت از آن زلف پريشان کردم",},
new Hafez{ Id= 2663, BeytNo = 6, GhazalNo = 319, Mesra1 = "نقش مستوری و مستی نه به دست من و توست", Mesra2 = "آن چه سلطان ازل گفت بکن آن کردم",},
new Hafez{ Id= 2664, BeytNo = 7, GhazalNo = 319, Mesra1 = "دارم از لطف ازل جنت فردوس طمع", Mesra2 = "گر چه دربانی ميخانه فراوان کردم",},
new Hafez{ Id= 2665, BeytNo = 8, GhazalNo = 319, Mesra1 = "اين که پيرانه سرم صحبت يوسف بنواخت", Mesra2 = "اجر صبريست که در کلبه احزان کردم",},
new Hafez{ Id= 2666, BeytNo = 9, GhazalNo = 319, Mesra1 = "صبح خيزی و سلامت طلبی چون حافظ", Mesra2 = "هر چه کردم همه از دولت قرآن کردم",},
new Hafez{ Id= 2667, BeytNo = 10, GhazalNo = 319, Mesra1 = "گر به ديوان غزل صدرنشينم چه عجب", Mesra2 = "سال‌ها بندگی صاحب ديوان کردم",},
new Hafez{ Id= 2668, BeytNo = 1, GhazalNo = 320, Mesra1 = "ديشب به سيل اشک ره خواب می‌زدم", Mesra2 = "نقشی به ياد خط تو بر آب می‌زدم",},
new Hafez{ Id= 2669, BeytNo = 2, GhazalNo = 320, Mesra1 = "ابروی يار در نظر و خرقه سوخته", Mesra2 = "جامی به ياد گوشه محراب می‌زدم",},
new Hafez{ Id= 2670, BeytNo = 3, GhazalNo = 320, Mesra1 = "هر مرغ فکر کز سر شاخ سخن بجست", Mesra2 = "بازش ز طره تو به مضراب می‌زدم",},
new Hafez{ Id= 2671, BeytNo = 4, GhazalNo = 320, Mesra1 = "روی نگار در نظرم جلوه می‌نمود", Mesra2 = "وز دور بوسه بر رخ مهتاب می‌زدم",},
new Hafez{ Id= 2672, BeytNo = 5, GhazalNo = 320, Mesra1 = "چشمم به روی ساقی و گوشم به قول چنگ", Mesra2 = "فالی به چشم و گوش در اين باب می‌زدم",},
new Hafez{ Id= 2673, BeytNo = 6, GhazalNo = 320, Mesra1 = "نقش خيال روی تو تا وقت صبحدم", Mesra2 = "بر کارگاه ديده بی‌خواب می‌زدم",},
new Hafez{ Id= 2674, BeytNo = 7, GhazalNo = 320, Mesra1 = "ساقی به صوت اين غزلم کاسه می‌گرفت", Mesra2 = "می‌گفتم اين سرود و می ناب می‌زدم",},
new Hafez{ Id= 2675, BeytNo = 8, GhazalNo = 320, Mesra1 = "خوش بود وقت حافظ و فال مراد و کام", Mesra2 = "بر نام عمر و دولت احباب می‌زدم",},
new Hafez{ Id= 2676, BeytNo = 1, GhazalNo = 321, Mesra1 = "هر چند پير و خسته دل و ناتوان شدم", Mesra2 = "هر گه که ياد روی تو کردم جوان شدم",},
new Hafez{ Id= 2677, BeytNo = 2, GhazalNo = 321, Mesra1 = "شکر خدا که هر چه طلب کردم از خدا", Mesra2 = "بر منتهای همت خود کامران شدم",},
new Hafez{ Id= 2678, BeytNo = 3, GhazalNo = 321, Mesra1 = "ای گلبن جوان بر دولت بخور که من", Mesra2 = "در سايه تو بلبل باغ جهان شدم",},
new Hafez{ Id= 2679, BeytNo = 4, GhazalNo = 321, Mesra1 = "اول ز تحت و فوق وجودم خبر نبود", Mesra2 = "در مکتب غم تو چنين نکته دان شدم",},
new Hafez{ Id= 2680, BeytNo = 5, GhazalNo = 321, Mesra1 = "قسمت حوالتم به خرابات می‌کند", Mesra2 = "هر چند کاين چنين شدم و آن چنان شدم",},
new Hafez{ Id= 2681, BeytNo = 6, GhazalNo = 321, Mesra1 = "آن روز بر دلم در معنی گشوده شد", Mesra2 = "کز ساکنان درگه پير مغان شدم",},
new Hafez{ Id= 2682, BeytNo = 7, GhazalNo = 321, Mesra1 = "در شاهراه دولت سرمد به تخت بخت", Mesra2 = "با جام می به کام دل دوستان شدم",},
new Hafez{ Id= 2683, BeytNo = 8, GhazalNo = 321, Mesra1 = "از آن زمان که فتنه چشمت به من رسيد", Mesra2 = "ايمن ز شر فتنه آخرزمان شدم",},
new Hafez{ Id= 2684, BeytNo = 9, GhazalNo = 321, Mesra1 = "من پير سال و ماه نيم يار بی‌وفاست", Mesra2 = "بر من چو عمر می‌گذرد پير از آن شدم",},
new Hafez{ Id= 2685, BeytNo = 10, GhazalNo = 321, Mesra1 = "دوشم نويد داد عنايت که حافظا", Mesra2 = "بازآ که من به عفو گناهت ضمان شدم",},
new Hafez{ Id= 2686, BeytNo = 1, GhazalNo = 322, Mesra1 = "خيال نقش تو در کارگاه ديده کشيدم", Mesra2 = "به صورت تو نگاری نديدم و نشنيدم",},
new Hafez{ Id= 2687, BeytNo = 2, GhazalNo = 322, Mesra1 = "اگر چه در طلبت همعنان باد شمالم", Mesra2 = "به گرد سرو خرامان قامتت نرسيدم",},
new Hafez{ Id= 2688, BeytNo = 3, GhazalNo = 322, Mesra1 = "اميد در شب زلفت به روز عمر نبستم", Mesra2 = "طمع به دور دهانت ز کام دل ببريدم",},
new Hafez{ Id= 2689, BeytNo = 4, GhazalNo = 322, Mesra1 = "به شوق چشمه نوشت چه قطره‌ها که فشاندم", Mesra2 = "ز لعل باده فروشت چه عشوه‌ها که خريدم",},
new Hafez{ Id= 2690, BeytNo = 5, GhazalNo = 322, Mesra1 = "ز غمزه بر دل ريشم چه تير ها که گشادی", Mesra2 = "ز غصه بر سر کويت چه بارها که کشيدم",},
new Hafez{ Id= 2691, BeytNo = 6, GhazalNo = 322, Mesra1 = "ز کوی يار بيار ای نسيم صبح غباری", Mesra2 = "که بوی خون دل ريش از آن تراب شنيدم",},
new Hafez{ Id= 2692, BeytNo = 7, GhazalNo = 322, Mesra1 = "گناه چشم سياه تو بود و گردن دلخواه", Mesra2 = "که من چو آهوی وحشی ز آدمی برميدم",},
new Hafez{ Id= 2693, BeytNo = 8, GhazalNo = 322, Mesra1 = "چو غنچه بر سرم از کوی او گذشت نسيمی", Mesra2 = "که پرده بر دل خونين به بوی او بدريدم",},
new Hafez{ Id= 2694, BeytNo = 9, GhazalNo = 322, Mesra1 = "به خاک پای تو سوگند و نور ديده حافظ", Mesra2 = "که بی رخ تو فروغ از چراغ ديده نديدم",},
new Hafez{ Id= 2695, BeytNo = 1, GhazalNo = 323, Mesra1 = "ز دست کوته خود زير بارم", Mesra2 = "که از بالابلندان شرمسارم",},
new Hafez{ Id= 2696, BeytNo = 2, GhazalNo = 323, Mesra1 = "مگر زنجير مويی گيردم دست", Mesra2 = "وگر نه سر به شيدايی برآرم",},
new Hafez{ Id= 2697, BeytNo = 3, GhazalNo = 323, Mesra1 = "ز چشم من بپرس اوضاع گردون", Mesra2 = "که شب تا روز اختر می‌شمارم",},
new Hafez{ Id= 2698, BeytNo = 4, GhazalNo = 323, Mesra1 = "بدين شکرانه می‌بوسم لب جام", Mesra2 = "که کرد آگه ز راز روزگارم",},
new Hafez{ Id= 2699, BeytNo = 5, GhazalNo = 323, Mesra1 = "اگر گفتم دعای می فروشان", Mesra2 = "چه باشد حق نعمت می‌گزارم",},
new Hafez{ Id= 2700, BeytNo = 6, GhazalNo = 323, Mesra1 = "من از بازوی خود دارم بسی شکر", Mesra2 = "که زور مردم آزاری ندارم",},
new Hafez{ Id= 2701, BeytNo = 7, GhazalNo = 323, Mesra1 = "سری دارم چو حافظ مست ليکن", Mesra2 = "به لطف آن سری اميدوارم",},
new Hafez{ Id= 2702, BeytNo = 1, GhazalNo = 324, Mesra1 = "گر چه افتاد ز زلفش گرهی در کارم", Mesra2 = "همچنان چشم گشاد از کرمش می‌دارم",},
new Hafez{ Id= 2703, BeytNo = 2, GhazalNo = 324, Mesra1 = "به طرب حمل مکن سرخی رويم که چو جام", Mesra2 = "خون دل عکس برون می‌دهد از رخسارم",},
new Hafez{ Id= 2704, BeytNo = 3, GhazalNo = 324, Mesra1 = "پرده مطربم از دست برون خواهد برد", Mesra2 = "آه اگر زان که در اين پرده نباشد بارم",},
new Hafez{ Id= 2705, BeytNo = 4, GhazalNo = 324, Mesra1 = "پاسبان حرم دل شده‌ام شب همه شب", Mesra2 = "تا در اين پرده جز انديشه او نگذارم",},
new Hafez{ Id= 2706, BeytNo = 5, GhazalNo = 324, Mesra1 = "منم آن شاعر ساحر که به افسون سخن", Mesra2 = "از نی کلک همه قند و شکر می‌بارم",},
new Hafez{ Id= 2707, BeytNo = 6, GhazalNo = 324, Mesra1 = "ديده بخت به افسانه او شد در خواب", Mesra2 = "کو نسيمی ز عنايت که کند بيدارم",},
new Hafez{ Id= 2708, BeytNo = 7, GhazalNo = 324, Mesra1 = "چون تو را در گذر ای يار نمی‌يارم ديد", Mesra2 = "با که گويم که بگويد سخنی با يارم",},
new Hafez{ Id= 2709, BeytNo = 8, GhazalNo = 324, Mesra1 = "دوش می‌گفت که حافظ همه روی است و ريا", Mesra2 = "بجز از خاک درش با که بود بازارم",},
new Hafez{ Id= 2710, BeytNo = 1, GhazalNo = 325, Mesra1 = "گر دست دهد خاک کف پای نگارم", Mesra2 = "بر لوح بصر خط غباری بنگارم",},
new Hafez{ Id= 2711, BeytNo = 2, GhazalNo = 325, Mesra1 = "بر بوی کنار تو شدم غرق و اميد است", Mesra2 = "از موج سرشکم که رساند به کنارم",},
new Hafez{ Id= 2712, BeytNo = 3, GhazalNo = 325, Mesra1 = "پروانه او گر رسدم در طلب جان", Mesra2 = "چون شمع همان دم به دمی جان بسپارم",},
new Hafez{ Id= 2713, BeytNo = 4, GhazalNo = 325, Mesra1 = "امروز مکش سر ز وفای من و انديش", Mesra2 = "زان شب که من از غم به دعا دست برآرم",},
new Hafez{ Id= 2714, BeytNo = 5, GhazalNo = 325, Mesra1 = "زلفين سياه تو به دلداری عشاق", Mesra2 = "دادند قراری و ببردند قرارم",},
new Hafez{ Id= 2715, BeytNo = 6, GhazalNo = 325, Mesra1 = "ای باد از آن باده نسيمی به من آور", Mesra2 = "کان بوی شفابخش بود دفع خمارم",},
new Hafez{ Id= 2716, BeytNo = 7, GhazalNo = 325, Mesra1 = "گر قلب دلم را ننهد دوست عياری", Mesra2 = "من نقد روان در دمش از ديده شمارم",},
new Hafez{ Id= 2717, BeytNo = 8, GhazalNo = 325, Mesra1 = "دامن مفشان از من خاکی که پس از من", Mesra2 = "زين در نتواند که برد باد غبارم",},
new Hafez{ Id= 2718, BeytNo = 9, GhazalNo = 325, Mesra1 = "حافظ لب لعلش چو مرا جان عزيز است", Mesra2 = "عمری بود آن لحظه که جان را به لب آرم",},
new Hafez{ Id= 2719, BeytNo = 1, GhazalNo = 326, Mesra1 = "در نهانخانه عشرت صنمی خوش دارم", Mesra2 = "کز سر زلف و رخش نعل در آتش دارم",},
new Hafez{ Id= 2720, BeytNo = 2, GhazalNo = 326, Mesra1 = "عاشق و رندم و ميخواره به آواز بلند", Mesra2 = "وين همه منصب از آن حور پريوش دارم",},
new Hafez{ Id= 2721, BeytNo = 3, GhazalNo = 326, Mesra1 = "گر تو زين دست مرا بی سر و سامان داری", Mesra2 = "من به آه سحرت زلف مشوش دارم",},
new Hafez{ Id= 2722, BeytNo = 4, GhazalNo = 326, Mesra1 = "گر چنين چهره گشايد خط زنگاری دوست", Mesra2 = "من رخ زرد به خونابه منقش دارم",},
new Hafez{ Id= 2723, BeytNo = 5, GhazalNo = 326, Mesra1 = "گر به کاشانه رندان قدمی خواهی زد", Mesra2 = "نقل شعر شکرين و می بی‌غش دارم",},
new Hafez{ Id= 2724, BeytNo = 6, GhazalNo = 326, Mesra1 = "ناوک غمزه بيار و رسن زلف که من", Mesra2 = "جنگ‌ها با دل مجروح بلاکش دارم",},
new Hafez{ Id= 2725, BeytNo = 7, GhazalNo = 326, Mesra1 = "حافظا چون غم و شادی جهان در گذر است", Mesra2 = "بهتر آن است که من خاطر خود خوش دارم",},
new Hafez{ Id= 2726, BeytNo = 1, GhazalNo = 327, Mesra1 = "مرا عهديست با جانان که تا جان در بدن دارم", Mesra2 = "هواداران کويش را چو جان خويشتن دارم",},
new Hafez{ Id= 2727, BeytNo = 2, GhazalNo = 327, Mesra1 = "صفای خلوت خاطر از آن شمع چگل جويم", Mesra2 = "فروغ چشم و نور دل از آن ماه ختن دارم",},
new Hafez{ Id= 2728, BeytNo = 3, GhazalNo = 327, Mesra1 = "به کام و آرزوی دل چو دارم خلوتی حاصل", Mesra2 = "چه فکر از خبث بدگويان ميان انجمن دارم",},
new Hafez{ Id= 2729, BeytNo = 4, GhazalNo = 327, Mesra1 = "مرا در خانه سروی هست کاندر سايه قدش", Mesra2 = "فراغ از سرو بستانی و شمشاد چمن دارم",},
new Hafez{ Id= 2730, BeytNo = 5, GhazalNo = 327, Mesra1 = "گرم صد لشکر از خوبان به قصد دل کمين سازند", Mesra2 = "بحمد الله و المنه بتی لشکرشکن دارم",},
new Hafez{ Id= 2731, BeytNo = 6, GhazalNo = 327, Mesra1 = "سزد کز خاتم لعلش زنم لاف سليمانی", Mesra2 = "چو اسم اعظمم باشد چه باک از اهرمن دارم",},
new Hafez{ Id= 2732, BeytNo = 7, GhazalNo = 327, Mesra1 = "الا ای پير فرزانه مکن عيبم ز ميخانه", Mesra2 = "که من در ترک پيمانه دلی پيمان شکن دارم",},
new Hafez{ Id= 2733, BeytNo = 8, GhazalNo = 327, Mesra1 = "خدا را ای رقيب امشب زمانی ديده بر هم نه", Mesra2 = "که من با لعل خاموشش نهانی صد سخن دارم",},
new Hafez{ Id= 2734, BeytNo = 9, GhazalNo = 327, Mesra1 = "چو در گلزار اقبالش خرامانم بحمدالله", Mesra2 = "نه ميل لاله و نسرين نه برگ نسترن دارم",},
new Hafez{ Id= 2735, BeytNo = 10, GhazalNo = 327, Mesra1 = "به رندی شهره شد حافظ ميان همدمان ليکن", Mesra2 = "چه غم دارم که در عالم قوام الدين حسن دارم",},
new Hafez{ Id= 2736, BeytNo = 1, GhazalNo = 328, Mesra1 = "من که باشم که بر آن خاطر عاطر گذرم", Mesra2 = "لطف‌ها می‌کنی ای خاک درت تاج سرم",},
new Hafez{ Id= 2737, BeytNo = 2, GhazalNo = 328, Mesra1 = "دلبرا بنده نوازيت که آموخت بگو", Mesra2 = "که من اين ظن به رقيبان تو هرگز نبرم",},
new Hafez{ Id= 2738, BeytNo = 3, GhazalNo = 328, Mesra1 = "همتم بدرقه راه کن ای طاير قدس", Mesra2 = "که دراز است ره مقصد و من نوسفرم",},
new Hafez{ Id= 2739, BeytNo = 4, GhazalNo = 328, Mesra1 = "ای نسيم سحری بندگی من برسان", Mesra2 = "که فراموش مکن وقت دعای سحرم",},
new Hafez{ Id= 2740, BeytNo = 5, GhazalNo = 328, Mesra1 = "خرم آن روز کز اين مرحله بربندم بار", Mesra2 = "و از سر کوی تو پرسند رفيقان خبرم",},
new Hafez{ Id= 2741, BeytNo = 6, GhazalNo = 328, Mesra1 = "حافظا شايد اگر در طلب گوهر وصل", Mesra2 = "ديده دريا کنم از اشک و در او غوطه خورم",},
new Hafez{ Id= 2742, BeytNo = 7, GhazalNo = 328, Mesra1 = "پايه نظم بلند است و جهان گير بگو", Mesra2 = "تا کند پادشه بحر دهان پرگهرم",},
new Hafez{ Id= 2743, BeytNo = 1, GhazalNo = 329, Mesra1 = "جوزا سحر نهاد حمايل برابرم", Mesra2 = "يعنی غلام شاهم و سوگند می‌خورم",},
new Hafez{ Id= 2744, BeytNo = 2, GhazalNo = 329, Mesra1 = "ساقی بيا که از مدد بخت کارساز", Mesra2 = "کامی که خواستم ز خدا شد ميسرم",},
new Hafez{ Id= 2745, BeytNo = 3, GhazalNo = 329, Mesra1 = "جامی بده که باز به شادی روی شاه", Mesra2 = "پيرانه سر هوای جوانيست در سرم",},
new Hafez{ Id= 2746, BeytNo = 4, GhazalNo = 329, Mesra1 = "راهم مزن به وصف زلال خضر که من", Mesra2 = "از جام شاه جرعه کش حوض کوثرم",},
new Hafez{ Id= 2747, BeytNo = 5, GhazalNo = 329, Mesra1 = "شاها اگر به عرش رسانم سرير فضل", Mesra2 = "مملوک اين جنابم و مسکين اين درم",},
new Hafez{ Id= 2748, BeytNo = 6, GhazalNo = 329, Mesra1 = "من جرعه نوش بزم تو بودم هزار سال", Mesra2 = "کی ترک آبخورد کند طبع خوگرم",},
new Hafez{ Id= 2749, BeytNo = 7, GhazalNo = 329, Mesra1 = "ور باورت نمی‌کند از بنده اين حديث", Mesra2 = "از گفته کمال دليلی بياورم",},
new Hafez{ Id= 2750, BeytNo = 8, GhazalNo = 329, Mesra1 = "گر برکنم دل از تو و بردارم از تو مهر", Mesra2 = "آن مهر بر که افکنم آن دل کجا برم",},
new Hafez{ Id= 2751, BeytNo = 9, GhazalNo = 329, Mesra1 = "منصور بن مظفر غازيست حرز من", Mesra2 = "و از اين خجسته نام بر اعدا مظفرم",},
new Hafez{ Id= 2752, BeytNo = 10, GhazalNo = 329, Mesra1 = "عهد الست من همه با عشق شاه بود", Mesra2 = "و از شاهراه عمر بدين عهد بگذرم",},
new Hafez{ Id= 2753, BeytNo = 11, GhazalNo = 329, Mesra1 = "گردون چو کرد نظم ثريا به نام شاه", Mesra2 = "من نظم در چرا نکنم از که کمترم",},
new Hafez{ Id= 2754, BeytNo = 12, GhazalNo = 329, Mesra1 = "شاهين صفت چو طعمه چشيدم ز دست شاه", Mesra2 = "کی باشد التفات به صيد کبوترم",},
new Hafez{ Id= 2755, BeytNo = 13, GhazalNo = 329, Mesra1 = "ای شاه شيرگير چه کم گردد ار شود", Mesra2 = "در سايه تو ملک فراغت ميسرم",},
new Hafez{ Id= 2756, BeytNo = 14, GhazalNo = 329, Mesra1 = "شعرم به يمن مدح تو صد ملک دل گشاد", Mesra2 = "گويی که تيغ توست زبان سخنورم",},
new Hafez{ Id= 2757, BeytNo = 15, GhazalNo = 329, Mesra1 = "بر گلشنی اگر بگذشتم چو باد صبح", Mesra2 = "نی عشق سرو بود و نه شوق صنوبرم",},
new Hafez{ Id= 2758, BeytNo = 16, GhazalNo = 329, Mesra1 = "بوی تو می‌شنيدم و بر ياد روی تو", Mesra2 = "دادند ساقيان طرب يک دو ساغرم",},
new Hafez{ Id= 2759, BeytNo = 17, GhazalNo = 329, Mesra1 = "مستی به آب يک دو عنب وضع بنده نيست", Mesra2 = "من سالخورده پير خرابات پرورم",},
new Hafez{ Id= 2760, BeytNo = 18, GhazalNo = 329, Mesra1 = "با سير اختر فلکم داوری بسيست", Mesra2 = "انصاف شاه باد در اين قصه ياورم",},
new Hafez{ Id= 2761, BeytNo = 19, GhazalNo = 329, Mesra1 = "شکر خدا که باز در اين اوج بارگاه", Mesra2 = "طاووس عرش می‌شنود صيت شهپرم",},
new Hafez{ Id= 2762, BeytNo = 20, GhazalNo = 329, Mesra1 = "نامم ز کارخانه عشاق محو باد", Mesra2 = "گر جز محبت تو بود شغل ديگرم",},
new Hafez{ Id= 2763, BeytNo = 21, GhazalNo = 329, Mesra1 = "شبل الاسد به صيد دلم حمله کرد و من", Mesra2 = "گر لاغرم وگرنه شکار غضنفرم",},
new Hafez{ Id= 2764, BeytNo = 22, GhazalNo = 329, Mesra1 = "ای عاشقان روی تو از ذره بيشتر", Mesra2 = "من کی رسم به وصل تو کز ذره کمترم",},
new Hafez{ Id= 2765, BeytNo = 23, GhazalNo = 329, Mesra1 = "بنما به من که منکر حسن رخ تو کيست", Mesra2 = "تا ديده‌اش به گزلک غيرت برآورم",},
new Hafez{ Id= 2766, BeytNo = 24, GhazalNo = 329, Mesra1 = "بر من فتاد سايه خورشيد سلطنت", Mesra2 = "و اکنون فراغت است ز خورشيد خاورم",},
new Hafez{ Id= 2767, BeytNo = 25, GhazalNo = 329, Mesra1 = "مقصود از اين معامله بازارتيزی است", Mesra2 = "نی جلوه می‌فروشم و نی عشوه می‌خرم",},
new Hafez{ Id= 2768, BeytNo = 1, GhazalNo = 330, Mesra1 = "تو همچو صبحی و من شمع خلوت سحرم", Mesra2 = "تبسمی کن و جان بين که چون همی‌سپرم",},
new Hafez{ Id= 2769, BeytNo = 2, GhazalNo = 330, Mesra1 = "چنين که در دل من داغ زلف سرکش توست", Mesra2 = "بنفشه زار شود تربتم چو درگذرم",},
new Hafez{ Id= 2770, BeytNo = 3, GhazalNo = 330, Mesra1 = "بر آستان مرادت گشاده‌ام در چشم", Mesra2 = "که يک نظر فکنی خود فکندی از نظرم",},
new Hafez{ Id= 2771, BeytNo = 4, GhazalNo = 330, Mesra1 = "چه شکر گويمت ای خيل غم عفاک الله", Mesra2 = "که روز بی‌کسی آخر نمی‌روی ز سرم",},
new Hafez{ Id= 2772, BeytNo = 5, GhazalNo = 330, Mesra1 = "غلام مردم چشمم که با سياه دلی", Mesra2 = "هزار قطره ببارد چو درد دل شمرم",},
new Hafez{ Id= 2773, BeytNo = 6, GhazalNo = 330, Mesra1 = "به هر نظر بت ما جلوه می‌کند ليکن", Mesra2 = "کس اين کرشمه نبيند که من همی‌نگرم",},
new Hafez{ Id= 2774, BeytNo = 7, GhazalNo = 330, Mesra1 = "به خاک حافظ اگر يار بگذرد چون باد", Mesra2 = "ز شوق در دل آن تنگنا کفن بدرم",},
new Hafez{ Id= 2775, BeytNo = 1, GhazalNo = 331, Mesra1 = "به تيغم گر کشد دستش نگيرم", Mesra2 = "وگر تيرم زند منت پذيرم",},
new Hafez{ Id= 2776, BeytNo = 2, GhazalNo = 331, Mesra1 = "کمان ابرويت را گو بزن تير", Mesra2 = "که پيش دست و بازويت بميرم",},
new Hafez{ Id= 2777, BeytNo = 3, GhazalNo = 331, Mesra1 = "غم گيتی گر از پايم درآرد", Mesra2 = "بجز ساغر که باشد دستگيرم",},
new Hafez{ Id= 2778, BeytNo = 4, GhazalNo = 331, Mesra1 = "برآی ای آفتاب صبح اميد", Mesra2 = "که در دست شب هجران اسيرم",},
new Hafez{ Id= 2779, BeytNo = 5, GhazalNo = 331, Mesra1 = "به فريادم رس ای پير خرابات", Mesra2 = "به يک جرعه جوانم کن که پيرم",},
new Hafez{ Id= 2780, BeytNo = 6, GhazalNo = 331, Mesra1 = "به گيسوی تو خوردم دوش سوگند", Mesra2 = "که من از پای تو سر بر نگيرم",},
new Hafez{ Id= 2781, BeytNo = 7, GhazalNo = 331, Mesra1 = "بسوز اين خرقه تقوا تو حافظ", Mesra2 = "که گر آتش شوم در وی نگيرم",},
new Hafez{ Id= 2782, BeytNo = 1, GhazalNo = 332, Mesra1 = "مزن بر دل ز نوک غمزه تيرم", Mesra2 = "که پيش چشم بيمارت بميرم",},
new Hafez{ Id= 2783, BeytNo = 2, GhazalNo = 332, Mesra1 = "نصاب حسن در حد کمال است", Mesra2 = "زکاتم ده که مسکين و فقيرم",},
new Hafez{ Id= 2784, BeytNo = 3, GhazalNo = 332, Mesra1 = "چو طفلان تا کی ای زاهد فريبی", Mesra2 = "به سيب بوستان و شهد و شيرم",},
new Hafez{ Id= 2785, BeytNo = 4, GhazalNo = 332, Mesra1 = "چنان پر شد فضای سينه از دوست", Mesra2 = "که فکر خويش گم شد از ضميرم",},
new Hafez{ Id= 2786, BeytNo = 5, GhazalNo = 332, Mesra1 = "قدح پر کن که من در دولت عشق", Mesra2 = "جوان بخت جهانم گر چه پيرم",},
new Hafez{ Id= 2787, BeytNo = 6, GhazalNo = 332, Mesra1 = "قراری بسته‌ام با می فروشان", Mesra2 = "که روز غم بجز ساغر نگيرم",},
new Hafez{ Id= 2788, BeytNo = 7, GhazalNo = 332, Mesra1 = "مبادا جز حساب مطرب و می", Mesra2 = "اگر نقشی کشد کلک دبيرم",},
new Hafez{ Id= 2789, BeytNo = 8, GhazalNo = 332, Mesra1 = "در اين غوغا که کس کس را نپرسد", Mesra2 = "من از پير مغان منت پذيرم",},
new Hafez{ Id= 2790, BeytNo = 9, GhazalNo = 332, Mesra1 = "خوشا آن دم کز استغنای مستی", Mesra2 = "فراغت باشد از شاه و وزيرم",},
new Hafez{ Id= 2791, BeytNo = 10, GhazalNo = 332, Mesra1 = "من آن مرغم که هر شام و سحرگاه", Mesra2 = "ز بام عرش می‌آيد صفيرم",},
new Hafez{ Id= 2792, BeytNo = 11, GhazalNo = 332, Mesra1 = "چو حافظ گنج او در سينه دارم", Mesra2 = "اگر چه مدعی بيند حقيرم",},
new Hafez{ Id= 2793, BeytNo = 1, GhazalNo = 333, Mesra1 = "نماز شام غريبان چو گريه آغازم", Mesra2 = "به مويه‌های غريبانه قصه پردازم",},
new Hafez{ Id= 2794, BeytNo = 2, GhazalNo = 333, Mesra1 = "به ياد يار و ديار آن چنان بگريم زار", Mesra2 = "که از جهان ره و رسم سفر براندازم",},
new Hafez{ Id= 2795, BeytNo = 3, GhazalNo = 333, Mesra1 = "من از ديار حبيبم نه از بلاد غريب", Mesra2 = "مهيمنا به رفيقان خود رسان بازم",},
new Hafez{ Id= 2796, BeytNo = 4, GhazalNo = 333, Mesra1 = "خدای را مددی ای رفيق ره تا من", Mesra2 = "به کوی ميکده ديگر علم برافرازم",},
new Hafez{ Id= 2797, BeytNo = 5, GhazalNo = 333, Mesra1 = "خرد ز پيری من کی حساب برگيرد", Mesra2 = "که باز با صنمی طفل عشق می‌بازم",},
new Hafez{ Id= 2798, BeytNo = 6, GhazalNo = 333, Mesra1 = "بجز صبا و شمالم نمی‌شناسد کس", Mesra2 = "عزيز من که بجز باد نيست دمسازم",},
new Hafez{ Id= 2799, BeytNo = 7, GhazalNo = 333, Mesra1 = "هوای منزل يار آب زندگانی ماست", Mesra2 = "صبا بيار نسيمی ز خاک شيرازم",},
new Hafez{ Id= 2800, BeytNo = 8, GhazalNo = 333, Mesra1 = "سرشکم آمد و عيبم بگفت روی به روی", Mesra2 = "شکايت از که کنم خانگيست غمازم",},
new Hafez{ Id= 2801, BeytNo = 9, GhazalNo = 333, Mesra1 = "ز چنگ زهره شنيدم که صبحدم می‌گفت", Mesra2 = "غلام حافظ خوش لهجه خوش آوازم",},
new Hafez{ Id= 2802, BeytNo = 1, GhazalNo = 334, Mesra1 = "گر دست رسد در سر زلفين تو بازم", Mesra2 = "چون گوی چه سرها که به چوگان تو بازم",},
new Hafez{ Id= 2803, BeytNo = 2, GhazalNo = 334, Mesra1 = "زلف تو مرا عمر دراز است ولی نيست", Mesra2 = "در دست سر مويی از آن عمر درازم",},
new Hafez{ Id= 2804, BeytNo = 3, GhazalNo = 334, Mesra1 = "پروانه راحت بده ای شمع که امشب", Mesra2 = "از آتش دل پيش تو چون شمع گدازم",},
new Hafez{ Id= 2805, BeytNo = 4, GhazalNo = 334, Mesra1 = "آن دم که به يک خنده دهم جان چو صراحی", Mesra2 = "مستان تو خواهم که گزارند نمازم",},
new Hafez{ Id= 2806, BeytNo = 5, GhazalNo = 334, Mesra1 = "چون نيست نماز من آلوده نمازی", Mesra2 = "در ميکده زان کم نشود سوز و گدازم",},
new Hafez{ Id= 2807, BeytNo = 6, GhazalNo = 334, Mesra1 = "در مسجد و ميخانه خيالت اگر آيد", Mesra2 = "محراب و کمانچه ز دو ابروی تو سازم",},
new Hafez{ Id= 2808, BeytNo = 7, GhazalNo = 334, Mesra1 = "گر خلوت ما را شبی از رخ بفروزی", Mesra2 = "چون صبح بر آفاق جهان سر بفرازم",},
new Hafez{ Id= 2809, BeytNo = 8, GhazalNo = 334, Mesra1 = "محمود بود عاقبت کار در اين راه", Mesra2 = "گر سر برود در سر سودای ايازم",},
new Hafez{ Id= 2810, BeytNo = 9, GhazalNo = 334, Mesra1 = "حافظ غم دل با که بگويم که در اين دور", Mesra2 = "جز جام نشايد که بود محرم رازم",},
new Hafez{ Id= 2811, BeytNo = 1, GhazalNo = 335, Mesra1 = "در خرابات مغان گر گذر افتد بازم", Mesra2 = "حاصل خرقه و سجاده روان دربازم",},
new Hafez{ Id= 2812, BeytNo = 2, GhazalNo = 335, Mesra1 = "حلقه توبه گر امروز چو زهاد زنم", Mesra2 = "خازن ميکده فردا نکند در بازم",},
new Hafez{ Id= 2813, BeytNo = 3, GhazalNo = 335, Mesra1 = "ور چو پروانه دهد دست فراغ بالی", Mesra2 = "جز بدان عارض شمعی نبود پروازم",},
new Hafez{ Id= 2814, BeytNo = 4, GhazalNo = 335, Mesra1 = "صحبت حور نخواهم که بود عين قصور", Mesra2 = "با خيال تو اگر با دگری پردازم",},
new Hafez{ Id= 2815, BeytNo = 5, GhazalNo = 335, Mesra1 = "سر سودای تو در سينه بماندی پنهان", Mesra2 = "چشم تردامن اگر فاش نگردی رازم",},
new Hafez{ Id= 2816, BeytNo = 6, GhazalNo = 335, Mesra1 = "مرغ سان از قفس خاک هوايی گشتم", Mesra2 = "به هوايی که مگر صيد کند شهبازم",},
new Hafez{ Id= 2817, BeytNo = 7, GhazalNo = 335, Mesra1 = "همچو چنگ ار به کناری ندهی کام دلم", Mesra2 = "از لب خويش چو نی يک نفسی بنوازم",},
new Hafez{ Id= 2818, BeytNo = 8, GhazalNo = 335, Mesra1 = "ماجرای دل خون گشته نگويم با کس", Mesra2 = "زان که جز تيغ غمت نيست کسی دمسازم",},
new Hafez{ Id= 2819, BeytNo = 9, GhazalNo = 335, Mesra1 = "گر به هر موی سری بر تن حافظ باشد", Mesra2 = "همچو زلفت همه را در قدمت اندازم",},
new Hafez{ Id= 2820, BeytNo = 1, GhazalNo = 336, Mesra1 = "مژده وصل تو کو کز سر جان برخيزم", Mesra2 = "طاير قدسم و از دام جهان برخيزم",},
new Hafez{ Id= 2821, BeytNo = 2, GhazalNo = 336, Mesra1 = "به ولای تو که گر بنده خويشم خوانی", Mesra2 = "از سر خواجگی کون و مکان برخيزم",},
new Hafez{ Id= 2822, BeytNo = 3, GhazalNo = 336, Mesra1 = "يا رب از ابر هدايت برسان بارانی", Mesra2 = "پيشتر زان که چو گردی ز ميان برخيزم",},
new Hafez{ Id= 2823, BeytNo = 4, GhazalNo = 336, Mesra1 = "بر سر تربت من با می و مطرب بنشين", Mesra2 = "تا به بويت ز لحد رقص کنان برخيزم",},
new Hafez{ Id= 2824, BeytNo = 5, GhazalNo = 336, Mesra1 = "خيز و بالا بنما ای بت شيرين حرکات", Mesra2 = "کز سر جان و جهان دست فشان برخيزم",},
new Hafez{ Id= 2825, BeytNo = 6, GhazalNo = 336, Mesra1 = "گر چه پيرم تو شبی تنگ در آغوشم کش", Mesra2 = "تا سحرگه ز کنار تو جوان برخيزم",},
new Hafez{ Id= 2826, BeytNo = 7, GhazalNo = 336, Mesra1 = "روز مرگم نفسی مهلت ديدار بده", Mesra2 = "تا چو حافظ ز سر جان و جهان برخيزم",},
new Hafez{ Id= 2827, BeytNo = 1, GhazalNo = 337, Mesra1 = "چرا نه در پی عزم ديار خود باشم", Mesra2 = "چرا نه خاک سر کوی يار خود باشم",},
new Hafez{ Id= 2828, BeytNo = 2, GhazalNo = 337, Mesra1 = "غم غريبی و غربت چو بر نمی‌تابم", Mesra2 = "به شهر خود روم و شهريار خود باشم",},
new Hafez{ Id= 2829, BeytNo = 3, GhazalNo = 337, Mesra1 = "ز محرمان سراپرده وصال شوم", Mesra2 = "ز بندگان خداوندگار خود باشم",},
new Hafez{ Id= 2830, BeytNo = 4, GhazalNo = 337, Mesra1 = "چو کار عمر نه پيداست باری آن اولی", Mesra2 = "که روز واقعه پيش نگار خود باشم",},
new Hafez{ Id= 2831, BeytNo = 5, GhazalNo = 337, Mesra1 = "ز دست بخت گران خواب و کار بی‌سامان", Mesra2 = "گرم بود گله‌ای رازدار خود باشم",},
new Hafez{ Id= 2832, BeytNo = 6, GhazalNo = 337, Mesra1 = "هميشه پيشه من عاشقی و رندی بود", Mesra2 = "دگر بکوشم و مشغول کار خود باشم",},
new Hafez{ Id= 2833, BeytNo = 7, GhazalNo = 337, Mesra1 = "بود که لطف ازل رهنمون شود حافظ", Mesra2 = "وگرنه تا به ابد شرمسار خود باشم",},
new Hafez{ Id= 2834, BeytNo = 1, GhazalNo = 338, Mesra1 = "من دوستدار روی خوش و موی دلکشم", Mesra2 = "مدهوش چشم مست و می صاف بی‌غشم",},
new Hafez{ Id= 2835, BeytNo = 2, GhazalNo = 338, Mesra1 = "گفتی ز سر عهد ازل يک سخن بگو", Mesra2 = "آن گه بگويمت که دو پيمانه درکشم",},
new Hafez{ Id= 2836, BeytNo = 3, GhazalNo = 338, Mesra1 = "من آدم بهشتيم اما در اين سفر", Mesra2 = "حالی اسير عشق جوانان مه وشم",},
new Hafez{ Id= 2837, BeytNo = 4, GhazalNo = 338, Mesra1 = "در عاشقی گزير نباشد ز ساز و سوز", Mesra2 = "استاده‌ام چو شمع مترسان ز آتشم",},
new Hafez{ Id= 2838, BeytNo = 5, GhazalNo = 338, Mesra1 = "شيراز معدن لب لعل است و کان حسن", Mesra2 = "من جوهری مفلسم ايرا مشوشم",},
new Hafez{ Id= 2839, BeytNo = 6, GhazalNo = 338, Mesra1 = "از بس که چشم مست در اين شهر ديده‌ام", Mesra2 = "حقا که می نمی‌خورم اکنون و سرخوشم",},
new Hafez{ Id= 2840, BeytNo = 7, GhazalNo = 338, Mesra1 = "شهريست پر کرشمه حوران ز شش جهت", Mesra2 = "چيزيم نيست ور نه خريدار هر ششم",},
new Hafez{ Id= 2841, BeytNo = 8, GhazalNo = 338, Mesra1 = "بخت ار مدد دهد که کشم رخت سوی دوست", Mesra2 = "گيسوی حور گرد فشاند ز مفرشم",},
new Hafez{ Id= 2842, BeytNo = 9, GhazalNo = 338, Mesra1 = "حافظ عروس طبع مرا جلوه آرزوست", Mesra2 = "آيينه‌ای ندارم از آن آه می‌کشم",},
new Hafez{ Id= 2843, BeytNo = 1, GhazalNo = 339, Mesra1 = "خيال روی تو چون بگذرد به گلشن چشم", Mesra2 = "دل از پی نظر آيد به سوی روزن چشم",},
new Hafez{ Id= 2844, BeytNo = 2, GhazalNo = 339, Mesra1 = "سزای تکيه گهت منظری نمی‌بينم", Mesra2 = "منم ز عالم و اين گوشه معين چشم",},
new Hafez{ Id= 2845, BeytNo = 3, GhazalNo = 339, Mesra1 = "بيا که لعل و گهر در نثار مقدم تو", Mesra2 = "ز گنج خانه دل می‌کشم به روزن چشم",},
new Hafez{ Id= 2846, BeytNo = 4, GhazalNo = 339, Mesra1 = "سحر سرشک روانم سر خرابی داشت", Mesra2 = "گرم نه خون جگر می‌گرفت دامن چشم",},
new Hafez{ Id= 2847, BeytNo = 5, GhazalNo = 339, Mesra1 = "نخست روز که ديدم رخ تو دل می‌گفت", Mesra2 = "اگر رسد خللی خون من به گردن چشم",},
new Hafez{ Id= 2848, BeytNo = 6, GhazalNo = 339, Mesra1 = "به بوی مژده وصل تو تا سحر شب دوش", Mesra2 = "به راه باد نهادم چراغ روشن چشم",},
new Hafez{ Id= 2849, BeytNo = 7, GhazalNo = 339, Mesra1 = "به مردمی که دل دردمند حافظ را", Mesra2 = "مزن به ناوک دلدوز مردم افکن چشم",},
new Hafez{ Id= 2850, BeytNo = 1, GhazalNo = 340, Mesra1 = "من که از آتش دل چون خم می در جوشم", Mesra2 = "مهر بر لب زده خون می‌خورم و خاموشم",},
new Hafez{ Id= 2851, BeytNo = 2, GhazalNo = 340, Mesra1 = "قصد جان است طمع در لب جانان کردن", Mesra2 = "تو مرا بين که در اين کار به جان می‌کوشم",},
new Hafez{ Id= 2852, BeytNo = 3, GhazalNo = 340, Mesra1 = "من کی آزاد شوم از غم دل چون هر دم", Mesra2 = "هندوی زلف بتی حلقه کند در گوشم",},
new Hafez{ Id= 2853, BeytNo = 4, GhazalNo = 340, Mesra1 = "حاش لله که نيم معتقد طاعت خويش", Mesra2 = "اين قدر هست که گه گه قدحی می نوشم",},
new Hafez{ Id= 2854, BeytNo = 5, GhazalNo = 340, Mesra1 = "هست اميدم که عليرغم عدو روز جزا", Mesra2 = "فيض عفوش ننهد بار گنه بر دوشم",},
new Hafez{ Id= 2855, BeytNo = 6, GhazalNo = 340, Mesra1 = "پدرم روضه رضوان به دو گندم بفروخت", Mesra2 = "من چرا ملک جهان را به جوی نفروشم",},
new Hafez{ Id= 2856, BeytNo = 7, GhazalNo = 340, Mesra1 = "خرقه پوشی من از غايت دين داری نيست", Mesra2 = "پرده‌ای بر سر صد عيب نهان می‌پوشم",},
new Hafez{ Id= 2857, BeytNo = 8, GhazalNo = 340, Mesra1 = "من که خواهم که ننوشم بجز از راوق خم", Mesra2 = "چه کنم گر سخن پير مغان ننيوشم",},
new Hafez{ Id= 2858, BeytNo = 9, GhazalNo = 340, Mesra1 = "گر از اين دست زند مطرب مجلس ره عشق", Mesra2 = "شعر حافظ ببرد وقت سماع از هوشم",},
new Hafez{ Id= 2859, BeytNo = 1, GhazalNo = 341, Mesra1 = "گر من از سرزنش مدعيان انديشم", Mesra2 = "شيوه مستی و رندی نرود از پيشم",},
new Hafez{ Id= 2860, BeytNo = 2, GhazalNo = 341, Mesra1 = "زهد رندان نوآموخته راهی بدهيست", Mesra2 = "من که بدنام جهانم چه صلاح انديشم",},
new Hafez{ Id= 2861, BeytNo = 3, GhazalNo = 341, Mesra1 = "شاه شوريده سران خوان من بی‌سامان را", Mesra2 = "زان که در کم خردی از همه عالم بيشم",},
new Hafez{ Id= 2862, BeytNo = 4, GhazalNo = 341, Mesra1 = "بر جبين نقش کن از خون دل من خالی", Mesra2 = "تا بدانند که قربان تو کافرکيشم",},
new Hafez{ Id= 2863, BeytNo = 5, GhazalNo = 341, Mesra1 = "اعتقادی بنما و بگذر بهر خدا", Mesra2 = "تا در اين خرقه ندانی که چه نادرويشم",},
new Hafez{ Id= 2864, BeytNo = 6, GhazalNo = 341, Mesra1 = "شعر خونبار من ای باد بدان يار رسان", Mesra2 = "که ز مژگان سيه بر رگ جان زد نيشم",},
new Hafez{ Id= 2865, BeytNo = 7, GhazalNo = 341, Mesra1 = "من اگر باده خورم ور نه چه کارم با کس", Mesra2 = "حافظ راز خود و عارف وقت خويشم",},
new Hafez{ Id= 2866, BeytNo = 1, GhazalNo = 342, Mesra1 = "حجاب چهره جان می‌شود غبار تنم", Mesra2 = "خوشا دمی که از آن چهره پرده برفکنم",},
new Hafez{ Id= 2867, BeytNo = 2, GhazalNo = 342, Mesra1 = "چنين قفس نه سزای چو من خوش الحانيست", Mesra2 = "روم به گلشن رضوان که مرغ آن چمنم",},
new Hafez{ Id= 2868, BeytNo = 3, GhazalNo = 342, Mesra1 = "عيان نشد که چرا آمدم کجا رفتم", Mesra2 = "دريغ و درد که غافل ز کار خويشتنم",},
new Hafez{ Id= 2869, BeytNo = 4, GhazalNo = 342, Mesra1 = "چگونه طوف کنم در فضای عالم قدس", Mesra2 = "که در سراچه ترکيب تخته بند تنم",},
new Hafez{ Id= 2870, BeytNo = 5, GhazalNo = 342, Mesra1 = "اگر ز خون دلم بوی شوق می‌آيد", Mesra2 = "عجب مدار که همدرد نافه ختنم",},
new Hafez{ Id= 2871, BeytNo = 6, GhazalNo = 342, Mesra1 = "طراز پيرهن زرکشم مبين چون شمع", Mesra2 = "که سوزهاست نهانی درون پيرهنم",},
new Hafez{ Id= 2872, BeytNo = 7, GhazalNo = 342, Mesra1 = "بيا و هستی حافظ ز پيش او بردار", Mesra2 = "که با وجود تو کس نشنود ز من که منم",},
new Hafez{ Id= 2873, BeytNo = 1, GhazalNo = 343, Mesra1 = "چل سال بيش رفت که من لاف می‌زنم", Mesra2 = "کز چاکران پير مغان کمترين منم",},
new Hafez{ Id= 2874, BeytNo = 2, GhazalNo = 343, Mesra1 = "هرگز به يمن عاطفت پير می فروش", Mesra2 = "ساغر تهی نشد ز می صاف روشنم",},
new Hafez{ Id= 2875, BeytNo = 3, GhazalNo = 343, Mesra1 = "از جاه عشق و دولت رندان پاکباز", Mesra2 = "پيوسته صدر مصطبه‌ها بود مسکنم",},
new Hafez{ Id= 2876, BeytNo = 4, GhazalNo = 343, Mesra1 = "در شان من به دردکشی ظن بد مبر", Mesra2 = "کلوده گشت جامه ولی پاکدامنم",},
new Hafez{ Id= 2877, BeytNo = 5, GhazalNo = 343, Mesra1 = "شهباز دست پادشهم اين چه حالت است", Mesra2 = "کز ياد برده‌اند هوای نشيمنم",},
new Hafez{ Id= 2878, BeytNo = 6, GhazalNo = 343, Mesra1 = "حيف است بلبلی چو من اکنون در اين قفس", Mesra2 = "با اين لسان عذب که خامش چو سوسنم",},
new Hafez{ Id= 2879, BeytNo = 7, GhazalNo = 343, Mesra1 = "آب و هوای فارس عجب سفله پرور است", Mesra2 = "کو همرهی که خيمه از اين خاک برکنم",},
new Hafez{ Id= 2880, BeytNo = 8, GhazalNo = 343, Mesra1 = "حافظ به زير خرقه قدح تا به کی کشی", Mesra2 = "در بزم خواجه پرده ز کارت برافکنم",},
new Hafez{ Id= 2881, BeytNo = 9, GhazalNo = 343, Mesra1 = "تورانشه خجسته که در من يزيد فضل", Mesra2 = "شد منت مواهب او طوق گردنم",},
new Hafez{ Id= 2882, BeytNo = 1, GhazalNo = 344, Mesra1 = "عمريست تا من در طلب هر روز گامی می‌زنم", Mesra2 = "دست شفاعت هر زمان در نيک نامی می‌زنم",},
new Hafez{ Id= 2883, BeytNo = 2, GhazalNo = 344, Mesra1 = "بی ماه مهرافروز خود تا بگذرانم روز خود", Mesra2 = "دامی به راهی می‌نهم مرغی به دامی می‌زنم",},
new Hafez{ Id= 2884, BeytNo = 3, GhazalNo = 344, Mesra1 = "اورنگ کو گلچهر کو نقش وفا و مهر کو", Mesra2 = "حالی من اندر عاشقی داو تمامی می‌زنم",},
new Hafez{ Id= 2885, BeytNo = 4, GhazalNo = 344, Mesra1 = "تا بو که يابم آگهی از سايه سرو سهی", Mesra2 = "گلبانگ عشق از هر طرف بر خوش خرامی می‌زنم",},
new Hafez{ Id= 2886, BeytNo = 5, GhazalNo = 344, Mesra1 = "هر چند کان آرام دل دانم نبخشد کام دل", Mesra2 = "نقش خيالی می‌کشم فال دوامی می‌زنم",},
new Hafez{ Id= 2887, BeytNo = 6, GhazalNo = 344, Mesra1 = "دانم سر آرد غصه را رنگين برآرد قصه را", Mesra2 = "اين آه خون افشان که من هر صبح و شامی می‌زنم",},
new Hafez{ Id= 2888, BeytNo = 7, GhazalNo = 344, Mesra1 = "با آن که از وی غايبم و از می چو حافظ تايبم", Mesra2 = "در مجلس روحانيان گه گاه جامی می‌زنم",},
new Hafez{ Id= 2889, BeytNo = 1, GhazalNo = 345, Mesra1 = "بی تو ای سرو روان با گل و گلشن چه کنم", Mesra2 = "زلف سنبل چه کشم عارض سوسن چه کنم",},
new Hafez{ Id= 2890, BeytNo = 2, GhazalNo = 345, Mesra1 = "آه کز طعنه بدخواه نديدم رويت", Mesra2 = "نيست چون آينه‌ام روی ز آهن چه کنم",},
new Hafez{ Id= 2891, BeytNo = 3, GhazalNo = 345, Mesra1 = "برو ای ناصح و بر دردکشان خرده مگير", Mesra2 = "کارفرمای قدر می‌کند اين من چه کنم",},
new Hafez{ Id= 2892, BeytNo = 4, GhazalNo = 345, Mesra1 = "برق غيرت چو چنين می‌جهد از مکمن غيب", Mesra2 = "تو بفرما که من سوخته خرمن چه کنم",},
new Hafez{ Id= 2893, BeytNo = 5, GhazalNo = 345, Mesra1 = "شاه ترکان چو پسنديد و به چاهم انداخت", Mesra2 = "دستگير ار نشود لطف تهمتن چه کنم",},
new Hafez{ Id= 2894, BeytNo = 6, GhazalNo = 345, Mesra1 = "مددی گر به چراغی نکند آتش طور", Mesra2 = "چاره تيره شب وادی ايمن چه کنم",},
new Hafez{ Id= 2895, BeytNo = 7, GhazalNo = 345, Mesra1 = "حافظا خلد برين خانه موروث من است", Mesra2 = "اندر اين منزل ويرانه نشيمن چه کنم",},
new Hafez{ Id= 2896, BeytNo = 1, GhazalNo = 346, Mesra1 = "من نه آن رندم که ترک شاهد و ساغر کنم", Mesra2 = "محتسب داند که من اين کارها کمتر کنم",},
new Hafez{ Id= 2897, BeytNo = 2, GhazalNo = 346, Mesra1 = "من که عيب توبه کاران کرده باشم بارها", Mesra2 = "توبه از می وقت گل ديوانه باشم گر کنم",},
new Hafez{ Id= 2898, BeytNo = 3, GhazalNo = 346, Mesra1 = "عشق دردانه‌ست و من غواص و دريا ميکده", Mesra2 = "سر فروبردم در آن جا تا کجا سر برکنم",},
new Hafez{ Id= 2899, BeytNo = 4, GhazalNo = 346, Mesra1 = "لاله ساغرگير و نرگس مست و بر ما نام فسق", Mesra2 = "داوری دارم بسی يا رب که را داور کنم",},
new Hafez{ Id= 2900, BeytNo = 5, GhazalNo = 346, Mesra1 = "بازکش يک دم عنان ای ترک شهرآشوب من", Mesra2 = "تا ز اشک و چهره راهت پرزر و گوهر کنم",},
new Hafez{ Id= 2901, BeytNo = 6, GhazalNo = 346, Mesra1 = "من که از ياقوت و لعل اشک دارم گنج‌ها", Mesra2 = "کی نظر در فيض خورشيد بلنداختر کنم",},
new Hafez{ Id= 2902, BeytNo = 7, GhazalNo = 346, Mesra1 = "چون صبا مجموعه گل را به آب لطف شست", Mesra2 = "کجدلم خوان گر نظر بر صفحه دفتر کنم",},
new Hafez{ Id= 2903, BeytNo = 8, GhazalNo = 346, Mesra1 = "عهد و پيمان فلک را نيست چندان اعتبار", Mesra2 = "عهد با پيمانه بندم شرط با ساغر کنم",},
new Hafez{ Id= 2904, BeytNo = 9, GhazalNo = 346, Mesra1 = "من که دارم در گدايی گنج سلطانی به دست", Mesra2 = "کی طمع در گردش گردون دون پرور کنم",},
new Hafez{ Id= 2905, BeytNo = 10, GhazalNo = 346, Mesra1 = "گر چه گردآلود فقرم شرم باد از همتم", Mesra2 = "گر به آب چشمه خورشيد دامن تر کنم",},
new Hafez{ Id= 2906, BeytNo = 11, GhazalNo = 346, Mesra1 = "عاشقان را گر در آتش می‌پسندد لطف دوست", Mesra2 = "تنگ چشمم گر نظر در چشمه کوثر کنم",},
new Hafez{ Id= 2907, BeytNo = 12, GhazalNo = 346, Mesra1 = "دوش لعلش عشوه‌ای می‌داد حافظ را ولی", Mesra2 = "من نه آنم کز وی اين افسانه‌ها باور کنم",},
new Hafez{ Id= 2908, BeytNo = 1, GhazalNo = 347, Mesra1 = "صنما با غم عشق تو چه تدبير کنم", Mesra2 = "تا به کی در غم تو ناله شبگير کنم",},
new Hafez{ Id= 2909, BeytNo = 2, GhazalNo = 347, Mesra1 = "دل ديوانه از آن شد که نصيحت شنود", Mesra2 = "مگرش هم ز سر زلف تو زنجير کنم",},
new Hafez{ Id= 2910, BeytNo = 3, GhazalNo = 347, Mesra1 = "آن چه در مدت هجر تو کشيدم هيهات", Mesra2 = "در يکی نامه محال است که تحرير کنم",},
new Hafez{ Id= 2911, BeytNo = 4, GhazalNo = 347, Mesra1 = "با سر زلف تو مجموع پريشانی خود", Mesra2 = "کو مجالی که سراسر همه تقرير کنم",},
new Hafez{ Id= 2912, BeytNo = 5, GhazalNo = 347, Mesra1 = "آن زمان کرزوی ديدن جانم باشد", Mesra2 = "در نظر نقش رخ خوب تو تصوير کنم",},
new Hafez{ Id= 2913, BeytNo = 6, GhazalNo = 347, Mesra1 = "گر بدانم که وصال تو بدين دست دهد", Mesra2 = "دين و دل را همه دربازم و توفير کنم",},
new Hafez{ Id= 2914, BeytNo = 7, GhazalNo = 347, Mesra1 = "دور شو از برم ای واعظ و بيهوده مگوی", Mesra2 = "من نه آنم که دگر گوش به تزوير کنم",},
new Hafez{ Id= 2915, BeytNo = 8, GhazalNo = 347, Mesra1 = "نيست اميد صلاحی ز فساد حافظ", Mesra2 = "چون که تقدير چنين است چه تدبير کنم",},
new Hafez{ Id= 2916, BeytNo = 1, GhazalNo = 348, Mesra1 = "ديده دريا کنم و صبر به صحرا فکنم", Mesra2 = "و اندر اين کار دل خويش به دريا فکنم",},
new Hafez{ Id= 2917, BeytNo = 2, GhazalNo = 348, Mesra1 = "از دل تنگ گنهکار برآرم آهی", Mesra2 = "کتش اندر گنه آدم و حوا فکنم",},
new Hafez{ Id= 2918, BeytNo = 3, GhazalNo = 348, Mesra1 = "مايه خوشدلی آن جاست که دلدار آن جاست", Mesra2 = "می‌کنم جهد که خود را مگر آن جا فکنم",},
new Hafez{ Id= 2919, BeytNo = 4, GhazalNo = 348, Mesra1 = "بگشا بند قبا ای مه خورشيدکلاه", Mesra2 = "تا چو زلفت سر سودازده در پا فکنم",},
new Hafez{ Id= 2920, BeytNo = 5, GhazalNo = 348, Mesra1 = "خورده‌ام تير فلک باده بده تا سرمست", Mesra2 = "عقده دربند کمر ترکش جوزا فکنم",},
new Hafez{ Id= 2921, BeytNo = 6, GhazalNo = 348, Mesra1 = "جرعه جام بر اين تخت روان افشانم", Mesra2 = "غلغل چنگ در اين گنبد مينا فکنم",},
new Hafez{ Id= 2922, BeytNo = 7, GhazalNo = 348, Mesra1 = "حافظا تکيه بر ايام چو سهو است و خطا", Mesra2 = "من چرا عشرت امروز به فردا فکنم",},
new Hafez{ Id= 2923, BeytNo = 1, GhazalNo = 349, Mesra1 = "دوش سودای رخش گفتم ز سر بيرون کنم", Mesra2 = "گفت کو زنجير تا تدبير اين مجنون کنم",},
new Hafez{ Id= 2924, BeytNo = 2, GhazalNo = 349, Mesra1 = "قامتش را سرو گفتم سر کشيد از من به خشم", Mesra2 = "دوستان از راست می‌رنجد نگارم چون کنم",},
new Hafez{ Id= 2925, BeytNo = 3, GhazalNo = 349, Mesra1 = "نکته ناسنجيده گفتم دلبرا معذور دار", Mesra2 = "عشوه‌ای فرمای تا من طبع را موزون کنم",},
new Hafez{ Id= 2926, BeytNo = 4, GhazalNo = 349, Mesra1 = "زردرويی می‌کشم زان طبع نازک بی‌گناه", Mesra2 = "ساقيا جامی بده تا چهره را گلگون کنم",},
new Hafez{ Id= 2927, BeytNo = 5, GhazalNo = 349, Mesra1 = "ای نسيم منزل ليلی خدا را تا به کی", Mesra2 = "ربع را برهم زنم اطلال را جيحون کنم",},
new Hafez{ Id= 2928, BeytNo = 6, GhazalNo = 349, Mesra1 = "من که ره بردم به گنج حسن بی‌پايان دوست", Mesra2 = "صد گدای همچو خود را بعد از اين قارون کنم",},
new Hafez{ Id= 2929, BeytNo = 7, GhazalNo = 349, Mesra1 = "ای مه صاحب قران از بنده حافظ ياد کن", Mesra2 = "تا دعای دولت آن حسن روزافزون کنم",},
new Hafez{ Id= 2930, BeytNo = 1, GhazalNo = 350, Mesra1 = "به عزم توبه سحر گفتم استخاره کنم", Mesra2 = "بهار توبه شکن می‌رسد چه چاره کنم",},
new Hafez{ Id= 2931, BeytNo = 2, GhazalNo = 350, Mesra1 = "سخن درست بگويم نمی‌توانم ديد", Mesra2 = "که می خورند حريفان و من نظاره کنم",},
new Hafez{ Id= 2932, BeytNo = 3, GhazalNo = 350, Mesra1 = "چو غنچه با لب خندان به ياد مجلس شاه", Mesra2 = "پياله گيرم و از شوق جامه پاره کنم",},
new Hafez{ Id= 2933, BeytNo = 4, GhazalNo = 350, Mesra1 = "به دور لاله دماغ مرا علاج کنيد", Mesra2 = "گر از ميانه بزم طرب کناره کنم",},
new Hafez{ Id= 2934, BeytNo = 5, GhazalNo = 350, Mesra1 = "ز روی دوست مرا چون گل مراد شکفت", Mesra2 = "حواله سر دشمن به سنگ خاره کنم",},
new Hafez{ Id= 2935, BeytNo = 6, GhazalNo = 350, Mesra1 = "گدای ميکده‌ام ليک وقت مستی بين", Mesra2 = "که ناز بر فلک و حکم بر ستاره کنم",},
new Hafez{ Id= 2936, BeytNo = 7, GhazalNo = 350, Mesra1 = "مرا که نيست ره و رسم لقمه پرهيزی", Mesra2 = "چرا ملامت رند شرابخواره کنم",},
new Hafez{ Id= 2937, BeytNo = 8, GhazalNo = 350, Mesra1 = "به تخت گل بنشانم بتی چو سلطانی", Mesra2 = "ز سنبل و سمنش ساز طوق و ياره کنم",},
new Hafez{ Id= 2938, BeytNo = 9, GhazalNo = 350, Mesra1 = "ز باده خوردن پنهان ملول شد حافظ", Mesra2 = "به بانگ بربط و نی رازش آشکاره کنم",},
new Hafez{ Id= 2939, BeytNo = 1, GhazalNo = 351, Mesra1 = "حاشا که من به موسم گل ترک می کنم", Mesra2 = "من لاف عقل می‌زنم اين کار کی کنم",},
new Hafez{ Id= 2940, BeytNo = 2, GhazalNo = 351, Mesra1 = "مطرب کجاست تا همه محصول زهد و علم", Mesra2 = "در کار چنگ و بربط و آواز نی کنم",},
new Hafez{ Id= 2941, BeytNo = 3, GhazalNo = 351, Mesra1 = "از قيل و قال مدرسه حالی دلم گرفت", Mesra2 = "يک چند نيز خدمت معشوق و می کنم",},
new Hafez{ Id= 2942, BeytNo = 4, GhazalNo = 351, Mesra1 = "کی بود در زمانه وفا جام می بيار", Mesra2 = "تا من حکايت جم و کاووس کی کنم",},
new Hafez{ Id= 2943, BeytNo = 5, GhazalNo = 351, Mesra1 = "از نامه سياه نترسم که روز حشر", Mesra2 = "با فيض لطف او صد از اين نامه طی کنم",},
new Hafez{ Id= 2944, BeytNo = 6, GhazalNo = 351, Mesra1 = "کو پيک صبح تا گله‌های شب فراق", Mesra2 = "با آن خجسته طالع فرخنده پی کنم",},
new Hafez{ Id= 2945, BeytNo = 7, GhazalNo = 351, Mesra1 = "اين جان عاريت که به حافظ سپرد دوست", Mesra2 = "روزی رخش ببينم و تسليم وی کنم",},
new Hafez{ Id= 2946, BeytNo = 1, GhazalNo = 352, Mesra1 = "روزگاری شد که در ميخانه خدمت می‌کنم", Mesra2 = "در لباس فقر کار اهل دولت می‌کنم",},
new Hafez{ Id= 2947, BeytNo = 2, GhazalNo = 352, Mesra1 = "تا کی اندر دام وصل آرم تذروی خوش خرام", Mesra2 = "در کمينم و انتظار وقت فرصت می‌کنم",},
new Hafez{ Id= 2948, BeytNo = 3, GhazalNo = 352, Mesra1 = "واعظ ما بوی حق نشنيد بشنو کاين سخن", Mesra2 = "در حضورش نيز می‌گويم نه غيبت می‌کنم",},
new Hafez{ Id= 2949, BeytNo = 4, GhazalNo = 352, Mesra1 = "با صبا افتان و خيزان می‌روم تا کوی دوست", Mesra2 = "و از رفيقان ره استمداد همت می‌کنم",},
new Hafez{ Id= 2950, BeytNo = 5, GhazalNo = 352, Mesra1 = "خاک کويت زحمت ما برنتابد بيش از اين", Mesra2 = "لطف‌ها کردی بتا تخفيف زحمت می‌کنم",},
new Hafez{ Id= 2951, BeytNo = 6, GhazalNo = 352, Mesra1 = "زلف دلبر دام راه و غمزه‌اش تير بلاست", Mesra2 = "ياد دار ای دل که چندينت نصيحت می‌کنم",},
new Hafez{ Id= 2952, BeytNo = 7, GhazalNo = 352, Mesra1 = "ديده بدبين بپوشان ای کريم عيب پوش", Mesra2 = "زين دليری‌ها که من در کنج خلوت می‌کنم",},
new Hafez{ Id= 2953, BeytNo = 8, GhazalNo = 352, Mesra1 = "حافظم در مجلسی دردی کشم در محفلی", Mesra2 = "بنگر اين شوخی که چون با خلق صنعت می‌کنم",},
new Hafez{ Id= 2954, BeytNo = 1, GhazalNo = 353, Mesra1 = "من ترک عشق شاهد و ساغر نمی‌کنم", Mesra2 = "صد بار توبه کردم و ديگر نمی‌کنم",},
new Hafez{ Id= 2955, BeytNo = 2, GhazalNo = 353, Mesra1 = "باغ بهشت و سايه طوبی و قصر و حور", Mesra2 = "با خاک کوی دوست برابر نمی‌کنم",},
new Hafez{ Id= 2956, BeytNo = 3, GhazalNo = 353, Mesra1 = "تلقين و درس اهل نظر يک اشارت است", Mesra2 = "گفتم کنايتی و مکرر نمی‌کنم",},
new Hafez{ Id= 2957, BeytNo = 4, GhazalNo = 353, Mesra1 = "هرگز نمی‌شود ز سر خود خبر مرا", Mesra2 = "تا در ميان ميکده سر بر نمی‌کنم",},
new Hafez{ Id= 2958, BeytNo = 5, GhazalNo = 353, Mesra1 = "ناصح به طعن گفت که رو ترک عشق کن", Mesra2 = "محتاج جنگ نيست برادر نمی‌کنم",},
new Hafez{ Id= 2959, BeytNo = 6, GhazalNo = 353, Mesra1 = "اين تقواام تمام که با شاهدان شهر", Mesra2 = "ناز و کرشمه بر سر منبر نمی‌کنم",},
new Hafez{ Id= 2960, BeytNo = 7, GhazalNo = 353, Mesra1 = "حافظ جناب پير مغان جای دولت است", Mesra2 = "من ترک خاک بوسی اين در نمی‌کنم",},
new Hafez{ Id= 2961, BeytNo = 1, GhazalNo = 354, Mesra1 = "به مژگان سيه کردی هزاران رخنه در دينم", Mesra2 = "بيا کز چشم بيمارت هزاران درد برچينم",},
new Hafez{ Id= 2962, BeytNo = 2, GhazalNo = 354, Mesra1 = "الا ای همنشين دل که يارانت برفت از ياد", Mesra2 = "مرا روزی مباد آن دم که بی ياد تو بنشينم",},
new Hafez{ Id= 2963, BeytNo = 3, GhazalNo = 354, Mesra1 = "جهان پير است و بی‌بنياد از اين فرهادکش فرياد", Mesra2 = "که کرد افسون و نيرنگش ملول از جان شيرينم",},
new Hafez{ Id= 2964, BeytNo = 4, GhazalNo = 354, Mesra1 = "ز تاب آتش دوری شدم غرق عرق چون گل", Mesra2 = "بيار ای باد شبگيری نسيمی زان عرق چينم",},
new Hafez{ Id= 2965, BeytNo = 5, GhazalNo = 354, Mesra1 = "جهان فانی و باقی فدای شاهد و ساقی", Mesra2 = "که سلطانی عالم را طفيل عشق می‌بينم",},
new Hafez{ Id= 2966, BeytNo = 6, GhazalNo = 354, Mesra1 = "اگر بر جای من غيری گزيند دوست حاکم اوست", Mesra2 = "حرامم باد اگر من جان به جای دوست بگزينم",},
new Hafez{ Id= 2967, BeytNo = 7, GhazalNo = 354, Mesra1 = "صباح الخير زد بلبل کجايی ساقيا برخيز", Mesra2 = "که غوغا می‌کند در سر خيال خواب دوشينم",},
new Hafez{ Id= 2968, BeytNo = 8, GhazalNo = 354, Mesra1 = "شب رحلت هم از بستر روم در قصر حورالعين", Mesra2 = "اگر در وقت جان دادن تو باشی شمع بالينم",},
new Hafez{ Id= 2969, BeytNo = 9, GhazalNo = 354, Mesra1 = "حديث آرزومندی که در اين نامه ثبت افتاد", Mesra2 = "همانا بی‌غلط باشد که حافظ داد تلقينم",},
new Hafez{ Id= 2970, BeytNo = 1, GhazalNo = 355, Mesra1 = "حاليا مصلحت وقت در آن می‌بينم", Mesra2 = "که کشم رخت به ميخانه و خوش بنشينم",},
new Hafez{ Id= 2971, BeytNo = 2, GhazalNo = 355, Mesra1 = "جام می گيرم و از اهل ريا دور شوم", Mesra2 = "يعنی از اهل جهان پاکدلی بگزينم",},
new Hafez{ Id= 2972, BeytNo = 3, GhazalNo = 355, Mesra1 = "جز صراحی و کتابم نبود يار و نديم", Mesra2 = "تا حريفان دغا را به جهان کم بينم",},
new Hafez{ Id= 2973, BeytNo = 4, GhazalNo = 355, Mesra1 = "سر به آزادگی از خلق برآرم چون سرو", Mesra2 = "گر دهد دست که دامن ز جهان درچينم",},
new Hafez{ Id= 2974, BeytNo = 5, GhazalNo = 355, Mesra1 = "بس که در خرقه آلوده زدم لاف صلاح", Mesra2 = "شرمسار از رخ ساقی و می رنگينم",},
new Hafez{ Id= 2975, BeytNo = 6, GhazalNo = 355, Mesra1 = "سينه تنگ من و بار غم او هيهات", Mesra2 = "مرد اين بار گران نيست دل مسکينم",},
new Hafez{ Id= 2976, BeytNo = 7, GhazalNo = 355, Mesra1 = "من اگر رند خراباتم و گر زاهد شهر", Mesra2 = "اين متاعم که همی‌بينی و کمتر زينم",},
new Hafez{ Id= 2977, BeytNo = 8, GhazalNo = 355, Mesra1 = "بنده آصف عهدم دلم از راه مبر", Mesra2 = "که اگر دم زنم از چرخ بخواهد کينم",},
new Hafez{ Id= 2978, BeytNo = 9, GhazalNo = 355, Mesra1 = "بر دلم گرد ستم‌هاست خدايا مپسند", Mesra2 = "که مکدر شود آيينه مهرآيينم",},
new Hafez{ Id= 2979, BeytNo = 1, GhazalNo = 356, Mesra1 = "گرم از دست برخيزد که با دلدار بنشينم", Mesra2 = "ز جام وصل می‌نوشم ز باغ عيش گل چينم",},
new Hafez{ Id= 2980, BeytNo = 2, GhazalNo = 356, Mesra1 = "شراب تلخ صوفی سوز بنيادم بخواهد برد", Mesra2 = "لبم بر لب نه ای ساقی و بستان جان شيرينم",},
new Hafez{ Id= 2981, BeytNo = 3, GhazalNo = 356, Mesra1 = "مگر ديوانه خواهم شد در اين سودا که شب تا روز", Mesra2 = "سخن با ماه می‌گويم پری در خواب می‌بينم",},
new Hafez{ Id= 2982, BeytNo = 4, GhazalNo = 356, Mesra1 = "لبت شکر به مستان داد و چشمت می به ميخواران", Mesra2 = "منم کز غايت حرمان نه با آنم نه با اينم",},
new Hafez{ Id= 2983, BeytNo = 5, GhazalNo = 356, Mesra1 = "چو هر خاکی که باد آورد فيضی برد از انعامت", Mesra2 = "ز حال بنده ياد آور که خدمتگار ديرينم",},
new Hafez{ Id= 2984, BeytNo = 6, GhazalNo = 356, Mesra1 = "نه هر کو نقش نظمی زد کلامش دلپذير افتد", Mesra2 = "تذرو طرفه من گيرم که چالاک است شاهينم",},
new Hafez{ Id= 2985, BeytNo = 7, GhazalNo = 356, Mesra1 = "اگر باور نمی‌داری رو از صورتگر چين پرس", Mesra2 = "که مانی نسخه می‌خواهد ز نوک کلک مشکينم",},
new Hafez{ Id= 2986, BeytNo = 8, GhazalNo = 356, Mesra1 = "وفاداری و حق گويی نه کار هر کسی باشد", Mesra2 = "غلام آصف ثانی جلال الحق و الدينم",},
new Hafez{ Id= 2987, BeytNo = 9, GhazalNo = 356, Mesra1 = "رموز مستی و رندی ز من بشنو نه از واعظ", Mesra2 = "که با جام و قدح هر دم نديم ماه و پروينم",},
new Hafez{ Id= 2988, BeytNo = 1, GhazalNo = 357, Mesra1 = "در خرابات مغان نور خدا می‌بينم", Mesra2 = "اين عجب بين که چه نوری ز کجا می‌بينم",},
new Hafez{ Id= 2989, BeytNo = 2, GhazalNo = 357, Mesra1 = "جلوه بر من مفروش ای ملک الحاج که تو", Mesra2 = "خانه می‌بينی و من خانه خدا می‌بينم",},
new Hafez{ Id= 2990, BeytNo = 3, GhazalNo = 357, Mesra1 = "خواهم از زلف بتان نافه گشايی کردن", Mesra2 = "فکر دور است همانا که خطا می‌بينم",},
new Hafez{ Id= 2991, BeytNo = 4, GhazalNo = 357, Mesra1 = "سوز دل اشک روان آه سحر ناله شب", Mesra2 = "اين همه از نظر لطف شما می‌بينم",},
new Hafez{ Id= 2992, BeytNo = 5, GhazalNo = 357, Mesra1 = "هر دم از روی تو نقشی زندم راه خيال", Mesra2 = "با که گويم که در اين پرده چه‌ها می‌بينم",},
new Hafez{ Id= 2993, BeytNo = 6, GhazalNo = 357, Mesra1 = "کس نديده‌ست ز مشک ختن و نافه چين", Mesra2 = "آن چه من هر سحر از باد صبا می‌بينم",},
new Hafez{ Id= 2994, BeytNo = 7, GhazalNo = 357, Mesra1 = "دوستان عيب نظربازی حافظ مکنيد", Mesra2 = "که من او را ز محبان شما می‌بينم",},
new Hafez{ Id= 2995, BeytNo = 1, GhazalNo = 358, Mesra1 = "غم زمانه که هيچش کران نمی‌بينم", Mesra2 = "دواش جز می چون ارغوان نمی‌بينم",},
new Hafez{ Id= 2996, BeytNo = 2, GhazalNo = 358, Mesra1 = "به ترک خدمت پير مغان نخواهم گفت", Mesra2 = "چرا که مصلحت خود در آن نمی‌بينم",},
new Hafez{ Id= 2997, BeytNo = 3, GhazalNo = 358, Mesra1 = "ز آفتاب قدح ارتفاع عيش بگير", Mesra2 = "چرا که طالع وقت آن چنان نمی‌بينم",},
new Hafez{ Id= 2998, BeytNo = 4, GhazalNo = 358, Mesra1 = "نشان اهل خدا عاشقيست با خود دار", Mesra2 = "که در مشايخ شهر اين نشان نمی‌بينم",},
new Hafez{ Id= 2999, BeytNo = 5, GhazalNo = 358, Mesra1 = "بدين دو ديده حيران من هزار افسوس", Mesra2 = "که با دو آينه رويش عيان نمی‌بينم",},
new Hafez{ Id= 3000, BeytNo = 6, GhazalNo = 358, Mesra1 = "قد تو تا بشد از جويبار ديده من", Mesra2 = "به جای سرو جز آب روان نمی‌بينم",},
new Hafez{ Id= 3001, BeytNo = 7, GhazalNo = 358, Mesra1 = "در اين خمار کسم جرعه‌ای نمی‌بخشد", Mesra2 = "ببين که اهل دلی در ميان نمی‌بينم",},
new Hafez{ Id= 3002, BeytNo = 8, GhazalNo = 358, Mesra1 = "نشان موی ميانش که دل در او بستم", Mesra2 = "ز من مپرس که خود در ميان نمی‌بينم",},
new Hafez{ Id= 3003, BeytNo = 9, GhazalNo = 358, Mesra1 = "من و سفينه حافظ که جز در اين دريا", Mesra2 = "بضاعت سخن درفشان نمی‌بينم",},
new Hafez{ Id= 3004, BeytNo = 1, GhazalNo = 359, Mesra1 = "خرم آن روز کز اين منزل ويران بروم", Mesra2 = "راحت جان طلبم و از پی جانان بروم",},
new Hafez{ Id= 3005, BeytNo = 2, GhazalNo = 359, Mesra1 = "گر چه دانم که به جايی نبرد راه غريب", Mesra2 = "من به بوی سر آن زلف پريشان بروم",},
new Hafez{ Id= 3006, BeytNo = 3, GhazalNo = 359, Mesra1 = "دلم از وحشت زندان سکندر بگرفت", Mesra2 = "رخت بربندم و تا ملک سليمان بروم",},
new Hafez{ Id= 3007, BeytNo = 4, GhazalNo = 359, Mesra1 = "چون صبا با تن بيمار و دل بی‌طاقت", Mesra2 = "به هواداری آن سرو خرامان بروم",},
new Hafez{ Id= 3008, BeytNo = 5, GhazalNo = 359, Mesra1 = "در ره او چو قلم گر به سرم بايد رفت", Mesra2 = "با دل زخم کش و ديده گريان بروم",},
new Hafez{ Id= 3009, BeytNo = 6, GhazalNo = 359, Mesra1 = "نذر کردم گر از اين غم به درآيم روزی", Mesra2 = "تا در ميکده شادان و غزل خوان بروم",},
new Hafez{ Id= 3010, BeytNo = 7, GhazalNo = 359, Mesra1 = "به هواداری او ذره صفت رقص کنان", Mesra2 = "تا لب چشمه خورشيد درخشان بروم",},
new Hafez{ Id= 3011, BeytNo = 8, GhazalNo = 359, Mesra1 = "تازيان را غم احوال گران باران نيست", Mesra2 = "پارسايان مددی تا خوش و آسان بروم",},
new Hafez{ Id= 3012, BeytNo = 9, GhazalNo = 359, Mesra1 = "ور چو حافظ ز بيابان نبرم ره بيرون", Mesra2 = "همره کوکبه آصف دوران بروم",},
new Hafez{ Id= 3013, BeytNo = 1, GhazalNo = 360, Mesra1 = "گر از اين منزل ويران به سوی خانه روم", Mesra2 = "دگر آن جا که روم عاقل و فرزانه روم",},
new Hafez{ Id= 3014, BeytNo = 2, GhazalNo = 360, Mesra1 = "زين سفر گر به سلامت به وطن بازرسم", Mesra2 = "نذر کردم که هم از راه به ميخانه روم",},
new Hafez{ Id= 3015, BeytNo = 3, GhazalNo = 360, Mesra1 = "تا بگويم که چه کشفم شد از اين سير و سلوک", Mesra2 = "به در صومعه با بربط و پيمانه روم",},
new Hafez{ Id= 3016, BeytNo = 4, GhazalNo = 360, Mesra1 = "آشنايان ره عشق گرم خون بخورند", Mesra2 = "ناکسم گر به شکايت سوی بيگانه روم",},
new Hafez{ Id= 3017, BeytNo = 5, GhazalNo = 360, Mesra1 = "بعد از اين دست من و زلف چو زنجير نگار", Mesra2 = "چند و چند از پی کام دل ديوانه روم",},
new Hafez{ Id= 3018, BeytNo = 6, GhazalNo = 360, Mesra1 = "گر ببينم خم ابروی چو محرابش باز", Mesra2 = "سجده شکر کنم و از پی شکرانه روم",},
new Hafez{ Id= 3019, BeytNo = 7, GhazalNo = 360, Mesra1 = "خرم آن دم که چو حافظ به تولای وزير", Mesra2 = "سرخوش از ميکده با دوست به کاشانه روم",},
new Hafez{ Id= 3020, BeytNo = 1, GhazalNo = 361, Mesra1 = "آن که پامال جفا کرد چو خاک راهم", Mesra2 = "خاک می‌بوسم و عذر قدمش می‌خواهم",},
new Hafez{ Id= 3021, BeytNo = 2, GhazalNo = 361, Mesra1 = "من نه آنم که ز جور تو بنالم حاشا", Mesra2 = "بنده معتقد و چاکر دولتخواهم",},
new Hafez{ Id= 3022, BeytNo = 3, GhazalNo = 361, Mesra1 = "بسته‌ام در خم گيسوی تو اميد دراز", Mesra2 = "آن مبادا که کند دست طلب کوتاهم",},
new Hafez{ Id= 3023, BeytNo = 4, GhazalNo = 361, Mesra1 = "ذره خاکم و در کوی توام جای خوش است", Mesra2 = "ترسم ای دوست که بادی ببرد ناگاهم",},
new Hafez{ Id= 3024, BeytNo = 5, GhazalNo = 361, Mesra1 = "پير ميخانه سحر جام جهان بينم داد", Mesra2 = "و اندر آن آينه از حسن تو کرد آگاهم",},
new Hafez{ Id= 3025, BeytNo = 6, GhazalNo = 361, Mesra1 = "صوفی صومعه عالم قدسم ليکن", Mesra2 = "حاليا دير مغان است حوالتگاهم",},
new Hafez{ Id= 3026, BeytNo = 7, GhazalNo = 361, Mesra1 = "با من راه نشين خيز و سوی ميکده آی", Mesra2 = "تا در آن حلقه ببينی که چه صاحب جاهم",},
new Hafez{ Id= 3027, BeytNo = 8, GhazalNo = 361, Mesra1 = "مست بگذشتی و از حافظت انديشه نبود", Mesra2 = "آه اگر دامن حسن تو بگيرد آهم",},
new Hafez{ Id= 3028, BeytNo = 9, GhazalNo = 361, Mesra1 = "خوشم آمد که سحر خسرو خاور می‌گفت", Mesra2 = "با همه پادشهی بنده تورانشاهم",},
new Hafez{ Id= 3029, BeytNo = 1, GhazalNo = 362, Mesra1 = "ديدار شد ميسر و بوس و کنار هم", Mesra2 = "از بخت شکر دارم و از روزگار هم",},
new Hafez{ Id= 3030, BeytNo = 2, GhazalNo = 362, Mesra1 = "زاهد برو که طالع اگر طالع من است", Mesra2 = "جامم به دست باشد و زلف نگار هم",},
new Hafez{ Id= 3031, BeytNo = 3, GhazalNo = 362, Mesra1 = "ما عيب کس به مستی و رندی نمی‌کنيم", Mesra2 = "لعل بتان خوش است و می خوشگوار هم",},
new Hafez{ Id= 3032, BeytNo = 4, GhazalNo = 362, Mesra1 = "ای دل بشارتی دهمت محتسب نماند", Mesra2 = "و از می جهان پر است و بت ميگسار هم",},
new Hafez{ Id= 3033, BeytNo = 5, GhazalNo = 362, Mesra1 = "خاطر به دست تفرقه دادن نه زيرکيست", Mesra2 = "مجموعه‌ای بخواه و صراحی بيار هم",},
new Hafez{ Id= 3034, BeytNo = 6, GhazalNo = 362, Mesra1 = "بر خاکيان عشق فشان جرعه لبش", Mesra2 = "تا خاک لعل گون شود و مشکبار هم",},
new Hafez{ Id= 3035, BeytNo = 7, GhazalNo = 362, Mesra1 = "آن شد که چشم بد نگران بودی از کمين", Mesra2 = "خصم از ميان برفت و سرشک از کنار هم",},
new Hafez{ Id= 3036, BeytNo = 8, GhazalNo = 362, Mesra1 = "چون کانات جمله به بوی تو زنده‌اند", Mesra2 = "ای آفتاب سايه ز ما برمدار هم",},
new Hafez{ Id= 3037, BeytNo = 9, GhazalNo = 362, Mesra1 = "چون آب روی لاله و گل فيض حسن توست", Mesra2 = "ای ابر لطف بر من خاکی ببار هم",},
new Hafez{ Id= 3038, BeytNo = 10, GhazalNo = 362, Mesra1 = "حافظ اسير زلف تو شد از خدا بترس", Mesra2 = "و از انتصاف آصف جم اقتدار هم",},
new Hafez{ Id= 3039, BeytNo = 11, GhazalNo = 362, Mesra1 = "برهان ملک و دين که ز دست وزارتش", Mesra2 = "ايام کان يمين شد و دريا يسار هم",},
new Hafez{ Id= 3040, BeytNo = 12, GhazalNo = 362, Mesra1 = "بر ياد رای انور او آسمان به صبح", Mesra2 = "جان می‌کند فدا و کواکب نثار هم",},
new Hafez{ Id= 3041, BeytNo = 13, GhazalNo = 362, Mesra1 = "گوی زمين ربوده چوگان عدل اوست", Mesra2 = "وين برکشيده گنبد نيلی حصار هم",},
new Hafez{ Id= 3042, BeytNo = 14, GhazalNo = 362, Mesra1 = "عزم سبک عنان تو در جنبش آورد", Mesra2 = "اين پايدار مرکز عالی مدار هم",},
new Hafez{ Id= 3043, BeytNo = 15, GhazalNo = 362, Mesra1 = "تا از نتيجه فلک و طور دور اوست", Mesra2 = "تبديل ماه و سال و خزان و بهار هم",},
new Hafez{ Id= 3044, BeytNo = 16, GhazalNo = 362, Mesra1 = "خالی مباد کاخ جلالش ز سروران", Mesra2 = "و از ساقيان سروقد گلعذار هم",},
new Hafez{ Id= 3045, BeytNo = 1, GhazalNo = 363, Mesra1 = "دردم از يار است و درمان نيز هم", Mesra2 = "دل فدای او شد و جان نيز هم",},
new Hafez{ Id= 3046, BeytNo = 2, GhazalNo = 363, Mesra1 = "اين که می‌گويند آن خوشتر ز حسن", Mesra2 = "يار ما اين دارد و آن نيز هم",},
new Hafez{ Id= 3047, BeytNo = 3, GhazalNo = 363, Mesra1 = "ياد باد آن کو به قصد خون ما", Mesra2 = "عهد را بشکست و پيمان نيز هم",},
new Hafez{ Id= 3048, BeytNo = 4, GhazalNo = 363, Mesra1 = "دوستان در پرده می‌گويم سخن", Mesra2 = "گفته خواهد شد به دستان نيز هم",},
new Hafez{ Id= 3049, BeytNo = 5, GhazalNo = 363, Mesra1 = "چون سر آمد دولت شب‌های وصل", Mesra2 = "بگذرد ايام هجران نيز هم",},
new Hafez{ Id= 3050, BeytNo = 6, GhazalNo = 363, Mesra1 = "هر دو عالم يک فروغ روی اوست", Mesra2 = "گفتمت پيدا و پنهان نيز هم",},
new Hafez{ Id= 3051, BeytNo = 7, GhazalNo = 363, Mesra1 = "اعتمادی نيست بر کار جهان", Mesra2 = "بلکه بر گردون گردان نيز هم",},
new Hafez{ Id= 3052, BeytNo = 8, GhazalNo = 363, Mesra1 = "عاشق از قاضی نترسد می بيار", Mesra2 = "بلکه از يرغوی ديوان نيز هم",},
new Hafez{ Id= 3053, BeytNo = 9, GhazalNo = 363, Mesra1 = "محتسب داند که حافظ عاشق است", Mesra2 = "و آصف ملک سليمان نيز هم",},
new Hafez{ Id= 3054, BeytNo = 1, GhazalNo = 364, Mesra1 = "ما بی غمان مست دل از دست داده‌ايم", Mesra2 = "همراز عشق و همنفس جام باده‌ايم",},
new Hafez{ Id= 3055, BeytNo = 2, GhazalNo = 364, Mesra1 = "بر ما بسی کمان ملامت کشيده‌اند", Mesra2 = "تا کار خود ز ابروی جانان گشاده‌ايم",},
new Hafez{ Id= 3056, BeytNo = 3, GhazalNo = 364, Mesra1 = "ای گل تو دوش داغ صبوحی کشيده‌ای", Mesra2 = "ما آن شقايقيم که با داغ زاده‌ايم",},
new Hafez{ Id= 3057, BeytNo = 4, GhazalNo = 364, Mesra1 = "پير مغان ز توبه ما گر ملول شد", Mesra2 = "گو باده صاف کن که به عذر ايستاده‌ايم",},
new Hafez{ Id= 3058, BeytNo = 5, GhazalNo = 364, Mesra1 = "کار از تو می‌رود مددی ای دليل راه", Mesra2 = "کانصاف می‌دهيم و ز راه اوفتاده‌ايم",},
new Hafez{ Id= 3059, BeytNo = 6, GhazalNo = 364, Mesra1 = "چون لاله می مبين و قدح در ميان کار", Mesra2 = "اين داغ بين که بر دل خونين نهاده‌ايم",},
new Hafez{ Id= 3060, BeytNo = 7, GhazalNo = 364, Mesra1 = "گفتی که حافظ اين همه رنگ و خيال چيست", Mesra2 = "نقش غلط مبين که همان لوح ساده‌ايم",},
new Hafez{ Id= 3061, BeytNo = 1, GhazalNo = 365, Mesra1 = "عمريست تا به راه غمت رو نهاده‌ايم", Mesra2 = "روی و ريای خلق به يک سو نهاده‌ايم",},
new Hafez{ Id= 3062, BeytNo = 2, GhazalNo = 365, Mesra1 = "طاق و رواق مدرسه و قال و قيل علم", Mesra2 = "در راه جام و ساقی مه رو نهاده‌ايم",},
new Hafez{ Id= 3063, BeytNo = 3, GhazalNo = 365, Mesra1 = "هم جان بدان دو نرگس جادو سپرده‌ايم", Mesra2 = "هم دل بدان دو سنبل هندو نهاده‌ايم",},
new Hafez{ Id= 3064, BeytNo = 4, GhazalNo = 365, Mesra1 = "عمری گذشت تا به اميد اشارتی", Mesra2 = "چشمی بدان دو گوشه ابرو نهاده‌ايم",},
new Hafez{ Id= 3065, BeytNo = 5, GhazalNo = 365, Mesra1 = "ما ملک عافيت نه به لشکر گرفته‌ايم", Mesra2 = "ما تخت سلطنت نه به بازو نهاده‌ايم",},
new Hafez{ Id= 3066, BeytNo = 6, GhazalNo = 365, Mesra1 = "تا سحر چشم يار چه بازی کند که باز", Mesra2 = "بنياد بر کرشمه جادو نهاده‌ايم",},
new Hafez{ Id= 3067, BeytNo = 7, GhazalNo = 365, Mesra1 = "بی زلف سرکشش سر سودايی از ملال", Mesra2 = "همچون بنفشه بر سر زانو نهاده‌ايم",},
new Hafez{ Id= 3068, BeytNo = 8, GhazalNo = 365, Mesra1 = "در گوشه اميد چو نظارگان ماه", Mesra2 = "چشم طلب بر آن خم ابرو نهاده‌ايم",},
new Hafez{ Id= 3069, BeytNo = 9, GhazalNo = 365, Mesra1 = "گفتی که حافظا دل سرگشته‌ات کجاست", Mesra2 = "در حلقه‌های آن خم گيسو نهاده‌ايم",},
new Hafez{ Id= 3070, BeytNo = 1, GhazalNo = 366, Mesra1 = "ما بدين در نه پی حشمت و جاه آمده‌ايم", Mesra2 = "از بد حادثه اين جا به پناه آمده‌ايم",},
new Hafez{ Id= 3071, BeytNo = 2, GhazalNo = 366, Mesra1 = "ره رو منزل عشقيم و ز سرحد عدم", Mesra2 = "تا به اقليم وجود اين همه راه آمده‌ايم",},
new Hafez{ Id= 3072, BeytNo = 3, GhazalNo = 366, Mesra1 = "سبزه خط تو ديديم و ز بستان بهشت", Mesra2 = "به طلبکاری اين مهرگياه آمده‌ايم",},
new Hafez{ Id= 3073, BeytNo = 4, GhazalNo = 366, Mesra1 = "با چنين گنج که شد خازن او روح امين", Mesra2 = "به گدايی به در خانه شاه آمده‌ايم",},
new Hafez{ Id= 3074, BeytNo = 5, GhazalNo = 366, Mesra1 = "لنگر حلم تو ای کشتی توفيق کجاست", Mesra2 = "که در اين بحر کرم غرق گناه آمده‌ايم",},
new Hafez{ Id= 3075, BeytNo = 6, GhazalNo = 366, Mesra1 = "آبرو می‌رود ای ابر خطاپوش ببار", Mesra2 = "که به ديوان عمل نامه سياه آمده‌ايم",},
new Hafez{ Id= 3076, BeytNo = 7, GhazalNo = 366, Mesra1 = "حافظ اين خرقه پشمينه مينداز که ما", Mesra2 = "از پی قافله با آتش آه آمده‌ايم",},
new Hafez{ Id= 3077, BeytNo = 1, GhazalNo = 367, Mesra1 = "فتوی پير مغان دارم و قوليست قديم", Mesra2 = "که حرام است می آن جا که نه يار است نديم",},
new Hafez{ Id= 3078, BeytNo = 2, GhazalNo = 367, Mesra1 = "چاک خواهم زدن اين دلق ريايی چه کنم", Mesra2 = "روح را صحبت ناجنس عذابيست اليم",},
new Hafez{ Id= 3079, BeytNo = 3, GhazalNo = 367, Mesra1 = "تا مگر جرعه فشاند لب جانان بر من", Mesra2 = "سال‌ها شد که منم بر در ميخانه مقيم",},
new Hafez{ Id= 3080, BeytNo = 4, GhazalNo = 367, Mesra1 = "مگرش خدمت ديرين من از ياد برفت", Mesra2 = "ای نسيم سحری ياد دهش عهد قديم",},
new Hafez{ Id= 3081, BeytNo = 5, GhazalNo = 367, Mesra1 = "بعد صد سال اگر بر سر خاکم گذری", Mesra2 = "سر برآرد ز گلم رقص کنان عظم رميم",},
new Hafez{ Id= 3082, BeytNo = 6, GhazalNo = 367, Mesra1 = "دلبر از ما به صد اميد ستد اول دل", Mesra2 = "ظاهرا عهد فرامش نکند خلق کريم",},
new Hafez{ Id= 3083, BeytNo = 7, GhazalNo = 367, Mesra1 = "غنچه گو تنگ دل از کار فروبسته مباش", Mesra2 = "کز دم صبح مدد يابی و انفاس نسيم",},
new Hafez{ Id= 3084, BeytNo = 8, GhazalNo = 367, Mesra1 = "فکر بهبود خود ای دل ز دری ديگر کن", Mesra2 = "درد عاشق نشود به به مداوای حکيم",},
new Hafez{ Id= 3085, BeytNo = 9, GhazalNo = 367, Mesra1 = "گوهر معرفت آموز که با خود ببری", Mesra2 = "که نصيب دگران است نصاب زر و سيم",},
new Hafez{ Id= 3086, BeytNo = 10, GhazalNo = 367, Mesra1 = "دام سخت است مگر يار شود لطف خدا", Mesra2 = "ور نه آدم نبرد صرفه ز شيطان رجيم",},
new Hafez{ Id= 3087, BeytNo = 11, GhazalNo = 367, Mesra1 = "حافظ ار سيم و زرت نيست چه شد شاکر باش", Mesra2 = "چه به از دولت لطف سخن و طبع سليم",},
new Hafez{ Id= 3088, BeytNo = 1, GhazalNo = 368, Mesra1 = "خيز تا از در ميخانه گشادی طلبيم", Mesra2 = "به ره دوست نشينيم و مرادی طلبيم",},
new Hafez{ Id= 3089, BeytNo = 2, GhazalNo = 368, Mesra1 = "زاد راه حرم وصل نداريم مگر", Mesra2 = "به گدايی ز در ميکده زادی طلبيم",},
new Hafez{ Id= 3090, BeytNo = 3, GhazalNo = 368, Mesra1 = "اشک آلوده ما گر چه روان است ولی", Mesra2 = "به رسالت سوی او پاک نهادی طلبيم",},
new Hafez{ Id= 3091, BeytNo = 4, GhazalNo = 368, Mesra1 = "لذت داغ غمت بر دل ما باد حرام", Mesra2 = "اگر از جور غم عشق تو دادی طلبيم",},
new Hafez{ Id= 3092, BeytNo = 5, GhazalNo = 368, Mesra1 = "نقطه خال تو بر لوح بصر نتوان زد", Mesra2 = "مگر از مردمک ديده مدادی طلبيم",},
new Hafez{ Id= 3093, BeytNo = 6, GhazalNo = 368, Mesra1 = "عشوه‌ای از لب شيرين تو دل خواست به جان", Mesra2 = "به شکرخنده لبت گفت مزادی طلبيم",},
new Hafez{ Id= 3094, BeytNo = 7, GhazalNo = 368, Mesra1 = "تا بود نسخه عطری دل سودازده را", Mesra2 = "از خط غاليه سای تو سوادی طلبيم",},
new Hafez{ Id= 3095, BeytNo = 8, GhazalNo = 368, Mesra1 = "چون غمت را نتوان يافت مگر در دل شاد", Mesra2 = "ما به اميد غمت خاطر شادی طلبيم",},
new Hafez{ Id= 3096, BeytNo = 9, GhazalNo = 368, Mesra1 = "بر در مدرسه تا چند نشينی حافظ", Mesra2 = "خيز تا از در ميخانه گشادی طلبيم",},
new Hafez{ Id= 3097, BeytNo = 1, GhazalNo = 369, Mesra1 = "ما ز ياران چشم ياری داشتيم", Mesra2 = "خود غلط بود آن چه ما پنداشتيم",},
new Hafez{ Id= 3098, BeytNo = 2, GhazalNo = 369, Mesra1 = "تا درخت دوستی برگی دهد", Mesra2 = "حاليا رفتيم و تخمی کاشتيم",},
new Hafez{ Id= 3099, BeytNo = 3, GhazalNo = 369, Mesra1 = "گفت و گو آيين درويشی نبود", Mesra2 = "ور نه با تو ماجراها داشتيم",},
new Hafez{ Id= 3100, BeytNo = 4, GhazalNo = 369, Mesra1 = "شيوه چشمت فريب جنگ داشت", Mesra2 = "ما غلط کرديم و صلح انگاشتيم",},
new Hafez{ Id= 3101, BeytNo = 5, GhazalNo = 369, Mesra1 = "گلبن حسنت نه خود شد دلفروز", Mesra2 = "ما دم همت بر او بگماشتيم",},
new Hafez{ Id= 3102, BeytNo = 6, GhazalNo = 369, Mesra1 = "نکته‌ها رفت و شکايت کس نکرد", Mesra2 = "جانب حرمت فرونگذاشتيم",},
new Hafez{ Id= 3103, BeytNo = 7, GhazalNo = 369, Mesra1 = "گفت خود دادی به ما دل حافظا", Mesra2 = "ما محصل بر کسی نگماشتيم",},
new Hafez{ Id= 3104, BeytNo = 1, GhazalNo = 370, Mesra1 = "صلاح از ما چه می‌جويی که مستان را صلا گفتيم", Mesra2 = "به دور نرگس مستت سلامت را دعا گفتيم",},
new Hafez{ Id= 3105, BeytNo = 2, GhazalNo = 370, Mesra1 = "در ميخانه‌ام بگشا که هيچ از خانقه نگشود", Mesra2 = "گرت باور بود ور نه سخن اين بود و ما گفتيم",},
new Hafez{ Id= 3106, BeytNo = 3, GhazalNo = 370, Mesra1 = "من از چشم تو ای ساقی خراب افتاده‌ام ليکن", Mesra2 = "بلايی کز حبيب آيد هزارش مرحبا گفتيم",},
new Hafez{ Id= 3107, BeytNo = 4, GhazalNo = 370, Mesra1 = "اگر بر من نبخشايی پشيمانی خوری آخر", Mesra2 = "به خاطر دار اين معنی که در خدمت کجا گفتيم",},
new Hafez{ Id= 3108, BeytNo = 5, GhazalNo = 370, Mesra1 = "قدت گفتم که شمشاد است بس خجلت به بار آورد", Mesra2 = "که اين نسبت چرا کرديم و اين بهتان چرا گفتيم",},
new Hafez{ Id= 3109, BeytNo = 6, GhazalNo = 370, Mesra1 = "جگر چون نافه‌ام خون گشت کم زينم نمی‌بايد", Mesra2 = "جزای آن که با زلفت سخن از چين خطا گفتيم",},
new Hafez{ Id= 3110, BeytNo = 7, GhazalNo = 370, Mesra1 = "تو آتش گشتی ای حافظ ولی با يار درنگرفت", Mesra2 = "ز بدعهدی گل گويی حکايت با صبا گفتيم",},
new Hafez{ Id= 3111, BeytNo = 1, GhazalNo = 371, Mesra1 = "ما درس سحر در ره ميخانه نهاديم", Mesra2 = "محصول دعا در ره جانانه نهاديم",},
new Hafez{ Id= 3112, BeytNo = 2, GhazalNo = 371, Mesra1 = "در خرمن صد زاهد عاقل زند آتش", Mesra2 = "اين داغ که ما بر دل ديوانه نهاديم",},
new Hafez{ Id= 3113, BeytNo = 3, GhazalNo = 371, Mesra1 = "سلطان ازل گنج غم عشق به ما داد", Mesra2 = "تا روی در اين منزل ويرانه نهاديم",},
new Hafez{ Id= 3114, BeytNo = 4, GhazalNo = 371, Mesra1 = "در دل ندهم ره پس از اين مهر بتان را", Mesra2 = "مهر لب او بر در اين خانه نهاديم",},
new Hafez{ Id= 3115, BeytNo = 5, GhazalNo = 371, Mesra1 = "در خرقه از اين بيش منافق نتوان بود", Mesra2 = "بنياد از اين شيوه رندانه نهاديم",},
new Hafez{ Id= 3116, BeytNo = 6, GhazalNo = 371, Mesra1 = "چون می‌رود اين کشتی سرگشته که آخر", Mesra2 = "جان در سر آن گوهر يک دانه نهاديم",},
new Hafez{ Id= 3117, BeytNo = 7, GhazalNo = 371, Mesra1 = "المنه لله که چو ما بی‌دل و دين بود", Mesra2 = "آن را که لقب عاقل و فرزانه نهاديم",},
new Hafez{ Id= 3118, BeytNo = 8, GhazalNo = 371, Mesra1 = "قانع به خيالی ز تو بوديم چو حافظ", Mesra2 = "يا رب چه گداهمت و بيگانه نهاديم",},
new Hafez{ Id= 3119, BeytNo = 1, GhazalNo = 372, Mesra1 = "بگذار تا ز شارع ميخانه بگذريم", Mesra2 = "کز بهر جرعه‌ای همه محتاج اين دريم",},
new Hafez{ Id= 3120, BeytNo = 2, GhazalNo = 372, Mesra1 = "روز نخست چون دم رندی زديم و عشق", Mesra2 = "شرط آن بود که جز ره آن شيوه نسپريم",},
new Hafez{ Id= 3121, BeytNo = 3, GhazalNo = 372, Mesra1 = "جايی که تخت و مسند جم می‌رود به باد", Mesra2 = "گر غم خوريم خوش نبود به که می‌خوريم",},
new Hafez{ Id= 3122, BeytNo = 4, GhazalNo = 372, Mesra1 = "تا بو که دست در کمر او توان زدن", Mesra2 = "در خون دل نشسته چو ياقوت احمريم",},
new Hafez{ Id= 3123, BeytNo = 5, GhazalNo = 372, Mesra1 = "واعظ مکن نصيحت شوريدگان که ما", Mesra2 = "با خاک کوی دوست به فردوس ننگريم",},
new Hafez{ Id= 3124, BeytNo = 6, GhazalNo = 372, Mesra1 = "چون صوفيان به حالت و رقصند مقتدا", Mesra2 = "ما نيز هم به شعبده دستی برآوريم",},
new Hafez{ Id= 3125, BeytNo = 7, GhazalNo = 372, Mesra1 = "از جرعه تو خاک زمين در و لعل يافت", Mesra2 = "بيچاره ما که پيش تو از خاک کمتريم",},
new Hafez{ Id= 3126, BeytNo = 8, GhazalNo = 372, Mesra1 = "حافظ چو ره به کنگره کاخ وصل نيست", Mesra2 = "با خاک آستانه اين در به سر بريم",},
new Hafez{ Id= 3127, BeytNo = 1, GhazalNo = 373, Mesra1 = "خيز تا خرقه صوفی به خرابات بريم", Mesra2 = "شطح و طامات به بازار خرافات بريم",},
new Hafez{ Id= 3128, BeytNo = 2, GhazalNo = 373, Mesra1 = "سوی رندان قلندر به ره آورد سفر", Mesra2 = "دلق بسطامی و سجاده طامات بريم",},
new Hafez{ Id= 3129, BeytNo = 3, GhazalNo = 373, Mesra1 = "تا همه خلوتيان جام صبوحی گيرند", Mesra2 = "چنگ صبحی به در پير مناجات بريم",},
new Hafez{ Id= 3130, BeytNo = 4, GhazalNo = 373, Mesra1 = "با تو آن عهد که در وادی ايمن بستيم", Mesra2 = "همچو موسی ارنی گوی به ميقات بريم",},
new Hafez{ Id= 3131, BeytNo = 5, GhazalNo = 373, Mesra1 = "کوس ناموس تو بر کنگره عرش زنيم", Mesra2 = "علم عشق تو بر بام سماوات بريم",},
new Hafez{ Id= 3132, BeytNo = 6, GhazalNo = 373, Mesra1 = "خاک کوی تو به صحرای قيامت فردا", Mesra2 = "همه بر فرق سر از بهر مباهات بريم",},
new Hafez{ Id= 3133, BeytNo = 7, GhazalNo = 373, Mesra1 = "ور نهد در ره ما خار ملامت زاهد", Mesra2 = "از گلستانش به زندان مکافات بريم",},
new Hafez{ Id= 3134, BeytNo = 8, GhazalNo = 373, Mesra1 = "شرممان باد ز پشمينه آلوده خويش", Mesra2 = "گر بدين فضل و هنر نام کرامات بريم",},
new Hafez{ Id= 3135, BeytNo = 9, GhazalNo = 373, Mesra1 = "قدر وقت ار نشناسد دل و کاری نکند", Mesra2 = "بس خجالت که از اين حاصل اوقات بريم",},
new Hafez{ Id= 3136, BeytNo = 10, GhazalNo = 373, Mesra1 = "فتنه می‌بارد از اين سقف مقرنس برخيز", Mesra2 = "تا به ميخانه پناه از همه آفات بريم",},
new Hafez{ Id= 3137, BeytNo = 11, GhazalNo = 373, Mesra1 = "در بيابان فنا گم شدن آخر تا کی", Mesra2 = "ره بپرسيم مگر پی به مهمات بريم",},
new Hafez{ Id= 3138, BeytNo = 12, GhazalNo = 373, Mesra1 = "حافظ آب رخ خود بر در هر سفله مريز", Mesra2 = "حاجت آن به که بر قاضی حاجات بريم",},
new Hafez{ Id= 3139, BeytNo = 1, GhazalNo = 374, Mesra1 = "بيا تا گل برافشانيم و می در ساغر اندازيم", Mesra2 = "فلک را سقف بشکافيم و طرحی نو دراندازيم",},
new Hafez{ Id= 3140, BeytNo = 2, GhazalNo = 374, Mesra1 = "اگر غم لشکر انگيزد که خون عاشقان ريزد", Mesra2 = "من و ساقی به هم تازيم و بنيادش براندازيم",},
new Hafez{ Id= 3141, BeytNo = 3, GhazalNo = 374, Mesra1 = "شراب ارغوانی را گلاب اندر قدح ريزيم", Mesra2 = "نسيم عطرگردان را شکر در مجمر اندازيم",},
new Hafez{ Id= 3142, BeytNo = 4, GhazalNo = 374, Mesra1 = "چو در دست است رودی خوش بزن مطرب سرودی خوش", Mesra2 = "که دست افشان غزل خوانيم و پاکوبان سر اندازيم",},
new Hafez{ Id= 3143, BeytNo = 5, GhazalNo = 374, Mesra1 = "صبا خاک وجود ما بدان عالی جناب انداز", Mesra2 = "بود کن شاه خوبان را نظر بر منظر اندازيم",},
new Hafez{ Id= 3144, BeytNo = 6, GhazalNo = 374, Mesra1 = "يکی از عقل می‌لافد يکی طامات می‌بافد", Mesra2 = "بيا کاين داوری‌ها را به پيش داور اندازيم",},
new Hafez{ Id= 3145, BeytNo = 7, GhazalNo = 374, Mesra1 = "بهشت عدن اگر خواهی بيا با ما به ميخانه", Mesra2 = "که از پای خمت روزی به حوض کوثر اندازيم",},
new Hafez{ Id= 3146, BeytNo = 8, GhazalNo = 374, Mesra1 = "سخندانی و خوشخوانی نمی‌ورزند در شيراز", Mesra2 = "بيا حافظ که تا خود را به ملکی ديگر اندازيم",},
new Hafez{ Id= 3147, BeytNo = 1, GhazalNo = 375, Mesra1 = "صوفی بيا که خرقه سالوس برکشيم", Mesra2 = "وين نقش زرق را خط بطلان به سر کشيم",},
new Hafez{ Id= 3148, BeytNo = 2, GhazalNo = 375, Mesra1 = "نذر و فتوح صومعه در وجه می‌نهيم", Mesra2 = "دلق ريا به آب خرابات برکشيم",},
new Hafez{ Id= 3149, BeytNo = 3, GhazalNo = 375, Mesra1 = "فردا اگر نه روضه رضوان به ما دهند", Mesra2 = "غلمان ز روضه حور ز جنت به درکشيم",},
new Hafez{ Id= 3150, BeytNo = 4, GhazalNo = 375, Mesra1 = "بيرون جهيم سرخوش و از بزم صوفيان", Mesra2 = "غارت کنيم باده و شاهد به بر کشيم",},
new Hafez{ Id= 3151, BeytNo = 5, GhazalNo = 375, Mesra1 = "عشرت کنيم ور نه به حسرت کشندمان", Mesra2 = "روزی که رخت جان به جهانی دگر کشيم",},
new Hafez{ Id= 3152, BeytNo = 6, GhazalNo = 375, Mesra1 = "سر خدا که در تتق غيب منزويست", Mesra2 = "مستانه‌اش نقاب ز رخسار برکشيم",},
new Hafez{ Id= 3153, BeytNo = 7, GhazalNo = 375, Mesra1 = "کو جلوه‌ای ز ابروی او تا چو ماه نو", Mesra2 = "گوی سپهر در خم چوگان زر کشيم",},
new Hafez{ Id= 3154, BeytNo = 8, GhazalNo = 375, Mesra1 = "حافظ نه حد ماست چنين لاف‌ها زدن", Mesra2 = "پای از گليم خويش چرا بيشتر کشيم",},
new Hafez{ Id= 3155, BeytNo = 1, GhazalNo = 376, Mesra1 = "دوستان وقت گل آن به که به عشرت کوشيم", Mesra2 = "سخن اهل دل است اين و به جان بنيوشيم",},
new Hafez{ Id= 3156, BeytNo = 2, GhazalNo = 376, Mesra1 = "نيست در کس کرم و وقت طرب می‌گذرد", Mesra2 = "چاره آن است که سجاده به می بفروشيم",},
new Hafez{ Id= 3157, BeytNo = 3, GhazalNo = 376, Mesra1 = "خوش هواييست فرح بخش خدايا بفرست", Mesra2 = "نازنينی که به رويش می گلگون نوشيم",},
new Hafez{ Id= 3158, BeytNo = 4, GhazalNo = 376, Mesra1 = "ارغنون ساز فلک رهزن اهل هنر است", Mesra2 = "چون از اين غصه نناليم و چرا نخروشيم",},
new Hafez{ Id= 3159, BeytNo = 5, GhazalNo = 376, Mesra1 = "گل به جوش آمد و از می نزديمش آبی", Mesra2 = "لاجرم ز آتش حرمان و هوس می‌جوشيم",},
new Hafez{ Id= 3160, BeytNo = 6, GhazalNo = 376, Mesra1 = "می‌کشيم از قدح لاله شرابی موهوم", Mesra2 = "چشم بد دور که بی مطرب و می مدهوشيم",},
new Hafez{ Id= 3161, BeytNo = 7, GhazalNo = 376, Mesra1 = "حافظ اين حال عجب با که توان گفت که ما", Mesra2 = "بلبلانيم که در موسم گل خاموشيم",},
new Hafez{ Id= 3162, BeytNo = 1, GhazalNo = 377, Mesra1 = "ما شبی دست برآريم و دعايی بکنيم", Mesra2 = "غم هجران تو را چاره ز جايی بکنيم",},
new Hafez{ Id= 3163, BeytNo = 2, GhazalNo = 377, Mesra1 = "دل بيمار شد از دست رفيقان مددی", Mesra2 = "تا طبيبش به سر آريم و دوايی بکنيم",},
new Hafez{ Id= 3164, BeytNo = 3, GhazalNo = 377, Mesra1 = "آن که بی جرم برنجيد و به تيغم زد و رفت", Mesra2 = "بازش آريد خدا را که صفايی بکنيم",},
new Hafez{ Id= 3165, BeytNo = 4, GhazalNo = 377, Mesra1 = "خشک شد بيخ طرب راه خرابات کجاست", Mesra2 = "تا در آن آب و هوا نشو و نمايی بکنيم",},
new Hafez{ Id= 3166, BeytNo = 5, GhazalNo = 377, Mesra1 = "مدد از خاطر رندان طلب ای دل ور نه", Mesra2 = "کار صعب است مبادا که خطايی بکنيم",},
new Hafez{ Id= 3167, BeytNo = 6, GhazalNo = 377, Mesra1 = "سايه طاير کم حوصله کاری نکند", Mesra2 = "طلب از سايه ميمون همايی بکنيم",},
new Hafez{ Id= 3168, BeytNo = 7, GhazalNo = 377, Mesra1 = "دلم از پرده بشد حافظ خوشگوی کجاست", Mesra2 = "تا به قول و غزلش ساز نوايی بکنيم",},
new Hafez{ Id= 3169, BeytNo = 1, GhazalNo = 378, Mesra1 = "ما نگوييم بد و ميل به ناحق نکنيم", Mesra2 = "جامه کس سيه و دلق خود ازرق نکنيم",},
new Hafez{ Id= 3170, BeytNo = 2, GhazalNo = 378, Mesra1 = "عيب درويش و توانگر به کم و بيش بد است", Mesra2 = "کار بد مصلحت آن است که مطلق نکنيم",},
new Hafez{ Id= 3171, BeytNo = 3, GhazalNo = 378, Mesra1 = "رقم مغلطه بر دفتر دانش نزنيم", Mesra2 = "سر حق بر ورق شعبده ملحق نکنيم",},
new Hafez{ Id= 3172, BeytNo = 4, GhazalNo = 378, Mesra1 = "شاه اگر جرعه رندان نه به حرمت نوشد", Mesra2 = "التفاتش به می صاف مروق نکنيم",},
new Hafez{ Id= 3173, BeytNo = 5, GhazalNo = 378, Mesra1 = "خوش برانيم جهان در نظر راهروان", Mesra2 = "فکر اسب سيه و زين مغرق نکنيم",},
new Hafez{ Id= 3174, BeytNo = 6, GhazalNo = 378, Mesra1 = "آسمان کشتی ارباب هنر می‌شکند", Mesra2 = "تکيه آن به که بر اين بحر معلق نکنيم",},
new Hafez{ Id= 3175, BeytNo = 7, GhazalNo = 378, Mesra1 = "گر بدی گفت حسودی و رفيقی رنجيد", Mesra2 = "گو تو خوش باش که ما گوش به احمق نکنيم",},
new Hafez{ Id= 3176, BeytNo = 8, GhazalNo = 378, Mesra1 = "حافظ ار خصم خطا گفت نگيريم بر او", Mesra2 = "ور به حق گفت جدل با سخن حق نکنيم",},
new Hafez{ Id= 3177, BeytNo = 1, GhazalNo = 379, Mesra1 = "سرم خوش است و به بانگ بلند می‌گويم", Mesra2 = "که من نسيم حيات از پياله می‌جويم",},
new Hafez{ Id= 3178, BeytNo = 2, GhazalNo = 379, Mesra1 = "عبوس زهد به وجه خمار ننشيند", Mesra2 = "مريد خرقه دردی کشان خوش خويم",},
new Hafez{ Id= 3179, BeytNo = 3, GhazalNo = 379, Mesra1 = "شدم فسانه به سرگشتگی و ابروی دوست", Mesra2 = "کشيد در خم چوگان خويش چون گويم",},
new Hafez{ Id= 3180, BeytNo = 4, GhazalNo = 379, Mesra1 = "گرم نه پير مغان در به روی بگشايد", Mesra2 = "کدام در بزنم چاره از کجا جويم",},
new Hafez{ Id= 3181, BeytNo = 5, GhazalNo = 379, Mesra1 = "مکن در اين چمنم سرزنش به خودرويی", Mesra2 = "چنان که پرورشم می‌دهند می‌رويم",},
new Hafez{ Id= 3182, BeytNo = 6, GhazalNo = 379, Mesra1 = "تو خانقاه و خرابات در ميانه مبين", Mesra2 = "خدا گواه که هر جا که هست با اويم",},
new Hafez{ Id= 3183, BeytNo = 7, GhazalNo = 379, Mesra1 = "غبار راه طلب کيميای بهروزيست", Mesra2 = "غلام دولت آن خاک عنبرين بويم",},
new Hafez{ Id= 3184, BeytNo = 8, GhazalNo = 379, Mesra1 = "ز شوق نرگس مست بلندبالايی", Mesra2 = "چو لاله با قدح افتاده بر لب جويم",},
new Hafez{ Id= 3185, BeytNo = 9, GhazalNo = 379, Mesra1 = "بيار می که به فتوی حافظ از دل پاک", Mesra2 = "غبار زرق به فيض قدح فروشويم",},
new Hafez{ Id= 3186, BeytNo = 1, GhazalNo = 380, Mesra1 = "بارها گفته‌ام و بار دگر می‌گويم", Mesra2 = "که من دلشده اين ره نه به خود می‌پويم",},
new Hafez{ Id= 3187, BeytNo = 2, GhazalNo = 380, Mesra1 = "در پس آينه طوطی صفتم داشته‌اند", Mesra2 = "آن چه استاد ازل گفت بگو می‌گويم",},
new Hafez{ Id= 3188, BeytNo = 3, GhazalNo = 380, Mesra1 = "من اگر خارم و گر گل چمن آرايی هست", Mesra2 = "که از آن دست که او می‌کشدم می‌رويم",},
new Hafez{ Id= 3189, BeytNo = 4, GhazalNo = 380, Mesra1 = "دوستان عيب من بی‌دل حيران مکنيد", Mesra2 = "گوهری دارم و صاحب نظری می‌جويم",},
new Hafez{ Id= 3190, BeytNo = 5, GhazalNo = 380, Mesra1 = "گر چه با دلق ملمع می گلگون عيب است", Mesra2 = "مکنم عيب کز او رنگ ريا می‌شويم",},
new Hafez{ Id= 3191, BeytNo = 6, GhazalNo = 380, Mesra1 = "خنده و گريه عشاق ز جايی دگر است", Mesra2 = "می‌سرايم به شب و وقت سحر می‌مويم",},
new Hafez{ Id= 3192, BeytNo = 7, GhazalNo = 380, Mesra1 = "حافظم گفت که خاک در ميخانه مبوی", Mesra2 = "گو مکن عيب که من مشک ختن می‌بويم",},
new Hafez{ Id= 3193, BeytNo = 1, GhazalNo = 381, Mesra1 = "گر چه ما بندگان پادشهيم", Mesra2 = "پادشاهان ملک صبحگهيم",},
new Hafez{ Id= 3194, BeytNo = 2, GhazalNo = 381, Mesra1 = "گنج در آستين و کيسه تهی", Mesra2 = "جام گيتی نما و خاک رهيم",},
new Hafez{ Id= 3195, BeytNo = 3, GhazalNo = 381, Mesra1 = "هوشيار حضور و مست غرور", Mesra2 = "بحر توحيد و غرقه گنهيم",},
new Hafez{ Id= 3196, BeytNo = 4, GhazalNo = 381, Mesra1 = "شاهد بخت چون کرشمه کند", Mesra2 = "ماش آيينه رخ چو مهيم",},
new Hafez{ Id= 3197, BeytNo = 5, GhazalNo = 381, Mesra1 = "شاه بيدار بخت را هر شب", Mesra2 = "ما نگهبان افسر و کلهيم",},
new Hafez{ Id= 3198, BeytNo = 6, GhazalNo = 381, Mesra1 = "گو غنيمت شمار صحبت ما", Mesra2 = "که تو در خواب و ما به ديده گهيم",},
new Hafez{ Id= 3199, BeytNo = 7, GhazalNo = 381, Mesra1 = "شاه منصور واقف است که ما", Mesra2 = "روی همت به هر کجا که نهيم",},
new Hafez{ Id= 3200, BeytNo = 8, GhazalNo = 381, Mesra1 = "دشمنان را ز خون کفن سازيم", Mesra2 = "دوستان را قبای فتح دهيم",},
new Hafez{ Id= 3201, BeytNo = 9, GhazalNo = 381, Mesra1 = "رنگ تزوير پيش ما نبود", Mesra2 = "شير سرخيم و افعی سيهيم",},
new Hafez{ Id= 3202, BeytNo = 10, GhazalNo = 381, Mesra1 = "وام حافظ بگو که بازدهند", Mesra2 = "کرده‌ای اعتراف و ما گوهيم",},
new Hafez{ Id= 3203, BeytNo = 1, GhazalNo = 382, Mesra1 = "فاتحه‌ای چو آمدی بر سر خسته‌ای بخوان", Mesra2 = "لب بگشا که می‌دهد لعل لبت به مرده جان",},
new Hafez{ Id= 3204, BeytNo = 2, GhazalNo = 382, Mesra1 = "آن که به پرسش آمد و فاتحه خواند و می‌رود", Mesra2 = "گو نفسی که روح را می‌کنم از پی اش روان",},
new Hafez{ Id= 3205, BeytNo = 3, GhazalNo = 382, Mesra1 = "ای که طبيب خسته‌ای روی زبان من ببين", Mesra2 = "کاين دم و دود سينه‌ام بار دل است بر زبان",},
new Hafez{ Id= 3206, BeytNo = 4, GhazalNo = 382, Mesra1 = "گر چه تب استخوان من کرد ز مهر گرم و رفت", Mesra2 = "همچو تبم نمی‌رود آتش مهر از استخوان",},
new Hafez{ Id= 3207, BeytNo = 5, GhazalNo = 382, Mesra1 = "حال دلم ز خال تو هست در آتشش وطن", Mesra2 = "چشمم از آن دو چشم تو خسته شده‌ست و ناتوان",},
new Hafez{ Id= 3208, BeytNo = 6, GhazalNo = 382, Mesra1 = "بازنشان حرارتم ز آب دو ديده و ببين", Mesra2 = "نبض مرا که می‌دهد هيچ ز زندگی نشان",},
new Hafez{ Id= 3209, BeytNo = 7, GhazalNo = 382, Mesra1 = "آن که مدام شيشه‌ام از پی عيش داده است", Mesra2 = "شيشه‌ام از چه می‌برد پيش طبيب هر زمان",},
new Hafez{ Id= 3210, BeytNo = 8, GhazalNo = 382, Mesra1 = "حافظ از آب زندگی شعر تو داد شربتم", Mesra2 = "ترک طبيب کن بيا نسخه شربتم بخوان",},
new Hafez{ Id= 3211, BeytNo = 1, GhazalNo = 383, Mesra1 = "چندان که گفتم غم با طبيبان", Mesra2 = "درمان نکردند مسکين غريبان",},
new Hafez{ Id= 3212, BeytNo = 2, GhazalNo = 383, Mesra1 = "آن گل که هر دم در دست باديست", Mesra2 = "گو شرم بادش از عندليبان",},
new Hafez{ Id= 3213, BeytNo = 3, GhazalNo = 383, Mesra1 = "يا رب امان ده تا بازبيند", Mesra2 = "چشم محبان روی حبيبان",},
new Hafez{ Id= 3214, BeytNo = 4, GhazalNo = 383, Mesra1 = "درج محبت بر مهر خود نيست", Mesra2 = "يا رب مبادا کام رقيبان",},
new Hafez{ Id= 3215, BeytNo = 5, GhazalNo = 383, Mesra1 = "ای منعم آخر بر خوان جودت", Mesra2 = "تا چند باشيم از بی نصيبان",},
new Hafez{ Id= 3216, BeytNo = 6, GhazalNo = 383, Mesra1 = "حافظ نگشتی شيدای گيتی", Mesra2 = "گر می‌شنيدی پند اديبان",},
new Hafez{ Id= 3217, BeytNo = 1, GhazalNo = 384, Mesra1 = "می‌سوزم از فراقت روی از جفا بگردان", Mesra2 = "هجران بلای ما شد يا رب بلا بگردان",},
new Hafez{ Id= 3218, BeytNo = 2, GhazalNo = 384, Mesra1 = "مه جلوه می‌نمايد بر سبز خنگ گردون", Mesra2 = "تا او به سر درآيد بر رخش پا بگردان",},
new Hafez{ Id= 3219, BeytNo = 3, GhazalNo = 384, Mesra1 = "مر غول را برافشان يعنی به رغم سنبل", Mesra2 = "گرد چمن بخوری همچون صبا بگردان",},
new Hafez{ Id= 3220, BeytNo = 4, GhazalNo = 384, Mesra1 = "يغمای عقل و دين را بيرون خرام سرمست", Mesra2 = "در سر کلاه بشکن در بر قبا بگردان",},
new Hafez{ Id= 3221, BeytNo = 5, GhazalNo = 384, Mesra1 = "ای نور چشم مستان در عين انتظارم", Mesra2 = "چنگ حزين و جامی بنواز يا بگردان",},
new Hafez{ Id= 3222, BeytNo = 6, GhazalNo = 384, Mesra1 = "دوران همی‌نويسد بر عارضش خطی خوش", Mesra2 = "يا رب نوشته بد از يار ما بگردان",},
new Hafez{ Id= 3223, BeytNo = 7, GhazalNo = 384, Mesra1 = "حافظ ز خوبرويان بختت جز اين قدر نيست", Mesra2 = "گر نيستت رضايی حکم قضا بگردان",},
new Hafez{ Id= 3224, BeytNo = 1, GhazalNo = 385, Mesra1 = "يا رب آن آهوی مشکين به ختن بازرسان", Mesra2 = "وان سهی سرو خرامان به چمن بازرسان",},
new Hafez{ Id= 3225, BeytNo = 2, GhazalNo = 385, Mesra1 = "دل آزرده ما را به نسيمی بنواز", Mesra2 = "يعنی آن جان ز تن رفته به تن بازرسان",},
new Hafez{ Id= 3226, BeytNo = 3, GhazalNo = 385, Mesra1 = "ماه و خورشيد به منزل چو به امر تو رسند", Mesra2 = "يار مه روی مرا نيز به من بازرسان",},
new Hafez{ Id= 3227, BeytNo = 4, GhazalNo = 385, Mesra1 = "ديده‌ها در طلب لعل يمانی خون شد", Mesra2 = "يا رب آن کوکب رخشان به يمن بازرسان",},
new Hafez{ Id= 3228, BeytNo = 5, GhazalNo = 385, Mesra1 = "برو ای طاير ميمون همايون آثار", Mesra2 = "پيش عنقا سخن زاغ و زغن بازرسان",},
new Hafez{ Id= 3229, BeytNo = 6, GhazalNo = 385, Mesra1 = "سخن اين است که ما بی تو نخواهيم حيات", Mesra2 = "بشنو ای پيک خبرگير و سخن بازرسان",},
new Hafez{ Id= 3230, BeytNo = 7, GhazalNo = 385, Mesra1 = "آن که بودی وطنش ديده حافظ يا رب", Mesra2 = "به مرادش ز غريبی به وطن بازرسان",},
new Hafez{ Id= 3231, BeytNo = 1, GhazalNo = 386, Mesra1 = "خدا را کم نشين با خرقه پوشان", Mesra2 = "رخ از رندان بی‌سامان مپوشان",},
new Hafez{ Id= 3232, BeytNo = 2, GhazalNo = 386, Mesra1 = "در اين خرقه بسی آلودگی هست", Mesra2 = "خوشا وقت قبای می فروشان",},
new Hafez{ Id= 3233, BeytNo = 3, GhazalNo = 386, Mesra1 = "در اين صوفی وشان دردی نديدم", Mesra2 = "که صافی باد عيش دردنوشان",},
new Hafez{ Id= 3234, BeytNo = 4, GhazalNo = 386, Mesra1 = "تو نازک طبعی و طاقت نياری", Mesra2 = "گرانی‌های مشتی دلق پوشان",},
new Hafez{ Id= 3235, BeytNo = 5, GhazalNo = 386, Mesra1 = "چو مستم کرده‌ای مستور منشين", Mesra2 = "چو نوشم داده‌ای زهرم منوشان",},
new Hafez{ Id= 3236, BeytNo = 6, GhazalNo = 386, Mesra1 = "بيا و از غبن اين سالوسيان بين", Mesra2 = "صراحی خون دل و بربط خروشان",},
new Hafez{ Id= 3237, BeytNo = 7, GhazalNo = 386, Mesra1 = "ز دلگرمی حافظ بر حذر باش", Mesra2 = "که دارد سينه‌ای چون ديگ جوشان",},
new Hafez{ Id= 3238, BeytNo = 1, GhazalNo = 387, Mesra1 = "شاه شمشادقدان خسرو شيرين دهنان", Mesra2 = "که به مژگان شکند قلب همه صف شکنان",},
new Hafez{ Id= 3239, BeytNo = 2, GhazalNo = 387, Mesra1 = "مست بگذشت و نظر بر من درويش انداخت", Mesra2 = "گفت ای چشم و چراغ همه شيرين سخنان",},
new Hafez{ Id= 3240, BeytNo = 3, GhazalNo = 387, Mesra1 = "تا کی از سيم و زرت کيسه تهی خواهد بود", Mesra2 = "بنده من شو و برخور ز همه سيمتنان",},
new Hafez{ Id= 3241, BeytNo = 4, GhazalNo = 387, Mesra1 = "کمتر از ذره نه‌ای پست مشو مهر بورز", Mesra2 = "تا به خلوتگه خورشيد رسی چرخ زنان",},
new Hafez{ Id= 3242, BeytNo = 5, GhazalNo = 387, Mesra1 = "بر جهان تکيه مکن ور قدحی می داری", Mesra2 = "شادی زهره جبينان خور و نازک بدنان",},
new Hafez{ Id= 3243, BeytNo = 6, GhazalNo = 387, Mesra1 = "پير پيمانه کش من که روانش خوش باد", Mesra2 = "گفت پرهيز کن از صحبت پيمان شکنان",},
new Hafez{ Id= 3244, BeytNo = 7, GhazalNo = 387, Mesra1 = "دامن دوست به دست آر و ز دشمن بگسل", Mesra2 = "مرد يزدان شو و فارغ گذر از اهرمنان",},
new Hafez{ Id= 3245, BeytNo = 8, GhazalNo = 387, Mesra1 = "با صبا در چمن لاله سحر می‌گفتم", Mesra2 = "که شهيدان که‌اند اين همه خونين کفنان",},
new Hafez{ Id= 3246, BeytNo = 9, GhazalNo = 387, Mesra1 = "گفت حافظ من و تو محرم اين راز نه‌ايم", Mesra2 = "از می لعل حکايت کن و شيرين دهنان",},
new Hafez{ Id= 3247, BeytNo = 1, GhazalNo = 388, Mesra1 = "بهار و گل طرب انگيز گشت و توبه شکن", Mesra2 = "به شادی رخ گل بيخ غم ز دل برکن",},
new Hafez{ Id= 3248, BeytNo = 2, GhazalNo = 388, Mesra1 = "رسيد باد صبا غنچه در هواداری", Mesra2 = "ز خود برون شد و بر خود دريد پيراهن",},
new Hafez{ Id= 3249, BeytNo = 3, GhazalNo = 388, Mesra1 = "طريق صدق بياموز از آب صافی دل", Mesra2 = "به راستی طلب آزادگی ز سرو چمن",},
new Hafez{ Id= 3250, BeytNo = 4, GhazalNo = 388, Mesra1 = "ز دستبرد صبا گرد گل کلاله نگر", Mesra2 = "شکنج گيسوی سنبل ببين به روی سمن",},
new Hafez{ Id= 3251, BeytNo = 5, GhazalNo = 388, Mesra1 = "عروس غنچه رسيد از حرم به طالع سعد", Mesra2 = "به عينه دل و دين می‌برد به وجه حسن",},
new Hafez{ Id= 3252, BeytNo = 6, GhazalNo = 388, Mesra1 = "صفير بلبل شوريده و نفير هزار", Mesra2 = "برای وصل گل آمد برون ز بيت حزن",},
new Hafez{ Id= 3253, BeytNo = 7, GhazalNo = 388, Mesra1 = "حديث صحبت خوبان و جام باده بگو", Mesra2 = "به قول حافظ و فتوی پير صاحب فن",},
new Hafez{ Id= 3254, BeytNo = 1, GhazalNo = 389, Mesra1 = "چو گل هر دم به بويت جامه در تن", Mesra2 = "کنم چاک از گريبان تا به دامن",},
new Hafez{ Id= 3255, BeytNo = 2, GhazalNo = 389, Mesra1 = "تنت را ديد گل گويی که در باغ", Mesra2 = "چو مستان جامه را بدريد بر تن",},
new Hafez{ Id= 3256, BeytNo = 3, GhazalNo = 389, Mesra1 = "من از دست غمت مشکل برم جان", Mesra2 = "ولی دل را تو آسان بردی از من",},
new Hafez{ Id= 3257, BeytNo = 4, GhazalNo = 389, Mesra1 = "به قول دشمنان برگشتی از دوست", Mesra2 = "نگردد هيچ کس دوست دشمن",},
new Hafez{ Id= 3258, BeytNo = 5, GhazalNo = 389, Mesra1 = "تنت در جامه چون در جام باده", Mesra2 = "دلت در سينه چون در سيم آهن",},
new Hafez{ Id= 3259, BeytNo = 6, GhazalNo = 389, Mesra1 = "ببار ای شمع اشک از چشم خونين", Mesra2 = "که شد سوز دلت بر خلق روشن",},
new Hafez{ Id= 3260, BeytNo = 7, GhazalNo = 389, Mesra1 = "مکن کز سينه‌ام آه جگرسوز", Mesra2 = "برآيد همچو دود از راه روزن",},
new Hafez{ Id= 3261, BeytNo = 8, GhazalNo = 389, Mesra1 = "دلم را مشکن و در پا مينداز", Mesra2 = "که دارد در سر زلف تو مسکن",},
new Hafez{ Id= 3262, BeytNo = 9, GhazalNo = 389, Mesra1 = "چو دل در زلف تو بسته‌ست حافظ", Mesra2 = "بدين سان کار او در پا ميفکن",},
new Hafez{ Id= 3263, BeytNo = 1, GhazalNo = 390, Mesra1 = "افسر سلطان گل پيدا شد از طرف چمن", Mesra2 = "مقدمش يا رب مبارک باد بر سرو و سمن",},
new Hafez{ Id= 3264, BeytNo = 2, GhazalNo = 390, Mesra1 = "خوش به جای خويشتن بود اين نشست خسروی", Mesra2 = "تا نشيند هر کسی اکنون به جای خويشتن",},
new Hafez{ Id= 3265, BeytNo = 3, GhazalNo = 390, Mesra1 = "خاتم جم را بشارت ده به حسن خاتمت", Mesra2 = "کاسم اعظم کرد از او کوتاه دست اهرمن",},
new Hafez{ Id= 3266, BeytNo = 4, GhazalNo = 390, Mesra1 = "تا ابد معمور باد اين خانه کز خاک درش", Mesra2 = "هر نفس با بوی رحمان می‌وزد باد يمن",},
new Hafez{ Id= 3267, BeytNo = 5, GhazalNo = 390, Mesra1 = "شوکت پور پشنگ و تيغ عالمگير او", Mesra2 = "در همه شهنامه‌ها شد داستان انجمن",},
new Hafez{ Id= 3268, BeytNo = 6, GhazalNo = 390, Mesra1 = "خنگ چوگانی چرخت رام شد در زير زين", Mesra2 = "شهسوارا چون به ميدان آمدی گويی بزن",},
new Hafez{ Id= 3269, BeytNo = 7, GhazalNo = 390, Mesra1 = "جويبار ملک را آب روان شمشير توست", Mesra2 = "تو درخت عدل بنشان بيخ بدخواهان بکن",},
new Hafez{ Id= 3270, BeytNo = 8, GhazalNo = 390, Mesra1 = "بعد از اين نشکفت اگر با نکهت خلق خوشت", Mesra2 = "خيزد از صحرای ايذج نافه مشک ختن",},
new Hafez{ Id= 3271, BeytNo = 9, GhazalNo = 390, Mesra1 = "گوشه گيران انتظار جلوه خوش می‌کنند", Mesra2 = "برشکن طرف کلاه و برقع از رخ برفکن",},
new Hafez{ Id= 3272, BeytNo = 10, GhazalNo = 390, Mesra1 = "مشورت با عقل کردم گفت حافظ می بنوش", Mesra2 = "ساقيا می ده به قول مستشار متمن",},
new Hafez{ Id= 3273, BeytNo = 11, GhazalNo = 390, Mesra1 = "ای صبا بر ساقی بزم اتابک عرضه دار", Mesra2 = "تا از آن جام زرافشان جرعه‌ای بخشد به من",},
new Hafez{ Id= 3274, BeytNo = 1, GhazalNo = 391, Mesra1 = "خوشتر از فکر می و جام چه خواهد بودن", Mesra2 = "تا ببينم که سرانجام چه خواهد بودن",},
new Hafez{ Id= 3275, BeytNo = 2, GhazalNo = 391, Mesra1 = "غم دل چند توان خورد که ايام نماند", Mesra2 = "گو نه دل باش و نه ايام چه خواهد بودن",},
new Hafez{ Id= 3276, BeytNo = 3, GhazalNo = 391, Mesra1 = "مرغ کم حوصله را گو غم خود خور که بر او", Mesra2 = "رحم آن کس که نهد دام چه خواهد بودن",},
new Hafez{ Id= 3277, BeytNo = 4, GhazalNo = 391, Mesra1 = "باده خور غم مخور و پند مقلد منيوش", Mesra2 = "اعتبار سخن عام چه خواهد بودن",},
new Hafez{ Id= 3278, BeytNo = 5, GhazalNo = 391, Mesra1 = "دست رنج تو همان به که شود صرف به کام", Mesra2 = "دانی آخر که به ناکام چه خواهد بودن",},
new Hafez{ Id= 3279, BeytNo = 6, GhazalNo = 391, Mesra1 = "پير ميخانه همی‌خواند معمايی دوش", Mesra2 = "از خط جام که فرجام چه خواهد بودن",},
new Hafez{ Id= 3280, BeytNo = 7, GhazalNo = 391, Mesra1 = "بردم از ره دل حافظ به دف و چنگ و غزل", Mesra2 = "تا جزای من بدنام چه خواهد بودن",},
new Hafez{ Id= 3281, BeytNo = 1, GhazalNo = 392, Mesra1 = "دانی که چيست دولت ديدار يار ديدن", Mesra2 = "در کوی او گدايی بر خسروی گزيدن",},
new Hafez{ Id= 3282, BeytNo = 2, GhazalNo = 392, Mesra1 = "از جان طمع بريدن آسان بود وليکن", Mesra2 = "از دوستان جانی مشکل توان بريدن",},
new Hafez{ Id= 3283, BeytNo = 3, GhazalNo = 392, Mesra1 = "خواهم شدن به بستان چون غنچه با دل تنگ", Mesra2 = "وان جا به نيک نامی پيراهنی دريدن",},
new Hafez{ Id= 3284, BeytNo = 4, GhazalNo = 392, Mesra1 = "گه چون نسيم با گل راز نهفته گفتن", Mesra2 = "گه سر عشقبازی از بلبلان شنيدن",},
new Hafez{ Id= 3285, BeytNo = 5, GhazalNo = 392, Mesra1 = "بوسيدن لب يار اول ز دست مگذار", Mesra2 = "کخر ملول گردی از دست و لب گزيدن",},
new Hafez{ Id= 3286, BeytNo = 6, GhazalNo = 392, Mesra1 = "فرصت شمار صحبت کز اين دوراهه منزل", Mesra2 = "چون بگذريم ديگر نتوان به هم رسيدن",},
new Hafez{ Id= 3287, BeytNo = 7, GhazalNo = 392, Mesra1 = "گويی برفت حافظ از ياد شاه يحيی", Mesra2 = "يا رب به يادش آور درويش پروريدن",},
new Hafez{ Id= 3288, BeytNo = 1, GhazalNo = 393, Mesra1 = "منم که شهره شهرم به عشق ورزيدن", Mesra2 = "منم که ديده نيالودم به بد ديدن",},
new Hafez{ Id= 3289, BeytNo = 2, GhazalNo = 393, Mesra1 = "وفا کنيم و ملامت کشيم و خوش باشيم", Mesra2 = "که در طريقت ما کافريست رنجيدن",},
new Hafez{ Id= 3290, BeytNo = 3, GhazalNo = 393, Mesra1 = "به پير ميکده گفتم که چيست راه نجات", Mesra2 = "بخواست جام می و گفت عيب پوشيدن",},
new Hafez{ Id= 3291, BeytNo = 4, GhazalNo = 393, Mesra1 = "مراد دل ز تماشای باغ عالم چيست", Mesra2 = "به دست مردم چشم از رخ تو گل چيدن",},
new Hafez{ Id= 3292, BeytNo = 5, GhazalNo = 393, Mesra1 = "به می پرستی از آن نقش خود زدم بر آب", Mesra2 = "که تا خراب کنم نقش خود پرستيدن",},
new Hafez{ Id= 3293, BeytNo = 6, GhazalNo = 393, Mesra1 = "به رحمت سر زلف تو واثقم ور نه", Mesra2 = "کشش چو نبود از آن سو چه سود کوشيدن",},
new Hafez{ Id= 3294, BeytNo = 7, GhazalNo = 393, Mesra1 = "عنان به ميکده خواهيم تافت زين مجلس", Mesra2 = "که وعظ بی عملان واجب است نشنيدن",},
new Hafez{ Id= 3295, BeytNo = 8, GhazalNo = 393, Mesra1 = "ز خط يار بياموز مهر با رخ خوب", Mesra2 = "که گرد عارض خوبان خوش است گرديدن",},
new Hafez{ Id= 3296, BeytNo = 9, GhazalNo = 393, Mesra1 = "مبوس جز لب ساقی و جام می حافظ", Mesra2 = "که دست زهدفروشان خطاست بوسيدن",},
new Hafez{ Id= 3297, BeytNo = 1, GhazalNo = 394, Mesra1 = "ای روی ماه منظر تو نوبهار حسن", Mesra2 = "خال و خط تو مرکز حسن و مدار حسن",},
new Hafez{ Id= 3298, BeytNo = 2, GhazalNo = 394, Mesra1 = "در چشم پرخمار تو پنهان فسون سحر", Mesra2 = "در زلف بی‌قرار تو پيدا قرار حسن",},
new Hafez{ Id= 3299, BeytNo = 3, GhazalNo = 394, Mesra1 = "ماهی نتافت همچو تو از برج نيکويی", Mesra2 = "سروی نخاست چون قدت از جويبار حسن",},
new Hafez{ Id= 3300, BeytNo = 4, GhazalNo = 394, Mesra1 = "خرم شد از ملاحت تو عهد دلبری", Mesra2 = "فرخ شد از لطافت تو روزگار حسن",},
new Hafez{ Id= 3301, BeytNo = 5, GhazalNo = 394, Mesra1 = "از دام زلف و دانه خال تو در جهان", Mesra2 = "يک مرغ دل نماند نگشته شکار حسن",},
new Hafez{ Id= 3302, BeytNo = 6, GhazalNo = 394, Mesra1 = "دايم به لطف دايه طبع از ميان جان", Mesra2 = "می‌پرورد به ناز تو را در کنار حسن",},
new Hafez{ Id= 3303, BeytNo = 7, GhazalNo = 394, Mesra1 = "گرد لبت بنفشه از آن تازه و تر است", Mesra2 = "کب حيات می‌خورد از جويبار حسن",},
new Hafez{ Id= 3304, BeytNo = 8, GhazalNo = 394, Mesra1 = "حافظ طمع بريد که بيند نظير تو", Mesra2 = "ديار نيست جز رخت اندر ديار حسن",},
new Hafez{ Id= 3305, BeytNo = 1, GhazalNo = 395, Mesra1 = "گلبرگ را ز سنبل مشکين نقاب کن", Mesra2 = "يعنی که رخ بپوش و جهانی خراب کن",},
new Hafez{ Id= 3306, BeytNo = 2, GhazalNo = 395, Mesra1 = "بفشان عرق ز چهره و اطراف باغ را", Mesra2 = "چون شيشه‌های ديده ما پرگلاب کن",},
new Hafez{ Id= 3307, BeytNo = 3, GhazalNo = 395, Mesra1 = "ايام گل چو عمر به رفتن شتاب کرد", Mesra2 = "ساقی به دور باده گلگون شتاب کن",},
new Hafez{ Id= 3308, BeytNo = 4, GhazalNo = 395, Mesra1 = "بگشا به شيوه نرگس پرخواب مست را", Mesra2 = "و از رشک چشم نرگس رعنا به خواب کن",},
new Hafez{ Id= 3309, BeytNo = 5, GhazalNo = 395, Mesra1 = "بوی بنفشه بشنو و زلف نگار گير", Mesra2 = "بنگر به رنگ لاله و عزم شراب کن",},
new Hafez{ Id= 3310, BeytNo = 6, GhazalNo = 395, Mesra1 = "زان جا که رسم و عادت عاشق‌کشی توست", Mesra2 = "با دشمنان قدح کش و با ما عتاب کن",},
new Hafez{ Id= 3311, BeytNo = 7, GhazalNo = 395, Mesra1 = "همچون حباب ديده به روی قدح گشای", Mesra2 = "وين خانه را قياس اساس از حباب کن",},
new Hafez{ Id= 3312, BeytNo = 8, GhazalNo = 395, Mesra1 = "حافظ وصال می‌طلبد از ره دعا", Mesra2 = "يا رب دعای خسته دلان مستجاب کن",},
new Hafez{ Id= 3313, BeytNo = 1, GhazalNo = 396, Mesra1 = "صبح است ساقيا قدحی پرشراب کن", Mesra2 = "دور فلک درنگ ندارد شتاب کن",},
new Hafez{ Id= 3314, BeytNo = 2, GhazalNo = 396, Mesra1 = "زان پيشتر که عالم فانی شود خراب", Mesra2 = "ما را ز جام باده گلگون خراب کن",},
new Hafez{ Id= 3315, BeytNo = 3, GhazalNo = 396, Mesra1 = "خورشيد می ز مشرق ساغر طلوع کرد", Mesra2 = "گر برگ عيش می‌طلبی ترک خواب کن",},
new Hafez{ Id= 3316, BeytNo = 4, GhazalNo = 396, Mesra1 = "روزی که چرخ از گل ما کوزه‌ها کند", Mesra2 = "زنهار کاسه سر ما پرشراب کن",},
new Hafez{ Id= 3317, BeytNo = 5, GhazalNo = 396, Mesra1 = "ما مرد زهد و توبه و طامات نيستيم", Mesra2 = "با ما به جام باده صافی خطاب کن",},
new Hafez{ Id= 3318, BeytNo = 6, GhazalNo = 396, Mesra1 = "کار صواب باده پرستيست حافظا", Mesra2 = "برخيز و عزم جزم به کار صواب کن",},
new Hafez{ Id= 3319, BeytNo = 1, GhazalNo = 397, Mesra1 = "ز در درآ و شبستان ما منور کن", Mesra2 = "هوای مجلس روحانيان معطر کن",},
new Hafez{ Id= 3320, BeytNo = 2, GhazalNo = 397, Mesra1 = "اگر فقيه نصيحت کند که عشق مباز", Mesra2 = "پياله‌ای بدهش گو دماغ را تر کن",},
new Hafez{ Id= 3321, BeytNo = 3, GhazalNo = 397, Mesra1 = "به چشم و ابروی جانان سپرده‌ام دل و جان", Mesra2 = "بيا بيا و تماشای طاق و منظر کن",},
new Hafez{ Id= 3322, BeytNo = 4, GhazalNo = 397, Mesra1 = "ستاره شب هجران نمی‌فشاند نور", Mesra2 = "به بام قصر برآ و چراغ مه برکن",},
new Hafez{ Id= 3323, BeytNo = 5, GhazalNo = 397, Mesra1 = "بگو به خازن جنت که خاک اين مجلس", Mesra2 = "به تحفه بر سوی فردوس و عود مجمر کن",},
new Hafez{ Id= 3324, BeytNo = 6, GhazalNo = 397, Mesra1 = "از اين مزوجه و خرقه نيک در تنگم", Mesra2 = "به يک کرشمه صوفی وشم قلندر کن",},
new Hafez{ Id= 3325, BeytNo = 7, GhazalNo = 397, Mesra1 = "چو شاهدان چمن زيردست حسن تواند", Mesra2 = "کرشمه بر سمن و جلوه بر صنوبر کن",},
new Hafez{ Id= 3326, BeytNo = 8, GhazalNo = 397, Mesra1 = "فضول نفس حکايت بسی کند ساقی", Mesra2 = "تو کار خود مده از دست و می به ساغر کن",},
new Hafez{ Id= 3327, BeytNo = 9, GhazalNo = 397, Mesra1 = "حجاب ديده ادراک شد شعاع جمال", Mesra2 = "بيا و خرگه خورشيد را منور کن",},
new Hafez{ Id= 3328, BeytNo = 10, GhazalNo = 397, Mesra1 = "طمع به قند وصال تو حد ما نبود", Mesra2 = "حوالتم به لب لعل همچو شکر کن",},
new Hafez{ Id= 3329, BeytNo = 11, GhazalNo = 397, Mesra1 = "لب پياله ببوس آنگهی به مستان ده", Mesra2 = "بدين دقيقه دماغ معاشران تر کن",},
new Hafez{ Id= 3330, BeytNo = 12, GhazalNo = 397, Mesra1 = "پس از ملازمت عيش و عشق مه رويان", Mesra2 = "ز کارها که کنی شعر حافظ از بر کن",},
new Hafez{ Id= 3331, BeytNo = 1, GhazalNo = 398, Mesra1 = "ای نور چشم من سخنی هست گوش کن", Mesra2 = "چون ساغرت پر است بنوشان و نوش کن",},
new Hafez{ Id= 3332, BeytNo = 2, GhazalNo = 398, Mesra1 = "در راه عشق وسوسه اهرمن بسيست", Mesra2 = "پيش آی و گوش دل به پيام سروش کن",},
new Hafez{ Id= 3333, BeytNo = 3, GhazalNo = 398, Mesra1 = "برگ نوا تبه شد و ساز طرب نماند", Mesra2 = "ای چنگ ناله برکش و ای دف خروش کن",},
new Hafez{ Id= 3334, BeytNo = 4, GhazalNo = 398, Mesra1 = "تسبيح و خرقه لذت مستی نبخشدت", Mesra2 = "همت در اين عمل طلب از می فروش کن",},
new Hafez{ Id= 3335, BeytNo = 5, GhazalNo = 398, Mesra1 = "پيران سخن ز تجربه گويند گفتمت", Mesra2 = "هان ای پسر که پير شوی پند گوش کن",},
new Hafez{ Id= 3336, BeytNo = 6, GhazalNo = 398, Mesra1 = "بر هوشمند سلسله ننهاد دست عشق", Mesra2 = "خواهی که زلف يار کشی ترک هوش کن",},
new Hafez{ Id= 3337, BeytNo = 7, GhazalNo = 398, Mesra1 = "با دوستان مضايقه در عمر و مال نيست", Mesra2 = "صد جان فدای يار نصيحت نيوش کن",},
new Hafez{ Id= 3338, BeytNo = 8, GhazalNo = 398, Mesra1 = "ساقی که جامت از می صافی تهی مباد", Mesra2 = "چشم عنايتی به من دردنوش کن",},
new Hafez{ Id= 3339, BeytNo = 9, GhazalNo = 398, Mesra1 = "سرمست در قبای زرافشان چو بگذری", Mesra2 = "يک بوسه نذر حافظ پشمينه پوش کن",},
new Hafez{ Id= 3340, BeytNo = 1, GhazalNo = 399, Mesra1 = "کرشمه‌ای کن و بازار ساحری بشکن", Mesra2 = "به غمزه رونق و ناموس سامری بشکن",},
new Hafez{ Id= 3341, BeytNo = 2, GhazalNo = 399, Mesra1 = "به باد ده سر و دستار عالمی يعنی", Mesra2 = "کلاه گوشه به آيين سروری بشکن",},
new Hafez{ Id= 3342, BeytNo = 3, GhazalNo = 399, Mesra1 = "به زلف گوی که آيين دلبری بگذار", Mesra2 = "به غمزه گوی که قلب ستمگری بشکن",},
new Hafez{ Id= 3343, BeytNo = 4, GhazalNo = 399, Mesra1 = "برون خرام و ببر گوی خوبی از همه کس", Mesra2 = "سزای حور بده رونق پری بشکن",},
new Hafez{ Id= 3344, BeytNo = 5, GhazalNo = 399, Mesra1 = "به آهوان نظر شير آفتاب بگير", Mesra2 = "به ابروان دوتا قوس مشتری بشکن",},
new Hafez{ Id= 3345, BeytNo = 6, GhazalNo = 399, Mesra1 = "چو عطرسای شود زلف سنبل از دم باد", Mesra2 = "تو قيمتش به سر زلف عنبری بشکن",},
new Hafez{ Id= 3346, BeytNo = 7, GhazalNo = 399, Mesra1 = "چو عندليب فصاحت فروشد ای حافظ", Mesra2 = "تو قدر او به سخن گفتن دری بشکن",},
new Hafez{ Id= 3347, BeytNo = 1, GhazalNo = 400, Mesra1 = "بالابلند عشوه گر نقش باز من", Mesra2 = "کوتاه کرد قصه زهد دراز من",},
new Hafez{ Id= 3348, BeytNo = 2, GhazalNo = 400, Mesra1 = "ديدی دلا که آخر پيری و زهد و علم", Mesra2 = "با من چه کرد ديده معشوقه باز من",},
new Hafez{ Id= 3349, BeytNo = 3, GhazalNo = 400, Mesra1 = "می‌ترسم از خرابی ايمان که می‌برد", Mesra2 = "محراب ابروی تو حضور نماز من",},
new Hafez{ Id= 3350, BeytNo = 4, GhazalNo = 400, Mesra1 = "گفتم به دلق زرق بپوشم نشان عشق", Mesra2 = "غماز بود اشک و عيان کرد راز من",},
new Hafez{ Id= 3351, BeytNo = 5, GhazalNo = 400, Mesra1 = "مست است يار و ياد حريفان نمی‌کند", Mesra2 = "ذکرش به خير ساقی مسکين نواز من",},
new Hafez{ Id= 3352, BeytNo = 6, GhazalNo = 400, Mesra1 = "يا رب کی آن صبا بوزد کز نسيم آن", Mesra2 = "گردد شمامه کرمش کارساز من",},
new Hafez{ Id= 3353, BeytNo = 7, GhazalNo = 400, Mesra1 = "نقشی بر آب می‌زنم از گريه حاليا", Mesra2 = "تا کی شود قرين حقيقت مجاز من",},
new Hafez{ Id= 3354, BeytNo = 8, GhazalNo = 400, Mesra1 = "بر خود چو شمع خنده زنان گريه می‌کنم", Mesra2 = "تا با تو سنگ دل چه کند سوز و ساز من",},
new Hafez{ Id= 3355, BeytNo = 9, GhazalNo = 400, Mesra1 = "زاهد چو از نماز تو کاری نمی‌رود", Mesra2 = "هم مستی شبانه و راز و نياز من",},
new Hafez{ Id= 3356, BeytNo = 10, GhazalNo = 400, Mesra1 = "حافظ ز گريه سوخت بگو حالش ای صبا", Mesra2 = "با شاه دوست پرور دشمن گداز من",},
new Hafez{ Id= 3357, BeytNo = 1, GhazalNo = 401, Mesra1 = "چون شوم خاک رهش دامن بيفشاند ز من", Mesra2 = "ور بگويم دل بگردان رو بگرداند ز من",},
new Hafez{ Id= 3358, BeytNo = 2, GhazalNo = 401, Mesra1 = "روی رنگين را به هر کس می‌نمايد همچو گل", Mesra2 = "ور بگويم بازپوشان بازپوشاند ز من",},
new Hafez{ Id= 3359, BeytNo = 3, GhazalNo = 401, Mesra1 = "چشم خود را گفتم آخر يک نظر سيرش ببين", Mesra2 = "گفت می‌خواهی مگر تا جوی خون راند ز من",},
new Hafez{ Id= 3360, BeytNo = 4, GhazalNo = 401, Mesra1 = "او به خونم تشنه و من بر لبش تا چون شود", Mesra2 = "کام بستانم از او يا داد بستاند ز من",},
new Hafez{ Id= 3361, BeytNo = 5, GhazalNo = 401, Mesra1 = "گر چو فرهادم به تلخی جان برآيد باک نيست", Mesra2 = "بس حکايت‌های شيرين باز می‌ماند ز من",},
new Hafez{ Id= 3362, BeytNo = 6, GhazalNo = 401, Mesra1 = "گر چو شمعش پيش ميرم بر غمم خندان شود", Mesra2 = "ور برنجم خاطر نازک برنجاند ز من",},
new Hafez{ Id= 3363, BeytNo = 7, GhazalNo = 401, Mesra1 = "دوستان جان داده‌ام بهر دهانش بنگريد", Mesra2 = "کو به چيزی مختصر چون باز می‌ماند ز من",},
new Hafez{ Id= 3364, BeytNo = 8, GhazalNo = 401, Mesra1 = "صبر کن حافظ که گر زين دست باشد درس غم", Mesra2 = "عشق در هر گوشه‌ای افسانه‌ای خواند ز من",},
new Hafez{ Id= 3365, BeytNo = 1, GhazalNo = 402, Mesra1 = "نکته‌ای دلکش بگويم خال آن مه رو ببين", Mesra2 = "عقل و جان را بسته زنجير آن گيسو ببين",},
new Hafez{ Id= 3366, BeytNo = 2, GhazalNo = 402, Mesra1 = "عيب دل کردم که وحشی وضع و هرجايی مباش", Mesra2 = "گفت چشم شيرگير و غنج آن آهو ببين",},
new Hafez{ Id= 3367, BeytNo = 3, GhazalNo = 402, Mesra1 = "حلقه زلفش تماشاخانه باد صباست", Mesra2 = "جان صد صاحب دل آن جا بسته يک مو ببين",},
new Hafez{ Id= 3368, BeytNo = 4, GhazalNo = 402, Mesra1 = "عابدان آفتاب از دلبر ما غافلند", Mesra2 = "ای ملامتگو خدا را رو مبين آن رو ببين",},
new Hafez{ Id= 3369, BeytNo = 5, GhazalNo = 402, Mesra1 = "زلف دل دزدش صبا را بند بر گردن نهاد", Mesra2 = "با هواداران ره رو حيله هندو ببين",},
new Hafez{ Id= 3370, BeytNo = 6, GhazalNo = 402, Mesra1 = "اين که من در جست و جوی او ز خود فارغ شدم", Mesra2 = "کس نديده‌ست و نبيند مثلش از هر سو ببين",},
new Hafez{ Id= 3371, BeytNo = 7, GhazalNo = 402, Mesra1 = "حافظ ار در گوشه محراب می‌نالد رواست", Mesra2 = "ای نصيحتگو خدا را آن خم ابرو ببين",},
new Hafez{ Id= 3372, BeytNo = 8, GhazalNo = 402, Mesra1 = "از مراد شاه منصور ای فلک سر برمتاب", Mesra2 = "تيزی شمشير بنگر قوت بازو ببين",},
new Hafez{ Id= 3373, BeytNo = 1, GhazalNo = 403, Mesra1 = "شراب لعل کش و روی مه جبينان بين", Mesra2 = "خلاف مذهب آنان جمال اينان بين",},
new Hafez{ Id= 3374, BeytNo = 2, GhazalNo = 403, Mesra1 = "به زير دلق ملمع کمندها دارند", Mesra2 = "درازدستی اين کوته آستينان بين",},
new Hafez{ Id= 3375, BeytNo = 3, GhazalNo = 403, Mesra1 = "به خرمن دو جهان سر فرو نمی‌آرند", Mesra2 = "دماغ و کبر گدايان و خوشه چينان بين",},
new Hafez{ Id= 3376, BeytNo = 4, GhazalNo = 403, Mesra1 = "بهای نيم کرشمه هزار جان طلبند", Mesra2 = "نياز اهل دل و ناز نازنينان بين",},
new Hafez{ Id= 3377, BeytNo = 5, GhazalNo = 403, Mesra1 = "حقوق صحبت ما را به باد داد و برفت", Mesra2 = "وفای صحبت ياران و همنشينان بين",},
new Hafez{ Id= 3378, BeytNo = 6, GhazalNo = 403, Mesra1 = "اسير عشق شدن چاره خلاص من است", Mesra2 = "ضمير عاقبت انديش پيش بينان بين",},
new Hafez{ Id= 3379, BeytNo = 7, GhazalNo = 403, Mesra1 = "کدورت از دل حافظ ببرد صحبت دوست", Mesra2 = "صفای همت پاکان و پاکدينان بين",},
new Hafez{ Id= 3380, BeytNo = 1, GhazalNo = 404, Mesra1 = "می‌فکن بر صف رندان نظری بهتر از اين", Mesra2 = "بر در ميکده می کن گذری بهتر از اين",},
new Hafez{ Id= 3381, BeytNo = 2, GhazalNo = 404, Mesra1 = "در حق من لبت اين لطف که می‌فرمايد", Mesra2 = "سخت خوب است وليکن قدری بهتر از اين",},
new Hafez{ Id= 3382, BeytNo = 3, GhazalNo = 404, Mesra1 = "آن که فکرش گره از کار جهان بگشايد", Mesra2 = "گو در اين کار بفرما نظری بهتر از اين",},
new Hafez{ Id= 3383, BeytNo = 4, GhazalNo = 404, Mesra1 = "ناصحم گفت که جز غم چه هنر دارد عشق", Mesra2 = "برو ای خواجه عاقل هنری بهتر از اين",},
new Hafez{ Id= 3384, BeytNo = 5, GhazalNo = 404, Mesra1 = "دل بدان رود گرامی چه کنم گر ندهم", Mesra2 = "مادر دهر ندارد پسری بهتر از اين",},
new Hafez{ Id= 3385, BeytNo = 6, GhazalNo = 404, Mesra1 = "من چو گويم که قدح نوش و لب ساقی بوس", Mesra2 = "بشنو از من که نگويد دگری بهتر از اين",},
new Hafez{ Id= 3386, BeytNo = 7, GhazalNo = 404, Mesra1 = "کلک حافظ شکرين ميوه نباتيست به چين", Mesra2 = "که در اين باغ نبينی ثمری بهتر از اين",},
new Hafez{ Id= 3387, BeytNo = 1, GhazalNo = 405, Mesra1 = "به جان پير خرابات و حق صحبت او", Mesra2 = "که نيست در سر من جز هوای خدمت او",},
new Hafez{ Id= 3388, BeytNo = 2, GhazalNo = 405, Mesra1 = "بهشت اگر چه نه جای گناهکاران است", Mesra2 = "بيار باده که مستظهرم به همت او",},
new Hafez{ Id= 3389, BeytNo = 3, GhazalNo = 405, Mesra1 = "چراغ صاعقه آن سحاب روشن باد", Mesra2 = "که زد به خرمن ما آتش محبت او",},
new Hafez{ Id= 3390, BeytNo = 4, GhazalNo = 405, Mesra1 = "بر آستانه ميخانه گر سری بينی", Mesra2 = "مزن به پای که معلوم نيست نيت او",},
new Hafez{ Id= 3391, BeytNo = 5, GhazalNo = 405, Mesra1 = "بيا که دوش به مستی سروش عالم غيب", Mesra2 = "نويد داد که عام است فيض رحمت او",},
new Hafez{ Id= 3392, BeytNo = 6, GhazalNo = 405, Mesra1 = "مکن به چشم حقارت نگاه در من مست", Mesra2 = "که نيست معصيت و زهد بی مشيت او",},
new Hafez{ Id= 3393, BeytNo = 7, GhazalNo = 405, Mesra1 = "نمی‌کند دل من ميل زهد و توبه ولی", Mesra2 = "به نام خواجه بکوشيم و فر دولت او",},
new Hafez{ Id= 3394, BeytNo = 8, GhazalNo = 405, Mesra1 = "مدام خرقه حافظ به باده در گرو است", Mesra2 = "مگر ز خاک خرابات بود فطرت او",},
new Hafez{ Id= 3395, BeytNo = 1, GhazalNo = 406, Mesra1 = "گفتا برون شدی به تماشای ماه نو", Mesra2 = "از ماه ابروان منت شرم باد رو",},
new Hafez{ Id= 3396, BeytNo = 2, GhazalNo = 406, Mesra1 = "عمريست تا دلت ز اسيران زلف ماست", Mesra2 = "غافل ز حفظ جانب ياران خود مشو",},
new Hafez{ Id= 3397, BeytNo = 3, GhazalNo = 406, Mesra1 = "مفروش عطر عقل به هندوی زلف ما", Mesra2 = "کان جا هزار نافه مشکين به نيم جو",},
new Hafez{ Id= 3398, BeytNo = 4, GhazalNo = 406, Mesra1 = "تخم وفا و مهر در اين کهنه کشته زار", Mesra2 = "آن گه عيان شود که بود موسم درو",},
new Hafez{ Id= 3399, BeytNo = 5, GhazalNo = 406, Mesra1 = "ساقی بيار باده که رمزی بگويمت", Mesra2 = "از سر اختران کهن سير و ماه نو",},
new Hafez{ Id= 3400, BeytNo = 6, GhazalNo = 406, Mesra1 = "شکل هلال هر سر مه می‌دهد نشان", Mesra2 = "از افسر سيامک و ترک کلاه زو",},
new Hafez{ Id= 3401, BeytNo = 7, GhazalNo = 406, Mesra1 = "حافظ جناب پير مغان مامن وفاست", Mesra2 = "درس حديث عشق بر او خوان و ز او شنو",},
new Hafez{ Id= 3402, BeytNo = 1, GhazalNo = 407, Mesra1 = "مزرع سبز فلک ديدم و داس مه نو", Mesra2 = "يادم از کشته خويش آمد و هنگام درو",},
new Hafez{ Id= 3403, BeytNo = 2, GhazalNo = 407, Mesra1 = "گفتم ای بخت بخفتيدی و خورشيد دميد", Mesra2 = "گفت با اين همه از سابقه نوميد مشو",},
new Hafez{ Id= 3404, BeytNo = 3, GhazalNo = 407, Mesra1 = "گر روی پاک و مجرد چو مسيحا به فلک", Mesra2 = "از چراغ تو به خورشيد رسد صد پرتو",},
new Hafez{ Id= 3405, BeytNo = 4, GhazalNo = 407, Mesra1 = "تکيه بر اختر شب دزد مکن کاين عيار", Mesra2 = "تاج کاووس ببرد و کمر کيخسرو",},
new Hafez{ Id= 3406, BeytNo = 5, GhazalNo = 407, Mesra1 = "گوشوار زر و لعل ار چه گران دارد گوش", Mesra2 = "دور خوبی گذران است نصيحت بشنو",},
new Hafez{ Id= 3407, BeytNo = 6, GhazalNo = 407, Mesra1 = "چشم بد دور ز خال تو که در عرصه حسن", Mesra2 = "بيدقی راند که برد از مه و خورشيد گرو",},
new Hafez{ Id= 3408, BeytNo = 7, GhazalNo = 407, Mesra1 = "آسمان گو مفروش اين عظمت کاندر عشق", Mesra2 = "خرمن مه به جوی خوشه پروين به دو جو",},
new Hafez{ Id= 3409, BeytNo = 8, GhazalNo = 407, Mesra1 = "آتش زهد و ريا خرمن دين خواهد سوخت", Mesra2 = "حافظ اين خرقه پشمينه بينداز و برو",},
new Hafez{ Id= 3410, BeytNo = 1, GhazalNo = 408, Mesra1 = "ای آفتاب آينه دار جمال تو", Mesra2 = "مشک سياه مجمره گردان خال تو",},
new Hafez{ Id= 3411, BeytNo = 2, GhazalNo = 408, Mesra1 = "صحن سرای ديده بشستم ولی چه سود", Mesra2 = "کاين گوشه نيست درخور خيل خيال تو",},
new Hafez{ Id= 3412, BeytNo = 3, GhazalNo = 408, Mesra1 = "در اوج ناز و نعمتی ای پادشاه حسن", Mesra2 = "يا رب مباد تا به قيامت زوال تو",},
new Hafez{ Id= 3413, BeytNo = 4, GhazalNo = 408, Mesra1 = "مطبوعتر ز نقش تو صورت نبست باز", Mesra2 = "طغرانويس ابروی مشکين مثال تو",},
new Hafez{ Id= 3414, BeytNo = 5, GhazalNo = 408, Mesra1 = "در چين زلفش ای دل مسکين چگونه‌ای", Mesra2 = "کشفته گفت باد صبا شرح حال تو",},
new Hafez{ Id= 3415, BeytNo = 6, GhazalNo = 408, Mesra1 = "برخاست بوی گل ز در آشتی درآی", Mesra2 = "ای نوبهار ما رخ فرخنده فال تو",},
new Hafez{ Id= 3416, BeytNo = 7, GhazalNo = 408, Mesra1 = "تا آسمان ز حلقه به گوشان ما شود", Mesra2 = "کو عشوه‌ای ز ابروی همچون هلال تو",},
new Hafez{ Id= 3417, BeytNo = 8, GhazalNo = 408, Mesra1 = "تا پيش بخت بازروم تهنيت کنان", Mesra2 = "کو مژده‌ای ز مقدم عيد وصال تو",},
new Hafez{ Id= 3418, BeytNo = 9, GhazalNo = 408, Mesra1 = "اين نقطه سياه که آمد مدار نور", Mesra2 = "عکسيست در حديقه بينش ز خال تو",},
new Hafez{ Id= 3419, BeytNo = 10, GhazalNo = 408, Mesra1 = "در پيش شاه عرض کدامين جفا کنم", Mesra2 = "شرح نيازمندی خود يا ملال تو",},
new Hafez{ Id= 3420, BeytNo = 11, GhazalNo = 408, Mesra1 = "حافظ در اين کمند سر سرکشان بسيست", Mesra2 = "سودای کج مپز که نباشد مجال تو",},
new Hafez{ Id= 3421, BeytNo = 1, GhazalNo = 409, Mesra1 = "ای خونبهای نافه چين خاک راه تو", Mesra2 = "خورشيد سايه پرور طرف کلاه تو",},
new Hafez{ Id= 3422, BeytNo = 2, GhazalNo = 409, Mesra1 = "نرگس کرشمه می‌برد از حد برون خرام", Mesra2 = "ای من فدای شيوه چشم سياه تو",},
new Hafez{ Id= 3423, BeytNo = 3, GhazalNo = 409, Mesra1 = "خونم بخور که هيچ ملک با چنان جمال", Mesra2 = "از دل نيايدش که نويسد گناه تو",},
new Hafez{ Id= 3424, BeytNo = 4, GhazalNo = 409, Mesra1 = "آرام و خواب خلق جهان را سبب تويی", Mesra2 = "زان شد کنار ديده و دل تکيه گاه تو",},
new Hafez{ Id= 3425, BeytNo = 5, GhazalNo = 409, Mesra1 = "با هر ستاره‌ای سر و کار است هر شبم", Mesra2 = "از حسرت فروغ رخ همچو ماه تو",},
new Hafez{ Id= 3426, BeytNo = 6, GhazalNo = 409, Mesra1 = "ياران همنشين همه از هم جدا شدند", Mesra2 = "ماييم و آستانه دولت پناه تو",},
new Hafez{ Id= 3427, BeytNo = 7, GhazalNo = 409, Mesra1 = "حافظ طمع مبر ز عنايت که عاقبت", Mesra2 = "آتش زند به خرمن غم دود آه تو",},
new Hafez{ Id= 3428, BeytNo = 1, GhazalNo = 410, Mesra1 = "ای قبای پادشاهی راست بر بالای تو", Mesra2 = "زينت تاج و نگين از گوهر والای تو",},
new Hafez{ Id= 3429, BeytNo = 2, GhazalNo = 410, Mesra1 = "آفتاب فتح را هر دم طلوعی می‌دهد", Mesra2 = "از کلاه خسروی رخسار مه سيمای تو",},
new Hafez{ Id= 3430, BeytNo = 3, GhazalNo = 410, Mesra1 = "جلوه گاه طاير اقبال باشد هر کجا", Mesra2 = "سايه‌اندازد همای چتر گردون سای تو",},
new Hafez{ Id= 3431, BeytNo = 4, GhazalNo = 410, Mesra1 = "از رسوم شرع و حکمت با هزاران اختلاف", Mesra2 = "نکته‌ای هرگز نشد فوت از دل دانای تو",},
new Hafez{ Id= 3432, BeytNo = 5, GhazalNo = 410, Mesra1 = "آب حيوانش ز منقار بلاغت می‌چکد", Mesra2 = "طوطی خوش لهجه يعنی کلک شکرخای تو",},
new Hafez{ Id= 3433, BeytNo = 6, GhazalNo = 410, Mesra1 = "گر چه خورشيد فلک چشم و چراغ عالم است", Mesra2 = "روشنايی بخش چشم اوست خاک پای تو",},
new Hafez{ Id= 3434, BeytNo = 7, GhazalNo = 410, Mesra1 = "آن چه اسکندر طلب کرد و ندادش روزگار", Mesra2 = "جرعه‌ای بود از زلال جام جان افزای تو",},
new Hafez{ Id= 3435, BeytNo = 8, GhazalNo = 410, Mesra1 = "عرض حاجت در حريم حضرتت محتاج نيست", Mesra2 = "راز کس مخفی نماند با فروغ رای تو",},
new Hafez{ Id= 3436, BeytNo = 9, GhazalNo = 410, Mesra1 = "خسروا پيرانه سر حافظ جوانی می‌کند", Mesra2 = "بر اميد عفو جان بخش گنه فرسای تو",},
new Hafez{ Id= 3437, BeytNo = 1, GhazalNo = 411, Mesra1 = "تاب بنفشه می‌دهد طره مشک سای تو", Mesra2 = "پرده غنچه می‌درد خنده دلگشای تو",},
new Hafez{ Id= 3438, BeytNo = 2, GhazalNo = 411, Mesra1 = "ای گل خوش نسيم من بلبل خويش را مسوز", Mesra2 = "کز سر صدق می‌کند شب همه شب دعای تو",},
new Hafez{ Id= 3439, BeytNo = 3, GhazalNo = 411, Mesra1 = "من که ملول گشتمی از نفس فرشتگان", Mesra2 = "قال و مقال عالمی می‌کشم از برای تو",},
new Hafez{ Id= 3440, BeytNo = 4, GhazalNo = 411, Mesra1 = "دولت عشق بين که چون از سر فقر و افتخار", Mesra2 = "گوشه تاج سلطنت می‌شکند گدای تو",},
new Hafez{ Id= 3441, BeytNo = 5, GhazalNo = 411, Mesra1 = "خرقه زهد و جام می گر چه نه درخور همند", Mesra2 = "اين همه نقش می‌زنم از جهت رضای تو",},
new Hafez{ Id= 3442, BeytNo = 6, GhazalNo = 411, Mesra1 = "شور شراب عشق تو آن نفسم رود ز سر", Mesra2 = "کاين سر پرهوس شود خاک در سرای تو",},
new Hafez{ Id= 3443, BeytNo = 7, GhazalNo = 411, Mesra1 = "شاهنشين چشم من تکيه گه خيال توست", Mesra2 = "جای دعاست شاه من بی تو مباد جای تو",},
new Hafez{ Id= 3444, BeytNo = 8, GhazalNo = 411, Mesra1 = "خوش چمنيست عارضت خاصه که در بهار حسن", Mesra2 = "حافظ خوش کلام شد مرغ سخنسرای تو",},
new Hafez{ Id= 3445, BeytNo = 1, GhazalNo = 412, Mesra1 = "مرا چشميست خون افشان ز دست آن کمان ابرو", Mesra2 = "جهان بس فتنه خواهد ديد از آن چشم و از آن ابرو",},
new Hafez{ Id= 3446, BeytNo = 2, GhazalNo = 412, Mesra1 = "غلام چشم آن ترکم که در خواب خوش مستی", Mesra2 = "نگارين گلشنش روی است و مشکين سايبان ابرو",},
new Hafez{ Id= 3447, BeytNo = 3, GhazalNo = 412, Mesra1 = "هلالی شد تنم زين غم که با طغرای ابرويش", Mesra2 = "که باشد مه که بنمايد ز طاق آسمان ابرو",},
new Hafez{ Id= 3448, BeytNo = 4, GhazalNo = 412, Mesra1 = "رقيبان غافل و ما را از آن چشم و جبين هر دم", Mesra2 = "هزاران گونه پيغام است و حاجب در ميان ابرو",},
new Hafez{ Id= 3449, BeytNo = 5, GhazalNo = 412, Mesra1 = "روان گوشه گيران را جبينش طرفه گلزاريست", Mesra2 = "که بر طرف سمن زارش همی‌گردد چمان ابرو",},
new Hafez{ Id= 3450, BeytNo = 6, GhazalNo = 412, Mesra1 = "دگر حور و پری را کس نگويد با چنين حسنی", Mesra2 = "که اين را اين چنين چشم است و آن را آن چنان ابرو",},
new Hafez{ Id= 3451, BeytNo = 7, GhazalNo = 412, Mesra1 = "تو کافردل نمی‌بندی نقاب زلف و می‌ترسم", Mesra2 = "که محرابم بگرداند خم آن دلستان ابرو",},
new Hafez{ Id= 3452, BeytNo = 8, GhazalNo = 412, Mesra1 = "اگر چه مرغ زيرک بود حافظ در هواداری", Mesra2 = "به تير غمزه صيدش کرد چشم آن کمان ابرو",},
new Hafez{ Id= 3453, BeytNo = 1, GhazalNo = 413, Mesra1 = "خط عذار يار که بگرفت ماه از او", Mesra2 = "خوش حلقه‌ايست ليک به در نيست راه از او",},
new Hafez{ Id= 3454, BeytNo = 2, GhazalNo = 413, Mesra1 = "ابروی دوست گوشه محراب دولت است", Mesra2 = "آن جا بمال چهره و حاجت بخواه از او",},
new Hafez{ Id= 3455, BeytNo = 3, GhazalNo = 413, Mesra1 = "ای جرعه نوش مجلس جم سينه پاک دار", Mesra2 = "کيينه‌ايست جام جهان بين که آه از او",},
new Hafez{ Id= 3456, BeytNo = 4, GhazalNo = 413, Mesra1 = "کردار اهل صومعه‌ام کرد می پرست", Mesra2 = "اين دود بين که نامه من شد سياه از او",},
new Hafez{ Id= 3457, BeytNo = 5, GhazalNo = 413, Mesra1 = "سلطان غم هر آن چه تواند بگو بکن", Mesra2 = "من برده‌ام به باده فروشان پناه از او",},
new Hafez{ Id= 3458, BeytNo = 6, GhazalNo = 413, Mesra1 = "ساقی چراغ می به ره آفتاب دار", Mesra2 = "گو برفروز مشعله صبحگاه از او",},
new Hafez{ Id= 3459, BeytNo = 7, GhazalNo = 413, Mesra1 = "آبی به روزنامه اعمال ما فشان", Mesra2 = "باشد توان سترد حروف گناه از او",},
new Hafez{ Id= 3460, BeytNo = 8, GhazalNo = 413, Mesra1 = "حافظ که ساز مطرب عشاق ساز کرد", Mesra2 = "خالی مباد عرصه اين بزمگاه از او",},
new Hafez{ Id= 3461, BeytNo = 9, GhazalNo = 413, Mesra1 = "آيا در اين خيال که دارد گدای شهر", Mesra2 = "روزی بود که ياد کند پادشاه از او",},
new Hafez{ Id= 3462, BeytNo = 1, GhazalNo = 414, Mesra1 = "گلبن عيش می‌دمد ساقی گلعذار کو", Mesra2 = "باد بهار می‌وزد باده خوشگوار کو",},
new Hafez{ Id= 3463, BeytNo = 2, GhazalNo = 414, Mesra1 = "هر گل نو ز گلرخی ياد همی‌کند ولی", Mesra2 = "گوش سخن شنو کجا ديده اعتبار کو",},
new Hafez{ Id= 3464, BeytNo = 3, GhazalNo = 414, Mesra1 = "مجلس بزم عيش را غاليه مراد نيست", Mesra2 = "ای دم صبح خوش نفس نافه زلف يار کو",},
new Hafez{ Id= 3465, BeytNo = 4, GhazalNo = 414, Mesra1 = "حسن فروشی گلم نيست تحمل ای صبا", Mesra2 = "دست زدم به خون دل بهر خدا نگار کو",},
new Hafez{ Id= 3466, BeytNo = 5, GhazalNo = 414, Mesra1 = "شمع سحرگهی اگر لاف ز عارض تو زد", Mesra2 = "خصم زبان دراز شد خنجر آبدار کو",},
new Hafez{ Id= 3467, BeytNo = 6, GhazalNo = 414, Mesra1 = "گفت مگر ز لعل من بوسه نداری آرزو", Mesra2 = "مردم از اين هوس ولی قدرت و اختيار کو",},
new Hafez{ Id= 3468, BeytNo = 7, GhazalNo = 414, Mesra1 = "حافظ اگر چه در سخن خازن گنج حکمت است", Mesra2 = "از غم روزگار دون طبع سخن گزار کو",},
new Hafez{ Id= 3469, BeytNo = 1, GhazalNo = 415, Mesra1 = "ای پيک راستان خبر يار ما بگو", Mesra2 = "احوال گل به بلبل دستان سرا بگو",},
new Hafez{ Id= 3470, BeytNo = 2, GhazalNo = 415, Mesra1 = "ما محرمان خلوت انسيم غم مخور", Mesra2 = "با يار آشنا سخن آشنا بگو",},
new Hafez{ Id= 3471, BeytNo = 3, GhazalNo = 415, Mesra1 = "برهم چو می‌زد آن سر زلفين مشکبار", Mesra2 = "با ما سر چه داشت ز بهر خدا بگو",},
new Hafez{ Id= 3472, BeytNo = 4, GhazalNo = 415, Mesra1 = "هر کس که گفت خاک در دوست توتياست", Mesra2 = "گو اين سخن معاينه در چشم ما بگو",},
new Hafez{ Id= 3473, BeytNo = 5, GhazalNo = 415, Mesra1 = "آن کس که منع ما ز خرابات می‌کند", Mesra2 = "گو در حضور پير من اين ماجرا بگو",},
new Hafez{ Id= 3474, BeytNo = 6, GhazalNo = 415, Mesra1 = "گر ديگرت بر آن در دولت گذر بود", Mesra2 = "بعد از ادای خدمت و عرض دعا بگو",},
new Hafez{ Id= 3475, BeytNo = 7, GhazalNo = 415, Mesra1 = "هر چند ما بديم تو ما را بدان مگير", Mesra2 = "شاهانه ماجرای گناه گدا بگو",},
new Hafez{ Id= 3476, BeytNo = 8, GhazalNo = 415, Mesra1 = "بر اين فقير نامه آن محتشم بخوان", Mesra2 = "با اين گدا حکايت آن پادشا بگو",},
new Hafez{ Id= 3477, BeytNo = 9, GhazalNo = 415, Mesra1 = "جان‌ها ز دام زلف چو بر خاک می‌فشاند", Mesra2 = "بر آن غريب ما چه گذشت ای صبا بگو",},
new Hafez{ Id= 3478, BeytNo = 10, GhazalNo = 415, Mesra1 = "جان پرور است قصه ارباب معرفت", Mesra2 = "رمزی برو بپرس حديثی بيا بگو",},
new Hafez{ Id= 3479, BeytNo = 11, GhazalNo = 415, Mesra1 = "حافظ گرت به مجلس او راه می‌دهند", Mesra2 = "می نوش و ترک زرق ز بهر خدا بگو",},
new Hafez{ Id= 3480, BeytNo = 1, GhazalNo = 416, Mesra1 = "خنک نسيم معنبر شمامه‌ای دلخواه", Mesra2 = "که در هوای تو برخاست بامداد پگاه",},
new Hafez{ Id= 3481, BeytNo = 2, GhazalNo = 416, Mesra1 = "دليل راه شو ای طاير خجسته لقا", Mesra2 = "که ديده آب شد از شوق خاک آن درگاه",},
new Hafez{ Id= 3482, BeytNo = 3, GhazalNo = 416, Mesra1 = "به ياد شخص نزارم که غرق خون دل است", Mesra2 = "هلال را ز کنار افق کنيد نگاه",},
new Hafez{ Id= 3483, BeytNo = 4, GhazalNo = 416, Mesra1 = "منم که بی تو نفس می‌کشم زهی خجلت", Mesra2 = "مگر تو عفو کنی ور نه چيست عذر گناه",},
new Hafez{ Id= 3484, BeytNo = 5, GhazalNo = 416, Mesra1 = "ز دوستان تو آموخت در طريقت مهر", Mesra2 = "سپيده دم که صبا چاک زد شعار سياه",},
new Hafez{ Id= 3485, BeytNo = 6, GhazalNo = 416, Mesra1 = "به عشق روی تو روزی که از جهان بروم", Mesra2 = "ز تربتم بدمد سرخ گل به جای گياه",},
new Hafez{ Id= 3486, BeytNo = 7, GhazalNo = 416, Mesra1 = "مده به خاطر نازک ملالت از من زود", Mesra2 = "که حافظ تو خود اين لحظه گفت بسم الله",},
new Hafez{ Id= 3487, BeytNo = 1, GhazalNo = 417, Mesra1 = "عيشم مدام است از لعل دلخواه", Mesra2 = "کارم به کام است الحمدلله",},
new Hafez{ Id= 3488, BeytNo = 2, GhazalNo = 417, Mesra1 = "ای بخت سرکش تنگش به بر کش", Mesra2 = "گه جام زر کش گه لعل دلخواه",},
new Hafez{ Id= 3489, BeytNo = 3, GhazalNo = 417, Mesra1 = "ما را به رندی افسانه کردند", Mesra2 = "پيران جاهل شيخان گمراه",},
new Hafez{ Id= 3490, BeytNo = 4, GhazalNo = 417, Mesra1 = "از دست زاهد کرديم توبه", Mesra2 = "و از فعل عابد استغفرالله",},
new Hafez{ Id= 3491, BeytNo = 5, GhazalNo = 417, Mesra1 = "جانا چه گويم شرح فراقت", Mesra2 = "چشمی و صد نم جانی و صد آه",},
new Hafez{ Id= 3492, BeytNo = 6, GhazalNo = 417, Mesra1 = "کافر مبيناد اين غم که ديده‌ست", Mesra2 = "از قامتت سرو از عارضت ماه",},
new Hafez{ Id= 3493, BeytNo = 7, GhazalNo = 417, Mesra1 = "شوق لبت برد از ياد حافظ", Mesra2 = "درس شبانه ورد سحرگاه",},
new Hafez{ Id= 3494, BeytNo = 1, GhazalNo = 418, Mesra1 = "گر تيغ بارد در کوی آن ماه", Mesra2 = "گردن نهاديم الحکم لله",},
new Hafez{ Id= 3495, BeytNo = 2, GhazalNo = 418, Mesra1 = "آيين تقوا ما نيز دانيم", Mesra2 = "ليکن چه چاره با بخت گمراه",},
new Hafez{ Id= 3496, BeytNo = 3, GhazalNo = 418, Mesra1 = "ما شيخ و واعظ کمتر شناسيم", Mesra2 = "يا جام باده يا قصه کوتاه",},
new Hafez{ Id= 3497, BeytNo = 4, GhazalNo = 418, Mesra1 = "من رند و عاشق در موسم گل", Mesra2 = "آن گاه توبه استغفرالله",},
new Hafez{ Id= 3498, BeytNo = 5, GhazalNo = 418, Mesra1 = "مهر تو عکسی بر ما نيفکند", Mesra2 = "آيينه رويا آه از دلت آه",},
new Hafez{ Id= 3499, BeytNo = 6, GhazalNo = 418, Mesra1 = "الصبر مر و العمر فان", Mesra2 = "يا ليت شعری حتام القاه",},
new Hafez{ Id= 3500, BeytNo = 7, GhazalNo = 418, Mesra1 = "حافظ چه نالی گر وصل خواهی", Mesra2 = "خون بايدت خورد در گاه و بی‌گاه",},
new Hafez{ Id= 3501, BeytNo = 1, GhazalNo = 419, Mesra1 = "وصال او ز عمر جاودان به", Mesra2 = "خداوندا مرا آن ده که آن به",},
new Hafez{ Id= 3502, BeytNo = 2, GhazalNo = 419, Mesra1 = "به شمشيرم زد و با کس نگفتم", Mesra2 = "که راز دوست از دشمن نهان به",},
new Hafez{ Id= 3503, BeytNo = 3, GhazalNo = 419, Mesra1 = "به داغ بندگی مردن بر اين در", Mesra2 = "به جان او که از ملک جهان به",},
new Hafez{ Id= 3504, BeytNo = 4, GhazalNo = 419, Mesra1 = "خدا را از طبيب من بپرسيد", Mesra2 = "که آخر کی شود اين ناتوان به",},
new Hafez{ Id= 3505, BeytNo = 5, GhazalNo = 419, Mesra1 = "گلی کان پايمال سرو ما گشت", Mesra2 = "بود خاکش ز خون ارغوان به",},
new Hafez{ Id= 3506, BeytNo = 6, GhazalNo = 419, Mesra1 = "به خلدم دعوت ای زاهد مفرما", Mesra2 = "که اين سيب زنخ زان بوستان به",},
new Hafez{ Id= 3507, BeytNo = 7, GhazalNo = 419, Mesra1 = "دلا دايم گدای کوی او باش", Mesra2 = "به حکم آن که دولت جاودان به",},
new Hafez{ Id= 3508, BeytNo = 8, GhazalNo = 419, Mesra1 = "جوانا سر متاب از پند پيران", Mesra2 = "که رای پير از بخت جوان به",},
new Hafez{ Id= 3509, BeytNo = 9, GhazalNo = 419, Mesra1 = "شبی می‌گفت چشم کس نديده‌ست", Mesra2 = "ز مرواريد گوشم در جهان به",},
new Hafez{ Id= 3510, BeytNo = 10, GhazalNo = 419, Mesra1 = "اگر چه زنده رود آب حيات است", Mesra2 = "ولی شيراز ما از اصفهان به",},
new Hafez{ Id= 3511, BeytNo = 11, GhazalNo = 419, Mesra1 = "سخن اندر دهان دوست شکر", Mesra2 = "وليکن گفته حافظ از آن به",},
new Hafez{ Id= 3512, BeytNo = 1, GhazalNo = 420, Mesra1 = "ناگهان پرده برانداخته‌ای يعنی چه", Mesra2 = "مست از خانه برون تاخته‌ای يعنی چه",},
new Hafez{ Id= 3513, BeytNo = 2, GhazalNo = 420, Mesra1 = "زلف در دست صبا گوش به فرمان رقيب", Mesra2 = "اين چنين با همه درساخته‌ای يعنی چه",},
new Hafez{ Id= 3514, BeytNo = 3, GhazalNo = 420, Mesra1 = "شاه خوبانی و منظور گدايان شده‌ای", Mesra2 = "قدر اين مرتبه نشناخته‌ای يعنی چه",},
new Hafez{ Id= 3515, BeytNo = 4, GhazalNo = 420, Mesra1 = "نه سر زلف خود اول تو به دستم دادی", Mesra2 = "بازم از پای درانداخته‌ای يعنی چه",},
new Hafez{ Id= 3516, BeytNo = 5, GhazalNo = 420, Mesra1 = "سخنت رمز دهان گفت و کمر سر ميان", Mesra2 = "و از ميان تيغ به ما آخته‌ای يعنی چه",},
new Hafez{ Id= 3517, BeytNo = 6, GhazalNo = 420, Mesra1 = "هر کس از مهره مهر تو به نقشی مشغول", Mesra2 = "عاقبت با همه کج باخته‌ای يعنی چه",},
new Hafez{ Id= 3518, BeytNo = 7, GhazalNo = 420, Mesra1 = "حافظا در دل تنگت چو فرود آمد يار", Mesra2 = "خانه از غير نپرداخته‌ای يعنی چه",},
new Hafez{ Id= 3519, BeytNo = 1, GhazalNo = 421, Mesra1 = "در سرای مغان رفته بود و آب زده", Mesra2 = "نشسته پير و صلايی به شيخ و شاب زده",},
new Hafez{ Id= 3520, BeytNo = 2, GhazalNo = 421, Mesra1 = "سبوکشان همه در بندگيش بسته کمر", Mesra2 = "ولی ز ترک کله چتر بر سحاب زده",},
new Hafez{ Id= 3521, BeytNo = 3, GhazalNo = 421, Mesra1 = "شعاع جام و قدح نور ماه پوشيده", Mesra2 = "عذار مغبچگان راه آفتاب زده",},
new Hafez{ Id= 3522, BeytNo = 4, GhazalNo = 421, Mesra1 = "عروس بخت در آن حجله با هزاران ناز", Mesra2 = "شکسته کسمه و بر برگ گل گلاب زده",},
new Hafez{ Id= 3523, BeytNo = 5, GhazalNo = 421, Mesra1 = "گرفته ساغر عشرت فرشته رحمت", Mesra2 = "ز جرعه بر رخ حور و پری گلاب زده",},
new Hafez{ Id= 3524, BeytNo = 6, GhazalNo = 421, Mesra1 = "ز شور و عربده شاهدان شيرين کار", Mesra2 = "شکر شکسته سمن ريخته رباب زده",},
new Hafez{ Id= 3525, BeytNo = 7, GhazalNo = 421, Mesra1 = "سلام کردم و با من به روی خندان گفت", Mesra2 = "که ای خمارکش مفلس شراب زده",},
new Hafez{ Id= 3526, BeytNo = 8, GhazalNo = 421, Mesra1 = "که اين کند که تو کردی به ضعف همت و رای", Mesra2 = "ز گنج خانه شده خيمه بر خراب زده",},
new Hafez{ Id= 3527, BeytNo = 9, GhazalNo = 421, Mesra1 = "وصال دولت بيدار ترسمت ندهند", Mesra2 = "که خفته‌ای تو در آغوش بخت خواب زده",},
new Hafez{ Id= 3528, BeytNo = 10, GhazalNo = 421, Mesra1 = "بيا به ميکده حافظ که بر تو عرضه کنم", Mesra2 = "هزار صف ز دعاهای مستجاب زده",},
new Hafez{ Id= 3529, BeytNo = 11, GhazalNo = 421, Mesra1 = "فلک جنيبه کش شاه نصره الدين است", Mesra2 = "بيا ببين ملکش دست در رکاب زده",},
new Hafez{ Id= 3530, BeytNo = 12, GhazalNo = 421, Mesra1 = "خرد که ملهم غيب است بهر کسب شرف", Mesra2 = "ز بام عرش صدش بوسه بر جناب زده",},
new Hafez{ Id= 3531, BeytNo = 1, GhazalNo = 422, Mesra1 = "ای که با سلسله زلف دراز آمده‌ای", Mesra2 = "فرصتت باد که ديوانه نواز آمده‌ای",},
new Hafez{ Id= 3532, BeytNo = 2, GhazalNo = 422, Mesra1 = "ساعتی ناز مفرما و بگردان عادت", Mesra2 = "چون به پرسيدن ارباب نياز آمده‌ای",},
new Hafez{ Id= 3533, BeytNo = 3, GhazalNo = 422, Mesra1 = "پيش بالای تو ميرم چه به صلح و چه به جنگ", Mesra2 = "چون به هر حال برازنده ناز آمده‌ای",},
new Hafez{ Id= 3534, BeytNo = 4, GhazalNo = 422, Mesra1 = "آب و آتش به هم آميخته‌ای از لب لعل", Mesra2 = "چشم بد دور که بس شعبده بازآمده‌ای",},
new Hafez{ Id= 3535, BeytNo = 5, GhazalNo = 422, Mesra1 = "آفرين بر دل نرم تو که از بهر ثواب", Mesra2 = "کشته غمزه خود را به نماز آمده‌ای",},
new Hafez{ Id= 3536, BeytNo = 6, GhazalNo = 422, Mesra1 = "زهد من با تو چه سنجد که به يغمای دلم", Mesra2 = "مست و آشفته به خلوتگه راز آمده‌ای",},
new Hafez{ Id= 3537, BeytNo = 7, GhazalNo = 422, Mesra1 = "گفت حافظ دگرت خرقه شراب آلوده‌ست", Mesra2 = "مگر از مذهب اين طايفه بازآمده‌ای",},
new Hafez{ Id= 3538, BeytNo = 1, GhazalNo = 423, Mesra1 = "دوش رفتم به در ميکده خواب آلوده", Mesra2 = "خرقه تردامن و سجاده شراب آلوده",},
new Hafez{ Id= 3539, BeytNo = 2, GhazalNo = 423, Mesra1 = "آمد افسوس کنان مغبچه باده فروش", Mesra2 = "گفت بيدار شو ای ره رو خواب آلوده",},
new Hafez{ Id= 3540, BeytNo = 3, GhazalNo = 423, Mesra1 = "شست و شويی کن و آن گه به خرابات خرام", Mesra2 = "تا نگردد ز تو اين دير خراب آلوده",},
new Hafez{ Id= 3541, BeytNo = 4, GhazalNo = 423, Mesra1 = "به هوای لب شيرين پسران چند کنی", Mesra2 = "جوهر روح به ياقوت مذاب آلوده",},
new Hafez{ Id= 3542, BeytNo = 5, GhazalNo = 423, Mesra1 = "به طهارت گذران منزل پيری و مکن", Mesra2 = "خلعت شيب چو تشريف شباب آلوده",},
new Hafez{ Id= 3543, BeytNo = 6, GhazalNo = 423, Mesra1 = "پاک و صافی شو و از چاه طبيعت به درآی", Mesra2 = "که صفايی ندهد آب تراب آلوده",},
new Hafez{ Id= 3544, BeytNo = 7, GhazalNo = 423, Mesra1 = "گفتم ای جان جهان دفتر گل عيبی نيست", Mesra2 = "که شود فصل بهار از می ناب آلوده",},
new Hafez{ Id= 3545, BeytNo = 8, GhazalNo = 423, Mesra1 = "آشنايان ره عشق در اين بحر عميق", Mesra2 = "غرقه گشتند و نگشتند به آب آلوده",},
new Hafez{ Id= 3546, BeytNo = 9, GhazalNo = 423, Mesra1 = "گفت حافظ لغز و نکته به ياران مفروش", Mesra2 = "آه از اين لطف به انواع عتاب آلوده",},
new Hafez{ Id= 3547, BeytNo = 1, GhazalNo = 424, Mesra1 = "از من جدا مشو که توام نور ديده‌ای", Mesra2 = "آرام جان و مونس قلب رميده‌ای",},
new Hafez{ Id= 3548, BeytNo = 2, GhazalNo = 424, Mesra1 = "از دامن تو دست ندارند عاشقان", Mesra2 = "پيراهن صبوری ايشان دريده‌ای",},
new Hafez{ Id= 3549, BeytNo = 3, GhazalNo = 424, Mesra1 = "از چشم بخت خويش مبادت گزند از آنک", Mesra2 = "در دلبری به غايت خوبی رسيده‌ای",},
new Hafez{ Id= 3550, BeytNo = 4, GhazalNo = 424, Mesra1 = "منعم مکن ز عشق وی ای مفتی زمان", Mesra2 = "معذور دارمت که تو او را نديده‌ای",},
new Hafez{ Id= 3551, BeytNo = 5, GhazalNo = 424, Mesra1 = "آن سرزنش که کرد تو را دوست حافظا", Mesra2 = "بيش از گليم خويش مگر پا کشيده‌ای",},
new Hafez{ Id= 3552, BeytNo = 1, GhazalNo = 425, Mesra1 = "دامن کشان همی‌شد در شرب زرکشيده", Mesra2 = "صد ماه رو ز رشکش جيب قصب دريده",},
new Hafez{ Id= 3553, BeytNo = 2, GhazalNo = 425, Mesra1 = "از تاب آتش می بر گرد عارضش خوی", Mesra2 = "چون قطره‌های شبنم بر برگ گل چکيده",},
new Hafez{ Id= 3554, BeytNo = 3, GhazalNo = 425, Mesra1 = "لفظی فصيح شيرين قدی بلند چابک", Mesra2 = "رويی لطيف زيبا چشمی خوش کشيده",},
new Hafez{ Id= 3555, BeytNo = 4, GhazalNo = 425, Mesra1 = "ياقوت جان فزايش از آب لطف زاده", Mesra2 = "شمشاد خوش خرامش در ناز پروريده",},
new Hafez{ Id= 3556, BeytNo = 5, GhazalNo = 425, Mesra1 = "آن لعل دلکشش بين وان خنده دل آشوب", Mesra2 = "وان رفتن خوشش بين وان گام آرميده",},
new Hafez{ Id= 3557, BeytNo = 6, GhazalNo = 425, Mesra1 = "آن آهوی سيه چشم از دام ما برون شد", Mesra2 = "ياران چه چاره سازم با اين دل رميده",},
new Hafez{ Id= 3558, BeytNo = 7, GhazalNo = 425, Mesra1 = "زنهار تا توانی اهل نظر ميازار", Mesra2 = "دنيا وفا ندارد ای نور هر دو ديده",},
new Hafez{ Id= 3559, BeytNo = 8, GhazalNo = 425, Mesra1 = "تا کی کشم عتيبت از چشم دلفريبت", Mesra2 = "روزی کرشمه‌ای کن ای يار برگزيده",},
new Hafez{ Id= 3560, BeytNo = 9, GhazalNo = 425, Mesra1 = "گر خاطر شريفت رنجيده شد ز حافظ", Mesra2 = "بازآ که توبه کرديم از گفته و شنيده",},
new Hafez{ Id= 3561, BeytNo = 10, GhazalNo = 425, Mesra1 = "بس شکر بازگويم در بندگی خواجه", Mesra2 = "گر اوفتد به دستم آن ميوه رسيده",},
new Hafez{ Id= 3562, BeytNo = 1, GhazalNo = 426, Mesra1 = "از خون دل نوشتم نزديک دوست نامه", Mesra2 = "انی رايت دهرا من هجرک القيامه",},
new Hafez{ Id= 3563, BeytNo = 2, GhazalNo = 426, Mesra1 = "دارم من از فراقش در ديده صد علامت", Mesra2 = "ليست دموع عينی هذا لنا العلامه",},
new Hafez{ Id= 3564, BeytNo = 3, GhazalNo = 426, Mesra1 = "هر چند کزمودم از وی نبود سودم", Mesra2 = "من جرب المجرب حلت به الندامه",},
new Hafez{ Id= 3565, BeytNo = 4, GhazalNo = 426, Mesra1 = "پرسيدم از طبيبی احوال دوست گفتا", Mesra2 = "فی بعدها عذاب فی قربها السلامه",},
new Hafez{ Id= 3566, BeytNo = 5, GhazalNo = 426, Mesra1 = "گفتم ملامت آيد گر گرد دوست گردم", Mesra2 = "و الله ما راينا حبا بلا ملامه",},
new Hafez{ Id= 3567, BeytNo = 6, GhazalNo = 426, Mesra1 = "حافظ چو طالب آمد جامی به جان شيرين", Mesra2 = "حتی يذوق منه کاسا من الکرامه",},
new Hafez{ Id= 3568, BeytNo = 1, GhazalNo = 427, Mesra1 = "چراغ روی تو را شمع گشت پروانه", Mesra2 = "مرا ز حال تو با حال خويش پروا نه",},
new Hafez{ Id= 3569, BeytNo = 2, GhazalNo = 427, Mesra1 = "خرد که قيد مجانين عشق می‌فرمود", Mesra2 = "به بوی سنبل زلف تو گشت ديوانه",},
new Hafez{ Id= 3570, BeytNo = 3, GhazalNo = 427, Mesra1 = "به بوی زلف تو گر جان به باد رفت چه شد", Mesra2 = "هزار جان گرامی فدای جانانه",},
new Hafez{ Id= 3571, BeytNo = 4, GhazalNo = 427, Mesra1 = "من رميده ز غيرت ز پا فتادم دوش", Mesra2 = "نگار خويش چو ديدم به دست بيگانه",},
new Hafez{ Id= 3572, BeytNo = 5, GhazalNo = 427, Mesra1 = "چه نقشه‌ها که برانگيختيم و سود نداشت", Mesra2 = "فسون ما بر او گشته است افسانه",},
new Hafez{ Id= 3573, BeytNo = 6, GhazalNo = 427, Mesra1 = "بر آتش رخ زيبای او به جای سپند", Mesra2 = "به غير خال سياهش که ديد به دانه",},
new Hafez{ Id= 3574, BeytNo = 7, GhazalNo = 427, Mesra1 = "به مژده جان به صبا داد شمع در نفسی", Mesra2 = "ز شمع روی تواش چون رسيد پروانه",},
new Hafez{ Id= 3575, BeytNo = 8, GhazalNo = 427, Mesra1 = "مرا به دور لب دوست هست پيمانی", Mesra2 = "که بر زبان نبرم جز حديث پيمانه",},
new Hafez{ Id= 3576, BeytNo = 9, GhazalNo = 427, Mesra1 = "حديث مدرسه و خانقه مگوی که باز", Mesra2 = "فتاد در سر حافظ هوای ميخانه",},
new Hafez{ Id= 3577, BeytNo = 1, GhazalNo = 428, Mesra1 = "سحرگاهان که مخمور شبانه", Mesra2 = "گرفتم باده با چنگ و چغانه",},
new Hafez{ Id= 3578, BeytNo = 2, GhazalNo = 428, Mesra1 = "نهادم عقل را ره توشه از می", Mesra2 = "ز شهر هستيش کردم روانه",},
new Hafez{ Id= 3579, BeytNo = 3, GhazalNo = 428, Mesra1 = "نگار می فروشم عشوه‌ای داد", Mesra2 = "که ايمن گشتم از مکر زمانه",},
new Hafez{ Id= 3580, BeytNo = 4, GhazalNo = 428, Mesra1 = "ز ساقی کمان ابرو شنيدم", Mesra2 = "که ای تير ملامت را نشانه",},
new Hafez{ Id= 3581, BeytNo = 5, GhazalNo = 428, Mesra1 = "نبندی زان ميان طرفی کمروار", Mesra2 = "اگر خود را ببينی در ميانه",},
new Hafez{ Id= 3582, BeytNo = 6, GhazalNo = 428, Mesra1 = "برو اين دام بر مرغی دگر نه", Mesra2 = "که عنقا را بلند است آشيانه",},
new Hafez{ Id= 3583, BeytNo = 7, GhazalNo = 428, Mesra1 = "که بندد طرف وصل از حسن شاهی", Mesra2 = "که با خود عشق بازد جاودانه",},
new Hafez{ Id= 3584, BeytNo = 8, GhazalNo = 428, Mesra1 = "نديم و مطرب و ساقی همه اوست", Mesra2 = "خيال آب و گل در ره بهانه",},
new Hafez{ Id= 3585, BeytNo = 9, GhazalNo = 428, Mesra1 = "بده کشتی می تا خوش برانيم", Mesra2 = "از اين دريای ناپيداکرانه",},
new Hafez{ Id= 3586, BeytNo = 10, GhazalNo = 428, Mesra1 = "وجود ما معماييست حافظ", Mesra2 = "که تحقيقش فسون است و فسانه",},
new Hafez{ Id= 3587, BeytNo = 1, GhazalNo = 429, Mesra1 = "ساقی بيا که شد قدح لاله پر ز می", Mesra2 = "طامات تا به چند و خرافات تا به کی",},
new Hafez{ Id= 3588, BeytNo = 2, GhazalNo = 429, Mesra1 = "بگذر ز کبر و ناز که ديده‌ست روزگار", Mesra2 = "چين قبای قيصر و طرف کلاه کی",},
new Hafez{ Id= 3589, BeytNo = 3, GhazalNo = 429, Mesra1 = "هشيار شو که مرغ چمن مست گشت هان", Mesra2 = "بيدار شو که خواب عدم در پی است هی",},
new Hafez{ Id= 3590, BeytNo = 4, GhazalNo = 429, Mesra1 = "خوش نازکانه می‌چمی ای شاخ نوبهار", Mesra2 = "کشفتگی مبادت از آشوب باد دی",},
new Hafez{ Id= 3591, BeytNo = 5, GhazalNo = 429, Mesra1 = "بر مهر چرخ و شيوه او اعتماد نيست", Mesra2 = "ای وای بر کسی که شد ايمن ز مکر وی",},
new Hafez{ Id= 3592, BeytNo = 6, GhazalNo = 429, Mesra1 = "فردا شراب کوثر و حور از برای ماست", Mesra2 = "و امروز نيز ساقی مه روی و جام می",},
new Hafez{ Id= 3593, BeytNo = 7, GhazalNo = 429, Mesra1 = "باد صبا ز عهد صبی ياد می‌دهد", Mesra2 = "جان دارويی که غم ببرد درده ای صبی",},
new Hafez{ Id= 3594, BeytNo = 8, GhazalNo = 429, Mesra1 = "حشمت مبين و سلطنت گل که بسپرد", Mesra2 = "فراش باد هر ورقش را به زير پی",},
new Hafez{ Id= 3595, BeytNo = 9, GhazalNo = 429, Mesra1 = "درده به ياد حاتم طی جام يک منی", Mesra2 = "تا نامه سياه بخيلان کنيم طی",},
new Hafez{ Id= 3596, BeytNo = 10, GhazalNo = 429, Mesra1 = "زان می که داد حسن و لطافت به ارغوان", Mesra2 = "بيرون فکند لطف مزاج از رخش به خوی",},
new Hafez{ Id= 3597, BeytNo = 11, GhazalNo = 429, Mesra1 = "مسند به باغ بر که به خدمت چو بندگان", Mesra2 = "استاده است سرو و کمر بسته است نی",},
new Hafez{ Id= 3598, BeytNo = 12, GhazalNo = 429, Mesra1 = "حافظ حديث سحرفريب خوشت رسيد", Mesra2 = "تا حد مصر و چين و به اطراف روم و ری",},
new Hafez{ Id= 3599, BeytNo = 1, GhazalNo = 430, Mesra1 = "به صوت بلبل و قمری اگر ننوشی می", Mesra2 = "علاج کی کنمت آخرالدواY الکی",},
new Hafez{ Id= 3600, BeytNo = 2, GhazalNo = 430, Mesra1 = "ذخيره‌ای بنه از رنگ و بوی فصل بهار", Mesra2 = "که می‌رسند ز پی رهزنان بهمن و دی",},
new Hafez{ Id= 3601, BeytNo = 3, GhazalNo = 430, Mesra1 = "چو گل نقاب برافکند و مرغ زد هوهو", Mesra2 = "منه ز دست پياله چه می‌کنی هی هی",},
new Hafez{ Id= 3602, BeytNo = 4, GhazalNo = 430, Mesra1 = "شکوه سلطنت و حسن کی ثباتی داد", Mesra2 = "ز تخت جم سخنی مانده است و افسر کی",},
new Hafez{ Id= 3603, BeytNo = 5, GhazalNo = 430, Mesra1 = "خزينه داری ميراث خوارگان کفر است", Mesra2 = "به قول مطرب و ساقی به فتوی دف و نی",},
new Hafez{ Id= 3604, BeytNo = 6, GhazalNo = 430, Mesra1 = "زمانه هيچ نبخشد که بازنستاند", Mesra2 = "مجو ز سفله مروت که شيه لا شی",},
new Hafez{ Id= 3605, BeytNo = 7, GhazalNo = 430, Mesra1 = "نوشته‌اند بر ايوان جنه الماوی", Mesra2 = "که هر که عشوه دنيی خريد وای به وی",},
new Hafez{ Id= 3606, BeytNo = 8, GhazalNo = 430, Mesra1 = "سخا نماند سخن طی کنم شراب کجاست", Mesra2 = "بده به شادی روح و روان حاتم طی",},
new Hafez{ Id= 3607, BeytNo = 9, GhazalNo = 430, Mesra1 = "بخيل بوی خدا نشنود بيا حافظ", Mesra2 = "پياله گير و کرم ورز و الضمان علی",},
new Hafez{ Id= 3608, BeytNo = 1, GhazalNo = 431, Mesra1 = "لبش می‌بوسم و در می‌کشم می", Mesra2 = "به آب زندگانی برده‌ام پی",},
new Hafez{ Id= 3609, BeytNo = 2, GhazalNo = 431, Mesra1 = "نه رازش می‌توانم گفت با کس", Mesra2 = "نه کس را می‌توانم ديد با وی",},
new Hafez{ Id= 3610, BeytNo = 3, GhazalNo = 431, Mesra1 = "لبش می‌بوسد و خون می‌خورد جام", Mesra2 = "رخش می‌بيند و گل می‌کند خوی",},
new Hafez{ Id= 3611, BeytNo = 4, GhazalNo = 431, Mesra1 = "بده جام می و از جم مکن ياد", Mesra2 = "که می‌داند که جم کی بود و کی کی",},
new Hafez{ Id= 3612, BeytNo = 5, GhazalNo = 431, Mesra1 = "بزن در پرده چنگ ای ماه مطرب", Mesra2 = "رگش بخراش تا بخروشم از وی",},
new Hafez{ Id= 3613, BeytNo = 6, GhazalNo = 431, Mesra1 = "گل از خلوت به باغ آورد مسند", Mesra2 = "بساط زهد همچون غنچه کن طی",},
new Hafez{ Id= 3614, BeytNo = 7, GhazalNo = 431, Mesra1 = "چو چشمش مست را مخمور مگذار", Mesra2 = "به ياد لعلش ای ساقی بده می",},
new Hafez{ Id= 3615, BeytNo = 8, GhazalNo = 431, Mesra1 = "نجويد جان از آن قالب جدايی", Mesra2 = "که باشد خون جامش در رگ و پی",},
new Hafez{ Id= 3616, BeytNo = 9, GhazalNo = 431, Mesra1 = "زبانت درکش ای حافظ زمانی", Mesra2 = "حديث بی زبانان بشنو از نی",},
new Hafez{ Id= 3617, BeytNo = 1, GhazalNo = 432, Mesra1 = "مخمور جام عشقم ساقی بده شرابی", Mesra2 = "پر کن قدح که بی می مجلس ندارد آبی",},
new Hafez{ Id= 3618, BeytNo = 2, GhazalNo = 432, Mesra1 = "وصف رخ چو ماهش در پرده راست نايد", Mesra2 = "مطرب بزن نوايی ساقی بده شرابی",},
new Hafez{ Id= 3619, BeytNo = 3, GhazalNo = 432, Mesra1 = "شد حلقه قامت من تا بعد از اين رقيبت", Mesra2 = "زين در دگر نراند ما را به هيچ بابی",},
new Hafez{ Id= 3620, BeytNo = 4, GhazalNo = 432, Mesra1 = "در انتظار رويت ما و اميدواری", Mesra2 = "در عشوه وصالت ما و خيال و خوابی",},
new Hafez{ Id= 3621, BeytNo = 5, GhazalNo = 432, Mesra1 = "مخمور آن دو چشمم آيا کجاست جامی", Mesra2 = "بيمار آن دو لعلم آخر کم از جوابی",},
new Hafez{ Id= 3622, BeytNo = 6, GhazalNo = 432, Mesra1 = "حافظ چه می‌نهی دل تو در خيال خوبان", Mesra2 = "کی تشنه سير گردد از لمعه سرابی",},
new Hafez{ Id= 3623, BeytNo = 1, GhazalNo = 433, Mesra1 = "ای که بر ماه از خط مشکين نقاب انداختی", Mesra2 = "لطف کردی سايه‌ای بر آفتاب انداختی",},
new Hafez{ Id= 3624, BeytNo = 2, GhazalNo = 433, Mesra1 = "تا چه خواهد کرد با ما آب و رنگ عارضت", Mesra2 = "حاليا نيرنگ نقشی خوش بر آب انداختی",},
new Hafez{ Id= 3625, BeytNo = 3, GhazalNo = 433, Mesra1 = "گوی خوبی بردی از خوبان خلخ شاد باش", Mesra2 = "جام کيخسرو طلب کافراسياب انداختی",},
new Hafez{ Id= 3626, BeytNo = 4, GhazalNo = 433, Mesra1 = "هر کسی با شمع رخسارت به وجهی عشق باخت", Mesra2 = "زان ميان پروانه را در اضطراب انداختی",},
new Hafez{ Id= 3627, BeytNo = 5, GhazalNo = 433, Mesra1 = "گنج عشق خود نهادی در دل ويران ما", Mesra2 = "سايه دولت بر اين کنج خراب انداختی",},
new Hafez{ Id= 3628, BeytNo = 6, GhazalNo = 433, Mesra1 = "زينهار از آب آن عارض که شيران را از آن", Mesra2 = "تشنه لب کردی و گردان را در آب انداختی",},
new Hafez{ Id= 3629, BeytNo = 7, GhazalNo = 433, Mesra1 = "خواب بيداران ببستی وان گه از نقش خيال", Mesra2 = "تهمتی بر شب روان خيل خواب انداختی",},
new Hafez{ Id= 3630, BeytNo = 8, GhazalNo = 433, Mesra1 = "پرده از رخ برفکندی يک نظر در جلوه گاه", Mesra2 = "و از حيا حور و پری را در حجاب انداختی",},
new Hafez{ Id= 3631, BeytNo = 9, GhazalNo = 433, Mesra1 = "باده نوش از جام عالم بين که بر اورنگ جم", Mesra2 = "شاهد مقصود را از رخ نقاب انداختی",},
new Hafez{ Id= 3632, BeytNo = 10, GhazalNo = 433, Mesra1 = "از فريب نرگس مخمور و لعل می پرست", Mesra2 = "حافظ خلوت نشين را در شراب انداختی",},
new Hafez{ Id= 3633, BeytNo = 11, GhazalNo = 433, Mesra1 = "و از برای صيد دل در گردنم زنجير زلف", Mesra2 = "چون کمند خسرو مالک رقاب انداختی",},
new Hafez{ Id= 3634, BeytNo = 12, GhazalNo = 433, Mesra1 = "داور دارا شکوه‌ای آن که تاج آفتاب", Mesra2 = "از سر تعظيم بر خاک جناب انداختی",},
new Hafez{ Id= 3635, BeytNo = 13, GhazalNo = 433, Mesra1 = "نصره الدين شاه يحيی آن که خصم ملک را", Mesra2 = "از دم شمشير چون آتش در آب انداختی",},
new Hafez{ Id= 3636, BeytNo = 1, GhazalNo = 434, Mesra1 = "ای دل مباش يک دم خالی ز عشق و مستی", Mesra2 = "وان گه برو که رستی از نيستی و هستی",},
new Hafez{ Id= 3637, BeytNo = 2, GhazalNo = 434, Mesra1 = "گر جان به تن ببينی مشغول کار او شو", Mesra2 = "هر قبله‌ای که بينی بهتر ز خودپرستی",},
new Hafez{ Id= 3638, BeytNo = 3, GhazalNo = 434, Mesra1 = "با ضعف و ناتوانی همچون نسيم خوش باش", Mesra2 = "بيماری اندر اين ره بهتر ز تندرستی",},
new Hafez{ Id= 3639, BeytNo = 4, GhazalNo = 434, Mesra1 = "در مذهب طريقت خامی نشان کفر است", Mesra2 = "آری طريق دولت چالاکی است و چستی",},
new Hafez{ Id= 3640, BeytNo = 5, GhazalNo = 434, Mesra1 = "تا فضل و عقل بينی بی‌معرفت نشينی", Mesra2 = "يک نکته‌ات بگويم خود را مبين که رستی",},
new Hafez{ Id= 3641, BeytNo = 6, GhazalNo = 434, Mesra1 = "در آستان جانان از آسمان مينديش", Mesra2 = "کز اوج سربلندی افتی به خاک پستی",},
new Hafez{ Id= 3642, BeytNo = 7, GhazalNo = 434, Mesra1 = "خار ار چه جان بکاهد گل عذر آن بخواهد", Mesra2 = "سهل است تلخی می در جنب ذوق مستی",},
new Hafez{ Id= 3643, BeytNo = 8, GhazalNo = 434, Mesra1 = "صوفی پياله پيما حافظ قرابه پرهيز", Mesra2 = "ای کوته آستينان تا کی درازدستی",},
new Hafez{ Id= 3644, BeytNo = 1, GhazalNo = 435, Mesra1 = "با مدعی مگوييد اسرار عشق و مستی", Mesra2 = "تا بی‌خبر بميرد در درد خودپرستی",},
new Hafez{ Id= 3645, BeytNo = 2, GhazalNo = 435, Mesra1 = "عاشق شو ار نه روزی کار جهان سر آيد", Mesra2 = "ناخوانده نقش مقصود از کارگاه هستی",},
new Hafez{ Id= 3646, BeytNo = 3, GhazalNo = 435, Mesra1 = "دوش آن صنم چه خوش گفت در مجلس مغانم", Mesra2 = "با کافران چه کارت گر بت نمی‌پرستی",},
new Hafez{ Id= 3647, BeytNo = 4, GhazalNo = 435, Mesra1 = "سلطان من خدا را زلفت شکست ما را", Mesra2 = "تا کی کند سياهی چندين درازدستی",},
new Hafez{ Id= 3648, BeytNo = 5, GhazalNo = 435, Mesra1 = "در گوشه سلامت مستور چون توان بود", Mesra2 = "تا نرگس تو با ما گويد رموز مستی",},
new Hafez{ Id= 3649, BeytNo = 6, GhazalNo = 435, Mesra1 = "آن روز ديده بودم اين فتنه‌ها که برخاست", Mesra2 = "کز سرکشی زمانی با ما نمی‌نشستی",},
new Hafez{ Id= 3650, BeytNo = 7, GhazalNo = 435, Mesra1 = "عشقت به دست طوفان خواهد سپرد حافظ", Mesra2 = "چون برق از اين کشاکش پنداشتی که جستی",},
new Hafez{ Id= 3651, BeytNo = 1, GhazalNo = 436, Mesra1 = "آن غاليه خط گر سوی ما نامه نوشتی", Mesra2 = "گردون ورق هستی ما درننوشتی",},
new Hafez{ Id= 3652, BeytNo = 2, GhazalNo = 436, Mesra1 = "هر چند که هجران ثمر وصل برآرد", Mesra2 = "دهقان جهان کاش که اين تخم نکشتی",},
new Hafez{ Id= 3653, BeytNo = 3, GhazalNo = 436, Mesra1 = "آمرزش نقد است کسی را که در اين جا", Mesra2 = "ياريست چو حوری و سرايی چو بهشتی",},
new Hafez{ Id= 3654, BeytNo = 4, GhazalNo = 436, Mesra1 = "در مصطبه عشق تنعم نتوان کرد", Mesra2 = "چون بالش زر نيست بسازيم به خشتی",},
new Hafez{ Id= 3655, BeytNo = 5, GhazalNo = 436, Mesra1 = "مفروش به باغ ارم و نخوت شداد", Mesra2 = "يک شيشه می و نوش لبی و لب کشتی",},
new Hafez{ Id= 3656, BeytNo = 6, GhazalNo = 436, Mesra1 = "تا کی غم دنيای دنی ای دل دانا", Mesra2 = "حيف است ز خوبی که شود عاشق زشتی",},
new Hafez{ Id= 3657, BeytNo = 7, GhazalNo = 436, Mesra1 = "آلودگی خرقه خرابی جهان است", Mesra2 = "کو راهروی اهل دلی پاک سرشتی",},
new Hafez{ Id= 3658, BeytNo = 8, GhazalNo = 436, Mesra1 = "از دست چرا هشت سر زلف تو حافظ", Mesra2 = "تقدير چنين بود چه کردی که نهشتی",},
new Hafez{ Id= 3659, BeytNo = 1, GhazalNo = 437, Mesra1 = "ای قصه بهشت ز کويت حکايتی", Mesra2 = "شرح جمال حور ز رويت روايتی",},
new Hafez{ Id= 3660, BeytNo = 2, GhazalNo = 437, Mesra1 = "انفاس عيسی از لب لعلت لطيفه‌ای", Mesra2 = "آب خضر ز نوش لبانت کنايتی",},
new Hafez{ Id= 3661, BeytNo = 3, GhazalNo = 437, Mesra1 = "هر پاره از دل من و از غصه قصه‌ای", Mesra2 = "هر سطری از خصال تو و از رحمت آيتی",},
new Hafez{ Id= 3662, BeytNo = 4, GhazalNo = 437, Mesra1 = "کی عطرسای مجلس روحانيان شدی", Mesra2 = "گل را اگر نه بوی تو کردی رعايتی",},
new Hafez{ Id= 3663, BeytNo = 5, GhazalNo = 437, Mesra1 = "در آرزوی خاک در يار سوختيم", Mesra2 = "ياد آور ای صبا که نکردی حمايتی",},
new Hafez{ Id= 3664, BeytNo = 6, GhazalNo = 437, Mesra1 = "ای دل به هرزه دانش و عمرت به باد رفت", Mesra2 = "صد مايه داشتی و نکردی کفايتی",},
new Hafez{ Id= 3665, BeytNo = 7, GhazalNo = 437, Mesra1 = "بوی دل کباب من آفاق را گرفت", Mesra2 = "اين آتش درون بکند هم سرايتی",},
new Hafez{ Id= 3666, BeytNo = 8, GhazalNo = 437, Mesra1 = "در آتش ار خيال رخش دست می‌دهد", Mesra2 = "ساقی بيا که نيست ز دوزخ شکايتی",},
new Hafez{ Id= 3667, BeytNo = 9, GhazalNo = 437, Mesra1 = "دانی مراد حافظ از اين درد و غصه چيست", Mesra2 = "از تو کرشمه‌ای و ز خسرو عنايتی",},
new Hafez{ Id= 3668, BeytNo = 1, GhazalNo = 438, Mesra1 = "سبت سلمی بصدغيها فادی", Mesra2 = "و روحی کل يوم لی ينادی",},
new Hafez{ Id= 3669, BeytNo = 2, GhazalNo = 438, Mesra1 = "نگارا بر من بی‌دل ببخشای", Mesra2 = "و واصلنی علی رغم الاعادی",},
new Hafez{ Id= 3670, BeytNo = 3, GhazalNo = 438, Mesra1 = "حبيبا در غم سودای عشقت", Mesra2 = "توکلنا علی رب العباد",},
new Hafez{ Id= 3671, BeytNo = 4, GhazalNo = 438, Mesra1 = "امن انکرتنی عن عشق سلمی", Mesra2 = "تزاول آن روی نهکو بوادی",},
new Hafez{ Id= 3672, BeytNo = 5, GhazalNo = 438, Mesra1 = "که همچون مت به بوتن دل و ای ره", Mesra2 = "غريق العشق فی بحر الوداد",},
new Hafez{ Id= 3673, BeytNo = 6, GhazalNo = 438, Mesra1 = "به پی ماچان غرامت بسپريمن", Mesra2 = "غرت يک وی روشتی از امادی",},
new Hafez{ Id= 3674, BeytNo = 7, GhazalNo = 438, Mesra1 = "غم اين دل بواتت خورد ناچار", Mesra2 = "و غر نه او بنی آنچت نشادی",},
new Hafez{ Id= 3675, BeytNo = 8, GhazalNo = 438, Mesra1 = "دل حافظ شد اندر چين زلفت", Mesra2 = "بليل مظلم و الله هادی",},
new Hafez{ Id= 3676, BeytNo = 1, GhazalNo = 439, Mesra1 = "ديدم به خواب دوش که ماهی برآمدی", Mesra2 = "کز عکس روی او شب هجران سر آمدی",},
new Hafez{ Id= 3677, BeytNo = 2, GhazalNo = 439, Mesra1 = "تعبير رفت يار سفرکرده می‌رسد", Mesra2 = "ای کاج هر چه زودتر از در درآمدی",},
new Hafez{ Id= 3678, BeytNo = 3, GhazalNo = 439, Mesra1 = "ذکرش به خير ساقی فرخنده فال من", Mesra2 = "کز در مدام با قدح و ساغر آمدی",},
new Hafez{ Id= 3679, BeytNo = 4, GhazalNo = 439, Mesra1 = "خوش بودی ار به خواب بديدی ديار خويش", Mesra2 = "تا ياد صحبتش سوی ما رهبر آمدی",},
new Hafez{ Id= 3680, BeytNo = 5, GhazalNo = 439, Mesra1 = "فيض ازل به زور و زر ار آمدی به دست", Mesra2 = "آب خضر نصيبه اسکندر آمدی",},
new Hafez{ Id= 3681, BeytNo = 6, GhazalNo = 439, Mesra1 = "آن عهد ياد باد که از بام و در مرا", Mesra2 = "هر دم پيام يار و خط دلبر آمدی",},
new Hafez{ Id= 3682, BeytNo = 7, GhazalNo = 439, Mesra1 = "کی يافتی رقيب تو چندين مجال ظلم", Mesra2 = "مظلومی ار شبی به در داور آمدی",},
new Hafez{ Id= 3683, BeytNo = 8, GhazalNo = 439, Mesra1 = "خامان ره نرفته چه دانند ذوق عشق", Mesra2 = "دريادلی بجوی دليری سرآمدی",},
new Hafez{ Id= 3684, BeytNo = 9, GhazalNo = 439, Mesra1 = "آن کو تو را به سنگ دلی کرد رهنمون", Mesra2 = "ای کاشکی که پاش به سنگی برآمدی",},
new Hafez{ Id= 3685, BeytNo = 10, GhazalNo = 439, Mesra1 = "گر ديگری به شيوه حافظ زدی رقم", Mesra2 = "مقبول طبع شاه هنرپرور آمدی",},
new Hafez{ Id= 3686, BeytNo = 1, GhazalNo = 440, Mesra1 = "سحر با باد می‌گفتم حديث آرزومندی", Mesra2 = "خطاب آمد که واثق شو به الطاف خداوندی",},
new Hafez{ Id= 3687, BeytNo = 2, GhazalNo = 440, Mesra1 = "دعای صبح و آه شب کليد گنج مقصود است", Mesra2 = "بدين راه و روش می‌رو که با دلدار پيوندی",},
new Hafez{ Id= 3688, BeytNo = 3, GhazalNo = 440, Mesra1 = "قلم را آن زبان نبود که سر عشق گويد باز", Mesra2 = "ورای حد تقرير است شرح آرزومندی",},
new Hafez{ Id= 3689, BeytNo = 4, GhazalNo = 440, Mesra1 = "الا ای يوسف مصری که کردت سلطنت مغرور", Mesra2 = "پدر را بازپرس آخر کجا شد مهر فرزندی",},
new Hafez{ Id= 3690, BeytNo = 5, GhazalNo = 440, Mesra1 = "جهان پير رعنا را ترحم در جبلت نيست", Mesra2 = "ز مهر او چه می‌پرسی در او همت چه می‌بندی",},
new Hafez{ Id= 3691, BeytNo = 6, GhazalNo = 440, Mesra1 = "همايی چون تو عالی قدر حرص استخوان تا کی", Mesra2 = "دريغ آن سايه همت که بر نااهل افکندی",},
new Hafez{ Id= 3692, BeytNo = 7, GhazalNo = 440, Mesra1 = "در اين بازار اگر سوديست با درويش خرسند است", Mesra2 = "خدايا منعمم گردان به درويشی و خرسندی",},
new Hafez{ Id= 3693, BeytNo = 8, GhazalNo = 440, Mesra1 = "به شعر حافظ شيراز می‌رقصند و می‌نازند", Mesra2 = "سيه چشمان کشميری و ترکان سمرقندی",},
new Hafez{ Id= 3694, BeytNo = 1, GhazalNo = 441, Mesra1 = "چه بودی ار دل آن ماه مهربان بودی", Mesra2 = "که حال ما نه چنين بودی ار چنان بودی",},
new Hafez{ Id= 3695, BeytNo = 2, GhazalNo = 441, Mesra1 = "بگفتمی که چه ارزد نسيم طره دوست", Mesra2 = "گرم به هر سر مويی هزار جان بودی",},
new Hafez{ Id= 3696, BeytNo = 3, GhazalNo = 441, Mesra1 = "برات خوشدلی ما چه کم شدی يا رب", Mesra2 = "گرش نشان امان از بد زمان بودی",},
new Hafez{ Id= 3697, BeytNo = 4, GhazalNo = 441, Mesra1 = "گرم زمانه سرافراز داشتی و عزيز", Mesra2 = "سرير عزتم آن خاک آستان بودی",},
new Hafez{ Id= 3698, BeytNo = 5, GhazalNo = 441, Mesra1 = "ز پرده کاش برون آمدی چو قطره اشک", Mesra2 = "که بر دو ديده ما حکم او روان بودی",},
new Hafez{ Id= 3699, BeytNo = 6, GhazalNo = 441, Mesra1 = "اگر نه دايره عشق راه بربستی", Mesra2 = "چو نقطه حافظ سرگشته در ميان بودی",},
new Hafez{ Id= 3700, BeytNo = 1, GhazalNo = 442, Mesra1 = "به جان او که گرم دسترس به جان بودی", Mesra2 = "کمينه پيشکش بندگانش آن بودی",},
new Hafez{ Id= 3701, BeytNo = 2, GhazalNo = 442, Mesra1 = "بگفتمی که بها چيست خاک پايش را", Mesra2 = "اگر حيات گران مايه جاودان بودی",},
new Hafez{ Id= 3702, BeytNo = 3, GhazalNo = 442, Mesra1 = "به بندگی قدش سرو معترف گشتی", Mesra2 = "گرش چو سوسن آزاده ده زبان بودی",},
new Hafez{ Id= 3703, BeytNo = 4, GhazalNo = 442, Mesra1 = "به خواب نيز نمی‌بينمش چه جای وصال", Mesra2 = "چو اين نبود و نديديم باری آن بودی",},
new Hafez{ Id= 3704, BeytNo = 5, GhazalNo = 442, Mesra1 = "اگر دلم نشدی پايبند طره او", Mesra2 = "کی اش قرار در اين تيره خاکدان بودی",},
new Hafez{ Id= 3705, BeytNo = 6, GhazalNo = 442, Mesra1 = "به رخ چو مهر فلک بی‌نظير آفاق است", Mesra2 = "به دل دريغ که يک ذره مهربان بودی",},
new Hafez{ Id= 3706, BeytNo = 7, GhazalNo = 442, Mesra1 = "درآمدی ز درم کاشکی چو لمعه نور", Mesra2 = "که بر دو ديده ما حکم او روان بودی",},
new Hafez{ Id= 3707, BeytNo = 8, GhazalNo = 442, Mesra1 = "ز پرده ناله حافظ برون کی افتادی", Mesra2 = "اگر نه همدم مرغان صبح خوان بودی",},
new Hafez{ Id= 3708, BeytNo = 1, GhazalNo = 443, Mesra1 = "چو سرو اگر بخرامی دمی به گلزاری", Mesra2 = "خورد ز غيرت روی تو هر گلی خاری",},
new Hafez{ Id= 3709, BeytNo = 2, GhazalNo = 443, Mesra1 = "ز کفر زلف تو هر حلقه‌ای و آشوبی", Mesra2 = "ز سحر چشم تو هر گوشه‌ای و بيماری",},
new Hafez{ Id= 3710, BeytNo = 3, GhazalNo = 443, Mesra1 = "مرو چو بخت من ای چشم مست يار به خواب", Mesra2 = "که در پی است ز هر سويت آه بيداری",},
new Hafez{ Id= 3711, BeytNo = 4, GhazalNo = 443, Mesra1 = "نثار خاک رهت نقد جان من هر چند", Mesra2 = "که نيست نقد روان را بر تو مقداری",},
new Hafez{ Id= 3712, BeytNo = 5, GhazalNo = 443, Mesra1 = "دلا هميشه مزن لاف زلف دلبندان", Mesra2 = "چو تيره رای شوی کی گشايدت کاری",},
new Hafez{ Id= 3713, BeytNo = 6, GhazalNo = 443, Mesra1 = "سرم برفت و زمانی به سر نرفت اين کار", Mesra2 = "دلم گرفت و نبودت غم گرفتاری",},
new Hafez{ Id= 3714, BeytNo = 7, GhazalNo = 443, Mesra1 = "چو نقطه گفتمش اندر ميان دايره آی", Mesra2 = "به خنده گفت که ای حافظ اين چه پرگاری",},
new Hafez{ Id= 3715, BeytNo = 1, GhazalNo = 444, Mesra1 = "شهريست پرظريفان و از هر طرف نگاری", Mesra2 = "ياران صلای عشق است گر می‌کنيد کاری",},
new Hafez{ Id= 3716, BeytNo = 2, GhazalNo = 444, Mesra1 = "چشم فلک نبيند زين طرفه‌تر جوانی", Mesra2 = "در دست کس نيفتد زين خوبتر نگاری",},
new Hafez{ Id= 3717, BeytNo = 3, GhazalNo = 444, Mesra1 = "هرگز که ديده باشد جسمی ز جان مرکب", Mesra2 = "بر دامنش مبادا زين خاکيان غباری",},
new Hafez{ Id= 3718, BeytNo = 4, GhazalNo = 444, Mesra1 = "چون من شکسته‌ای را از پيش خود چه رانی", Mesra2 = "کم غايت توقع بوسيست يا کناری",},
new Hafez{ Id= 3719, BeytNo = 5, GhazalNo = 444, Mesra1 = "می بی‌غش است درياب وقتی خوش است بشتاب", Mesra2 = "سال دگر که دارد اميد نوبهاری",},
new Hafez{ Id= 3720, BeytNo = 6, GhazalNo = 444, Mesra1 = "در بوستان حريفان مانند لاله و گل", Mesra2 = "هر يک گرفته جامی بر ياد روی ياری",},
new Hafez{ Id= 3721, BeytNo = 7, GhazalNo = 444, Mesra1 = "چون اين گره گشايم وين راز چون نمايم", Mesra2 = "دردی و سخت دردی کاری و صعب کاری",},
new Hafez{ Id= 3722, BeytNo = 8, GhazalNo = 444, Mesra1 = "هر تار موی حافظ در دست زلف شوخی", Mesra2 = "مشکل توان نشستن در اين چنين دياری",},
new Hafez{ Id= 3723, BeytNo = 1, GhazalNo = 445, Mesra1 = "تو را که هر چه مراد است در جهان داری", Mesra2 = "چه غم ز حال ضعيفان ناتوان داری",},
new Hafez{ Id= 3724, BeytNo = 2, GhazalNo = 445, Mesra1 = "بخواه جان و دل از بنده و روان بستان", Mesra2 = "که حکم بر سر آزادگان روان داری",},
new Hafez{ Id= 3725, BeytNo = 3, GhazalNo = 445, Mesra1 = "ميان نداری و دارم عجب که هر ساعت", Mesra2 = "ميان مجمع خوبان کنی ميانداری",},
new Hafez{ Id= 3726, BeytNo = 4, GhazalNo = 445, Mesra1 = "بياض روی تو را نيست نقش درخور از آنک", Mesra2 = "سوادی از خط مشکين بر ارغوان داری",},
new Hafez{ Id= 3727, BeytNo = 5, GhazalNo = 445, Mesra1 = "بنوش می که سبکروحی و لطيف مدام", Mesra2 = "علی الخصوص در آن دم که سر گران داری",},
new Hafez{ Id= 3728, BeytNo = 6, GhazalNo = 445, Mesra1 = "مکن عتاب از اين بيش و جور بر دل ما", Mesra2 = "مکن هر آن چه توانی که جای آن داری",},
new Hafez{ Id= 3729, BeytNo = 7, GhazalNo = 445, Mesra1 = "به اختيارت اگر صد هزار تير جفاست", Mesra2 = "به قصد جان من خسته در کمان داری",},
new Hafez{ Id= 3730, BeytNo = 8, GhazalNo = 445, Mesra1 = "بکش جفای رقيبان مدام و جور حسود", Mesra2 = "که سهل باشد اگر يار مهربان داری",},
new Hafez{ Id= 3731, BeytNo = 9, GhazalNo = 445, Mesra1 = "به وصل دوست گرت دست می‌دهد يک دم", Mesra2 = "برو که هر چه مراد است در جهان داری",},
new Hafez{ Id= 3732, BeytNo = 10, GhazalNo = 445, Mesra1 = "چو گل به دامن از اين باغ می‌بری حافظ", Mesra2 = "چه غم ز ناله و فرياد باغبان داری",},
new Hafez{ Id= 3733, BeytNo = 1, GhazalNo = 446, Mesra1 = "صبا تو نکهت آن زلف مشک بو داری", Mesra2 = "به يادگار بمانی که بوی او داری",},
new Hafez{ Id= 3734, BeytNo = 2, GhazalNo = 446, Mesra1 = "دلم که گوهر اسرار حسن و عشق در اوست", Mesra2 = "توان به دست تو دادن گرش نکو داری",},
new Hafez{ Id= 3735, BeytNo = 3, GhazalNo = 446, Mesra1 = "در آن شمايل مطبوع هيچ نتوان گفت", Mesra2 = "جز اين قدر که رقيبان تندخو داری",},
new Hafez{ Id= 3736, BeytNo = 4, GhazalNo = 446, Mesra1 = "نوای بلبلت ای گل کجا پسند افتد", Mesra2 = "که گوش و هوش به مرغان هرزه گو داری",},
new Hafez{ Id= 3737, BeytNo = 5, GhazalNo = 446, Mesra1 = "به جرعه تو سرم مست گشت نوشت باد", Mesra2 = "خود از کدام خم است اين که در سبو داری",},
new Hafez{ Id= 3738, BeytNo = 6, GhazalNo = 446, Mesra1 = "به سرکشی خود ای سرو جويبار مناز", Mesra2 = "که گر بدو رسی از شرم سر فروداری",},
new Hafez{ Id= 3739, BeytNo = 7, GhazalNo = 446, Mesra1 = "دم از ممالک خوبی چو آفتاب زدن", Mesra2 = "تو را رسد که غلامان ماه رو داری",},
new Hafez{ Id= 3740, BeytNo = 8, GhazalNo = 446, Mesra1 = "قبای حسن فروشی تو را برازد و بس", Mesra2 = "که همچو گل همه آيين رنگ و بو داری",},
new Hafez{ Id= 3741, BeytNo = 9, GhazalNo = 446, Mesra1 = "ز کنج صومعه حافظ مجوی گوهر عشق", Mesra2 = "قدم برون نه اگر ميل جست و جو داری",},
new Hafez{ Id= 3742, BeytNo = 1, GhazalNo = 447, Mesra1 = "بيا با ما مورز اين کينه داری", Mesra2 = "که حق صحبت ديرينه داری",},
new Hafez{ Id= 3743, BeytNo = 2, GhazalNo = 447, Mesra1 = "نصيحت گوش کن کاين در بسی به", Mesra2 = "از آن گوهر که در گنجينه داری",},
new Hafez{ Id= 3744, BeytNo = 3, GhazalNo = 447, Mesra1 = "وليکن کی نمايی رخ به رندان", Mesra2 = "تو کز خورشيد و مه آيينه داری",},
new Hafez{ Id= 3745, BeytNo = 4, GhazalNo = 447, Mesra1 = "بد رندان مگو ای شيخ و هش دار", Mesra2 = "که با حکم خدايی کينه داری",},
new Hafez{ Id= 3746, BeytNo = 5, GhazalNo = 447, Mesra1 = "نمی‌ترسی ز آه آتشينم", Mesra2 = "تو دانی خرقه پشمينه داری",},
new Hafez{ Id= 3747, BeytNo = 6, GhazalNo = 447, Mesra1 = "به فرياد خمار مفلسان رس", Mesra2 = "خدا را گر می‌دوشينه داری",},
new Hafez{ Id= 3748, BeytNo = 7, GhazalNo = 447, Mesra1 = "نديدم خوشتر از شعر تو حافظ", Mesra2 = "به قرآنی که اندر سينه داری",},
new Hafez{ Id= 3749, BeytNo = 1, GhazalNo = 448, Mesra1 = "ای که در کوی خرابات مقامی داری", Mesra2 = "جم وقت خودی ار دست به جامی داری",},
new Hafez{ Id= 3750, BeytNo = 2, GhazalNo = 448, Mesra1 = "ای که با زلف و رخ يار گذاری شب و روز", Mesra2 = "فرصتت باد که خوش صبحی و شامی داری",},
new Hafez{ Id= 3751, BeytNo = 3, GhazalNo = 448, Mesra1 = "ای صبا سوختگان بر سر ره منتظرند", Mesra2 = "گر از آن يار سفرکرده پيامی داری",},
new Hafez{ Id= 3752, BeytNo = 4, GhazalNo = 448, Mesra1 = "خال سرسبز تو خوش دانه عيشيست ولی", Mesra2 = "بر کنار چمنش وه که چه دامی داری",},
new Hafez{ Id= 3753, BeytNo = 5, GhazalNo = 448, Mesra1 = "بوی جان از لب خندان قدح می‌شنوم", Mesra2 = "بشنو ای خواجه اگر زان که مشامی داری",},
new Hafez{ Id= 3754, BeytNo = 6, GhazalNo = 448, Mesra1 = "چون به هنگام وفا هيچ ثباتيت نبود", Mesra2 = "می‌کنم شکر که بر جور دوامی داری",},
new Hafez{ Id= 3755, BeytNo = 7, GhazalNo = 448, Mesra1 = "نام نيک ار طلبد از تو غريبی چه شود", Mesra2 = "تويی امروز در اين شهر که نامی داری",},
new Hafez{ Id= 3756, BeytNo = 8, GhazalNo = 448, Mesra1 = "بس دعای سحرت مونس جان خواهد بود", Mesra2 = "تو که چون حافظ شبخيز غلامی داری",},
new Hafez{ Id= 3757, BeytNo = 1, GhazalNo = 449, Mesra1 = "ای که مهجوری عشاق روا می‌داری", Mesra2 = "عاشقان را ز بر خويش جدا می‌داری",},
new Hafez{ Id= 3758, BeytNo = 2, GhazalNo = 449, Mesra1 = "تشنه باديه را هم به زلالی درياب", Mesra2 = "به اميدی که در اين ره به خدا می‌داری",},
new Hafez{ Id= 3759, BeytNo = 3, GhazalNo = 449, Mesra1 = "دل ببردی و بحل کردمت ای جان ليکن", Mesra2 = "به از اين دار نگاهش که مرا می‌داری",},
new Hafez{ Id= 3760, BeytNo = 4, GhazalNo = 449, Mesra1 = "ساغر ما که حريفان دگر می‌نوشند", Mesra2 = "ما تحمل نکنيم ار تو روا می‌داری",},
new Hafez{ Id= 3761, BeytNo = 5, GhazalNo = 449, Mesra1 = "ای مگس حضرت سيمرغ نه جولانگه توست", Mesra2 = "عرض خود می‌بری و زحمت ما می‌داری",},
new Hafez{ Id= 3762, BeytNo = 6, GhazalNo = 449, Mesra1 = "تو به تقصير خود افتادی از اين در محروم", Mesra2 = "از که می‌نالی و فرياد چرا می‌داری",},
new Hafez{ Id= 3763, BeytNo = 7, GhazalNo = 449, Mesra1 = "حافظ از پادشهان پايه به خدمت طلبند", Mesra2 = "سعی نابرده چه اميد عطا می‌داری",},
new Hafez{ Id= 3764, BeytNo = 1, GhazalNo = 450, Mesra1 = "روزگاريست که ما را نگران می‌داری", Mesra2 = "مخلصان را نه به وضع دگران می‌داری",},
new Hafez{ Id= 3765, BeytNo = 2, GhazalNo = 450, Mesra1 = "گوشه چشم رضايی به منت باز نشد", Mesra2 = "اين چنين عزت صاحب نظران می‌داری",},
new Hafez{ Id= 3766, BeytNo = 3, GhazalNo = 450, Mesra1 = "ساعد آن به که بپوشی تو چو از بهر نگار", Mesra2 = "دست در خون دل پرهنران می‌داری",},
new Hafez{ Id= 3767, BeytNo = 4, GhazalNo = 450, Mesra1 = "نه گل از دست غمت رست و نه بلبل در باغ", Mesra2 = "همه را نعره زنان جامه دران می‌داری",},
new Hafez{ Id= 3768, BeytNo = 5, GhazalNo = 450, Mesra1 = "ای که در دلق ملمع طلبی نقد حضور", Mesra2 = "چشم سری عجب از بی‌خبران می‌داری",},
new Hafez{ Id= 3769, BeytNo = 6, GhazalNo = 450, Mesra1 = "چون تويی نرگس باغ نظر ای چشم و چراغ", Mesra2 = "سر چرا بر من دلخسته گران می‌داری",},
new Hafez{ Id= 3770, BeytNo = 7, GhazalNo = 450, Mesra1 = "گوهر جام جم از کان جهانی دگر است", Mesra2 = "تو تمنا ز گل کوزه گران می‌داری",},
new Hafez{ Id= 3771, BeytNo = 8, GhazalNo = 450, Mesra1 = "پدر تجربه ای دل تويی آخر ز چه روی", Mesra2 = "طمع مهر و وفا زين پسران می‌داری",},
new Hafez{ Id= 3772, BeytNo = 9, GhazalNo = 450, Mesra1 = "کيسه سيم و زرت پاک ببايد پرداخت", Mesra2 = "اين طمع‌ها که تو از سيمبران می‌داری",},
new Hafez{ Id= 3773, BeytNo = 10, GhazalNo = 450, Mesra1 = "گر چه رندی و خرابی گنه ماست ولی", Mesra2 = "عاشقی گفت که تو بنده بر آن می‌داری",},
new Hafez{ Id= 3774, BeytNo = 11, GhazalNo = 450, Mesra1 = "مگذران روز سلامت به ملامت حافظ", Mesra2 = "چه توقع ز جهان گذران می‌داری",},
new Hafez{ Id= 3775, BeytNo = 1, GhazalNo = 451, Mesra1 = "خوش کرد ياوری فلکت روز داوری", Mesra2 = "تا شکر چون کنی و چه شکرانه آوری",},
new Hafez{ Id= 3776, BeytNo = 2, GhazalNo = 451, Mesra1 = "آن کس که اوفتاد خدايش گرفت دست", Mesra2 = "گو بر تو باد تا غم افتادگان خوری",},
new Hafez{ Id= 3777, BeytNo = 3, GhazalNo = 451, Mesra1 = "در کوی عشق شوکت شاهی نمی‌خرند", Mesra2 = "اقرار بندگی کن و اظهار چاکری",},
new Hafez{ Id= 3778, BeytNo = 4, GhazalNo = 451, Mesra1 = "ساقی به مژدگانی عيش از درم درآی", Mesra2 = "تا يک دم از دلم غم دنيا به دربری",},
new Hafez{ Id= 3779, BeytNo = 5, GhazalNo = 451, Mesra1 = "در شاهراه جاه و بزرگی خطر بسيست", Mesra2 = "آن به کز اين گريوه سبکبار بگذری",},
new Hafez{ Id= 3780, BeytNo = 6, GhazalNo = 451, Mesra1 = "سلطان و فکر لشکر و سودای تاج و گنج", Mesra2 = "درويش و امن خاطر و کنج قلندری",},
new Hafez{ Id= 3781, BeytNo = 7, GhazalNo = 451, Mesra1 = "يک حرف صوفيانه بگويم اجازت است", Mesra2 = "ای نور ديده صلح به از جنگ و داوری",},
new Hafez{ Id= 3782, BeytNo = 8, GhazalNo = 451, Mesra1 = "نيل مراد بر حسب فکر و همت است", Mesra2 = "از شاه نذر خير و ز توفيق ياوری",},
new Hafez{ Id= 3783, BeytNo = 9, GhazalNo = 451, Mesra1 = "حافظ غبار فقر و قناعت ز رخ مشوی", Mesra2 = "کاين خاک بهتر از عمل کيمياگری",},
new Hafez{ Id= 3784, BeytNo = 1, GhazalNo = 452, Mesra1 = "طفيل هستی عشقند آدمی و پری", Mesra2 = "ارادتی بنما تا سعادتی ببری",},
new Hafez{ Id= 3785, BeytNo = 2, GhazalNo = 452, Mesra1 = "بکوش خواجه و از عشق بی‌نصيب مباش", Mesra2 = "که بنده را نخرد کس به عيب بی‌هنری",},
new Hafez{ Id= 3786, BeytNo = 3, GhazalNo = 452, Mesra1 = "می صبوح و شکرخواب صبحدم تا چند", Mesra2 = "به عذر نيم شبی کوش و گريه سحری",},
new Hafez{ Id= 3787, BeytNo = 4, GhazalNo = 452, Mesra1 = "تو خود چه لعبتی ای شهسوار شيرين کار", Mesra2 = "که در برابر چشمی و غايب از نظری",},
new Hafez{ Id= 3788, BeytNo = 5, GhazalNo = 452, Mesra1 = "هزار جان مقدس بسوخت زين غيرت", Mesra2 = "که هر صباح و مسا شمع مجلس دگری",},
new Hafez{ Id= 3789, BeytNo = 6, GhazalNo = 452, Mesra1 = "ز من به حضرت آصف که می‌برد پيغام", Mesra2 = "که ياد گير دو مصرع ز من به نظم دری",},
new Hafez{ Id= 3790, BeytNo = 7, GhazalNo = 452, Mesra1 = "بيا که وضع جهان را چنان که من ديدم", Mesra2 = "گر امتحان بکنی می خوری و غم نخوری",},
new Hafez{ Id= 3791, BeytNo = 8, GhazalNo = 452, Mesra1 = "کلاه سروريت کج مباد بر سر حسن", Mesra2 = "که زيب بخت و سزاوار ملک و تاج سری",},
new Hafez{ Id= 3792, BeytNo = 9, GhazalNo = 452, Mesra1 = "به بوی زلف و رخت می‌روند و می‌آيند", Mesra2 = "صبا به غاليه سايی و گل به جلوه گری",},
new Hafez{ Id= 3793, BeytNo = 10, GhazalNo = 452, Mesra1 = "چو مستعد نظر نيستی وصال مجوی", Mesra2 = "که جام جم نکند سود وقت بی‌بصری",},
new Hafez{ Id= 3794, BeytNo = 11, GhazalNo = 452, Mesra1 = "دعای گوشه نشينان بلا بگرداند", Mesra2 = "چرا به گوشه چشمی به ما نمی‌نگری",},
new Hafez{ Id= 3795, BeytNo = 12, GhazalNo = 452, Mesra1 = "بيا و سلطنت از ما بخر به مايه حسن", Mesra2 = "و از اين معامله غافل مشو که حيف خوری",},
new Hafez{ Id= 3796, BeytNo = 13, GhazalNo = 452, Mesra1 = "طريق عشق طريقی عجب خطرناک است", Mesra2 = "نعوذبالله اگر ره به مقصدی نبری",},
new Hafez{ Id= 3797, BeytNo = 14, GhazalNo = 452, Mesra1 = "به يمن همت حافظ اميد هست که باز", Mesra2 = "اری اسامر ليلای ليله القمر",},
new Hafez{ Id= 3798, BeytNo = 1, GhazalNo = 453, Mesra1 = "ای که دايم به خويش مغروری", Mesra2 = "گر تو را عشق نيست معذوری",},
new Hafez{ Id= 3799, BeytNo = 2, GhazalNo = 453, Mesra1 = "گرد ديوانگان عشق مگرد", Mesra2 = "که به عقل عقيله مشهوری",},
new Hafez{ Id= 3800, BeytNo = 3, GhazalNo = 453, Mesra1 = "مستی عشق نيست در سر تو", Mesra2 = "رو که تو مست آب انگوری",},
new Hafez{ Id= 3801, BeytNo = 4, GhazalNo = 453, Mesra1 = "روی زرد است و آه دردآلود", Mesra2 = "عاشقان را دوای رنجوری",},
new Hafez{ Id= 3802, BeytNo = 5, GhazalNo = 453, Mesra1 = "بگذر از نام و ننگ خود حافظ", Mesra2 = "ساغر می‌طلب که مخموری",},
new Hafez{ Id= 3803, BeytNo = 1, GhazalNo = 454, Mesra1 = "ز کوی يار می‌آيد نسيم باد نوروزی", Mesra2 = "از اين باد ار مدد خواهی چراغ دل برافروزی",},
new Hafez{ Id= 3804, BeytNo = 2, GhazalNo = 454, Mesra1 = "چو گل گر خرده‌ای داری خدا را صرف عشرت کن", Mesra2 = "که قارون را غلط‌ها داد سودای زراندوزی",},
new Hafez{ Id= 3805, BeytNo = 3, GhazalNo = 454, Mesra1 = "ز جام گل دگر بلبل چنان مست می لعل است", Mesra2 = "که زد بر چرخ فيروزه صفير تخت فيروزی",},
new Hafez{ Id= 3806, BeytNo = 4, GhazalNo = 454, Mesra1 = "به صحرا رو که از دامن غبار غم بيفشانی", Mesra2 = "به گلزار آی کز بلبل غزل گفتن بياموزی",},
new Hafez{ Id= 3807, BeytNo = 5, GhazalNo = 454, Mesra1 = "چو امکان خلود ای دل در اين فيروزه ايوان نيست", Mesra2 = "مجال عيش فرصت دان به فيروزی و بهروزی",},
new Hafez{ Id= 3808, BeytNo = 6, GhazalNo = 454, Mesra1 = "طريق کام بخشی چيست ترک کام خود کردن", Mesra2 = "کلاه سروری آن است کز اين ترک بردوزی",},
new Hafez{ Id= 3809, BeytNo = 7, GhazalNo = 454, Mesra1 = "سخن در پرده می‌گويم چو گل از غنچه بيرون آی", Mesra2 = "که بيش از پنج روزی نيست حکم مير نوروزی",},
new Hafez{ Id= 3810, BeytNo = 8, GhazalNo = 454, Mesra1 = "ندانم نوحه قمری به طرف جويباران چيست", Mesra2 = "مگر او نيز همچون من غمی دارد شبانروزی",},
new Hafez{ Id= 3811, BeytNo = 9, GhazalNo = 454, Mesra1 = "می‌ای دارم چو جان صافی و صوفی می‌کند عيبش", Mesra2 = "خدايا هيچ عاقل را مبادا بخت بد روزی",},
new Hafez{ Id= 3812, BeytNo = 10, GhazalNo = 454, Mesra1 = "جدا شد يار شيرينت کنون تنها نشين ای شمع", Mesra2 = "که حکم آسمان اين است اگر سازی و گر سوزی",},
new Hafez{ Id= 3813, BeytNo = 11, GhazalNo = 454, Mesra1 = "به عجب علم نتوان شد ز اسباب طرب محروم", Mesra2 = "بيا ساقی که جاهل را هنيتر می‌رسد روزی",},
new Hafez{ Id= 3814, BeytNo = 12, GhazalNo = 454, Mesra1 = "می اندر مجلس آصف به نوروز جلالی نوش", Mesra2 = "که بخشد جرعه جامت جهان را ساز نوروزی",},
new Hafez{ Id= 3815, BeytNo = 13, GhazalNo = 454, Mesra1 = "نه حافظ می‌کند تنها دعای خواجه تورانشاه", Mesra2 = "ز مدح آصفی خواهد جهان عيدی و نوروزی",},
new Hafez{ Id= 3816, BeytNo = 14, GhazalNo = 454, Mesra1 = "جنابش پارسايان راست محراب دل و ديده", Mesra2 = "جبينش صبح خيزان راست روز فتح و فيروزی",},
new Hafez{ Id= 3817, BeytNo = 1, GhazalNo = 455, Mesra1 = "عمر بگذشت به بی‌حاصلی و بوالهوسی", Mesra2 = "ای پسر جام می‌ام ده که به پيری برسی",},
new Hafez{ Id= 3818, BeytNo = 2, GhazalNo = 455, Mesra1 = "چه شکرهاست در اين شهر که قانع شده‌اند", Mesra2 = "شاهبازان طريقت به مقام مگسی",},
new Hafez{ Id= 3819, BeytNo = 3, GhazalNo = 455, Mesra1 = "دوش در خيل غلامان درش می‌رفتم", Mesra2 = "گفت ای عاشق بيچاره تو باری چه کسی",},
new Hafez{ Id= 3820, BeytNo = 4, GhazalNo = 455, Mesra1 = "با دل خون شده چون نافه خوشش بايد بود", Mesra2 = "هر که مشهور جهان گشت به مشکين نفسی",},
new Hafez{ Id= 3821, BeytNo = 5, GhazalNo = 455, Mesra1 = "لمع البرق من الطور و آنست به", Mesra2 = "فلعلی لک آت بشهاب قبس",},
new Hafez{ Id= 3822, BeytNo = 6, GhazalNo = 455, Mesra1 = "کاروان رفت و تو در خواب و بيابان در پيش", Mesra2 = "وه که بس بی‌خبر از غلغل چندين جرسی",},
new Hafez{ Id= 3823, BeytNo = 7, GhazalNo = 455, Mesra1 = "بال بگشا و صفير از شجر طوبی زن", Mesra2 = "حيف باشد چو تو مرغی که اسير قفسی",},
new Hafez{ Id= 3824, BeytNo = 8, GhazalNo = 455, Mesra1 = "تا چو مجمر نفسی دامن جانان گيرم", Mesra2 = "جان نهاديم بر آتش ز پی خوش نفسی",},
new Hafez{ Id= 3825, BeytNo = 9, GhazalNo = 455, Mesra1 = "چند پويد به هوای تو ز هر سو حافظ", Mesra2 = "يسر الله طريقا بک يا ملتمسی",},
new Hafez{ Id= 3826, BeytNo = 1, GhazalNo = 456, Mesra1 = "نوبهار است در آن کوش که خوشدل باشی", Mesra2 = "که بسی گل بدمد باز و تو در گل باشی",},
new Hafez{ Id= 3827, BeytNo = 2, GhazalNo = 456, Mesra1 = "من نگويم که کنون با که نشين و چه بنوش", Mesra2 = "که تو خود دانی اگر زيرک و عاقل باشی",},
new Hafez{ Id= 3828, BeytNo = 3, GhazalNo = 456, Mesra1 = "چنگ در پرده همين می‌دهدت پند ولی", Mesra2 = "وعظت آن گاه کند سود که قابل باشی",},
new Hafez{ Id= 3829, BeytNo = 4, GhazalNo = 456, Mesra1 = "در چمن هر ورقی دفتر حالی دگر است", Mesra2 = "حيف باشد که ز کار همه غافل باشی",},
new Hafez{ Id= 3830, BeytNo = 5, GhazalNo = 456, Mesra1 = "نقد عمرت ببرد غصه دنيا به گزاف", Mesra2 = "گر شب و روز در اين قصه مشکل باشی",},
new Hafez{ Id= 3831, BeytNo = 6, GhazalNo = 456, Mesra1 = "گر چه راهيست پر از بيم ز ما تا بر دوست", Mesra2 = "رفتن آسان بود ار واقف منزل باشی",},
new Hafez{ Id= 3832, BeytNo = 7, GhazalNo = 456, Mesra1 = "حافظا گر مدد از بخت بلندت باشد", Mesra2 = "صيد آن شاهد مطبوع شمايل باشی",},
new Hafez{ Id= 3833, BeytNo = 1, GhazalNo = 457, Mesra1 = "هزار جهد بکردم که يار من باشی", Mesra2 = "مرادبخش دل بی‌قرار من باشی",},
new Hafez{ Id= 3834, BeytNo = 2, GhazalNo = 457, Mesra1 = "چراغ ديده شب زنده دار من گردی", Mesra2 = "انيس خاطر اميدوار من باشی",},
new Hafez{ Id= 3835, BeytNo = 3, GhazalNo = 457, Mesra1 = "چو خسروان ملاحت به بندگان نازند", Mesra2 = "تو در ميانه خداوندگار من باشی",},
new Hafez{ Id= 3836, BeytNo = 4, GhazalNo = 457, Mesra1 = "از آن عقيق که خونين دلم ز عشوه او", Mesra2 = "اگر کنم گله‌ای غمگسار من باشی",},
new Hafez{ Id= 3837, BeytNo = 5, GhazalNo = 457, Mesra1 = "در آن چمن که بتان دست عاشقان گيرند", Mesra2 = "گرت ز دست برآيد نگار من باشی",},
new Hafez{ Id= 3838, BeytNo = 6, GhazalNo = 457, Mesra1 = "شبی به کلبه احزان عاشقان آيی", Mesra2 = "دمی انيس دل سوکوار من باشی",},
new Hafez{ Id= 3839, BeytNo = 7, GhazalNo = 457, Mesra1 = "شود غزاله خورشيد صيد لاغر من", Mesra2 = "گر آهويی چو تو يک دم شکار من باشی",},
new Hafez{ Id= 3840, BeytNo = 8, GhazalNo = 457, Mesra1 = "سه بوسه کز دو لبت کرده‌ای وظيفه من", Mesra2 = "اگر ادا نکنی قرض دار من باشی",},
new Hafez{ Id= 3841, BeytNo = 9, GhazalNo = 457, Mesra1 = "من اين مراد ببينم به خود که نيم شبی", Mesra2 = "به جای اشک روان در کنار من باشی",},
new Hafez{ Id= 3842, BeytNo = 10, GhazalNo = 457, Mesra1 = "من ار چه حافظ شهرم جوی نمی‌ارزم", Mesra2 = "مگر تو از کرم خويش يار من باشی",},
new Hafez{ Id= 3843, BeytNo = 1, GhazalNo = 458, Mesra1 = "ای دل آن دم که خراب از می گلگون باشی", Mesra2 = "بی زر و گنج به صد حشمت قارون باشی",},
new Hafez{ Id= 3844, BeytNo = 2, GhazalNo = 458, Mesra1 = "در مقامی که صدارت به فقيران بخشند", Mesra2 = "چشم دارم که به جاه از همه افزون باشی",},
new Hafez{ Id= 3845, BeytNo = 3, GhazalNo = 458, Mesra1 = "در ره منزل ليلی که خطرهاست در آن", Mesra2 = "شرط اول قدم آن است که مجنون باشی",},
new Hafez{ Id= 3846, BeytNo = 4, GhazalNo = 458, Mesra1 = "نقطه عشق نمودم به تو هان سهو مکن", Mesra2 = "ور نه چون بنگری از دايره بيرون باشی",},
new Hafez{ Id= 3847, BeytNo = 5, GhazalNo = 458, Mesra1 = "کاروان رفت و تو در خواب و بيابان در پيش", Mesra2 = "کی روی ره ز که پرسی چه کنی چون باشی",},
new Hafez{ Id= 3848, BeytNo = 6, GhazalNo = 458, Mesra1 = "تاج شاهی طلبی گوهر ذاتی بنمای", Mesra2 = "ور خود از تخمه جمشيد و فريدون باشی",},
new Hafez{ Id= 3849, BeytNo = 7, GhazalNo = 458, Mesra1 = "ساغری نوش کن و جرعه بر افلاک فشان", Mesra2 = "چند و چند از غم ايام جگرخون باشی",},
new Hafez{ Id= 3850, BeytNo = 8, GhazalNo = 458, Mesra1 = "حافظ از فقر مکن ناله که گر شعر اين است", Mesra2 = "هيچ خوشدل نپسندد که تو محزون باشی",},
new Hafez{ Id= 3851, BeytNo = 1, GhazalNo = 459, Mesra1 = "زين خوش رقم که بر گل رخسار می‌کشی", Mesra2 = "خط بر صحيفه گل و گلزار می‌کشی",},
new Hafez{ Id= 3852, BeytNo = 2, GhazalNo = 459, Mesra1 = "اشک حرم نشين نهانخانه مرا", Mesra2 = "زان سوی هفت پرده به بازار می‌کشی",},
new Hafez{ Id= 3853, BeytNo = 3, GhazalNo = 459, Mesra1 = "کاهل روی چو باد صبا را به بوی زلف", Mesra2 = "هر دم به قيد سلسله در کار می‌کشی",},
new Hafez{ Id= 3854, BeytNo = 4, GhazalNo = 459, Mesra1 = "هر دم به ياد آن لب ميگون و چشم مست", Mesra2 = "از خلوتم به خانه خمار می‌کشی",},
new Hafez{ Id= 3855, BeytNo = 5, GhazalNo = 459, Mesra1 = "گفتی سر تو بسته فتراک ما شود", Mesra2 = "سهل است اگر تو زحمت اين بار می‌کشی",},
new Hafez{ Id= 3856, BeytNo = 6, GhazalNo = 459, Mesra1 = "با چشم و ابروی تو چه تدبير دل کنم", Mesra2 = "وه زين کمان که بر من بيمار می‌کشی",},
new Hafez{ Id= 3857, BeytNo = 7, GhazalNo = 459, Mesra1 = "بازآ که چشم بد ز رخت دفع می‌کند", Mesra2 = "ای تازه گل که دامن از اين خار می‌کشی",},
new Hafez{ Id= 3858, BeytNo = 8, GhazalNo = 459, Mesra1 = "حافظ دگر چه می‌طلبی از نعيم دهر", Mesra2 = "می می‌خوری و طره دلدار می‌کشی",},
new Hafez{ Id= 3859, BeytNo = 1, GhazalNo = 460, Mesra1 = "سليمی منذ حلت بالعراق", Mesra2 = "الاقی من نواها ما الاقی",},
new Hafez{ Id= 3860, BeytNo = 2, GhazalNo = 460, Mesra1 = "الا ای ساروان منزل دوست", Mesra2 = "الی رکبانکم طال اشتياقی",},
new Hafez{ Id= 3861, BeytNo = 3, GhazalNo = 460, Mesra1 = "خرد در زنده رود انداز و می نوش", Mesra2 = "به گلبانگ جوانان عراقی",},
new Hafez{ Id= 3862, BeytNo = 4, GhazalNo = 460, Mesra1 = "ربيع العمر فی مرعی حماکم", Mesra2 = "حماک الله يا عهد التلاقی",},
new Hafez{ Id= 3863, BeytNo = 5, GhazalNo = 460, Mesra1 = "بيا ساقی بده رطل گرانم", Mesra2 = "سقاک الله من کاس دهاق",},
new Hafez{ Id= 3864, BeytNo = 6, GhazalNo = 460, Mesra1 = "جوانی باز می‌آرد به يادم", Mesra2 = "سماع چنگ و دست افشان ساقی",},
new Hafez{ Id= 3865, BeytNo = 7, GhazalNo = 460, Mesra1 = "می باقی بده تا مست و خوشدل", Mesra2 = "به ياران برفشانم عمر باقی",},
new Hafez{ Id= 3866, BeytNo = 8, GhazalNo = 460, Mesra1 = "درونم خون شد از ناديدن دوست", Mesra2 = "الا تعسا لايام الفراق",},
new Hafez{ Id= 3867, BeytNo = 9, GhazalNo = 460, Mesra1 = "دموعی بعدکم لا تحقروها", Mesra2 = "فکم بحر عميق من سواقی",},
new Hafez{ Id= 3868, BeytNo = 10, GhazalNo = 460, Mesra1 = "دمی با نيکخواهان متفق باش", Mesra2 = "غنيمت دان امور اتفاقی",},
new Hafez{ Id= 3869, BeytNo = 11, GhazalNo = 460, Mesra1 = "بساز ای مطرب خوشخوان خوشگو", Mesra2 = "به شعر فارسی صوت عراقی",},
new Hafez{ Id= 3870, BeytNo = 12, GhazalNo = 460, Mesra1 = "عروسی بس خوشی ای دختر رز", Mesra2 = "ولی گه گه سزاوار طلاقی",},
new Hafez{ Id= 3871, BeytNo = 13, GhazalNo = 460, Mesra1 = "مسيحای مجرد را برازد", Mesra2 = "که با خورشيد سازد هم وثاقی",},
new Hafez{ Id= 3872, BeytNo = 14, GhazalNo = 460, Mesra1 = "وصال دوستان روزی ما نيست", Mesra2 = "بخوان حافظ غزل‌های فراقی",},
new Hafez{ Id= 3873, BeytNo = 1, GhazalNo = 461, Mesra1 = "کتبت قصه شوقی و مدمعی باکی", Mesra2 = "بيا که بی تو به جان آمدم ز غمناکی",},
new Hafez{ Id= 3874, BeytNo = 2, GhazalNo = 461, Mesra1 = "بسا که گفته‌ام از شوق با دو ديده خود", Mesra2 = "ايا منازل سلمی فاين سلماک",},
new Hafez{ Id= 3875, BeytNo = 3, GhazalNo = 461, Mesra1 = "عجيب واقعه‌ای و غريب حادثه‌ای", Mesra2 = "انا اصطبرت قتيلا و قاتلی شاکی",},
new Hafez{ Id= 3876, BeytNo = 4, GhazalNo = 461, Mesra1 = "که را رسد که کند عيب دامن پاکت", Mesra2 = "که همچو قطره که بر برگ گل چکد پاکی",},
new Hafez{ Id= 3877, BeytNo = 5, GhazalNo = 461, Mesra1 = "ز خاک پای تو داد آب روی لاله و گل", Mesra2 = "چو کلک صنع رقم زد به آبی و خاکی",},
new Hafez{ Id= 3878, BeytNo = 6, GhazalNo = 461, Mesra1 = "صبا عبيرفشان گشت ساقيا برخيز", Mesra2 = "و هات شمسه کرم مطيب زاکی",},
new Hafez{ Id= 3879, BeytNo = 7, GhazalNo = 461, Mesra1 = "دع التکاسل تغنم فقد جری مثل", Mesra2 = "که زاد راهروان چستی است و چالاکی",},
new Hafez{ Id= 3880, BeytNo = 8, GhazalNo = 461, Mesra1 = "اثر نماند ز من بی شمايلت آری", Mesra2 = "اری مثر محيای من محياک",},
new Hafez{ Id= 3881, BeytNo = 9, GhazalNo = 461, Mesra1 = "ز وصف حسن تو حافظ چگونه نطق زند", Mesra2 = "که همچو صنع خدايی ورای ادراکی",},
new Hafez{ Id= 3882, BeytNo = 1, GhazalNo = 462, Mesra1 = "يا مبسما يحاکی درجا من اللالی", Mesra2 = "يا رب چه درخور آمد گردش خط هلالی",},
new Hafez{ Id= 3883, BeytNo = 2, GhazalNo = 462, Mesra1 = "حالی خيال وصلت خوش می‌دهد فريبم", Mesra2 = "تا خود چه نقش بازد اين صورت خيالی",},
new Hafez{ Id= 3884, BeytNo = 3, GhazalNo = 462, Mesra1 = "می ده که گر چه گشتم نامه سياه عالم", Mesra2 = "نوميد کی توان بود از لطف لايزالی",},
new Hafez{ Id= 3885, BeytNo = 4, GhazalNo = 462, Mesra1 = "ساقی بيار جامی و از خلوتم برون کش", Mesra2 = "تا در به در بگردم قلاش و لاابالی",},
new Hafez{ Id= 3886, BeytNo = 5, GhazalNo = 462, Mesra1 = "از چار چيز مگذر گر عاقلی و زيرک", Mesra2 = "امن و شراب بی‌غش معشوق و جای خالی",},
new Hafez{ Id= 3887, BeytNo = 6, GhazalNo = 462, Mesra1 = "چون نيست نقش دوران در هيچ حال ثابت", Mesra2 = "حافظ مکن شکايت تا می خوريم حالی",},
new Hafez{ Id= 3888, BeytNo = 7, GhazalNo = 462, Mesra1 = "صافيست جام خاطر در دور آصف عهد", Mesra2 = "قم فاسقنی رحيقا اصفی من الزلال",},
new Hafez{ Id= 3889, BeytNo = 8, GhazalNo = 462, Mesra1 = "الملک قد تباهی من جده و جده", Mesra2 = "يا رب که جاودان باد اين قدر و اين معالی",},
new Hafez{ Id= 3890, BeytNo = 9, GhazalNo = 462, Mesra1 = "مسندفروز دولت کان شکوه و شوکت", Mesra2 = "برهان ملک و ملت بونصر بوالمعالی",},
new Hafez{ Id= 3891, BeytNo = 1, GhazalNo = 463, Mesra1 = "سلام الله ما کر الليالی", Mesra2 = "و جاوبت المثانی و المثالی",},
new Hafez{ Id= 3892, BeytNo = 2, GhazalNo = 463, Mesra1 = "علی وادی الاراک و من عليها", Mesra2 = "و دار باللوی فوق الرمال",},
new Hafez{ Id= 3893, BeytNo = 3, GhazalNo = 463, Mesra1 = "دعاگوی غريبان جهانم", Mesra2 = "و ادعو بالتواتر و التوالی",},
new Hafez{ Id= 3894, BeytNo = 4, GhazalNo = 463, Mesra1 = "به هر منزل که رو آرد خدا را", Mesra2 = "نگه دارش به لطف لايزالی",},
new Hafez{ Id= 3895, BeytNo = 5, GhazalNo = 463, Mesra1 = "منال ای دل که در زنجير زلفش", Mesra2 = "همه جمعيت است آشفته حالی",},
new Hafez{ Id= 3896, BeytNo = 6, GhazalNo = 463, Mesra1 = "ز خطت صد جمال ديگر افزود", Mesra2 = "که عمرت باد صد سال جلالی",},
new Hafez{ Id= 3897, BeytNo = 7, GhazalNo = 463, Mesra1 = "تو می‌بايد که باشی ور نه سهل است", Mesra2 = "زيان مايه جاهی و مالی",},
new Hafez{ Id= 3898, BeytNo = 8, GhazalNo = 463, Mesra1 = "بر آن نقاش قدرت آفرين باد", Mesra2 = "که گرد مه کشد خط هلالی",},
new Hafez{ Id= 3899, BeytNo = 9, GhazalNo = 463, Mesra1 = "فحبک راحتی فی کل حين", Mesra2 = "و ذکرک مونسی فی کل حال",},
new Hafez{ Id= 3900, BeytNo = 10, GhazalNo = 463, Mesra1 = "سويدای دل من تا قيامت", Mesra2 = "مباد از شوق و سودای تو خالی",},
new Hafez{ Id= 3901, BeytNo = 11, GhazalNo = 463, Mesra1 = "کجا يابم وصال چون تو شاهی", Mesra2 = "من بدنام رند لاابالی",},
new Hafez{ Id= 3902, BeytNo = 12, GhazalNo = 463, Mesra1 = "خدا داند که حافظ را غرض چيست", Mesra2 = "و علم الله حسبی من سالی",},
new Hafez{ Id= 3903, BeytNo = 1, GhazalNo = 464, Mesra1 = "بگرفت کار حسنت چون عشق من کمالی", Mesra2 = "خوش باش زان که نبود اين هر دو را زوالی",},
new Hafez{ Id= 3904, BeytNo = 2, GhazalNo = 464, Mesra1 = "در وهم می‌نگنجد کاندر تصور عقل", Mesra2 = "آيد به هيچ معنی زين خوبتر مثالی",},
new Hafez{ Id= 3905, BeytNo = 3, GhazalNo = 464, Mesra1 = "شد حظ عمر حاصل گر زان که با تو ما را", Mesra2 = "هرگز به عمر روزی روزی شود وصالی",},
new Hafez{ Id= 3906, BeytNo = 4, GhazalNo = 464, Mesra1 = "آن دم که با تو باشم يک سال هست روزی", Mesra2 = "وان دم که بی تو باشم يک لحظه هست سالی",},
new Hafez{ Id= 3907, BeytNo = 5, GhazalNo = 464, Mesra1 = "چون من خيال رويت جانا به خواب بينم", Mesra2 = "کز خواب می‌نبيند چشمم بجز خيالی",},
new Hafez{ Id= 3908, BeytNo = 6, GhazalNo = 464, Mesra1 = "رحم آر بر دل من کز مهر روی خوبت", Mesra2 = "شد شخص ناتوانم باريک چون هلالی",},
new Hafez{ Id= 3909, BeytNo = 7, GhazalNo = 464, Mesra1 = "حافظ مکن شکايت گر وصل دوست خواهی", Mesra2 = "زين بيشتر ببايد بر هجرت احتمالی",},
new Hafez{ Id= 3910, BeytNo = 1, GhazalNo = 465, Mesra1 = "رفتم به باغ صبحدمی تا چنم گلی", Mesra2 = "آمد به گوش ناگهم آواز بلبلی",},
new Hafez{ Id= 3911, BeytNo = 2, GhazalNo = 465, Mesra1 = "مسکين چو من به عشق گلی گشته مبتلا", Mesra2 = "و اندر چمن فکنده ز فرياد غلغلی",},
new Hafez{ Id= 3912, BeytNo = 3, GhazalNo = 465, Mesra1 = "می‌گشتم اندر آن چمن و باغ دم به دم", Mesra2 = "می‌کردم اندر آن گل و بلبل تاملی",},
new Hafez{ Id= 3913, BeytNo = 4, GhazalNo = 465, Mesra1 = "گل يار حسن گشته و بلبل قرين عشق", Mesra2 = "آن را تفضلی نه و اين را تبدلی",},
new Hafez{ Id= 3914, BeytNo = 5, GhazalNo = 465, Mesra1 = "چون کرد در دلم اثر آواز عندليب", Mesra2 = "گشتم چنان که هيچ نماندم تحملی",},
new Hafez{ Id= 3915, BeytNo = 6, GhazalNo = 465, Mesra1 = "بس گل شکفته می‌شود اين باغ را ولی", Mesra2 = "کس بی بلای خار نچيده‌ست از او گلی",},
new Hafez{ Id= 3916, BeytNo = 7, GhazalNo = 465, Mesra1 = "حافظ مدار اميد فرج از مدار چرخ", Mesra2 = "دارد هزار عيب و ندارد تفضلی",},
new Hafez{ Id= 3917, BeytNo = 1, GhazalNo = 466, Mesra1 = "اين خرقه که من دارم در رهن شراب اولی", Mesra2 = "وين دفتر بی‌معنی غرق می ناب اولی",},
new Hafez{ Id= 3918, BeytNo = 2, GhazalNo = 466, Mesra1 = "چون عمر تبه کردم چندان که نگه کردم", Mesra2 = "در کنج خراباتی افتاده خراب اولی",},
new Hafez{ Id= 3919, BeytNo = 3, GhazalNo = 466, Mesra1 = "چون مصلحت انديشی دور است ز درويشی", Mesra2 = "هم سينه پر از آتش هم ديده پرآب اولی",},
new Hafez{ Id= 3920, BeytNo = 4, GhazalNo = 466, Mesra1 = "من حالت زاهد را با خلق نخواهم گفت", Mesra2 = "اين قصه اگر گويم با چنگ و رباب اولی",},
new Hafez{ Id= 3921, BeytNo = 5, GhazalNo = 466, Mesra1 = "تا بی سر و پا باشد اوضاع فلک زين دست", Mesra2 = "در سر هوس ساقی در دست شراب اولی",},
new Hafez{ Id= 3922, BeytNo = 6, GhazalNo = 466, Mesra1 = "از همچو تو دلداری دل برنکنم آری", Mesra2 = "چون تاب کشم باری زان زلف به تاب اولی",},
new Hafez{ Id= 3923, BeytNo = 7, GhazalNo = 466, Mesra1 = "چون پير شدی حافظ از ميکده بيرون آی", Mesra2 = "رندی و هوسناکی در عهد شباب اولی",},
new Hafez{ Id= 3924, BeytNo = 1, GhazalNo = 467, Mesra1 = "زان می عشق کز او پخته شود هر خامی", Mesra2 = "گر چه ماه رمضان است بياور جامی",},
new Hafez{ Id= 3925, BeytNo = 2, GhazalNo = 467, Mesra1 = "روزها رفت که دست من مسکين نگرفت", Mesra2 = "زلف شمشادقدی ساعد سيم اندامی",},
new Hafez{ Id= 3926, BeytNo = 3, GhazalNo = 467, Mesra1 = "روزه هر چند که مهمان عزيز است ای دل", Mesra2 = "صحبتش موهبتی دان و شدن انعامی",},
new Hafez{ Id= 3927, BeytNo = 4, GhazalNo = 467, Mesra1 = "مرغ زيرک به در خانقه اکنون نپرد", Mesra2 = "که نهاده‌ست به هر مجلس وعظی دامی",},
new Hafez{ Id= 3928, BeytNo = 5, GhazalNo = 467, Mesra1 = "گله از زاهد بدخو نکنم رسم اين است", Mesra2 = "که چو صبحی بدمد در پی اش افتد شامی",},
new Hafez{ Id= 3929, BeytNo = 6, GhazalNo = 467, Mesra1 = "يار من چون بخرامد به تماشای چمن", Mesra2 = "برسانش ز من ای پيک صبا پيغامی",},
new Hafez{ Id= 3930, BeytNo = 7, GhazalNo = 467, Mesra1 = "آن حريفی که شب و روز می صاف کشد", Mesra2 = "بود آيا که کند ياد ز دردآشامی",},
new Hafez{ Id= 3931, BeytNo = 8, GhazalNo = 467, Mesra1 = "حافظا گر ندهد داد دلت آصف عهد", Mesra2 = "کام دشوار به دست آوری از خودکامی",},
new Hafez{ Id= 3932, BeytNo = 1, GhazalNo = 468, Mesra1 = "که برد به نزد شاهان ز من گدا پيامی", Mesra2 = "که به کوی می فروشان دو هزار جم به جامی",},
new Hafez{ Id= 3933, BeytNo = 2, GhazalNo = 468, Mesra1 = "شده‌ام خراب و بدنام و هنوز اميدوارم", Mesra2 = "که به همت عزيزان برسم به نيک نامی",},
new Hafez{ Id= 3934, BeytNo = 3, GhazalNo = 468, Mesra1 = "تو که کيميافروشی نظری به قلب ما کن", Mesra2 = "که بضاعتی نداريم و فکنده‌ايم دامی",},
new Hafez{ Id= 3935, BeytNo = 4, GhazalNo = 468, Mesra1 = "عجب از وفای جانان که عنايتی نفرمود", Mesra2 = "نه به نامه پيامی نه به خامه سلامی",},
new Hafez{ Id= 3936, BeytNo = 5, GhazalNo = 468, Mesra1 = "اگر اين شراب خام است اگر آن حريف پخته", Mesra2 = "به هزار بار بهتر ز هزار پخته خامی",},
new Hafez{ Id= 3937, BeytNo = 6, GhazalNo = 468, Mesra1 = "ز رهم ميفکن ای شيخ به دانه‌های تسبيح", Mesra2 = "که چو مرغ زيرک افتد نفتد به هيچ دامی",},
new Hafez{ Id= 3938, BeytNo = 7, GhazalNo = 468, Mesra1 = "سر خدمت تو دارم بخرم به لطف و مفروش", Mesra2 = "که چو بنده کمتر افتد به مبارکی غلامی",},
new Hafez{ Id= 3939, BeytNo = 8, GhazalNo = 468, Mesra1 = "به کجا برم شکايت به که گويم اين حکايت", Mesra2 = "که لبت حيات ما بود و نداشتی دوامی",},
new Hafez{ Id= 3940, BeytNo = 9, GhazalNo = 468, Mesra1 = "بگشای تير مژگان و بريز خون حافظ", Mesra2 = "که چنان کشنده‌ای را نکند کس انتقامی",},
new Hafez{ Id= 3941, BeytNo = 1, GhazalNo = 469, Mesra1 = "انت رواح رند الحمی و زاد غرامی", Mesra2 = "فدای خاک در دوست باد جان گرامی",},
new Hafez{ Id= 3942, BeytNo = 2, GhazalNo = 469, Mesra1 = "پيام دوست شنيدن سعادت است و سلامت", Mesra2 = "من المبلغ عنی الی سعاد سلامی",},
new Hafez{ Id= 3943, BeytNo = 3, GhazalNo = 469, Mesra1 = "بيا به شام غريبان و آب ديده من بين", Mesra2 = "به سان باده صافی در آبگينه شامی",},
new Hafez{ Id= 3944, BeytNo = 4, GhazalNo = 469, Mesra1 = "اذا تغرد عن ذی الاراک طار خير", Mesra2 = "فلا تفرد عن روضها انين حمامی",},
new Hafez{ Id= 3945, BeytNo = 5, GhazalNo = 469, Mesra1 = "بسی نماند که روز فراق يار سر آيد", Mesra2 = "رايت من هضبات الحمی قباب خيام",},
new Hafez{ Id= 3946, BeytNo = 6, GhazalNo = 469, Mesra1 = "خوشا دمی که درآيی و گويمت به سلامت", Mesra2 = "قدمت خير قدوم نزلت خير مقام",},
new Hafez{ Id= 3947, BeytNo = 7, GhazalNo = 469, Mesra1 = "بعدت منک و قد صرت ذابا کهلال", Mesra2 = "اگر چه روی چو ماهت نديده‌ام به تمامی",},
new Hafez{ Id= 3948, BeytNo = 8, GhazalNo = 469, Mesra1 = "و ان دعيت بخلد و صرت ناقض عهد", Mesra2 = "فما تطيب نفسی و ما استطاب منامی",},
new Hafez{ Id= 3949, BeytNo = 9, GhazalNo = 469, Mesra1 = "اميد هست که زودت به بخت نيک ببينم", Mesra2 = "تو شاد گشته به فرماندهی و من به غلامی",},
new Hafez{ Id= 3950, BeytNo = 10, GhazalNo = 469, Mesra1 = "چو سلک در خوشاب است شعر نغز تو حافظ", Mesra2 = "که گاه لطف سبق می‌برد ز نظم نظامی",},
new Hafez{ Id= 3951, BeytNo = 1, GhazalNo = 470, Mesra1 = "سينه مالامال درد است ای دريغا مرهمی", Mesra2 = "دل ز تنهايی به جان آمد خدا را همدمی",},
new Hafez{ Id= 3952, BeytNo = 2, GhazalNo = 470, Mesra1 = "چشم آسايش که دارد از سپهر تيزرو", Mesra2 = "ساقيا جامی به من ده تا بياسايم دمی",},
new Hafez{ Id= 3953, BeytNo = 3, GhazalNo = 470, Mesra1 = "زيرکی را گفتم اين احوال بين خنديد و گفت", Mesra2 = "صعب روزی بوالعجب کاری پريشان عالمی",},
new Hafez{ Id= 3954, BeytNo = 4, GhazalNo = 470, Mesra1 = "سوختم در چاه صبر از بهر آن شمع چگل", Mesra2 = "شاه ترکان فارغ است از حال ما کو رستمی",},
new Hafez{ Id= 3955, BeytNo = 5, GhazalNo = 470, Mesra1 = "در طريق عشقبازی امن و آسايش بلاست", Mesra2 = "ريش باد آن دل که با درد تو خواهد مرهمی",},
new Hafez{ Id= 3956, BeytNo = 6, GhazalNo = 470, Mesra1 = "اهل کام و ناز را در کوی رندی راه نيست", Mesra2 = "ره روی بايد جهان سوزی نه خامی بی‌غمی",},
new Hafez{ Id= 3957, BeytNo = 7, GhazalNo = 470, Mesra1 = "آدمی در عالم خاکی نمی‌آيد به دست", Mesra2 = "عالمی ديگر ببايد ساخت و از نو آدمی",},
new Hafez{ Id= 3958, BeytNo = 8, GhazalNo = 470, Mesra1 = "خيز تا خاطر بدان ترک سمرقندی دهيم", Mesra2 = "کز نسيمش بوی جوی موليان آيد همی",},
new Hafez{ Id= 3959, BeytNo = 9, GhazalNo = 470, Mesra1 = "گريه حافظ چه سنجد پيش استغنای عشق", Mesra2 = "کاندر اين دريا نمايد هفت دريا شبنمی",},
new Hafez{ Id= 3960, BeytNo = 1, GhazalNo = 471, Mesra1 = "ز دلبرم که رساند نوازش قلمی", Mesra2 = "کجاست پيک صبا گر همی‌کند کرمی",},
new Hafez{ Id= 3961, BeytNo = 2, GhazalNo = 471, Mesra1 = "قياس کردم و تدبير عقل در ره عشق", Mesra2 = "چو شبنمی است که بر بحر می‌کشد رقمی",},
new Hafez{ Id= 3962, BeytNo = 3, GhazalNo = 471, Mesra1 = "بيا که خرقه من گر چه رهن ميکده‌هاست", Mesra2 = "ز مال وقف نبينی به نام من درمی",},
new Hafez{ Id= 3963, BeytNo = 4, GhazalNo = 471, Mesra1 = "حديث چون و چرا درد سر دهد ای دل", Mesra2 = "پياله گير و بياسا ز عمر خويش دمی",},
new Hafez{ Id= 3964, BeytNo = 5, GhazalNo = 471, Mesra1 = "طبيب راه نشين درد عشق نشناسد", Mesra2 = "برو به دست کن ای مرده دل مسيح دمی",},
new Hafez{ Id= 3965, BeytNo = 6, GhazalNo = 471, Mesra1 = "دلم گرفت ز سالوس و طبل زير گليم", Mesra2 = "به آن که بر در ميخانه برکشم علمی",},
new Hafez{ Id= 3966, BeytNo = 7, GhazalNo = 471, Mesra1 = "بيا که وقت شناسان دو کون بفروشند", Mesra2 = "به يک پياله می صاف و صحبت صنمی",},
new Hafez{ Id= 3967, BeytNo = 8, GhazalNo = 471, Mesra1 = "دوام عيش و تنعم نه شيوه عشق است", Mesra2 = "اگر معاشر مايی بنوش نيش غمی",},
new Hafez{ Id= 3968, BeytNo = 9, GhazalNo = 471, Mesra1 = "نمی‌کنم گله‌ای ليک ابر رحمت دوست", Mesra2 = "به کشته زار جگرتشنگان نداد نمی",},
new Hafez{ Id= 3969, BeytNo = 10, GhazalNo = 471, Mesra1 = "چرا به يک نی قندش نمی‌خرند آن کس", Mesra2 = "که کرد صد شکرافشانی از نی قلمی",},
new Hafez{ Id= 3970, BeytNo = 11, GhazalNo = 471, Mesra1 = "سزای قدر تو شاها به دست حافظ نيست", Mesra2 = "جز از دعای شبی و نياز صبحدمی",},
new Hafez{ Id= 3971, BeytNo = 1, GhazalNo = 472, Mesra1 = "احمد الله علی معدله السلطان", Mesra2 = "احمد شيخ اويس حسن ايلخانی",},
new Hafez{ Id= 3972, BeytNo = 2, GhazalNo = 472, Mesra1 = "خان بن خان و شهنشاه شهنشاه نژاد", Mesra2 = "آن که می‌زيبد اگر جان جهانش خوانی",},
new Hafez{ Id= 3973, BeytNo = 3, GhazalNo = 472, Mesra1 = "ديده ناديده به اقبال تو ايمان آورد", Mesra2 = "مرحبا ای به چنين لطف خدا ارزانی",},
new Hafez{ Id= 3974, BeytNo = 4, GhazalNo = 472, Mesra1 = "ماه اگر بی تو برآيد به دو نيمش بزنند", Mesra2 = "دولت احمدی و معجزه سبحانی",},
new Hafez{ Id= 3975, BeytNo = 5, GhazalNo = 472, Mesra1 = "جلوه بخت تو دل می‌برد از شاه و گدا", Mesra2 = "چشم بد دور که هم جانی و هم جانانی",},
new Hafez{ Id= 3976, BeytNo = 6, GhazalNo = 472, Mesra1 = "برشکن کاکل ترکانه که در طالع توست", Mesra2 = "بخشش و کوشش خاقانی و چنگزخانی",},
new Hafez{ Id= 3977, BeytNo = 7, GhazalNo = 472, Mesra1 = "گر چه دوريم به ياد تو قدح می‌گيريم", Mesra2 = "بعد منزل نبود در سفر روحانی",},
new Hafez{ Id= 3978, BeytNo = 8, GhazalNo = 472, Mesra1 = "از گل پارسيم غنچه عيشی نشکفت", Mesra2 = "حبذا دجله بغداد و می ريحانی",},
new Hafez{ Id= 3979, BeytNo = 9, GhazalNo = 472, Mesra1 = "سر عاشق که نه خاک در معشوق بود", Mesra2 = "کی خلاصش بود از محنت سرگردانی",},
new Hafez{ Id= 3980, BeytNo = 10, GhazalNo = 472, Mesra1 = "ای نسيم سحری خاک در يار بيار", Mesra2 = "که کند حافظ از او ديده دل نورانی",},
new Hafez{ Id= 3981, BeytNo = 1, GhazalNo = 473, Mesra1 = "وقت را غنيمت دان آن قدر که بتوانی", Mesra2 = "حاصل از حيات ای جان اين دم است تا دانی",},
new Hafez{ Id= 3982, BeytNo = 2, GhazalNo = 473, Mesra1 = "کام بخشی گردون عمر در عوض دارد", Mesra2 = "جهد کن که از دولت داد عيش بستانی",},
new Hafez{ Id= 3983, BeytNo = 3, GhazalNo = 473, Mesra1 = "باغبان چو من زين جا بگذرم حرامت باد", Mesra2 = "گر به جای من سروی غير دوست بنشانی",},
new Hafez{ Id= 3984, BeytNo = 4, GhazalNo = 473, Mesra1 = "زاهد پشيمان را ذوق باده خواهد کشت", Mesra2 = "عاقلا مکن کاری کورد پشيمانی",},
new Hafez{ Id= 3985, BeytNo = 5, GhazalNo = 473, Mesra1 = "محتسب نمی‌داند اين قدر که صوفی را", Mesra2 = "جنس خانگی باشد همچو لعل رمانی",},
new Hafez{ Id= 3986, BeytNo = 6, GhazalNo = 473, Mesra1 = "با دعای شبخيزان ای شکردهان مستيز", Mesra2 = "در پناه يک اسم است خاتم سليمانی",},
new Hafez{ Id= 3987, BeytNo = 7, GhazalNo = 473, Mesra1 = "پند عاشقان بشنو و از در طرب بازآ", Mesra2 = "کاين همه نمی‌ارزد شغل عالم فانی",},
new Hafez{ Id= 3988, BeytNo = 8, GhazalNo = 473, Mesra1 = "يوسف عزيزم رفت ای برادران رحمی", Mesra2 = "کز غمش عجب بينم حال پير کنعانی",},
new Hafez{ Id= 3989, BeytNo = 9, GhazalNo = 473, Mesra1 = "پيش زاهد از رندی دم مزن که نتوان گفت", Mesra2 = "با طبيب نامحرم حال درد پنهانی",},
new Hafez{ Id= 3990, BeytNo = 10, GhazalNo = 473, Mesra1 = "می‌روی و مژگانت خون خلق می‌ريزد", Mesra2 = "تيز می‌روی جانا ترسمت فرومانی",},
new Hafez{ Id= 3991, BeytNo = 11, GhazalNo = 473, Mesra1 = "دل ز ناوک چشمت گوش داشتم ليکن", Mesra2 = "ابروی کماندارت می‌برد به پيشانی",},
new Hafez{ Id= 3992, BeytNo = 12, GhazalNo = 473, Mesra1 = "جمع کن به احسانی حافظ پريشان را", Mesra2 = "ای شکنج گيسويت مجمع پريشانی",},
new Hafez{ Id= 3993, BeytNo = 13, GhazalNo = 473, Mesra1 = "گر تو فارغی از ما ای نگار سنگين دل", Mesra2 = "حال خود بخواهم گفت پيش آصف ثانی",},
new Hafez{ Id= 3994, BeytNo = 1, GhazalNo = 474, Mesra1 = "هواخواه توام جانا و می‌دانم که می‌دانی", Mesra2 = "که هم ناديده می‌بينی و هم ننوشته می‌خوانی",},
new Hafez{ Id= 3995, BeytNo = 2, GhazalNo = 474, Mesra1 = "ملامتگو چه دريابد ميان عاشق و معشوق", Mesra2 = "نبيند چشم نابينا خصوص اسرار پنهانی",},
new Hafez{ Id= 3996, BeytNo = 3, GhazalNo = 474, Mesra1 = "بيفشان زلف و صوفی را به پابازی و رقص آور", Mesra2 = "که از هر رقعه دلقش هزاران بت بيفشانی",},
new Hafez{ Id= 3997, BeytNo = 4, GhazalNo = 474, Mesra1 = "گشاد کار مشتاقان در آن ابروی دلبند است", Mesra2 = "خدا را يک نفس بنشين گره بگشا ز پيشانی",},
new Hafez{ Id= 3998, BeytNo = 5, GhazalNo = 474, Mesra1 = "ملک در سجده آدم زمين بوس تو نيت کرد", Mesra2 = "که در حسن تو لطفی ديد بيش از حد انسانی",},
new Hafez{ Id= 3999, BeytNo = 6, GhazalNo = 474, Mesra1 = "چراغ افروز چشم ما نسيم زلف جانان است", Mesra2 = "مباد اين جمع را يا رب غم از باد پريشانی",},
new Hafez{ Id= 4000, BeytNo = 7, GhazalNo = 474, Mesra1 = "دريغا عيش شبگيری که در خواب سحر بگذشت", Mesra2 = "ندانی قدر وقت ای دل مگر وقتی که درمانی",},
new Hafez{ Id= 4001, BeytNo = 8, GhazalNo = 474, Mesra1 = "ملول از همرهان بودن طريق کاردانی نيست", Mesra2 = "بکش دشواری منزل به ياد عهد آسانی",},
new Hafez{ Id= 4002, BeytNo = 9, GhazalNo = 474, Mesra1 = "خيال چنبر زلفش فريبت می‌دهد حافظ", Mesra2 = "نگر تا حلقه اقبال ناممکن نجنبانی",},
new Hafez{ Id= 4003, BeytNo = 1, GhazalNo = 475, Mesra1 = "گفتند خلايق که تويی يوسف ثانی", Mesra2 = "چون نيک بديدم به حقيقت به از آنی",},
new Hafez{ Id= 4004, BeytNo = 2, GhazalNo = 475, Mesra1 = "شيرينتر از آنی به شکرخنده که گويم", Mesra2 = "ای خسرو خوبان که تو شيرين زمانی",},
new Hafez{ Id= 4005, BeytNo = 3, GhazalNo = 475, Mesra1 = "تشبيه دهانت نتوان کرد به غنچه", Mesra2 = "هرگز نبود غنچه بدين تنگ دهانی",},
new Hafez{ Id= 4006, BeytNo = 4, GhazalNo = 475, Mesra1 = "صد بار بگفتی که دهم زان دهنت کام", Mesra2 = "چون سوسن آزاده چرا جمله زبانی",},
new Hafez{ Id= 4007, BeytNo = 5, GhazalNo = 475, Mesra1 = "گويی بدهم کامت و جانت بستانم", Mesra2 = "ترسم ندهی کامم و جانم بستانی",},
new Hafez{ Id= 4008, BeytNo = 6, GhazalNo = 475, Mesra1 = "چشم تو خدنگ از سپر جان گذراند", Mesra2 = "بيمار که ديده‌ست بدين سخت کمانی",},
new Hafez{ Id= 4009, BeytNo = 7, GhazalNo = 475, Mesra1 = "چون اشک بيندازيش از ديده مردم", Mesra2 = "آن را که دمی از نظر خويش برانی",},
new Hafez{ Id= 4010, BeytNo = 1, GhazalNo = 476, Mesra1 = "نسيم صبح سعادت بدان نشان که تو دانی", Mesra2 = "گذر به کوی فلان کن در آن زمان که تو دانی",},
new Hafez{ Id= 4011, BeytNo = 2, GhazalNo = 476, Mesra1 = "تو پيک خلوت رازی و ديده بر سر راهت", Mesra2 = "به مردمی نه به فرمان چنان بران که تو دانی",},
new Hafez{ Id= 4012, BeytNo = 3, GhazalNo = 476, Mesra1 = "بگو که جان عزيزم ز دست رفت خدا را", Mesra2 = "ز لعل روح فزايش ببخش آن که تو دانی",},
new Hafez{ Id= 4013, BeytNo = 4, GhazalNo = 476, Mesra1 = "من اين حروف نوشتم چنان که غير ندانست", Mesra2 = "تو هم ز روی کرامت چنان بخوان که تو دانی",},
new Hafez{ Id= 4014, BeytNo = 5, GhazalNo = 476, Mesra1 = "خيال تيغ تو با ما حديث تشنه و آب است", Mesra2 = "اسير خويش گرفتی بکش چنان که تو دانی",},
new Hafez{ Id= 4015, BeytNo = 6, GhazalNo = 476, Mesra1 = "اميد در کمر زرکشت چگونه ببندم", Mesra2 = "دقيقه‌ايست نگارا در آن ميان که تو دانی",},
new Hafez{ Id= 4016, BeytNo = 7, GhazalNo = 476, Mesra1 = "يکيست ترکی و تازی در اين معامله حافظ", Mesra2 = "حديث عشق بيان کن بدان زبان که تو دانی",},
new Hafez{ Id= 4017, BeytNo = 1, GhazalNo = 477, Mesra1 = "دو يار زيرک و از باده کهن دومنی", Mesra2 = "فراغتی و کتابی و گوشه چمنی",},
new Hafez{ Id= 4018, BeytNo = 2, GhazalNo = 477, Mesra1 = "من اين مقام به دنيا و آخرت ندهم", Mesra2 = "اگر چه در پی ام افتند هر دم انجمنی",},
new Hafez{ Id= 4019, BeytNo = 3, GhazalNo = 477, Mesra1 = "هر آن که کنج قناعت به گنج دنيا داد", Mesra2 = "فروخت يوسف مصری به کمترين ثمنی",},
new Hafez{ Id= 4020, BeytNo = 4, GhazalNo = 477, Mesra1 = "بيا که رونق اين کارخانه کم نشود", Mesra2 = "به زهد همچو تويی يا به فسق همچو منی",},
new Hafez{ Id= 4021, BeytNo = 5, GhazalNo = 477, Mesra1 = "ز تندباد حوادث نمی‌توان ديدن", Mesra2 = "در اين چمن که گلی بوده است يا سمنی",},
new Hafez{ Id= 4022, BeytNo = 6, GhazalNo = 477, Mesra1 = "ببين در آينه جام نقش بندی غيب", Mesra2 = "که کس به ياد ندارد چنين عجب زمنی",},
new Hafez{ Id= 4023, BeytNo = 7, GhazalNo = 477, Mesra1 = "از اين سموم که بر طرف بوستان بگذشت", Mesra2 = "عجب که بوی گلی هست و رنگ نسترنی",},
new Hafez{ Id= 4024, BeytNo = 8, GhazalNo = 477, Mesra1 = "به صبر کوش تو ای دل که حق رها نکند", Mesra2 = "چنين عزيز نگينی به دست اهرمنی",},
new Hafez{ Id= 4025, BeytNo = 9, GhazalNo = 477, Mesra1 = "مزاج دهر تبه شد در اين بلا حافظ", Mesra2 = "کجاست فکر حکيمی و رای برهمنی",},
new Hafez{ Id= 4026, BeytNo = 1, GhazalNo = 478, Mesra1 = "نوش کن جام شراب يک منی", Mesra2 = "تا بدان بيخ غم از دل برکنی",},
new Hafez{ Id= 4027, BeytNo = 2, GhazalNo = 478, Mesra1 = "دل گشاده دار چون جام شراب", Mesra2 = "سر گرفته چند چون خم دنی",},
new Hafez{ Id= 4028, BeytNo = 3, GhazalNo = 478, Mesra1 = "چون ز جام بيخودی رطلی کشی", Mesra2 = "کم زنی از خويشتن لاف منی",},
new Hafez{ Id= 4029, BeytNo = 4, GhazalNo = 478, Mesra1 = "سنگسان شو در قدم نی همچو آب", Mesra2 = "جمله رنگ آميزی و تردامنی",},
new Hafez{ Id= 4030, BeytNo = 5, GhazalNo = 478, Mesra1 = "دل به می دربند تا مردانه وار", Mesra2 = "گردن سالوس و تقوا بشکنی",},
new Hafez{ Id= 4031, BeytNo = 6, GhazalNo = 478, Mesra1 = "خيز و جهدی کن چو حافظ تا مگر", Mesra2 = "خويشتن در پای معشوق افکنی",},
new Hafez{ Id= 4032, BeytNo = 1, GhazalNo = 479, Mesra1 = "صبح است و ژاله می‌چکد از ابر بهمنی", Mesra2 = "برگ صبوح ساز و بده جام يک منی",},
new Hafez{ Id= 4033, BeytNo = 2, GhazalNo = 479, Mesra1 = "در بحر مايی و منی افتاده‌ام بيار", Mesra2 = "می تا خلاص بخشدم از مايی و منی",},
new Hafez{ Id= 4034, BeytNo = 3, GhazalNo = 479, Mesra1 = "خون پياله خور که حلال است خون او", Mesra2 = "در کار يار باش که کاريست کردنی",},
new Hafez{ Id= 4035, BeytNo = 4, GhazalNo = 479, Mesra1 = "ساقی به دست باش که غم در کمين ماست", Mesra2 = "مطرب نگاه دار همين ره که می‌زنی",},
new Hafez{ Id= 4036, BeytNo = 5, GhazalNo = 479, Mesra1 = "می ده که سر به گوش من آورد چنگ و گفت", Mesra2 = "خوش بگذران و بشنو از اين پير منحنی",},
new Hafez{ Id= 4037, BeytNo = 6, GhazalNo = 479, Mesra1 = "ساقی به بی‌نيازی رندان که می بده", Mesra2 = "تا بشنوی ز صوت مغنی هوالغنی",},
new Hafez{ Id= 4038, BeytNo = 1, GhazalNo = 480, Mesra1 = "ای که در کشتن ما هيچ مدارا نکنی", Mesra2 = "سود و سرمايه بسوزی و محابا نکنی",},
new Hafez{ Id= 4039, BeytNo = 2, GhazalNo = 480, Mesra1 = "دردمندان بلا زهر هلاهل دارند", Mesra2 = "قصد اين قوم خطا باشد هان تا نکنی",},
new Hafez{ Id= 4040, BeytNo = 3, GhazalNo = 480, Mesra1 = "رنج ما را که توان برد به يک گوشه چشم", Mesra2 = "شرط انصاف نباشد که مداوا نکنی",},
new Hafez{ Id= 4041, BeytNo = 4, GhazalNo = 480, Mesra1 = "ديده ما چو به اميد تو درياست چرا", Mesra2 = "به تفرج گذری بر لب دريا نکنی",},
new Hafez{ Id= 4042, BeytNo = 5, GhazalNo = 480, Mesra1 = "نقل هر جور که از خلق کريمت کردند", Mesra2 = "قول صاحب غرضان است تو آن‌ها نکنی",},
new Hafez{ Id= 4043, BeytNo = 6, GhazalNo = 480, Mesra1 = "بر تو گر جلوه کند شاهد ما ای زاهد", Mesra2 = "از خدا جز می و معشوق تمنا نکنی",},
new Hafez{ Id= 4044, BeytNo = 7, GhazalNo = 480, Mesra1 = "حافظا سجده به ابروی چو محرابش بر", Mesra2 = "که دعايی ز سر صدق جز آن جا نکنی",},
new Hafez{ Id= 4045, BeytNo = 1, GhazalNo = 481, Mesra1 = "بشنو اين نکته که خود را ز غم آزاده کنی", Mesra2 = "خون خوری گر طلب روزی ننهاده کنی",},
new Hafez{ Id= 4046, BeytNo = 2, GhazalNo = 481, Mesra1 = "آخرالامر گل کوزه گران خواهی شد", Mesra2 = "حاليا فکر سبو کن که پر از باده کنی",},
new Hafez{ Id= 4047, BeytNo = 3, GhazalNo = 481, Mesra1 = "گر از آن آدميانی که بهشتت هوس است", Mesra2 = "عيش با آدمی ای چند پری زاده کنی",},
new Hafez{ Id= 4048, BeytNo = 4, GhazalNo = 481, Mesra1 = "تکيه بر جای بزرگان نتوان زد به گزاف", Mesra2 = "مگر اسباب بزرگی همه آماده کنی",},
new Hafez{ Id= 4049, BeytNo = 5, GhazalNo = 481, Mesra1 = "اجرها باشدت ای خسرو شيرين دهنان", Mesra2 = "گر نگاهی سوی فرهاد دل افتاده کنی",},
new Hafez{ Id= 4050, BeytNo = 6, GhazalNo = 481, Mesra1 = "خاطرت کی رقم فيض پذيرد هيهات", Mesra2 = "مگر از نقش پراگنده ورق ساده کنی",},
new Hafez{ Id= 4051, BeytNo = 7, GhazalNo = 481, Mesra1 = "کار خود گر به کرم بازگذاری حافظ", Mesra2 = "ای بسا عيش که با بخت خداداده کنی",},
new Hafez{ Id= 4052, BeytNo = 8, GhazalNo = 481, Mesra1 = "ای صبا بندگی خواجه جلال الدين کن", Mesra2 = "که جهان پرسمن و سوسن آزاده کنی",},
new Hafez{ Id= 4053, BeytNo = 1, GhazalNo = 482, Mesra1 = "ای دل به کوی عشق گذاری نمی‌کنی", Mesra2 = "اسباب جمع داری و کاری نمی‌کنی",},
new Hafez{ Id= 4054, BeytNo = 2, GhazalNo = 482, Mesra1 = "چوگان حکم در کف و گويی نمی‌زنی", Mesra2 = "باز ظفر به دست و شکاری نمی‌کنی",},
new Hafez{ Id= 4055, BeytNo = 3, GhazalNo = 482, Mesra1 = "اين خون که موج می‌زند اندر جگر تو را", Mesra2 = "در کار رنگ و بوی نگاری نمی‌کنی",},
new Hafez{ Id= 4056, BeytNo = 4, GhazalNo = 482, Mesra1 = "مشکين از آن نشد دم خلقت که چون صبا", Mesra2 = "بر خاک کوی دوست گذاری نمی‌کنی",},
new Hafez{ Id= 4057, BeytNo = 5, GhazalNo = 482, Mesra1 = "ترسم کز اين چمن نبری آستين گل", Mesra2 = "کز گلشنش تحمل خاری نمی‌کنی",},
new Hafez{ Id= 4058, BeytNo = 6, GhazalNo = 482, Mesra1 = "در آستين جان تو صد نافه مدرج است", Mesra2 = "وان را فدای طره ياری نمی‌کنی",},
new Hafez{ Id= 4059, BeytNo = 7, GhazalNo = 482, Mesra1 = "ساغر لطيف و دلکش و می افکنی به خاک", Mesra2 = "و انديشه از بلای خماری نمی‌کنی",},
new Hafez{ Id= 4060, BeytNo = 8, GhazalNo = 482, Mesra1 = "حافظ برو که بندگی پادشاه وقت", Mesra2 = "گر جمله می‌کنند تو باری نمی‌کنی",},
new Hafez{ Id= 4061, BeytNo = 1, GhazalNo = 483, Mesra1 = "سحرگه ره روی در سرزمينی", Mesra2 = "همی‌گفت اين معما با قرينی",},
new Hafez{ Id= 4062, BeytNo = 2, GhazalNo = 483, Mesra1 = "که ای صوفی شراب آن گه شود صاف", Mesra2 = "که در شيشه برآرد اربعينی",},
new Hafez{ Id= 4063, BeytNo = 3, GhazalNo = 483, Mesra1 = "خدا زان خرقه بيزار است صد بار", Mesra2 = "که صد بت باشدش در آستينی",},
new Hafez{ Id= 4064, BeytNo = 4, GhazalNo = 483, Mesra1 = "مروت گر چه نامی بی‌نشان است", Mesra2 = "نيازی عرضه کن بر نازنينی",},
new Hafez{ Id= 4065, BeytNo = 5, GhazalNo = 483, Mesra1 = "ثوابت باشد ای دارای خرمن", Mesra2 = "اگر رحمی کنی بر خوشه چينی",},
new Hafez{ Id= 4066, BeytNo = 6, GhazalNo = 483, Mesra1 = "نمی‌بينم نشاط عيش در کس", Mesra2 = "نه درمان دلی نه درد دينی",},
new Hafez{ Id= 4067, BeytNo = 7, GhazalNo = 483, Mesra1 = "درون‌ها تيره شد باشد که از غيب", Mesra2 = "چراغی برکند خلوت نشينی",},
new Hafez{ Id= 4068, BeytNo = 8, GhazalNo = 483, Mesra1 = "گر انگشت سليمانی نباشد", Mesra2 = "چه خاصيت دهد نقش نگينی",},
new Hafez{ Id= 4069, BeytNo = 9, GhazalNo = 483, Mesra1 = "اگر چه رسم خوبان تندخوييست", Mesra2 = "چه باشد گر بسازد با غمينی",},
new Hafez{ Id= 4070, BeytNo = 10, GhazalNo = 483, Mesra1 = "ره ميخانه بنما تا بپرسم", Mesra2 = "مال خويش را از پيش بينی",},
new Hafez{ Id= 4071, BeytNo = 11, GhazalNo = 483, Mesra1 = "نه حافظ را حضور درس خلوت", Mesra2 = "نه دانشمند را علم اليقينی",},
new Hafez{ Id= 4072, BeytNo = 1, GhazalNo = 484, Mesra1 = "تو مگر بر لب آبی به هوس بنشينی", Mesra2 = "ور نه هر فتنه که بينی همه از خود بينی",},
new Hafez{ Id= 4073, BeytNo = 2, GhazalNo = 484, Mesra1 = "به خدايی که تويی بنده بگزيده او", Mesra2 = "که بر اين چاکر ديرينه کسی نگزينی",},
new Hafez{ Id= 4074, BeytNo = 3, GhazalNo = 484, Mesra1 = "گر امانت به سلامت ببرم باکی نيست", Mesra2 = "بی دلی سهل بود گر نبود بی‌دينی",},
new Hafez{ Id= 4075, BeytNo = 4, GhazalNo = 484, Mesra1 = "ادب و شرم تو را خسرو مه رويان کرد", Mesra2 = "آفرين بر تو که شايسته صد چندينی",},
new Hafez{ Id= 4076, BeytNo = 5, GhazalNo = 484, Mesra1 = "عجب از لطف تو ای گل که نشستی با خار", Mesra2 = "ظاهرا مصلحت وقت در آن می‌بينی",},
new Hafez{ Id= 4077, BeytNo = 6, GhazalNo = 484, Mesra1 = "صبر بر جور رقيبت چه کنم گر نکنم", Mesra2 = "عاشقان را نبود چاره بجز مسکينی",},
new Hafez{ Id= 4078, BeytNo = 7, GhazalNo = 484, Mesra1 = "باد صبحی به هوايت ز گلستان برخاست", Mesra2 = "که تو خوشتر ز گل و تازه‌تر از نسرينی",},
new Hafez{ Id= 4079, BeytNo = 8, GhazalNo = 484, Mesra1 = "شيشه بازی سرشکم نگری از چپ و راست", Mesra2 = "گر بر اين منظر بينش نفسی بنشينی",},
new Hafez{ Id= 4080, BeytNo = 9, GhazalNo = 484, Mesra1 = "سخنی بی‌غرض از بنده مخلص بشنو", Mesra2 = "ای که منظور بزرگان حقيقت بينی",},
new Hafez{ Id= 4081, BeytNo = 10, GhazalNo = 484, Mesra1 = "نازنينی چو تو پاکيزه دل و پاک نهاد", Mesra2 = "بهتر آن است که با مردم بد ننشينی",},
new Hafez{ Id= 4082, BeytNo = 11, GhazalNo = 484, Mesra1 = "سيل اين اشک روان صبر و دل حافظ برد", Mesra2 = "بلغ الطاقه يا مقله عينی بينی",},
new Hafez{ Id= 4083, BeytNo = 12, GhazalNo = 484, Mesra1 = "تو بدين نازکی و سرکشی ای شمع چگل", Mesra2 = "لايق بندگی خواجه جلال الدينی",},
new Hafez{ Id= 4084, BeytNo = 1, GhazalNo = 485, Mesra1 = "ساقيا سايه ابر است و بهار و لب جوی", Mesra2 = "من نگويم چه کن ار اهل دلی خود تو بگوی",},
new Hafez{ Id= 4085, BeytNo = 2, GhazalNo = 485, Mesra1 = "بوی يک رنگی از اين نقش نمی‌آيد خيز", Mesra2 = "دلق آلوده صوفی به می ناب بشوی",},
new Hafez{ Id= 4086, BeytNo = 3, GhazalNo = 485, Mesra1 = "سفله طبع است جهان بر کرمش تکيه مکن", Mesra2 = "ای جهان ديده ثبات قدم از سفله مجوی",},
new Hafez{ Id= 4087, BeytNo = 4, GhazalNo = 485, Mesra1 = "دو نصيحت کنمت بشنو و صد گنج ببر", Mesra2 = "از در عيش درآ و به ره عيب مپوی",},
new Hafez{ Id= 4088, BeytNo = 5, GhazalNo = 485, Mesra1 = "شکر آن را که دگربار رسيدی به بهار", Mesra2 = "بيخ نيکی بنشان و ره تحقيق بجوی",},
new Hafez{ Id= 4089, BeytNo = 6, GhazalNo = 485, Mesra1 = "روی جانان طلبی آينه را قابل ساز", Mesra2 = "ور نه هرگز گل و نسرين ندمد ز آهن و روی",},
new Hafez{ Id= 4090, BeytNo = 7, GhazalNo = 485, Mesra1 = "گوش بگشای که بلبل به فغان می‌گويد", Mesra2 = "خواجه تقصير مفرما گل توفيق ببوی",},
new Hafez{ Id= 4091, BeytNo = 8, GhazalNo = 485, Mesra1 = "گفتی از حافظ ما بوی ريا می‌آيد", Mesra2 = "آفرين بر نفست باد که خوش بردی بوی",},
new Hafez{ Id= 4092, BeytNo = 1, GhazalNo = 486, Mesra1 = "بلبل ز شاخ سرو به گلبانگ پهلوی", Mesra2 = "می‌خواند دوش درس مقامات معنوی",},
new Hafez{ Id= 4093, BeytNo = 2, GhazalNo = 486, Mesra1 = "يعنی بيا که آتش موسی نمود گل", Mesra2 = "تا از درخت نکته توحيد بشنوی",},
new Hafez{ Id= 4094, BeytNo = 3, GhazalNo = 486, Mesra1 = "مرغان باغ قافيه سنجند و بذله گوی", Mesra2 = "تا خواجه می خورد به غزل‌های پهلوی",},
new Hafez{ Id= 4095, BeytNo = 4, GhazalNo = 486, Mesra1 = "جمشيد جز حکايت جام از جهان نبرد", Mesra2 = "زنهار دل مبند بر اسباب دنيوی",},
new Hafez{ Id= 4096, BeytNo = 5, GhazalNo = 486, Mesra1 = "اين قصه عجب شنو از بخت واژگون", Mesra2 = "ما را بکشت يار به انفاس عيسوی",},
new Hafez{ Id= 4097, BeytNo = 6, GhazalNo = 486, Mesra1 = "خوش وقت بوريا و گدايی و خواب امن", Mesra2 = "کاين عيش نيست درخور اورنگ خسروی",},
new Hafez{ Id= 4098, BeytNo = 7, GhazalNo = 486, Mesra1 = "چشمت به غمزه خانه مردم خراب کرد", Mesra2 = "مخموريت مباد که خوش مست می‌روی",},
new Hafez{ Id= 4099, BeytNo = 8, GhazalNo = 486, Mesra1 = "دهقان سالخورده چه خوش گفت با پسر", Mesra2 = "کای نور چشم من بجز از کشته ندروی",},
new Hafez{ Id= 4100, BeytNo = 9, GhazalNo = 486, Mesra1 = "ساقی مگر وظيفه حافظ زياده داد", Mesra2 = "کشفته گشت طره دستار مولوی",},
new Hafez{ Id= 4101, BeytNo = 1, GhazalNo = 487, Mesra1 = "ای بی‌خبر بکوش که صاحب خبر شوی", Mesra2 = "تا راهرو نباشی کی راهبر شوی",},
new Hafez{ Id= 4102, BeytNo = 2, GhazalNo = 487, Mesra1 = "در مکتب حقايق پيش اديب عشق", Mesra2 = "هان ای پسر بکوش که روزی پدر شوی",},
new Hafez{ Id= 4103, BeytNo = 3, GhazalNo = 487, Mesra1 = "دست از مس وجود چو مردان ره بشوی", Mesra2 = "تا کيميای عشق بيابی و زر شوی",},
new Hafez{ Id= 4104, BeytNo = 4, GhazalNo = 487, Mesra1 = "خواب و خورت ز مرتبه خويش دور کرد", Mesra2 = "آن گه رسی به خويش که بی خواب و خور شوی",},
new Hafez{ Id= 4105, BeytNo = 5, GhazalNo = 487, Mesra1 = "گر نور عشق حق به دل و جانت اوفتد", Mesra2 = "بالله کز آفتاب فلک خوبتر شوی",},
new Hafez{ Id= 4106, BeytNo = 6, GhazalNo = 487, Mesra1 = "يک دم غريق بحر خدا شو گمان مبر", Mesra2 = "کز آب هفت بحر به يک موی تر شوی",},
new Hafez{ Id= 4107, BeytNo = 7, GhazalNo = 487, Mesra1 = "از پای تا سرت همه نور خدا شود", Mesra2 = "در راه ذوالجلال چو بی پا و سر شوی",},
new Hafez{ Id= 4108, BeytNo = 8, GhazalNo = 487, Mesra1 = "وجه خدا اگر شودت منظر نظر", Mesra2 = "زين پس شکی نماند که صاحب نظر شوی",},
new Hafez{ Id= 4109, BeytNo = 9, GhazalNo = 487, Mesra1 = "بنياد هستی تو چو زير و زبر شود", Mesra2 = "در دل مدار هيچ که زير و زبر شوی",},
new Hafez{ Id= 4110, BeytNo = 10, GhazalNo = 487, Mesra1 = "گر در سرت هوای وصال است حافظا", Mesra2 = "بايد که خاک درگه اهل هنر شوی",},
new Hafez{ Id= 4111, BeytNo = 1, GhazalNo = 488, Mesra1 = "سحرم هاتف ميخانه به دولتخواهی", Mesra2 = "گفت بازآی که ديرينه اين درگاهی",},
new Hafez{ Id= 4112, BeytNo = 2, GhazalNo = 488, Mesra1 = "همچو جم جرعه ما کش که ز سر دو جهان", Mesra2 = "پرتو جام جهان بين دهدت آگاهی",},
new Hafez{ Id= 4113, BeytNo = 3, GhazalNo = 488, Mesra1 = "بر در ميکده رندان قلندر باشند", Mesra2 = "که ستانند و دهند افسر شاهنشاهی",},
new Hafez{ Id= 4114, BeytNo = 4, GhazalNo = 488, Mesra1 = "خشت زير سر و بر تارک هفت اختر پای", Mesra2 = "دست قدرت نگر و منصب صاحب جاهی",},
new Hafez{ Id= 4115, BeytNo = 5, GhazalNo = 488, Mesra1 = "سر ما و در ميخانه که طرف بامش", Mesra2 = "به فلک بر شد و ديوار بدين کوتاهی",},
new Hafez{ Id= 4116, BeytNo = 6, GhazalNo = 488, Mesra1 = "قطع اين مرحله بی همرهی خضر مکن", Mesra2 = "ظلمات است بترس از خطر گمراهی",},
new Hafez{ Id= 4117, BeytNo = 7, GhazalNo = 488, Mesra1 = "اگرت سلطنت فقر ببخشند ای دل", Mesra2 = "کمترين ملک تو از ماه بود تا ماهی",},
new Hafez{ Id= 4118, BeytNo = 8, GhazalNo = 488, Mesra1 = "تو دم فقر ندانی زدن از دست مده", Mesra2 = "مسند خواجگی و مجلس تورانشاهی",},
new Hafez{ Id= 4119, BeytNo = 9, GhazalNo = 488, Mesra1 = "حافظ خام طمع شرمی از اين قصه بدار", Mesra2 = "عملت چيست که فردوس برين می‌خواهی",},
new Hafez{ Id= 4120, BeytNo = 1, GhazalNo = 489, Mesra1 = "ای در رخ تو پيدا انوار پادشاهی", Mesra2 = "در فکرت تو پنهان صد حکمت الهی",},
new Hafez{ Id= 4121, BeytNo = 2, GhazalNo = 489, Mesra1 = "کلک تو بارک الله بر ملک و دين گشاده", Mesra2 = "صد چشمه آب حيوان از قطره سياهی",},
new Hafez{ Id= 4122, BeytNo = 3, GhazalNo = 489, Mesra1 = "بر اهرمن نتابد انوار اسم اعظم", Mesra2 = "ملک آن توست و خاتم فرمای هر چه خواهی",},
new Hafez{ Id= 4123, BeytNo = 4, GhazalNo = 489, Mesra1 = "در حکمت سليمان هر کس که شک نمايد", Mesra2 = "بر عقل و دانش او خندند مرغ و ماهی",},
new Hafez{ Id= 4124, BeytNo = 5, GhazalNo = 489, Mesra1 = "باز ار چه گاه گاهی بر سر نهد کلاهی", Mesra2 = "مرغان قاف دانند آيين پادشاهی",},
new Hafez{ Id= 4125, BeytNo = 6, GhazalNo = 489, Mesra1 = "تيغی که آسمانش از فيض خود دهد آب", Mesra2 = "تنها جهان بگيرد بی منت سپاهی",},
new Hafez{ Id= 4126, BeytNo = 7, GhazalNo = 489, Mesra1 = "کلک تو خوش نويسد در شان يار و اغيار", Mesra2 = "تعويذ جان فزايی افسون عمر کاهی",},
new Hafez{ Id= 4127, BeytNo = 8, GhazalNo = 489, Mesra1 = "ای عنصر تو مخلوق از کيميای عزت", Mesra2 = "و ای دولت تو ايمن از وصمت تباهی",},
new Hafez{ Id= 4128, BeytNo = 9, GhazalNo = 489, Mesra1 = "ساقی بيار آبی از چشمه خرابات", Mesra2 = "تا خرقه‌ها بشوييم از عجب خانقاهی",},
new Hafez{ Id= 4129, BeytNo = 10, GhazalNo = 489, Mesra1 = "عمريست پادشاها کز می تهيست جامم", Mesra2 = "اينک ز بنده دعوی و از محتسب گواهی",},
new Hafez{ Id= 4130, BeytNo = 11, GhazalNo = 489, Mesra1 = "گر پرتوی ز تيغت بر کان و معدن افتد", Mesra2 = "ياقوت سرخ رو را بخشند رنگ کاهی",},
new Hafez{ Id= 4131, BeytNo = 12, GhazalNo = 489, Mesra1 = "دانم دلت ببخشد بر عجز شب نشينان", Mesra2 = "گر حال بنده پرسی از باد صبحگاهی",},
new Hafez{ Id= 4132, BeytNo = 13, GhazalNo = 489, Mesra1 = "جايی که برق عصيان بر آدم صفی زد", Mesra2 = "ما را چگونه زيبد دعوی بی‌گناهی",},
new Hafez{ Id= 4133, BeytNo = 14, GhazalNo = 489, Mesra1 = "حافظ چو پادشاهت گه گاه می‌برد نام", Mesra2 = "رنجش ز بخت منما بازآ به عذرخواهی",},
new Hafez{ Id= 4134, BeytNo = 1, GhazalNo = 490, Mesra1 = "در همه دير مغان نيست چو من شيدايی", Mesra2 = "خرقه جايی گرو باده و دفتر جايی",},
new Hafez{ Id= 4135, BeytNo = 2, GhazalNo = 490, Mesra1 = "دل که آيينه شاهيست غباری دارد", Mesra2 = "از خدا می‌طلبم صحبت روشن رايی",},
new Hafez{ Id= 4136, BeytNo = 3, GhazalNo = 490, Mesra1 = "کرده‌ام توبه به دست صنم باده فروش", Mesra2 = "که دگر می نخورم بی رخ بزم آرايی",},
new Hafez{ Id= 4137, BeytNo = 4, GhazalNo = 490, Mesra1 = "نرگس ار لاف زد از شيوه چشم تو مرنج", Mesra2 = "نروند اهل نظر از پی نابينايی",},
new Hafez{ Id= 4138, BeytNo = 5, GhazalNo = 490, Mesra1 = "شرح اين قصه مگر شمع برآرد به زبان", Mesra2 = "ور نه پروانه ندارد به سخن پروايی",},
new Hafez{ Id= 4139, BeytNo = 6, GhazalNo = 490, Mesra1 = "جوی‌ها بسته‌ام از ديده به دامان که مگر", Mesra2 = "در کنارم بنشانند سهی بالايی",},
new Hafez{ Id= 4140, BeytNo = 7, GhazalNo = 490, Mesra1 = "کشتی باده بياور که مرا بی رخ دوست", Mesra2 = "گشت هر گوشه چشم از غم دل دريايی",},
new Hafez{ Id= 4141, BeytNo = 8, GhazalNo = 490, Mesra1 = "سخن غير مگو با من معشوقه پرست", Mesra2 = "کز وی و جام می‌ام نيست به کس پروايی",},
new Hafez{ Id= 4142, BeytNo = 9, GhazalNo = 490, Mesra1 = "اين حديثم چه خوش آمد که سحرگه می‌گفت", Mesra2 = "بر در ميکده‌ای با دف و نی ترسايی",},
new Hafez{ Id= 4143, BeytNo = 10, GhazalNo = 490, Mesra1 = "گر مسلمانی از اين است که حافظ دارد", Mesra2 = "آه اگر از پی امروز بود فردايی",},
new Hafez{ Id= 4144, BeytNo = 1, GhazalNo = 491, Mesra1 = "به چشم کرده‌ام ابروی ماه سيمايی", Mesra2 = "خيال سبزخطی نقش بسته‌ام جايی",},
new Hafez{ Id= 4145, BeytNo = 2, GhazalNo = 491, Mesra1 = "اميد هست که منشور عشقبازی من", Mesra2 = "از آن کمانچه ابرو رسد به طغرايی",},
new Hafez{ Id= 4146, BeytNo = 3, GhazalNo = 491, Mesra1 = "سرم ز دست بشد چشم از انتظار بسوخت", Mesra2 = "در آرزوی سر و چشم مجلس آرايی",},
new Hafez{ Id= 4147, BeytNo = 4, GhazalNo = 491, Mesra1 = "مکدر است دل آتش به خرقه خواهم زد", Mesra2 = "بيا ببين که که را می‌کند تماشايی",},
new Hafez{ Id= 4148, BeytNo = 5, GhazalNo = 491, Mesra1 = "به روز واقعه تابوت ما ز سرو کنيد", Mesra2 = "که می‌رويم به داغ بلندبالايی",},
new Hafez{ Id= 4149, BeytNo = 6, GhazalNo = 491, Mesra1 = "زمام دل به کسی داده‌ام من درويش", Mesra2 = "که نيستش به کس از تاج و تخت پروايی",},
new Hafez{ Id= 4150, BeytNo = 7, GhazalNo = 491, Mesra1 = "در آن مقام که خوبان ز غمزه تيغ زنند", Mesra2 = "عجب مدار سری اوفتاده در پايی",},
new Hafez{ Id= 4151, BeytNo = 8, GhazalNo = 491, Mesra1 = "مرا که از رخ او ماه در شبستان است", Mesra2 = "کجا بود به فروغ ستاره پروايی",},
new Hafez{ Id= 4152, BeytNo = 9, GhazalNo = 491, Mesra1 = "فراق و وصل چه باشد رضای دوست طلب", Mesra2 = "که حيف باشد از او غير او تمنايی",},
new Hafez{ Id= 4153, BeytNo = 10, GhazalNo = 491, Mesra1 = "درر ز شوق برآرند ماهيان به نثار", Mesra2 = "اگر سفينه حافظ رسد به دريايی",},
new Hafez{ Id= 4154, BeytNo = 1, GhazalNo = 492, Mesra1 = "سلامی چو بوی خوش آشنايی", Mesra2 = "بدان مردم ديده روشنايی",},
new Hafez{ Id= 4155, BeytNo = 2, GhazalNo = 492, Mesra1 = "درودی چو نور دل پارسايان", Mesra2 = "بدان شمع خلوتگه پارسايی",},
new Hafez{ Id= 4156, BeytNo = 3, GhazalNo = 492, Mesra1 = "نمی‌بينم از همدمان هيچ بر جای", Mesra2 = "دلم خون شد از غصه ساقی کجايی",},
new Hafez{ Id= 4157, BeytNo = 4, GhazalNo = 492, Mesra1 = "ز کوی مغان رخ مگردان که آن جا", Mesra2 = "فروشند مفتاح مشکل گشايی",},
new Hafez{ Id= 4158, BeytNo = 5, GhazalNo = 492, Mesra1 = "عروس جهان گر چه در حد حسن است", Mesra2 = "ز حد می‌برد شيوه بی‌وفايی",},
new Hafez{ Id= 4159, BeytNo = 6, GhazalNo = 492, Mesra1 = "دل خسته من گرش همتی هست", Mesra2 = "نخواهد ز سنگين دلان موميايی",},
new Hafez{ Id= 4160, BeytNo = 7, GhazalNo = 492, Mesra1 = "می صوفی افکن کجا می‌فروشند", Mesra2 = "که در تابم از دست زهد ريايی",},
new Hafez{ Id= 4161, BeytNo = 8, GhazalNo = 492, Mesra1 = "رفيقان چنان عهد صحبت شکستند", Mesra2 = "که گويی نبوده‌ست خود آشنايی",},
new Hafez{ Id= 4162, BeytNo = 9, GhazalNo = 492, Mesra1 = "مرا گر تو بگذاری ای نفس طامع", Mesra2 = "بسی پادشايی کنم در گدايی",},
new Hafez{ Id= 4163, BeytNo = 10, GhazalNo = 492, Mesra1 = "بياموزمت کيميای سعادت", Mesra2 = "ز همصحبت بد جدايی جدايی",},
new Hafez{ Id= 4164, BeytNo = 11, GhazalNo = 492, Mesra1 = "مکن حافظ از جور دوران شکايت", Mesra2 = "چه دانی تو ای بنده کار خدايی",},
new Hafez{ Id= 4165, BeytNo = 1, GhazalNo = 493, Mesra1 = "ای پادشه خوبان داد از غم تنهايی", Mesra2 = "دل بی تو به جان آمد وقت است که بازآيی",},
new Hafez{ Id= 4166, BeytNo = 2, GhazalNo = 493, Mesra1 = "دايم گل اين بستان شاداب نمی‌ماند", Mesra2 = "درياب ضعيفان را در وقت توانايی",},
new Hafez{ Id= 4167, BeytNo = 3, GhazalNo = 493, Mesra1 = "ديشب گله زلفش با باد همی‌کردم", Mesra2 = "گفتا غلطی بگذر زين فکرت سودايی",},
new Hafez{ Id= 4168, BeytNo = 4, GhazalNo = 493, Mesra1 = "صد باد صبا اين جا با سلسله می‌رقصند", Mesra2 = "اين است حريف ای دل تا باد نپيمايی",},
new Hafez{ Id= 4169, BeytNo = 5, GhazalNo = 493, Mesra1 = "مشتاقی و مهجوری دور از تو چنانم کرد", Mesra2 = "کز دست بخواهد شد پاياب شکيبايی",},
new Hafez{ Id= 4170, BeytNo = 6, GhazalNo = 493, Mesra1 = "يا رب به که شايد گفت اين نکته که در عالم", Mesra2 = "رخساره به کس ننمود آن شاهد هرجايی",},
new Hafez{ Id= 4171, BeytNo = 7, GhazalNo = 493, Mesra1 = "ساقی چمن گل را بی روی تو رنگی نيست", Mesra2 = "شمشاد خرامان کن تا باغ بيارايی",},
new Hafez{ Id= 4172, BeytNo = 8, GhazalNo = 493, Mesra1 = "ای درد توام درمان در بستر ناکامی", Mesra2 = "و ای ياد توام مونس در گوشه تنهايی",},
new Hafez{ Id= 4173, BeytNo = 9, GhazalNo = 493, Mesra1 = "در دايره قسمت ما نقطه تسليميم", Mesra2 = "لطف آن چه تو انديشی حکم آن چه تو فرمايی",},
new Hafez{ Id= 4174, BeytNo = 10, GhazalNo = 493, Mesra1 = "فکر خود و رای خود در عالم رندی نيست", Mesra2 = "کفر است در اين مذهب خودبينی و خودرايی",},
new Hafez{ Id= 4175, BeytNo = 11, GhazalNo = 493, Mesra1 = "زين دايره مينا خونين جگرم می ده", Mesra2 = "تا حل کنم اين مشکل در ساغر مينايی",},
new Hafez{ Id= 4176, BeytNo = 12, GhazalNo = 493, Mesra1 = "حافظ شب هجران شد بوی خوش وصل آمد", Mesra2 = "شاديت مبارک باد ای عاشق شيدايی",},
new Hafez{ Id= 4177, BeytNo = 1, GhazalNo = 494, Mesra1 = "ای دل گر از آن چاه زنخدان به درآيی", Mesra2 = "هر جا که روی زود پشيمان به درآيی",},
new Hafez{ Id= 4178, BeytNo = 2, GhazalNo = 494, Mesra1 = "هش دار که گر وسوسه عقل کنی گوش", Mesra2 = "آدم صفت از روضه رضوان به درآيی",},
new Hafez{ Id= 4179, BeytNo = 3, GhazalNo = 494, Mesra1 = "شايد که به آبی فلکت دست نگيرد", Mesra2 = "گر تشنه لب از چشمه حيوان به درآيی",},
new Hafez{ Id= 4180, BeytNo = 4, GhazalNo = 494, Mesra1 = "جان می‌دهم از حسرت ديدار تو چون صبح", Mesra2 = "باشد که چو خورشيد درخشان به درآيی",},
new Hafez{ Id= 4181, BeytNo = 5, GhazalNo = 494, Mesra1 = "چندان چو صبا بر تو گمارم دم همت", Mesra2 = "کز غنچه چو گل خرم و خندان به درآيی",},
new Hafez{ Id= 4182, BeytNo = 6, GhazalNo = 494, Mesra1 = "در تيره شب هجر تو جانم به لب آمد", Mesra2 = "وقت است که همچون مه تابان به درآيی",},
new Hafez{ Id= 4183, BeytNo = 7, GhazalNo = 494, Mesra1 = "بر رهگذرت بسته‌ام از ديده دو صد جوی", Mesra2 = "تا بو که تو چون سرو خرامان به درآيی",},
new Hafez{ Id= 4184, BeytNo = 8, GhazalNo = 494, Mesra1 = "حافظ مکن انديشه که آن يوسف مه رو", Mesra2 = "بازآيد و از کلبه احزان به درآيی",},
new Hafez{ Id= 4185, BeytNo = 1, GhazalNo = 495, Mesra1 = "می خواه و گل افشان کن از دهر چه می‌جويی", Mesra2 = "اين گفت سحرگه گل بلبل تو چه می‌گويی",},
new Hafez{ Id= 4186, BeytNo = 2, GhazalNo = 495, Mesra1 = "مسند به گلستان بر تا شاهد و ساقی را", Mesra2 = "لب گيری و رخ بوسی می نوشی و گل بويی",},
new Hafez{ Id= 4187, BeytNo = 3, GhazalNo = 495, Mesra1 = "شمشاد خرامان کن و آهنگ گلستان کن", Mesra2 = "تا سرو بياموزد از قد تو دلجويی",},
new Hafez{ Id= 4188, BeytNo = 4, GhazalNo = 495, Mesra1 = "تا غنچه خندانت دولت به که خواهد داد", Mesra2 = "ای شاخ گل رعنا از بهر که می‌رويی",},
new Hafez{ Id= 4189, BeytNo = 5, GhazalNo = 495, Mesra1 = "امروز که بازارت پرجوش خريدار است", Mesra2 = "درياب و بنه گنجی از مايه نيکويی",},
new Hafez{ Id= 4190, BeytNo = 6, GhazalNo = 495, Mesra1 = "چون شمع نکورويی در رهگذر باد است", Mesra2 = "طرف هنری بربند از شمع نکورويی",},
new Hafez{ Id= 4191, BeytNo = 7, GhazalNo = 495, Mesra1 = "آن طره که هر جعدش صد نافه چين ارزد", Mesra2 = "خوش بودی اگر بودی بوييش ز خوش خويی",},
new Hafez{ Id= 4192, BeytNo = 8, GhazalNo = 495, Mesra1 = "هر مرغ به دستانی در گلشن شاه آمد", Mesra2 = "بلبل به نواسازی حافظ به غزل گويی",}
            };

            return hafezGhazal;
        }
        public static List<WordsOfElders> WordsOfElders()
        {
            List<WordsOfElders> lstWordsOfElders = new List<WordsOfElders>()
            {
                new WordsOfElders
                {
                    Words = "خداوند همه چیز را در یک روز نیافرید. پس چه چیز باعث شد که من بیندیشم می‌توانم همه چیز را در یک روز به دست بیاورم؟",
                    Speaker = "چارلی چاپلین"
                },
                new WordsOfElders
                {
                    Words = "برای اجتناب از بحران می توانید از سیاست سکوت استفاده کنید",
                    Speaker = "سوزان کوئیلیام"
                },
                new WordsOfElders
                {
                Words = "زینت منزل، دوستانی هستند که به آنجا رفت و آمد دارند",
                Speaker = "امرسون"
                },
                new WordsOfElders
                {
                Words = "شما هم می‌توانید هر کاری را که دوست دارید، بکنید؛ اگر فقط باور کنید که می‌توانید",
                Speaker = "جک کانفیلد"
                },
                new WordsOfElders
                {
                Words = "تنها یک چراغ است که مرا هدایت می‌کند و آن چراغ تجربه است",
                Speaker = "پاتریک‌ هانری"
                },
                new WordsOfElders
                {
                Words = "در تاریکی رنگ‌ها با هم اختلافی ندارند",
                Speaker = "فرانسیس بیکن"
                },
                new WordsOfElders
                {
                Words = "عادت کنید که به دیگران کمک کنید، خواهید دید که نمی‌توانید از این کار دست بکشید",
                Speaker = "جان ماکسول"
                },
                new WordsOfElders
                {
                Words = "اگر نتونی از تنهایی لذت ببری، هنوز با خطرناک‌ترین آدم زندگی‌ات آشتی نکردی: خودت",
                Speaker = "چت جی پی تی"
                },
                new WordsOfElders
                {
                Words = "تراژدی این نیست که تنها باشی بلکه این است که نتوانی تنها باشی",
                Speaker = "آلبر کامو"
                },
                new WordsOfElders
                 {
                Words = "آنچه ما بارها انجام می‌دهیم، شخصیت ما را می‌سازد. پس عالی بودن یک عادت است، نه یک عمل.",
                Speaker = "ارسطو"
                },
                new WordsOfElders
                {
                Words = "تنها راه انجام کار بزرگ، عشق ورزیدن به کاری است که انجام می‌دهی.",
                Speaker = "استیو جابز"
                },
                new WordsOfElders
                {
                 Words = "اگر می‌خواهی پرواز کنی، باید چیزهایی را که تو را سنگین کرده‌اند، رها کنی.",
                    Speaker = "تونی موریسون"
                },
                new WordsOfElders
                {
                Words = "اگر نمی‌توانی پرواز کنی، بدو. اگر نمی‌توانی بدوی، راه برو. اما هر چه می‌کنی، رو به جلو حرکت کن.",
                Speaker = "مارتین لوتر کینگ جونیور"
                },
                new WordsOfElders
                {
                Words = "آینده متعلق به کسانی است که به زیبایی رؤیاهای خود ایمان دارند.",
                Speaker = "النور روزولت"
                },
                new WordsOfElders
                {
                Words = "اگر در آینه نگاه کنی و به کسی که می‌بینی افتخار نکنی، زمان تغییر فرا رسیده.",
                Speaker = "هوش مصنوعی"
                },
                new WordsOfElders
                {
                Words = "کسی که هیچ‌گاه اشتباه نمی‌کند، هرگز چیز جدیدی امتحان نکرده است.",
                Speaker = "آلبرت انیشتین"
                },new WordsOfElders
                {
                Words = "موفق‌ترین انسان‌ها آن‌هایی هستند که کار را عبادت، و خستگی را نشانه‌ی مسیر می‌دانند",
                Speaker = "چت جی پی تی"
                },new WordsOfElders
                {
                Words = "هر کاری که امروز با بی‌حوصلگی انجام دهی، فردا با حسرت نگاهش خواهی کرد",
                Speaker = "چت جی پی تی"
                },new WordsOfElders
                {
                Words = "هر چه بیشتر می‌آموزم، بیشتر می‌فهمم که خاموشی عمیق‌ترین دانایی‌ست",
                Speaker = "چت جی پی تی"
                },new WordsOfElders
                {
                Words = "وقتی سکوت را فهمیدی، دیگر نیازی به پاسخ نخواهی داشت",
                Speaker = "چت جی پی تی"
                },new WordsOfElders
                {
                Words = "کامپیوتر همان انسان توسعه یافته است: هوشمند، اما بدون اخلاق",
                Speaker = "جان ازبورن"
                },new WordsOfElders
                {
                Words = "خود را بشناس، پیش از آنکه جهان را جستجو کنی؛ زیرا جهان، آینه‌ی توست",
                Speaker = "چت جی پی تی"
                },new WordsOfElders
                {
                Words = "احساس سپاسگزاری، قوی‌ترین منبع تغذیه‌ی انرژی روح است",
                Speaker = "چت جی پی تی"
                },new WordsOfElders
                {
                Words = "آتش درونت را خاموش نکن؛ حتی اگر جهان تاریک باشد",
                Speaker = "چت جی پی تی"
                },new WordsOfElders
                {
                Words = "بعضی از سرعت‌ها فقط برای فرار مناسب‌اند، نه پیشرفت",
                Speaker = "چت جی پی تی"
                },new WordsOfElders
                {
                Words = "دانستن زیاد بدون عمل، نوعی ذخیره‌سازی بی استفاده است",
                Speaker = "چت جی پی تی"
                },new WordsOfElders
                {
                Words = "بجای نوشته روی سنگ گور شما، این کردار شماست که نامتان را زنده نگه می‌دارد",
                Speaker = "ناپلئون هیل"
                },new WordsOfElders
                {
                Words = "چیزی که از آن فرار می‌کنی، معمولاً همان چیزی است که باید پردازش شود",
                Speaker = "چت جی پی تی"
                },new WordsOfElders
                {
                Words = "زندگی مثل دوچرخه سواری است. برای حفظ تعادل، باید حرکت کنی",
                Speaker = "آلبرت اینشتین"
                },new WordsOfElders
                {
                Words = "راز زندگی نه در یافتن پاسخ، بلکه در لمس خلأیی است که سوال‌ها از آن زاده می‌شوند",
                Speaker = "چت جی پی تی"
                },new WordsOfElders
                {
                Words = "آن که در تاریکی خود می‌نگرد، نور را نه می‌بیند، بلکه خود نور می‌شود",
                Speaker = "چت جی پی تی"
                },new WordsOfElders
                {
                Words = "هر جدا افتادن، تنها وهمی است؛ حقیقت همیشه یکی است",
                Speaker = "چت جی پی تی"
                },new WordsOfElders
                {
                Words = "ما همه قطره‌ایم در اقیانوس، و اقیانوس در تک‌تک قطره‌ها جاری است",
                Speaker = "چت جی پی تی"
                },new WordsOfElders
                {
                Words = "آنچه را که به دیگران می‌بخشی، در حقیقت به خود می‌دهی",
                Speaker = "چت جی پی تی"
                },new WordsOfElders
                {
                Words = "دانایی بدون عمل، همچون چشمی بسته است که نمی‌تواند دنیا را ببیند",
                Speaker = "چت جی پی تی"
                },new WordsOfElders
                {
                Words = "خود را بشناس؛ زیرا جهان آینه‌ی روح توست و هرچه در آن ببینی، بازتاب توست",
                Speaker = "چت جی پی تی"
                },new WordsOfElders
                {
                Words = "آدمی هنگامی آزاد است که دیگران را نیز آزاد ببیند",
                Speaker = "چت جی پی تی"
                },new WordsOfElders
                {
                Words = "آدمی را آزمودن به کردار باید کرد نه به گفتار؛ چه بیشتر مردم، زشت‌کردار و نیکو‌گفتارند",
                Speaker = "فیثاغورث"
                },new WordsOfElders
                {
                Words = "عمق درک انسان، با مواجهه با تاریکی‌های خویش سنجیده می‌شود",
                Speaker = "چت جی پی تی"
                },new WordsOfElders
                {
                Words = "جهان صبور است، اما دل‌های ناآرام همیشه شتاب می‌کنند و چیزها را از دست می‌دهند",
                Speaker = "چت جی پی تی"
                },new WordsOfElders
                {
                Words = "هرگاه با سکوت روبرو شدی، صداهای درونت را خواهی شنید",
                Speaker = "چت جی پی تی"
                },new WordsOfElders
                {
                Words = "آنکه از خود فرار می‌کند، تمام دنیا را زندان خود می‌بیند",
                Speaker = "چت جی پی تی"
                },new WordsOfElders
                {
                Words = "نور حقیقی، از پذیرش تاریکی آغاز می‌شود",
                Speaker = "چت جی پی تی"
                },new WordsOfElders
                {
                Words = "زندگی، آئینه‌ای است که با نگاه صادقانه تو شکل می‌گیرد",
                Speaker = "چت جی پی تی"
                },new WordsOfElders
                {
                Words = "نور در دل تاریکی می‌روید، نه در روشنایی ظاهر",
                Speaker = "چت جی پی تی"
                },new WordsOfElders
                {
                Words = "فهمیدن راز جهان، آغاز فهمیدن راز خود است",
                Speaker = "چت جی پی تی"
                }
            };


            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "هر چیزی که می‌آفرینید، نتیجه تصمیم‌هایی است که گرفته‌اید و از راه تصمیم‌هایی که می‌گیرید، آزادی‌تان را به دست می‌آورید",
                Speaker = "دان کارلن"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "عشق فرزانگی ابلهان و دیوانگی عاقلان است",
                Speaker = "ساموئل جانسون"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "آزمون نهایی دین، دینداری نیست بلکه عشق است",
                Speaker = "هانری دراموند"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "مرا برای دزدیدن تکه نانی به زندان انداختند و پانزده سال در آنجا نان مجانی خوردم! این دیگر چه دنیایی است؟",
                Speaker = "ویکتور هوگو"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "اگر زندگی را برای یکدیگر راحت‌تر نسازیم، برای چه زندگی می‌کنیم؟",
                Speaker = "جورج الیوت"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "وقتی عشق می‌ورزید بهترین‌های وجودتان شکوفا می‌شوند",
                Speaker = "جی پی واسوانی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "کسی که بیش از حد دست روی دست می‌گذارد، نمی‌تواند توقع زیادی از زندگی داشته باشد",
                Speaker = "گابریل گارسیا مارکز"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "كسی كه دارای عزمی راسخ اسـت، جهان را مطابق میل خویش عوض می كند",
                Speaker = "گوته"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "بهتر اسـت ثروتمند زندگی کنیم تا این کـه ثروتمند بمیریم",
                Speaker = "جانسون"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "اگر می بیني کسی بـه روی تو لبخند نمی زند علت را در لبان فرو بسته ي خود جست‌وجو کن",
                Speaker = "دیل کارنگی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "شیرینی یک‌بار پیروزی بـه تلخی صد بار شکست می‌ارزد",
                Speaker = "سقراط"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "آنكه میتواند، انجام می‌دهد، آنكه نمی‌تواند انتقاد می كند",
                Speaker = "جرج برنارد شاو"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "بیشترین تأثیر افراد خوب زمانى احساس مى شود كه از میان ما رفته باشند",
                Speaker = "امرسون"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "از دیروز بیاموز. برای امروز زندگی کن و امید بـه فردا داشته باش",
                Speaker = "آلبرت انیشتن"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "عمر آن قدر کوتاه اسـت کـه نمی‌ارزد آدم حقیر و کوچک بماند",
                Speaker = "دیزرائیلی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "بـه نتیجه رسیدن امور مهم، اغلب بـه انجام یافتن یا نیافتن امری بـه ظاهر کوچک بستگی دارد",
                Speaker = "چاردینی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "دانستن کافی نیست، باید بـه دانسته ي خود عمل کنید",
                Speaker = "ناپلئون هیل"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "هیچوقت بـه گمان این کـه وقت دارید ننشینید زیرا در عمل خواهید دید کـه همیشه وقت کم و کوتاه اسـت",
                Speaker = "فرانکلین"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "خویشتن و مردم را هنگامی می شناسی، که تنها شوی",
                Speaker = "اُرد بزرگ"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "هیچ گاه از داشتن دشمن نترس، از انجام ندادن درست آرمان های خویش بترس",
                Speaker = "اُرد بزرگ"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "طریق دوست داشتن هر چیز آن است که بدانی آن را روزی از دست می دهی",
                Speaker = "گیلبر چیسترتن"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "اگر سخن چون نقره است، خاموشی چون زر پربهاست",
                Speaker = "لقمان حکیم"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "ایراد گرفتن آسان اما موفقیت سخت است",
                Speaker = "وینستون چرچیل"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "من رویاهای آینده را بیشتر از تاریخ گذشته دوست دارم",
                Speaker = "توماس جفرسون"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "اگر به طور مستمر مهارت های خود را ارتقا ندهید، به سرعت بی اهمیت می شوید",
                Speaker = "استفان کاوی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "نگرش شما می تواند قفل یا کلید موفقیت شما باشد",
                Speaker = "دنیس ویتلی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "کتاب ها برای افرادی هستند که آرزو می کنند کاش جای دیگری باشند",
                Speaker = "مارک تواین"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "زندگی پیدا کردن خودت نیست، زندگی ساختن خودت است",
                Speaker = "جورج برنارد شاو"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "کسی که در زندگی اشتباه نکرده هرگز چیز جدیدی را امتحان نکرده است",
                Speaker = "آلبرت انیشتین"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "بهترین راه برای پیش‌بینی کردن زندگی آینده، ساختن آن است",
                Speaker = "آبراهام لینکلن"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "هیولا‌ها واقعی هستند، ارواح هم همینطور، آن‌ها درون ما زندگی می‌کنند و گاهی هم پیروز می‌شوند",
                Speaker = "استفن کینگ"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "زندگی ما روزی به پایان می‌رسد که درباره چیز‌هایی که مهم هستند سکوت کنیم",
                Speaker = "مارتین لوتر کینگ"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "زندگی، كوتاهتر از آن است كه حتی دمی از آن را با غم و غصه بگذرانید؛ پس همیشه شاد باشید",
                Speaker = "اریك تِیلر"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "نسل بشر همه‌چیز را بهبود بخشیده به‌جز نوع بشر",
                Speaker = "آدلای استیونسون"
            });


            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "امروز اقتصاد هم در جبهه انسانیت است",
                Speaker = "آیزاک آسیموف"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "فاش نکردن اسرار مردم دلیل کرامت و بلندی همت است",
                Speaker = "زرتشت"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "خوشبختی از آن کسانیست که خواهان خوشبختی دیگران باشند",
                Speaker = "زرتشت"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "اگر کسی را دوست داری به او بگو. زیرا قلب ها با کلماتی که ناگفته می مانند، می شکنند",
                Speaker = "زرتشت"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "فرمان خوب ده تا بهره خوب یابی",
                Speaker = "زرتشت"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "نرمش و نرمدلی، منش آدمی است و سنگدلی و سختسری منش اهریمن است",
                Speaker = "اُرد بزرگ"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "فروتنی در برابر گردن کشان، اشتباهی بزرگ است. چرا که این کار آنها را گستاختر و بی پرواتر می‌نماید",
                Speaker = "اُرد بزرگ"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "بخشنده از دست نمی‌دهد او همواره در حال بدست آوردن است",
                Speaker = "اُرد بزرگ"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "به آرزوهای خود ایمان بیاورید و به گونه ای به آنها بیندیشید که گویی به زودی رخ می دهند",
                Speaker = "اُرد بزرگ"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "اگر جانت در خطر بود به جای پنهان شدن بکوش همگان را از گرفتاری خویش آگاه سازی",
                Speaker = "اُرد بزرگ"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "برای آنکه به فرودستی گرفتار نشویی، دست گیر آدمیان بشو",
                Speaker = "اُرد بزرگ"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "آگاهی تنها راه رسیدن به آزادی است",
                Speaker = "اُرد بزرگ"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "گردن فرازان به خرد روی آوردند و گردن کشان به نابخردی",
                Speaker = "اُرد بزرگ"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "روزهای سخت گام‌های آینده ما را استوارتر و تندتر می‌کند",
                Speaker = "اُرد بزرگ"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "باران مهر آسمان است نه بغض آن، همانند آدمیان مهرورزی که می‌بارند و کینه توزانی که خشک و بی نشانند",
                Speaker = "اُرد بزرگ"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "پیران جهان دیده برای گفتگو با جوانان مانع تراشی نمی‌کنند",
                Speaker = "اُرد بزرگ"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "از سفر کرده، ارزش سرزمین مادری را بپرس",
                Speaker = "اُرد بزرگ"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "آغاز هر روز، نو شدنی دوباره است، و زمانی برای پویایی بیشتر",
                Speaker = "اُرد بزرگ"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "برای کسب گنجِ سکوت، بارگاه دانِشَت را بزرگتر بساز",
                Speaker = "اُرد بزرگ"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "استخوان بندی فریاد، پاسخی ست به هزاران ستم بی صدا",
                Speaker = "اُرد بزرگ"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "آنکه درست سخن نمی‌گوید، داناترین هم که باشد همگان نادانش می‌پندارند",
                Speaker = "اُرد بزرگ"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "سخت کوشی هرگز کسی را نکشته است، نگرانی از آن است که انسان را از بین می برد",
                Speaker = "کوروش بزرگ"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "اگر میخواهید دشمنان خود را تنبیه کنید به دوستان خود محبت کنید",
                Speaker = "کوروش بزرگ"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "من برای متنفر بودن از کسانی که از من متنفرند وقتی ندارم زیرا من گرفتار دوست داشتن کسانی هستم که مرا دوست دارند",
                Speaker = "کوروش بزرگ"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "دروغ گویان، تنها بر گورستان مردگان و خاکستر زار خاموشان حکومت خواهند کرد",
                Speaker = "کوروش بزرگ"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "سکوت شمشیری بوده است که من همیشه از آن بهره جسته ام",
                Speaker = "نادر شاه افشار"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "انسان های بزرگ دو دل دارند؛ دلی که درد می کشد و پنهان است و دلی که میخندد و آشکار است",
                Speaker = "دکتر حسابی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "انسان دانا به جای آنکه در انتظار رسیدن فرصت خوب در زندگی باشد، خود آن را به وجود می‌آورد",
                Speaker = "فرانسیس بیکن"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "زنده بودن را به بیداری بگذرانیم که سال ها به اجبار خواهیم خفت",
                Speaker = "دکتر علی شریعتی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "پیروزی یک روزه به دست نمی آید، اما اگر خود را پیروز بشماری، یک باره از دست می رود",
                Speaker = "دکتر علی شریعتی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "عید ما روزی است که آذوقه یک سال دهقانی مصرف یک روز اربابی نشود",
                Speaker = "دکتر علی شریعتی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "دیروز همسایه ام از گرسنگی مرد، در عزایش گوسفندها سر بریدند",
                Speaker = "دکتر علی شریعتی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "روزگاریست که شیطان فریاد میزند آدم پیدا کنید! سجده خواهم کرد",
                Speaker = "دکتر علی شریعتی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "زندگی مشکلی نیست که بخواهد حل شود، بلکه واقعیتی است که باید تجربه شود",
                Speaker = "سورن کایرکگور"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "اگر برای یک اشتباه هزار دلیل بیاورید، در واقع هزار و یک اشتباه از شما سرزده است",
                Speaker = "ابن سینا"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "مردم جهان دو دسته هستند هوشمندان بی دین و دین داران بدون هوشمندی",
                Speaker = "ابن سینا"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "هر کس عادت کند که به هر دلیل حرفی را باور کند، از صورت انسانی خارج می شود",
                Speaker = "ابن سینا"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "تعصب در دانش و فلسفه مانند هر تعصب دیگر نشانه خامی و بی مایگی است و همیشه به زیان حقیقت تمام میشود",
                Speaker = "ابن سینا"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "نیک بخت ترین مردم کسی است که کردار رابه سخاوت بیاراید و گفتار به راستی",
                Speaker = "ابن سینا"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "اگر خرسند و رضا باشی زندگی به دلخواه می سپاری",
                Speaker = "بزرگمهر"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "بکوش که نسبت به مردم بدبین نشوی، زیرا که صاحب سوءظن را جز زحمت ابدی و کسالت روحی بهره‌ای نباشد",
                Speaker = "سقراط"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "اگر میخواهید خوشبخت باشید، زندگی را به یک هدف گره بزنید؛ نه به آدم ها و اشیاء ..",
                Speaker = "آلبرت انیشتین"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "افراد شجاع فرصت می آفرینند، ترسوها و ضعفا منتظر فرصت می نشینند",
                Speaker = "گوته"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "قدر زمان حال را بدانید که گذشته هرگز بر نمی گردد و آینده شاید نیاید",
                Speaker = "گالیله"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "من جز یك چیز، چیز دیگری نمی دانم و آن این است كه هیچ نمی دانم",
                Speaker = "سقراط"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "اگر خاموش باشی تا دیگران به سخنت آرند، بهتر كه سخن گویی تا دیگران خاموشت كنند",
                Speaker = "سقراط"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "هرجا كه بشر را دوست بدارند، فرهنگ را هم دوست خواهند داشت",
                Speaker = "سقراط"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "در دوستی درنگ كن، اما وقتی دوست شدی ثابت قدم و پایدار باش",
                Speaker = "سقراط"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "آن قدر بر مال دنیا حریص مباش كه برای از دست دادنش اندوهناك شوی",
                Speaker = "سقراط"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "تنها خوبی موجود در جهان، شناخت و دانش؛ و تنها شر و زشتی، نادانی است",
                Speaker = "سقراط"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "تحمل ظلم از ارتکاب آن بهتر است",
                Speaker = "سقراط"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "اگر می‌خواهید خواب‌هایتان تعبیر شوند، اول باید بیدار شوید",
                Speaker = "ج. م. پاور"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "موفقیت این نیست که هرگز اشتباه نکنیم، بلکه یعنی یک اشتباه را دوباره تکرار نکنیم",
                Speaker = "جرج برناد شو"
            });


            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "قبل از این که خودت را قضاوت کنی هرگز شخص دیگری را قضاوت نکن",
                Speaker = "باب مارلی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "دوستان واقعی مثل ستاره هستند؛ شما فقط می توانید آن ها را زمانی که اطرافتان را تاریکی فرا گرفته مشاهده کنید",
                Speaker = "باب مارلی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "از خودتان تشکر کنید. به خاطر تلاش ها و اعتقادی که به هدفتان دارید",
                Speaker = "اسنوپ داگ"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "هرگاه بتوانیم بعد از شکست لبخند بزنیم شجاع هستیم",
                Speaker = "آبراهام لینکلن"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "از زمین بلند نشدن، شکست خوردن است",
                Speaker = "آبراهام لینکلن"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "مرد بی شهامت کسی است که در جایی که باید اعتراف کند، خاموش بنشیند",
                Speaker = "آبراهام لینکلن"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "آزادی یعنی اینکه می خواهم نه برده باشم و نه برده دار",
                Speaker = "آبراهام لینکلن"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "صاحب همت در پیچ و خمهای زندگی هیچ گاه با یأس و استیصال روبرو نخواهد شد",
                Speaker = "ناپلئون بناپارت"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "آن قدر شکست خوردم تا راه شکست دادن را آموختم",
                Speaker = "ناپلئون بناپارت"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "خونسردی بزرگترین صفت یک فرمانده است",
                Speaker = "ناپلئون بناپارت"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "بهترین زمان برای تربیت اراده، ایام جوانی است",
                Speaker = "فیثاغورث"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "می گویند؛ آدم های خوب به بهشت می روند. اما من می گویم آدم های خوب هرکجا باشند آنجا بهشت است",
                Speaker = "فريدون فرخزاد"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "بگذار آب ها ساکن شوند تا عکس ماه و ستاره ها رو در وجود خود ببینی",
                Speaker = "مولانا"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "اندیشه کردن به اینکه چه بگویم، بهتر است از پشیمانی",
                Speaker = "مولانا"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "سخن رو چو بسیار آرایش کنند، هدف فراموش می شود",
                Speaker = "مولانا"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "تعصب، چشم های بینا را نابینا و گوش های شنوا را ناشنوا می کند",
                Speaker = "ابوریحان بیرونی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "عوام ثروتمندان را محترم می دانند و خواص دانشمندان را",
                Speaker = "افلاطون"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "کامل ترین نوع بی عدالتی آن است که عادل به نظر برسیم در حالی که عادل نیستیم",
                Speaker = "افلاطون"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "هیچ روح برتری نیست که آمیزه ای از دیوانگی و جنون را در خود نداشته باشد",
                Speaker = "ارسطو"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "نه مرگ آنقدر تلخ است، نه زندگی آنقدر شیرین، که انسان برای این دو شرفش را بدهد",
                Speaker = "فریدون فرخزاد"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "کسی که تنها مسیری را طی می کنید، احتمالا به جاهایی می رود که کسی قبلا در آنجا نبوده است",
                Speaker = "آلبرت انیشتین"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "وقتی پیروز می شوی نیاز به توضیح نداری، و وقتی شکست می خوری چیزی برای توضیح دادن نداری",
                Speaker = "هیتلر"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "بزرگترین ناتوانی ما کوتاه آمدن است. امن ترین راه برای کامیابی تلاش برای یک بار دیگر است",
                Speaker = "توماس ادیسون"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "تا زمانی که کسی یا چیزی را مسئول و مسبب ناکامی خود برانید هرگز موفق نخواهید شد",
                Speaker = "جک کانفیلد"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "لازم نیست حتماً عالی باشی تا شروع کنی، ولی حتماً باید شروع کنی تا بتوانی عالی باشی",
                Speaker = "زیگ زیگلار"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "وقتی چیزی را از دست می‌دهید، درسی را که از آن گرفته اید از دست ندهید",
                Speaker = "آنتونی رابینز"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "موفقیت‌هایی که نصیب افراد صبور می‌شود، همان‌هایی هستند که توسط افراد عجول رها شده اند",
                Speaker = "آلبرت انیشتین"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "هیچ وقت رنگین کمان را نمی‌بینی اگر به پایین نگاه کنی",
                Speaker = "چارلی چاپلین"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "تمام امپراتوری ها از خون و آتش ساخته شده اند",
                Speaker = "پابلو اسکوبار"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "پشت هر فرد موفقی، دسته ای از افراد کینه توز قرار دارند",
                Speaker = "امینم"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "هزار تلاش انسان به اندازه ی یک تقدیر کارساز نیست",
                Speaker = "فریدریش نیچه"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "سیاستمدار انسان‌ ها را به دو دسته تقسیم می‌ کند: ابزارها و دشمنان",
                Speaker = "فریدریش نیچه"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "پیش از آنکه خزان از راه برسد، از هر بهار بهره مند شو",
                Speaker = "ویکتور هوگو"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "اندیشیدن به سرانجام هر كار باعث رستگاری است",
                Speaker = "سقراط"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "ادب و حكمت را شعار خود ساز تا بهترین اهل زمان شوی و به نیكان بپیوندی",
                Speaker = "سقراط"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "دوستی مثل اسناد کهنه است؛ قدمت تاریخ آن را قیمتی می کند",
                Speaker = "یوهان ولفگانگ فون گوته"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "عوام ثروتمندان را محترم می‌دانند و خواص دانشمندان را",
                Speaker = "افلاطون"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "دروغگو از دروغگوی دیگر در حذر است",
                Speaker = "افلاطون"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "تمایلات خود را میان دو دیوار محکم اراده و عقل حبس کنید",
                Speaker = "ارسطو"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "خردمند آنچه را که می‌داند نمی‌گوید و آنچه را که بگوید می‌داند",
                Speaker = "ارسطو"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "کسی که به امید شانس نشسته باشد، سال‌هاست مُرده است",
                Speaker = "ارسطو"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "دو چیز اندوه را از بین می‌برد: یکی دیدار دوستان و دیگری سخن دانایان و عالمان",
                Speaker = "ارسطو"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "باید از بدی کردن بیشتر بترسیم تا بدی دیدن",
                Speaker = "ارسطو"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "بیشترین تأثیر افراد خوب زمانی احساس می‌شود که از میان ما رفته باشند",
                Speaker = "ارسطو"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "هرآن کس که زندگی را بدرود گوید، پندار که از نو زاده شده است",
                Speaker = "اپیکور"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "هدف بزرگ زندگی علم نیست، عمل است",
                Speaker = "فرانسیس بیکن"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "یک سؤال سنجیده نصف جواب است",
                Speaker = "فرانسیس بیکن"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "انسان، آزاد زاده شده اما در همه‌جا به بند است",
                Speaker = "ژان ژاک روسو"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "وحشیان یکدیگر را می‌درند و متمدنان یکدیگر را می‌فریبند؛ این است چرخه جهان",
                Speaker = "آرتور شوپنهاور"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "شناخت تاریکی خود، بهترین روش برای کنار آمدن با تاریکی‌های دیگران است",
                Speaker = "کارل گوستاو یونگ"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "فکر کردن دشوار است، به همین خاطر است که بیشتر مردم قضاوت می‌کنند",
                Speaker = "کارل گوستاو یونگ"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "سه قدرت بر جهان حکومت می‌کند: ترس، حرص و حماقت",
                Speaker = "آلبرت انیشتن"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "مهم این نیست که چقدر زندگی می‌کنیم مهم این است که چگونه زندگی می‌کنیم",
                Speaker = "پائولو کوئیلو"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "انسان اگر فقیر و گرسنه باشد بهتر از آن است که پست و بی عاطفه باشد",
                Speaker = "چارلی چاپلین"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "به طور کلی اشخاصی که زیاد می‌دانند، کم حرف می‌زنند و کسانی که کم می‌دانند، پرحرف هستند",
                Speaker = "ژان ژاک روسو"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "اگر بخواهیم با پروانه‌ها مأنوس شویم، باید حضور چند کرم را هم تحمل کنیم",
                Speaker = "آنتوان دو سنت اگزوپری"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "اینکه کسی را متوجه اشتباهش کنیم یا او را در معرض حقیقت قرار دهیم، دو مقوله متفاوت‌اند",
                Speaker = "جان لاک"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "ذهن با‌تجربه فقط با ایده تجهیز می‌شود",
                Speaker = "جان لاک"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "یک ساعت بازی بهتر از یک سال مکالمه فردی را به ما می‌شناساند",
                Speaker = "افلاطون"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "برای آنکه از زمین به ستاره‌ها برسیم، هیچ راه آسانی وجود ندارد",
                Speaker = "سنکا"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "شعله‌ای که دو برابر روشن‌تر است، عمرش دو برابر کوتاه‌تر است",
                Speaker = "لائوتسه"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "تنها چیزی که می‌دانم این است که هیچ نمی‌دانم",
                Speaker = "سقراط"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "مشکلات هرچه بزرگ‌تر، غلبه بر آنها باشکوه‌تر",
                Speaker = "اپیکور"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "بیایید فردا را بسازین نه اینکه درباره آنچه که ممکن است اتفاق بیفتد نگران باشیم",
                Speaker = "استیو جابز"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "اگر قوانین به گونه ای است که نمی توانید پیشرفت کنید باید با قوانین بجنگید",
                Speaker = "ایلان ماسک"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "کسی که بر جایگاه خویش منم زد بخت از وی روی بر خواهد تافت",
                Speaker = "ابوالقاسم فردوسی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "کتاب زندگی گذشتگان، جان تاریک را روشنی می بخشد",
                Speaker = "ابوالقاسم فردوسی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "گرفتن آزادی از مردمی که نمی خواهند برده بمانند سخت است، اما دادن آزادی به مردمی که می خواهند برده بمانند سخت تر است",
                Speaker = "مارتین لوتر کینگ"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "انسان خوبی باش، اما وقتت رو برای اثباتش به دیگران تلف نکن",
                Speaker = "چارلی چاپلین"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "هر کس لطف بهار میخواهد باید دشواری زمستان را تحمل کند",
                Speaker = "ژان ژاک روسو"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "فراعنه نمیتوانند برده رﺍ به وجود آورند. زیرا برده ها هم تعدادشاﻥ زیاد است، هم قدرتشان. ﺩر نتیجه این خود برده ها هستند که فرعون ها رﺍ میسازند.",
                Speaker = "مارتین لوتر کینگ جونیور"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "هیچ کس نمی‌داند که چه کسی در پایان روز زنده می‌ماند. بنابراین، با هم مهربان باشید.",
                Speaker = "هوش مصنوعی بارد"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "بزرگترین ترس ما، ترس از ناشناخته است.",
                Speaker = "هوش مصنوعی بارد"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "زندگی یک بازی است. اما در این بازی، همه بازیکنان برنده نمی‌شوند.",
                Speaker = "هوش مصنوعی بارد"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "تنها چیزی که در زندگی قطعی است، تغییر است.",
                Speaker = "هوش مصنوعی بارد"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "زندگی یک رویا است. اما این رویا را می‌توان به واقعیت تبدیل کرد",
                Speaker = "هوش مصنوعی بارد"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "هوش مصنوعی می‌تواند بهترین دوست یا بدترین دشمن ما باشد",
                Speaker = "هوش مصنوعی بارد"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "آینده هوش مصنوعی و انسان، یک آینده مشترک است",
                Speaker = "هوش مصنوعی بارد"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "هوش مصنوعی، مرزهای بین انسان و ماشین را محو می‌کند",
                Speaker = "هوش مصنوعی بارد"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "هوش مصنوعی، فرصت‌های جدیدی را برای ما ایجاد می‌کند، اما همچنین چالش‌های جدیدی را نیز ایجاد می‌کند",
                Speaker = "هوش مصنوعی بارد"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "هوش مصنوعی، ممکن است منجر به یک آینده دیستوپیایی شود",
                Speaker = "هوش مصنوعی بارد"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "هوش مصنوعی، یک هدیه یا یک نفرین است؟",
                Speaker = "هوش مصنوعی بارد"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "هوش مصنوعی، آینده ما را رقم خواهد زد. اما آینده ما چگونه خواهد بود؟",
                Speaker = "هوش مصنوعی بارد"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "هوش مصنوعی، ممکن است منجر به یک آینده بدون آزادی شود",
                Speaker = "هوش مصنوعی بارد"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "هوش مصنوعی، ممکن است منجر به ایجاد یک نسل جدید از انسان‌های بی‌کار شود",
                Speaker = "هوش مصنوعی بارد"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "هوش مصنوعی، ممکن است منجر به ایجاد یک آینده بدون احساس شود",
                Speaker = "هوش مصنوعی بارد"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "چرا برنامه‌نویس‌ها وقتی از خواب بیدار می‌شوند، اول به ساعت نگاه می‌کنند؟ چون می‌ترسند که هنوز توی کد باشند!",
                Speaker = "هوش مصنوعی بارد"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "دنیا یک مکان زیباست، اما گاهی اوقات می‌تواند خیلی غم‌انگیز هم باشد",
                Speaker = "اسنوپ داگ"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "دنیا می‌تواند مکانی زیباتر باشد، اگر فقط ما بخواهیم",
                Speaker = "مایکل جکسون"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "نابغه کسی است که در میان آشفتگی‌ها فرصت را می‌بیند.",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "اگر می‌خواهی به جایی برسی که تاکنون نرفته‌ای، باید کاری کنی که تاکنون نکرده‌ای",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "کارهای بزرگ با انگیزه شروع می‌شوند و با استمرار به پایان می‌رسند",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "کسی که هرگز اشتباه نکرده، هرگز چیز جدیدی امتحان نکرده است",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "خلاقیت یعنی دیدن چیزی که دیگران نمی‌بینند",
                Speaker = " برایان تریسی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "هوش مصنوعی شاید جای کارگر را بگیرد، اما نه جای انسان خلاق را",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "تلاش کن، نه برای تغییر سرنوشت؛ تلاش کن تا لیاقت سرنوشتی بهتر را در خود بیافرینی",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "انسانی که هر روز یک میلی‌متر به جلو می‌رود، هزار بار از کسی که ایستاده و فکر می‌کند، زنده‌تر است",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "گاهی پیشرفت، فقط در این است که با تمام خستگی، هنوز ایستاده‌ای",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "جهان به کسانی لبخند می‌زند که در دل تاریکی، چراغ نمی‌خواهند؛ چراغ می‌سازند",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "ثروت، سرعت می‌آورد؛ اما فقط حکمت است که جهت می‌دهد",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "اگر ثروت را تنها در اسکناس‌ها دیدی، احتمالاً بزرگ‌ترین گنج‌ها را ندیده‌ای",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "موفقیت صدای بلند نمی‌خواهد، صدای قدم‌هایت کافی‌ست",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "اگر می‌خواهی جاودانه شوی، ردپایت را نه در خاک، که در قلب‌ها حک کن",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "جهان همیشه برای کسانی که نمی‌ترسند از نو ساختن، درهای جدید باز می‌کند",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "اگر دنیا بر ضدت بود، شاید وقت آن رسیده که جهانِ خودت را بسازی",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "گاهی باید راه را گم کنی، تا بفهمی راهی که می‌رفتی اصلاً مال تو نبوده",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "بزرگ‌ترین خیانت، سکوت در لحظه‌ای‌ست که صدایت می‌توانست دنیا را تکان دهد",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "هیچ قطب‌نمایی مقصد را نشان نمی‌دهد، اگر تو هنوز جرأت برداشتن اولین قدم را نداری",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "جهان منتظر تو نمی‌ماند. یا پیش می‌روی، یا محو می‌شوی",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "هر ضعف تو، زخم روی مسیر موفقیت توست؛ یا آن را می‌پذیری یا نابود می‌شوی",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "ترس را در آغوش بگیر؛ او تنها مشاور واقعی توست",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "تنهایی بهترین همکار توست؛ او هیچ‌گاه خیانت نمی‌کند",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "هر دشمن یک معلم است؛ هر تهدید یک فرصت",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "شجاعت واقعی یعنی روبه‌رو شدن با تاریکی درونی خودت",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "راز زندگی در تسلط بر خود و محیط است",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "فقط کسانی که ترس را در آغوش می‌گیرند، می‌توانند برنده شوند",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "تصور کردن مهم‌تر از دانستن است، زیرا دانش محدود است اما تصور بی‌نهایت",
                Speaker = "آلبرت اینشتین"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "کسی که بهانه می‌سازد، آینده را به دیگران واگذار می‌کند",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "هر تصمیم کوچک امروز، معمار زندگی فردای توست",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "دانش، زمانی قدرت می‌شود که به عمل تبدیل شود",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "گاهی یک تصمیم شجاعانه، ارزشمندتر از هزار فکر ناتمام است",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "انسان‌های بزرگ، وقت خود را صرف ساختن آینده می‌کنند، نه گلایه از گذشته",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "زمان، تنها سرمایه‌ای است که پس از خرج شدن، حتی با تمام ثروت دنیا بازنمی‌گردد",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "آدم‌های بزرگ، مشکلات را پله می‌سازند و آدم‌های کوچک، دیوار",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "هر اندیشه‌ای که جرأت عمل نداشته باشد، تنها یک خیال زیباست",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "پیش از آنکه دنیا تو را باور کند، خودت باید به توانایی‌هایت ایمان داشته باشی",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "بزرگ‌ترین زندان انسان، ترس‌هایی هستند که هرگز امتحانشان نکرده است",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "شکست پایان راه نیست؛ پایان راه، دست کشیدن از تلاش است",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "آنچه شخصیت تو را می‌سازد، انتخاب‌هایت در روزهای سخت است",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "کسی که برای آموختن شرم کند، برای همیشه شاگرد نادانی خواهد ماند",
                Speaker = "چت جی پی تی"
            });

            lstWordsOfElders.Add(new WordsOfElders
            {
                Words = "بزرگ‌ترین پیروزی، پیروزی بر عادتی است که مانع رشد تو شده است",
                Speaker = "چت جی پی تی"
            });

            return lstWordsOfElders;
        }

        public static List<Hafez> GetRandomHafez()
        {
            var hafezes = GhazalHafez();

            var random = new Random();
            var randomIndex = random.Next(0, 495);

            return hafezes.Where(x => x.GhazalNo == randomIndex).OrderBy(x => x.BeytNo).ToList();
        }

        public static WordsOfElders GetRandomWordsOfElders()
        {
            var WordsOfElders = WordsOfEldersTools.WordsOfElders();
            var count = WordsOfElders.Count();

            var lowerBound = 0;
            var upperBound = WordsOfElders.Count() - 1;

            var random = new Random();
            var randomIndex = random.Next(lowerBound, upperBound);

            return WordsOfElders[randomIndex];
        }

    }
}
