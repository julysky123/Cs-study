
class String
{
    public static void Main()
    {
        //문자열 변수 선언
        string name = "Hello, world!";

        // 문자열 내의 개별 문자 접근을 위해 []연산자를 제공한다.
        System.Console.WriteLine(name[0]);
        System.Console.WriteLine(name[1]);
        System.Console.WriteLine(name[2]);
        System.Console.WriteLine(name[3]);

        // 문자열 길이 정보를 제공한다.
        System.Console.WriteLine(name.Length);

        //수정된 문자열이 반환된다.
        string X = name.Insert(6, "C# ");
        System.Console.WriteLine(name);
        System.Console.WriteLine(X);

        // 문자열 앞 뒤에 패딩을 삽입할 수 있다.
        System.Console.WriteLine("|"+name.PadLeft(15)+"|"); //15칸만큼의 공간에 name을 적는다. 남는공간은 왼쪽에 공백으로
        System.Console.WriteLine("|" + name.PadRight(15) + "|"); //15칸만큼의 공간에 name을 적는다. 남는공간은 오른쪽에 공백으로

        //부분문자열 제거.
        System.Console.WriteLine(name.Remove(5, 7));    //5번째 위치부터 7개 제거.
        System.Console.WriteLine(name.Remove(5));       //5번째 위치부터 끝까지 제거.

        //다른 문자로 치환이 가능.
        System.Console.WriteLine(name.Replace('l', '?'));
        System.Console.WriteLine(name.ToUpper());
        System.Console.WriteLine(name.ToLower());

        //트림 지원
        name = "       Hello, C#!      ";
        System.Console.WriteLine("|" + name.Trim() + "|");
        System.Console.WriteLine("|" + name.TrimStart() + "|");
        System.Console.WriteLine("|" + name.TrimEnd() + "|");

        //분리
        name = "Hello, C#";
        string[] a = name.Split(',');
        System.Console.WriteLine(a[0]);
        System.Console.WriteLine(a[1]);

        //부분문자열 추출.
        name = "Hello, world!";
        System.Console.WriteLine(name.Substring(7,5)); //7번째 위치부터 5개 추출.
        System.Console.WriteLine(name.Substring(7)); //7번째 위치부터 끝까지 추출.

        System.Console.WriteLine(name.Contains("ll")); //해당하는 문자열이 있으면.
        System.Console.WriteLine(name.IndexOf('o'));  //해당하는 문자들중 가장 빠른 인덱스 출력
        System.Console.WriteLine(string.Concat("!@!@!",name));  //두 문자열을 합침

        string copy = string.Copy(name);        //복사.
        System.Console.WriteLine(copy);

        string[] arr = { "apple", "orange", "graph", "pear" };
        string result = string.Join(", ", arr);     //배열의 문자열들을 , 로 연결.
        System.Console.WriteLine(result);


    }
}

