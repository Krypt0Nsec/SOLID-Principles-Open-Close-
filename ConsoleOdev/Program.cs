
namespace ConsoleOdev
{
    public abstract class Program
    {
        static void Main(string[] args)
        {
            

            var logger = new Logger();

            var result = logger.Log(new DbLog());

            Console.WriteLine(result + $" 303 nolu hata kodu {result}'a kaydedildi");


        }
    }
}