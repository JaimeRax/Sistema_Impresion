using System;

// Interfaces segregadas para diferentes formatos de documentos
public interface IPrintable
{
    void Print();
}
public interface IPdfPrintable : IPrintable
{
    void PrintPdf();
}


public interface IWordPrintable : IPrintable
{
    void PrintWord();
}
public interface IExcelPrintable : IPrintable
{
    void PrintExcel();
}


// Clases que implementan las interfaces según el formato de documento
public class PdfDocument : IPdfPrintable
{
    public void Print()
    {
        PrintPdf();
    }

    public void PrintPdf()
    {
        Console.WriteLine();
        Console.WriteLine("Imprimiendo documento PDF...");
        Console.WriteLine();
    }
}


public class WordDocument : IWordPrintable
{
    public void Print()
    {
        PrintWord();
    }

    public void PrintWord()
    {
        Console.WriteLine();
        Console.WriteLine("Imprimiendo documento Word...");
        Console.WriteLine();
    }
}
public class ExcelDocument : IExcelPrintable
{
    public void Print()
    {
        PrintExcel();
    }

    public void PrintExcel()
    {
        Console.WriteLine();
        Console.WriteLine("Imprimiendo documento Excel...");
        Console.WriteLine();
    }
}

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
        IPdfPrintable pdfDocument = new PdfDocument();
        IWordPrintable wordDocument = new WordDocument();
        IExcelPrintable excelDocument = new ExcelDocument();
        
        PrintClient printClient = new PrintClient();

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
                       // PrintClient printClient = new PrintClient();
                        printClient.PrintDocument(pdfDocument);
                        break;
                    case "2":
                       // PrintClient printClient = new PrintClient();
                        printClient.PrintDocument(wordDocument);
                        break;
                    case "3":
                       // PrintClient printClient = new PrintClient();
                        printClient.PrintDocument(excelDocument);
                       
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