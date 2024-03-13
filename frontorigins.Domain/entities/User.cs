using Microsoft.AspNetCore.Identity;

namespace frontorigins.Domain.entities
{
    public class User : IdentityUser
    {

        private bool isApproved;

        private bool isLocketOut;

        private DateTime createdDate;

        private DateTime? lastModifiedDate;

        private DateTime? lastLockOutDate;

        private Employee employee;
        public string UserName { get => base.UserName; set => base.UserName = value; }
        public bool IsApproved { get => isApproved; set => isApproved = value; }
        public bool IsLocketOut { get => isLocketOut; set => isLocketOut = value; }
        public DateTime CreatedDate { get => createdDate; set => createdDate = value; }
        public DateTime? LastModifiedDate { get => lastModifiedDate; set => lastModifiedDate = value; }
        public DateTime? LastLockOutDate { get => lastLockOutDate; set => lastLockOutDate = value; }
        public virtual Employee Employee { get => employee; set => employee = value; }
    }
}
