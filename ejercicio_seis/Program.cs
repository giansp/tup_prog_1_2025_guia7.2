namespace tenis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jug1, jug2;
            int set1j1, set2j1, set3j1;
            int set1j2, set2j2, set3j2;
            int suma1, suma2;
            Console.WriteLine("Ingrese el nombre del jugador 1:");
            jug1 = Console.ReadLine();
            Console.WriteLine("Ingrese el resultado del set 1 del jugador 1:");
            set1j1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el resultado del set 2 del jugador 1:");
            set2j1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el resultado del set 3 del jugador 1:");
            set3j1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del jugador 2:");
            jug2 = Console.ReadLine();
            Console.WriteLine("Ingrese el resultado del set 1 del jugador 2:");
            set1j2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el resultado del set 2 del jugador 2:");
            set2j2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el resultado del set 3 del jugador 2:");
            set3j2 = Convert.ToInt32(Console.ReadLine());
            suma1 = set1j1 + set2j1 + set3j1;
            suma2 = set1j2 + set2j2 + set3j2;
            if (suma1>suma2)
            {
                Console.WriteLine($"El ganador es" + jug1);
            }
            else Console.WriteLine($"El ganador es " + jug2);
        }
    }
}
