using System;

namespace Lander
{

    class Land
    {

        public string namn, styrestyp, huvudstad; 
        public int invånarantal;
      


        public void Print()
        {
            Console.WriteLine("Landet: " + namn + "  ");
            Console.WriteLine($"Telefon:   ");
            Console.WriteLine("Adress:  " );
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
 
        }
   
    
    
    
    
    
    }
}