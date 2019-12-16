using System;

//사용자가 클래스의 생성자를 추가하지 않으면 컴파일러가 기본생성자를 추가하는데
// 이 기본생성자는 매개변수가 없고, 멤버 데이터를 기본 값으로 고히화 한다.
// 정수 0 실수 0 참조변수 null

// 사용자가 생성자를 만들면, 기본생성자를 만들지 않는다.

class Point
{
    public int x, y;
    int[] arr;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    // this constructor : 생성자 옆에 콜론을 사용하여 다른 생성자를 호출하는 기능.
    public Point() : this(0, 0) { }
}


class Program
{
    static void Main(string[] args)
    {
        Point p = new Point();
        Console.WriteLine(p.x);
        Console.WriteLine(p.y);
    }
}
