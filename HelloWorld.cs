using System;

namespace CSharpHelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            // 1. OUTPUT
            Console.WriteLine("--------- 1. OUTPUT ---------");

            Console.WriteLine("Hello, World!");
            Console.WriteLine("I am Learning C#");
            Console.WriteLine("It is awesome!");

            Console.WriteLine(3 + 3);

            Console.Write("Hello, ");
            Console.WriteLine("I am writing in the same line.");

            // 2. COMMENTS
            // single-line comments
            /* multi-line
            comments */

            // 3. VARIABLES
            Console.WriteLine("--------- 3. VARIABLES ---------");
            string name = "John";
            Console.WriteLine(name);

            int myNum = 15;
            Console.WriteLine(myNum);
            myNum = 20;
            Console.WriteLine(myNum);

            // 3.1 CONSTANTS
            const int myConst = 18;
            //myConst = 20  ERROR!!

            // 3.2 DISPLAY VARIABLES
            Console.WriteLine("--------- 3.2 DISPLAY VARIABLES ---------");
            Console.WriteLine("Hello " + name);

            string firstName = "John ";
            string lastName = "Doe";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);

            int x = 5;
            int y = 6;
            Console.WriteLine(x + y); // Print the value of x + y

            // 3.3 MULTIPLE VARIABLES
            Console.WriteLine("--------- 3.3 MULTIPLE VARIABLES ---------");
            int a = 3, b = 4, c = 5;
            Console.WriteLine(a + b + c);

            int m, n, o;
            m = n = o = 50;
            Console.WriteLine(m);
            Console.WriteLine(m + n + o);

            // 4. DATA TYPES
            Console.WriteLine("--------- 4. DATA TYPES ---------");

            int myInt = 260;
            long myLong = 1500000000L;
            float myFloat = 9.75F;    // 6-7 digits of precision
            double myDouble = 5.95D;  // 15 digits of precision
            char myLetter = 'A';
            string myText = "Hello";
            bool myBool = true;
            Console.WriteLine(myBool);

            // SCIENTIFIC NUMBERS
            float f1 = 35e7F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);

            // 5. TYPE CASTING
            Console.WriteLine("--------- 5. TYPE CASTING ---------");



            Console.WriteLine("--------- 6. USER INPUT ---------");



            


            Console.WriteLine("--------- 7. OPERATORS ---------");




            Console.WriteLine("---------  ---------");




            Console.WriteLine("---------  ---------");
        }
    }
}