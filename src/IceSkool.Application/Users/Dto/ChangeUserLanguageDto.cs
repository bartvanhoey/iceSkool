using System.ComponentModel.DataAnnotations;

namespace IceSkool.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}