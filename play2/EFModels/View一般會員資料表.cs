using System;
using System.Collections.Generic;

namespace play2.EFModels
{
    public partial class View一般會員資料表
    {
        public string MemberId { get; set; } = null!;
        public string? LoginEmail { get; set; }
        public string? LoginPw { get; set; }
        public string? MemberType { get; set; }
        public int? IsCheck { get; set; }
        public string? MemberName { get; set; }
        public string? PersonalNumber { get; set; }
        public string? Phone { get; set; }
    }
}
