using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginReg
{    
    [Table("users")]
    public class User
    {
        [Key]
        public int UserId {get;set;}
        [Required]
        [MinLength(2, ErrorMessage="First Name must be at least 2 characters.")]
        public string first_name {get;set;}
        [Required]
        [MinLength(2, ErrorMessage="Last Name must be at least 2 characters.")]
        public string last_name {get;set;}
        [EmailAddress]
        [Required]
        public string Email {get;set;}
        [DataType(DataType.Password)]
        [Required]
        [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
        public string Password {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        // Will not be mapped to your users table!
        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string Confirm {get;set;}
    }

        public class LoginUser
        {
            [Required]
            [EmailAddress]
            public string Email {get; set;}
            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
        }











}        
