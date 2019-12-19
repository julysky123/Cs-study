using System;

class ii
{
    public int val = 0;
    public static ii operator ++(ii i)
    {
        ii j = new ii();
        j.val = i.val + 1;
        return j;
    }
}


class Program
{
    static void Main(string[] args)
    {
        ii i = new ii();
        ii j = ++i;
        Console.WriteLine($"{i.val}, {j.val}");

    }
}
