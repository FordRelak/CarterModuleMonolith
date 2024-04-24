namespace CarterModuleMonolith.ModuleOne.Domain;
public class EntityOne
{
    public int Id { get; private set; }

    public string Name { get; private set; } = default!;

    private EntityOne(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public static EntityOne Create()
    {
        var id = Random.Shared.Next();
        return new(id, $"Name_{id}");
    }

    public static EntityOne Create(int id) => new(id, $"Name_{id}");
}
