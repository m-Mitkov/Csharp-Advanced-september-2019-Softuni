using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Animal tomcat = new Tomcat("tom", 22);
            Console.WriteLine(tomcat);
        }
    }
}
