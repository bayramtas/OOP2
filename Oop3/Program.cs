using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManeger ihtiyacKrediManeger = new İhtiyacKrediManeger();
            IKrediManeger taşıtKrediManeger = new TaşıtKrediManeger();
            IKrediManeger konutKrediManeger = new KonutKrediManeger();

            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService FileLogerService = new FileLoggerService();

            //BasvuruManeger basvuruManeger = new BasvuruManeger();
            //basvuruManeger.Basvuruyap(konutKrediManeger,  dataBaseLoggerService);

            BasvuruManeger basvuruManeger = new BasvuruManeger();
            basvuruManeger.Basvuruyap(konutKrediManeger, FileLogerService);


            List<IKrediManeger> krediler = new List<IKrediManeger>() {ihtiyacKrediManeger, taşıtKrediManeger,konutKrediManeger  };
            basvuruManeger.KrediOnBilgi(krediler);


        }
    }
}
