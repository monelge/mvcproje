using System;
using System.Collections;
using System.Collections.Generic;

namespace EntityLayer.Concrete
{
    public class Category
    {
        public int CatagoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public string CategoryStatus { get; set; }

        public ICollection<Heading> Headings { get; set; }
    }
}
