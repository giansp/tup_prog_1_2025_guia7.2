namespace Condicion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double condicion,p1,p2,p3,promedio;
            Console.WriteLine("Ingrese condición de promoción");
            condicion = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese las tres notas a a evaluar");
            p1 = Convert.ToDouble(Console.ReadLine());
            p2 = Convert.ToDouble(Console.ReadLine());
            p3 = Convert.ToDouble(Console.ReadLine());
            promedio = (p1 + p2 + p3) / 3;
            if (promedio >=condicion)
            {
                Console.WriteLine("Promociona");
            }
            else
            {
                Console.WriteLine("No promociona");
            }
        }
    }
}
