namespace SimulationGame;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        Simulator simulator = new Simulator();
        simulator.SimulateForever();
    }

}