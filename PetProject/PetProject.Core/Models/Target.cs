namespace PetProject.Core.Models;

public class Target
{
    public const int  MAX_LENGTH_NAME = 50;
    public const int  MAX_LENGTH_DESCRIPTION = 50;
    private Target(Guid id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }
    public Guid Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string Description { get; private set; } = string.Empty;

    public static Target Create(Guid id, string name, string description)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name cannot be null!");

        if (string.IsNullOrWhiteSpace(description)) throw new ArgumentException("Description cannot be null!");

        return new Target(id, name, description);
    }
}
