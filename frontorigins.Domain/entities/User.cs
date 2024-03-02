using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Domain.entities
{
    public class User : IdentityUser
    {
        private string firstname { get; set; }

        private string lastname { get; set; }


        public string UserName { get; set; }
        public bool IsApproved { get; set; }

        public bool isLocketOut { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime? LastModifiedDate { get; set; }

        public DateTime? LastLockOutDate { get; set; }

        public User() { }
    }
}
