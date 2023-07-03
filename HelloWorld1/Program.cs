namespace HelloWorld1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World First Program");
            //object creation of any class
            Calculator calculator = new Calculator();
            calculator.AdditionOfTwoNumbers();
            calculator.DifferenceOfTwoNumbers();
            Console.ReadLine();
        }
    }
}