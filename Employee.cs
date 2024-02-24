class Employee: StorePerson{

    public double Salary {get;}

    public Employee(string name, string cell, double salary =2500) : base(name, cell)
    {
        this.Salary = salary;

    }

    public override string ToString()
    {
        return $"{this.Id} {this.Name} {this.Cell} - Salary: {this.Salary}";
    }

}