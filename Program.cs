using System;
using System.Collections.Generic;
using System.Linq;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is test application. Hello!");

            //Act
            NumbersMosk mosk = new NumbersMosk();
            Calculator calculator = new Calculator();

            //Act
            calculator.Sum(mosk);
            calculator.Increment(mosk);

            //Assert
            if (mosk.methods.First() == "Sum is Completed" && 
                mosk.methods.Last() == "Increment is Completed")
            {
                Console.WriteLine("Тестирование прошло успешно!");
            }

            Console.ReadLine();
        }

        public class NumbersMosk
        {
            public List<string> methods = new List<string>();

            public int a = 5;
            public int b = 3;

            public int Result;
            public int ResultAfterIncrement;
        }

        public class Calculator
        {
            public void Sum(NumbersMosk numbers)
            {
                numbers.Result = numbers.a + numbers.b;
                numbers.methods.Add("Sum is Completed");
            }
            public void Increment(NumbersMosk numbers)
            {
                numbers.ResultAfterIncrement = ++numbers.Result;
                numbers.methods.Add("Increment is Completed");
            }
        }
    }
}
