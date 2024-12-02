using System;
//Модуль 07
//Завдання 1 
/*interface ICalc
{
    int Less(int valueToCompare);
    int Greater(int valueToCompare);
}

class Array : ICalc
{
    private int[] elements;

    public Array(int[] values)
    {
        elements = values;
    }

    public int Less(int valueToCompare)
    {
        int count = 0;
        foreach (int element in elements)
        {
            if (element < valueToCompare)
                count++;
        }
        return count;
    }

    public int Greater(int valueToCompare)
    {
        int count = 0;
        foreach (int element in elements)
        {
            if (element > valueToCompare)
                count++;
        }
        return count;
    }
}

class Program
{
    static void Main()
    {
        int[] values = { 1, 3, 5, 7, 9 };
        Array array = new Array(values);

        Console.WriteLine($"The number of less than 5: {array.Less(5)}");
        Console.WriteLine($"The number of more than 5: {array.Greater(5)}");
    }
}
*/



/*interface IOutput2
{
    void ShowEven();
    void ShowOdd();
}

class Array : IOutput2
{
    private int[] elements;

    public Array(int[] values)
    {
        elements = values;
    }

    public void ShowEven()
    {
        Console.WriteLine("Even values:");
        foreach (int element in elements)
        {
            if (element % 2 == 0)
                Console.Write($"{element} ");
        }
        Console.WriteLine();
    }

    public void ShowOdd()
    {
        Console.WriteLine("Odd values:");
        foreach (int element in elements)
        {
            if (element % 2 != 0)
                Console.Write($"{element} ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Array array = new Array(values);

        array.ShowEven();
        array.ShowOdd();
    }
}
*/


