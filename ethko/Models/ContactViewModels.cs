using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ethko.Models
{

    public class AddContactIndividualViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string FName { get; set; }

        [Display(Name = "Middle Name")]
        public string MName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LName { get; set; }

        [Required]
        [Display(Name = "UserId")]
        public string UserId { get; set; }

        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Client Portal")]
        public string EnableClientPortal { get; set; }

        [Display(Name = "Contact Group")]
        public string ContactGroupId { get; set; }

        [Display(Name = "Cell Phone")]
        public string CellPhone { get; set; }

        [Display(Name = "Work Phone")]
        public string WorkPhone { get; set; }

        [Display(Name = "Home Phone")]
        public string HomePhone { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Address2")]
        public string Address2 { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }

        [Display(Name = "Zip")]
        public string Zip { get; set; }

        [Display(Name = "Country")]
        public string Country { get; set; }
    }

    [Table("Contacts")]
    public class GetContactIndividualViewModel
    {
        [Display(Name = "First Name")]
        public string FName { get; set; }

        [Display(Name = "Last Name")]
        public string LName { get; set; }

        [Display(Name = "User Id")]
        public string UserId { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Contact Id")]
        public string ContactId { get; set; }

        [Display(Name = "Date Created")]
        public string InsDate { get; set; }
    }

    public class ContactIndividualViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Number { get; set; }
    }

    public class AddContactGroupViewModel
    {
        [Required]
        [Display(Name = "Contact Group")]
        public string ContactGroupName { get; set; }
    }
    
    public class AddCompanyViewModel
    {
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Website")]
        public string Website { get; set; }

        [Display(Name = "Main Phone")]
        public string MainPhone { get; set; }

        [Display(Name = "Fax Number")]
        public string FaxNumber { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Address2")]
        public string Address2 { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }

        [Display(Name = "Zip")]
        public string Zip { get; set; }

        [Display(Name = "Country")]
        public string Country { get; set; }
    }
}
