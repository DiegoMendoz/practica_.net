var show = Show;

Some(show,"Hola como estas");

string Show(string message)
{
    return message.ToUpper();
}

void Some(Func<string,string> fn, string message)
{
    Console.WriteLine("Hace algo al inicio");
    fn(message);
    Console.WriteLine("hace algo al final");
}