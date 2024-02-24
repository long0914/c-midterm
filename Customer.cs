


class Customer : StorePerson
{
    public double Credit { get; }

    public Customer(string name, string cell, double credit = 500) : base(name, cell)
    {
        this.Credit = credit;
    }

    public override string ToString()
    {
        return $"{this.Id} {this.Name} {this.Cell} - Credit: {this.Credit}";
    }
}