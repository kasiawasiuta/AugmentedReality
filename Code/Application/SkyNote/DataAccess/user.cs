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
    
    public partial class user
    {
        public user()
        {
            this.note = new HashSet<note>();
            this.usergroup = new HashSet<usergroup>();
            this.userfriends = new HashSet<userfriends>();
            this.notesgroups = new HashSet<notesgroups>();
            this.userfriendsinvites = new HashSet<userfriendsinvites>();
            this.usergroupinvites = new HashSet<usergroupinvites>();
        }
    
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
    
        public virtual ICollection<note> note { get; set; }
        public virtual ICollection<usergroup> usergroup { get; set; }
        public virtual ICollection<userfriends> userfriends { get; set; }
        public virtual ICollection<notesgroups> notesgroups { get; set; }
        public virtual ICollection<userfriendsinvites> userfriendsinvites { get; set; }
        public virtual ICollection<usergroupinvites> usergroupinvites { get; set; }
    }
}
