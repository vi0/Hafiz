//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserGroup
    {
        public UserGroup()
        {
            this.Users = new HashSet<User>();
        }
    
        public int Id { get; set; }
        public string Key { get; set; }
        public string FriendlyName { get; set; }
    
        public virtual ICollection<User> Users { get; set; }
    }
}
