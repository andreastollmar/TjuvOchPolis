using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvOchPolisProjekt
{
    internal class Stad
    {
        public static string[,] city = new string[25, 100];

        List<Polis> poliser = new List<Polis>();
        //public int checkPolisX = 0;
        //public int checkPolisY = 0;

        //Polis polis = new Polis();
        Tjuv tjuv = new Tjuv();
        Medborgare medborgare = new Medborgare();
        public void ListaPoliser()
        {

            //skapar 20 poliser och skriver ut dom på matrisen City
            for (int i = 0; i < 20; i++)
            {
                Polis polis1 = new Polis();
                poliser.Add(polis1);
                int checkPolisX = polis1.SeePlacementX();
                int checkPolisY = polis1.SeePlacementY();
                city[checkPolisX, checkPolisY] = polis1.Name();
            }
            while (true)
            {
                foreach (Polis polis in poliser)
                {
                    //kollar movement och skriver ut alla poliser på sina respektive platser i matrisen.
                    polis.Movement();                    
                    int checkPolisX1 = polis.SeePlacementX();
                    int checkPolisY1 = polis.SeePlacementY();
                    city[checkPolisX1, checkPolisY1] = polis.Name();
                }
            for (int row = 0; row < city.GetLength(0); row++)
            {
                //ritar ut hela matrisen
                for (int col = 0; col < city.GetLength(1); col++)
                {
                    if (city[row, col] == null)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(city[row, col]);
                    }
                }
                Console.WriteLine();
            } //end for loop
            Console.ReadKey();
                //skriver över all information och raderar positioner.
                for (int row = 0; row < city.GetLength(0); row++)
                {
                    for (int col = 0; col < city.GetLength(1); col++)
                    {
                        city[row, col] = " ";
                    }
                    Console.WriteLine();
                }
                Console.Clear();
        

                
                



            } //end while

        }

        //public void PrintCity()
        //{
        //    while (true)
        //    {
        //        for (int row = 0; row < city.GetLength(0); row++)
        //        {
        //            int checkPolisX = polis.SeePlacementX();
        //            int checkPolisY = polis.SeePlacementY();
        //            if (checkPolisX < 0 || checkPolisX > 25)
        //            {
        //                checkPolisX = polis.SetPlacementzeroX(checkPolisX);
        //            }
        //            else if (checkPolisY < 0 || checkPolisY > 100)
        //            {
        //                checkPolisY = polis.SetPlacementZeroY(checkPolisY);
        //            }
        //            for (int col = 0; col < city.GetLength(1); col++)
        //            {

        //                if (row == checkPolisX && col == checkPolisY)
        //                {
        //                    Console.Write(polis.Name());
        //                }
        //                else
        //                {
        //                    Console.Write(" ");
        //                }
        //            }
        //            Console.WriteLine();

        //        }
        //        polis.Movement();
        //        Console.ReadKey();
        //        Console.Clear();

        //    }


        //    }




    }
}
