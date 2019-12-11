using System;

class Program
{
    static void Main(string[] args)
    {
        string s = "";
        int num = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <num; i++) Console.WriteLine($"{s+='*'}");

        Console.Clear();
        while(true)
        {
            string c = Console.ReadLine();
            switch(c)
            {
                case "1":
                case "2":
                    Console.WriteLine($"{c}번 메뉴가 선택되었습니다.");
                    break;
                case "0":
                    Console.WriteLine("프로그램을 종료합니다.");
                    break;
                default:
                    Console.WriteLine("잘못 입력했습니다.");
                    break;
            }
            if (c == "0") break;
        }
    }
}

