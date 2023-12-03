using System.ComponentModel.DataAnnotations;

namespace BankApp.WebApi.Models.ModelMetadataTypes
{
    public class BankAccMetadata
    {
        [Required(ErrorMessage = "Lütfen adınızı giriniz.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Adınız 3 ile 20 karakter arasında olmalıdır.")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Lütfen soyadınızı giriniz.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Soyadınız 3 ile 20 karakter arasında olmalıdır.")]
        public string Soyad { get; set; }

        [Required(ErrorMessage = "Lütfen telefon numaranızı giriniz.")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Telefon numarası 10 basamaklı olmalıdır.")]
        public string TelefonNumarasi { get; set; }

    }
}
