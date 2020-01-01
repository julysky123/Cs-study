
class Type
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("hello, world");
        //부호 있는 타입
        sbyte sb = 10;      //1바이트 정수
        short s = 10;       //2바이트 정수
        int i = 10;         //4바이트 정수
        long l = 10;        //8바이트 정수

        //부호없는 정수타입
        byte b = 10;        //1바이트 정수
        ushort us = 10;     //2바이트 정수
        uint ui = 10;       //4바이트 정수
        ulong ul = 10;      //8바이트 정수
        bool x = (4 > 1);
        System.Console.WriteLine(x);

        //문자저장 : 전세계 언어를 표현하기 위해 유니코드를 사용한다.
        char ch = 'A';
        System.Console.WriteLine(ch);

        //문자열 저장하기 위한 타입.
        string str = "Hello";
        System.Console.WriteLine(str);

        //부동소수점 타입
        float f = 3.14F;        //4바이트 실수(유효범위 : 6~7자리)
        double d = 3.14;        //8바이트 실수(유효범위 : 15~16자리)
        decimal e = 3.14m;      //16바이트 실수(유효범위 : 28~29자리) ->재무나 회계용

        //구조체와 열거형도 제공.

    }
}
