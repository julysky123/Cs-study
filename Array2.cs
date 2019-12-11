using System;

class Array2
{

    //다차원배열
    public static void Main() 
    {
        int[,] a = new int[2, 3];     //형식. 차원 늘릴때마다 콤마 더쓰기.

        int[,] b = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        int[,] c = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
        int[,] d = { { 1, 2, 3 }, { 4, 5, 6 } };
        for(int i=0;i<2;i++)
        {
            for(int j=0;j<3;j++) {
                Console.Write($"{a[i, j]}");
            }
            Console.WriteLine();
        }
        Console.WriteLine(a.GetLength(0)); //차원을 받는다. 첫번째 차원의 길이. 행 : 0
        Console.WriteLine(a.GetLength(1)); //차원을 받는다. 두번재 차원의 길이. 열 : 1

        foreach (var e in a)
            Console.Write(e + " "); //일렬로 출력할때는 이거 가능. 선형으로 되어있다.
        Console.WriteLine();


    }
}

