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
    
    public partial class Applicant
    {
        public int Id { get; set; }
        public int Job_id { get; set; }
        public int User_id { get; set; }
    
        public virtual Job Job { get; set; }
        public virtual User User { get; set; }
    }
}