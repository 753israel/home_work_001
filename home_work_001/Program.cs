using Microsoft.VisualBasic;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

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

            //int num = int.Parse(Console.ReadLine());
            //while (num != 0)
            //{
            //    num = int.Parse(Console.ReadLine());
            //    Console.WriteLine(num);
            //}
            //.11
            //מציאת המספר הגדול מבין 3 מספרים(בלי להשתמש ב‑Math.Max)
            //קבל 3 מספרים מהמשתמש והדפס מי הגדול ביותר.
            //Console.WriteLine("Enter first number:");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter second number:");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter third number:");
            //int num3 = int.Parse(Console.ReadLine());

            //if (num1 > num2 && num1 > num3)
            //{
            //    Console.WriteLine($"The biggest number is: {num1}");
            //}
            //else if (num2 > num1 && num2 > num3)
            //{
            //    Console.WriteLine($"The biggest number is: {num2}");
            //}
            //else if (num3 > num1 && num3 > num2)
            //{
            //    Console.WriteLine($"The biggest number is: {num3}");
            //}
            //else
            //{
            //    Console.WriteLine("Some numbers are equal.");
            //}

            //12.
            //קבל מספר מהמשתמש(למשל 54321)
            //והדפס כמה ספרות יש בו.
            //דוגמה:
            //קלט: 54321
            //פלט: 5 ספרות

            //Console.WriteLine("Enter a number (min 3 digits):");
            //int num = int.Parse(Console.ReadLine());
            //int count = 0;
            //while (num > 0)
            //{
            //    num = num / 10;
            //    count++;
            //}
            //Console.WriteLine($"Number of digits: {count}");

            //כתוב תוכנית ב‑C# שמבקשת מהמשתמש מספרים שוב ושוב, עד שהוא מכניס מספר שלילי.
            //בכל פעם שהמשתמש מכניס מספר חיובי או אפס —
            //התוכנית צריכה:
            //להוסיף אותו לסכום מצטבר
            //לספור כמה מספרים הוזנו
            //להדפיס את המספר שהוזן
            //כאשר המשתמש מכניס מספר שלילי —
            //התוכנית תעצור ותדפיס:
            //          כמה מספרים הוזנו
            //   מה הסכום שלהם
            //מה הממוצע שלהם
            //Console.WriteLine("Enter a positive number (negative to stop):");
            //int num = int.Parse(Console.ReadLine());

            //int sum = 0;
            //int count = 0;

            //while (num >= 0)
            //{
            //    sum += num;
            //    count++;

            //    Console.WriteLine($"You entered: {num}");

            //    num = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine($"Total numbers: {count}");
            //Console.WriteLine($"Sum: {sum}");
            //Console.WriteLine($"Average: {(double)sum / count}");

            //1
            //Console.WriteLine(10);

            //2
            //Console.WriteLine("enter a name:");
            //string s = Console.ReadLine();
            //Console.WriteLine("hello" + " " + s);

            //3


            //int sum = 0;
            //Console.WriteLine("enter a number:");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter a number:");
            //int num2 = int.Parse(Console.ReadLine());
            //sum += num1 + num2;
            //Console.WriteLine($"the total is {sum}");

            //4
            //Console.WriteLine("enter a number");
            //double number = double.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("number is zoggi");
            //}
            //else
            //{
            //    Console.WriteLine("number is odd");
            //}

            //5
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write(i+",");

            //}
            //Console.WriteLine();

            //6

            //int [] s = [572,162,584,555,674];
            //for (int i = 0;i < s.Length; i++)
            //{
            //    Console.WriteLine(s[i]);
            //}

            //7
            //Console.WriteLine("enter a 3 number:");
            //int num1 =int.Parse(Console.ReadLine());
            //int num2 =int.Parse(Console.ReadLine());
            //int num3 =int.Parse(Console.ReadLine());
            //if (num1 > num2 & num1 > num3)
            //    Console.WriteLine("num1 is big" + "" + num1);
            //else if (num2 > num1 & num2 > num3)
            //    Console.WriteLine("num2 is big" + "" + num2);
            //else if (num3 > num1 & num3 > num2)
            //    Console.WriteLine("num3 is big" + "" + num3);
            //else
            //    Console.WriteLine("the number is equal");

            //8
            //string s = Console.ReadLine();
            //int sum = 0;
            //for (int i = 1; i <= s.Length; i++)
            //    sum++;
            //Console.WriteLine(sum);
            //int g = 5; 
            //g = sum1(g);
            //Console.WriteLine(g);
            //Dictionary<string, int> grades = new Dictionary<string, int>();
            //grades.Add("israel", 90);
            //grades.Add("orin", 88);
            //grades.Add("yossi", 50);
            //foreach (var grade in grades)
            //{
            //    Console.WriteLine($"{grade.Value}{grade.Key}");
            //}
            //


            //1. הדפסה בסיסית
            //כתוב תוכנית שמדפיסה את שמך ואת הגיל שלך למסך.
            //Console.WriteLine("enter your name:");
            //string  name = Console.ReadLine();
            //Console.WriteLine("enter your age:");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine($"my name is :{name} my age {age}:");

            //2. חיבור שני מספרים
            // קבל מהמשתמש שני מספרים והדפס את הסכום שלהם.
            //Console.WriteLine("enter a first number:");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter a second number:");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{num1} + {num2} = {num1+num2} ");

            //3. בדיקת מספר זוגי
            //  קבל מספר מהמשתמש ובדוק האם הוא זוגי או אי‑זוגי.
            //Console.WriteLine("enter a number :");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("the number is even");
            //}
            //else
            //{
            //    Console.WriteLine("the number is odd");
            //}

            //4. לולאה שמדפיסה 1 עד 10
            // השתמש בלולאת for כדי להדפיס את המספרים 1–10.
            //for (int i = 1; i <= 10; i++)
            //    Console.WriteLine(i);

            //5. פונקציה שמחזירה את סכום המספרים
            //   כתוב פונקציה Sum(int a, int b) שמחזירה את סכום שני מספרים.
            //Console.WriteLine(sum_number(10,20));

            //6. מחלקה Person
            // צור מחלקה עם:
            // שם
            // גיל
            // פונקציה Introduce() שמדפיסה משפט על האדם.
            //Person p1 = new Person();
            // p1.Name = "israel";
            // p1.Age = 36;
            // p1.Introduce();
            //Person p1 = new Person { Name = "Israel", Age = 36 };
            //p1.Introduce();

            //7. מערך של מספרים
            //  צור מערך של 5 מספרים והדפס את המספר הגדול ביותר.
            //int[] numbers = [10, 15, 26, 2, 9];
            //int max = numbers[0];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > max)
            //        max = numbers[i];
            //}
            //Console.WriteLine(max);

            //8. מחלקה Car
            //מחלקה עם:
            // צבע 
            // מהירות
            // פונקציה Drive() שמדפיסה שהרכב נוסע.
            //Car c1 = new Car("red",100);
            //c1.Drive();

            //9. רשימת מחרוזות
            //   צור List<string> של שמות והדפס את כל השמות בלולאה.
            //List<string> names = new List<string>();
            //names.Add("orin");
            //names.Add("israel");
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //10. מחלקה Calculator
            //צור מחלקה עם פונקציות:
            // Add 
            //Subtract
            //Multiply
            //Divide(כולל בדיקה שלא מחלקים באפס)

            Calculator calc = new Calculator();

            Console.WriteLine(calc.Add(10, 5));
            Console.WriteLine(calc.Subtract(10, 5));
            Console.WriteLine(calc.Multiply(10, 5));
            Console.WriteLine(calc.Divide(10, 5));


        }
        //public static int sum1(int n)
        //{
        //    return n * 2;
        //}
        public static int SumNumber(int a, int b)
        {
            return a + b;
        }
    
    }
}
