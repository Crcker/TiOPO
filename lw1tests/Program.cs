using System;
using System.Diagnostics;
using System.IO;

namespace lw1tests
{
    class Testing
    {
        static void Main()
        {
            string filePath = "D:\\TiOPO\\lw1\\bin\\Debug\\netcoreapp3.1\\lw1.exe";
            string testPath = "D:\\TiOPO\\lw1tests\\tests\\test.txt";
            string outPath = "D:\\TiOPO\\lw1tests\\tests\\testout.txt";

            using StreamReader sr = new(testPath);
            using StreamWriter sw = new(outPath);
            
            string inArgs;

            while ((inArgs = sr.ReadLine()) != null)
            {
            
                inArgs = inArgs.Replace('\t', ' ');
                var testArgs = inArgs.Split(' ');
                if (testArgs.Length == 4)
                {
                    string a = testArgs[0];
                    string b = testArgs[1];
                    string c = testArgs[2];
                    string result = testArgs[3];

                    using Process prgram = new();
                    prgram.StartInfo.FileName = filePath;
                    prgram.StartInfo.Arguments = $"{testArgs[0]} {testArgs[1]} {testArgs[2]}";
                    prgram.StartInfo.UseShellExecute = false;
                    prgram.StartInfo.RedirectStandardOutput = true;
                    prgram.Start();

                    StreamReader reader = prgram.StandardOutput;
                    string programResult = reader.ReadLine();
                    string outRes = (programResult == result) ? "success" : "error";
                    sw.WriteLine(outRes);
                }
                else
                {
                    sw.WriteLine("error");
                }              
            }
        }
    }
}
