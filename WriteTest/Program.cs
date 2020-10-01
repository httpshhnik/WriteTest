using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WriteTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string link = File.ReadAllText("link.txt");

                File.WriteAllText(link, "test");
            }
            catch (Exception ex) {
                File.WriteAllText("error.txt",ex.Message);
            }
        }
    }
}
