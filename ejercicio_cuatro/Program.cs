namespace mayorvalor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mayor, val;
            Console.WriteLine("Ingrese el valor 1:");
            mayor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor 2:");
            val = Convert.ToDouble(Console.ReadLine());
            if (val>mayor)
            {
                mayor = val;
            }
            Console.WriteLine("Ingrese el valor 3:");
            val = Convert.ToDouble(Console.ReadLine());
            if (val > mayor)
            {
                mayor = val;
            }
            Console.WriteLine("Ingrese el valor 4:");
            val = Convert.ToDouble(Console.ReadLine());
            if (val > mayor)
            {
                mayor = val;
            }
            Console.WriteLine("Ingrese el valor 5:");
            val = Convert.ToDouble(Console.ReadLine());
            if (val > mayor)
            {
                mayor = val;
            }
            Console.WriteLine("El mayor valor es: " + mayor);
        }
    }
}
