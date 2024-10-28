using Core.DataBS;
using Core.Models;
using System;

namespace NewProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            AppDbContext db = new AppDbContext();

            bool f=false;
            do
            {
                Console.WriteLine("1.Country menu\r\n2.Planet menu\r\n0.Cixis");
                int choice=int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        bool f1=false;
                        do
                        {
                            
                            Console.WriteLine("1.olke yarat\r\n2.olke gor\r\n3.Update country name\r\n4.Evvelki menuya qayit.\r\n0.Exit");
                            choice = int.Parse(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:

                                    db.CreateCountry();
                                    break;

                                case 2:
                                    Console.Write("Enter country id that you want to get: ");
                                    int ID = int.Parse(Console.ReadLine());
                                    db.Getcountry(ID);
                                    break;

                                case 3:
                                    Console.WriteLine("Enter country Id that you want to remove:");
                                    int id=int.Parse(Console.ReadLine());
                                    db.UpdateCountry(id);
                                    break;

                                case 4:
                                    f1 = true;
                                    break;

                                
                                case 0:
                                    f = true;
                                    f1 = true;
                                    break;
                            }


                        } while (!f1);
                        break;


                    case 2:
                        bool f2=false;
                        


                        do
                        {
                            Console.WriteLine("1.planet yarat\r\n2.Butun Planetleri gor\r\n3.Update Planet\r\n4.Planet sec (planetin adini daxil ederek secilecek)\r\n0.Exit");
                            choice = int.Parse(Console.ReadLine());

                            switch (choice) 
                            { 
                                case 1:
                                    db.CreatePlanet();
                                    break;

                                case 2:
                                    db.GetAllPlanets();
                                    break;


                                case 3:
                                    Console.WriteLine("Enter planet name that you want to update:");
                                    int id=int.Parse(Console.ReadLine());
                                    db.UpdatePlanet(id);
                                    break;
                                case 4:
                                    Console.Write("Enter planter name that you want to get: ");
                                    string name=Console.ReadLine();
                                    db.Getplanet(name);
                                    break;

                                case 0:
                                    f=true;
                                    f2 = true;
                                    break;

                            }


                        } while (!f2);

                        break;


                    case 0:
                        f=true;
                        break;
                }


            }while (!f);
        }
    }
}
