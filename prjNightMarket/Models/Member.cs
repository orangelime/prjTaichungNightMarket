using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace prjNightMarket.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    public class Member
    {
        [DisplayName("帳號")]
        [Required(ErrorMessage="帳號不可空白")]
        [StringLength(15,ErrorMessage ="帳號必須是3-15個字元",MinimumLength =3)]
        public string UserId { get; set; }
               
        [DisplayName("姓名")]
        [Required(ErrorMessage = "姓名不可空白")]
        public string Name { get; set; }

        [DisplayName("密碼")]
        [Required(ErrorMessage = "密碼不可空白")]
        [StringLength(15, ErrorMessage = "密碼必須是3-15個字元", MinimumLength = 3)]
        [RegularExpression("^[a-zA-Z0-9!\"#$%&'()*+,./:;<=>?@\\^_`{|}~-]*$", ErrorMessage = "密碼格式錯誤！")]

        public string Pwd { get; set; }

        [DisplayName("信箱")]
        [Required(ErrorMessage = "Email格式有誤")]
        public string Email { get; set; }

        [DisplayName("生日")]
        [Required(ErrorMessage = "生日不可空白")]
        public DateTime BirthDay { get; set; }
    }
}