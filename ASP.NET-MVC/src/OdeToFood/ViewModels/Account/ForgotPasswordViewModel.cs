using System.ComponentModel.DataAnnotations;

namespace OdeToFood.ViewModels.Account
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
