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
    
    public partial class Category
    {
        public Category()
        {
            this.Tags = new HashSet<Tag>();
        }
    
        public int Id { get; set; }
        public string Key { get; set; }
        public string FriendlyName { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
