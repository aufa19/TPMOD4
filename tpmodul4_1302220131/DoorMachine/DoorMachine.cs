using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302220131
{
    internal class DoorMachine
    {
        public enum StateKeys { TERBUKA, TERTUTUP, TERKUNCI, QUIT };
        public enum StateKunci { KUNCI, TIDAKKUNCI };

        public void run()
        {
            StateKeys defaults = StateKeys.TERKUNCI;
            String Command = "terbuka";
            while (defaults != StateKeys.QUIT)
            {
                switch (defaults)
                {
                    case StateKeys.TERBUKA:
                        Console.WriteLine("Pintu sudah terbuka");
                        break;
                    case StateKeys.TERKUNCI:
                        Console.WriteLine("Pintu sudah terkunci");
                        break;
                    case StateKeys.QUIT:
                        Console.WriteLine("Keluar");
                        break;
                }
                Console.WriteLine("Masukkan perintah : ");
                Command = Console.ReadLine();

                if (Command == "BukaPintu" || Command == "buka")
                {
                    if (defaults == StateKeys.TERKUNCI)
                    {
                        defaults = StateKeys.TERBUKA;
                    }
                    else
                    {
                        Console.WriteLine("Pintu tidak terkunci");
                    }
                }
                else if (Command == "KunciPintu" || Command == "kunci")
                {
                    if (defaults == StateKeys.TERBUKA)
                    {
                        defaults = StateKeys.TERKUNCI;
                    }
                    else
                    {
                        Console.WriteLine("Pintu terkunci");
                    }
                }
                else if (Command == "quit" || Command == "QUIT")
                {
                    defaults = StateKeys.QUIT;
                }
                else
                {
                    Console.WriteLine("Perintah tidak dikenal");
                }
            }
        }
    }
}