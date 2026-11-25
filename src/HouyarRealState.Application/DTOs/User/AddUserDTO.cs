using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HouyarRealState.Application.DTOs.User
{
    public class AddUserDTO
    {
        [Display(Name = "")]
        [Required(ErrorMessage = "{0} نمی‌تواند خالی باشد", AllowEmptyStrings = false)]
        public string Mobile { get; set; }

        [Display(Name = "نام و نام خانوادگی")]
        [Required(ErrorMessage = "{0} نمی‌تواند خالی باشد", AllowEmptyStrings = false)]
        public string FullName { get; set; }

        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "{0} نمی‌تواند خالی باشد", AllowEmptyStrings = false)]
        public string UserName { get; set; }

        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "{0} نمی‌تواند خالی باشد", AllowEmptyStrings = false)]
        [EmailAddress(ErrorMessage = "{0} وارد شده معتبر نمی‌باشد")]
        public string Email { get; set; }

        [Display(Name = "چت آی‌دی بله")]
        public string? BaleChatId { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "{0} نمی‌تواند خالی باشد", AllowEmptyStrings = false)]
        public string Password { get; set; }

        [Display(Name = "تایید کلمه عبور")]
        [Required(ErrorMessage = "{0} نمی‌تواند خالی باشد", AllowEmptyStrings = false)]
        [Compare("Password", ErrorMessage = "کلمه عبور و تایید آن یکسان نیستند")]
        public string ConfirmPassword { get; set; }

        public List<string> Role { get; set; } = new List<string>();
    }
}
