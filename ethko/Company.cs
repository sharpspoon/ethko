//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ethko
{
    using System;
    using System.Collections.Generic;
    
    public partial class Company
    {
        public int CompanyId { get; set; }
        public string FstUser { get; set; }
        public System.DateTime InsDate { get; set; }
        public string Name { get; set; }
        public short Archived { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string MainPhone { get; set; }
        public string FaxNumber { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public byte[] RowVersion { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
    }
}
