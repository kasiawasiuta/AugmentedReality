//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessDenormalized
{
    using System;
    using System.Collections.Generic;
    
    public partial class note
    {
        public int Id { get; set; }
        public Nullable<int> UserId { get; set; }
        public string Topic { get; set; }
        public string Content { get; set; }
        public int LocationId { get; set; }
        public Nullable<decimal> XCord { get; set; }
        public Nullable<decimal> YCord { get; set; }
        public Nullable<decimal> ZCord { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Mail { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    }
}
