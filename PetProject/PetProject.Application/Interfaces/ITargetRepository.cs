using PetProject.Core.Models;

namespace PetProject.Application.Interfaces
{
    public interface ITargetRepository
    {
        Task<Guid> Create(Target target);
        Task<Guid> Delete(Guid id);
        Task<List<Target>> Get();
        Task<Guid> Update(Guid id, string name, string description);
    }
}