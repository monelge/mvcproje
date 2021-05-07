﻿using System;
namespace EntityLayer.Concrete
{
    public class Content
    {
        public int ContentId { get; set; }
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; }

        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; }

        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }


    }
}
