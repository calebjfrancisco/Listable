
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("users")]
    public class User : EntityBase
    {
        [Column("email")]
        public string Email { get; set; }
        [Column("user_security_id")]
        public int UserSecurityId { get; set; } 
        public UserSecurity Security { get; set; }
        [Column("user_profile_id")]
        public int UserProfileId { get; set; }
        public UserProfile Profile { get; set; }
    }
}