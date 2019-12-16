using static System.Console;

//복소수를 처리하는 코드를 구현해 봅시다.
//public static 리턴타입 operator연산자기호 (타입 변수명, 타입변수명) { ...}  //무조건 정적 메쏘드로 만들어야함.
class Complex
{
    double real, image;

    public Complex(double real, double image)
    {
        this.real = real;
        this.image = image;
    }

    //두 복소수를 더하는것이 불편했다. (method 이름을 알아서 호출해야함) -> 연산자 오버로딩.
    //public static Complex Add(Complex c, Complex d)
    //{
    //    // 정적 메서드 안에서는 자신의 타입에 대하여 private 속성에 접근할 수 있다.
    //    Complex result = new Complex(c.real + d.real, c.image + d.image);   //new를 써버리네
    //    return result;
    //}
    public static Complex operator +(Complex c, Complex d)
    {
        return new Complex(c.real + d.real, c.image + d.image);   //new를 써버리네       
    }

    public static Complex operator -(Complex c, Complex d)
    {
        return new Complex(c.real - d.real, c.image - d.image);   //new를 써버리네       
    }

    public static Complex operator *(Complex c, Complex d)
    {
        return new Complex(c.real * d.real - c.image * d.image, 2 * c.image * d.image);   //new를 써버리네       
    }


    public string ToStr()
    {
        string ret;
        if (real != 0 && image == 0) ret = $"{real}";
        else if (real == 0 && image == 0) ret = "0";
        else if (real == 0 && image != 0) ret = $"{image}j";
        else if (image < 0) ret = $"{real}{image}j";
        else ret = $"{real}+{image}j";

        return ret;
    }
}

class Operator
{
    public static void Main1()
    {
        Complex c1 = new Complex(1, 1);
        Complex c2 = new Complex(1, 1);

        Complex c3 = c1 + c2;
        Complex c4 = c1 - c2;
        Complex c5 = c1 * c2;
        c1 += c2;   //복합대입 연산자도 자동으로 오퍼레이터 오버로딩 됨.
        WriteLine(c3.ToStr());
        WriteLine(c4.ToStr());
        WriteLine(c5.ToStr());

        int a = 3;
        int b = 2;
    }
}

// C#에서 오버로딩 안되는 연산자 &&, ||
// 되는것. +, -, *, /, %, \, ^, <<, ==, !=;

//c++에서는 이거 구현이 번거로움.
//++(++C); 참조형으로 리턴돼서 가능.
//(C++)++; 상수형으로 리턴돼서 불가능.
//그런데 c#은 컴파일러에서 하나만 해놓으면 알아서 구현해줌.
