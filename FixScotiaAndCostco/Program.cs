using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                string outFilename = @"c:\temp\Converted.ofx";
                using (StreamWriter sw = new StreamWriter(outFilename))
                {
                    using (StreamReader sr = new StreamReader(args[0]))
                    {
                        String line;
                        // Read and display lines from the file until the end of 
                        // the file is reached.
                        while ((line = sr.ReadLine()) != null)
                        {
                            sw.WriteLine(FixLine(line));
                        }
                    }
                }
                //command = string.Format("\"{0}\"", @"C:\Program Files\Microsoft Money 2006\MNYCoreFiles\mnyimprt.exe");
                //string fName = string.Format("\"{0}\"", outFilename);
                //ProcessStartInfo startInfo = new ProcessStartInfo(command);
                //startInfo.Arguments = fName;

                //Process.Start(startInfo);
                //Process.Start(command, fName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(command);
                Console.WriteLine(ex.Message);
                Thread.Sleep(5000);
            }
        }

        private static string FixLine(string original)
        {
            original = original.Replace("&", "&amp;");
            original = original.Replace("<CURDEF>USD</CURDEF>", "<CURDEF>CAD</CURDEF>");
            return original;
        }
    }
}
