//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyEgitimAkademi_Portfolio.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Projects
    {
        public int projectsID { get; set; }
        public string tittle { get; set; }
        public string descreption { get; set; }
        public Nullable<int> projectCategory { get; set; }
        public Nullable<int> completeDay { get; set; }
        public Nullable<decimal> price { get; set; }
    
        public virtual Category Category { get; set; }
    }
}