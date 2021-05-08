using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CatagoryID { get; set; }
        [StringLength(100)]
        public string CategoryName { get; set; }
        [StringLength(500)]
        public string CategoryDescription { get; set; }
        [StringLength(500)]
        public string CategoryStatus { get; set; }

        public ICollection<Heading> Headings { get; set; }
    }
}
