
using Exercise_2_U2;

namespace Exercise_2_U2
{
    class program
    {

        static void Main(string[] args)
        {
            formula_2 time = new formula_2();
            time.v_cyclist(900, 90, 10);

            Console.WriteLine("~The time a cyclist takes to reach the finish line~");
            Console.WriteLine("Distance(m)= " + time.Distance + "(m)");
            Console.WriteLine("velocity=" + time.Velocity + "(m/s)");
            Console.WriteLine("time(s)= " + time.Time + "(s)");
            Console.ReadLine();
        }
    }

}
