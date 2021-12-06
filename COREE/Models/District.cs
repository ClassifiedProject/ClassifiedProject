using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace COREE.Models
{
    [Table("Districties")]
    class District
    {
        [Key]
        public long DistrictID { get; set; }
        public string Title { get; set; }
        public long CityID { get; set; }

        public virtual City city { get; set; }
    }
}
