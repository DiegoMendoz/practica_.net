
var sale = new Sale();
var beer = new Beer();

Some(sale);
Some(beer);

void Some(Isave save)
{
    save.save();
}
interface ISale
{
    decimal Total { get; set; }
}
interface Isave
{
    public void save();
}
public class Sale : ISale, Isave
{
    public decimal Total { get; set; }
    public void save()
    {
        Console.WriteLine("Se guardo en DB");
    }
}

public class Beer : Isave
{
    public void save()
    {
        Console.WriteLine("Se guardo en Servicio");
    }
}
