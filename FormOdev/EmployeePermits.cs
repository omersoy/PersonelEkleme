//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FormOdev
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployeePermits
    {
        public int PermitID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<int> PermitsLeft { get; set; }
        public Nullable<int> SpecialPermitCount { get; set; }
        public Nullable<int> AnnualPermitCount { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
