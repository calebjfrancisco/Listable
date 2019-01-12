
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("user_securities")]
    public class UserSecurity : EntityBase
    {
        [Column("salt")]
        public string Salt { get; set; }
        [Column("password_digest")]
        public string PasswordDigest { get; set; }
        [Column("email_confirmation_token")]
        public string EmailConfirmationToken { get; set; }
        [Column("email_confirmation_sent_at")]
        public DateTime EmailConfirmationSentAt { get; set; }
        [Column("email_confirmed_at")]
        public DateTime EmailConfirmedAt { get; set; }
        [Column("password_reset_token")]
        public string PasswordResetToken { get; set; }
        [Column("password_reset_sent_at")]
        public string PasswordResetSentAt { get; set; }
        [Column("password_reset_confirmed_at")]
        public DateTime PasswordConfirmedAt { get; set; }
    }
}