using HouyarRealState.Domain.Entities.Settings;
using HouyarRealState.Domain.Entities.User;

namespace HouyarRealState.Domain.Entities.Properties
{
    public class Property:BaseEntity
    {


        // شناسه کاربری که آگهی ملک را ثبت کرده است
        public Guid UserId { get; set; }

        public Guid LanguageId { get; set; }

        // عنوان آگهی ملک
        public string Title { get; set; } = string.Empty;

        // توضیحات کامل ملک
        public string Description { get; set; } = string.Empty;

        // کد اختصاصی ملک در سامانه
        public string? PropertyCode { get; set; }

        // نوع ملک: آپارتمان، خانه، ویلا، زمین، مغازه و غیره
        public Guid PropertyTypeId { get; set; }

        // نوع معامله: خرید، فروش، رهن، اجاره و غیره
        public Guid TransactionTypeId { get; set; }

        // وضعیت آگهی: پیش‌نویس، منتشرشده، فروخته‌شده، اجاره‌رفته و غیره
        public string Status { get; set; } = "Draft";

        // مشخص می‌کند آگهی تأیید شده است یا خیر
        public bool IsApproved { get; set; }

        // مشخص می‌کند آگهی ویژه است یا خیر
        public bool IsFeatured { get; set; }

        // مشخص می‌کند آگهی در صفحه اصلی نمایش داده شود یا خیر
        public bool IsHighlighted { get; set; }

        // تاریخ شروع انتشار آگهی
        public DateTime? PublishedAt { get; set; }

        // تاریخ پایان اعتبار آگهی
        public DateTime? ExpiresAt { get; set; }

        // تعداد دفعات مشاهده آگهی
        public int ViewCount { get; set; }

        // تاریخ ایجاد رکورد
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // تاریخ آخرین ویرایش رکورد
        public DateTime? UpdatedAt { get; set; }


        // مساحت کل ملک بر حسب مترمربع
        public decimal Area { get; set; }

        // مساحت زیربنا بر حسب مترمربع
        public decimal? BuiltArea { get; set; }

        // مساحت زمین بر حسب مترمربع
        public decimal? LandArea { get; set; }

        // مساحت مفید ملک بر حسب مترمربع
        public decimal? UsefulArea { get; set; }

        // تعداد اتاق خواب
        public int? Bedrooms { get; set; }

        // تعداد سرویس‌های بهداشتی
        public int? Bathrooms { get; set; }

        // تعداد حمام
        public int? Showers { get; set; }

        // تعداد سالن‌های پذیرایی
        public int? LivingRooms { get; set; }

        // تعداد آشپزخانه
        public int? Kitchens { get; set; }

        // تعداد طبقات کل ساختمان
        public int? Floors { get; set; }

        // شماره طبقه‌ای که ملک در آن قرار دارد
        public int? FloorNumber { get; set; }

        // تعداد واحدهای موجود در ساختمان
        public int? UnitsCount { get; set; }

        // تعداد واحدهای موجود در هر طبقه
        public int? UnitsPerFloor { get; set; }

        // ارتفاع سقف بر حسب متر
        public decimal? CeilingHeight { get; set; }

        // سال ساخت ملک
        public int? ConstructionYear { get; set; }

        // سال آخرین بازسازی اساسی
        public int? RenovationYear { get; set; }

        // تعداد بالکن‌ها
        public int? BalconiesCount { get; set; }

        // تعداد تراس‌ها
        public int? TerracesCount { get; set; }

        // تعداد انباری‌های اختصاصی
        public int? StorageCount { get; set; }

        // تعداد پارکینگ‌های اختصاصی
        public int? ParkingCount { get; set; }

        // تعداد آسانسورهای ساختمان
        public int? ElevatorsCount { get; set; }

        // ظرفیت آسانسور بر حسب تعداد نفر
        public int? ElevatorCapacity { get; set; }

        // تعداد ورودی‌های مستقل ملک
        public int? EntrancesCount { get; set; }

        // تعداد اضلاع نورگیر ملک
        public int? LightSidesCount { get; set; }

        // تعداد واحدهای مستقل موجود در خود ملک
        public int? IndependentUnitsCount { get; set; }

        // وضعیت نوساز بودن ملک
        public bool IsNewlyBuilt { get; set; }

        // وضعیت کلیدنخورده بودن ملک
        public bool IsUnused { get; set; }

        // وضعیت بازسازی‌شده بودن ملک
        public bool IsRenovated { get; set; }

        // وضعیت نیمه‌کاره بودن ساختمان
        public bool IsUnderConstruction { get; set; }

        // وضعیت آماده تحویل بودن ملک
        public bool IsReadyToMove { get; set; }



        // قیمت کل ملک برای فروش
        public decimal? Price { get; set; }

        // قیمت هر مترمربع
        public decimal? PricePerSquareMeter { get; set; }

        // مبلغ ودیعه یا رهن
        public decimal? Deposit { get; set; }

        // مبلغ اجاره ماهانه
        public decimal? MonthlyRent { get; set; }

        // مبلغ قابل پرداخت به‌عنوان پیش‌پرداخت خرید
        public decimal? DownPayment { get; set; }

        // مبلغ اقساط ماهانه
        public decimal? MonthlyInstallment { get; set; }

        // تعداد اقساط پرداختی
        public int? InstallmentsCount { get; set; }

        // مبلغ هر قسط
        public decimal? InstallmentAmount { get; set; }

        // مبلغ شارژ ماهانه ساختمان
        public decimal? MonthlyBuildingCharge { get; set; }

        // مبلغ تقریبی هزینه نگهداری ماهانه
        public decimal? MonthlyMaintenanceCost { get; set; }

        // مبلغ تقریبی قبوض ماهانه
        public decimal? MonthlyUtilitiesCost { get; set; }

        // هزینه کمیسیون یا حق واگذاری در صورت وجود
        public decimal? Commission { get; set; }

        // میزان تخفیف در قیمت پیشنهادی
        public decimal? DiscountAmount { get; set; }

        // مشخص می‌کند قیمت قابل مذاکره است یا خیر
        public bool IsPriceNegotiable { get; set; }

        // مشخص می‌کند امکان خرید اقساطی وجود دارد یا خیر
        public bool IsInstallmentSale { get; set; }

        // مشخص می‌کند امکان معاوضه ملک وجود دارد یا خیر
        public bool IsExchangeable { get; set; }

        // مشخص می‌کند امکان تهاتر با کالا یا ملک دیگر وجود دارد یا خیر
        public bool IsBarterPossible { get; set; }

        // واحد پول: تومان، ریال یا ارز دیگر
        public string Currency { get; set; } = "IRR";

        // توضیحات مربوط به شرایط پرداخت
        public string? PaymentTerms { get; set; }


        // نام استان
        public string Province { get; set; } = string.Empty;

        // نام شهر
        public string City { get; set; } = string.Empty;

        // نام منطقه یا ناحیه شهری
        public string? District { get; set; }

        // نام محله
        public string? Neighborhood { get; set; }

        // نام خیابان اصلی
        public string? Street { get; set; }

        // نام خیابان فرعی
        public string? SideStreet { get; set; }

        // کوچه یا بن‌بست
        public string? Alley { get; set; }

        // پلاک ساختمان
        public string? پلاک { get; set; }

        // طبقه در نشانی پستی، در صورت نیاز به نگهداری مستقل
        public string? AddressFloor { get; set; }

        // واحد در نشانی پستی
        public string? UnitNumber { get; set; }

        // کد پستی ملک
        public string? PostalCode { get; set; }

        // نشانی کامل ملک
        public string Address { get; set; } = string.Empty;

        // عرض جغرافیایی ملک
        public decimal? Latitude { get; set; }

        // طول جغرافیایی ملک
        public decimal? Longitude { get; set; }

        // جهت جغرافیایی ملک: شمالی، جنوبی، شرقی یا غربی
        public string? Direction { get; set; }

        // جهت اصلی پنجره‌ها و نورگیری ملک
        public string? WindowDirection { get; set; }

        // وضعیت دسترسی ملک به خیابان اصلی
        public bool HasMainStreetAccess { get; set; }

        // وضعیت دسترسی به وسایل حمل‌ونقل عمومی
        public bool HasPublicTransportAccess { get; set; }

        // وضعیت دسترسی به مترو
        public bool HasMetroAccess { get; set; }

        // وضعیت دسترسی به مراکز خرید
        public bool HasShoppingCenterAccess { get; set; }

        // وضعیت دسترسی به مراکز درمانی
        public bool HasMedicalCenterAccess { get; set; }

        // وضعیت دسترسی به مدارس
        public bool HasSchoolAccess { get; set; }

        // توضیحات مربوط به موقعیت و دسترسی‌ها
        public string? LocationDescription { get; set; }



        // دارای پارکینگ
        public bool HasParking { get; set; }

        // دارای پارکینگ مسقف
        public bool HasCoveredParking { get; set; }

        // دارای پارکینگ اختصاصی
        public bool HasPrivateParking { get; set; }

        // دارای پارکینگ مهمان
        public bool HasGuestParking { get; set; }

        // دارای آسانسور
        public bool HasElevator { get; set; }

        // دارای انباری
        public bool HasStorage { get; set; }

        // دارای بالکن
        public bool HasBalcony { get; set; }

        // دارای تراس
        public bool HasTerrace { get; set; }

        // دارای حیاط
        public bool HasYard { get; set; }

        // دارای حیاط اختصاصی
        public bool HasPrivateYard { get; set; }

        // دارای باغ
        public bool HasGarden { get; set; }

        // دارای روف‌گاردن
        public bool HasRoofGarden { get; set; }

        // دارای استخر
        public bool HasSwimmingPool { get; set; }

        // دارای استخر سرپوشیده
        public bool HasIndoorPool { get; set; }

        // دارای استخر روباز
        public bool HasOutdoorPool { get; set; }

        // دارای سونا
        public bool HasSauna { get; set; }

        // دارای جکوزی
        public bool HasJacuzzi { get; set; }

        // دارای سالن ورزشی
        public bool HasGym { get; set; }

        // دارای سالن اجتماعات
        public bool HasMeetingRoom { get; set; }

        // دارای سالن بازی کودکان
        public bool HasPlayroom { get; set; }

        // دارای فضای سبز مشترک
        public bool HasSharedGreenSpace { get; set; }

        // دارای لابی
        public bool HasLobby { get; set; }

        // دارای نگهبانی
        public bool HasSecurityGuard { get; set; }

        // دارای سرایدار
        public bool HasCaretaker { get; set; }

        // دارای دوربین مداربسته
        public bool HasCCTV { get; set; }

        // دارای سیستم اعلام حریق
        public bool HasFireAlarm { get; set; }

        // دارای سیستم اطفای حریق
        public bool HasFireSuppressionSystem { get; set; }

        // دارای درب ضدسرقت
        public bool HasSecurityDoor { get; set; }

        // دارای آیفون تصویری
        public bool HasVideoIntercom { get; set; }

        // دارای سیستم خانه هوشمند
        public bool HasSmartHome { get; set; }

        // دارای اینترنت پرسرعت
        public bool HasHighSpeedInternet { get; set; }

        // دارای آنتن مرکزی
        public bool HasCentralAntenna { get; set; }

        // دارای سیستم برق اضطراری
        public bool HasBackupPower { get; set; }

        // دارای ژنراتور برق
        public bool HasGenerator { get; set; }

        // دارای منبع ذخیره آب
        public bool HasWaterTank { get; set; }

        // دارای پمپ آب
        public bool HasWaterPump { get; set; }

        // دارای سیستم تصفیه آب
        public bool HasWaterPurifier { get; set; }

        // دارای سیستم تصفیه فاضلاب
        public bool HasWastewaterTreatment { get; set; }

        // دارای پنجره دوجداره
        public bool HasDoubleGlazedWindows { get; set; }

        // دارای عایق صوتی
        public bool HasSoundInsulation { get; set; }

        // دارای عایق حرارتی
        public bool HasThermalInsulation { get; set; }



        // نوع سیستم گرمایشی: پکیج، موتورخانه، بخاری و غیره
        public string? HeatingSystem { get; set; }

        // نوع سیستم سرمایشی: کولر گازی، آبی، چیلر و غیره
        public string? CoolingSystem { get; set; }

        // دارای کولر گازی
        public bool HasAirConditioner { get; set; }

        // دارای کولر آبی
        public bool HasEvaporativeCooler { get; set; }

        // دارای سیستم گرمایش از کف
        public bool HasUnderfloorHeating { get; set; }

        // دارای رادیاتور
        public bool HasRadiator { get; set; }

        // دارای شومینه
        public bool HasFireplace { get; set; }

        // دارای پکیج گرمایشی
        public bool HasBoiler { get; set; }

        // دارای موتورخانه مرکزی
        public bool HasCentralHeating { get; set; }

        // دارای سیستم تهویه مطبوع مرکزی
        public bool HasCentralAirConditioning { get; set; }

        // دارای سیستم تهویه مکانیکی
        public bool HasMechanicalVentilation { get; set; }

        // نوع تأمین آب گرم مصرفی
        public string? HotWaterSystem { get; set; }



        // نوع کف‌پوش: سرامیک، پارکت، سنگ، لمینت و غیره
        public string? FlooringType { get; set; }

        // نوع پوشش دیوارها
        public string? WallCovering { get; set; }

        // نوع پوشش سقف
        public string? CeilingType { get; set; }

        // نوع نمای ساختمان
        public string? FacadeType { get; set; }

        // نوع کابینت آشپزخانه
        public string? CabinetType { get; set; }

        // جنس صفحه کابینت
        public string? CountertopType { get; set; }

        // نوع پنجره‌ها
        public string? WindowType { get; set; }

        // جنس چهارچوب پنجره‌ها
        public string? WindowFrameMaterial { get; set; }

        // نوع درب‌های داخلی
        public string? InteriorDoorType { get; set; }

        // دارای کمد دیواری
        public bool HasWardrobe { get; set; }

        // دارای اتاق لباس یا کلوزت
        public bool HasWalkInCloset { get; set; }

        // دارای اتاق مستر
        public bool HasMasterBedroom { get; set; }

        // دارای سرویس بهداشتی فرنگی
        public bool HasWesternToilet { get; set; }

        // دارای سرویس بهداشتی ایرانی
        public bool HasIranianToilet { get; set; }

        // دارای وان حمام
        public bool HasBathtub { get; set; }

        // دارای کابین دوش
        public bool HasShowerCabin { get; set; }

        // دارای نورپردازی دکوراتیو
        public bool HasDecorativeLighting { get; set; }

        // دارای سقف کاذب
        public bool HasFalseCeiling { get; set; }

        // دارای پرده
        public bool HasCurtains { get; set; }

        // دارای مبلمان ثابت
        public bool HasBuiltInFurniture { get; set; }

        // وضعیت مبله بودن ملک
        public bool IsFurnished { get; set; }

        // وضعیت نیمه‌مبله بودن ملک
        public bool IsSemiFurnished { get; set; }

        // توضیحات مربوط به دکوراسیون داخلی
        public string? InteriorDescription { get; set; }


        // دارای اجاق گاز
        public bool HasStove { get; set; }

        // دارای فر توکار
        public bool HasOven { get; set; }

        // دارای مایکروویو
        public bool HasMicrowave { get; set; }

        // دارای هود
        public bool HasRangeHood { get; set; }

        // دارای ماشین ظرف‌شویی
        public bool HasDishwasher { get; set; }

        // دارای ماشین لباس‌شویی
        public bool HasWashingMachine { get; set; }

        // دارای یخچال
        public bool HasRefrigerator { get; set; }

        // دارای تجهیزات کامل آشپزخانه
        public bool HasEquippedKitchen { get; set; }

        // توضیحات مربوط به تجهیزات و لوازم موجود
        public string? AppliancesDescription { get; set; }


        // نوع سند: تک‌برگ، شش‌دانگ، قولنامه‌ای، اوقافی و غیره
        public string? DeedType { get; set; }

        // وضعیت داشتن سند رسمی
        public bool HasOfficialDeed { get; set; }

        // وضعیت شش‌دانگ بودن سند
        public bool IsSixDang { get; set; }

        // وضعیت آزاد بودن سند از رهن یا بازداشت
        public bool IsDeedFree { get; set; }

        // وضعیت داشتن پایان کار
        public bool HasCompletionCertificate { get; set; }

        // وضعیت داشتن صورت‌مجلس تفکیکی
        public bool HasSubdivisionDocument { get; set; }

        // وضعیت داشتن پروانه ساخت
        public bool HasBuildingPermit { get; set; }

        // وضعیت داشتن سند مالکیت زمین
        public bool HasLandOwnershipDocument { get; set; }

        // وضعیت وجود بدهی یا تعهد حقوقی
        public bool HasLegalEncumbrance { get; set; }

        // وضعیت قرار داشتن ملک در رهن بانک
        public bool IsMortgaged { get; set; }

        // وضعیت مشاع بودن ملک
        public bool IsSharedOwnership { get; set; }

        // وضعیت ورثه‌ای بودن ملک
        public bool IsInherited { get; set; }

        // وضعیت داشتن مستأجر فعلی
        public bool HasCurrentTenant { get; set; }

        // وضعیت امکان انتقال فوری سند
        public bool CanTransferImmediately { get; set; }

        // توضیحات مربوط به وضعیت حقوقی و اسناد
        public string? LegalDescription { get; set; }



        // نوع کاربری زمین: مسکونی، تجاری، کشاورزی و غیره
        public string? LandUseType { get; set; }

        // وضعیت داخل محدوده شهری بودن زمین
        public bool IsInsideUrbanBoundary { get; set; }

        // وضعیت قرارگیری زمین در بافت شهری
        public bool IsInUrbanTexture { get; set; }

        // وضعیت قرارگیری زمین در بافت روستایی
        public bool IsInRuralTexture { get; set; }

        // وضعیت داشتن بر خیابان
        public bool HasStreetFrontage { get; set; }

        // طول بر زمین بر حسب متر
        public decimal? FrontageLength { get; set; }

        // عمق زمین بر حسب متر
        public decimal? LandDepth { get; set; }

        // وضعیت دوبر بودن زمین
        public bool IsCornerLot { get; set; }

        // وضعیت چندبر بودن زمین
        public bool IsMultiFrontage { get; set; }

        // تعداد برهای زمین
        public int? FrontageCount { get; set; }

        // وضعیت امکان ساخت‌وساز
        public bool IsBuildable { get; set; }

        // تراکم مجاز ساخت بر حسب درصد
        public decimal? AllowedDensity { get; set; }

        // سطح اشغال مجاز بر حسب درصد
        public decimal? AllowedCoverage { get; set; }

        // تعداد طبقات مجاز ساخت
        public int? AllowedFloors { get; set; }

        // وضعیت دسترسی به آب شهری
        public bool HasWaterConnection { get; set; }

        // وضعیت دسترسی به برق شهری
        public bool HasElectricityConnection { get; set; }

        // وضعیت دسترسی به گاز شهری
        public bool HasGasConnection { get; set; }

        // وضعیت دسترسی به شبکه فاضلاب
        public bool HasSewageConnection { get; set; }

        // وضعیت محصور بودن زمین
        public bool IsFenced { get; set; }

        // وضعیت دیوارکشی زمین
        public bool HasBoundaryWall { get; set; }

        // وضعیت شیب‌دار بودن زمین
        public bool IsSloped { get; set; }

        // وضعیت داشتن چاه آب
        public bool HasWaterWell { get; set; }

        // وضعیت داشتن حق‌آبه
        public bool HasWaterRights { get; set; }

        // توضیحات مربوط به زمین و قابلیت ساخت
        public string? LandDescription { get; set; }

        // نوع اسکلت ساختمان: بتنی، فلزی، بنایی و غیره
        public string? StructureType { get; set; }

        // نوع مصالح اصلی ساختمان
        public string? ConstructionMaterial { get; set; }

        // وضعیت داشتن سیستم ارتینگ
        public bool HasGroundingSystem { get; set; }

        // وضعیت داشتن سیستم برق‌کشی استاندارد
        public bool HasStandardElectricalSystem { get; set; }

        // وضعیت داشتن لوله‌کشی استاندارد
        public bool HasStandardPlumbing { get; set; }

        // وضعیت داشتن گواهی یا تأییدیه ایمنی
        public bool HasSafetyCertificate { get; set; }

        // وضعیت مناسب بودن ملک برای افراد دارای معلولیت
        public bool IsAccessibleForDisabled { get; set; }

        // وضعیت داشتن رمپ دسترسی
        public bool HasAccessibilityRamp { get; set; }

        // وضعیت مقاوم‌سازی ساختمان
        public bool IsRetrofitted { get; set; }

        // توضیحات مربوط به وضعیت سازه
        public string? StructureDescription { get; set; }



        // وضعیت فعلی ملک: خالی، دارای ساکن، اجاره‌داده‌شده و غیره
        public string? OccupancyStatus { get; set; }

        // مشخص می‌کند مالک در ملک سکونت دارد یا خیر
        public bool IsOwnerOccupied { get; set; }

        // مشخص می‌کند ملک در حال حاضر اجاره داده شده است یا خیر
        public bool IsRented { get; set; }

        // مشخص می‌کند ملک تخلیه شده است یا خیر
        public bool IsVacant { get; set; }

        // مشخص می‌کند ملک مناسب سکونت است یا خیر
        public bool IsSuitableForResidence { get; set; }

        // مشخص می‌کند ملک مناسب استفاده اداری است یا خیر
        public bool IsSuitableForOffice { get; set; }

        // مشخص می‌کند ملک مناسب استفاده تجاری است یا خیر
        public bool IsSuitableForCommercialUse { get; set; }

        // مشخص می‌کند امکان استفاده صنعتی وجود دارد یا خیر
        public bool IsSuitableForIndustrialUse { get; set; }

        // مشخص می‌کند امکان استفاده کشاورزی وجود دارد یا خیر
        public bool IsSuitableForAgriculture { get; set; }

        // مشخص می‌کند اجازه نگهداری حیوان خانگی وجود دارد یا خیر
        public bool AllowsPets { get; set; }

        // مشخص می‌کند امکان اجاره کوتاه‌مدت وجود دارد یا خیر
        public bool AllowsShortTermRental { get; set; }

        // حداقل مدت اجاره بر حسب ماه
        public int? MinimumRentalMonths { get; set; }

        // حداکثر مدت اجاره بر حسب ماه
        public int? MaximumRentalMonths { get; set; }

        // تاریخ تخلیه یا تحویل ملک
        public DateTime? AvailableFrom { get; set; }

        // توضیحات مربوط به شرایط سکونت و بهره‌برداری
        public string? OccupancyDescription { get; set; }


        // نوع فعالیت تجاری مجاز
        public string? CommercialActivityType { get; set; }

        // دارای ویترین
        public bool HasShowcase { get; set; }

        // طول ویترین یا بر تجاری بر حسب متر
        public decimal? ShowcaseLength { get; set; }

        // دارای کرکره برقی
        public bool HasElectricShutter { get; set; }

        // دارای انبار تجاری
        public bool HasCommercialStorage { get; set; }

        // دارای سرویس بهداشتی مستقل
        public bool HasPrivateRestroom { get; set; }

        // دارای اتاق مدیریت
        public bool HasManagementRoom { get; set; }

        // دارای اتاق جلسات
        public bool HasConferenceRoom { get; set; }

        // دارای اتاق سرور
        public bool HasServerRoom { get; set; }

        // دارای ورودی مستقل
        public bool HasIndependentEntrance { get; set; }

        // دارای مجوز فعالیت
        public bool HasBusinessLicense { get; set; }

        // وضعیت امکان دریافت مجوز کسب‌وکار
        public bool CanObtainBusinessLicense { get; set; }

        // میزان برق قابل استفاده بر حسب کیلووات
        public decimal? ElectricalCapacity { get; set; }

        // ارتفاع درب ورودی بر حسب متر
        public decimal? EntranceHeight { get; set; }

        // توضیحات مربوط به کاربری تجاری یا اداری
        public string? CommercialDescription { get; set; }

        // دارای حیاط خلوت
        public bool HasBackyard { get; set; }

        // دارای باربیکیو
        public bool HasBarbecue { get; set; }

        // دارای آلاچیق
        public bool HasGazebo { get; set; }

        // دارای آب‌نما
        public bool HasWaterFeature { get; set; }

        // دارای زمین بازی
        public bool HasPlayground { get; set; }

        // دارای اتاق مهمان مستقل
        public bool HasGuestRoom { get; set; }

        // دارای سوئیت مستقل
        public bool HasSeparateSuite { get; set; }

        // دارای آشپزخانه فضای باز
        public bool HasOutdoorKitchen { get; set; }

        // دارای انشعاب مستقل آب
        public bool HasIndependentWaterMeter { get; set; }

        // دارای انشعاب مستقل برق
        public bool HasIndependentElectricityMeter { get; set; }

        // دارای انشعاب مستقل گاز
        public bool HasIndependentGasMeter { get; set; }



        // نام سازنده یا شرکت سازنده
        public string? BuilderName { get; set; }

        // نام پروژه ساختمانی
        public string? ProjectName { get; set; }

        // نام مالک، در صورت نیاز و با رعایت حریم خصوصی
        public string? OwnerName { get; set; }



        // متن کوتاه معرفی ملک
        public string? ShortDescription { get; set; }



        // توضیحات مربوط به امکانات محله
        public string? NeighborhoodDescription { get; set; }

        // توضیحات مربوط به چشم‌انداز ملک
        public string? ViewDescription { get; set; }

        // وضعیت امکان بازدید حضوری
        public bool AllowsInPersonVisit { get; set; } = true;

        // توضیحات مربوط به زمان و شرایط بازدید
        public string? VisitDescription { get; set; }

        // توضیحات مدیریتی داخلی که به کاربران نمایش داده نمی‌شود
        public string? InternalNotes { get; set; }


        public virtual ApplicationUser Author { get; set; }
        public virtual Language Language { get; set; }



    }
}