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
        private Employee employee;

        private bool isApproved = false;

        private bool isLocketOut = false;

        private DateTime createdDate = DateTime.Now;

        private DateTime? lastModifiedDate;

        private DateTime? lastLockOutDate;

        public bool IsApproved { get => isApproved; set => isApproved = value; }
        public bool IsLocketOut { get => isLocketOut; set => isLocketOut = value; }
        public DateTime CreatedDate { get => createdDate; set => createdDate = value; }
        public DateTime? LastModifiedDate { get => lastModifiedDate; set => lastModifiedDate = value; }
        public DateTime? LastLockOutDate { get => lastLockOutDate; set => lastLockOutDate = value; }
        public Employee Employee { get => employee; set => employee = value; }
    }
}
