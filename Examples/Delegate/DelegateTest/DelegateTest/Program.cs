using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    class Program
    {
        //public delegate [return-ValueType] NameOfSignature (Parameters...)


        //public delegate void methodReturnVoidAcceptString(string name);
        //static methodReturnVoidAcceptString methodHolderVoidAndAcceptString;

        public static void PrintHello(string Name)
        {
            Console.WriteLine($"Hello : {Name}");
        }

        //public static void Executor(methodReturnVoidAcceptString function)
        //{
        //    function.Invoke("My Name");
        //}

        public delegate int FunctionReturnIntAccepts2Ints(int x, int y);

        static public int Add(int x,int y)
        {
            Console.WriteLine($"Add: {x + y}");
            return x + y;
        }

        static public int Subtract(int x, int y)
        {
            Console.WriteLine($"Subtract: {x - y}");

            return x - y;
        }

        static public FunctionReturnIntAccepts2Ints ChooseFunction(string operation)
        {
            switch (operation)
            {
                case "+": return Add;
                case "-": return Subtract;
                case "*":return (x, y) =>  // lambda expression
                {
                    Console.WriteLine($"Multiply{x * y}");
                    return x * y;
                };

                 default : return null;
            }
        }

        static void Main(string[] args)
        {
            //methodHolderVoidAndAcceptString = PrintHello;
            //PrintHello("Israel");
            //methodHolderVoidAndAcceptString.Invoke("Danny");
            //methodHolderVoidAndAcceptString("Mike");  //not suggested writing
            //Executor(methodHolderVoidAndAcceptString);


            //FunctionReturnIntAccepts2Ints methodHolder = ChooseFunction("+");
            //Console.WriteLine(methodHolder.Invoke(10, 20));
            //methodHolder = ChooseFunction("-");
            //Console.WriteLine(methodHolder.Invoke(10,20));

            //Console.WriteLine(ChooseFunction("+").Invoke(40,40)); // short example


            //methodHolder = ChooseFunction("*");
            //if (methodHolder != null)
            //{
            //    Console.WriteLine(methodHolder.Invoke(10, 20));
            //}



            //FunctionReturnIntAccepts2Ints MethodHolder = Add;
            //MethodHolder += Subtract;



            //delegate int  FunctionReturnIntAccepts2Ints(int x,int y);
            //FunctionReturnIntAccepts2Ints MethodHolder = Add;
            Func<int, int, int> MethodHolder = Add;
            MethodHolder = Add;
            MethodHolder += Subtract;

            MethodHolder.Invoke(20, 30);
            Console.WriteLine();

            Action<string> methodVoidWrihStringParameter = PrintHello;
            methodVoidWrihStringParameter += PrintHello;
            methodVoidWrihStringParameter.Invoke("Moshe");


            List<int> Numbers = new List<int> { 5, 8, 9 };
            //Numbers.ForEach(x => Console.WriteLine(x));
            Numbers.FirstOrDefault(x => x > 5);

            //Func<int, int> MultiFunc = (int x) => { return x * x; };    //1. lambda expression example
            Func<int, int> MultiFunc = x =>  x * x;     //2. lambda expression example

        }
    }
}
