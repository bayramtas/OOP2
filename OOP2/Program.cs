using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Indıvidual ındıvidual1 = new Indıvidual();
            ındıvidual1.Id = 12;
            ındıvidual1.MusteriNo = "12345";
            ındıvidual1.Adı = "Bayram";
            ındıvidual1.Soyadı = "Taş";
            ındıvidual1.TcNo = "123456789";


            //  kodlama

            Coorporate coorporate1 = new Coorporate();
            coorporate1.Id = 45;
            coorporate1.MusteriNo = "54321";
            coorporate1.SirketAdı = "kodlama";
            coorporate1.VergiNo = "159357";


            Customer customer3 = new Coorporate();
            Customer customer4 = new Indıvidual();

            CustomerManeger customerManeger = new CustomerManeger();
            customerManeger.Add(ındıvidual1);
            customerManeger.Add(coorporate1);



        }
    }
}
