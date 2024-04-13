namespace ExerciseOopHierarchy;

public abstract class MenuItem
{
    private string _name;
    private string _description;
    private decimal _price; 

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    public decimal Price
    {
        get { return (decimal)_price; }
        set { _price = value; }
    }

    public MenuItem(string name,string description,decimal price)
    {
        Name= name;
        Description= description;
        Price= price;
    }

    public override string ToString()
    {
        return $"{this.Name} - {this.Description} - {this.Price}.";
    }

}
