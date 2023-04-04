Person person = new Person();
person.Greetings();
person.DoWork();

Person person2 = new("Vasyliy", 40);
person2.Greetings();
person2.DoWork();

person.Name = " ";
Console.WriteLine("Person1 name is: " + person.Name);
person.Name = "Petro";
Console.WriteLine("Person1 name is: " + person.Name);
person.Age = 390;
Console.WriteLine(person.Age);

Console.WriteLine(person.Description);
person.Description = "This is Petro, former John Doe";
Console.WriteLine(person.Description);
class Person
{
    private string _name;
    private int _age;

    public string Name
    {
        get => _name;
        set { if (value.Trim() != string.Empty) _name = value; }
    }
    public int Age 
    {
        get => _age;
        set { if(value < 0 || value > 120) _age = value; }
    }
    public string Description { get; set; } = "Some description";
    public Person()
    {
        _name = "John Doe";
        _age = 18;
    }

    public Person(string name, int age)
    {
        _age = age;
        _name = name;
    }

    public void Greetings()
    {
        Console.WriteLine($"Hello! My name is {_name}. I'm {_age} years old");
    }

    public void DoWork()
    {
        Console.WriteLine($"{_name} doing some work");
    }
    
}