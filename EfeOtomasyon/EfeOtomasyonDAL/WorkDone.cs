//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EfeOtomasyonDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class WorkDone
    {
        public int WorkDoneID { get; set; }
        public string PlugNo { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string WorkName { get; set; }
        public int CategoryID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public string Quantity { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public string ImagePath { get; set; }
        public string Link { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> CustomerID { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
    }
}