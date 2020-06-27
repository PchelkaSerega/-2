using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ООП_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TV myTV = new TV();
            Console.WriteLine("Введите \"+\", чтобы переключить на следующий канал");
            Console.WriteLine("Введите \"-\", чтобы переключить на следующий канал");
            Console.WriteLine("Введите \"=\", чтобы ввести канал вручную");
            Console.WriteLine("Канал: " + myTV.kanal);
            int kanal;
            while(true)
            {
                char command = char.Parse(Console.ReadLine());
                if (command == '+' | command == '-')
                    myTV.perekl(command);
                else
                if (command == '=')
                {
                    Console.Write("Введите канал вручную: ");
                    kanal = int.Parse(Console.ReadLine());
                    myTV.vvodKanal(kanal);
                }
                else
                    Console.WriteLine("Некорректная команда");
                Console.WriteLine("Канал: " + myTV.kanal);
            }
        }
    }

    class TV
    {
        public int kanal = 1;
        public void perekl(char a)
        {
            if (a == '+')
                kanal++;
            if (a == '-')
                if (kanal > 1)
                kanal--;
        }
        public void vvodKanal(int a)
        {
            if (a > 1)
                kanal = a;
        }
    }
}
