namespace Classes
{

    public class Program
    {
        static void Main(string[] args)
        {
            var CarOne = new Car();
            CarOne.Make = "Ford";
            CarOne.Model = "Bronco";
            CarOne.Year = 2019;
            Console.WriteLine($"This is {CarOne.Make},{CarOne.Model},it was made in the year {CarOne.Year}.");
        }
    }
}
    

