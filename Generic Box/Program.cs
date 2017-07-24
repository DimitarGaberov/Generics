using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        // Task 2.

        //int numberOfLines = int.Parse(Console.ReadLine());

        //for (int i = 0; i < numberOfLines; i++)
        //{
        //    Box<string> boxStr = new Box<string>(Console.ReadLine());
        //    Console.WriteLine(boxStr);
        //}

        // Task 3

        //int numberOfLines = int.Parse(Console.ReadLine());

        //for (int i = 0; i < numberOfLines; i++)
        //{
        //    Box<int> boxInt = new Box<int>(int.Parse(Console.ReadLine()));
        //    Console.WriteLine(boxInt);
        //}

        // Task 4

        //int numberOfLines = int.Parse(Console.ReadLine());
        //List<Box<string>> boxCollection = new List<Box<string>>();

        //for (int i = 0; i < numberOfLines; i++)
        //{
        //    Box<string> boxStr = new Box<string>(Console.ReadLine());
        //    boxCollection.Add(boxStr);
        //}

        //var indexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        //SwapElements(boxCollection, indexes[0], indexes[1]);

        //foreach (var box in boxCollection)
        //{
        //    Console.WriteLine(box);
        //}

        // Task 5

        //int numberOfLines = int.Parse(Console.ReadLine());
        //List<Box<int>> boxCollection = new List<Box<int>>();

        //for (int i = 0; i < numberOfLines; i++)
        //{
        //    Box<int> boxInt = new Box<int>(int.Parse(Console.ReadLine()));
        //    boxCollection.Add(boxInt);
        //}

        //var indexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        //SwapElements(boxCollection, indexes[0], indexes[1]);

        //foreach (var box in boxCollection)
        //{
        //    Console.WriteLine(box);
        //}

        // Task 6

        //var numberOfLines = int.Parse(Console.ReadLine());
        //List<Box<string>> listOfBoxes = new List<Box<string>>();
        //for (int i = 0; i < numberOfLines; i++)
        //{
        //    Box<string> boxStr = new Box<string>(Console.ReadLine());
        //    listOfBoxes.Add(boxStr);
        //}

        //var element = Console.ReadLine();
        //var result = GetGreaterElementsCount(listOfBoxes, element);

        //Console.WriteLine(result);

        // Task 7

        var numberOfLines = int.Parse(Console.ReadLine());
        List<Box<double>> listOfBoxes = new List<Box<double>>();
        for (int i = 0; i < numberOfLines; i++)
        {
            Box<double> boxDouble = new Box<double>(double.Parse(Console.ReadLine()));
            listOfBoxes.Add(boxDouble);
        }

        var element = double.Parse(Console.ReadLine());
        var result = GetGreaterElementsCount(listOfBoxes, element);

        Console.WriteLine(result);
    }

    // Tasks 6, 7.

    public static int GetGreaterElementsCount<T>(List<Box<T>> listOfBoxes, T element)
            where T : IComparable<T>
    {
        return listOfBoxes.Count(b => b.Value.CompareTo(element) > 0);
    }

    // Tasks 4, 5.

    //private static void SwapElements<T>(List<T> boxCollection, int index1, int index2)
    //{
    //    T tempBox = boxCollection[index1];
    //    boxCollection[index1] = boxCollection[index2];
    //    boxCollection[index2] = tempBox;
    //}
}
