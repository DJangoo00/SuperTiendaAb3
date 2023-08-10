namespace LinQTiendaAb3.clases;
public class Category
{
    int id { get; set; }
    string description { get; set; }

    public Category(int id, string description)
    {
        this.id = id;
        this.description = description;
    }
}