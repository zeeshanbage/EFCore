using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class User{

        [Key]
        public int UserId { get; set;}
        public string? Email { get; set; }
        public string? Firstname { get; set; }
        public string? Password { get; set; }

        public string? Lastname { get; set; }
        [MaxLength(10)]
        public string? Phone { get; set; }
        public DateTime? RegistrationDate { get; set; }
}    