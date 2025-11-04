var names = new List<string>()
{
    "Hector","Francisco","Ana","Hugo","Pedro"
};
var namesResult = from n in names
                  where n.Length>3 && n.Length<5
                  orderby n descending
                  select n;

foreach (var name in namesResult)
{
    Console.WriteLine(name);
}