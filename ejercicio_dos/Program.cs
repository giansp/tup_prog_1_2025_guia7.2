namespace masmenoscero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num;
            Console.WriteLine("Ingrese un número:");
            num=Convert.ToDouble(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("El número es negativo.");
            }
            else if (num > 0)
            {
                Console.WriteLine("El número es positivo.");
            }
            else
            {
                Console.WriteLine("El número es cero.");
            }
        }
    }
}
