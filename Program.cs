using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

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

                var dict = new Dictionary<int, string>();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    dict.Add(int.Parse(line.Split()[0]), line.Split()[1]);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();

                var list = dict.Keys.ToList();
                list.Sort();

                string output = "";
                for (int i = 0, y = 1; i < dict.Count; i += y)
                {
                    output += dict[list[i]] + " ";
                    y++;
                }

                Console.WriteLine(output);

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
