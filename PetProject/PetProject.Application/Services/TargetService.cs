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

    public async Task<IReadOnlyList<Target>> GetAllTarget(string status)
    {
        return await _targetRepository.Get(status);
    }

    public async Task<Guid> UpdateTarget(
        Guid id,
        string name,
        string description,
        bool status,
        string priority
        )
    {
        return await _targetRepository.Update(id, name, description, status, priority);
    }

    public async Task<Guid> DeleteTarget(Guid id)
    {
        return await _targetRepository.Delete(id);
    }
}
