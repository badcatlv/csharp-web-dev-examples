namespace HelloMethods
{
    public class HelloWorld
    {
        public string message = "Hello World";

        public void SayHello()
        {

            string message = "Goodbye World";

            // The line below prints "Goodbye World"
            Console.WriteLine(message);

            // The line below prints "Hello World"
            Console.WriteLine(this.message);
        }
    }
}
