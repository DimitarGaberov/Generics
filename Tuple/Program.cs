using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        //Task 11.

        //var inputTokens = Console.ReadLine().Split(' ');
        //var names = $"{inputTokens[0]} {inputTokens[1]}";
        //var address = inputTokens[2];
        //var namesAddress = new Tuple<string, string>(names, address);
        //Console.WriteLine(namesAddress);

        //inputTokens = Console.ReadLine().Split(' ');
        //var name = inputTokens[0];
        //var liters = int.Parse(inputTokens[1]);
        //var nameLiters = new Tuple<string, int>(name, liters);
        //Console.WriteLine(nameLiters);

        //inputTokens = Console.ReadLine().Split(' ');
        //var intParam = int.Parse(inputTokens[0]);
        //var doubleParam = double.Parse(inputTokens[1]);
        //var intDouble = new Tuple<int, double>(intParam, doubleParam);
        //Console.WriteLine(intDouble);

        //Task 12.

        var inputTokens = Console.ReadLine().Split(' ');
        var names = $"{inputTokens[0]} {inputTokens[1]}";
        var address = inputTokens[2];
        var town = inputTokens[3];
        var namesAddress = new Tuple<string, string, string>(names, address, town);
        Console.WriteLine(namesAddress);

        inputTokens = Console.ReadLine().Split(' ');
        var name = inputTokens[0];
        var liters = int.Parse(inputTokens[1]);
        bool drunkOrNot = IsDrunk(inputTokens[2]);
        var nameLitDrunk = new Tuple<string, int, bool>(name, liters, drunkOrNot);
        Console.WriteLine(nameLitDrunk);

        inputTokens = Console.ReadLine().Split(' ');
        var name1 = inputTokens[0];
        var accBallance = double.Parse(inputTokens[1]);
        var bankName = inputTokens[2];
        var nameAccBank = new Tuple<string, double, string>(name1, accBallance, bankName);
        Console.WriteLine(nameAccBank);
    }

    private static bool IsDrunk(string word)
    {
        if (word == "drunk")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
