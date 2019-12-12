using System;

class Program
{
    static void Swap(ref int a, ref int b)
    {
        int t = a;
        a = b;
        b = t;
    }
    //static bool Div(int x, int y, ref int ret)
    //{
    //    if (y==0)
    //    {
    //        return true;
    //    }
    //    ret = x / y;
    //    return false;
    //}   //오류코드를 리턴, ret에 값을 저장.
 
    //ret는 out용 parameter 이다.
    //-> 새로운 키워드 제공. out 적고 메서드 종료 전에 값의 할당이 없으면 오류
    static bool Div(int x, int y, out int ret)
    {
        if (y==0)
        {
            ret = 0;
            return true;
        }
        ret = x / y;
        return false;
    }

    static void Main1(string[] args)
    {
        int a = 10, b = 1000;
        //java에서는 swap이 어렵. 사실 C#도 포인터 없어서 C만큼 쉬운거같지는 않음.
        Swap(ref a, ref b);

        //몫을 구하는 메서드 구현하기.
        int ans=0;
        //if (Div(10, 0, ref ans)) Console.WriteLine("Div error");
        //else Console.WriteLine(ans);
        if (Div(10, 0, out ans)) Console.WriteLine("Div error");
        else Console.WriteLine(ans);
    }
}

