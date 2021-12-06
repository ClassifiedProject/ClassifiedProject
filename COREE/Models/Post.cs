using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace COREE.Models
{
    [Table("Posts")]
    class Post
    { 
        [Key]
        public long PostID { get; set; }
        public long CategoryID { get; set; }
        public long UserID { get; set; }
        public bool Balcony { get; set; }
        public int Floor { get; set; }
        public int RoomCount { get; set; }
        public int BuildingAge { get; set; }
        public bool InSite { get; set; }
        public bool HasFurniture { get; set; }
        public int BathroomCount { get; set; }
        public int SquareMeters { get; set; }
        public DateTime PostDate { get; set; }
        public bool Vacancy { get; set; }
        public string Heating { get; set; }

        public virtual User Users { get; set; }
        public virtual Category Categories { get; set; }
    }
}