using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace FoxmindedTestApp
{
    public static class Helper
    {
        public static FileAnalizeResult AnalizeFile(string filePath)
        {
            string[] lines = GetFileContent(filePath);

            var result = new FileAnalizeResult
            {
                BrokenLines = new List<string>()
            };

            for (int i = 0; i < lines.Length; i++)
            {
                try
                {
                    double sum = lines[i].Split(",").Sum(l => Double.Parse(l, CultureInfo.InvariantCulture));
                    if (sum > result.MaxSum)
                    {
                        result.MaxSum = sum;
                        result.MaxLineNumber = i + 1;
                    }
                }
                catch
                {
                    result.BrokenLines.Add(lines[i]);
                }
            }

            return result;
        }

        private static string[] GetFileContent(string path)
        {
            string fileContent;
            try
            {
                FileStream fileStream = new FileStream(path, FileMode.Open);
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not found");
                throw ex;
            }

            return fileContent.Split("\r\n");
        }
    }
}
