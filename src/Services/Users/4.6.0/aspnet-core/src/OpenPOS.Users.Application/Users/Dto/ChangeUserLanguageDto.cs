using System.ComponentModel.DataAnnotations;

namespace OpenPOS.Users.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}