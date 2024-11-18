
namespace Delegate301;

public abstract class Car
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public virtual string GetCarDetails() { return $"{Id} - {Name}"; }
}

