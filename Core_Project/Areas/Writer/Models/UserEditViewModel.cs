using Microsoft.AspNetCore.Http;

namespace Core_Project.Areas.Writer.Models
{
    public class UserEditViewModel
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public string PictureUrl { get; set; }

        public string Mail { get; set; }


        public IFormFile Picture { get; set; }
    }
}
