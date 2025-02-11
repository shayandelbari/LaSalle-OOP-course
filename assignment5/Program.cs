class Computer
{
    private string brand;
    private string model;
    private long sn;
    private double price;
    static int count = 0;

    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }
    public string Model
    {
        get { return model; }
        set { model = value; }
    }
    public long SN
    {
        get { return sn; }
        set { if (value > 0) sn = value; }
    }
    public double Price
    {
        get { return price; }
        set { if (value > 0) price = value; }
    }

    public Computer(string brand, string model, long SN, double price)
    {
        this.brand = brand;
        this.model = model;
        this.SN = SN;
        this.price = price;
        count++;
    }

    public override string ToString()
    {
        return $"Brand: {brand} \nModel: {model} \nSN: {SN} \nPrice: {price}";
    }

    public static int FindNumberOfCreatedComputers()
    {
        return count;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Computer Store!");
        Console.Write("Enter the number of computers you want to create: ");
        int maxNum = Convert.ToInt32(Console.ReadLine());
        Computer[] computers = new Computer[maxNum];

        const string PASSWORD = "password";
        string msg = @"What do you want to do?
1.	Enter new computers (password required)
2.	Change information of a computer (password required)
3.	Display all computers by a specific brand
4.	Display all computers under a certain a price.
5.	Quit
Please enter your choice > ";

        Console.WriteLine(msg);
        int choice = int.TryParse(Console.ReadLine(), out int result) ? result : 0;

        while (choice != 5)
        {
            if (choice == 1)
            {
                Console.Write("Enter the password: ");
                string password = Console.ReadLine();
                if (password == PASSWORD)
                {
                    Console.WriteLine("Enter the information of the computers:");
                    Console.Write("Enter the brand: ");
                    string brand = Console.ReadLine();
                    Console.Write("Enter the model: ");
                    string model = Console.ReadLine();
                    Console.Write("Enter the SN: ");
                    long SN = Convert.ToInt64(Console.ReadLine());
                    Console.Write("Enter the price: ");
                    double price = Convert.ToDouble(Console.ReadLine());
                    Computer computer = new(brand, model, SN, price);
                    computers[Computer.FindNumberOfCreatedComputers()] = computer;
                }
                else
                {
                    Console.WriteLine("Wrong password!");
                }
            }
            else if (choice == 2)
            {
                Console.Write("Enter the password: ");
                string password = Console.ReadLine();
                if (password == PASSWORD)
                {
                    Console.Write("Enter the number of the computer you want to change: ");
                    int computerNum = Convert.ToInt32(Console.ReadLine());

                    if (computerNum < 0 || computerNum >= computers.Length || computers[computerNum] == null)
                    {
                        Console.WriteLine("No computer found at this index. Do you want to enter another computer (yes/no)?");
                        string response = Console.ReadLine();
                        if (response.ToLower() == "yes")
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Returning to main menu.");
                            continue;
                        }
                    }

                    Console.WriteLine($"Computer #{computerNum}");
                    Console.WriteLine(computers[computerNum]);

                    Console.WriteLine(@"What information would you like to change?
1. brand
2. model
3. SN
4. price
5. Quit
Enter your choice > ");
                    int infoChoice = Convert.ToInt32(Console.ReadLine());

                    switch (infoChoice)
                    {
                        case 1:
                            Console.Write("Enter the new brand: ");
                            computers[computerNum].Brand = Console.ReadLine();
                            break;
                        case 2:
                            Console.Write("Enter the new model: ");
                            computers[computerNum].Model = Console.ReadLine();
                            break;
                        case 3:
                            Console.Write("Enter the new SN: ");
                            computers[computerNum].SN = Convert.ToInt64(Console.ReadLine());
                            break;
                        case 4:
                            Console.Write("Enter the new price: ");
                            computers[computerNum].Price = Convert.ToDouble(Console.ReadLine());
                            break;
                        case 5:
                            Console.WriteLine("Returning to main menu.");
                            break;
                        default:
                            Console.WriteLine("Invalid choice!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong password!");
                }
            }
            else if (choice == 3)
            {
                Console.Write("Enter the brand: ");
                string brand = Console.ReadLine();
                foreach (Computer computer in computers)
                {
                    if (computer.Brand == brand)
                    {
                        Console.WriteLine(computer);
                    }
                }
            }
            else if (choice == 4)
            {
                Console.Write("Enter the price: ");
                double price = Convert.ToDouble(Console.ReadLine());
                foreach (Computer computer in computers)
                {
                    if (computer.Price < price)
                    {
                        Console.WriteLine(computer);
                    }
                }
            }
            else
            {
                Console.WriteLine("Wrong choice!");
            }
        }
    }
}