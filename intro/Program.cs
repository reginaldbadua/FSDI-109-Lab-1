using System;

namespace intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            new Program();
        }

        //play with the app and C# language
        //constructor of the class

        Program(){
            Console.WriteLine("Hello from C#");

            SayHello(); //exec the method
        }
        //first method
        /*Syntax
            access level (optional)
            return type
            name 
            parameters (optional)
         */
        public string SayHello(){
            Console.WriteLine("Hello from a method");

            return "other";
        }
        //void for not returning anything
        public void DataTypes(){

            //variable syntax:
            /*
                datatypie
                name
                initial value (optional, but recommended)
             */
            int a = 1;
            string name = "Reggie";
            bool found = false; 
            double d = 1.45;

            char c = 'd';
            float f = 1.23f;

            //array in JS
            // var list = []

            string[] names = new string[23];

            if(name == "Reggie"){
                // do something
            }

            //for to fill the array

            for(int j = 0; j < 23; j++){
                //names.push on JS
                //names[0] = "axs";
                names[j] = "Value: " + j;

            }

            for(int i = 0; i <10; i++)
            {
                string item = names[i];
                Console.WriteLine(name);
            }


            

        }
    }
}
