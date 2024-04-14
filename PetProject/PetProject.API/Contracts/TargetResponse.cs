namespace PetProject.API.Contracts
{
    public record TargetResponse(
        Guid Id,
        string Name,
        string Description,
        bool Status,
        string Priority
        );
}
