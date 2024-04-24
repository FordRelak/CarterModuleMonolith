namespace CarterModuleMonolith.ModuleTwo.Domain;
public class EntityTwo
{
    public int Id { get; private set; }

    public string Name { get; private set; } = default!;

    private EntityTwo(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public static EntityTwo Create()
    {
        var id = Random.Shared.Next();
        return new(id, $"Name_{id}");
    }

    public static EntityTwo Create(int id) => new(id, $"Name_{id}");
}
