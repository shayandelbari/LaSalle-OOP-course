class Program
{
    static void Main()
    {
        Console.WriteLine("Enter product details number 1:");
        Console.Write("Product ID: ");
        int productID = Convert.ToInt32(Console.ReadLine());
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Price: ");
        double price = Convert.ToDouble(Console.ReadLine());
        Console.Write("Quantity: ");
        int quantity = Convert.ToInt32(Console.ReadLine());
        Product product1 = new(productID, name, price, quantity);

        Console.WriteLine("\nEnter product details number 2:");
        Console.Write("Product ID: ");
        productID = Convert.ToInt32(Console.ReadLine());
        Console.Write("Name: ");
        name = Console.ReadLine();
        Console.Write("Price: ");
        price = Convert.ToDouble(Console.ReadLine());
        Console.Write("Quantity: ");
        quantity = Convert.ToInt32(Console.ReadLine());
        Product product2 = new(productID, name, price, quantity);

        Console.WriteLine("\nProduct details:");
        Console.WriteLine("Product 1:");
        product1.DisplayProductDetails();
        Console.WriteLine("\nProduct 2:");
        product2.DisplayProductDetails();

        Console.Write("Enter quantity change for product 1: ");
        int change = Convert.ToInt32(Console.ReadLine());
        product1.UpdateQuantity(change);
        Console.WriteLine("\nProduct 1 after quantity change:");
        product1.DisplayProductDetails();

        Console.WriteLine("Comparing Total Values: ");
        if (product1.CalculateTotalValue() > product2.CalculateTotalValue())
            Console.WriteLine($"Product 1 has a higher total value than product 2.");
        else
            Console.WriteLine($"Product 2 has a higher total value than product 1.");

        Console.WriteLine("Copying Object...");
        Product product3 = new(product1);
        Console.WriteLine("Copied Object:");
        product3.DisplayProductDetails();
    }
}
class Product
{
    private int productID;
    private string name;
    private double price;
    private int quantity;

    public int ProductID
    {
        get { return productID; }
        set { productID = value; }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public double Price
    {
        get { return price; }
        set { if (value < 0) price = 0; else price = value; }
    }
    public int Quantity
    {
        get { return quantity; }
        set { if (value <= 0) quantity = 0; else quantity = value; }
    }

    public Product()
    {
        productID = 0;
        name = "Unknown";
        price = 0.0;
        quantity = 0;
    }
    public Product(int productID, string name, double price, int quantity)
    {
        this.productID = productID;
        this.name = name;
        this.price = price;
        this.quantity = quantity;
    }
    public Product(Product product)
    {
        productID = product.productID;
        name = product.name;
        price = product.price;
        quantity = product.quantity;
    }

    public void DisplayProductDetails()
    {
        Console.WriteLine($"Product ID: {productID}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Price: {price}");
        Console.WriteLine($"Quantity: {quantity}");
    }
    public double CalculateTotalValue()
    {
        return price * quantity;
    }
    public void UpdateQuantity(int change)
    {
        quantity += change;
    }
}