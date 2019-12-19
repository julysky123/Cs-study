using System;

//추상 메서드 : 구현이 없는 메서드를 추상 메서드.
//추상 메서드가 하나이상 포함되어있는 클래스는 무조건 추상 클래스로 정의해야한다.
abstract class Klass
{
    //c#에서는 메서드를 선언만 할 수 없다. 반드시 정의해야한다.
    public void Foo() { } //OK, 정의

    public abstract void Func(); //error
}

//추상 클래스는 객체를 생성할 수 없다. 클래스의 정보가 완전하지 않기 때문.
//만약 추상 클래스를 객체로 생성하려면 상속을 한 뒤 자식 클래스가 부모의 추상 메서드를 구현하면 된다.
//자식에게 기능을 물려줌과 동시에 특정 기능을 구현하도록 강제한다.



class Child : Klass //만약 child가 추상메서드를 구현하지 않으면 자식도 추상클래스가 된다.
{
    public override void Func()
    {
        Console.WriteLine("hi");
    }
}


class Abstract2
{
    public static void Main()
    {
        //Klass o = new Klass();        //err
        Child a = new Child();
        a.Func();
    }


}

