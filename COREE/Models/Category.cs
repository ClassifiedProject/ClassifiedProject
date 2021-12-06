using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace COREE.Models
{
    [Table("Categories")]
    class Category
    {
        [Key]
        public long CategorID { get; set; }

        public string CategoryName { get; set; }
    }
}
