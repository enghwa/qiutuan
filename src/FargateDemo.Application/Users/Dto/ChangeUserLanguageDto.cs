using System.ComponentModel.DataAnnotations;

namespace FargateDemo.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}