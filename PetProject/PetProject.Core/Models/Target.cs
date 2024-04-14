namespace PetProject.Core.Models;

public class Target
{
    public const int  MAX_LENGTH_NAME = 50;
    public const int  MAX_LENGTH_DESCRIPTION = 50;
    private Target(Guid id, string name, string description, bool status, string priority)
    {
        Id = id;
        Name = name;
        Description = description;
        Status = status;
        Priority = priority;
    }
    public Guid Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string Description { get; private set; } = string.Empty;
    public bool Status { get ; private set; }
    public string Priority { get; private set; }

    public static Target Create(Guid id, string name, string description, bool status, string priority)
    {
        if (string.IsNullOrWhiteSpace(name) && name.Length > MAX_LENGTH_NAME)
        {
            throw new ArgumentException("Name cannot be null or length mast be less 50 sumbols!");
        }

        if (string.IsNullOrWhiteSpace(description) && description.Length > MAX_LENGTH_DESCRIPTION)
        {
            throw new ArgumentException("Description cannot be null or length mast be less 50 sumbols!");
        }

        if (string.IsNullOrWhiteSpace(priority))
        {
            throw new ArgumentException("Priority cannot be null");
        }

        return new Target(id, name, description, status, priority);
    }
}
