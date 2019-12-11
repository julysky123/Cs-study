using System;

class Array3
{
    public static void Main()
    {

        //톱니형 배열 (jagged array)
        int[][] arr = new int[3][];
        arr[0] = new int[2];
        arr[1] = new int[3];
        arr[2] = new int[4];

        int[][] brr = new int[3][] { new int[2] { 1, 2 },
                                    new int[4] { 3, 4, 5, 6 },
                                    new int[5] {7,8,9,10,11 } };

        // 타입[][] 배열명 = new 타입[행][];

        //톱니형 배열의 순회
        for (int i = 0; i < brr.Length; i++)
        {
            for (int j = 0; j < brr[i].Length; j++)
                Console.Write(brr[i][j] + " ");
            Console.WriteLine(" ");
        }
        //arr[a][b] <- 재그드 어레이 arr[a,b] <- 다차원배열.
        //보기만해도 구분 가능하게 만듦
        //포인터배열이랑 같다고 생각. 
        // 재그드 어레이는 1차원 배열. 배열이 배열의 주소를 담고있다.

        
        int[][,] crr = new int[3][,] { new int[2, 2] { { 1, 2 }, { 3, 4 } }, new int[1, 4], new int[3, 3] };
        for (int i = 0; i < crr.Length; i++)
        {
            for (int j = 0; j < crr[i].GetLength(0); j++)
            {
                for (int k = 0; k < crr[i].GetLength(1); k++)
                {
                    crr[i][j, k] = (i + 1) * (j + 1) * (k + 1);
                }
            }
        }
        for (int i = 0; i < crr.Length; i++)
        {
            for (int j = 0; j < crr[i].GetLength(0); j++)
            {
                for (int k = 0; k < crr[i].GetLength(1); k++)
                {
                    Console.Write(crr[i][j, k] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}
