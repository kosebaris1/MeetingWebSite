using System.ComponentModel.DataAnnotations;

namespace MeetingWebSite.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Ad Alanı zorunlu")]
        public string? Name { get; set; }

        [Required(ErrorMessage ="Telefon numarası giriniz")]
        public string? Phone { get; set; }

        [Required(ErrorMessage ="E-posta Adresi girinz")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public bool WillAttend { get; set; }


    }
}
