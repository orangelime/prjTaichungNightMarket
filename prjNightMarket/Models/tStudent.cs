//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace prjNightMarket.Models
{
    using System;
    using System.Collections.Generic;

    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class tStudent
    {
        [DisplayName("學號")]
        [Required(ErrorMessage ="學號不可空白")]
        [StringLength(7,ErrorMessage ="學號必須是2-7個字元",MinimumLength =2)]
        public string fStuId { get; set; }

        [DisplayName("姓名")]
        [Required(ErrorMessage = "姓名不可空白")]
        public string fName { get; set; }

        [DisplayName("信箱")]
        [EmailAddress(ErrorMessage = "Emai格式有誤")]
        public string fEmail { get; set; }

        [DisplayName("成績")]
        [Range(0,100,ErrorMessage = "分數必須是0-100")]
        public Nullable<int> fScore { get; set; }
    }
}
