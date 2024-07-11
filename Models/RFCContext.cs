using Microsoft.EntityFrameworkCore;

namespace CoreAPI_Tracking.Models;

public class RFCContext : DbContext
{
    public RFCContext (DbContextOptions<RFCContext> options)
    : base(options)
    {

    }

    public DbSet<RFCRequest> RFCRequest { get; set; } = null!;
}
