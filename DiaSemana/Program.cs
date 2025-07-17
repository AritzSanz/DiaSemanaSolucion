internal class Program
{
    private static void Main(string[] args)
    {
        int dia = 20;
        var texto = "20";

        while (dia!=0) {

            Console.WriteLine(value: "Introduce un numero del 1 al 7 ( o 0 para salir):");
            
            texto = Console.ReadLine();
            dia = Int32.Parse(texto);

            switch (dia)
            {
                case 0:
                    Console.WriteLine("¡Hasta luego!");
                    break;
                case 1:
                    Console.WriteLine("Lunes");
                    continue;
                case 2:
                    Console.WriteLine("Martes");
                    continue;
                case 3:
                    Console.WriteLine("Miércoles");
                    continue;
                case 4:
                    Console.WriteLine("Jueves");
                    continue;
                case 5:
                    Console.WriteLine("Viernes");
                    continue;
                case 6:
                    Console.WriteLine("Sabado");
                    continue;
                case 7:
                    Console.WriteLine("Domingo");
                    continue;
                default:
                    Console.WriteLine("Valor no válido, intenta de nuevo.");
                    continue;
            }


        }
    }
}