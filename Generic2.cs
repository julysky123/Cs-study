using System;

//인터페이스에 대해서도 제네릭이 가능.
interface IFoo<T>
{
    T Foo(T x);
}

class Test : IFoo<Test>
{
    public Test Foo(Test x) { return x; }
}

interface IGoo
{
    int Value { get; set; }//인터페이스 안에 프로퍼티 가능.
}

class Goo : IGoo
{
    public int Value {
        get { return 0; }
        set { Value = value; }
    }
}



class Generic3
{
    //인자로 전달된 두 값에 대하여 큰 값을 출력하는 코드를 생각.
    //C#에서 제공하는 대부분의 타입은 IComparable 인터페이스를 구현.
    //이 인터페이스 안에는 int compareTo(object) 메서드가 존재한다.
    //a.compareTo(b)가 있을때
    //a >b 이면 1
    //a==b 이면 0
    //a<b 이면 -1을 반환. 이렇게 동작하는 이유는 문자열 때문.

    //generic을 안써도 모든 오브젝트에 동작할 수 있게 할 수는 있지만, 분기문이 들어간다.
    //static object Max(object a, object b)
    //{
    //    IComparable c1 = a as IComparable;
    //    IComparable c2 = b as IComparable;
    //    if (c1 == null || c2 == null) return null;
    //    return c1.CompareTo(c2) < 0 ? c2 : c1;
    //}

    //분기문 없애는 법.
    static object Max(IComparable a, IComparable b)
    {
        return a.CompareTo(b) < 0 ? b : a;
    }

    //generic으로만들기.
    static T Max<T> (T a, T b) where T : IComparable        //T는 IComparable인 것만 받겠다.
    {
        return a.CompareTo(b) < 0 ? b : a;
    }

    //c#(4.0) dynamic: 피연산자에 타입을 컴파일 타입에 검사하지말고 런타임에 조사하라는 의미.
    static T Square<T>(T x)
    {
        return (dynamic)x * (dynamic)x;     //어차피 런타임에 곱셈이 수행될 애들만 넣을거라면.
    }




    public static void Main1()
    {
      //  Console.WriteLine(Max(new foo(), new foo()));  //불가능.
        Console.WriteLine(Max(1.1, 2.2));
        Console.WriteLine(Max("A", "B"));

        Console.WriteLine(Square(2));
        Console.WriteLine(Square(2.2));
        
    }
}
