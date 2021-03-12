using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class BasvuruManeger
    {
        public void Basvuruyap(IKrediManeger krediManeger, ILoggerService loggerService )
        {
            krediManeger.Hesapla();
            loggerService.Log();

        }

        public void KrediOnBilgi(List<IKrediManeger>krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }

        }
    }
}
