using System;

class If
{
    public static void Main1()
    {
        int input = 20;
        //if(input) // 분기문의 조건식에는 불리언 이외의 다른 값이 올수 없다.

        //널 조건 연산자.
        string name = null; //해당 참조 변수가 아무런 객체를 가지고 있지 않다는 의미.

        //System.Console.WriteLine(name.ToUpper());// <= name이 null이라서 오류

        // if(name.Length >0) // 같은 이유로 오류.
        // {
        //      System.Console.WriteLine(name.ToUpper());
        // }

        //스위치케이스 : case 뒤에 break; 필수. 단 case 안에 코드가 없다면 break 생략 가능.
        int color = Convert.ToInt32(Console.ReadLine());
        switch (color)
        {
            case 0:
            case 1:
            case 2:
                Console.WriteLine("RGB");
                break;
            default:
                Console.WriteLine("잘못 입력했습니다.");
                break;
        }

        //사실 문자열에 대한 분기도 가능.
        string col = Console.ReadLine();
        switch(col)
        {
            case "0":
            case "1":
            case "2":
                Console.WriteLine("RGB");
                break;
            default:
                Console.WriteLine("잘못 입력했습니다.");
                break;
        }
        Console.Write("월을 입력하세요 : ");
        string mon = Console.ReadLine();
        switch (mon)
        {
            case "4":
            case "6":
            case "9":
            case "11":
                Console.WriteLine("30일입니다.");
                break;
            case "2":
                Console.WriteLine("28일입니다.");
                break;
            default:
                Console.WriteLine("31일입니다.");
                break;
        }

    }
}

