using PetProject.Core.Models;

namespace PetProject.Application.Interfaces
{
    public interface ITargetsService
    {
        Task<Guid> CreateTargaet(Target target);
        Task<Guid> DeleteTarget(Guid id);
        Task<IReadOnlyList<Target>> GetAllTarget(string status);
        Task<Guid> UpdateTarget(Guid id, string name, string description, bool status, string priority);
    }
}