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
        private string firstname;

        private string lastname;


        private string UserName;
        private bool IsApproved;

        private bool isLocketOut;

        private DateTime CreatedDate;

        private DateTime? LastModifiedDate;

        private DateTime? LastLockOutDate;

        private Employee employee;

        public User(string firstname, string lastname, string userName, bool isApproved, bool isLocketOut, DateTime createdDate, DateTime? lastModifiedDate, DateTime? lastLockOutDate, Employee employee)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            UserName = userName;
            IsApproved = isApproved;
            this.isLocketOut = isLocketOut;
            CreatedDate = createdDate;
            LastModifiedDate = lastModifiedDate;
            LastLockOutDate = lastLockOutDate;
            this.employee = employee;
        }

        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string UserName1 { get => UserName; set => UserName = value; }
        public bool IsApproved1 { get => IsApproved; set => IsApproved = value; }
        public bool IsLocketOut { get => isLocketOut; set => isLocketOut = value; }
        public DateTime CreatedDate1 { get => CreatedDate; set => CreatedDate = value; }
        public DateTime? LastModifiedDate1 { get => LastModifiedDate; set => LastModifiedDate = value; }
        public DateTime? LastLockOutDate1 { get => LastLockOutDate; set => LastLockOutDate = value; }
        public Employee Employee { get => employee; set => employee = value; }
    }
}
