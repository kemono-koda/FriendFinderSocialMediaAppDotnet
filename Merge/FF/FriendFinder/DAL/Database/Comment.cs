//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public Comment()
        {
            this.Replies = new HashSet<Reply>();
        }
    
        public int Id { get; set; }
        public string Cmnt { get; set; }
        public int Post_id { get; set; }
        public int User_id { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual Post Post { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Reply> Replies { get; set; }
    }
}
