using System.Text.Json;

var hector = new People()
{
    Name = "Hector",
    Age = 36,
};
string json = JsonSerializer.Serialize(hector);
Console.WriteLine(json);

string myJson = @"
{""Name"":""Juan""
,""Age"":36
}";

People? juan = JsonSerializer.Deserialize<People>(myJson);
Console.WriteLine(juan?.Name);
Console.WriteLine(juan?.Age);
public class People
{
    public string? Name { get; set; }
    public decimal Age { get; set; }
}