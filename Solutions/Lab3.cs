
using System;


namespace lesson1.Solutions
{
    class Lab3
    {
         public void Problem1()
        {
            System.Console.WriteLine("Solution1 :");
            System.Console.Write("Enter number: ");
            var line = Console.ReadLine();
            var data = line.Split(' ');
            var a = int.Parse(data[0]);
		    char ch = (char)a;

            System.Console.WriteLine($"Natija (int): {a}");
		    Console.WriteLine($"Natija (char): {ch}");
        }



        public void Problem2()
        {
           
            System.Console.Write("Enter width: ");
            int b = int.Parse(Console.ReadLine());

            System.Console.Write("Enter lenght: ");
            int a = int.Parse(Console.ReadLine());

            var c = a * b;
            System.Console.WriteLine($"Area is {c}");
        }

        public void Problem3()
        {
           
            System.Console.Write("Enter real width number: ");
            float b = float.Parse(Console.ReadLine());

            System.Console.Write("Enter real lenght number: ");
            float a = float.Parse(Console.ReadLine());

            var c = a * b;
            System.Console.WriteLine($"Area is {c}");
        }
        
        
        public void Problem4()
        {
            System.Console.Write("Enter a real number: ");
            float b = float.Parse(Console.ReadLine());

            int a = (int)Math.Round(b);
            System.Console.WriteLine($"Round off: {a}");
        }

        public void Problem5()
        {

            System.Console.WriteLine("Enter lower case:");
            char a = char.Parse(Console.ReadLine());

            if(Char.IsLower(a))
            {
                System.Console.Write("Upper case: ");
                Console.WriteLine(Char.ToUpper(a));
            }
        }
        public void Problem6()
        {

            System.Console.WriteLine("Enter Upper case : ");
            char b = char.Parse(Console.ReadLine());

            if(Char.IsUpper(b))
            {
                System.Console.WriteLine("Lower case :");
                Console.WriteLine(Char.ToLower(b));
            }
            
        }


    }
}