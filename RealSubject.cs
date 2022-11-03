namespace proxy
{
    internal class RealSubject : Subject
    {
        public void Request(int parameter)
        {
            var complexResult = parameter * parameter;
            Console.WriteLine($"Real request result {complexResult}");
        }
    }
}
