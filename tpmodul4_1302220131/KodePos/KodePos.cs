using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302220131
{

    internal class KodePos
    {
        public String kelurahan;
        public int kodepos;
        public List<KodePos> listKodepost = new List<KodePos>();
        public KodePos(String a = "", int k = 0)
        {
            this.kelurahan = a;
            this.kodepos = k;
        }

        public void setKodePost()
        {
            this.listKodepost.Add(new KodePos("Batununggal", 40266));
            this.listKodepost.Add(new KodePos("Kujangsari", 40287));
            this.listKodepost.Add(new KodePos("Mengger", 40267));
            this.listKodepost.Add(new KodePos("Wates", 40256));
            this.listKodepost.Add(new KodePos("Cijaura", 40287));
            this.listKodepost.Add(new KodePos("Jatisari", 40286));
            this.listKodepost.Add(new KodePos("Margasari", 40286));
            this.listKodepost.Add(new KodePos("Sekejati", 40286));
            this.listKodepost.Add(new KodePos("Kebonwaru", 40272));
            this.listKodepost.Add(new KodePos("Maleer", 40274));
            this.listKodepost.Add(new KodePos("Samoja", 40273));
        }

        public void getKodePos()
        {
            Console.WriteLine("Kelurahan\tKode Pos");
            foreach (KodePos k in this.listKodepost)
            {
                string kelPad = k.kelurahan.PadRight(15);
                Console.Write(kelPad + "\t" + k.kodepos);
                Console.WriteLine();
            }

        }
    }
}