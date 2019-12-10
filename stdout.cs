
class Operator2
{
    public static void Main()
    {
        //WriteLine은 값을 출력하고 개행을 한다.
        System.Console.WriteLine(true);
        //Write는 개행을 하지 않는다.
        System.Console.Write("hi");

        System.Console.WriteLine("\"Hello, C#\"");
        System.Console.WriteLine("hi\t hi");
        System.Console.WriteLine("{0},{1}", "Hello", "world");  //C랑 다른점.
        System.Console.WriteLine("{0,10}", "Hello"); //폭을 양수로 주면 오른쪽 정렬
        System.Console.WriteLine("{0,-10}", "Hello"); //폭을 음수로 주면 왼쪽 정렬


        //2. 출력형식
        System.Console.WriteLine("통화 : {0:C}", 123456789);  //원화표시로 뜸. 3칸씩 콤마도 들어감.
        System.Console.WriteLine("지수표기법: {0:E}", 123456789); //지수표기법
        System.Console.WriteLine("실수표기법: {0:F6}", 123456789); //실수표기법 뒤에 숫자쓰면 표현하는 소수점 아래 자리수.
        System.Console.WriteLine("16진수 : {0:X}", 123456789);
        System.Console.WriteLine("자리수 : {0:D8}", 1234); //빈자리는 0으로 채움. 00001234


        //3. 다수의 데이터출력

        int i = 10;
        double d = 3.14;

        //System.Console.WriteLine(i, d); 오류
        //-> WriteLine에서 2개이상의 인자를 받을때 첫번째 인자가 반드시 문자열이어야한다.
        System.Console.WriteLine("{0},{1}", i, d);

        // 문자열 : C#에서는 다른 값에 문자열을 더하면 문자열로 변화된다.
        System.Console.WriteLine(i + ", " + d);

        //C# 6.0 보간문자열
        System.Console.WriteLine($"{i}, {d}");       //$표시를 쓰면 된다.
        System.Console.WriteLine($"{i+d}");          //내부에서 표현식 사용가능.

        //변환출력 (Convert 클래스)
        byte value = byte.MaxValue;
        System.Console.WriteLine(System.Convert.ToString(value, 2));


        // 문자열을 값으로 변경
        string str = "255";
        System.Console.WriteLine(System.Convert.ToInt32(str));
        System.Console.WriteLine(int.Parse(str));

        //실수를 불리언값으로 변경.
        double e = 3.14;
        System.Console.WriteLine(System.Convert.ToBoolean(e));

    }
}

