using System;

namespace DestCity
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] paths = new string[,] { { "London", "New York" }, { "New York", "Tampa" },
                                        { "Delhi", "London" } };
            string destination = DestCity(paths);
            Console.WriteLine("Q6");
            Console.WriteLine("Destination city is " + destination);
        }
        private static string DestCity(string[,] paths)
        {
            string d = "";
            try
            {

                string[] source = new string[paths.Length];
                string[] destination = new string[paths.Length];
                for (int i = 0; i < 3; i++)
                {
                    source[i] = paths[i, 0];
                    destination[i] = paths[i, 1];
                }
                for (int i = 0; i < 3; i++)
                {
                    int j;
                    for (j = 0; j < 3; j++)
                    {
                        if (destination[i] == source[j])
                            break;
                    }

                    if (j == 3)
                    {
                        d = destination[i];
                    }


                }
                return d;
            }
            catch (Exception)
            {

                throw;
            }


        }


    }
}