using System;
using System.Threading;
class Downloader
{
    public static void Download(string url, Action<string, int> callback = null)
    {
        for (int i = 0; i < 21; i++)
        {
            callback?.Invoke(url, i); //델리게이트가 널이 아니면 호출하라는 의미
            Thread.Sleep(400);
        }
    }
}
class Delegate2
{

    static void DisplayPercentage(string url, int amout)
    {
        Console.Write($"\rDownloading {url}: {amout * 5,3}%");
    }
    static void DisplayProgress(string url, int amout)
    {
        char[] progress = { '|', '/', '-', '\\' };
        Console.Write($"\rDownloading {url}: {progress[amout%4]}");
    }


    public static void Main()
    {
       // Downloader.Download("http://www.xxx.com/sing.mp3",DisplayPercentage);
        Downloader.Download("http://www.xxx.com/sing.mp3", DisplayProgress);
        Console.WriteLine("다운로드가 완료되었습니다.");
    }
}

