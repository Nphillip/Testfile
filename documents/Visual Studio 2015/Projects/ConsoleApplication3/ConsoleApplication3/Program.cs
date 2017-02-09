using System;


namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {// Prints the menu and its planets\\
            double ratio = 0.0;
            Console.WriteLine("Menu of Planets");
            Console.WriteLine("==== == =======");
            Console.WriteLine("1.Jupiter, 2.Mars, 3.Mercury");
            Console.WriteLine("4.Neptune, 5.Pluto, 6.Saturn");
            Console.WriteLine("7.Uranus, 8.Venus, 9. <Quit>");
            Console.WriteLine();
            // Created int to store weight and choose their planet 
            int weight = 0;
            //Console.Write("Please enter your weight: ");
            //weight = int.Parse(Console.ReadLine());

            int Enterplanet = 0;
            

            string planets = "";

            while (Enterplanet != 9)
            {
                Console.Write("Choose your planet: ");
                Enterplanet = Convert.ToInt32(Console.ReadLine());


                // This puts a number to the enterplanet and the switch checks which case to follow
                switch (Enterplanet)
                {

                    case 1:
                        Console.Write("enter yout weight");
                        weight = Convert.ToInt32(Console.ReadLine());
                        ratio = 0.37;
                        planets = "mercury";
                        break;

                    case 2:
                        Console.Write("enter yout weight");
                        weight = Convert.ToInt32(Console.ReadLine());
                        ratio = 2.64;
                        planets = "jupiter";
                        break;

                    case 3:
                        Console.Write("enter yout weight");
                        weight = Convert.ToInt32(Console.ReadLine());
                        ratio = 1.12;
                        planets = "neptune";
                        break;

                    case 4:
                        Console.Write("enter yout weight");
                        weight = Convert.ToInt32(Console.ReadLine());
                        ratio = 0.88;
                        planets = "venus";
                        break;

                    case 5:
                        Console.Write("enter yout weight");
                        weight = Convert.ToInt32(Console.ReadLine());
                        ratio = 1.15;
                        planets = "Saturn";
                        break;

                    case 6:
                        Console.Write("enter yout weight");
                        weight = Convert.ToInt32(Console.ReadLine());
                        ratio = 0.04;
                        planets = "pluto";
                        break;

                    case 7:
                        Console.Write("enter yout weight");
                        weight = Convert.ToInt32(Console.ReadLine());
                        ratio = 0.38;
                        planets = "mars";
                        break;

                    case 8:
                        Console.Write("enter yout weight");
                        weight = Convert.ToInt32(Console.ReadLine());
                        ratio = 1.15;
                        planets = "uranus";
                        break;

                    case 9:
                        Console.Write("This program will quit");

                        break;

                        // Below is where the user will be rerouted to choose a planet again 
                    default:
                        Console.WriteLine("Please Choose a planet");
                        Enterplanet = Convert.ToInt32(Console.ReadLine());

                  


                        break;
                }
                // Calculated the users weight by multiplying it by the ratio 
                // Here is where it tells the user how much there weight would be on the planet
                double answer;
                answer = weight * ratio;
                Console.WriteLine("Your weight on " + planets + " will be " + answer);

            }


            
        }
    }
}
 