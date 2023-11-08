using System;
using System.IO;
using System.Collections.Generic;

namespace PyramidDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("E:\\Development\\PyramidDecoder\\coding_qual_input.txt");
                //Read the first line of text
                line = sr.ReadLine();
                List<int> numbers = new List<int>();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    numbers.Add(int.Parse(line.Split()[0]));
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();

                numbers.Sort();
                string output = "";
                for(int i = 0, y = 1; i < numbers.Count; i=+y)
                {
                    //
                }
                

                //Console.WriteLine(output);

                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

        }
    }
}
