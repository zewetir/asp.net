using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Register

    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name ="First Name ")]
        [StringLength(15, MinimumLength = 3)]
        //[StringLength(15, ErrorMessage = "Name length can't be more than 15.")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name ")]

        [StringLength(15, MinimumLength = 3)]
        //[StringLength(15, ErrorMessage = "Name length can't be more than 15.")]
        public string LasttName { get; set; }

        [Required]
        [Display(Name = "Username ")]

        [StringLength(15, MinimumLength = 3)]
        //[StringLength(15, ErrorMessage = "Name length can't be more than 15.")]
        public string username { get; set; }


        [Required]
        [Display(Name = "Password ")]

        [StringLength(10, MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        [NotMapped] // Does not effect with your database
        [Compare("Password")]
        public string ConfirmPassword { get; set; }


    }
}
