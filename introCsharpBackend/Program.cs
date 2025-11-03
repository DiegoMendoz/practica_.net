
var sale = new SaleWithtax(15,1.16m);
var message = sale.GetInfo();
Console.WriteLine(message);

class SaleWithtax : Sale
{
    public decimal Tax { get; set; }
    public SaleWithtax(decimal total, decimal tax) : base(total)
    {
        Tax = tax;
    }
    public override string GetInfo()
    {
        return "El total es " + Total + " Impuesto es: " + Tax;
    }
    

}
class Sale
{
    public decimal Total { get; set; }

    public Sale(decimal total)
    {
        Total = total;
       
    }
    public virtual string GetInfo()
    {
        return "El total es " + Total;
    }
}