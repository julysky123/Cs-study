using System;
using static System.Console;    //정적 메서드에 한해서는 클래스 붙이지 않고 사용하게 함.
//정적 멤버 메서드 : 정적 멤버만 접근 가능
//일반 멤버 메서드 : 모든 멤버에 접근 가능

//아래의 클래스는 내부적으로 객체의 솟성을 저장하기 위한 멤버 데이터가 존재하지 않는다.
//이러한 클래스의 경우 굳이 객체를 생성할 필요가 없다.

static class Calculator //static 키워드에 의해 객체생성 금지.
{
    //객체를 생성할 이유가 없으므로 주석.
    //public int Add(int a, int b) { return a + b; }
    //public int Sub(int a, int b) { return a - b; }
    //public int Square(int a) { return a * a; }

    //객체를 생성할수 없게 금지. 생성자를 private으로 만들어버림.
    //하지만 이는 C#이전에 프로그래머가 private 키워드를 이용해 기능을 만들어낸것.
    //Calculator() { }    
    //C#에는 static 키워드를 class 앞에 붙여서 객체 생성을 금지.

    public static int Add(int a, int b) { return a + b; }
    public static int Sub(int a, int b) { return a - b; }
    public static int Square(int a) { return a * a; }
}

//모노스테이트 패턴 : 정적 멤버만 제공하는 클래스
// 예) Convert 클래스.

class Program
{
    static void Main(string[] args)
    {
        //Calculator calc = new Calculator(); //굳이 생성할 필요가없다.
        // Console.WriteLine(calc.Square(2));
        WriteLine(Calculator.Square(2));
        WriteLine(Convert.ToInt32("10"));   //모노스테이트 패턴.

    }
}

