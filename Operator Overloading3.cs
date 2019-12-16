using System;

//public static explicit operator 타입(변수명) {}    //명시적 변환만 허용할때 explicit.
//public static implicit operator 타입(변수명) {}    //암시적도 허용하면 implicit.

    //가급적 명시적 변환을 사용하자.

class Complex
{
    double real, image;
    public Complex(double real, double image)
    {
        this.real = real;
        this.image = image;
    }
    public static explicit operator double(Complex c) { return c.real; }       
}


class Operator_Overloading3
{
    public static void Main1()
    {
        int i = (int)3.14; //형 변환 연산자 또는 타입 캐스팅 연산자.
        Console.WriteLine(i);
        Complex c = new Complex(1, 1);
        double real = (double)c;    //명시적 타입 캐스팅 연산자 호출.
                                    //      double real = c;            //암묵적 타입 캐스팅 연산자 호출. 
        Console.WriteLine(real);

    }
}

