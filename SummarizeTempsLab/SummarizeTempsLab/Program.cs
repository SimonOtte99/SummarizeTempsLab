using System;
using System.IO;

namespace SummarizeTempsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename;
            Console.WriteLine("Enter the filename");
            // temperature data is in temps.txt
            filename = Console.ReadLine();

            if (File.Exists(filename))
            {
                Console.WriteLine("The file exists");

                Console.WriteLine("Enter Threshold");
                string input;
                int threshold;
                input = Console.ReadLine();
                threshold = int.Parse(input);

                int sumTemps = 0;
                int numberbelow = 0;
                int numberabove = 0;
                int tempcount = 0;

                using (StreamReader sr = File.OpenText(filename))
                {
                    string line = sr.ReadLine();
                    int temp;
                    while (line != null)
                    {
                        temp = int.Parse(line);
                        sumTemps += temp;
                        tempcount += 1;


                        if (temp >= threshold)
                        {
                            numberabove += 1;

                        }
                        else
                        {
                            numberbelow += 1;

                        }
                        line = sr.ReadLine();
                    }


                    

                }

            }
            else
            {
                Console.WriteLine("The file does not exist");     
            }
                
        }
    }
}
