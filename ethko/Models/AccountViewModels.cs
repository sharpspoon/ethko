﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ethko.Models
{
    // Models returned by AccountController actions.
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Hometown")]
        public string Hometown { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Hometown")]
        public string Hometown { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

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
}
