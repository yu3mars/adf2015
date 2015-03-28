using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace self_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("これはyu3marsの自己紹介用プログラムです。");
            for (; ; )
            {
                string str = Console.ReadLine();
                if (str == "")
                {
                    Console.WriteLine("これはyu3marsの自己紹介用プログラムです。");
                    Console.WriteLine("「h」でヘルプを表示できます。");
                }
                else if (str == "c")
                {
                    Console.WriteLine("時代はConsole!(嘘)");
                    Console.WriteLine("競プロで使っているので…");
                }
                else if (str == "h")
                {
                    Console.WriteLine("c:Consoleを選んだ理由");
                    Console.WriteLine("h:ヘルプ表示");
                    Console.WriteLine("n:名前表示");
                    Console.WriteLine("p:プロ");
                    Console.WriteLine("q:終了");
                    Console.WriteLine("s:進捗どうですか");
                    Console.WriteLine("v:バージョン表示");
                    Console.WriteLine("w:自己紹介表示");
                }
                else if (str == "n")
                {
                    Console.WriteLine("私のハンドルネームは「yu3mars」です。");
                    Console.WriteLine("「ゆーさん」と呼んでください。");
                }
                else if (str == "p")
                {
                    Console.WriteLine("Q「プロですか?」");
                    Console.WriteLine("Q「趣味です」");
                }
                else if (str == "q")
                {
                    Console.WriteLine("さようなら。");
                    Console.WriteLine("Enterキーを押して終了してください。");
                    Console.ReadLine();
                    return;
                }
                else if (str == "s")
                {
                    Console.WriteLine("進捗ダメです。");
                }
                else if (str == "v")
                {
                    Console.WriteLine("Self introduction program of yu3mars used for ADF2015");
                    Console.WriteLine("Version 1.0.0.0");
                    Console.WriteLine("(c) yu3mars");
                }
                else if (str == "w")
                {
                    Console.WriteLine("C#競プロerです!");
                }
                else
                {
                    Console.WriteLine("「{0}」というコマンドはありません。", str);
                    Console.WriteLine("「h」でヘルプを表示できます。");
                }
            }
        }
    }
}
