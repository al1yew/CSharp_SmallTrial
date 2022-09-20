using System;

namespace Fev10_doma
{
    class Program
    {
        static void Main(string[] args)
        {
            #region (TernaryOperator)
            //int x = 20, y = 10;

            //string result = x > y ? "x is greater than y" : "x is less than y";

            //Console.WriteLine(result);
            #endregion (TernaryOperator)

            #region(PracticeFor)
            //for (int i = 0; i < 10; i++)
            //Console.WriteLine("Value of i: {0}", i);
            #endregion(PracticeFor)

            #region (Switch)

            //int a = 10;

            //switch (a % 3)
            //{
            //case (0):

            //    Console.WriteLine("Qaliq yoxdur");

            //    break;

            //case (1):

            //    Console.WriteLine("Qaliq Birdir");

            //    break;
            //}

            #endregion (Switch)

            #region (If)

            //int x = 10, y = 15, z = 25; //z-deki 25 deyishib 15 yazsam onda axirinci sade else ishledecek

            //if (x > y && x > z)
            //{
            //    Console.WriteLine("X hamisindan boyukdur");
            //}
            //else if (y > x && y > z)
            //{
            //    Console.WriteLine("Y hamisindan boyukdur");
            //}
            //else if (z > x && z > y)
            //{
            //    Console.WriteLine("Z hamisindan boyukdur");
            //}
            //else
            //{
            //    Console.WriteLine("Ededleri yoxlayin, beraberlik movcuddur");
            //}

            #endregion(If)

            #region(Big If istifadeci iki regem daxil edir)

            //evvel sistem bize string kimi deyirki melumati daxil et
           
            Console.WriteLine("Ashagidaki melumatlari qeyd edin.");

            Console.WriteLine("Her hansi regemi daxil et.");
            string a = Console.ReadLine();       // nese daxil etdik 
            int number1 = int.Parse(a);

            Console.WriteLine("Her hansi regemi daxil et.");
            string b = Console.ReadLine();       // nese daxil etdik 
            int number2 = int.Parse(b);

            // sonra biz hemin melumati elde edib convert edirik parse ile integer type-a
            // bize lazimdi ki user iki dene regem daxil etdikde algoritm onu compare elesin.
            // burda loop yoxdu, sade else if ishledirik

            if (number1 > number2)              // birinci daxil edilen regem ikinciden boyuk olsa bunu yazacag
            {
                Console.WriteLine("Hormetli istifadeci, birinci daxil etdiyiniz deyer ikinciden boyukdur.");
            }
            else if (number1 < number2)         //  ikinci daxil edilen regem birinciden boyuk olsa bunu yazacag
            {
                Console.WriteLine("Hormetli istifadeci, ikinci daxil etdiyiniz deyer birinciden boyukdur.");
            }
            else                                // bu ise else-dir, yuxaridaki iki hal odenmese bulari yazacag
            {
                Console.WriteLine("Hormetli istifadeci, sizin daxil etdiyiniz deyerler beraberdir. Xahish edirik bir daha cehd edin.");
            }
            #endregion(Big If istifadeci iki regem daxil edir)  
        }
    }
}