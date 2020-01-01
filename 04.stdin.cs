
class Stdin
{
    public static void Main()
    {
        //입력된 데이터를 라닝단위로 읽는다.
        //키보드로부터 입력된 모든 데이터는 문자 또는 문자열 타입.
        //string str = System.Console.ReadLine();
        //System.Console.WriteLine(str);
        //위와 같은 방식으로 사용하면 사용이 모호하다.
        //아래처럼 프롬프트(사용자의 명령을 받아들일 준비가 되어있음)
        System.Console.Write("이름을 입력하세요 : ");
        string str = System.Console.ReadLine();
        System.Console.WriteLine(str);
        System.Console.Write("나이를 입력하세요 : ");
        uint age = System.Convert.ToUInt32(System.Console.ReadLine());
        System.Console.WriteLine(age);

        //문자 하나만 입력받기.
        char ch = (char)System.Console.Read();//문자하나만 입력받아서 int로 반환.
        System.Console.WriteLine(ch);

        //버퍼사용하지않고 바로 입력 : readkey


        //커서 위치 설정.
        int x = 40, y = 12;
        while(true)
        {
            System.Console.Clear();
            System.Console.SetCursorPosition(x, y);
            System.Console.Write('#');

            System.ConsoleKeyInfo kinfo = System.Console.ReadKey();
            switch(kinfo.Key)
            {
                case System.ConsoleKey.LeftArrow: --x;break;
                case System.ConsoleKey.RightArrow: ++x; break;
                case System.ConsoleKey.UpArrow: --y; break;
                case System.ConsoleKey.DownArrow: ++y; break;
                case System.ConsoleKey.Q: return;
            }
        }

    }
}

