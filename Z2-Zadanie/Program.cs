using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2_Zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SferaEntities())
            {
                Console.WriteLine("Pomieszczenia: ");
                foreach (var item in context.Obiekty.OfType<Pomieszczenie>())
                {                    
                    Console.WriteLine("\t - {0}",item.Nazwa);
                }
                Console.WriteLine("Stand'y: ");
                foreach (var item in context.Obiekty.OfType<Stand>())
                {                    
                    Console.WriteLine("\t - {0}", item.Nazwa);
                }

                var wpis1 = new Poziom
                {
                    Nazwa = "Zerowy",
                    Powierzchnia_całkowita = "1222"
                };
                var wpis2 = new Korytarz
                {
                    Nazwa = "Północny",
                    Powierzchnia_całkowita = "542321",
                    Nazwa_technicza = "Korytarz"
                };
                var wpis3 = new Pomieszczenie
                {
                    Nazwa = "Media Markt",
                    Nazwa_technicza = "sklep AGD RTV",
                    Powierzchnia_całkowita = "31231231",
                    Powierzchnia_wynajmu = 2,
                    Typ_działalności = "Elektornika",
                    Data_początku_wynajmu = DateTime.Now,
                    Data_zakończenia_wynajmu = DateTime.Parse("2015-01-01"),
                    Cena_wynajmu = 312312312
                };
                var wpis4 = new ObiektDoWynajecia
                {
                    Nazwa = "House",
                    Powierzchnia_całkowita = "3123",
                    Typ_działalności = "Odzierz",
                    Cena_wynajmu = 1231235778
                };
                var wpis5 = new PomieszczenieTechniczne
                {
                    Nazwa = "Magazynek",
                    Nazwa_technicza = "Pokój dla ekipy",
                    Powierzchnia_całkowita = "5"
                };
                var wpis6 = new Parking
                {
                    Liczba_miejsc_parkingowych = 2313,
                    Nazwa = "Parking poziom 1",
                    Nazwa_technicza = "Parking piętrowy"
                };
                var wpis7 = new Stand
                {
                    Cena_wynajmu = 200,
                    Nazwa = "Stand obok fontanny",
                    Powierzchnia_całkowita = "2",
                    Typ_działalności = "stand"
                };
                context.Obiekty.Add(wpis1);
                context.Obiekty.Add(wpis2);
                context.Obiekty.Add(wpis3);
                context.Obiekty.Add(wpis4);
                context.Obiekty.Add(wpis5);
                context.Obiekty.Add(wpis6);
                context.Obiekty.Add(wpis7);
                context.SaveChanges();


                ObiektDoWynajecia obiekt = context.Obiekty.OfType<ObiektDoWynajecia>().First(x => x.ID == 1);
                obiekt.Powierzchnia_całkowita = "1000";
                obiekt.Typ_działalności = "Odziez";
                context.SaveChanges();


                context.Obiekty.Remove(wpis1);
                context.Obiekty.Remove(wpis2);
                context.Obiekty.Remove(wpis3);
                context.Obiekty.Remove(wpis4);
                context.Obiekty.Remove(wpis5);
                context.Obiekty.Remove(wpis6);
                context.Obiekty.Remove(wpis7);
                context.SaveChanges();
            }
        }
    }
}
