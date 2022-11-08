using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;

namespace BlogTrackerApp.Models
{
    public class AdminModel
    {
        [Key]
        [Required(ErrorMessage = "Please enter your email address")]
        [DataType(DataType.EmailAddress)]
        public string EmailID { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}