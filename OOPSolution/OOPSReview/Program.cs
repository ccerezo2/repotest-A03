using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSReview
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = 6.5;
            double width = 8.0;
            double linearlength = 135.0;
            string style = "Neighbour Friendly:Spruce";
            double price = 108.00;


            //store the fence data
            //declare a storage area for the fence data
            //create a non static nistance of a class
            //use the new command to create the class instance
            //the new command references the class ocnstructor
            FenceGate gateInfo;
            List<FenceGate> gateList = new List<FenceGate>();
            FencePanel fenceInfo = new FencePanel(height, width, style, price);
            //Assume looping to obtain all gate data
            //Each loop is one gate. 
            //Pass Uno
            fenceInfo = new FencePanel();//systems constructors
            height = 6.25;
            width = 4.0;
            style = "Neighbour friendly: Spruce";
            price = 86.45;
            fenceInfo.Height = height;
            fenceInfo.Width = width;
            fenceInfo.Style = style;
            fenceInfo.Price = price;

            gateInfo = new FenceGate();//systems constructors
            height = 6.25;
            width = 3.25;
            style = "Neighbour friendly: Spruce";
            price = 86.45;
            gateInfo.Height = height;
            gateInfo._Width = width;
            gateInfo.Style = style;
            gateInfo.Price = price;
            gateList.Add(gateInfo);

            gateInfo = new FenceGate();//systems constructors
            height = 6.25;
            width = 4.00;
            style = "Neighbour friendly: Spruce";
            price = 86.45;
            gateInfo.Height = height;
            gateInfo._Width = width;
            gateInfo.Style = style;
            gateInfo.Price = price;
            gateList.Add(gateInfo);

            //cresate estimate
            Estimate theEstimate = new Estimate();
            theEstimate.LinearLength = linearlength;
            theEstimate.Panel = fenceInfo;
            theEstimate.GateList = gateList;
            theEstimate.CalculatePrice();

            //Client wishes an output of the estimate
            Console.WriteLine($"The fence is to be a {0} style",theEstimate.Panel.Style);
            Console.WriteLine($"Total linear length requested {0}", theEstimate.LinearLength);
            Console.WriteLine($"Number of required panels{0}", theEstimate.Panel.EstimatedNumberOfPanels(theEstimate.LinearLength));
            Console.WriteLine($"The number of gates {0}", theEstimate.GateList.Count);
            double fenceArea = theEstimate.Panel.FenceArea(theEstimate.LinearLength);
            foreach(var item in theEstimate.GateList)
            {
                fenceArea += item.FenceGateArea();
            }
            Console.WriteLine($"the fence area is{0:0.00}",fenceArea*2);
            //List<FenceGate> fenceData = new List<FenceGate>();

            //char answer;
            //Console.WriteLine("");
            //Console.ReadKey();
            //Console.WriteLine("░░░░░░░░░░▄▄▀▀▀▀▀▀▀▀▀▄▄░░░░░░░░░░");
            //Console.WriteLine("░░░░░░░░░█░░░░░░░░░░░░░█░░░░░░░░░ ");
            //Console.WriteLine("░░░░░░░░█░░░░░░░░░░▄▄▄░░█░░░░░░░░");
            //Console.WriteLine("░░░░░░░░█░░▄▄▄░░▄░░███░░█░░░░░░░░ ");
            //Console.WriteLine("░░░░░░░░▄█░▄░░░▀▀▀░░░▄░█▄░░░░░░░░ ");
            //Console.WriteLine("░░░░░░░░█░░▀█▀█▀█▀█▀█▀░░█░░░░░░░░ ");
            //Console.WriteLine("░░░░░░░░▄██▄▄▀▀▀▀▀▀▀▄▄██▄░░░░░░░░ ");
            //Console.WriteLine("░░░░░░▄█░█▀▀█▀▀▀█▀▀▀█▀▀█░█▄░░░░░░ ");
            //Console.WriteLine("░░░░░▄▀░▄▄▀▄▄▀▀▀▄▀▀▀▄▄▀▄▄░▀▄░░░░░ ");
            //Console.WriteLine("░░░░░█░░░░▀▄░█▄░░░▄█░▄▀░░░░█░░░░░ ");
            //Console.WriteLine("░░░░░░▀▄▄░█░░█▄▄▄▄▄█░░█░▄▄▀░░░░░░ ");
            //Console.WriteLine("░░░░░░░░▀██▄▄███████▄▄██▀░░░░░░░░ ");
            //Console.WriteLine("░░░░░░░░████████▀████████░░░░░░░░ ");
            //Console.WriteLine("░░░░░░░▄▄█▀▀▀▀█░░░█▀▀▀▀█▄▄░░░░░░░ ");
            //Console.WriteLine("░░░░░░░▀▄▄▄▄▄▀▀░░░▀▀▄▄▄▄▄▀░░░░░░░");
            //Console.WriteLine("You wanted a fence? Y/N");
            //answer = Char.Parse(Console.ReadLine().ToUpper());
            //if (answer == 'Y')
            //{
            //    Console.WriteLine($"░░░░░░░░██████████████████\n░░░░████░░░░░░░░░░░░░░░░░░████\n░░██░░░░░░░░░░░░░░░░░░░░░░░░░░██\n░░██░░░░░░░░░░░░░░░░░░░░░░░░░░██\n██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██\n██░░░░░░░░░░░░░░░░░░░░██████░░░░██\n██░░░░░░░░░░░░░░░░░░░░██████░░░░██\n██░░░░██████░░░░██░░░░██████░░░░██\n░░██░░░░░░░░░░██████░░░░░░░░░░██\n████░░██░░░░░░░░░░░░░░░░░░██░░████\n██░░░░██████████████████████░░░░██\n██░░░░░░██░░██░░██░░██░░██░░░░░░██\n░░████░░░░██████████████░░░░████\n░░░░░░████░░░░░░░░░░░░░░████\n░░░░░░░░░░██████████████");
            //    Console.WriteLine("Nice");
            //}
            //else
            //{
            //    Console.WriteLine($"██████████▀▀▀▀▀▀▀▀▀▀▀▀▀██████████\n█████▀▀░░░░░░░░░░░░░░░░░░░▀▀█████\n███▀░░░░░░░░░░░░░░░░░░░░░░░░░▀███\n██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██\n█░░░░░░▄▄▄▄▄▄░░░░░░░░▄▄▄▄▄▄░░░░░█\n█░░░▄██▀░░░▀██░░░░░░██▀░░░▀██▄░░█\n█░░░██▄░░▀░░▄█░░░░░░█▄░░▀░░▄██░░█\n██░░░▀▀█▄▄▄██░░░██░░░██▄▄▄█▀▀░░██\n███░░░░░░▄▄▀░░░████░░░▀▄▄░░░░░███\n██░░░░░█▄░░░░░░▀▀▀▀░░░░░░░█▄░░░██\n██░░░▀▀█░█▀▄▄▄▄▄▄▄▄▄▄▄▄▄▀██▀▀░░██\n███░░░░░▀█▄░░█░░█░░░█░░█▄▀░░░░███\n████▄░░░░░░▀▀█▄▄█▄▄▄█▄▀▀░░░░▄████\n███████▄▄▄▄░░░░░░░░░░░░▄▄▄███████");
            //    Console.WriteLine("You're gonna have a bad time");
            //}
            Console.ReadKey();
        }

        static List<FencePanel> AddFence(List<FencePanel> fenceData, FencePanel fenceInfo)
        {
            string style;
            double height;
            double width;
            double price= 0;
            char loop = 'y';
            int valid;

            while (loop == 'y')
            {
               
                Console.Write("\nAdd another movie? (y/n): ");
                loop = char.Parse(Console.ReadLine().ToLower());
                Console.Clear();
            }
            return fenceData;
        }
    }
}
