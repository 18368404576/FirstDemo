using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region System.Console.Read()的使用
            System.Console.WriteLine("System.Console.Read()的使用");
            int i;
            char Read;
            i = System.Console.Read();//System.Console.Read()的值为int型表示读取的字符对应的整数
            Read = (char)i;
            System.Console.WriteLine(i);
            System.Console.WriteLine(Read);
            #endregion
            #region System.Console.ReadKey()方法的使用
            System.Console.WriteLine("System.Console.ReadKey()方法的使用");
            ConsoleKeyInfo cki;
            String m1 = "This example discovers the console and modifier keys " +
                "that you press.\n";
            String m2 = "Press any combination of CTL, ALT, and SHIFT modifier keys, " +
                        "and a console key.\nPress the Escape (Esc) key to quit: ";
            String m3 = "You pressed ";
            String m4 = " (character '{0}').";
            StringBuilder sb = new StringBuilder();
            Console.TreatControlCAsInput = true;
            Console.WriteLine(m1);
            do
            {
                Console.WriteLine(m2);
                sb.Length = 0;
                cki = Console.ReadKey(true);
                sb.Append(m3);
                if (cki.Modifiers != 0)
                {
                    if ((cki.Modifiers & ConsoleModifiers.Alt) != 0)
                        sb.Append("ALT+");
                    if ((cki.Modifiers & ConsoleModifiers.Shift) != 0)
                        sb.Append("SHIFT+");
                    if ((cki.Modifiers & ConsoleModifiers.Control) != 0)
                        sb.Append("CTL+");
                }
                sb.Append(cki.Key.ToString());
                sb.AppendFormat(m4, cki.KeyChar);
                sb.AppendLine().AppendLine();
                Console.WriteLine(sb.ToString());
            }
            while (cki.Key != ConsoleKey.Escape);
            #endregion
            #region 字符串插值
            System.Console.WriteLine("字符串插值");
            ChaZhi();
            #endregion
        }
        public static void ChaZhi()
        {
            string FirstChar;
            string SecondChar;

            System.Console.Write("请输入第一个字符：");
            FirstChar = System.Console.ReadLine();


            System.Console.Write("请输入第二个字符：");
            SecondChar = System.Console.ReadLine();

            System.Console.WriteLine("c#6.0之前的插值写法 复合式格式化you full name is {0}{1}");
            System.Console.WriteLine("you full name is {0}{1}", FirstChar, SecondChar);
            System.Console.WriteLine("c#6.0的插值写法 $ you full name is {FirstChar}{ SecondChar}");
            System.Console.WriteLine($"you full name is {FirstChar}{SecondChar}");
        }
    }
}
