using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema Cadastro UBS");
            int opc = 0;
            while(opc != 3)
            {
                Console.WriteLine("1-Cadastrar");
                Console.WriteLine("2-Listar");
                Console.WriteLine("3- Sair");
                opc = int.Parse(Console.ReadLine());    
            }
        }
    }
}
