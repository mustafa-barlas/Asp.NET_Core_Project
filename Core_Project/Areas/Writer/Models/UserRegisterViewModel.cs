using System.ComponentModel.DataAnnotations;

namespace Core_Project.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen kulanıcı adı giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi  giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz")]
        [Compare("Password",ErrorMessage = "Şifre ayn değil")]
        public string ConfirmPassword { get; set; }


        [Required(ErrorMessage = "Lütfen mail adresinizi giriniz")]
        public string Mail { get; set; }
    }
}
