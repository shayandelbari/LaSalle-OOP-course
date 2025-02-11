class Animal
{
    private string name;
    private int age;
    public string Name
    {
        get { return name; }
        set { if (name != null && name != "") name = value; }
    }
    public int Age
    {
        get { return age; }
        set { if (age >= 0 && age <= 50) age = value; }
    }

    public Animal()
    {
        name = "No name";
        age = 0;
    }
    public Animal(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public Animal(Animal animal)
    {
        name = animal.name;
        age = animal.age;
    }

    public override string ToString()
    {
        return $"Name: {name}, Age: {age}";
    }
}

class Dog : Animal
{
    private string breed;
    public string Breed
    {
        get { return breed; }
        set { if (breed != null && breed != "") breed = value; }
    }
    public Dog() : base()
    {
        breed = "Unknown";
    }
    public Dog(string name, int age, string breed) : base(name, age)
    {
        this.breed = breed;
    }
    public Dog(Dog dog) : base(dog)
    {
        breed = dog.breed;
    }

    public string BarkSound()
    {
        if (this.Breed == "Husky") return "Awoo! 🐺";
        else if (this.Breed == "Poodle") return "Woof! 🐶";
        else return "Bark! 🐕";
    }
    public override string ToString()
    {
        return base.ToString() + $", Breed: {breed}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter dog's name: ");
        string name = Console.ReadLine() ?? "No name";

        int age;
        while (true)
        {
            Console.Write("Enter dog's age: ");
            if (int.TryParse(Console.ReadLine(), out age) && age >= 0 && age <= 50)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input for age. Please enter a valid number between 0 and 50.");
            }
        }

        Console.Write("Enter dog's breed: ");
        string breed = Console.ReadLine() ?? "Unknown";

        Dog dog = new(name, age, breed);
        Console.WriteLine("Dog details: " + dog.ToString());

        Dog copiedDog = new(dog);
        Console.WriteLine("Copied dog details: " + copiedDog.ToString());
    }
}
