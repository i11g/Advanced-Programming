namespace Animals.Models;

public abstract class Animal
{
    private string name;
    private string favoredFood;

    public Animal (string name, string favoredFood)
    {
        this.name = name;
        this.favoredFood = favoredFood;
    }
    public virtual string ExplainSelf()
    {
        return $"I am {this.name} and my fovourite food is {this.favoredFood}";
    }
}
