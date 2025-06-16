namespace ordenmenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double val,menor,posicion;
            Console.WriteLine("Ingresar el valor 1: ");
            val = Convert.ToDouble(Console.ReadLine());
            menor = val;
            posicion = 1;
            Console.WriteLine("Ingresar el valor 2: ");
            val = Convert.ToDouble(Console.ReadLine());
            if (val < menor)
            {
                menor = val;
                posicion = 2;
            }
            Console.WriteLine("Ingresar el valor 3: ");
            val = Convert.ToDouble(Console.ReadLine());
            if (val < menor)
            {
                menor = val;
                posicion = 3;
            }
            Console.WriteLine("Ingresar el valor 4: ");
            val = Convert.ToDouble(Console.ReadLine());
            if (val < menor)
            {
                menor = val;
                posicion = 4;
            }
            Console.WriteLine("Ingresar el valor 5: ");
            val = Convert.ToDouble(Console.ReadLine());
            if (val < menor)
            {
                menor = val;
                posicion = 5;
            }
            Console.WriteLine($"El menor valor es: {menor} y se encuentra en la posicion {posicion}");
        }
    }
}
