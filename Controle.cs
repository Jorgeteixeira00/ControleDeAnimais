using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAnimais
{
    class Controle
    {
        public void Iniciar()
        {
            Animal a1 = new();
            Animal a2 = new();
            Animal a3 = new(); 
            int tCachorro = 0, tGato = 0, tPeixe = 0;

            Console.WriteLine("Controle de animais");
            Console.Write("Informe o nome do 1° animal:");
            a1.name = Console.ReadLine();
            Console.Write("Informe o tipo do 1° animal (Cachorro, Gato ou Peixe):");
            a1.type = Console.ReadLine().ToUpper();

            if (a1.type == "CACHORRO") tCachorro++;
            if (a1.type == "GATO") tGato++;
            if (a1.type == "PEIXE") tPeixe++;

            //2° ANIMAL
            Console.WriteLine("Controle de animais");
            Console.Write("Informe o nome do 2° animal:");
            a2.name = Console.ReadLine();
            Console.Write("Informe o tipo do 2° animal (Cachorro, Gato ou Peixe):");
            a2.type = Console.ReadLine().ToUpper();

            if (a2.type == "CACHORRO") tCachorro++;
            if (a2.type == "GATO") tGato++;
            if (a2.type == "PEIXE") tPeixe++;

            //3° ANIMAL
            Console.WriteLine("Controle de animais");
            Console.Write("Informe o nome do 3° animal:");
            a3.name = Console.ReadLine();
            Console.Write("Informe o tipo do 3° animal (Cachorro, Gato ou Peixe):");
            a3.type = Console.ReadLine().ToUpper();

            if (a3.type == "CACHORRO") tCachorro++;
            if (a3.type == "GATO") tGato++;
            if (a3.type == "PEIXE") tPeixe++;

            Console.WriteLine("Total de animais:");
            Console.WriteLine($"Cachorros:{tCachorro}");
            Console.WriteLine($"Gatos:{tGato}");
            Console.WriteLine($"Peixes:{tPeixe}");
        }
    }
}
