using System;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
        } // computer looks for this when you enter dotnet run in cmd line

/*
*Contructor of the class(execs automatically when an isntance is created)
Rules:
-it MUST have the same name as the class
-Is the only Method that DOES NOT contain a return type.
*/


        public Program()
        {
            Console.WriteLine("My First DotNet app");
        }

        public void Test(){
            /*Data Types*/
            //Integer x = 1;
            int age = 99;


            //float
            float gravity = 9.8f;
            //decimal
            decimal money = 12.99m;
            //Boolean
            bool isThisCrazy = true;
            //string
            string text = "this is a string";

            Console.WriteLine("This is my name: William");

            if(money < 50){
                Console.WriteLine("It's cheap!");
            }
            else{
                Console.WriteLine("It's exensive!");
            }

            for(int i =0; i < 9; i++){
                Console.WriteLine("Iteration: " + i);
            }
        }

/**
    Method (function)
    -access level (public/private)
    -so if you don't put public, it will be assumed private.
    -return type (void, int, etc)
    -Name
    -parameters (type name, type name)
*/
        public int SayHello()
        {
            Console.WriteLine("I'm a method");
            bool isRainny = false;
            if(isRainny)
            {
                return 21;
            }
            else
            {
                return 6;
                // System.Console.WriteLine("NOT RETURNING ANYTHING");
                //will not run because you need to return a value everytime
            }
        }
    }
}
