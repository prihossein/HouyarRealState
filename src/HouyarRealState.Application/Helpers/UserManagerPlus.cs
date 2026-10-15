

using HouyarRealState.Domain.Entities.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace HouyarRealState.Application.Helpers
{
    public class CustomIdentityErrorDescriber : IdentityErrorDescriber
    {
        #region UserNotInRole
        public override IdentityError UserNotInRole(string role)
        {
            return new IdentityError
            {
                Code = nameof(UserNotInRole),
                Description = $"کاربر عضو نقش '{role}' نیست."
            };
        }
        #endregion

        #region UserAlreadyInRole
        public override IdentityError UserAlreadyInRole(string role)
        {
            return new IdentityError
            {
                Code = nameof(UserAlreadyInRole),
                Description = $"کاربر از قبل عضو نقش '{role}' است."
            };
        }
        #endregion


        public override IdentityError InvalidToken()
        {
            return new IdentityError
            {
                Code = nameof(InvalidToken),
                Description = "توکن معتبر نیست یا منقضی شده است."
            };
        }

        public override IdentityError RecoveryCodeRedemptionFailed()
        {
            return new IdentityError
            {
                Code = nameof(RecoveryCodeRedemptionFailed),
                Description = "استفاده از کد بازیابی با شکست مواجه شد. لطفاً کد معتبر وارد کنید."
            };
        }

        public override IdentityError UserLockoutNotEnabled()
        {
            return new IdentityError
            {
                Code = nameof(UserLockoutNotEnabled),
                Description = "قابلیت قفل شدن حساب کاربری برای این کاربر فعال نیست."
            };
        }

        public override IdentityError DefaultError()
        {
            return new IdentityError
            {
                Code = nameof(DefaultError),
                Description = "خطای نامشخصی رخ داده است. لطفاً دوباره تلاش کنید."
            };
        }

        public override IdentityError ConcurrencyFailure()
        {
            return new IdentityError
            {
                Code = nameof(ConcurrencyFailure),
                Description = "خطا در بروزرسانی اطلاعات به دلیل تغییرات همزمان. لطفاً دوباره تلاش کنید."
            };
        }

        public override IdentityError LoginAlreadyAssociated()
        {
            return new IdentityError
            {
                Code = nameof(LoginAlreadyAssociated),
                Description = "این ورود خارجی قبلاً به یک حساب کاربری دیگر متصل شده است."
            };
        }

        public override IdentityError InvalidRoleName(string? role)
        {
            return new IdentityError
            {
                Code = nameof(InvalidRoleName),
                Description = $"نام نقش '{role}' معتبر نیست."
            };
        }

        public override IdentityError InvalidEmail(string? email)
        {
            return new IdentityError
            {
                Code = nameof(InvalidEmail),
                Description = $"ایمیل '{email}' معتبر نیست."
            };
        }

        public override IdentityError DuplicateRoleName(string role)
        {
            return new IdentityError
            {
                Code = nameof(DuplicateRoleName),
                Description = $"نقشی با عنوان '{role}' قبلاً ایجاد شده است."
            };
        }

        public override IdentityError DuplicateEmail(string email)
        {
            return new IdentityError
            {
                Code = nameof(DuplicateEmail),
                Description = $"ایمیل '{email}' قبلاً در سیستم ثبت شده است."
            };
        }

        public override IdentityError UserAlreadyHasPassword()
        {
            return new IdentityError
            {
                Code = nameof(UserAlreadyHasPassword),
                Description = "این کاربر قبلاً دارای کلمه عبور است."
            };
        }
        public override IdentityError PasswordRequiresUniqueChars(int uniqueChars)
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresUniqueChars),
                Description = $"کلمه عبور باید حداقل شامل {uniqueChars} کاراکتر منحصربه‌فرد باشد."
            };
        }

        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresUpper),
                Description = "کلمه عبور باید حداقل شامل یک حرف بزرگ انگلیسی باشد."
            };
        }

        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresLower),
                Description = "کلمه عبور باید حداقل شامل یک حرف کوچک انگلیسی باشد."
            };
        }

        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresDigit),
                Description = "کلمه عبور باید حداقل شامل یک رقم (0 تا 9) باشد."
            };
        }
        public override IdentityError PasswordMismatch()
        {
            return new IdentityError
            {
                Code = nameof(PasswordMismatch),
                Description = "کلمه عبور وارد شده صحیح نیست."
            };
        }

        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError
            {
                Code = nameof(PasswordTooShort),
                Description = $"کلمه عبور باید حداقل {length} کاراکتر باشد."
            };
        }

        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresNonAlphanumeric),
                Description = "کلمه عبور باید حداقل شامل یک کاراکتر غیر حرف و عدد باشد."
            };
        }

        public override IdentityError DuplicateUserName(string userName)
        {
            return new IdentityError
            {
                Code = nameof(DuplicateUserName),
                Description = $"نام کاربری '{userName}' قبلاً ثبت شده است."
            };
        }

        public override IdentityError InvalidUserName(string userName)
        {
            return new IdentityError
            {
                Code = nameof(InvalidUserName),
                Description = $"نام کاربری '{userName}' معتبر نیست."
            };
        }


    }


    public class UserManagerPlus : UserManager<ApplicationUser>
    {

        public UserManagerPlus(IUserStore<ApplicationUser> store, IOptions<IdentityOptions> optionsAccessor, IPasswordHasher<ApplicationUser> passwordHasher, IEnumerable<IUserValidator<ApplicationUser>> userValidators, IEnumerable<IPasswordValidator<ApplicationUser>> passwordValidators, ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, IServiceProvider services, ILogger<UserManager<ApplicationUser>> logger) : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {

        }

        public async Task<bool> ExistMobileForUpdateAsync(string mobile, string userName)
        {
            var user = await FindByNameAsync(userName);

            return await Users.AnyAsync(x => x.Mobile.Trim() == mobile.Trim() && x.Id != user.Id);
        }
        public async Task<ApplicationUser> FindByPhoneNumberAsync(string PhoneNumber)
        {
            return await Users.Where(u => u.PhoneNumber.Trim().ToLower() == PhoneNumber.Trim().ToLower()).FirstOrDefaultAsync();
        }

        public async Task<ApplicationUser> FindByMobileAsync(string mobile)
        {
            return await Users.Where(u => u.Mobile.Trim().ToLower() == mobile.Trim().ToLower()).FirstOrDefaultAsync();
        }

        public async Task<ApplicationUser> FindByUserNameOrEmailAsync(string userNameOrEmail)
        {
            return await Users.Where(u => u.UserName.ToLower() == userNameOrEmail.ToLower() || u.Email.ToLower() == userNameOrEmail.ToLower()).SingleOrDefaultAsync();
        }


        public async Task<bool> ExistByUserNameAsync(string userName)
        {
            return await Users.AnyAsync(u => u.UserName.ToLower() == userName.ToLower());
        }


        public async Task<bool> ExistByCodeAsync(string code)
        {
            return await Users.AnyAsync(u => u.Code.ToLower() == code.Trim().ToLower());
        }

        public async Task<bool> ExistByEmailAsync(string email)
        {
            return await Users.AnyAsync(u => u.Email.ToLower() == email.ToLower());
        }

        public async Task<bool> ExistByMobileAsync(string mobile)
        {
            return await Users.AnyAsync(u => u.Mobile.ToLower() == mobile.ToLower());
        }

        public async Task<bool> IsDeletedUserAsync(string userName)
        {
            return await Users.IgnoreQueryFilters().AnyAsync(u => u.UserName.ToLower() == userName.ToLower() && u.IsDelete == true);
        }

        public async Task<bool> IsDeletedEmailAsync(string email)
        {
            return await Users.IgnoreQueryFilters().AnyAsync(u => u.Email.ToLower() == email.ToLower() && u.IsDelete == true);
        }
        public async Task<bool> IsDeletedPhoneNumberAsync(string phoneNumber)
        {
            return await Users.IgnoreQueryFilters().AnyAsync(u => u.PhoneNumber.ToLower() == phoneNumber.ToLower() && u.IsDelete == true);
        }
        public async Task<bool> ExistByPhoneNumberAsync(string phoneNumber)
        {
            return await Users.AnyAsync(u => u.PhoneNumber == phoneNumber);
        }

        public async Task<Guid> GetIdByUserName(string userName)
        {
            var user = await FindByNameAsync(userName);
            return user.Id;
        }

    }
}
