using System;

class InvalidPasswordException : Exception
{
    //만약 사용자 메시지를 전달하고 싶다면 부모생성자에 메시지를 전달하면 된다.
    public InvalidPasswordException(string msg) : base(msg) { }
}

class Exception2
{
    static string Input(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }
    static void checkPassword(string psw)
    {
        if(psw!="1234")
        {
            throw new InvalidPasswordException("비번오류");
        }
    }

    public static void Main()
    {
        try
        {
            int n = 4 / 3;
            int[] arr = new int[5];
            arr[2] = 0;
            string psw = Input("psw :");
            checkPassword(psw);
            //오류 발생시 오류 아래의 구문은 시행되지 않는다.

        }
        catch(DivideByZeroException e)
        {
            Console.WriteLine(e);
        }
        catch(IndexOutOfRangeException e)
        {
            Console.WriteLine(e);
        }
        catch(Exception e)      //
        {
            Console.WriteLine(e);
        }
        //만약 특정 예외를 제외한 나머지 예외를 한번에 처리하고 싶다면 exception 타입으로 예외를 잡아준다.
        //단 위에서 부터 내려오면서 확인하니, 맨 아래에 두자.
        finally
        {
            //이 블럭은 예외의 발생과 상관 없이 항상 동작.
        }
    }

}

