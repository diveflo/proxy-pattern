namespace proxy
{
    internal class RealSubject : Subject
    {
        public void Request(int parameter)
        {
            Console.WriteLine("Real Request");
        }
    }
}
