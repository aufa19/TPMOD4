using tpmodul4_1302220131;
using static tpmodul4_1302220131.DoorMachine;
using static tpmodul4_1302220131.KodePos;
using System;

namespace tpmodul4_1302220131
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contoh pertama :");
            KodePos kodepos = new KodePos();
            kodepos.setKodePost();
            kodepos.getKodePos();

            Console.WriteLine("\nSoal ketiga :");
            DoorMachine door = new DoorMachine();
            door.run();
        }
    }
}