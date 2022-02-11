using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VasutCommon.Model.UserHandling
{
    [Table("USERS")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public long Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        public User(string name, string userName, string email, string password, Role role)
        {
            Name = name;
            UserName = userName;
            Email = email;
            Password = password;
            Role = role;
        }
    }
}
