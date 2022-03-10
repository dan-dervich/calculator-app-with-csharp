using System;
using System.Linq;

public class Calculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("tipos de operaciones que se aceptan: *, /, %, + y -");
        Console.WriteLine("porfavor ingrese su  operacion matematica.");
        string operation = Console.ReadLine();
        for (int i = 0; i < operation.Count(); i++)
        {
            string createFirstNum = "";
            string createSecondNum = "";
            for (int z = i + 1; z < operation.Count(); z++)
            {
                createFirstNum = createFirstNum + operation[z - i - 1];
                createSecondNum = createSecondNum + operation[z];
            }
            if (operation[i] == '*')
            {
                Console.WriteLine(Convert.ToInt32(createFirstNum) * Convert.ToInt32(createSecondNum));
            }
            else if (operation[i] == '/')
            {
                Console.WriteLine(Convert.ToInt32(createFirstNum) / Convert.ToInt32(createSecondNum));
            }
            else if (operation[i] == '%')
            {
                Console.WriteLine(Convert.ToInt32(createFirstNum) % Convert.ToInt32(createSecondNum));
            }
            else if (operation[i] == '+')
            {
                Console.WriteLine(Convert.ToInt32(createFirstNum) + Convert.ToInt32(createSecondNum));
            }
            else if (operation[i] == '-')
            {
                Console.WriteLine(Convert.ToInt32(createFirstNum) - Convert.ToInt32(createSecondNum));
            }
        }
    }
}