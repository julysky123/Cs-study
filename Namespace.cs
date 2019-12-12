using System;
using Text;

//네임스페이스 : 프로그램을 구성하는 논리적인 요소들을 묶을수 있는 기능으로
// 이름 충돌을 방지하기 위해 사용한다.

//namespace 네임스페이스명{
//
//}

//using이라는 키워드를 이용하면 자주 사용하는 네임스페이스를 네임스페이스 없이
//사용할 수 있다. 단 파일의 맨 위에 있어야 한다
//but 사용할경우 충돌의 가능성이 높아지니 가급적 쓰지말자.


//구조체: 데이터들의 집합.
//struct Point { int x,y;}
//문장을 저장하기 위한 구조체
namespace Text
{
    struct Line { string name; }
}

// 중첩도 된다.
namespace f
{
    namespace g
    {
        struct H { }
    }
}


//선의 정보를 저장하기 위한 구조체
namespace Graphic
{
    struct Line { int x1, y1, x2, y2; }
}



class Namespace
{
    public static void main1()
    {
        Line a; //네임스페이스를 사용해서 text를 안써도 됨.
        Graphic.Line b;
        f.g.H lll;
    }
}

