using PetProject.Core.Models;

namespace PetProject.Application.Interfaces
{
    public interface ITargetsService
    {
        Task<Guid> CreateTargaet(Target target);
        Task<Guid> DeleteTarget(Guid id);
        Task<List<Target>> GetAllTarget();
        Task<Guid> UpdateTarget(Guid id, string name, string description);
    }
}