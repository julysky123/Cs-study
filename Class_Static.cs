using System;

class Person
{
    public static int count = 0;    //static 멤버변수는 한 영역에만 생성. Class.변수이름 으로 접근.
    string name;        //객체마다 생성.

    public Person() //멤버method는 한 영역에만 생성.
    {
        //클래스로부터 생성된 객체는 클래스의 정보를 공유하므로 
        //클래스의 이름을 사용하지 않고도 정적 멤버 데이터에 접근할 수 있다.

        ++count; // ++Person.count; 라고 써도 됨.이렇게 쓴다면 정적멤버데이터인걸 바로 알수있다.
    }
}


class Static2
{
    public static void Main()
    {
        Person p1 = new Person();
        Person p2 = new Person();
        Person p3 = new Person();
        Console.WriteLine(Person.count);    //클래스의 이름으로 접근.
    }
}
