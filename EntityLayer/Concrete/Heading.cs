using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        [Key]
        public int HeadingID { get; set; }
        [StringLength(200)]
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }

        public int CatagoryID { get; set; }
        public virtual Category Category { get; set; }

        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }

        //public IComparable<Content> Contents { get; set; }


    }
}
