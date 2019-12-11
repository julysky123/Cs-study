
class Constant
{
    public static void Main()
    {
        //상수: 그 값이 변하지 않는 데이터를 의미하며 크게 2가지로 나눌 수 있다.
        //1. 심볼릭 상수 : 이름이 있는상수  변수를 상수화한것. const 키워드를 사용한다.
        const double PI = 3.14;
        int radius = 2;
        System.Console.WriteLine(radius * radius * PI); // 3.14;
        

        //2.리터럴(literal) 상수 : 문자 그대로의 값을 의미하며 소스 코드 자체에 존재하게 된다.
        char ch = 'A';  //'A'는 Main method 안에 박혀서 존재.


        // 'A': 문자상수
        // 100 : 정수상수
        // 1.1 : 실수 상수
        // "A" : 문자열상수
        // true : 논리상수

        //상수에도 타입이 존재.
        int i = 10;         //10 : int
        long l = 10L;       //10 : long
        uint ui = 10U;      //10 : unsigned int
        ulong ul = 10UL;    //10 : unsigned long
        float f = 3.14F;    //3.14 : float
        double d = 3.14;    //3.14 : double
        decimal dec = 3.14M;//3.14 : decimal

        //int x = 3.14;     //<-큰타입을 작윽타입에 집어넣으면 에러발생.
        int x = (int)3.14;  //강제 형변환을 하여 저장가능.

        double y = 10;      //가능.

    }

}
