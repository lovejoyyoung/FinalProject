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
    
    public partial class Message
    {
        public int MessageId { get; set; }
        public string MessageText { get; set; }
        public int ManagerId { get; set; }
        public int TenantId { get; set; }
    
        public virtual Manager Manager { get; set; }
        public virtual Tenant Tenant { get; set; }
    }
}
