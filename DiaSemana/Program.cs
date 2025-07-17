using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        int dia = 20;
        var texto = "20";

        while (dia!=0) {

            Console.WriteLine(value: "Introduce un numero del 1 al 7 ( o 0 para salir):");
            
            texto = Console.ReadLine();
            bool isParsedSuccessfully = Int32.TryParse(texto, out dia);

            switch (dia) {
                case 0:
                    Console.WriteLine("¡Hasta luego!");
                    break;
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miércoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Valor no válido, intenta de nuevo.");
                    break;
            }
        }
    }
}