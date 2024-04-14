namespace PetProject.API.Contracts
{
    public record TargetRequest(
        string Name,
        string Description,
        bool Status,
        string Priority
        );
}
