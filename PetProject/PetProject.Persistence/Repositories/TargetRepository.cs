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

    public async Task<List<Target>> Get()
    {
        var target = await _context.Targets
            .AsNoTracking()
            .ToListAsync();

        return target;
    }

    public async Task<Guid> Update(Guid id, string name, string description)
    {
        await _context.Targets
            .Where(t => t.Id == id)
            .ExecuteUpdateAsync(s => s
            .SetProperty(t => t.Name, name)
            .SetProperty(t => t.Description, description));

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
