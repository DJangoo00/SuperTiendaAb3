namespace LinQTiendaAb3.clases;
public class Product
{
    int codProduct { get; set; }
    string name { get; set; }
    int stock { get; set; }
    int stockMin { get; set; }
    int stockMax { get; set; }
    int soldPrice { get; set; }
    int buyPrice { get; set; }
    int idCategory { get; set; }

    public Product() { }
    public Product(int codProduct, string name, int stock, int stockMin, int stockMax, int soldPrice, int buyPrice, int idCategory)
    {
        this.codProduct = codProduct;
        this.name = name;
        this.stock = stock;
        this.stockMin = stockMin;
        this.stockMax = stockMax;
        this.soldPrice = soldPrice;
        this.buyPrice = buyPrice;
        this.idCategory = idCategory;
    }
    public void UpgradeStock()
    {
        Console.WriteLine("\tIngrese el nuevo stock:");
        stock = int.Parse(Console.ReadLine());
    }
    public int ShowAll()
    {
        int total = stock * soldPrice;
        Console.WriteLine("{0}|{1}|{2}|{3}|{4}", codProduct, name, stock, soldPrice, total);
        return total;
    }
    public AddProduct()
    {
        Console.WriteLine("\tIngrese el codigo de producto");
        int codProduct = int.Parse(Console.ReadLine());
        Console.WriteLine("\tIngrese el nombre de producto");
        string name = Console.ReadLine();
        Console.WriteLine("\tIngrese el stock de producto");
        int stock = int.Parse(Console.ReadLine());
        Console.WriteLine("\tIngrese el sotck minimo de producto");
        int stockMin = int.Parse(Console.ReadLine());
        Console.WriteLine("\tIngrese el sotck maximo de producto");
        int stockMax = int.Parse(Console.ReadLine());
        Console.WriteLine("\tIngrese el precio de venta de producto");
        int soldPrice = int.Parse(Console.ReadLine());
        Console.WriteLine("\tIngrese el precio de compra de producto");
        int buyPrice = int.Parse(Console.ReadLine());
        Console.WriteLine("\tIngrese el id de categoria");
        int idCategory = int.Parse(Console.ReadLine());
    }
}
