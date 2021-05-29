using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vaperoom.Storage.Entity
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        public string Nickname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public byte[] Image { get; set; }
        [Range(0, 1)]
        public Role Role { get; set; }
        public long Phone_number { get; set; }
        public DateTime DateOfBirthday { get; set; }


    }

    public enum Role
    {
        Admin = 1,
        User = 0
    }
}
