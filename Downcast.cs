using System;


class Animal { virtual public void Cry() { Console.WriteLine("멍냐옹"); } }    // 아직 진도 안나갔는데 virtual 추가해봄.

class Dog : Animal { public override void Cry() { Console.WriteLine("멍멍!"); } }
class Cat : Animal { public override void Cry() { Console.WriteLine("냐옹~"); } }


class DownCast
{
    public static void Main1()
    {
        Animal[] box = { new Dog(), new Cat(), new Animal() };    //UpCasting
        //업캐스팅은 캐스팅 연산자를 생략할 수 있다. 컴파일러가 컴파일 타임에 둘의 관계를 알 수 있기 때문.

        Dog d = (Dog)box[0];    //DownCasting
        // 부모타입에서는 Cry메서드가 없으므로 호출할 수가 없다.. 다운캐스팅은 새스팅 연산자를 생략할 수 없다.
        // 컴파일러가 부모 타입의 참조 변수에 어떠한 자식 객체를 가지고 있는지 알수 없기 때문.


        box[0].Cry();
        box[1].Cry();
        box[2].Cry();
    }

}

