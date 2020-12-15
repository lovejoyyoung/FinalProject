//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Apartment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Apartment()
        {
            this.Appointments = new HashSet<Appointment>();
        }
    
        public int ApartmentNumber { get; set; }
        public int TenantId { get; set; }
        public string ApartmentArea { get; set; }
        public string ApartmentDescription { get; set; }
        public int BuildingId { get; set; }
        public string Status { get; set; }
        public int ManagerId { get; set; }
    
        public virtual Building Building { get; set; }
        public virtual Manager Manager { get; set; }
        public virtual Tenant Tenant { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
