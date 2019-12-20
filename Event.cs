using System;

class Dialog
{
    public void OpenFile() { Console.WriteLine("파일을 엽니다."); }
    public void CloseFile() { Console.WriteLine("파일을 닫습니다."); }

    public void OnClick()
    {
        
    }
}

class Button
{
    //public interface IOnClickListener { void OnClick(); }
    //IOnClickListener listener = null;
    public Action ClickDelegate { get; set; } = null;
    public void Click() { ClickDelegate?.Invoke(); }
}

class Event
{
    public static void Main()
    {
        Dialog dlg = new Dialog();
        //버튼 테스트
        Button btnClose = new Button();
        btnClose.ClickDelegate=dlg.CloseFile;
        Button btnOpen = new Button();
        btnOpen.ClickDelegate=dlg.OpenFile;
        btnOpen.Click();
        btnClose.Click();
    }
}
