using System;

namespace Lander
{

    class Land
    {

        public string namn, styrestyp, huvudstad; 
        public int invånarantal;
      


        public void Print()
        {
            Console.Write(" "+ namn + "  ");
            Console.Write($"{styrestyp} ");
            Console.WriteLine( huvudstad +"  " + invånarantal);
        }

    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Land sverige = new Land() { namn = "Sverige", styrestyp = "monarki", huvudstad = "Stockholm", invånarantal = 10512820 };
            Land tyskland = new Land() { namn = "Tyskland", styrestyp = "republik", huvudstad = "Berlin", invånarantal = 83783902 };
            Land sanmarino = new Land() { namn = "San Marino", styrestyp = "republik", huvudstad = "San Marino", invånarantal = 33600 };

            sverige.Print();

            Land[] länder = new Land[7] { sverige, tyskland, sanmarino, new Land() { namn = "Dan", styrestyp = "monarki", huvudstad = "Stockholm", invånarantal = 10512820 },
            new Land() { namn = "Ita", styrestyp = "monarki", huvudstad = "Stockholm", invånarantal = 10512820 },
            new Land() { namn = "Tje", styrestyp = "monarki", huvudstad = "Stockholm", invånarantal = 10512820 },
            new Land() { namn = "Run", styrestyp = "monarki", huvudstad = "Stockholm", invånarantal = 10512820 } };


            foreach (Land xx in länder)
            {
                xx.Print();
            }

        }
   
    
    
    
    
    
    }
}