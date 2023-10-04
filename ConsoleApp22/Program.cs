using System;

namespace ConsoleApp22
{
    class program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            string x = Console.ReadLine();
            int ålder = int.Parse(x);

            switch(ålder)
            {
                case 16:
                    {
                        Console.WriteLine("Du får vara med");
                          break;
                    }

                case 17:
                    {
                        Console.WriteLine("Du får vara med");
                          break;
                    }


                case 18:
                    {
                        Console.WriteLine("Du får vara med");
                          break;
                    }


                case 19:
                    {
                        Console.WriteLine("Du får vara med");
                          break;
                    }


                default:
                    {
                        Console.WriteLine("Du får inte vara med");
                        break;
                    }


                


            }

            Console.ReadLine();
        }
       
    }


}