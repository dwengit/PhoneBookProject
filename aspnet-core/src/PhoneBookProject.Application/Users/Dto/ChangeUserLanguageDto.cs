using System.ComponentModel.DataAnnotations;

namespace PhoneBookProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}