using System;

namespace Bilblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Carte();
            string s = c.Info();
            Console.WriteLine(s);


            Carte c1 = new Carte("Ion", "Liviu Rebreanu", "MINERVA",10);
            string s1 = c1.ConversieLaSir();
            Console.WriteLine(s1);
            

            var c2 = new Carte("Luceafarul", "Mihai Eminescu", "CANONICA",20,Categorie.Poezie);
            string s2 = c2.Info();
            Console.WriteLine(s2);
            string s3 = c1.ComparaExemplare(c1,c2);

            Carte c3 = new Carte("O scrisoare pierduta", "Ion Luca Caragiale", "REGIS", 15, Categorie.Comedie);
            Console.WriteLine(c3.Info());
            Console.ReadKey();  
        }

        public static Carte CitireCarteTastatura()
        {
            Console.WriteLine("Introduceti numele cartii : ");
            string nume = Console.ReadLine();

            Console.WriteLine("Introduceti autorul cartii : ");
            string autor = Console.ReadLine();

            Console.WriteLine("Introduceti editura cartii : ");
            string editura = Console.ReadLine();

            Console.WriteLine("Introduceti numarul de exemplare:");
            int nrexemplare = Convert.ToInt32( Console.ReadLine() );


            Carte c3 = new Carte(nume, autor, editura,nrexemplare);
            return c3;
        }
    }
}
