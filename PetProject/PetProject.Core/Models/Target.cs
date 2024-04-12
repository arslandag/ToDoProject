namespace PetProject.Core.Models;

public class Target
{

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
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("Name cannot be null!");

        if (string.IsNullOrEmpty(description)) throw new ArgumentException("Description cannot be null!");

        return new Target(id, name, description);
    }
}
