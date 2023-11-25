namespace csharp_exercise_extension_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2020, 10, 10, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}