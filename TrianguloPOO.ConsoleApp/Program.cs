using TrianguloPOO.ConsoleApp;

internal class Program
{
    private static void Main(string[] args)
    {
        Triangulo triangulo = new Triangulo();

        Console.WriteLine("Informe o valor de x: ");
        triangulo.x = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor de y: ");
        triangulo.y = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor de z: ");
        triangulo.z = int.Parse(Console.ReadLine());

        triangulo.VerificarTriangulo();

    }
}