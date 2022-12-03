using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace webapp.Models;

public class ApplicationUser : IdentityUser<Guid>
{
    [Required]
    [Display(Name = "Fornavn")]
    [StringLength(64, MinimumLength = 2, ErrorMessage = "Fornavn må være mellom 2 og 64 bokstaver")]
    public string FirstName { get; set; } = String.Empty;
    
    [Required]
    [Display(Name = "Etternavn")]
    [StringLength(64, MinimumLength = 2, ErrorMessage = "Etternavn må være mellom 2 og 64 bokstaver")]
    public string LastName { get; set; } = String.Empty;
    
    [Display(Name = "Nickname")]
    [StringLength(64, MinimumLength = 4, ErrorMessage = "Nickname må være mellom 4 og 64 bokstaver")]
    public string? Nickname;
    
    [Required]
    [Display(Name = "Fødselsdato")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }
    
    // Address info
    [Required]
    [Display(Name = "Adresse")]
    [StringLength(64, MinimumLength = 4, ErrorMessage = "Addressen må være mellom 4 og 64 bokstaver")]
    public string Address { get; set; } = String.Empty;
    
    [Required]
    [Display(Name = "Postkode")]
    [StringLength(4, MinimumLength = 4, ErrorMessage = "Postkoden må være 4 tall")]
    [RegularExpression("^[0-9]*$", ErrorMessage = "Postkoden må bestå av tall")]
    public string PostalCode { get; set; } = String.Empty;
    
    [Required]
    [Display(Name = "Poststed")]
    [StringLength(64, MinimumLength = 4, ErrorMessage = "Poststed må være mellom 4 og 64 bokstaver")]
    public string City { get; set; } = String.Empty;

    //public DateTime DateCreated { get; } = DateTime.Now;
    //public DateTime DateModified { get; set; }

    //public ExtraInfo ExtraInfo;

    //public File ProfilePicture;
    //public ExtraInfo ExtraInfo;
}