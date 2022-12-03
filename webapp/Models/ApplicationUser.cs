using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace webapp.Models;

public class ApplicationUser : IdentityUser<Guid>
{
    [Required]
    public string FirstName { get; set; }
    
    [Required]
    public string LastName { get; set; }
    
    [StringLength(64, MinimumLength = 4)]
    public string? Nickname;
    
    [Required]
    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }
    
    //public DateTime DateCreated { get; } = DateTime.Now;
    //public DateTime DateModified { get; set; }

    //public ExtraInfo ExtraInfo;

    //public File ProfilePicture;
    //public ExtraInfo m_ExtraInfo;
}