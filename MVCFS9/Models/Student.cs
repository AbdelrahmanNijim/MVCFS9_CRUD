using System.ComponentModel.DataAnnotations;

namespace MVCFS9.Models
{
    public class Student
    {
        public int Id { get; set; }

        [DataType("varchar")]
        [MaxLength(55)]
        public required string Name { get; set; }
        [DataType("varchar")]
        [MaxLength(255)]
        [EmailAddress]
        public required string Email { get; set; }
        [DataType(DataType.Password)]
        [MaxLength(255)]
        public String password { get; set; } = null!;

        public string Phone { get; set; } = null!;

      



    }
}
