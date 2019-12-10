
class Program
{

    static void Main(string[] args)
    {
        //논리 연산자 : 논리 값을 사용하여 연산을 수행하는 연산자.
        //논리곱 연산자. 곱셈과 같은 효과.
        System.Console.WriteLine(true && true);     //true
        System.Console.WriteLine(true && false);    //f
        System.Console.WriteLine(false && true);    //f
        System.Console.WriteLine(false && false);   //f

        //논리합 연산자. 덧셈과 같은 효과
        System.Console.WriteLine(true || true);     //true
        System.Console.WriteLine(true || false);    //t
        System.Console.WriteLine(false || true);    //t
        System.Console.WriteLine(false || false);   //false

        //부정 연산자.
        System.Console.WriteLine(!true);        //f
        System.Console.WriteLine(!false);       //t


        int age;
        bool result;
        age = 0;
        result = true && ((++age) != 0);
        System.Console.WriteLine(age);          //1

        age = 0;
        result = false && ((++age) != 0);
        System.Console.WriteLine(age);          //0

        age = 0;
        result = false || ((++age) != 0);
        System.Console.WriteLine(age);          //1

        age = 0;
        result = true || ((++age) != 0);
        System.Console.WriteLine(age);          //0
    }
}

