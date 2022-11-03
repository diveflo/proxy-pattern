// See https://aka.ms/new-console-template for more information
using proxy;

Subject subject = new RealSubject();
subject.Request(100);

Subject proxy = new Proxy();
subject.Request(100);
