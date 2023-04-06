using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloPOO.ConsoleApp
{
    internal class Triangulo
    {
        public int x;
        public int y;
        public int z;
        
        public void VerificarTriangulo()
        {
            if(x < y+z && y < x+y && z < y+x)
            {
                if(x == y && y == z)
                {
                    Console.WriteLine("Triângulo equilátero");
                }
                else if(x == y && y != z || x == z && y != x || y == z && y != x)
                {
                    Console.WriteLine("Triângulo isósceles");
                }
                else
                {
                    Console.WriteLine("Triângulo escaleno");
                }
            }
            else
            {
                Console.WriteLine("Não é um triângulo");
            }
        }
    }
}
