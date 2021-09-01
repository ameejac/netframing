using System;

namespace oops
{
    class Program
    {

        public void MainFunction()
        {
            Console.WriteLine("Main class");
        }
        static void Main(string[] args)
        {
            //main class instance
            Program obj = new Program();
            obj.MainFunction();


            //other class instace
            demo dObj = new demo();
            dObj.addition();

            ameeja amee = new ameeja();
            amee.subtraction();
        }
    }

    class demo
    {
        int x = 10;
        int y = 20;
        int z;

        public void addition()
        {
            z = x + y;
            Console.WriteLine("other class in Namespace");
            Console.WriteLine(z);
        }
    }

    class ameeja
    { 
        int a = 10;
        int b = 20;
        int z = 0;
        
        public void subtraction()
        {
            z = b - a;
            Console.WriteLine("ameeja");
            Console.WriteLine(z);
        }
    }
}
