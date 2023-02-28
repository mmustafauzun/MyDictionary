namespace MyDictionary
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dictionary<int,string> dictionary = new Dictionary<int,string>();

            dictionary.Add(1,"Mustafa");
            dictionary.Add(2,"Engin");
            dictionary.Add(3,"Kemal");

            for (int i = 0; i < dictionary.NameLenght; i++)
            {
                Console.WriteLine("Sıra No :" + dictionary.CountId[i]+" "+
                                   "Adi : " + dictionary.CountName[i]);
            }
            Console.WriteLine("Mevcut liste sayısı : " + dictionary.NameLenght);
        }
    }
}