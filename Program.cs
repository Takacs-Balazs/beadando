namespace hazii;
class Program
{


        static void Main(string[] args)
        {
            List<osztaly> Lista = new List<osztaly>();
            using (StreamReader fajl = new StreamReader("kifejezesek.txt"))
            {
                while (!fajl.EndOfStream)
                {
                    Lista.Add(new osztaly(fajl.ReadLine()));
                }
            }
            Console.WriteLine($"kifejezesek: {Lista.Count}");
            Console.WriteLine($"maradekos osztassal: {Lista.Count(x => x.STRING == "mod")}");

            int i = 0;
            bool talalat = false;
            do
            {
                talalat = Lista[i].Egyik % 10 == 0 && Lista[i].Masik % 10 == 0;
                i++;
            } while (!talalat);
            Console.WriteLine($"{(talalat ? "Van" : "Nincs")} ilyen kifejezes");
            Console.WriteLine("Statisztika");
            Lista.Where(x => x.STRING == "+" || x.STRING == "-" || x.STRING == "*" || x.STRING == "/" || x.STRING == "mod" || x.STRING == "div").GroupBy(x => x.STRING).ToList().ForEach(y => Console.WriteLine($"\t{y.Key} -> {y.Count()} db"));
            string input = "";
            do
            {
                if (input != "")
                {
                    try
                    {
                        osztaly muvelet = new osztaly(input);
                        Console.WriteLine($"\t{muvelet.ToString()}");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("\tHibás muvelet!");
                    }
                }
                Console.Write("Adj meg egy muveletet (pl: 9 - 27): ");
                input = Console.ReadLine();
            } while (input != "");

            using (StreamWriter end = new StreamWriter("eredmenyek.txt"))
            {
                Lista.ForEach(x => end.WriteLine(x.ToString()));
            }
            Console.WriteLine("eredmenyek.txt");
            Console.ReadKey();
        }
    }
