using HouyarRealState.Domain.Entities.Properties;

namespace HouyarRealState.Infrastructure.Persistence.SeedData
{
    public static class SeedDatas
    {


        public static async Task SeedPropertyStatusAsync(ApplicationDbContext dbContext)
        {
            var propertyStatuses = new List<PropertyStatus>
    {
        new PropertyStatus
        {
                    Id = Guid.Parse("50000000-0000-0000-0000-000000000001"),
                    Title = "در حال اجرا"
        },
        new PropertyStatus
        {
                    Id = Guid.Parse("50000000-0000-0000-0000-000000000002"),
                    Title = "پایان یافته"
        }};

            var existingTitles = await dbContext.Set<PropertyStatus>()
                .Select(pf => pf.Title)
                .ToListAsync();

            var newPropertyStatuses = propertyStatuses
                .Where(pf => !existingTitles.Contains(pf.Title))
                .ToList();

            if (newPropertyStatuses.Any())
            {
                await dbContext.Set<PropertyStatus>()
                    .AddRangeAsync(newPropertyStatuses);

                await dbContext.SaveChangesAsync();
            }
        }



        public static async Task SeedPropertyRequestTypeAsync(ApplicationDbContext dbContext)
        {
            var now = DateTime.UtcNow;

            var propertyRequestTypes = new List<PropertyRequestType>
    {
        new PropertyRequestType
        {
                    Id = Guid.Parse("10000000-0000-0000-0000-000000000001"),
                    Title = "عرضه ملک",
                    Code = "Offer",
        },
        new PropertyRequestType
        {
                    Id = Guid.Parse("10000000-0000-0000-0000-000000000002"),
                    Title = "تقاضای ملک",
                    Code = "Demand",
        }};

            var existingTitles = await dbContext.Set<PropertyRequestType>()
                .Select(pf => pf.Title)
                .ToListAsync();

            var newPropertyRequestTypes = propertyRequestTypes
                .Where(pf => !existingTitles.Contains(pf.Title))
                .ToList();

            if (newPropertyRequestTypes.Any())
            {
                await dbContext.Set<PropertyRequestType>()
                    .AddRangeAsync(newPropertyRequestTypes);

                await dbContext.SaveChangesAsync();
            }
        }




        public static async Task SeedPropertyFeaturesAsync(ApplicationDbContext dbContext)
        {
            var now = DateTime.UtcNow;

            var propertyFeatures = new List<PropertyFeature>
    {
        new PropertyFeature
        {
            Id = Guid.Parse("30000000-0000-0000-0000-000000000001"),
            Title = "استخر",
            IsDelete = false
        },
        new PropertyFeature
        {
            Id = Guid.Parse("30000000-0000-0000-0000-000000000002"),
            Title = "سونا",
            IsDelete = false
        },
        new PropertyFeature
        {
            Id = Guid.Parse("30000000-0000-0000-0000-000000000003"),
            Title = "جکوزی",
            IsDelete = false
        },
        new PropertyFeature
        {
            Id = Guid.Parse("30000000-0000-0000-0000-000000000004"),
            Title = "آسانسور",
            IsDelete = false
        },
        new PropertyFeature
        {
            Id = Guid.Parse("30000000-0000-0000-0000-000000000005"),
            Title = "پارکینگ",
            IsDelete = false
        },
        new PropertyFeature
        {
            Id = Guid.Parse("30000000-0000-0000-0000-000000000006"),
            Title = "انباری",
            IsDelete = false
        },
        new PropertyFeature
        {
            Id = Guid.Parse("30000000-0000-0000-0000-000000000007"),
            Title = "لابی",
            IsDelete = false
        },
        new PropertyFeature
        {
            Id = Guid.Parse("30000000-0000-0000-0000-000000000008"),
            Title = "نگهبانی",
            IsDelete = false
        },
        new PropertyFeature
        {
            Id = Guid.Parse("30000000-0000-0000-0000-000000000009"),
            Title = "دوربین مداربسته",
            IsDelete = false
        },
        new PropertyFeature
        {
            Id = Guid.Parse("30000000-0000-0000-0000-000000000010"),
            Title = "سیستم اعلام و اطفای حریق",
            IsDelete = false
        },
        new PropertyFeature
        {
            Id = Guid.Parse("30000000-0000-0000-0000-000000000011"),
            Title = "بالکن",
            IsDelete = false
        },
        new PropertyFeature
        {
            Id = Guid.Parse("30000000-0000-0000-0000-000000000012"),
            Title = "تراس",
            IsDelete = false
        },
        new PropertyFeature
        {
            Id = Guid.Parse("30000000-0000-0000-0000-000000000013"),
            Title = "روف گاردن",
            IsDelete = false
        },
        new PropertyFeature
        {
            Id = Guid.Parse("30000000-0000-0000-0000-000000000014"),
            Title = "حیاط",
            IsDelete = false
        },
        new PropertyFeature
        {
            Id = Guid.Parse("30000000-0000-0000-0000-000000000015"),
            Title = "آب‌نما",
            IsDelete = false
        },
        new PropertyFeature
        {
            Id = Guid.Parse("30000000-0000-0000-0000-000000000016"),
            Title = "سیستم گرمایش مرکزی",
            IsDelete = false
        },
        new PropertyFeature
        {
            Id = Guid.Parse("30000000-0000-0000-0000-000000000017"),
            Title = "سیستم سرمایش مرکزی",
            IsDelete = false
        },
        new PropertyFeature
        {
            Id = Guid.Parse("30000000-0000-0000-0000-000000000018"),
            Title = "درب ضد سرقت",
            IsDelete = false
        },
        new PropertyFeature
        {
            Id = Guid.Parse("30000000-0000-0000-0000-000000000019"),
            Title = "پنجره دوجداره",
            IsDelete = false
        },
        new PropertyFeature
        {
            Id = Guid.Parse("30000000-0000-0000-0000-000000000020"),
            Title = "آنتن مرکزی",
            IsDelete = false
        }
    };

            var existingTitles = await dbContext.Set<PropertyFeature>()
                .Select(pf => pf.Title)
                .ToListAsync();

            var newPropertyFeatures = propertyFeatures
                .Where(pf => !existingTitles.Contains(pf.Title))
                .ToList();

            if (newPropertyFeatures.Any())
            {
                await dbContext.Set<PropertyFeature>()
                    .AddRangeAsync(newPropertyFeatures);

                await dbContext.SaveChangesAsync();
            }
        }

        public static async Task SeedTransactionTypesAsync(ApplicationDbContext dbContext)
        {
            var transactionTypes = new List<TransactionType>
    {
        new TransactionType
        {
            Id = Guid.Parse("20000000-0000-0000-0000-000000000001"),
            Title = "خرید",
            IsDelete = false
        },
        new TransactionType
        {
            Id = Guid.Parse("20000000-0000-0000-0000-000000000002"),
            Title = "فروش",
            IsDelete = false,
        },
        new TransactionType
        {
            Id = Guid.Parse("20000000-0000-0000-0000-000000000003"),
            Title = "رهن",
            IsDelete = false,
        },
        new TransactionType
        {
            Id = Guid.Parse("20000000-0000-0000-0000-000000000004"),
            Title = "اجاره",
            IsDelete = false,
        },
        new TransactionType
        {
            Id = Guid.Parse("20000000-0000-0000-0000-000000000005"),
            Title = "رهن و اجاره",
            IsDelete = false,
        },
        new TransactionType
        {
            Id = Guid.Parse("20000000-0000-0000-0000-000000000006"),
            Title = "پیش‌ فروش",
            IsDelete = false,
        },
        new TransactionType
        {
            Id = Guid.Parse("20000000-0000-0000-0000-000000000007"),
            Title = "معاوضه",
            IsDelete = false,
        }
    };

            var existingTitles = await dbContext.Set<TransactionType>()
                .Select(tt => tt.Title)
                .ToListAsync();

            var newTransactionTypes = transactionTypes
                .Where(tt => !existingTitles.Contains(tt.Title))
                .ToList();

            if (newTransactionTypes.Any())
            {
                await dbContext.Set<TransactionType>()
                    .AddRangeAsync(newTransactionTypes);

                await dbContext.SaveChangesAsync();
            }
        }



        public static async Task SeedPropertyTypesAsync(ApplicationDbContext dbContext)
        {
            var propertyTypes = new List<PropertyType>
            {
                new PropertyType
                {
                    Id = Guid.Parse("10000000-0000-0000-0000-000000000001"),
                    Title = "آپارتمان",
                    IsDelete = false,
                    CreateDate = DateTime.UtcNow,
                    ModifyDate = DateTime.UtcNow
                },
                new PropertyType
                {
                    Id = Guid.Parse("10000000-0000-0000-0000-000000000002"),
                    Title = "خانه ویلایی",
                    IsDelete = false,
                    CreateDate = DateTime.UtcNow,
                    ModifyDate = DateTime.UtcNow
                },
                new PropertyType
                {
                    Id = Guid.Parse("10000000-0000-0000-0000-000000000003"),
                    Title = "زمین",
                    IsDelete = false,
                    CreateDate = DateTime.UtcNow,
                    ModifyDate = DateTime.UtcNow
                },
                new PropertyType
                {
                    Id = Guid.Parse("10000000-0000-0000-0000-000000000004"),
                    Title = "مغازه",
                    IsDelete = false,
                    CreateDate = DateTime.UtcNow,
                    ModifyDate = DateTime.UtcNow
                },
                new PropertyType
                {
                    Id = Guid.Parse("10000000-0000-0000-0000-000000000005"),
                    Title = "دفتر کار",
                    IsDelete = false,
                    CreateDate = DateTime.UtcNow,
                    ModifyDate = DateTime.UtcNow
                },
                new PropertyType
                {
                    Id = Guid.Parse("10000000-0000-0000-0000-000000000006"),
                    Title = "باغ",
                    IsDelete = false,
                    CreateDate = DateTime.UtcNow,
                    ModifyDate = DateTime.UtcNow
                },
                new PropertyType
                {
                    Id = Guid.Parse("10000000-0000-0000-0000-000000000007"),
                    Title = "سوله و انبار",
                    IsDelete = false,
                    CreateDate = DateTime.UtcNow,
                    ModifyDate = DateTime.UtcNow
                },
                new PropertyType
                {
                    Id = Guid.Parse("10000000-0000-0000-0000-000000000008"),
                    Title = "ملک کلنگی",
                    IsDelete = false,
                    CreateDate = DateTime.UtcNow,
                    ModifyDate = DateTime.UtcNow
                }
            };

            var existingTitles = await dbContext.Set<PropertyType>()
                .Select(pt => pt.Title)
                .ToListAsync();

            var newPropertyTypes = propertyTypes
                .Where(pt => !existingTitles.Contains(pt.Title))
                .ToList();

            if (newPropertyTypes.Any())
            {
                await dbContext.Set<PropertyType>()
                    .AddRangeAsync(newPropertyTypes);

                await dbContext.SaveChangesAsync();
            }
        }
    }
}