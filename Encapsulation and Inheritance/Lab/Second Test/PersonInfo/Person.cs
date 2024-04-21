using System;
using System.ComponentModel.Design;

namespace PersonInfo;

public class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;
    
    public string FirstName
    {
        get 
        { 
            return _firstName;
        }
        private set
        { 
            if (value.Length < 3)
            {
                throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
            }
            else
            {
                _firstName = value;
            }
            this._firstName = value;
        }
    }
    public string LastName
    {
        get
        {
            return _lastName;
        }
        private set 
        {  
            if(value.Length<3)
            {
                throw new ArgumentException("Last name cannot contain fewer than 3 symbols!0" );
            }
            this._lastName = value;
        }
    }
    public int Age
    {
        get
        {
            return _age;
        }
        private set
        {   
            if (value<3)
            {
                throw new ArgumentException("Age cannot be zero or a negative integer!");
            }
            this._age = value;
        }
    }
    public Person (string firstName,string lastName, int age)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age= age;
    }

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} is {this.Age} years old.";
    }
}
