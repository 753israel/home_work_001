using Microsoft.VisualBasic;

namespace home_work_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1.כתוב תוכנית שמבקשת מהמשתמש את שמו ומדפיסה:
            //Console.WriteLine("enter a name:");
            //string name = Console.ReadLine();
            //Console.WriteLine($"my name is: {name}");

            ////2.
            ////כתוב תוכנית שמקבלת שני מספרים מהמשתמש ומדפיסה את הסכום שלהם
            //Console.WriteLine("enter a first number :");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter a secund number:");
            //int num2 = int.Parse(Console.ReadLine());
            //int result = num1 + num2;
            //Console.WriteLine($"result is : {num1} + {num2} = {result}");

            //3.בדיקה אם מספר זוגי
            //קבל מספר מהמשתמש והדפס אם הוא זוגי או אי‑זוגי.
            //Console.WriteLine("Enter a number");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 2 == 0)
            //    Console.WriteLine("number is zoggi");
            //else
            //    Console.WriteLine("the number is odd");

            //4.   הדפסת מספרים מ‑1 עד  10 
            //     כתוב לולאה שמדפיסה את המספרים 1–10.
            //for (int i = 1; i <= 10; i++)
            //    Console.WriteLine(i);

            //5.מציאת המספר הגדול מבין שניים
            //קבל שני מספרים והדפס מי הגדול יותר.

            Console.WriteLine("enter a first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a secund number:");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("the number first is big number");
            }
            else
            {
                Console.WriteLine("the number secund is big");
            }
        }
    }
}
