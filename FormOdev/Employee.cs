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
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.EmployeePermits = new HashSet<EmployeePermits>();
        }
    
        public int EmployeeID { get; set; }
        public Nullable<long> TC { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Nullable<System.DateTime> BDate { get; set; }
        public Nullable<System.DateTime> WDate { get; set; }
        public string KanGrubu { get; set; }
        public string Address { get; set; }
        public string NetMaas { get; set; }
        public string FYolu { get; set; }
        public Nullable<System.DateTime> WCikmaDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeePermits> EmployeePermits { get; set; }
    }
}
