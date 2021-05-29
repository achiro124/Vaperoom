using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Vaperoom.Storage.Entity;

namespace NewKinoHub.Storage.Entity
{
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReviewId { get; set; }
        public string DateOfReview { get; set; }

        [DataType(DataType.MultilineText)]        
        public string Description { get; set; }
        public string Nickname { get; set; }
        public byte[] ImgUser { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int UsersId { get; set; }
        public User User { get; set; } 

    }
}
