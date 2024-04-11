using System.ComponentModel;
using System.Runtime.CompilerServices;

//Person person = new Person("Iv", 9);

 Worker worker = new Worker("Test", 2, "ABC");

/*worker.SayName()*/;

Console.WriteLine(worker.ToString());

public class Person
{  //fileds can be inherited
    protected string name;
    protected int age;

    // constructors can not be inherited
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // properties can be inherited
    public string Name 
    {
        get { return this.name; } 
        set 
        { 
            if(string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name is not valid"); 
            }
            name = value; 
        } 
    }
    public int Age 
    {
        get { return this.age; } 
        set 
        { 
            if(value<0)
            {
                throw new ArgumentException("Age cannot be negative");
            }           
            age = value; 
        
        } 
    }
    //mehotds can be inherited
    //public void SayName()
    //{
    //    Console.WriteLine(this.Name);
    //}

    public override string ToString()
    {
        return $"Name:{this.Name}|Age:{this.Age}";
    }
}
public class Worker : Person
{
    private string _workPlace;

    public Worker (string name, int age, string workplace): base (name,age) 
    {
        this.Workplace = workplace;
    }
    public string Workplace
    {
        get { return this._workPlace; }
        set 
        {   if(string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Workplace is not valid");
            }
            
            this._workPlace = value;
        }
    }
    public override string ToString()
    { 
        
        return $"{base.ToString()}|Workplace:{this.Workplace}";
    }
}

public class Student:Person 
{    
    public Student(string name, int age,string university): base(name,age)
    {
        University = university;
    }
    public string University { get; set; }

}  