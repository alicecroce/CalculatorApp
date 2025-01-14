using CalculatorApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Inserisci il primo numero:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Inserisci il secondo numero:");
        int num2 = int.Parse(Console.ReadLine());

        int result = Calculator.Add(num1, num2);
        Console.WriteLine($"La somma è: {result}");
    }
}
