using System;

class Class1
{
    // 회원을 등록하는 메서드.
    // 이 때, 나이를 등록하는 것은 선택사항이라고 가정.
    // 선택적 매개변수 또는 기본 매개변수 라는 것을 제공
    static void RegisterMember(string email, string name, int age=0)
    {
        Console.WriteLine(" name: " + name);
        Console.WriteLine(" email: " + email);
        if(age>0) Console.WriteLine(" age: " + age);
    }


    //메서드 오버로딩. 선택적 매개변수와 같이 사용불가.
    //out과 ref에 대한 오버로딩을 할 수 없다.
    static double Square(double x) { return x * x; }
    static int Square(int x) { return x * x; }
    static int Square(ref int x) { return x * x; }

    //가변인자. params int (매개변수의 맨 마지막에만 적을수 있다.)
    static int Add(params int[] values)
    {
        int ret=0;
        foreach(var e in values)
        {
            ret += e;
        }
        return ret;
    }


    public static void Main()
    {
        RegisterMember("hello@world.com", "daniel", 20);
        Console.WriteLine();
        RegisterMember("hello@world.com", "daniel");
        // 명명된 인자 (named parameter) : 매서드 호출 시 ,매개변수의 이름을 사용하여 인자를 전달하는 기능. 
        RegisterMember(age: 30, email: "mj.gwak@samsung.com", name: "MJ");

        Console.WriteLine(Square(2));
        Console.WriteLine(Square(2.4));

        Console.WriteLine(Add(1, 1));
        Console.WriteLine(Add(1, 1,1));
        Console.WriteLine(Add(1, 1,1,1));
    }
}


