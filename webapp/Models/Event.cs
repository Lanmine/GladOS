using System.ComponentModel.DataAnnotations;

namespace webapp.Models;

public class Event
{
    public Event() {}
    
    public Guid Id { get; set; }

    public bool Archived { get; set; } = false;
    
    [Required]
    public string Name { get; set; } = string.Empty;

    [Required] 
    public string Description { get; set; } = string.Empty;


    [Required]
    public DateTime Start { get; set; }
    
    [Required]
    public DateTime End { get; set; }
    
    /*
    [Required]
    public DateTime DateCreated { get; set; }
    
    public DateTime? DateModified { get; set; }
    */
    
    [Required]
    public string HumanReadableUrl { get; set; } = string.Empty;
}