//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace congcong.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class cc_publicMessage
    {
        public string contentText { get; set; }
        public System.DateTime date { get; set; }
        public int id { get; set; }
        public int recieveId { get; set; }
        public int senderId { get; set; }
    
        public virtual cc_user cc_user { get; set; }
        public virtual cc_user cc_user1 { get; set; }
    }
}
