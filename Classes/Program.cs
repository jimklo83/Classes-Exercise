namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car corvette = new Car();
            corvette.Make = "Chevrolet";
            corvette.Model = "Corvette";
            corvette.Year = 1967;
            
            Console.WriteLine($"It's a {corvette.Year} {corvette.Make} {corvette.Model}.");
        }
    }
}
