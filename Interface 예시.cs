//using System;
//using System.Text;//for StringBuilder

//interface ILineEdit
//{
//    string ReadLine();
//    bool Checktype(char k);
//}

//class LineEdit : ILineEdit
//{
//    public string ReadLine()
//    {
//        StringBuilder data = new StringBuilder();
//        data.Clear(); //문자열 내용을 삭제합니다.
//        ConsoleKeyInfo cki;
//        while (true)
//        {
//            cki = Console.ReadKey(true);
//            if (cki.Key == ConsoleKey.Enter) break;
//            char ch = cki.KeyChar;
//            if (!Checktype(ch)) continue;
//            data.Append(ch);
//            Console.Write(ch);
//        }
//        Console.WriteLine();
//        return data.ToString();
//    }
//    public virtual bool Checktype(char k) { return true; }
//}

//class AlphaBetLineEdit : LineEdit
//{
//    public override bool Checktype(char k) { return char.IsLetter(k); }
//}

//class DigitLineEdit : LineEdit
//{
//    public override bool Checktype(char k){ return char.IsDigit(k); }
//}


////이와 같이 전체 알고리즘은 그대로 유지한 채 세부 정책을 자식 클래스에게 위임하는 패턴을
////템플릿 메서드 패턴이라고 합니다. 부모 메서드의 흐름은 틀처럼 고정되어 있기 때문입니다.

//class Interface
//{
//    public static void Main()
//    {
//        LineEdit alledit = new LineEdit();
//        DigitLineEdit dedit = new DigitLineEdit();
//        AlphaBetLineEdit aedit = new AlphaBetLineEdit();
//        while (true)
//        {
//            Console.WriteLine(alledit.ReadLine());
//            Console.WriteLine(aedit.ReadLine());
//            Console.WriteLine(dedit.ReadLine());
//        }
//    }
//}



using System;
using System.Text;//for StringBuilder

//이전의 코드는 몇가지 단점이 있는데 첫번째로 런타임에 정책을 바꿀수 없다는 것이다.
//두번째는 상태 정보를 공유할 수 없다. 서로 다른 정책을 가진 객체를 생성하기 때문.
//또한 상속이 깊어지게되면 자칫 클래스가 비대해져 재사용하기 어려워진다.

//인터페이스 기반으로 설계해보자.

interface IValidator
{
    bool Validate(char ch);
}

class LineEdit
{
    StringBuilder data = new StringBuilder();

    //정책을 포함관계로 구현.
    IValidator validator = null;
    public string ReadLine()
    { 
        data.Clear(); //문자열 내용을 삭제합니다.
        ConsoleKeyInfo cki;
        while (true)
        {
            cki = Console.ReadKey(true);
            if (cki.Key == ConsoleKey.Enter) break;
            char ch = cki.KeyChar;
            if (validator == null || validator.Validate(ch))
            {
                data.Append(ch);
                Console.Write(ch);
            }
        }
        Console.WriteLine();
        return data.ToString();
    }
    public void SetValidator(IValidator validator)
    {
        this.validator = validator;
    }
}

class AlphabetValidator : IValidator
{
    public bool Validate(char k) { return char.IsLetter(k); }
}

class DigitValidator: IValidator
{
    public bool Validate(char k) { return char.IsDigit(k); }
}


//이와 같이 전체 알고리즘은 그대로 유지한 채 세부 정책을 자식 클래스에게 위임하는 패턴을
//템플릿 메서드 패턴이라고 합니다. 부모 메서드의 흐름은 틀처럼 고정되어 있기 때문입니다.

class Interface
{
    public static void Main()
    {
        LineEdit alledit = new LineEdit();
        Console.WriteLine(alledit.ReadLine());

        alledit.SetValidator(new DigitValidator());
        Console.WriteLine(alledit.ReadLine());

        alledit.SetValidator(new AlphabetValidator());
        Console.WriteLine(alledit.ReadLine());
    }
}
