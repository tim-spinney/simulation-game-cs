namespace SimulationGame;


class Program
{
    static void Main(string[] args)
    {
        Simulator simulator = new Simulator(4, 10, new NameGenerator(new Random()), new Random());
        simulator.AdvanceTime(100);
    }

}