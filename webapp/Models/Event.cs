using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace webapp.Models;

public class Event
{
    public Event() {}
    
    public Guid Id { get; set; }

    [DisplayName("Status")]
    public bool Archived { get; set; } = false;
    
    [Required]
    [DisplayName("Navn")]
    public string Name { get; set; } = string.Empty;

    [Required] 
    [DisplayName("Beskrivelse")]
    public string Description { get; set; } = string.Empty;


    [Required]
    [DisplayName("Start")]
    public DateTime Start { get; set; }
    
    [Required]
    [DisplayName("Slutt")]
    public DateTime End { get; set; }
    
    /*
    [Required]
    public DateTime DateCreated { get; set; }
    
    public DateTime? DateModified { get; set; }
    */
    
    [Required]
    public string HumanReadableUrl { get; set; } = string.Empty;
}