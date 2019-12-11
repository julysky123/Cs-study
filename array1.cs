using System;

class Array
{
    public static void Main() {


        int k = 7;
        int[] b = new int[k];   //변수도 가능.
        int[] c = new int[3] { 1, 2, 3 };   //변수 초기화 방법. java style.
        int[] d = new int[] { 1, 2, 3 };    //초기화 하면 요소 개수 생략가능. java style.
        int[] e = { 1, 2, 3 };              //초기화 하면 c style도 가능.
        // 주의점. 
        int[] f;
        f = new int[] { 1, 2, 3 };  //이건 허용
                                    //int[] g;
                                    //g = { 1,2,3 };      //오류

        int[] a = new int[3];
        for (int i = 0; i < a.Length; i++) a[i] = i;
        //배열의 길이는 array.Length;
        int total = a[0] + a[1] + a[2];
        Console.WriteLine($"평균:{total / 3.0}");

        foreach (int i in a)    //각각의 g의 원소 들마다.
            Console.Write(i + " ");

        foreach (var i in a)    //원소의 타입을 몰라도 쓸수있다. C#3.0부터
            Console.Write(i + " ");

        //foreach 내부에서 원소 수정 불가!
        //foreach (int i in a)
        //    i = 3;
        int[] arr = {1, 2, 3, 4, 5 };
        Console.WriteLine(arr[3]);
        Console.WriteLine(arr.GetValue(3)); //위와 같은기능.

        Console.WriteLine(arr.GetLowerBound(0));    //0 가장 낮은 인덱스 (지금까지는 당연히 0)
        Console.WriteLine(arr.GetUpperBound(0));    //4 가장 높은 인덱스
        // 0을 인자로 넣는 이유.. -> 다차원배열에서 설명.

        int[] arr1 = { 10 };    // arr1이 배열을 가리킨다.
        int[] arr2 = arr1;      // arr2가 arr1이 가리키는 배열을 가리킨다.
        arr2[0] = 0;            //따라서 arr1[0] = 0 이된다.
        Console.WriteLine(arr1[0]); // 얘도 바뀜.
        //따라서 완벽한 배열의 사본이 아니다. ->얕은 복사.

        //배열의 사본 만들기. clone 메쏘드 -> 깊은 복사.
        int[] arr3 = { 10 };
        int[] arr4 = (int[])arr3.Clone();
        arr4[0] = 0;
        Console.WriteLine($"{arr3[0]}, {arr4[0]}");

    }
}
