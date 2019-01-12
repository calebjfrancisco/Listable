
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("user_profiles")]
    public class UserProfile
    {
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("username")]
        public string Username { get; set; }
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }
    }
}