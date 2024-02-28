namespace TCT.Models;
public class Booking
{
    public Booking()
    {
        this.Locations = new HashSet<Location>();
    }
    
    public int BookingId { get; set; }
    public decimal TotalPrice { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int TotalDays { get; set; }
    public int MainlandDays { get; set; }
    public int IslandDays { get; set; }
    public int MainlandAccommodation { get; set; }
    public int IslandAccommodation { get; set; }
    public Vehicle Vehicle { get; set; }
    public Driver Driver { get; set; }
    public Customer Customer { get; set; }
    public ClientCompany? ClientCompany { get; set; }
    
    public virtual ICollection<Location> Locations { get; set; }
}

// Determined how to account for many to many relationship for code first approach:
// Reference: https://www.entityframeworktutorial.net/code-first/configure-many-to-many-relationship-in-code-first.aspx