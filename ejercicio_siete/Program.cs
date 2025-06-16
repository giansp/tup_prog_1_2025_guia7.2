namespace bisiesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anio;
            Console.WriteLine("Ingrese el año");
            anio=Convert.ToInt32(Console.ReadLine());
            if (anio % 4 == 0)
            {
                if (anio % 100 == 0)
                {
                    if (anio % 400 == 0)
                    {
                        Console.WriteLine("El año es bisiesto");
                    }
                    else
                    {
                        Console.WriteLine("El año no es bisiesto");
                    }
                }
                else
                {
                    Console.WriteLine("El año es bisiesto");
                }
            }
            else
            {
                Console.WriteLine("El año no es bisiesto");
            }
        }
    }
}
