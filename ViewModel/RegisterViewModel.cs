using System.ComponentModel.DataAnnotations;

namespace MenagmentSystem.ViewModel
{
    public class RegisterViewModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        

    }
}
