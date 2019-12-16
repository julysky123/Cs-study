using System;

class TimesTable
{
    //주의! 인덱서는정적으로 구현할 수 없다.
    //foreach 루프에서는 동작하지 않는다.
    public int this[int x, int y] {
        get { return x * y; }
    }
    public double this[double x, double y] {
        get { return x * y; }
    }
}

class II
{
    public int val;
    //사용자 정의 타입인 클래스를 표준출력으로 전송
    //접근지정자 override string ToString();
    public override string ToString() { return val + ""; }
}

class Operator_Overloading5
{
    public static void Main1()
    {
        //2차원배열 생성방법
        //int[,] arr = new int[2,3];
        //arr[0,0]=10;
        //Console.WriteLine(arr[0,0]);

        TimesTable tt = new TimesTable();
        Console.WriteLine(tt[9, 9]);
        Console.WriteLine(tt[9.9, 9.9]);
        
        II i = new II();
        i.val = 10;
        Console.WriteLine(i);   //이걸로 val을 찍고싶다. writeline은 인자로 전달된 객체에 대해 ToString멤버 메서드를 호출한다. 따라서 ToString을 오버로딩한다.


    }
}

