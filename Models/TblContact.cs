using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PlineFaxServer.Models.Users;

namespace PlineFaxServer.Models
{
    public class TblContact
    {
        public int Id { get; set; }

        [ForeignKey("PK_UserId")]
        public TblUser UserId { get; set; }

        [Required(ErrorMessage = "نام مخاطب نمی تواند خالی باشد")]
        [Display(Name = "نام مخاطب")]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required(ErrorMessage = "نام خانوادگی مخاطب نمی تواند خالی باشد")]
        [Display(Name = "نام خانوادگی مخاطب")]
        [MaxLength(255)]
        public string LastName { get; set; }

        [Display(Name = "نام مستعار")]
        [MaxLength(255)]
        public string NickName { get; set; }

        //[Required(ErrorMessage="شماره ی فکس نمی تواند خالی باشد")]
        [Display(Name = "شماره ی فکس")]
        [MaxLength(20)]
        public string FaxNumber { get; set; }

        [Display(Name = "شماره ی فکس دوم")]
        [MaxLength(20)]
        public string FaxNumber2 { get; set; }

        [Display(Name = "شماره ی فکس سوم")]
        [MaxLength(20)]
        public string FaxNumber3 { get; set; }

        //[Required(ErrorMessage="شماره ی تلفن نمی تواند خالی باشد")]
        [Display(Name = "شماره ی تلفن")]
        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        [Display(Name = "شماره ی تلفن دوم")]
        [MaxLength(20)]
        public string PhoneNumber2 { get; set; }

        [Display(Name = "شماره ی تلفن سوم")]
        [MaxLength(20)]
        public string PhoneNumber3 { get; set; }

        [Display(Name = "ایمیل ")]
        [MaxLength(255)]
        [EmailAddress(ErrorMessage = "ایمیل نامعتبر")]
        public string Email { get; set; }

        [Display(Name = "ایمیل دوم")]
        [MaxLength(255)]
        [EmailAddress(ErrorMessage = "ایمیل نامعتبر")]
        public string Email2 { get; set; }

        [EmailAddress(ErrorMessage = "ایمیل نامعتبر")]
        [Display(Name = "ایمیل سوم")]
        [MaxLength(255)]
        public string Email3 { get; set; }

        [Display(Name = "آدرس")]
        [MaxLength(600)]
        public string Address { get; set; }

        [Display(Name = "یادداشت ها")]
        [MaxLength(600)]
        public string Notes { get; set; }

        //[Required(ErrorMessage="شماره ی موبایل نمی تواند خالی باشد")]
        [Display(Name = "شماره ی موبایل")]
        [MaxLength(20)]
        public string MobileNumber { get; set; }

        [Display(Name = "شماره ی موبایل دوم")]
        [MaxLength(20)]
        public string MobileNumber2 { get; set; }

        [Display(Name = "شماره ی موبایل سوم")]
        [MaxLength(20)]
        public string MobileNumber3 { get; set; }
    }
}