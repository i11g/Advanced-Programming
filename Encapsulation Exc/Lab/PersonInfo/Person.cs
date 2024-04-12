using System;

namespace PersonInfo;

public class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;
    //3 is a magic number 

    private const int NAME_MIN_LENGTH = 3;

    public string FirstName 
    { 
        get
        { return _firstName; }
         
        private set 
        { 
           if(value.Length< NAME_MIN_LENGTH)
            {
                throw new ArgumentException($"First name cannot contain fewer than {NAME_MIN_LENGTH}  symbiols!");
            } 
            _firstName = value; }
    }
    public string LastName
    {
        get { return _lastName; }
        private set { 
            if(value.Length<NAME_MIN_LENGTH)
            {
                throw new ArgumentException($"Last Name cannot contain fewer than {NAME_MIN_LENGTH} symbols");
            }
            _lastName = value; }
    }
    public int Age
    {
        get { return _age; }
        private set { 
            if(_age<=0)
            {
                throw new ArgumentException("Age cannot be zero or a negative integer");
            }
            _age = value; }

    }
    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} is {this.Age}years old";
    }

    public Person (string firstName, string lastName, int age)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;        
    }
}
