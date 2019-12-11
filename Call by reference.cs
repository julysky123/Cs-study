using System;

class Method2
{
    static void InitInt(int n)
    {
        n = 0;
    }

    static void InitInt(ref int n)
    {
        n = 0;
    }

    static void InitArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            arr[i] = 0;
    }

    public static void Main()
    {
        int age = 10;
        InitInt(age);   // 값에 의한 호출
        int[] ages = { 1, 2, 3, 4, 5 };
        InitArray(ages); //참조에 의한 호출
        Console.WriteLine(age);             //안바뀜.
        foreach (var e in ages) Console.Write(e + " "); //바뀜.
        Console.WriteLine();

        InitInt(ref age);   //ref 를 사용해서 참조에 의한 호출을 하였다.
        Console.WriteLine(age);

        int c = 5;
        ref int d = ref c; // c의 별명으로 d를 짓는다. c랑 d 가 같은 메모리의 이름.
        d = 0;
        Console.WriteLine($"{c},{d}");


    }
}

