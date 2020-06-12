using System;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
            do {
                // Reading user input x from console
                Console.Write("x = ");
                string str = Console.ReadLine();
                if (str == "exit")
                    break;

                int x = Convert.ToInt32(str);

                // Reading user input y from console
                Console.Write("y = ");
                int y = Convert.ToInt32(Console.ReadLine());

                int sum = x + y;
                // Displaying the sum of x and y on the console
                Console.WriteLine("Result: {0}", sum);
            }
            while(true);
        }
    }
}
