using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Avtopark.DataAccess.Entities
{
    [Table("users")]
    public class User : IdentityUser<int>, IBaseEntity
    {
        [Key]
        public int Id { get; set; }
        public Guid ExternalId { get; set; }
        public DateTime ModificationTime { get; set; }
        public DateTime CreationTime { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string SecretHash { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }

    public class UserRoleEntity : IdentityRole<int>
    {
    }
}
