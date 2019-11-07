using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VoteSmart.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string firstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        [Required]
        [Display(Name = "Street Address")]
        public string streetAddress { get; set; }
        [Required]
        [Display(Name = "City")]
        public string city { get; set; }
        [Required]
        [Display(Name = "State Code")]
        public string stateCode { get; set; }
        [Required]
        [Display(Name = "ZIP Code")]
        public int zipcode { get; set; }
        public float lat { get; set; }
        public float lng { get; set; }
        [Display(Name = "Republican")]
        public bool republican { get; set; }
        [Display(Name = "Democrat")]
        public bool democrat { get; set; }
        [Display(Name = "Independant")]
        public bool independant { get; set; }
        [Display(Name = "Undecided")]
        public bool undecided { get; set; }
    }
}