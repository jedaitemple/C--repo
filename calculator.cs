using System;

namespace ConsoleApp1
{
    class Calculator
    {
        private int a;
        private int b;
        public Calculator(int new_a,int new_b)
        {
            Console.WriteLine("Constructor Called");
            a = new_a;
            b = new_b;

        }
        public int sum()
        {
            int sum = a + b;
            return sum;
        }
        public int sub()
        {
            int sum = a - b;
            return sum;
        }
        public int multiply()
        {
            int sum = a * b;
            return sum;
        }
        public int delenie()
        {
            int sum = a / b;
            return sum;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Calculator c1 = new Calculator(5, 6);
            Console.Write(c1.sum());

        }
    }
}
