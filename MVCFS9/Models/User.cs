using System.ComponentModel.DataAnnotations;

namespace MVCFS9.Models
{
    public class User
    {
        [Key] public Guid UserId { get; set; }
        public string? UserName { get; set; }

        public string? UserEmail { get; set; }

        public String? UserPhone { get; set; }

        [DataType(DataType.Password)]
        public string? UserPassword { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool IsActive { get; set; }

       
    }
}
