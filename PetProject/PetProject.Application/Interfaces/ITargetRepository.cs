using PetProject.Core.Models;

namespace PetProject.Application.Interfaces
{
    public interface ITargetRepository
    {
        Task<Guid> Create(Target target);
        Task<Guid> Delete(Guid id);
        Task<IReadOnlyList<Target>> Get();
        Task<Guid> Update(Guid id, string name, string description);
    }
}