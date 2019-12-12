using System;

class Int
{
    public int val;
}



class Array4
{
    public static void Main()
    {
        int[] arr1 = new int[3];
        arr1[0] = 20;
        Console.WriteLine(arr1[0]);

        Int[] arr2 = new Int[3];    //Int 짜리 배열만 할당함.
        arr2[0] = new Int();    // 클래스도 할당 필요. 이게 필요.
        arr2[0].val = 20;
        Console.WriteLine(arr2[0].val);
    }

}
