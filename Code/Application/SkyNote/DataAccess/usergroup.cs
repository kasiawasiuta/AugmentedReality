//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class usergroup
    {
        public int RecordId { get; set; }
        public int UserId { get; set; }
        public int GroupId { get; set; }
    
        public virtual group group { get; set; }
        public virtual user user { get; set; }
    }
}
