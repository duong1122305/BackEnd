using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.DTOs
{
    public class UserRegister
    {
        [Required(ErrorMessage = "Không được để trống")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Không được để trống"),
            RegularExpression(@"(^([a-zỳọáầảấờễàạằệếýộậốũứĩõúữịỗìềểẩớặòùồợãụủíỹắẫựỉỏừỷởóéửỵẳẹèẽổẵẻỡơôưăêâđ'A-ZỲỌÁẦẢẤỜỄÀẠẰỆẾÝỘẬỐŨỨĨÕÚỮỊỖÌỀỂẨỚẶÒÙỒỢÃỤỦÍỸẮẪỰỈỎỪỶỞÓÉỬỴẲẸÈẼỔẴẺỠƠÔƯĂÊÂĐ]{1,})((\s)([a-zỳọáầảấờễàạằệếýộậốũứĩõúữịỗìềểẩớặòùồợãụủíỹắẫựỉỏừỷởóéửỵẳẹèẽổẵẻỡơôưăêâđ'A-ZỲỌÁẦẢẤỜỄÀẠẰỆẾÝỘẬỐŨỨĨÕÚỮỊỖÌỀỂẨỚẶÒÙỒỢÃỤỦÍỸẮẪỰỈỎỪỶỞÓÉỬỴẲẸÈẼỔẴẺỠƠÔƯĂÊÂĐ]{1,}))*)$", ErrorMessage = "Tên chưa đúng định dạng")
        ]
        public string FullName { get; set; }

        [MaxLength(30, ErrorMessage = "Tối đa 30 ký tự"), MinLength(5, ErrorMessage = "Tối thiểu 5 ký tự")]
        public string? Alias { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        public string Password { get; set; }
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "Không được để trống"),
         RegularExpression(@"([\w]{5,20})+@[a-z]+\.([a-z]{2,3}|[a-z]{2,3}\.[a-z]{2,3})$", ErrorMessage = "Email chưa đúng định dạng")
        ]
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime Dob { get; set; }
    }
}
