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
    
    public partial class group
    {
        public group()
        {
            this.notesgroups = new HashSet<notesgroups>();
            this.usergroup = new HashSet<usergroup>();
            this.notesgroups = new HashSet<notesgroups>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<notesgroups> notesgroups { get; set; }
        public virtual ICollection<usergroup> usergroup { get; set; }
        public virtual ICollection<notesgroups> notesgroups { get; set; }
    }
}
