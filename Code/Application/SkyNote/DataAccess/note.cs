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
    
    public partial class note
    {
        public note()
        {
            this.notesgroups = new HashSet<notesgroups>();
        }
    
        public int Id { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> LocationId { get; set; }
        public string Topic { get; set; }
        public string Content { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<int> TypeId { get; set; }
    
        public virtual location location { get; set; }
        public virtual user user { get; set; }
        public virtual types types { get; set; }
        public virtual ICollection<notesgroups> notesgroups { get; set; }
    }
}
