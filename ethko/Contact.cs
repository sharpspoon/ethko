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
    
    public partial class Contact
    {
        public int ContactId { get; set; }
        public string UserId { get; set; }
        public byte[] InsDate { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
    }
}
