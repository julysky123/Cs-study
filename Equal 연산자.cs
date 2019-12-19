using System;

class Animal { }
class Dog : Animal { }
class Cat : Animal { }

class aaa : Object { }

class Point
{
    int x, y;
    public override string ToString()
    {
        return $"(x={x}, y={y})";
    }
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    //참조 변수 자체의 값에 대한 비교가 아니라 객체가 가지고 있는 값에 대한 비교를 수행하려면 Equals 메서드를 오버라이딩 하면된다.
    public override bool Equals(object obj)
    {
        if (obj == null) return false;
        Point point = obj as Point;
        if (point == null) return false;

        // 3. 객체가 가진 값을 비교합니다.
        return ((x == point.x) && (y == point.y));
    }

    public static bool operator ==(Point p1, Point p2)
    {
        //if(p1==null || p2==null) 여기서 무한재귀호출. 
        if (ReferenceEquals(p1, null) || ReferenceEquals(p2, null)) return false;
        return ((p1.x == p2.x) && (p1.y == p2.y));
    }
    public static bool operator !=(Point p1, Point p2)
    {
        return !(p1 == p2);
    }

}
class Abstract
{
    public static void Main()
    {

        // C#은 서로 다른 타입을 처리하기 위해 상속을 사용한다.
        Animal[] zoo = { new Dog(), new Cat() };
        // C#은 모든 것이 객체.
        string s = 10.ToString();
        Console.WriteLine(s);

        //모든 것을 객체로 설계한 이유는 Object라는 클래스의 자식으로 구현하기 위함.
        //C#에서 생성된 모든 객체는 암묵적으로 Object라는 클래스를 상속받도록 구현되어있다.

        //따라서 Object 타입으로 배열을 선언하면 모든 타입 저장가능.
        Object[] arr = { 10, 3.14, "hello", new Dog() };

        //1. ToString : 자신에 대한 정보를 문자열로 반환하는 메서드.
        Point p = new Point(1, 3);
        Console.WriteLine(p.ToString()); //오버라이딩 안되어있으면 기본적으로 클래스이름 반환.

        //값 타입에 대하여 비교 연산은 변수가 가진 값을 가지고 비교한다.

        Point p1 = new Point(1, 1);
        Point p2 = new Point(1, 1);
        if (p1 == p2) Console.WriteLine("same");
        else Console.WriteLine("not same");

        if (p1.Equals(p2)) Console.WriteLine("same");
        else Console.WriteLine("not same");

        //예외적으로 참조 타입이지만 비교 연산자를 사용하여 객체가 가진 값을 비교하는 클래스
        // == string 클래스.
        string n1 = "daniel";
        string n2 = "daniel";
        if (n1 == n2) Console.WriteLine("same");
        else Console.WriteLine("not same");

        if (n1.Equals(n2)) Console.WriteLine("same");
        else Console.WriteLine("not same");

        //3. GetHashCode




    }

}

