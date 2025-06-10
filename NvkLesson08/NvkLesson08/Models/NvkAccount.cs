using System.ComponentModel.DataAnnotations;

namespace NvkLesson08.Models
{
    public class NvkAccount
    {
        [Key]
        public int NvkId { get; set; }

        [Display(Name="Ho va ten")]
        [Required(ErrorMessage ="Ho va ten khong duoc de trong")]
        [MinLength(6, ErrorMessage = "Họ tên ít nhất là 6 ký tự")]
        [MaxLength(20, ErrorMessage = "Họ tên tối đa 20 ký tự")]
        public string NvkFullName { get; set; }

        [Display(Name = "Địa chỉ email")]
        [Required(ErrorMessage = "Địa chỉ email không được để trống")]
        [EmailAddress(ErrorMessage = "Địa chỉ email không đúng định dạng")]
        [DataType(DataType.EmailAddress)]
        public string NvkEmail { get; set; }

        [Display(Name = "Số điện thoại")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\+?[0-9]{3})?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
           ErrorMessage = "Số điện thoại không đúng định dạng")]
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        public string NvkPhone { get; set; }

        [Display(Name = "Địa chỉ thường trú")]
        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        [StringLength(35, ErrorMessage = "Địa chỉ không vượt quá 35 ký tự")]
        public string NvkAddress { get; set; }

        [Display(Name = "Ảnh đại diện")]
        public string NvkAvatar { get; set; }

        [Display(Name = "Ngày sinh")]
        [Required(ErrorMessage = "Ngày sinh không được để trống")]
        [DataType(DataType.Date)]
        public DateTime NvkBirthday { get; set; }

        [Display(Name = "Giới tính")]
        public string NvkGender { get; set; }

        [Display(Name = "Mật khẩu")]
        [DataType(DataType.Password)]
        public string NvkPassword { get; set; }

        [Display(Name = "Link Facebook cá nhân")]
        [Required(ErrorMessage = "Link Facebook không được để trống")]
        [Url(ErrorMessage = "Url phải đúng định dạng bao gồm http hoặc https, tên miền VD: https://facebook.com/itvnsoft")]
        public string NvkFacebook { get; set; }
    }
}