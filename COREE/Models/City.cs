using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace COREE.Models
{
    [Table("Cities")]
    class City
    {
        [Key]
        public long CityID { get; set; }
        public string CityName { get; set; }
    }
}
