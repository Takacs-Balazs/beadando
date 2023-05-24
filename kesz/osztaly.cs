using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hazii
{
    
    internal class osztaly
    {
        int egyik, masik;
        string strng;

        public int Egyik { get => egyik; set => egyik = value; }
        public int Masik { get => masik; set => masik = value; }
        public string STRING { get => strng; set => strng = value; }

        public string eredmeny
        {
           
            {
                try
                {
                    switch (STRING)
                    {
                        
                    }
                }
                catch (Exception)
                {
                    return "hiba!";
                }
            }
        }

        public osztaly(string line)
        {
            string[] data = line.Split(',');
            Egyik = int.Parse(data[0].Trim());
            strng = data[1].Trim();
            Masik = int.Parse(data[2].Trim());
        }

        public override string ToString()
        {
            return $"{Egyik} {STRING} {Masik} = {eredmeny}";
        }
    }
}


