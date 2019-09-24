using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your e-mail")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage ="Please enter a valid e-mail address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter a phone number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please choose an option so that we know whether you're attending or not")]
        public bool? WillAttend { get; set; }
    }
}
