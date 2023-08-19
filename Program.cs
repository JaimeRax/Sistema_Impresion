using System;

// Interfaces segregadas para diferentes formatos de documentos
public interface IPrintable
{
    void Print();
}



/*

    Crear interfaz para cada tipo de archico

*/





// Clases que implementan las interfaces según el formato de documento



/*

    Crear clase para implementar las interfaces

*/









// Cliente que utiliza el sistema de impresión
public class PrintClient
{
    public void PrintDocument(IPrintable document)
    {
        document.Print();
    }
}
class Program
{
    static void Main(string[] args)
    {
        /* 
            Crear una instancia hacia su interfaz
        */
        while (true)
            {
                Console.WriteLine("Selecciona el tipo de archivo a imprimir:");
                Console.WriteLine("1. PDF");
                Console.WriteLine("2. Word");
                Console.WriteLine("3. Excel");
                Console.WriteLine("4. Salir");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        /* llamar a la clase PrintClient ya creada e implementar la clase que crearon ustedes., ejemplo:

                         PrintClient printClient = new PrintClient();
                         printClient.PrintDocument(pdfDocument); */
                        break;
                    case "2":
                        ImprimirWord();
                        break;
                    case "3":
                        ImprimirExcel();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, selecciona una opción válida.");
                        break;
                }
            }
    }
}