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
    
    public partial class ViewLogs
    {
        public int FilmId { get; set; }
        public Nullable<int> ViewedCount { get; set; }
        public System.DateTime ViewDate { get; set; }
    
        public virtual Films Films { get; set; }
    }
}
