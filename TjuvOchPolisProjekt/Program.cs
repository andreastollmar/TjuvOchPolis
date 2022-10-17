namespace TjuvOchPolisProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Medborgare medborgare = new Medborgare();
            Stad stad = new Stad();
            //medborgare.Addinventory();
            //medborgare.PrintInventory();
            while (true)
            {
                //stad.PrintCity();
                stad.ListaPoliser();
                Console.ReadKey();
                Console.Clear();
            }
            
            //Tjuv tjuv = new Tjuv();
            //Console.WriteLine(tjuv);
            //Console.WriteLine(medborgare.Name);
        }
    }
}