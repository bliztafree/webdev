using System.ComponentModel.DataAnnotations;

namespace Microsoft.bliztafree.Services.Identity.API.Models.AccountViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
