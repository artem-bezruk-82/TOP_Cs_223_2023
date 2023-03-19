namespace hw_04_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product tomato = new Product("Tomato", new Money(56,34));
            Console.WriteLine(tomato);
            try
            {
                tomato.DecreasePrice(new Money(6,45));
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            Console.WriteLine(tomato);
        }
    }
}