using PetProject.Core.Models;
using PetProject.Application.Interfaces;

namespace PetProject.Application.Services;

public class TargetsService : ITargetsService
{
    private readonly ITargetRepository _targetRepository;

    public TargetsService(ITargetRepository targetRepository)
    {
        _targetRepository = targetRepository;
    }

    public async Task<Guid> CreateTargaet(Target target)
    {
        return await _targetRepository.Create(target);
    }

    public async Task<IReadOnlyList<Target>> GetAllTarget()
    {
        return await _targetRepository.Get();
    }

    public async Task<Guid> UpdateTarget(
        Guid id,
        string name,
        string description
        )
    {
        return await _targetRepository.Update(id, name, description);
    }

    public async Task<Guid> DeleteTarget(Guid id)
    {
        return await _targetRepository.Delete(id);
    }
}
