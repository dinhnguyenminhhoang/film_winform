//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FilmApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Follows
    {
        public int UserId { get; set; }
        public int FilmId { get; set; }
        public System.DateTime FollowedDate { get; set; }
    
        public virtual Films Films { get; set; }
        public virtual Users Users { get; set; }
    }
}