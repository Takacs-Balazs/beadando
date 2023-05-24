namespace hazii;
class Program
{


        static void Main(string[] args)
        {
            List<osztaly> Lista = new List<osztaly>();
            using (StreamReader fajl = new StreamReader("kifejezesek.txt"))
            {
                while (!fajl.EndOfStream)
                {Lista.Add(new osztaly(fajl.ReadLine()));}
            }
            Console.WriteLine($"kifejezesek: {Lista.Count}");
            Console.WriteLine($"maradekos osztassal: {Lista.Count(x => x.STRING == "mod")}");
            do
            {
                if (inp != "")
                {try
                    {osztaly muvelet = new osztaly(inp);
                     Console.WriteLine($"\t{muvelet.ToString()}");}
                    catch (Exception)
                    {Console.WriteLine("\tHibás muvelet!");}}
              Console.Write("Adj meg egy muveletet (pl: 9 - 27): ");
              inp = Console.ReadLine();
            } while (inp != "");
            using (StreamWriter end = new StreamWriter("eredmenyek.txt"))
            {Lista.ForEach(x => end.WriteLine(x.ToString()));}
            Console.WriteLine("eredmenyek.txt");
            Console.ReadKey();
        }
    }
