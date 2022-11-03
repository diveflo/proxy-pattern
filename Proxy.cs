namespace proxy
{
    public class Proxy : Subject
    {
        private RealSubject myRealSubject;

        public Proxy()
        {
            myRealSubject = new RealSubject();
        }

        public void Request(int parameter)
        {
            Console.WriteLine($"\nInput parameter: {parameter}");

            myRealSubject.Request(parameter);
        }
    }
}
