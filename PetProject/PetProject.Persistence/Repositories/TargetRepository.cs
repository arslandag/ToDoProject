using Microsoft.EntityFrameworkCore;
using PetProject.Application.Interfaces;
using PetProject.Core.Models;

namespace PetProject.Persistence.Repositories;

public class TargetRepository : ITargetRepository
{
    private readonly ProjectDbContext _context;

    public TargetRepository(ProjectDbContext context)
    {
        _context = context;
    }

    public async Task<Guid> Create(Target target)
    {
        await _context.Targets.AddAsync(target);
        await _context.SaveChangesAsync();

        return target.Id;
    }

    public async Task<IReadOnlyList<Target>> Get(string status)
    {
        try
        {
            if (status == "all")
            {
                var targets = await _context.Targets
                    .AsNoTracking()
                    .ToListAsync();

                return targets;
            }
            else
            {
                var targets = await _context.Targets
                    .Where(t => t.Status == bool.Parse(status))
                    .AsNoTracking()
                    .ToListAsync();

                return targets;
            }
        } 
        catch 
        {
            throw new ArgumentException("Nothing found");
        }
    }

    public async Task<Guid> Update(Guid id, string name, string description, bool status, string priorty)
    {
        await _context.Targets
            .Where(t => t.Id == id)
            .ExecuteUpdateAsync(s => s
            .SetProperty(t => t.Name, name)
            .SetProperty(t => t.Description, description)
            .SetProperty(t => t.Status, status)
            .SetProperty(t => t.Priority, priorty));

        return id;
    }

    public async Task<Guid> Delete(Guid id)
    {
        await _context.Targets
            .Where(t => t.Id == id)
            .ExecuteDeleteAsync();

        return id;
    }
}
