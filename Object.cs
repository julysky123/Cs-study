using System;

class Person
{
    //멤버 필드.
    //클래스의 내부는 기본적으로 비공개 속성.
    // 비공개 속성. private (생략가능)
    private string name;
    private int age;

    // 외부에서 쓰려면 비공개 속성을 공개로 변경해야한다.
    // 아래와 같이 클래스 내부의 메서드를 멤버 메서드라고 한다.
    // static을 지운다.

    //setter Method
    public void SetName(string name) { this.name = name;}
    public void SetAge(int age) { this.age = age; }

    //getter Method
    public string GetName() { return name; }
    public int GetAge() { return age; }

    public void Display()
    {
        Console.WriteLine($"name: {this.name}, age : {this.age}");
    }

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}


//캡슐화 (encapsulation).
// 1. 객체의 속성과 행위를 하나로 묶고 실제 구현 내용중 일부를 외부에 감추어 은닉한다.


class Complex
{
    int r;
    int i;

    public Complex(int r,int i){ this.r = r; this.i = i;}
    public void SetReal(int r) { this.r = r; }
    public void SetImage(int i) { this.i = i; }
    public void Display() { Console.WriteLine($"{this.r}+{this.i}j"); }

}


class Object
{
    public static void Main1()
    {
        string name = "daniel";
        int age = 20;

        Console.WriteLine($"name:{name},age: {age}");

        //객체 생성 방법
        // 클래스명 변수명 = new 클래스명();
        Person p = new Person("da",3);
        p.Display();

        Complex c = new Complex(1, 1);
        c.Display();
        c.SetReal(0);
        c.SetImage(0);
        c.Display();
    }
}



