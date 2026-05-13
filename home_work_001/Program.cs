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

            //Console.WriteLine("enter a first number:");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter a secund number:");
            //int num2 = int.Parse(Console.ReadLine());
            //if (num1 > num2)
            //    Console.WriteLine($"{num1} is bigger");
            //else if (num2 > num1)
            //    Console.WriteLine($"{num2} is bigger");
            //else
            //    Console.WriteLine("Both numbers are equal");

            //6 .חישוב ממוצע של 3 מספרים
            //קבל מהמשתמש שלושה מספרים והדפס את הממוצע שלהם.

            //Console.WriteLine("enter a first number:");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter a second number:");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter a thred number:");
            //int num3 = int.Parse(Console.ReadLine());
            //int result = num1 + num2 + num3;
            //Console.WriteLine($"result avg is :{result/3}");

            //7. בדיקה אם מספר חיובי, שלילי או אפס
            //קבל מספר מהמשתמש והדפס:
            //"Positive" אם הוא חיובי
            //"Negative" אם הוא שלילי
            //"Zero" אם הוא אפס

            //Console.WriteLine("enter a number im cheek number");
            //int num = int.Parse(Console.ReadLine());
            //if (num > 0)
            //    Console.WriteLine("number is Positive");
            //else if (num < 0)
            //    Console.WriteLine("number is Negative");
            //else
            //    Console.WriteLine("number is Zero");

            ////8.הדפסת כל המספרים הזוגיים מ‑1 עד מספר שהמשתמש נותן
            ////המשתמש מכניס מספר N, ואתה מדפיס את כל המספרים הזוגיים מ‑1 עד N.

            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i < num; i++)
            //{
            //    if (i %2 == 0)
            //    {
            //        Console.WriteLine($"number zoggi:{i}");
            //    }
            //}

            //9.קבלת שם וגיל — והדפסת משפט מותאם
            //קבל שם וגיל מהמשתמש.
            //אם הגיל קטן מ‑18 — הדפס: "Hello {name}, you are a minor"
            //אחרת — "Hello {name}, you are an adult"

            //Console.WriteLine("enter a name:");
            //string name = Console.ReadLine();
            //Console.WriteLine("enter age:");
            //int age = int.Parse(Console.ReadLine());
            //if (age < 18)
            //{
            //    Console.WriteLine($"Hello {name}, you are a minor");
            //}
            //else
            //{
            //    Console.WriteLine($"Hello {name}, you are an adult");
            //}

            //10.   לולאה שמבקשת מספרים עד שהמשתמש מכניס 0
            //בכל פעם שהמשתמש מכניס מספר — הדפס אותו.
            //כאשר הוא מכניס 0 — עצור את התוכנית.

            int num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
                num = int.Parse(Console.ReadLine());
                Console.WriteLine(num);
            }
        }
    }
}
