namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1,num2,num3;
            string nom1, nom2, nom3;
            Console.WriteLine("Ingrese nombre del primer alumno:");
            nom1 = Console.ReadLine();
            Console.WriteLine("Ingrese numero de libreta del primer alumno:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese nombre del segundo alumno:");
            nom2 = Console.ReadLine();
            Console.WriteLine("Ingrese numero de libreta del segundo alumno:");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese nombre del tercer alumno:");
            nom3 = Console.ReadLine();
            Console.WriteLine("Ingrese numero de libreta del tercer alumno:");
            num3 = Convert.ToDouble(Console.ReadLine());
            if (num1 > num2 && num2 > num3)
            {
                Console.WriteLine("Lista ordenada");
                Console.WriteLine($"{nom1} {num1}");
                Console.WriteLine($"{nom2} {num2}");
                Console.WriteLine($"{nom3} {num3}");
            }
            else if (num1 > num3 && num3 > num2)
            {
                Console.WriteLine("Lista ordenada");
                Console.WriteLine($"{nom1} {num1}");
                Console.WriteLine($"{nom3} {num3}");
                Console.WriteLine($"{nom2} {num2}");
            }
            else if (num2 > num1 && num1 > num3)
            {
                Console.WriteLine("Lista ordenada");
                Console.WriteLine($"{nom2} {num2}");
                Console.WriteLine($"{nom1} {num1}");
                Console.WriteLine($"{nom3} {num3}");
            }
            else if (num2 > num3 && num3 > num1)
            {
                Console.WriteLine("Lista ordenada");
                Console.WriteLine($"{nom2} {num2}");
                Console.WriteLine($"{nom3} {num3}");
                Console.WriteLine($"{nom1} {num1}");
            }
            else if (num3 > num1 && num1 > num2)
            {
                Console.WriteLine("Lista ordenada");
                Console.WriteLine($"{nom3} {num3}");
                Console.WriteLine($"{nom1} {num1}");
                Console.WriteLine($"{nom2} {num2}");
            }
            else if (num3 > num2 && num2 > num1)
            {
                Console.WriteLine("Lista ordenada");
                Console.WriteLine($"{nom3} {num3}");
                Console.WriteLine($"{nom2} {num2}");
                Console.WriteLine($"{nom1} {num1}");
            }
          
        }
    }
}
