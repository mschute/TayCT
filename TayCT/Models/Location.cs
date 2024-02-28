namespace TCT.Models;

public class Location
{
    public Location()
    {
        this.Bookings = new HashSet<Booking>();
    }
    public int LocationId { get; set; }
    public string LocationName { get; set; }
    public string LocationAddress { get; set; }
    public string MainlandIsland { get; set; }
    
    public virtual ICollection<Booking> Bookings { get; set; }
}

// Determined how to account for many to many relationship for code first approach:
// Reference: https://www.entityframeworktutorial.net/code-first/configure-many-to-many-relationship-in-code-first.aspx