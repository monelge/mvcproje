using System;
namespace EntityLayer.Concrete
{
    public class Heading
    {
        public int HeadingID { get; set; }
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }

        public int CatagoryID { get; set; }
        public virtual Category Category { get; set; }

        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }

        public IComparable<Content> Contents { get; set; }


    }
}
