using System;
using System.IO;

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
                string output = "";
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    output += line.Split()[0];
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
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
