
abstract class StorePerson
{
    private static int ID = 100_000;
    public string Cell { get; }
    public string Name { get; }
    public string Id { get;  }

    public StorePerson(string name, string cell)
    {
        this.Name = name;
        this.Cell = cell;
        this.Id = ID.ToString();
        ID++;
    }
}