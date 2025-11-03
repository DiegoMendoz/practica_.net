using System.Reflection.Metadata.Ecma335;

var numbers = new MyList<int>(5);
var names = new MyList<string>(5);
var beers = new MyList<Beer>(3);
numbers.add(1);
numbers.add(2);
numbers.add(3);
numbers.add(4);
numbers.add(5);

names.add("Hector");
names.add("Ana");
names.add("Luis");
names.add("Juan");
names.add("Roberto");
names.add("Karla");

beers.add(new Beer()
{
    Name = "Erdinger",
    Price = 5
});
beers.add(new Beer()
{
    Name = "Golden",
    Price = 7
});
beers.add(new Beer()
{
    Name = "Corona",
    Price = 4
});
beers.add(new Beer()
{
    Name = "Pilsener",
    Price = 9
});
Console.WriteLine(numbers.GetContent());
Console.WriteLine(names.GetContent());
Console.WriteLine(beers.GetContent());

public class MyList<T>
{
    private List<T> _list;
    private int _limit;

    public MyList(int limit)
    {
        _limit = limit;
        _list = new List<T>();
    }

    public void add(T element)
    {
        if (_list.Count < _limit)
        {
            _list.Add(element);
        }
    }

    public string GetContent()
    {
        return string.Join(".\n ", _list); // 
    }
}

public class Beer : Object
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public override string ToString()
    {
        return "Nombre: " + Name + " \nPrice: " + Price;
       
    }
}
