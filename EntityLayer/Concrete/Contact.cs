using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        [StringLength(100)]
        public string UserName { get; set; }
        [StringLength(100)]
        public string UserMail { get; set; }
        [StringLength(500)]
        public string Subject { get; set; }
        [StringLength(500)]
        public string Message { get; set; }
    }
}
