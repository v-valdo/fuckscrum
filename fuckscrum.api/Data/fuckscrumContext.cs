using fuckscrum.api.Models;
using Microsoft.EntityFrameworkCore;

namespace fuckscrum.api.Data;
public class fuckscrumContext : DbContext
{
    public DbSet<FeatureModel> Features => Set<FeatureModel>();
    public DbSet<MemberModel> Members => Set<MemberModel>();
    public DbSet<ProjectModel> Projects => Set<ProjectModel>();
    public DbSet<TechnologyModel> TechStack => Set<TechnologyModel>();

    public fuckscrumContext(DbContextOptions options) : base(options)
    {

    }
}