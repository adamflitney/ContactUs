using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactUs.Models
{
    public class ContactUsMessage
    {
        [Key]
        public int MessageId { get; set; }
        [Required]
        public string senderName { get; set; }
        [Required]
        [EmailAddress]
        public string emailAddress { get; set; }
        [Required]
        public string message { get; set; }
    }
}
