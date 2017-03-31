using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParseTheParcelApp.ParseTheParcelService;

namespace ParseTheParcelApp
{
    class Program
    {
        static void Main(string[] args)
        {

            IParceTheParcel package;
            package = new ParceTheParcelClient();

            Console.WriteLine("Your Package Name: " + package.GetPackageName(210, 280, 130, 20));
            Console.WriteLine("Your Package Cost: " + package.GetPackageCost(210, 280, 130, 20).ToString());
            Console.WriteLine("");

            Console.WriteLine("Your Package Name: " + package.GetPackageName(280,390,180,25));
            Console.WriteLine("Your Package Cost: " + package.GetPackageCost(280, 390, 180, 25).ToString());
            Console.WriteLine("");

            Console.WriteLine("Your Package Name: " + package.GetPackageName(380,550,200,25));
            Console.WriteLine("Your Package Cost: " + package.GetPackageCost(380, 550, 200, 25).ToString());
            Console.WriteLine("");

            Console.WriteLine("Your Package Name: " + package.GetPackageName(410, 600, 500, 25));
            Console.WriteLine("Your Package Cost: " + package.GetPackageCost(410, 600, 500, 25).ToString());
            Console.WriteLine("");
            
            Console.ReadLine();
        }
    }
}
