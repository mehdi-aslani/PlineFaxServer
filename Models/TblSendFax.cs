using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PlineFaxServer.Models.Users;
using PlineFaxServer.Tools;

namespace PlineFaxServer.Models
{
    public class TblSendFax
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "تاریخ")]
        [MaxLength(10)]
        public string Date { get; set; }

        [Required]
        [Display(Name = "ساعت")]
        [MaxLength(5)]
        public string Time { get; set; }

        [Required]
        [Display(Name = "فرستنده فکس")]
        [MaxLength(20)]
        public string CallerId { get; set; }

        [Required(ErrorMessage = "{0} نمی تواند خالی باشد.")]
        [Display(Name = "شماره مقصد فکس")]
        [MaxLength(20)]
        public string Line { get; set; }

        //[Required(ErrorMessage="مقدار {0} نمی تواند خالی باشد")]
        [Display(Name = "نام فایل فکس")]
        [MaxLength(255)]
        public string FileName { get; set; }

        //[Required]
        [Display(Name = "مسبر کامل فایل")]
        [MaxLength(255)]
        public string FullPath { get; set; }

        [Required]
        [Display(Name = "وضعیت ارسال فکس")]
        public Globals.FaxStatus Status { get; set; }
        
        [ForeignKey("PK_UserId")]
        public TblUser UserId { get; set; }
    }
}