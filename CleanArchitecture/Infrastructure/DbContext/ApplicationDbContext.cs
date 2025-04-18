using System.Net.Mime;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Infrastructure.DbContext;

public class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {   
    }
    
    //DbSet<Domain.Property> Properties { get; set; }
    DbSet<Domain.Property> Properties => Set<Domain.Property>();
    DbSet<Domain.Image> Images { get; set; }
}